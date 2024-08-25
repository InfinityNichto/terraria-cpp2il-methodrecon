using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class ArrayTypeMismatchException : SystemException
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x0000C514 File Offset: 0x0000A714
		public ArrayTypeMismatchException()
			: base("Attempted to access an element as a type incompatible with the array.")
		{
			this._HResult = 5379;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000C538 File Offset: 0x0000A738
		protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
