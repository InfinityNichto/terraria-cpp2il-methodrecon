using System;
using System.IO;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002C5 RID: 709
	internal class MibIPGlobalProperties : UnixIPGlobalProperties
	{
		// Token: 0x060012C8 RID: 4808 RVA: 0x0003A68C File Offset: 0x0003888C
		public MibIPGlobalProperties(string procDir)
		{
			if (!true)
			{
			}
			string text = Path.Combine(procDir, "net/snmp");
			this.StatisticsFile = text;
			string text2 = Path.Combine(text, "net/snmp6");
			this.StatisticsFileIPv6 = text2;
			string text3 = Path.Combine(procDir, "net/tcp");
			this.TcpFile = text3;
			string text4 = Path.Combine(procDir, "net/tcp6");
			this.Tcp6File = text4;
			string text5 = Path.Combine(procDir, "net/udp");
			this.UdpFile = text5;
			string text6 = Path.Combine(procDir, "net/udp6");
			this.Udp6File = text6;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0003A718 File Offset: 0x00038918
		// Note: this type is marked as 'beforefieldinit'.
		static MibIPGlobalProperties()
		{
		}

		// Token: 0x04000F0A RID: 3850
		public readonly string StatisticsFile;

		// Token: 0x04000F0B RID: 3851
		public readonly string StatisticsFileIPv6;

		// Token: 0x04000F0C RID: 3852
		public readonly string TcpFile;

		// Token: 0x04000F0D RID: 3853
		public readonly string Tcp6File;

		// Token: 0x04000F0E RID: 3854
		public readonly string UdpFile;

		// Token: 0x04000F0F RID: 3855
		public readonly string Udp6File;

		// Token: 0x04000F10 RID: 3856
		private static readonly char[] wsChars;
	}
}
