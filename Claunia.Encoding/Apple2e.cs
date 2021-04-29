﻿//
// Apple IIe.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright © 2016-2021 Natalia Portillo
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

namespace Claunia.Encoding
{
    /// <summary>Represents an Apple IIe character encoding of Unicode characters.</summary>
    public class Apple2E : SingleByteEncoding
    {
        public override string BodyName        => "apple2e";
        public override int    CodePage        => 0;
        public override string EncodingName    => "Western European (Apple IIe)";
        public override string HeaderName      => "apple2e";
        public override string WebName         => "";
        public override int    WindowsCodePage => 0;

        public override bool IsBrowserDisplay  => false;
        public override bool IsBrowserSave     => false;
        public override bool IsMailNewsDisplay => false;
        public override bool IsMailNewsSave    => false;
        public override bool IsReadOnly        => true;
        public override bool IsSingleByte      => true;

        /// <summary>The Apple IIe to Unicode character map.</summary>
        protected override char[] CharTable => new[]
        {
            // 0x00
            '\u0020', '\u0021', '\u0022', '\u0023', '\u0024', '\u0025', '\u0026', '\u0027',

            // 0x08
            '\u0028', '\u0029', '\u002A', '\u002B', '\u002C', '\u002D', '\u002E', '\u002F',

            // 0x10
            '\u0030', '\u0031', '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037',

            // 0x18
            '\u0038', '\u0039', '\u003A', '\u003B', '\u003C', '\u003D', '\u003E', '\u003F',

            // 0x20
            '\u0040', '\u0061', '\u0062', '\u0063', '\u0064', '\u0065', '\u0066', '\u0067',

            // 0x28
            '\u0068', '\u0069', '\u006A', '\u006B', '\u006C', '\u006D', '\u006E', '\u006F',

            // 0x30
            '\u0070', '\u0071', '\u0072', '\u0073', '\u0074', '\u0075', '\u0076', '\u0077',

            // 0x38
            '\u0078', '\u0079', '\u007A', '\u005B', '\u005C', '\u005D', '\u005E', '\u005F',

            // 0x40
            '\u00A0', '\u2575', '\u2574', '\u2577', '\u2576', '\u2518', '\u2510', '\u250C',

            // 0x48
            '\u2514', '\u2500', '\u2502', '\u2534', '\u2524', '\u252C', '\u251C', '\u253C',

            // 0x50
            '\u25E4', '\u25E5', '\u2592', '\u2598', '\u259D', '\u2580', '\u2596', '\u2597',

            // 0x58
            '\u259A', '\u258C', '\u0000', '\u0000', '\u2190', '\u2191', '\u2192', '\u2193',

            // 0x60
            '\u03C0', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',

            // 0x68
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',

            // 0x70
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',

            // 0x78
            '\u0058', '\u0059', '\u005A', '\u007B', '\u007C', '\u007D', '\u007E', '\u0000',

            // 0x80
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x88
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x90
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x98
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xA0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xA8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xB0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xB8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xC0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xC8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xD0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xD8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xE0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xE8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xF0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xF8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000'
        };

