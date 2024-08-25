using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002B1 RID: 689
	internal class LinuxNetworkInterfaceAPI : UnixNetworkInterfaceAPI
	{
		// Token: 0x060012AA RID: 4778 RVA: 0x0003A2AC File Offset: 0x000384AC
		private static void FreeInterfaceAddresses(IntPtr ifap)
		{
			UnixNetworkInterfaceAPI.freeifaddrs(ifap);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0003A2C0 File Offset: 0x000384C0
		private static int GetInterfaceAddresses([Out] IntPtr ifap)
		{
			int num;
			return num;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
		public override NetworkInterface[] GetAllNetworkInterfaces()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0003A2D0 File Offset: 0x000384D0
		public LinuxNetworkInterfaceAPI()
		{
		}
	}
}
