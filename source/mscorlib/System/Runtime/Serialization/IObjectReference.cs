using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003C6 RID: 966
	public interface IObjectReference
	{
		// Token: 0x06001EC4 RID: 7876
		object GetRealObject(StreamingContext context);
	}
}
