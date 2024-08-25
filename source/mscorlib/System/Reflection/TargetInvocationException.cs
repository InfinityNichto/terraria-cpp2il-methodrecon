using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004F3 RID: 1267
	[Serializable]
	public sealed class TargetInvocationException : ApplicationException
	{
		// Token: 0x060024D2 RID: 9426 RVA: 0x000515C4 File Offset: 0x0004F7C4
		public TargetInvocationException(Exception inner)
			: base("Exception has been thrown by the target of an invocation.", inner)
		{
			this._HResult = 5636;
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000515E8 File Offset: 0x0004F7E8
		public TargetInvocationException(string message, Exception inner)
			: base(message, inner)
		{
			this._HResult = 5636;
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00051608 File Offset: 0x0004F808
		internal TargetInvocationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
