using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x0200034E RID: 846
	internal class SingleCallIdentity : ServerIdentity
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x0003DB90 File Offset: 0x0003BD90
		public SingleCallIdentity(string objectUri, Context context, Type objectType)
			: base(objectUri, context, objectType)
		{
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0003DBA8 File Offset: 0x0003BDA8
		public override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			Type objectType = this._objectType;
			int num = 1;
			object obj = Activator.CreateInstance(objectType, num != 0);
			if (obj != null)
			{
			}
			ServerIdentity serverIdentity;
			if (serverIdentity == null)
			{
			}
			Context context = this._context;
			if (obj != null)
			{
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0003DBF0 File Offset: 0x0003BDF0
		public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
		{
			Type objectType = this._objectType;
			int num = 1;
			object obj = Activator.CreateInstance(objectType, num != 0);
			if (obj != null)
			{
			}
			Context context = this._context;
			if (obj != null && obj != null && obj == null)
			{
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}
	}
}
