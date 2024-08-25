using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020001FA RID: 506
	[ComVisible(true)]
	[Serializable]
	public sealed class ThreadAbortException : SystemException
	{
		// Token: 0x0600122E RID: 4654 RVA: 0x00026678 File Offset: 0x00024878
		private ThreadAbortException()
		{
			if (!true)
			{
			}
			string messageFromNativeResources = Exception.GetMessageFromNativeResources(Exception.ExceptionMessageKind.ThreadAbort);
			base..ctor(messageFromNativeResources);
			base.SetErrorCode(5424);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000266A4 File Offset: 0x000248A4
		internal ThreadAbortException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
