using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020001BF RID: 447
	[Serializable]
	public class SemaphoreFullException : SystemException
	{
		// Token: 0x060010BC RID: 4284 RVA: 0x0002375C File Offset: 0x0002195C
		public SemaphoreFullException()
			: base("Adding the specified count to the semaphore would cause it to exceed its maximum count.")
		{
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00023774 File Offset: 0x00021974
		protected SemaphoreFullException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
