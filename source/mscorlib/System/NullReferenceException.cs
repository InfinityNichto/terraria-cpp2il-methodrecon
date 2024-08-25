using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000E2 RID: 226
	[Serializable]
	public class NullReferenceException : SystemException
	{
		// Token: 0x0600084A RID: 2122 RVA: 0x00013494 File Offset: 0x00011694
		public NullReferenceException()
			: base("Object reference not set to an instance of an object.")
		{
			this._HResult = 16387;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000134B8 File Offset: 0x000116B8
		public NullReferenceException(string message)
			: base(message)
		{
			this._HResult = 16387;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000134D8 File Offset: 0x000116D8
		protected NullReferenceException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
