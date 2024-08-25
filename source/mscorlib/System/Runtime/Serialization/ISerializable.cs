using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003C7 RID: 967
	public interface ISerializable
	{
		// Token: 0x06001EC5 RID: 7877
		void GetObjectData(SerializationInfo info, StreamingContext context);
	}
}
