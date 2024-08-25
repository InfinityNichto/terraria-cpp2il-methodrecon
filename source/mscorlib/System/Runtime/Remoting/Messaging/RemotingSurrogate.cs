using System;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003BA RID: 954
	internal class RemotingSurrogate : ISerializationSurrogate
	{
		// Token: 0x06001E8F RID: 7823 RVA: 0x00042E58 File Offset: 0x00041058
		public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc)
		{
			while (obj == null || si == null)
			{
			}
			if (!true)
			{
			}
			bool flag = RemotingServices.IsTransparentProxy(obj);
			RealProxy realProxy = RemotingServices.GetRealProxy(obj);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00042E88 File Offset: 0x00041088
		public RemotingSurrogate()
		{
		}
	}
}
