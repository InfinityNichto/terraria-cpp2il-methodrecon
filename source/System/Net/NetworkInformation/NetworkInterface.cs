using System;
using Cpp2IlInjected;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002A2 RID: 674
	public abstract class NetworkInterface
	{
		// Token: 0x06001288 RID: 4744 RVA: 0x00039F8C File Offset: 0x0003818C
		public static NetworkInterface[] GetAllNetworkInterfaces()
		{
			if (!true)
			{
			}
			return SystemNetworkInterface.GetNetworkInterfaces();
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00002050 File Offset: 0x00000250
		public virtual string Description
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00002050 File Offset: 0x00000250
		public virtual IPInterfaceProperties GetIPProperties()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00002050 File Offset: 0x00000250
		public virtual OperationalStatus OperationalStatus
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x00002050 File Offset: 0x00000250
		public virtual NetworkInterfaceType NetworkInterfaceType
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00039FA4 File Offset: 0x000381A4
		protected NetworkInterface()
		{
		}
	}
}
