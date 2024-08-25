using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x0200033B RID: 827
	[Serializable]
	internal class EnvoyInfo : IEnvoyInfo
	{
		// Token: 0x06001BB9 RID: 7097 RVA: 0x0003BC88 File Offset: 0x00039E88
		public EnvoyInfo(IMessageSink sinks)
		{
			this.envoySinks = sinks;
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0003BCA4 File Offset: 0x00039EA4
		public IMessageSink EnvoySinks
		{
			get
			{
				return this.envoySinks;
			}
		}

		// Token: 0x04000E20 RID: 3616
		private IMessageSink envoySinks;
	}
}
