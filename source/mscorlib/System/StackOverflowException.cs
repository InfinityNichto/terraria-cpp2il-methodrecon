using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000FC RID: 252
	[Serializable]
	public sealed class StackOverflowException : SystemException
	{
		// Token: 0x0600097A RID: 2426 RVA: 0x00016DE4 File Offset: 0x00014FE4
		public StackOverflowException()
			: base("Operation caused a stack overflow.")
		{
			this._HResult = 1001;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00016E08 File Offset: 0x00015008
		public StackOverflowException(string message)
			: base(message)
		{
			this._HResult = 1001;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00016E28 File Offset: 0x00015028
		internal StackOverflowException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
