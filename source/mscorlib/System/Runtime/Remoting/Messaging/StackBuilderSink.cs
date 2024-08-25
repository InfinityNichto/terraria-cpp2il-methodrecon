using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Proxies;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C1 RID: 961
	internal class StackBuilderSink : IMessageSink
	{
		// Token: 0x06001EB5 RID: 7861 RVA: 0x00043300 File Offset: 0x00041500
		public StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute)
		{
			this._target = obj;
			if (!true)
			{
			}
			bool flag = RemotingServices.IsTransparentProxy(obj);
			if (!true)
			{
			}
			RealProxy realProxy = RemotingServices.GetRealProxy(obj);
			this._rp = realProxy;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00043338 File Offset: 0x00041538
		public IMessage SyncProcessMessage(IMessage msg)
		{
			do
			{
				if (this._rp != null)
				{
				}
				MarshalByRefObject target = this._target;
			}
			while (msg == null || msg != null);
			throw new InvalidCastException();
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00043364 File Offset: 0x00041564
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			if ((msg == null || msg != null) && (replySink == null || replySink != null))
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00043384 File Offset: 0x00041584
		private void ExecuteAsyncMessage(object ob)
		{
			long num;
			if (ob != null)
			{
				if (ob == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				num = 0L;
			}
			if (ob != null && ob == null)
			{
				return;
			}
			RealProxy rp = this._rp;
			if (num != 0L)
			{
				if (num == 0L)
				{
					goto IL_0036;
				}
				if (rp != null)
				{
					RealProxy rp2 = this._rp;
					return;
				}
			}
			else
			{
				while (rp != null)
				{
				}
			}
			if (num != 0L)
			{
				if (num == 0L)
				{
					goto IL_0036;
				}
			}
			MarshalByRefObject target = this._target;
			return;
			IL_0036:
			throw new InvalidCastException();
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000433E0 File Offset: 0x000415E0
		private void CheckParameters(IMessage msg)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00043440 File Offset: 0x00041640
		[CompilerGenerated]
		private void <AsyncProcessMessage>b__4_0(object data)
		{
			this.ExecuteAsyncMessage(data);
		}

		// Token: 0x04000F71 RID: 3953
		private MarshalByRefObject _target;

		// Token: 0x04000F72 RID: 3954
		private RealProxy _rp;
	}
}
