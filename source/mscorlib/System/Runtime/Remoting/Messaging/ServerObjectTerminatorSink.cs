using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003BF RID: 959
	internal class ServerObjectTerminatorSink : IMessageSink
	{
		// Token: 0x06001EAF RID: 7855 RVA: 0x000431E8 File Offset: 0x000413E8
		public ServerObjectTerminatorSink(IMessageSink nextSink)
		{
			this._nextSink = nextSink;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00043204 File Offset: 0x00041404
		public IMessage SyncProcessMessage(IMessage msg)
		{
			if (!true)
			{
			}
			Identity messageTargetIdentity = RemotingServices.GetMessageTargetIdentity(msg);
			if (messageTargetIdentity != null)
			{
			}
			int num = 1;
			long num2 = 0L;
			long num3 = 0L;
			messageTargetIdentity.NotifyServerDynamicSinks(num != 0, msg, num2 != 0L, num3 != 0L);
			IMessageSink nextSink = this._nextSink;
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			messageTargetIdentity.NotifyServerDynamicSinks(num4 != 0L, msg, num5 != 0L, num6 != 0L);
			throw new InvalidCastException();
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00043254 File Offset: 0x00041454
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			if (!true)
			{
			}
			Identity messageTargetIdentity = RemotingServices.GetMessageTargetIdentity(msg);
			if (messageTargetIdentity != null)
			{
			}
			bool hasServerDynamicSinks = messageTargetIdentity.HasServerDynamicSinks;
			int num = 1;
			int num2 = 1;
			long num3 = 0L;
			messageTargetIdentity.NotifyServerDynamicSinks(num != 0, msg, num3 != 0L, num2 != 0);
			if (replySink != null)
			{
			}
			IMessageSink nextSink = this._nextSink;
			int num4 = 1;
			int num5 = 1;
			long num6 = 0L;
			messageTargetIdentity.NotifyServerDynamicSinks(num6 != 0L, msg, num4 != 0, num5 != 0);
			throw new InvalidCastException();
		}

		// Token: 0x04000F6E RID: 3950
		private IMessageSink _nextSink;
	}
}
