using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000A6 RID: 166
	[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
	[Serializable]
	public sealed class ExecutionEngineException : SystemException
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
		public ExecutionEngineException()
			: base("Internal error in the runtime.")
		{
			this._HResult = 5382;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		public ExecutionEngineException(string message)
			: base(message)
		{
			this._HResult = 5382;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0000FA18 File Offset: 0x0000DC18
		internal ExecutionEngineException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
