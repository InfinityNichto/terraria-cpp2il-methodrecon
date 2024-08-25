using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004BA RID: 1210
	[Serializable]
	public sealed class AmbiguousMatchException : SystemException
	{
		// Token: 0x0600235B RID: 9051 RVA: 0x00050220 File Offset: 0x0004E420
		public AmbiguousMatchException()
			: base("Ambiguous match found.")
		{
			this._HResult = 8477;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00050244 File Offset: 0x0004E444
		public AmbiguousMatchException(string message)
			: base(message)
		{
			this._HResult = 8477;
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00050264 File Offset: 0x0004E464
		internal AmbiguousMatchException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
