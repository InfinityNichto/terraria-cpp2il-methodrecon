using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class UriFormatException : FormatException, ISerializable
	{
		// Token: 0x0600027C RID: 636 RVA: 0x0000A0D0 File Offset: 0x000082D0
		public UriFormatException()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public UriFormatException(string textString)
			: base(textString)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000A0F8 File Offset: 0x000082F8
		protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000A110 File Offset: 0x00008310
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
}
