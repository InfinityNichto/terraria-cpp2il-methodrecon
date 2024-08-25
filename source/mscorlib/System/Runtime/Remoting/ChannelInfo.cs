using System;
using System.Runtime.Remoting.Channels;

namespace System.Runtime.Remoting
{
	// Token: 0x02000337 RID: 823
	[Serializable]
	internal class ChannelInfo : IChannelInfo
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x0003BB04 File Offset: 0x00039D04
		public ChannelInfo()
		{
			if (!true)
			{
			}
			object[] currentChannelInfo = ChannelServices.GetCurrentChannelInfo();
			this.channelData = currentChannelInfo;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0003BB2C File Offset: 0x00039D2C
		public ChannelInfo(object remoteChannelData)
		{
			if (remoteChannelData == null || remoteChannelData != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x0003BB4C File Offset: 0x00039D4C
		public object[] ChannelData
		{
			get
			{
				return this.channelData;
			}
		}

		// Token: 0x04000E18 RID: 3608
		private object[] channelData;
	}
}
