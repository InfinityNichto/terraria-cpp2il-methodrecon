using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000E1 RID: 225
	[Serializable]
	public class NotSupportedException : SystemException
	{
		// Token: 0x06000846 RID: 2118 RVA: 0x00013418 File Offset: 0x00011618
		public NotSupportedException()
			: base("Specified method is not supported.")
		{
			this._HResult = 5397;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0001343C File Offset: 0x0001163C
		public NotSupportedException(string message)
			: base(message)
		{
			this._HResult = 5397;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0001345C File Offset: 0x0001165C
		public NotSupportedException(string message, Exception innerException)
			: base(message, innerException)
		{
			this._HResult = 5397;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0001347C File Offset: 0x0001167C
		protected NotSupportedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
