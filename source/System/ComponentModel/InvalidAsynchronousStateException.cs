using System;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	// Token: 0x02000390 RID: 912
	[Serializable]
	public class InvalidAsynchronousStateException : ArgumentException
	{
		// Token: 0x060017C0 RID: 6080 RVA: 0x00043808 File Offset: 0x00041A08
		public InvalidAsynchronousStateException()
		{
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00043818 File Offset: 0x00041A18
		public InvalidAsynchronousStateException(string message)
			: base(message)
		{
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0004382C File Offset: 0x00041A2C
		public InvalidAsynchronousStateException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00043844 File Offset: 0x00041A44
		protected InvalidAsynchronousStateException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
