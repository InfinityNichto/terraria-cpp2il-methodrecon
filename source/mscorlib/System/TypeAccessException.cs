using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000111 RID: 273
	[Serializable]
	public class TypeAccessException : TypeLoadException
	{
		// Token: 0x06000A9E RID: 2718 RVA: 0x0001806C File Offset: 0x0001626C
		public TypeAccessException()
			: base("Attempt to access the type failed.")
		{
			this._HResult = 5443;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00018090 File Offset: 0x00016290
		protected TypeAccessException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
