using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x02000359 RID: 857
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Class)]
	public class ProxyAttribute : Attribute, IContextAttribute
	{
		// Token: 0x06001C8F RID: 7311 RVA: 0x0003E228 File Offset: 0x0003C428
		public virtual MarshalByRefObject CreateInstance(Type serverType)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0003E240 File Offset: 0x0003C440
		public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext)
		{
			if (!true)
			{
			}
			return RemotingServices.GetRealProxy(RemotingServices.GetProxyForRemoteObject(objRef, serverType));
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0003E25C File Offset: 0x0003C45C
		[ComVisible(true)]
		public void GetPropertiesForNewContext(IConstructionCallMessage msg)
		{
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0003E26C File Offset: 0x0003C46C
		[ComVisible(true)]
		public bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			return true;
		}
	}
}
