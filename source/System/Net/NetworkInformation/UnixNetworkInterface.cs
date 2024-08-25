using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002C9 RID: 713
	internal abstract class UnixNetworkInterface : NetworkInterface
	{
		// Token: 0x060012D2 RID: 4818 RVA: 0x0003A7B0 File Offset: 0x000389B0
		internal UnixNetworkInterface(string name)
		{
			this.name = name;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002050 File Offset: 0x00000250
		internal void AddAddress(IPAddress address)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0003A7CC File Offset: 0x000389CC
		internal void SetLinkLayerInfo(int index, byte[] macAddress, NetworkInterfaceType type)
		{
			this.macAddress = macAddress;
			this.type = type;
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0003A7E8 File Offset: 0x000389E8
		public override string Description
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x0003A7FC File Offset: 0x000389FC
		public override NetworkInterfaceType NetworkInterfaceType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x04000F16 RID: 3862
		protected IPInterfaceProperties ipproperties;

		// Token: 0x04000F17 RID: 3863
		private string name;

		// Token: 0x04000F18 RID: 3864
		protected List<IPAddress> addresses;

		// Token: 0x04000F19 RID: 3865
		private byte[] macAddress;

		// Token: 0x04000F1A RID: 3866
		private NetworkInterfaceType type;
	}
}
