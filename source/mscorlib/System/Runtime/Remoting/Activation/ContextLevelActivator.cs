using System;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x02000387 RID: 903
	[Serializable]
	internal class ContextLevelActivator : IActivator
	{
		// Token: 0x06001D5D RID: 7517 RVA: 0x000402B8 File Offset: 0x0003E4B8
		public ContextLevelActivator(IActivator next)
		{
			this.m_NextActivator = next;
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x000402D4 File Offset: 0x0003E4D4
		public IActivator NextActivator
		{
			get
			{
				return this.m_NextActivator;
			}
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000402E8 File Offset: 0x0003E4E8
		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			ClientActivatedIdentity clientActivatedIdentity;
			RemotingServices.SetMessageTargetIdentity(ctorCall, clientActivatedIdentity);
			if (ctorCall != null)
			{
			}
			Context context = Context.CreateNewContext(ctorCall);
			clientActivatedIdentity._context = context;
			Context context2 = AppDomain.InternalSetContext(context);
			IActivator nextActivator = this.m_NextActivator;
			long num = 0L;
			int num2 = 4;
			Context context3 = AppDomain.InternalSetContext(context2);
			if (num == 0L)
			{
				if (num2 != 0)
				{
				}
				IActivator nextActivator2 = this.m_NextActivator;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04000ECC RID: 3788
		private IActivator m_NextActivator;
	}
}
