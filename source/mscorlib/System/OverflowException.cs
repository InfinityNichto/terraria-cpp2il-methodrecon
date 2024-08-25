using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public class OverflowException : ArithmeticException
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x0001578C File Offset: 0x0001398C
		public OverflowException()
			: base("Arithmetic operation resulted in an overflow.")
		{
			this._HResult = 1;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000157AC File Offset: 0x000139AC
		public OverflowException(string message)
			: base(message)
		{
			this._HResult = 5398;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000157CC File Offset: 0x000139CC
		public OverflowException(string message, Exception innerException)
			: base(message, innerException)
		{
			this._HResult = 5398;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000157EC File Offset: 0x000139EC
		protected OverflowException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
