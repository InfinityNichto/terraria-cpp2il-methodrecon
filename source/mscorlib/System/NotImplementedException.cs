using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000E0 RID: 224
	[Serializable]
	public class NotImplementedException : SystemException
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x000133BC File Offset: 0x000115BC
		public NotImplementedException()
			: base("The method or operation is not implemented.")
		{
			this._HResult = 16385;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000133E0 File Offset: 0x000115E0
		public NotImplementedException(string message)
			: base(message)
		{
			this._HResult = 16385;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00013400 File Offset: 0x00011600
		protected NotImplementedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
