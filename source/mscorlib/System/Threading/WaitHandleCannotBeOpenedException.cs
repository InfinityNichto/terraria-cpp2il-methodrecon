using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public class WaitHandleCannotBeOpenedException : ApplicationException
	{
		// Token: 0x060010C9 RID: 4297 RVA: 0x00023950 File Offset: 0x00021B50
		public WaitHandleCannotBeOpenedException()
		{
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00023960 File Offset: 0x00021B60
		public WaitHandleCannotBeOpenedException(string message)
			: base(message)
		{
			this._HResult = 5420;
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00023980 File Offset: 0x00021B80
		protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
