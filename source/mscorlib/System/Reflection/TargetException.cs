using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004F2 RID: 1266
	[Serializable]
	public class TargetException : ApplicationException
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x0005155C File Offset: 0x0004F75C
		public TargetException()
		{
			this._HResult = 5635;
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00051574 File Offset: 0x0004F774
		public TargetException(string message)
		{
			this._HResult = 5635;
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0005158C File Offset: 0x0004F78C
		public TargetException(string message, Exception inner)
			: base(message, inner)
		{
			this._HResult = 5635;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000515AC File Offset: 0x0004F7AC
		protected TargetException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
