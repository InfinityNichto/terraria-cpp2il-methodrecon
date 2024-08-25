using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020001C1 RID: 449
	[Serializable]
	public class SynchronizationLockException : SystemException
	{
		// Token: 0x060010C0 RID: 4288 RVA: 0x00023810 File Offset: 0x00021A10
		public SynchronizationLockException()
			: base("Object synchronization method was called from an unsynchronized block of code.")
		{
			this._HResult = 5400;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00023834 File Offset: 0x00021A34
		public SynchronizationLockException(string message)
			: base(message)
		{
			this._HResult = 5400;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00023854 File Offset: 0x00021A54
		protected SynchronizationLockException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
