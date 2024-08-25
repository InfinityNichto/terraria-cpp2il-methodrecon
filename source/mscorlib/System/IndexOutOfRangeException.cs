using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000CD RID: 205
	[Serializable]
	public sealed class IndexOutOfRangeException : SystemException
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x000122A8 File Offset: 0x000104A8
		public IndexOutOfRangeException()
			: base("Index was outside the bounds of the array.")
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000122C0 File Offset: 0x000104C0
		public IndexOutOfRangeException(string message)
			: base(message)
		{
			this._HResult = 5384;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000122E0 File Offset: 0x000104E0
		internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
