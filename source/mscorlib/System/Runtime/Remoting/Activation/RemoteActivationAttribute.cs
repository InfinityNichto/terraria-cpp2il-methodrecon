using System;
using System.Collections;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x0200038B RID: 907
	internal class RemoteActivationAttribute : Attribute, IContextAttribute
	{
		// Token: 0x06001D68 RID: 7528 RVA: 0x0004035C File Offset: 0x0003E55C
		public RemoteActivationAttribute(IList contextProperties)
		{
			this._contextProperties = contextProperties;
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00040378 File Offset: 0x0003E578
		public bool IsContextOK(Context ctx, IConstructionCallMessage ctor)
		{
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00040388 File Offset: 0x0003E588
		public void GetPropertiesForNewContext(IConstructionCallMessage ctor)
		{
			IList contextProperties = this._contextProperties;
			if (contextProperties != null)
			{
				return;
			}
		}

		// Token: 0x04000ECD RID: 3789
		private IList _contextProperties;
	}
}
