using System;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x0200038C RID: 908
	internal class RemoteActivator : MarshalByRefObject, IActivator
	{
		// Token: 0x06001D6B RID: 7531 RVA: 0x000403C8 File Offset: 0x0003E5C8
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			object obj;
			if (obj != null || obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0000207A File Offset: 0x0000027A
		public IActivator NextActivator
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
