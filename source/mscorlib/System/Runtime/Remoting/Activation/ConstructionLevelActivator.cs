using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x02000386 RID: 902
	[Serializable]
	internal class ConstructionLevelActivator : IActivator
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0004026C File Offset: 0x0003E46C
		public IActivator NextActivator
		{
			get
			{
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0004027C File Offset: 0x0003E47C
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			IMessageSink serverContextSinkChain = Thread.CurrentContext.GetServerContextSinkChain();
			if (serverContextSinkChain == null || serverContextSinkChain != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x000402A4 File Offset: 0x0003E4A4
		public ConstructionLevelActivator()
		{
		}
	}
}
