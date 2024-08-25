using System;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x02000385 RID: 901
	internal class AppDomainLevelActivator : IActivator
	{
		// Token: 0x06001D57 RID: 7511 RVA: 0x000401DC File Offset: 0x0003E3DC
		public AppDomainLevelActivator(string activationUrl, IActivator next)
		{
			this._activationUrl = activationUrl;
			this._next = next;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00040200 File Offset: 0x0003E400
		public IActivator NextActivator
		{
			get
			{
				return this._next;
			}
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00040214 File Offset: 0x0003E414
		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			if (!true)
			{
			}
			string activationUrl = this._activationUrl;
			Type type;
			object obj = RemotingServices.Connect(type, activationUrl);
			long num;
			if (obj != null)
			{
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				num = 0L;
			}
			long value = num.m_value;
			long value2 = num.m_value;
			Identity identity;
			if (identity == null)
			{
				ClientIdentity clientIdentity;
				RemotingServices.SetMessageTargetIdentity(ctorCall, clientIdentity);
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x04000ECA RID: 3786
		private string _activationUrl;

		// Token: 0x04000ECB RID: 3787
		private IActivator _next;
	}
}
