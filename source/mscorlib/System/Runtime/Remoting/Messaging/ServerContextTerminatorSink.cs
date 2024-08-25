using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003BE RID: 958
	internal class ServerContextTerminatorSink : IMessageSink
	{
		// Token: 0x06001EAC RID: 7852 RVA: 0x00043190 File Offset: 0x00041390
		public IMessage SyncProcessMessage(IMessage msg)
		{
			if (msg != null)
			{
				if (msg != null)
				{
					if (msg == null)
					{
						return msg;
					}
				}
			}
			else
			{
				Identity messageTargetIdentity = RemotingServices.GetMessageTargetIdentity(msg);
			}
			IMessage message;
			return message;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000431B8 File Offset: 0x000413B8
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			if (!true)
			{
			}
			Identity messageTargetIdentity = RemotingServices.GetMessageTargetIdentity(msg);
			throw new InvalidCastException();
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x000431D4 File Offset: 0x000413D4
		public ServerContextTerminatorSink()
		{
		}
	}
}
