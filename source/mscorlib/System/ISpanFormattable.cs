using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020000CC RID: 204
	internal interface ISpanFormattable
	{
		// Token: 0x06000770 RID: 1904
		bool TryFormat(Span<char> destination, [Out] int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
	}
}
