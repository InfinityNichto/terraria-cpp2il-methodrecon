using System;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x02000376 RID: 886
	[Serializable]
	internal class CrossAppDomainData
	{
		// Token: 0x06001D2A RID: 7466 RVA: 0x0003FD54 File Offset: 0x0003DF54
		internal CrossAppDomainData(int domainId)
		{
			this._DomainID = domainId;
			if (!true)
			{
			}
			string processId = RemotingConfiguration.ProcessId;
			this._processGuid = processId;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0003FD80 File Offset: 0x0003DF80
		internal int DomainID
		{
			get
			{
				return this._DomainID;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0003FD94 File Offset: 0x0003DF94
		internal string ProcessID
		{
			get
			{
				return this._processGuid;
			}
		}

		// Token: 0x04000EBB RID: 3771
		private object _ContextID;

		// Token: 0x04000EBC RID: 3772
		private int _DomainID;

		// Token: 0x04000EBD RID: 3773
		private string _processGuid;
	}
}
