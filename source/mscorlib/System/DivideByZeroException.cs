using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	public class DivideByZeroException : ArithmeticException
	{
		// Token: 0x06000645 RID: 1605 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public DivideByZeroException()
			: base("Attempted to divide by zero.")
		{
			this._HResult = 18;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		protected DivideByZeroException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
