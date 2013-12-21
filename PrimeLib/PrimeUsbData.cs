﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PrimeLib
{
    /// <summary>
    /// Class that represents a data ready to be sent to the calculator thru the USB or saved
    /// </summary>
    public class PrimeUsbData
    {
        private readonly PrimeParameters _settings;
        private readonly Dictionary<PrimeUsbDataType, PrimeUsbDataHeader> _headers = GetHeaders();
        private bool _isComplete;
        private byte[] _data;
        private const string EncodePrefix = "____[", EncodePostfix = "]____";

        private static Dictionary<PrimeUsbDataType, PrimeUsbDataHeader> GetHeaders()
        {
            var t = new List<PrimeUsbDataHeader>(new[]
            {new PrimeUsbDataHeader {Header = new byte[]{0x00, 0x00, 0xf7, 0x01}, Type = PrimeUsbDataType.File},
            new PrimeUsbDataHeader {Header = new byte[]{0x00, 0x00, 0xf2, 0x01}, Type = PrimeUsbDataType.Message}});

            return t.ToDictionary(header => header.Type);
        }

        /// <summary>
        /// Type of the data
        /// </summary>
        public PrimeUsbDataType Type { get; private set; }

        /// <summary>
        /// Name of the script represented by this data
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Contents of the script in UTF-16, without any header 
        /// </summary>
        public byte[] Data
        {
            get { return _data; }
            private set 
            { 
                // Special data processing
                if (_settings != null && _settings.GetFlag("EnableAdditionalProgramProcessing"))
                {
                    var regexStrings = new Regex(_settings.GetValue("RegexStrings"));
                    var regexComments = new Regex(_settings.GetValue("RegexComments"));

                    var tmp = Encoding.Unicode.GetString(value);

                    // Encode strings and comments
                    tmp = regexStrings.Replace(tmp, EncodeElement);
                    tmp = regexComments.Replace(tmp, _settings.GetFlag("RemoveComments") ? (m => String.Empty) : (MatchEvaluator)EncodeElement);

                    if (_settings.GetFlag("CompressSpaces"))
                    {
                        var o = new StringBuilder();
                        foreach (var l in tmp.Replace(Environment.NewLine,"\n").Replace("\r",String.Empty).Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries))
                        {
                            var line = l.Trim(new [] {' ', '\t'});

                            // Spaces near operators
                            foreach (var c in " \"'+/*-^@!:;,.?%=(){}[]|")
                            {
                                var nline = line;
                                do
                                {
                                    line = nline;
                                    nline = line.Replace(" " + c, String.Empty+c).Replace(c + " ", String.Empty+c);
                                } while (line.CompareTo(nline) != 0);
                            }

                            o.Append(line);

                            if (!String.IsNullOrEmpty (line) && !line.EndsWith(";"))
                                o.Append('\n');
                        }
                        tmp = o.ToString();
                    }

                    if (_settings.GetFlag("ObfuscateVariables"))
                    {

                    }

                    // Restore string and comments again
                    tmp = Regex.Replace(tmp,Regex.Escape(EncodePrefix) + "(?<data>" + _settings.GetValue("RegexBase64") + ")" + Regex.Escape(EncodePostfix),DecodeElement);
                    _data = Encoding.Unicode.GetBytes(tmp);
                }
                else
                    _data = value; 
            }
        }

        private static string DecodeElement(Match match)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(match.Groups["data"].Value));
        }

        private static string EncodeElement(Match match)
        {
            return EncodePrefix + Convert.ToBase64String(Encoding.Unicode.GetBytes(match.Value)) + EncodePostfix;
        }

        /// <summary>
        /// Initializes a usb file that represents a message
        /// </summary>
        /// <param name="message">Text message</param>
        /// <param name="chunkSize">Chunk size to split the data</param>
        /// <param name="settings">Settings for handling the data</param>
        public PrimeUsbData(String message, int chunkSize, PrimeParameters settings)
        {
            _settings = settings;
            Name = null;
            Data = Encoding.Unicode.GetBytes(message);
            Type = PrimeUsbDataType.Message;
            IsValid = true;
            IsComplete = true;

            Chunks = new List<byte[]>();

            // Prepare the header
            var fullData = new List<byte>(_headers[PrimeUsbDataType.Message].Header);

            // Size
            var size = BitConverter.GetBytes(Data.Length + _headers[PrimeUsbDataType.Message].Header.Length-2);

            // Combining all fields
            fullData.AddRange(size.Reverse());
            fullData.AddRange(Data);

            GenerateChunks(fullData, chunkSize);
        }

        private void GenerateChunks(List<byte> data, int chunkSize)
        {
            if (chunkSize <= 2)
                return;

            int position = 0, chunk = 0;

            // Add missing padding zeros
            var allBytes = data.Concat(new byte[data.Count() % chunkSize]).ToArray();
            if (chunkSize > 0)
                do
                {
                    IEnumerable<byte> tmp = new[] {(byte) 0x00, (byte) (chunk++%byte.MaxValue)};
                    Chunks.Add(tmp.Concat(allBytes.SubArray(position == 0 ? 2 : position,
                            Math.Min(chunkSize - 2, allBytes.Length - position))).ToArray());
                    position += chunkSize - (position == 0 ? 0 : 2);
                } while (position < allBytes.Length);
        }

        /// <summary>
        /// Initializes a usb that represents a program file
        /// </summary>
        /// <param name="name">Name of the script</param>
        /// <param name="data">Contents of the script in UTF-16, without any header</param>
        /// <param name="chunkSize">Chunk size to split the data</param>
        /// <param name="settings">Settings for handling the data</param>
        public PrimeUsbData(string name, byte[] data, int chunkSize, PrimeParameters settings)
        {
            _settings = settings;
            Name = name;
            Data = data;
            IsValid = true;
            IsComplete = true;
            Type = PrimeUsbDataType.File;

            Chunks = new List<byte[]>();

            // Prepare the header
            var fullData = new List<byte>(_headers[PrimeUsbDataType.File].Header);

            // Name
            var nameBytes = Encoding.Unicode.GetBytes(name);

            // Size
            var size = BitConverter.GetBytes(Data.Length + nameBytes.Length + _headers[PrimeUsbDataType.File].Header.Length + 1);

            // Combining all fields
            fullData.AddRange(size.Reverse());
            fullData.Add(0x06);
            fullData.Add((byte) nameBytes.Length);
            fullData.AddRange(new byte[] {0x94, 0xdd}); // CRC
            fullData.AddRange(nameBytes);
            fullData.AddRange(Data);

            GenerateChunks(fullData, chunkSize);
        }

        /// <summary>
        /// Returns the file validity (first Chunk header matches with expected header)
        /// </summary>
        public bool IsValid { get; private set; }

        /// <summary>
        /// Checks (only until completion, then only returns true) if the file is valid and complete, isValid is true and all chunks matches with the parameters defined in the header
        /// </summary>
        public bool IsComplete
        {
            get 
            {
                CheckForValidity();
                return _isComplete; 
            }

            private set { _isComplete = value; }
        }

        /// <summary>
        /// Initializes a usb data received or ready to send, with the first chunk already defined, and checks the validity and completioness
        /// </summary>
        /// <param name="chunkData">Chunk data without the first byte (as is received from the USB)</param>
        /// <param name="settings">Settings for handling the data</param>
        public PrimeUsbData(IEnumerable<byte> chunkData, PrimeParameters settings = null)
        {
            _settings = settings;
            Name = null;
            Type = PrimeUsbDataType.Unknown;
            var b = new byte[] {0x00};
            Chunks = new List<byte[]>(new []{b.Concat(chunkData).ToArray()});
            CheckForValidity();
        }

        private void CheckForValidity(bool force = false)
        {
            if (_isComplete && !force)
                return;

            IsValid = false;
            IsComplete = false;
            if (Chunks.Count <= 0) return;

            var tmp = Chunks.Aggregate<byte[], IEnumerable<byte>>(null, (current, b) => current == null ? b : current.Concat(b)).ToArray();

            // Check the header
            Type = PrimeUsbDataType.Unknown;
            foreach (var _header in _headers)
            {
                if (tmp.Length < _header.Value.Header.Length || _header.Value.Header.Where((t, i) => tmp[i] != t).Any())
                    continue;

                Type = _header.Value.Type; // Valid type
                break;
            }

            var size=0;
            switch (Type)
            {
                case PrimeUsbDataType.Message:
                    size = BitConverter.ToInt32(tmp.SubArray(4, 4).Reverse().ToArray(), 0);

                    IsValid = true;

                    if (tmp.Length > 8 + size)
                    {
                        Data = tmp.SubArray(8, size - 2);
                        _isComplete = true;
                    }
                    break;

                case PrimeUsbDataType.File:
                    if (tmp.Length < 12) // Can't fit the header for files in here
                        return;

                    // Another checking
                    if (tmp[8] != 0x06)
                        return;

                    // Get the size and name
                    size = BitConverter.ToInt32(tmp.SubArray(4, 4).Reverse().ToArray(), 0);

                    IsValid = true;

                    // Get the name length
                    const int nameOffset = 12;
                    int nameLength = tmp[9];

                    if (tmp.Length > nameOffset + tmp[9])
                    {
                        Name = Encoding.Unicode.GetString(tmp.SubArray(nameOffset, nameLength));
                        _isComplete = tmp.Length >= size + nameOffset + nameLength;

                        if (_isComplete)
                            Data = tmp.SubArray(nameOffset + nameLength, size - nameLength - 4)
                                    .Concat(new byte[] {0x00, 0x00}).ToArray();
                    }
                    break;
            }
        }

        /// <summary>
        /// Segmented data ready to send
        /// </summary>
        public List<byte[]> Chunks { get; private set; }

        /// <summary>
        /// Saves this script to the filesystem
        /// </summary>
        /// <param name="destinationFilename">File including the extension to specify the format of the output (use .txt for plain text)</param>
        public void Save(string destinationFilename)
        {
            // Check destination folder
            var d = Path.GetDirectoryName(Path.GetFullPath(destinationFilename));
            if (d == null) return;

            if (!Directory.Exists(d))
                Directory.CreateDirectory(d);

            switch (Path.GetExtension(destinationFilename))
            {
                case ".txt":
                    File.WriteAllBytes(destinationFilename,Data.SubArray(0,Data.Length>1?(Data[Data.Length-1]==0&&Data[Data.Length-2]==0?Data.Length-2:Data.Length):Data.Length));
                    break;

                default:
                    // Convert to hpprgm file
                    IEnumerable<byte> f = new byte[]
                    {0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
                    File.WriteAllBytes(destinationFilename,
                        f.Concat(BitConverter.GetBytes(Data.Length)).Concat(Data).ToArray());
                    break;
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            if (Data !=null && Data.Length > 0)
                return Encoding.Unicode.GetString(Data);
            return null;
        }
    }

    internal struct PrimeUsbDataHeader
    {
        public byte[] Header;
        public PrimeUsbDataType Type;
    }

    /// <summary>
    /// Type of PrimeUsbData
    /// </summary>
    public enum PrimeUsbDataType
    {
        /// <summary>
        /// Data without known format header
        /// </summary>
        Unknown,
        /// <summary>
        /// Data uses a file header
        /// </summary>
        File,
        /// <summary>
        /// Data uses a message header
        /// </summary>
        Message
    }
}
