using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000117 RID: 279
	[Serializable]
	public class UnauthorizedAccessException : SystemException
	{
		// Token: 0x06000B01 RID: 2817 RVA: 0x00018868 File Offset: 0x00016A68
		public UnauthorizedAccessException()
			: base("Attempted to perform an unauthorized operation.")
		{
			this._HResult = 5;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00018888 File Offset: 0x00016A88
		public UnauthorizedAccessException(string message)
			: base(message)
		{
			this._HResult = 5;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000188A4 File Offset: 0x00016AA4
		public UnauthorizedAccessException(string message, Exception inner)
			: base(message, inner)
		{
			this._HResult = 5;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000188C0 File Offset: 0x00016AC0
		protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
