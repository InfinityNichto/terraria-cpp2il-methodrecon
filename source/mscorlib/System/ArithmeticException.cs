using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000086 RID: 134
	[Serializable]
	public class ArithmeticException : SystemException
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x0000C150 File Offset: 0x0000A350
		public ArithmeticException()
			: base("Overflow or underflow in the arithmetic operation.")
		{
			this._HResult = 534;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000C174 File Offset: 0x0000A374
		public ArithmeticException(string message)
			: base(message)
		{
			this._HResult = 534;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000C194 File Offset: 0x0000A394
		public ArithmeticException(string message, Exception innerException)
			: base(message, innerException)
		{
			this._HResult = 534;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		protected ArithmeticException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
