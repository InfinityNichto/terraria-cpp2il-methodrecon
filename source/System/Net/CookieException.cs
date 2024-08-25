using System;
using System.Runtime.Serialization;

namespace System.Net
{
	// Token: 0x02000219 RID: 537
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		// Token: 0x06000D53 RID: 3411 RVA: 0x0002AF00 File Offset: 0x00029100
		public CookieException()
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0002AF14 File Offset: 0x00029114
		internal CookieException(string message)
			: base(message)
		{
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0002AF28 File Offset: 0x00029128
		internal CookieException(string message, Exception inner)
			: base(message, inner)
		{
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0002AF40 File Offset: 0x00029140
		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0002AF58 File Offset: 0x00029158
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0002AF70 File Offset: 0x00029170
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
}
