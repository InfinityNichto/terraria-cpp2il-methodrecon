using System;
using System.Net.NetworkInformation.AixStructs;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002A9 RID: 681
	internal class AixNetworkInterfaceAPI : UnixNetworkInterfaceAPI
	{
		// Token: 0x0600129B RID: 4763
		public static extern int socket(AixAddressFamily family, int type, int protocol);

		// Token: 0x0600129C RID: 4764
		public static extern int close(int fd);

		// Token: 0x0600129D RID: 4765
		public static extern int ioctl(int fd, AixIoctlRequest request, int arg);

		// Token: 0x0600129E RID: 4766
		public static extern int ioctl(int fd, AixIoctlRequest request, global::System.Net.NetworkInformation.AixStructs.ifconf arg);

		// Token: 0x0600129F RID: 4767
		public static extern int ioctl(int fd, AixIoctlRequest request, global::System.Net.NetworkInformation.AixStructs.ifreq_flags arg);

		// Token: 0x060012A0 RID: 4768
		public static extern int ioctl(int fd, AixIoctlRequest request, global::System.Net.NetworkInformation.AixStructs.ifreq_mtu arg);

		// Token: 0x060012A1 RID: 4769 RVA: 0x0003A0D4 File Offset: 0x000382D4
		private unsafe static void ByteArrayCopy(byte* dst, byte* src, int elements)
		{
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0003A0E4 File Offset: 0x000382E4
		public override NetworkInterface[] GetAllNetworkInterfaces()
		{
			IntPtr intPtr = Marshal.AllocHGlobal(43159552);
			long num;
			Type type;
			object obj = Marshal.PtrToStructure((IntPtr)num, type);
			string text = Marshal.PtrToStringAnsi(-2147483648);
			int num2 = 16;
			bool flag;
			Type type2;
			object obj2 = Marshal.PtrToStructure((flag ? 1 : 0) + num2, type2);
			return int.MinValue;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0003A1EC File Offset: 0x000383EC
		public AixNetworkInterfaceAPI()
		{
		}
	}
}
