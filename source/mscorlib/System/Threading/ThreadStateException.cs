using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020001C5 RID: 453
	[Serializable]
	public class ThreadStateException : SystemException
	{
		// Token: 0x060010C5 RID: 4293 RVA: 0x000238E4 File Offset: 0x00021AE4
		public ThreadStateException()
			: base("Thread was in an invalid state for the operation being executed.")
		{
			this._HResult = 5408;
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00023908 File Offset: 0x00021B08
		public ThreadStateException(string message)
			: base(message)
		{
			this._HResult = 5408;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00023928 File Offset: 0x00021B28
		protected ThreadStateException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
