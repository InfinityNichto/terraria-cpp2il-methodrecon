using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200010A RID: 266
	[Serializable]
	public class TimeoutException : SystemException
	{
		// Token: 0x060009DD RID: 2525 RVA: 0x00017644 File Offset: 0x00015844
		public TimeoutException()
		{
			this._HResult = 5381;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0001765C File Offset: 0x0001585C
		public TimeoutException(string message)
			: base(message)
		{
			this._HResult = 5381;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0001767C File Offset: 0x0001587C
		protected TimeoutException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
