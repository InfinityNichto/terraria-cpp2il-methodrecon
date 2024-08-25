using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020001FB RID: 507
	[ComVisible(true)]
	[Serializable]
	public class ThreadInterruptedException : SystemException
	{
		// Token: 0x06001230 RID: 4656 RVA: 0x000266BC File Offset: 0x000248BC
		public ThreadInterruptedException()
		{
			if (!true)
			{
			}
			string messageFromNativeResources = Exception.GetMessageFromNativeResources(Exception.ExceptionMessageKind.ThreadInterrupted);
			base..ctor(messageFromNativeResources);
			base.SetErrorCode(5401);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000266E8 File Offset: 0x000248E8
		protected ThreadInterruptedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
