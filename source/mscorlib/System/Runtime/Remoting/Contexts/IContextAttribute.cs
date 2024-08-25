using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200036C RID: 876
	[ComVisible(true)]
	public interface IContextAttribute
	{
		// Token: 0x06001D10 RID: 7440
		void GetPropertiesForNewContext(IConstructionCallMessage msg);

		// Token: 0x06001D11 RID: 7441
		bool IsContextOK(Context ctx, IConstructionCallMessage msg);
	}
}
