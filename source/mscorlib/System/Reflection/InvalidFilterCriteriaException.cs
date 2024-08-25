using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004D7 RID: 1239
	[Serializable]
	public class InvalidFilterCriteriaException : ApplicationException
	{
		// Token: 0x060023AE RID: 9134 RVA: 0x00050704 File Offset: 0x0004E904
		public InvalidFilterCriteriaException()
		{
			this._HResult = 5633;
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0005071C File Offset: 0x0004E91C
		public InvalidFilterCriteriaException(string message)
		{
			this._HResult = 5633;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00050734 File Offset: 0x0004E934
		public InvalidFilterCriteriaException(string message, Exception inner)
			: base(message, inner)
		{
			this._HResult = 5633;
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00050754 File Offset: 0x0004E954
		protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
