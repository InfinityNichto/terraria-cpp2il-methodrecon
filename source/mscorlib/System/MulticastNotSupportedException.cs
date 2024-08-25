using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000DE RID: 222
	[Serializable]
	public sealed class MulticastNotSupportedException : SystemException
	{
		// Token: 0x0600083F RID: 2111 RVA: 0x0001334C File Offset: 0x0001154C
		public MulticastNotSupportedException()
			: base("Attempted to add multiple callbacks to a delegate that does not support multicast.")
		{
			this._HResult = 5396;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00013370 File Offset: 0x00011570
		public MulticastNotSupportedException(string message)
			: base(message)
		{
			this._HResult = 5396;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00013390 File Offset: 0x00011590
		internal MulticastNotSupportedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
