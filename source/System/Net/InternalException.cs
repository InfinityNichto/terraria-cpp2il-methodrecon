using System;
using System.Runtime.Serialization;

namespace System.Net
{
	// Token: 0x0200019F RID: 415
	internal class InternalException : SystemException
	{
		// Token: 0x06000A74 RID: 2676 RVA: 0x000232A0 File Offset: 0x000214A0
		internal InternalException()
		{
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000232B4 File Offset: 0x000214B4
		internal InternalException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}
	}
}
