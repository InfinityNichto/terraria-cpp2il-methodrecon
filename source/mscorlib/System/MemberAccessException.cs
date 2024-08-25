using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000D7 RID: 215
	[Serializable]
	public class MemberAccessException : SystemException
	{
		// Token: 0x06000810 RID: 2064 RVA: 0x00012CE8 File Offset: 0x00010EE8
		public MemberAccessException()
			: base("Cannot access member.")
		{
			this._HResult = 5402;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00012D0C File Offset: 0x00010F0C
		public MemberAccessException(string message)
			: base(message)
		{
			this._HResult = 5402;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00012D2C File Offset: 0x00010F2C
		protected MemberAccessException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
