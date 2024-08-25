using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020001A2 RID: 418
	[StructLayout(2)]
	internal struct Variant
	{
		// Token: 0x06000FF8 RID: 4088 RVA: 0x000220F8 File Offset: 0x000202F8
		public void Clear()
		{
			Marshal.FreeBSTR(this.uintVal);
		}

		// Token: 0x04000892 RID: 2194
		public short vt;

		// Token: 0x04000893 RID: 2195
		public ushort wReserved1;

		// Token: 0x04000894 RID: 2196
		public ushort wReserved2;

		// Token: 0x04000895 RID: 2197
		public ushort wReserved3;

		// Token: 0x04000896 RID: 2198
		public long llVal;

		// Token: 0x04000897 RID: 2199
		public int lVal;

		// Token: 0x04000898 RID: 2200
		public byte bVal;

		// Token: 0x04000899 RID: 2201
		public short iVal;

		// Token: 0x0400089A RID: 2202
		public float fltVal;

		// Token: 0x0400089B RID: 2203
		public double dblVal;

		// Token: 0x0400089C RID: 2204
		public short boolVal;

		// Token: 0x0400089D RID: 2205
		public IntPtr bstrVal;

		// Token: 0x0400089E RID: 2206
		public sbyte cVal;

		// Token: 0x0400089F RID: 2207
		public ushort uiVal;

		// Token: 0x040008A0 RID: 2208
		public uint ulVal;

		// Token: 0x040008A1 RID: 2209
		public ulong ullVal;

		// Token: 0x040008A2 RID: 2210
		public int intVal;

		// Token: 0x040008A3 RID: 2211
		public uint uintVal;

		// Token: 0x040008A4 RID: 2212
		public IntPtr pdispVal;

		// Token: 0x040008A5 RID: 2213
		public BRECORD bRecord;
	}
}
