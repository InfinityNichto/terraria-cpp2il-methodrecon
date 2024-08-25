using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020002DC RID: 732
	internal struct sockaddr_dl
	{
		// Token: 0x060012D9 RID: 4825 RVA: 0x0003A900 File Offset: 0x00038B00
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

		// Token: 0x04000F4F RID: 3919
		public byte sdl_len;

		// Token: 0x04000F50 RID: 3920
		public byte sdl_family;

		// Token: 0x04000F51 RID: 3921
		public ushort sdl_index;

		// Token: 0x04000F52 RID: 3922
		public byte sdl_type;

		// Token: 0x04000F53 RID: 3923
		public byte sdl_nlen;

		// Token: 0x04000F54 RID: 3924
		public byte sdl_alen;

		// Token: 0x04000F55 RID: 3925
		public byte sdl_slen;

		// Token: 0x04000F56 RID: 3926
		public byte[] sdl_data;
	}
}
