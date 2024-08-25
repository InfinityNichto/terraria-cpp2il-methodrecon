using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003BB RID: 955
	internal class ObjRefSurrogate : ISerializationSurrogate
	{
		// Token: 0x06001E92 RID: 7826 RVA: 0x00042E9C File Offset: 0x0004109C
		public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc)
		{
			if (obj != null && si != null)
			{
				long num = 0L;
				si.AddValue("fIsMarshalled", (int)num);
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00042EC4 File Offset: 0x000410C4
		public ObjRefSurrogate()
		{
		}
	}
}
