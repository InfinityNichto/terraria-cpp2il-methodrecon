using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class MethodAccessException : MemberAccessException
	{
		// Token: 0x06000837 RID: 2103 RVA: 0x0001323C File Offset: 0x0001143C
		public MethodAccessException()
			: base("Attempt to access the method failed.")
		{
			this._HResult = 5392;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00013260 File Offset: 0x00011460
		public MethodAccessException(string message)
			: base(message)
		{
			this._HResult = 5392;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00013280 File Offset: 0x00011480
		protected MethodAccessException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
