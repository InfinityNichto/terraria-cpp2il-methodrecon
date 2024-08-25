using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003CF RID: 975
	public interface ISurrogateSelector
	{
		// Token: 0x06001EE4 RID: 7908
		ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, [Out] ISurrogateSelector selector);
	}
}
