using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.ComponentModel.Design
{
	// Token: 0x02000409 RID: 1033
	[Serializable]
	public class CheckoutException : ExternalException
	{
		// Token: 0x06001BFE RID: 7166 RVA: 0x0004CE54 File Offset: 0x0004B054
		public CheckoutException()
		{
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0004CE68 File Offset: 0x0004B068
		public CheckoutException(string message, int errorCode)
			: base(message, errorCode)
		{
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0004CE80 File Offset: 0x0004B080
		protected CheckoutException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0004CE98 File Offset: 0x0004B098
		// Note: this type is marked as 'beforefieldinit'.
		static CheckoutException()
		{
		}

		// Token: 0x0400138B RID: 5003
		public static readonly CheckoutException Canceled;
	}
}
