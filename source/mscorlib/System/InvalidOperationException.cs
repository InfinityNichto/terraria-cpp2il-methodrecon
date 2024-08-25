using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000D2 RID: 210
	[Serializable]
	public class InvalidOperationException : SystemException
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x00012A78 File Offset: 0x00010C78
		public InvalidOperationException()
			: base("Operation is not valid due to the current state of the object.")
		{
			this._HResult = 5385;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00012A9C File Offset: 0x00010C9C
		public InvalidOperationException(string message)
			: base(message)
		{
			this._HResult = 5385;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00012ABC File Offset: 0x00010CBC
		public InvalidOperationException(string message, Exception innerException)
			: base(message, innerException)
		{
			this._HResult = 5385;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00012ADC File Offset: 0x00010CDC
		protected InvalidOperationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
