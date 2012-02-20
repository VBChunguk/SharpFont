﻿#region MIT License
/*Copyright (c) 2012 Robert Rouhani <robert.rouhani@gmail.com>

SharpFont based on Tao.FreeType, Copyright (c) 2003-2007 Tao Framework Team

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
#endregion

using System;
using System.Runtime.InteropServices;

#if FT64
using FT_26Dot6 = System.Int64;
using FT_Fixed = System.Int64;
using FT_Long = System.Int64;
using FT_Pos = System.Int64;
using FT_ULong = System.UInt64;
#else
using FT_26Dot6 = System.Int32;
using FT_Fixed = System.Int32;
using FT_Long = System.Int32;
using FT_Pos = System.Int32;
using FT_ULong = System.UInt32;
#endif

namespace SharpFont.Internal
{
	/// <summary>
	/// Internally represents a GlyphMetrics.
	/// </summary>
	/// <remarks>
	/// Refer to <see cref="GlyphMetrics"/> for FreeType documentation.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	internal struct GlyphMetricsInternal
	{
		internal FT_Pos width;
		internal FT_Pos height;

		internal FT_Pos horiBearingX;
		internal FT_Pos horiBearingY;
		internal FT_Pos horiAdvance;

		internal FT_Pos vertBearingX;
		internal FT_Pos vertBearingY;
		internal FT_Pos vertAdvance;

		internal static int SizeInBytes { get { return sizeof(FT_Pos) * 8; } }
	}
}
