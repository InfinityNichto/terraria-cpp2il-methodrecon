using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020001BC RID: 444
	[Serializable]
	public class LockRecursionException : Exception
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x00023680 File Offset: 0x00021880
		public LockRecursionException()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00023698 File Offset: 0x00021898
		public LockRecursionException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x000236B0 File Offset: 0x000218B0
		protected LockRecursionException(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor(info, context);
		}
	}
}
