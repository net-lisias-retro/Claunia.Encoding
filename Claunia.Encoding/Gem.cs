﻿//
// Gem.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright © 2016-2018 Natalia Portillo
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace Claunia.Encoding
{
    /// <summary>
    ///     Represents a GEM character encoding of Unicode characters.
    /// </summary>
    public class Gem : Encoding
    {
        const string _bodyname        = "gem";
        const int    _codepage        = 0;
        const string _encodingname    = "Western European (GEM)";
        const string _headername      = "gem";
        const string _webname         = "";
        const int    _windowsCodepage = 0;

        const bool browserDisplay  = false;
        const bool browserSave     = false;
        const bool mailNewsDisplay = false;
        const bool mailNewsSave    = false;
        const bool readOnly        = false;
        const bool singleByte      = true;

        /// <summary>
        ///     The GEM to Unicode character map.
        ///     Pending: 0x09 => 0x0001F552, 0x0A => 0x0001F514
        /// </summary>
        static readonly char[] GemTable =
        {
            // 0x00
            '\u0000', '\u21E7', '\u21E9', '\u21E8', '\u21E6', '\u25FC', '\uFFFD', '\u25C6',
            // 0x08
            '\u2713', '\uFFFD', '\uFFFD', '\u266A', '\u25B4', '\u25BE', '\u25B8', '\u25C2',
            // 0x10
            '\u25BA', '\u25C4', '\u29D3', '\u2582', '\u00B6', '\u00A7', '\u2195', '\u21A8',
            // 0x18
            '\u2191', '\u2193', '\u2192', '\u2190', '\u221F', '\u2194', '\u25B2', '\u25BC',
            // 0x20
            '\u0020', '\u0021', '\u0022', '\u0023', '\u0024', '\u0025', '\u0026', '\u0027',
            // 0x28
            '\u0028', '\u0029', '\u002A', '\u002B', '\u002C', '\u002D', '\u002E', '\u002F',
            // 0x30
            '\u0030', '\u0031', '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037',
            // 0x38
            '\u0038', '\u0039', '\u003A', '\u003B', '\u003C', '\u003D', '\u003E', '\u003F',
            // 0x40
            '\u0040', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',
            // 0x48
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',
            // 0x50
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',
            // 0x58
            '\u0058', '\u0059', '\u005A', '\u005B', '\u005C', '\u005D', '\u005E', '\u005F',
            // 0x60
            '\u0060', '\u0061', '\u0062', '\u0063', '\u0064', '\u0065', '\u0066', '\u0067',
            // 0x68
            '\u0068', '\u0069', '\u006A', '\u006B', '\u006C', '\u006D', '\u006E', '\u006F',
            // 0x70
            '\u0070', '\u0071', '\u0072', '\u0073', '\u0074', '\u0075', '\u0076', '\u0077',
            // 0x78
            '\u0078', '\u0079', '\u007A', '\u007B', '\u007C', '\u007D', '\u007E', '\u2302',
            // 0x80
            '\u00C7', '\u00FC', '\u00E9', '\u00E2', '\u00E4', '\u00E0', '\u00E5', '\u00E7',
            // 0x88
            '\u00EA', '\u00EB', '\u00E8', '\u00EF', '\u00EE', '\u00EC', '\u00C4', '\u00C5',
            // 0x90
            '\u00C9', '\u00E6', '\u00C6', '\u00F4', '\u00F6', '\u00F2', '\u00FB', '\u00F9',
            // 0x98
            '\u00FF', '\u00D6', '\u00DC', '\u00FB', '\u00A3', '\u00D8', '\u00A4', '\u0192',
            // 0xA0
            '\u00E1', '\u00ED', '\u00F3', '\u00FA', '\u00F1', '\u00D1', '\u00AA', '\u00BA',
            // 0xA8
            '\u00BF', '\u201C', '\u201D', '\u2039', '\u203A', '\u00A1', '\u00AB', '\u00BB',
            // 0xB0
            '\u00E3', '\u00F5', '\u00A5', '\u00A2', '\u0153', '\u0152', '\u00C0', '\u00C3',
            // 0xB8
            '\u00D5', '\u00A7', '\u2021', '\u2020', '\u00B6', '\u00A9', '\u00AE', '\u2122',
            // 0xC0
            '\u201E', '\u2026', '\u2030', '\u2022', '\u2013', '\u2014', '\u2070', '\u00C1',
            // 0xC8
            '\u00C2', '\u00C8', '\u00CA', '\u00CB', '\u00CC', '\u00CD', '\u00CE', '\u00CF',
            // 0xD0
            '\u00D2', '\u00D3', '\u00D4', '\u0160', '\u0161', '\u00D9', '\u00DA', '\u00DB',
            // 0xD8
            '\u0178', '\u00DF', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',
            // 0xE0
            '\u03B1', '\u03B2', '\u0393', '\u03C0', '\u03A3', '\u03C3', '\u00B5', '\u03C4',
            // 0xE8
            '\u03A6', '\u0398', '\u03A9', '\u03B4', '\u222E', '\u0278', '\u2208', '\u2229',
            // 0xF0
            '\u2261', '\u00B1', '\u2265', '\u2264', '\u2320', '\u2321', '\u00F7', '\u2248',
            // 0xF8
            '\u00B0', '\u2219', '\u00B7', '\u221A', '\u207F', '\u00B2', '\u25A0', '\u2205'
        };

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by browser clients for displaying content.
        /// </summary>
        public override bool IsBrowserDisplay => browserDisplay;

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by browser clients for saving content.
        /// </summary>
        public override bool IsBrowserSave => browserSave;

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by mail and news clients for displaying content.
        /// </summary>
        public override bool IsMailNewsDisplay => mailNewsDisplay;

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by mail and news clients for saving content.
        /// </summary>
        public override bool IsMailNewsSave => mailNewsSave;

        /// <summary>
        ///     Gets a value indicating whether the current encoding is read-only.
        /// </summary>
        /// <value>The is single byte.</value>
        public override bool IsReadOnly => readOnly;

        /// <summary>
        ///     Gets a value indicating whether the current encoding uses single-byte code points.
        /// </summary>
        public override bool IsSingleByte => singleByte;

        /// <summary>
        ///     Gets the code page identifier of the current Encoding.
        /// </summary>
        public override int CodePage => _codepage;

        /// <summary>
        ///     Gets a name for the current encoding that can be used with mail agent body tags
        /// </summary>
        public override string BodyName => _bodyname;

        /// <summary>
        ///     Gets a name for the current encoding that can be used with mail agent header tags
        /// </summary>
        public override string HeaderName => _headername;

        /// <summary>
        ///     Ggets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.
        /// </summary>
        public override string WebName => _webname;

        /// <summary>
        ///     Gets the human-readable description of the current encoding.
        /// </summary>
        public override string EncodingName => _encodingname;

        /// <summary>
        ///     Gets the Windows operating system code page that most closely corresponds to the current encoding.
        /// </summary>
        public override int WindowsCodePage => _windowsCodepage;

        /// <summary>
        ///     Calculates the number of bytes produced by encoding the characters in the specified <see cref="string" />.
        /// </summary>
        /// <returns>The number of bytes produced by encoding the specified characters.</returns>
        /// <param name="s">The <see cref="string" /> containing the set of characters to encode.</param>
        public override int GetByteCount(string s)
        {
            if(s == null) throw new ArgumentNullException(nameof(s));

            return s.Length;
        }

        /// <summary>
        ///     Calculates the number of bytes produced by encoding a set of characters from the specified character array.
        /// </summary>
        /// <returns>The number of bytes produced by encoding the specified characters.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="index">The index of the first character to encode.</param>
        /// <param name="count">The number of characters to encode.</param>
        public override int GetByteCount(char[] chars, int index, int count)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            if(index < 0 || index >= chars.Length) throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0 || index + count > chars.Length) throw new ArgumentOutOfRangeException(nameof(index));

            return count;
        }

        /// <summary>
        ///     Calculates the number of bytes produced by encoding all the characters in the specified character array.
        /// </summary>
        /// <returns>The number of bytes produced by encoding all the characters in the specified character array.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override int GetByteCount(char[] chars)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            return chars.Length;
        }

        /// <summary>
        ///     Encodes a set of characters from the specified <see cref="string" /> into the specified byte array.
        /// </summary>
        /// <returns>The actual number of bytes written into bytes.</returns>
        /// <param name="s">The <see cref="string" /> containing the set of characters to encode.</param>
        /// <param name="charIndex">The index of the first character to encode.</param>
        /// <param name="charCount">The number of characters to encode.</param>
        /// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
        /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            return GetBytes(s.ToCharArray(), charIndex, charCount, bytes, byteIndex);
        }

        /// <summary>
        ///     Encodes all the characters in the specified string into a sequence of bytes.
        /// </summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="s">The string containing the characters to encode.</param>
        public override byte[] GetBytes(string s)
        {
            if(s == null) throw new ArgumentNullException(nameof(s));

            return GetBytes(s.ToCharArray(), 0, s.Length);
        }

        /// <summary>
        ///     Encodes a set of characters from the specified character array into the specified byte array.
        /// </summary>
        /// <returns>The actual number of bytes written into bytes.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="charIndex">The index of the first character to encode.</param>
        /// <param name="charCount">The number of characters to encode.</param>
        /// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
        /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            if(bytes == null) throw new ArgumentNullException(nameof(bytes));

            if(charIndex < 0) throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charCount < 0) throw new ArgumentOutOfRangeException(nameof(charCount));

            if(byteIndex < 0) throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(charIndex >= chars.Length) throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charCount + charIndex > chars.Length) throw new ArgumentOutOfRangeException(nameof(charCount));

            if(byteIndex >= bytes.Length) throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteIndex + charCount > bytes.Length) throw new ArgumentException(nameof(bytes));

            byte[] temp = GetBytes(chars, charIndex, charCount);

            for(int i = 0; i < temp.Length; i++) bytes[i + byteIndex] = temp[i];

            return charCount;
        }

        /// <summary>
        ///     Encodes a set of characters from the specified character array into a sequence of bytes.
        /// </summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="index">The index of the first character to encode.</param>
        /// <param name="count">The number of characters to encode.</param>
        public override byte[] GetBytes(char[] chars, int index, int count)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            if(index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0) throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > chars.Length) throw new ArgumentOutOfRangeException(nameof(count));

            byte[] bytes = new byte[count];

            for(int i = 0; i < count; i++) bytes[i] = GetByte(chars[index + i]);

            return bytes;
        }

        /// <summary>
        ///     Encodes all the characters in the specified character array into a sequence of bytes.
        /// </summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override byte[] GetBytes(char[] chars)
        {
            return GetBytes(chars, 0, chars.Length);
        }

        /// <summary>
        ///     Calculates the number of characters produced by decoding all the bytes in the specified byte array.
        /// </summary>
        /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override int GetCharCount(byte[] bytes)
        {
            return GetCharCount(bytes, 0, bytes.Length);
        }

        /// <summary>
        ///     Calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.
        /// </summary>
        /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override int GetCharCount(byte[] bytes, int index, int count)
        {
            if(bytes == null) throw new ArgumentNullException(nameof(bytes));

            if(index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0) throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > bytes.Length) throw new ArgumentOutOfRangeException(nameof(count));

            return count;
        }

        /// <summary>
        ///     Decodes a sequence of bytes from the specified byte array into the specified character array.
        /// </summary>
        /// <returns>The actual number of characters written into chars.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="byteIndex">The index of the first byte to decode.</param>
        /// <param name="byteCount">The number of bytes to decode.</param>
        /// <param name="chars">The character array to contain the resulting set of characters.</param>
        /// <param name="charIndex">The index at which to start writing the resulting set of characters.</param>
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
        {
            if(bytes == null) throw new ArgumentNullException(nameof(bytes));

            if(chars == null) throw new ArgumentNullException(nameof(chars));

            if(byteIndex < 0) throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteCount < 0) throw new ArgumentOutOfRangeException(nameof(byteCount));

            if(charIndex < 0) throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(byteIndex >= bytes.Length) throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteCount + byteIndex > bytes.Length) throw new ArgumentOutOfRangeException(nameof(byteCount));

            if(charIndex >= chars.Length) throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charIndex + byteCount > chars.Length) throw new ArgumentException(nameof(chars));

            char[] temp = GetChars(bytes, byteIndex, byteCount);

            for(int i = 0; i < temp.Length; i++) chars[i + charIndex] = temp[i];

            return byteCount;
        }

        /// <summary>
        ///     Decodes all the bytes in the specified byte array into a set of characters.
        /// </summary>
        /// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override char[] GetChars(byte[] bytes)
        {
            return GetChars(bytes, 0, bytes.Length);
        }

        /// <summary>
        ///     Decodes a sequence of bytes from the specified byte array into a set of characters.
        /// </summary>
        /// <returns>The chars.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override char[] GetChars(byte[] bytes, int index, int count)
        {
            if(bytes == null) throw new ArgumentNullException(nameof(bytes));

            if(index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0) throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > bytes.Length) throw new ArgumentOutOfRangeException(nameof(count));

            char[] chars = new char[count];

            for(int i = 0; i < count; i++) chars[i] = GetChar(bytes[index + i]);

            return chars;
        }

        /// <summary>
        ///     Calculates the maximum number of bytes produced by encoding the specified number of characters.
        /// </summary>
        /// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
        /// <param name="charCount">The number of characters to encode.</param>
        public override int GetMaxByteCount(int charCount)
        {
            if(charCount < 0) throw new ArgumentOutOfRangeException(nameof(charCount));

            return charCount;
        }

        /// <summary>
        ///     Calculates the maximum number of characters produced by decoding the specified number of bytes.
        /// </summary>
        /// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
        /// <param name="byteCount">The number of bytes to decode.</param>
        public override int GetMaxCharCount(int byteCount)
        {
            if(byteCount < 0) throw new ArgumentOutOfRangeException(nameof(byteCount));

            return byteCount;
        }

        /// <summary>
        ///     Returns a sequence of bytes that specifies the encoding used.
        /// </summary>
        /// <returns>A byte array of length zero, as a preamble is not required.</returns>
        public override byte[] GetPreamble()
        {
            return new byte[0];
        }

        /// <summary>
        ///     Decodes all the bytes in the specified byte array into a string.
        /// </summary>
        /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override string GetString(byte[] bytes)
        {
            return GetString(bytes, 0, bytes.Length);
        }

        /// <summary>
        ///     Decodes a sequence of bytes from the specified byte array into a string.
        /// </summary>
        /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override string GetString(byte[] bytes, int index, int count)
        {
            return new string(GetChars(bytes, index, count));
        }

        /// <summary>
        ///     Converts a GEM character to an Unicode character
        /// </summary>
        /// <returns>Unicode character.</returns>
        /// <param name="character">GEM character.</param>
        static char GetChar(byte character)
        {
            return GemTable[character];
        }

        /// <summary>
        ///     Converts a Unicode character to an GEM character
        /// </summary>
        /// <returns>GEM character.</returns>
        /// <param name="character">Unicode character.</param>
        static byte GetByte(char character)
        {
            switch(character)
            {
                case '\u0000': return 0x00;
                case '\u21E7': return 0x01;
                case '\u21E9': return 0x02;
                case '\u21E8': return 0x03;
                case '\u21E6': return 0x04;
                case '\u25FC': return 0x05;
                case '\u25C6': return 0x07;
                case '\u2713': return 0x08;
                case '\u266A': return 0x0B;
                case '\u25B4': return 0x0C;
                case '\u25BE': return 0x0D;
                case '\u25B8': return 0x0E;
                case '\u25C2': return 0x0F;
                case '\u25BA': return 0x10;
                case '\u25C4': return 0x11;
                case '\u29D3': return 0x12;
                case '\u2582': return 0x13;
                case '\u2195': return 0x16;
                case '\u21A8': return 0x17;
                case '\u2191': return 0x18;
                case '\u2193': return 0x19;
                case '\u2192': return 0x1A;
                case '\u2190': return 0x1B;
                case '\u221F': return 0x1C;
                case '\u2194': return 0x1D;
                case '\u25B2': return 0x1E;
                case '\u25BC': return 0x1F;
                case '\u0020': return 0x20;
                case '\u0021': return 0x21;
                case '\u0022': return 0x22;
                case '\u0023': return 0x23;
                case '\u0024': return 0x24;
                case '\u0025': return 0x25;
                case '\u0026': return 0x26;
                case '\u0027': return 0x27;
                case '\u0028': return 0x28;
                case '\u0029': return 0x29;
                case '\u002A': return 0x2A;
                case '\u002B': return 0x2B;
                case '\u002C': return 0x2C;
                case '\u002D': return 0x2D;
                case '\u002E': return 0x2E;
                case '\u002F': return 0x2F;
                case '\u0030': return 0x30;
                case '\u0031': return 0x31;
                case '\u0032': return 0x32;
                case '\u0033': return 0x33;
                case '\u0034': return 0x34;
                case '\u0035': return 0x35;
                case '\u0036': return 0x36;
                case '\u0037': return 0x37;
                case '\u0038': return 0x38;
                case '\u0039': return 0x39;
                case '\u003A': return 0x3A;
                case '\u003B': return 0x3B;
                case '\u003C': return 0x3C;
                case '\u003D': return 0x3D;
                case '\u003E': return 0x3E;
                case '\u003F': return 0x3F;
                case '\u0040': return 0x40;
                case '\u0041': return 0x41;
                case '\u0042': return 0x42;
                case '\u0043': return 0x43;
                case '\u0044': return 0x44;
                case '\u0045': return 0x45;
                case '\u0046': return 0x46;
                case '\u0047': return 0x47;
                case '\u0048': return 0x48;
                case '\u0049': return 0x49;
                case '\u004A': return 0x4A;
                case '\u004B': return 0x4B;
                case '\u004C': return 0x4C;
                case '\u004D': return 0x4D;
                case '\u004E': return 0x4E;
                case '\u004F': return 0x4F;
                case '\u0050': return 0x50;
                case '\u0051': return 0x51;
                case '\u0052': return 0x52;
                case '\u0053': return 0x53;
                case '\u0054': return 0x54;
                case '\u0055': return 0x55;
                case '\u0056': return 0x56;
                case '\u0057': return 0x57;
                case '\u0058': return 0x58;
                case '\u0059': return 0x59;
                case '\u005A': return 0x5A;
                case '\u005B': return 0x5B;
                case '\u005C': return 0x5C;
                case '\u005D': return 0x5D;
                case '\u005E': return 0x5E;
                case '\u005F': return 0x5F;
                case '\u0060': return 0x60;
                case '\u0061': return 0x61;
                case '\u0062': return 0x62;
                case '\u0063': return 0x63;
                case '\u0064': return 0x64;
                case '\u0065': return 0x65;
                case '\u0066': return 0x66;
                case '\u0067': return 0x67;
                case '\u0068': return 0x68;
                case '\u0069': return 0x69;
                case '\u006A': return 0x6A;
                case '\u006B': return 0x6B;
                case '\u006C': return 0x6C;
                case '\u006D': return 0x6D;
                case '\u006E': return 0x6E;
                case '\u006F': return 0x6F;
                case '\u0070': return 0x70;
                case '\u0071': return 0x71;
                case '\u0072': return 0x72;
                case '\u0073': return 0x73;
                case '\u0074': return 0x74;
                case '\u0075': return 0x75;
                case '\u0076': return 0x76;
                case '\u0077': return 0x77;
                case '\u0078': return 0x78;
                case '\u0079': return 0x79;
                case '\u007A': return 0x7A;
                case '\u007B': return 0x7B;
                case '\u007C': return 0x7C;
                case '\u007D': return 0x7D;
                case '\u007E': return 0x7E;
                case '\u2302': return 0x7F;
                case '\u00C7': return 0x80;
                case '\u00FC': return 0x81;
                case '\u00E9': return 0x82;
                case '\u00E2': return 0x83;
                case '\u00E4': return 0x84;
                case '\u00E0': return 0x85;
                case '\u00E5': return 0x86;
                case '\u00E7': return 0x87;
                case '\u00EA': return 0x88;
                case '\u00EB': return 0x89;
                case '\u00E8': return 0x8A;
                case '\u00EF': return 0x8B;
                case '\u00EE': return 0x8C;
                case '\u00EC': return 0x8D;
                case '\u00C4': return 0x8E;
                case '\u00C5': return 0x8F;
                case '\u00C9': return 0x90;
                case '\u00E6': return 0x91;
                case '\u00C6': return 0x92;
                case '\u00F4': return 0x93;
                case '\u00F6': return 0x94;
                case '\u00F2': return 0x95;
                case '\u00FB': return 0x96;
                case '\u00F9': return 0x97;
                case '\u00FF': return 0x98;
                case '\u00D6': return 0x99;
                case '\u00DC': return 0x9A;
                case '\u00F8': return 0x9B;
                case '\u00A3': return 0x9C;
                case '\u00D8': return 0x9D;
                case '\u00A4': return 0x9E;
                case '\u0192': return 0x9F;
                case '\u00E1': return 0xA0;
                case '\u00ED': return 0xA1;
                case '\u00F3': return 0xA2;
                case '\u00FA': return 0xA3;
                case '\u00F1': return 0xA4;
                case '\u00D1': return 0xA5;
                case '\u00AA': return 0xA6;
                case '\u00BA': return 0xA7;
                case '\u00BF': return 0xA8;
                case '\u201C': return 0xA9;
                case '\u201D': return 0xAA;
                case '\u2039': return 0xAB;
                case '\u203A': return 0xAC;
                case '\u00A1': return 0xAD;
                case '\u00AB': return 0xAE;
                case '\u00BB': return 0xAF;
                case '\u00E3': return 0xB0;
                case '\u00F5': return 0xB1;
                case '\u00A5': return 0xB2;
                case '\u00A2': return 0xB3;
                case '\u0153': return 0xB4;
                case '\u0152': return 0xB5;
                case '\u00C0': return 0xB6;
                case '\u00C3': return 0xB7;
                case '\u00D5': return 0xB8;
                case '\u00A7': return 0xB9;
                case '\u2821': return 0xBA;
                case '\u2020': return 0xBB;
                case '\u00B6': return 0xBC;
                case '\u00A9': return 0xBD;
                case '\u00AE': return 0xBE;
                case '\u2122': return 0xBF;
                case '\u201E': return 0xC0;
                case '\u2026': return 0xC1;
                case '\u2030': return 0xC2;
                case '\u2022': return 0xC3;
                case '\u2013': return 0xC4;
                case '\u2014': return 0xC5;
                case '\u2070': return 0xC6;
                case '\u00C1': return 0xC7;
                case '\u00C2': return 0xC8;
                case '\u00C8': return 0xC9;
                case '\u00CA': return 0xCA;
                case '\u00CB': return 0xCB;
                case '\u00CC': return 0xCC;
                case '\u00CD': return 0xCD;
                case '\u00CE': return 0xCE;
                case '\u00CF': return 0xCF;
                case '\u00D2': return 0xD0;
                case '\u00D3': return 0xD1;
                case '\u00D4': return 0xD2;
                case '\u0160': return 0xD3;
                case '\u0161': return 0xD4;
                case '\u00D9': return 0xD5;
                case '\u00DA': return 0xD6;
                case '\u00DB': return 0xD7;
                case '\u0178': return 0xD8;
                case '\u00DF': return 0xD9;
                case '\u03B1': return 0xE0;
                case '\u03B2': return 0xE1;
                case '\u0393': return 0xE2;
                case '\u03C0': return 0xE3;
                case '\u03A3': return 0xE4;
                case '\u03C3': return 0xE5;
                case '\u00B5': return 0xE6;
                case '\u03C4': return 0xE7;
                case '\u03A6': return 0xE8;
                case '\u0398': return 0xE9;
                case '\u03A9': return 0xEA;
                case '\u03B4': return 0xEB;
                case '\u222E': return 0xEC;
                case '\u0278': return 0xED;
                case '\u2208': return 0xEE;
                case '\u2229': return 0xEF;
                case '\u2261': return 0xF0;
                case '\u00B1': return 0xF1;
                case '\u2265': return 0xF2;
                case '\u2264': return 0xF3;
                case '\u2320': return 0xF4;
                case '\u2321': return 0xF5;
                case '\u00F7': return 0xF6;
                case '\u2248': return 0xF7;
                case '\u00B0': return 0xF8;
                case '\u2219': return 0xF9;
                case '\u00B7': return 0xFA;
                case '\u221A': return 0xFB;
                case '\u207F': return 0xFC;
                case '\u00B2': return 0xFD;
                case '\u25A0': return 0xFE;
                case '\u2205': return 0xFF;
                default:
                    // Fallback to '?'
                    return 0x3F;
            }
        }
    }
}