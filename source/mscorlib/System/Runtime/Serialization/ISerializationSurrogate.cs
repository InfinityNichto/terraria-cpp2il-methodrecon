using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003CE RID: 974
	public interface ISerializationSurrogate
	{
		// Token: 0x06001EE2 RID: 7906
		void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

		// Token: 0x06001EE3 RID: 7907
		object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
	}
}
