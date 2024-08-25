using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000D1 RID: 209
	[Serializable]
	public class InvalidCastException : SystemException
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00012A28 File Offset: 0x00010C28
		public InvalidCastException()
		{
			this._HResult = 16386;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00012A40 File Offset: 0x00010C40
		public InvalidCastException(string message)
			: base(message)
		{
			this._HResult = 16386;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00012A60 File Offset: 0x00010C60
		protected InvalidCastException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
