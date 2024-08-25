using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020002D0 RID: 720
	internal struct sockaddr_dl
	{
		// Token: 0x060012D8 RID: 4824 RVA: 0x0003A848 File Offset: 0x00038A48
		internal void Read(IntPtr ptr)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			byte b = Marshal.ReadByte(ptr, (int)num2);
			this.sdl_len = b;
			int num3 = 1;
			byte b2 = Marshal.ReadByte(ptr, num3);
			this.sdl_family = b2;
			int num4 = 2;
			short num5 = Marshal.ReadInt16(ptr, num4);
			this.sdl_index = (ushort)num5;
			int num6 = 4;
			byte b3 = Marshal.ReadByte(ptr, num6);
			this.sdl_type = b3;
			int num7 = 5;
			byte b4 = Marshal.ReadByte(ptr, num7);
			this.sdl_nlen = b4;
			int num8 = 6;
			byte b5 = Marshal.ReadByte(ptr, num8);
			this.sdl_alen = b5;
			int num9 = 7;
			byte b6 = Marshal.ReadByte(ptr, num9);
			this.sdl_slen = b6;
			if (num == 0)
			{
			}
			int num10 = Math.Max(12, num9);
			byte[] array = this.sdl_data;
		}

		// Token: 0x04000F2F RID: 3887
		public byte sdl_len;

		// Token: 0x04000F30 RID: 3888
		public byte sdl_family;

		// Token: 0x04000F31 RID: 3889
		public ushort sdl_index;

		// Token: 0x04000F32 RID: 3890
		public byte sdl_type;

		// Token: 0x04000F33 RID: 3891
		public byte sdl_nlen;

		// Token: 0x04000F34 RID: 3892
		public byte sdl_alen;

		// Token: 0x04000F35 RID: 3893
		public byte sdl_slen;

		// Token: 0x04000F36 RID: 3894
		public byte[] sdl_data;
	}
}
