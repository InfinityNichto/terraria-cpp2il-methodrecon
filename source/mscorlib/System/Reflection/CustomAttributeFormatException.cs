using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004CD RID: 1229
	[Serializable]
	public class CustomAttributeFormatException : FormatException
	{
		// Token: 0x0600237A RID: 9082 RVA: 0x00050458 File Offset: 0x0004E658
		public CustomAttributeFormatException()
		{
			this._HResult = 5637;
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00050470 File Offset: 0x0004E670
		public CustomAttributeFormatException(string message)
		{
			this._HResult = 5637;
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00050488 File Offset: 0x0004E688
		public CustomAttributeFormatException(string message, Exception inner)
			: base(message, inner)
		{
			this._HResult = 5637;
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000504A8 File Offset: 0x0004E6A8
		protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