        /// <summary>Converts a Unicode character to an Apple IIe character</summary>
        /// <returns>Apple IIe character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(char character)
        {
            switch(character)
            {
                case '\u0020': return 0x00;
                case '\u0021': return 0x01;
                case '\u0022': return 0x02;
                case '\u0023': return 0x03;
                case '\u0024': return 0x04;
                case '\u0025': return 0x05;
                case '\u0026': return 0x06;
                case '\u0027': return 0x07;
                case '\u0028': return 0x08;
                case '\u0029': return 0x09;
                case '\u002A': return 0x0A;
                case '\u002B': return 0x0B;
                case '\u002C': return 0x0C;
                case '\u002D': return 0x0D;
                case '\u002E': return 0x0E;
                case '\u002F': return 0x0F;
                case '\u0030': return 0x10;
                case '\u0031': return 0x11;
                case '\u0032': return 0x12;
                case '\u0033': return 0x13;
                case '\u0034': return 0x14;
                case '\u0035': return 0x15;
                case '\u0036': return 0x16;
                case '\u0037': return 0x17;
                case '\u0038': return 0x18;
                case '\u0039': return 0x19;
                case '\u003A': return 0x1A;
                case '\u003B': return 0x1B;
                case '\u003C': return 0x1C;
                case '\u003D': return 0x1D;
                case '\u003E': return 0x1E;
                case '\u003F': return 0x1F;
                case '\u0040': return 0x20;
                case '\u0061': return 0x21;
                case '\u0062': return 0x22;
                case '\u0063': return 0x23;
                case '\u0064': return 0x24;
                case '\u0065': return 0x25;
                case '\u0066': return 0x26;
                case '\u0067': return 0x27;
                case '\u0068': return 0x28;
                case '\u0069': return 0x29;
                case '\u006A': return 0x2A;
                case '\u006B': return 0x2B;
                case '\u006C': return 0x2C;
                case '\u006D': return 0x2D;
                case '\u006E': return 0x2E;
                case '\u006F': return 0x2F;
                case '\u0070': return 0x30;
                case '\u0071': return 0x31;
                case '\u0072': return 0x32;
                case '\u0073': return 0x33;
                case '\u0074': return 0x34;
                case '\u0075': return 0x35;
                case '\u0076': return 0x36;
                case '\u0077': return 0x37;
                case '\u0078': return 0x38;
                case '\u0079': return 0x39;
                case '\u007A': return 0x3A;
                case '\u005B': return 0x3B;
                case '\u005C': return 0x3C;
                case '\u005D': return 0x3D;
                case '\u005E': return 0x3E;
                case '\u005F': return 0x3F;
                case '\u00A0': return 0x40;
                case '\u2575': return 0x41;
                case '\u2574': return 0x42;
                case '\u2577': return 0x43;
                case '\u2576': return 0x44;
                case '\u2518': return 0x45;
                case '\u2510': return 0x46;
                case '\u250C': return 0x47;
                case '\u2514': return 0x48;
                case '\u2500': return 0x49;
                case '\u2502': return 0x4A;
                case '\u2534': return 0x4B;
                case '\u2524': return 0x4C;
                case '\u252C': return 0x4D;
                case '\u251C': return 0x4E;
                case '\u253C': return 0x4F;
                case '\u25E4': return 0x50;
                case '\u25E5': return 0x51;
                case '\u2592': return 0x52;
                case '\u2598': return 0x53;
                case '\u259D': return 0x54;
                case '\u2580': return 0x55;
                case '\u2596': return 0x56;
                case '\u2597': return 0x57;
                case '\u259A': return 0x58;
                case '\u258C': return 0x59;
                case '\u2190': return 0x5C;
                case '\u2191': return 0x5D;
                case '\u2192': return 0x5E;
                case '\u2193': return 0x5F;
                case '\u03C0': return 0x60;
                case '\u0041': return 0x61;
                case '\u0042': return 0x62;
                case '\u0043': return 0x63;
                case '\u0044': return 0x64;
                case '\u0045': return 0x65;
                case '\u0046': return 0x66;
                case '\u0047': return 0x67;
                case '\u0048': return 0x68;
                case '\u0049': return 0x69;
                case '\u004A': return 0x6A;
                case '\u004B': return 0x6B;
                case '\u004C': return 0x6C;
                case '\u004D': return 0x6D;
                case '\u004E': return 0x6E;
                case '\u004F': return 0x6F;
                case '\u0050': return 0x70;
                case '\u0051': return 0x71;
                case '\u0052': return 0x72;
                case '\u0053': return 0x73;
                case '\u0054': return 0x74;
                case '\u0055': return 0x75;
                case '\u0056': return 0x76;
                case '\u0057': return 0x77;
                case '\u0058': return 0x78;
                case '\u0059': return 0x79;
                case '\u005A': return 0x7A;
                case '\u007B': return 0x7B;
                case '\u007C': return 0x7C;
                case '\u007D': return 0x7D;
                case '\u007E': return 0x7E;
                default:
                    // Fallback to '?'
                    return 0x3F;
            }
        }
    }
}