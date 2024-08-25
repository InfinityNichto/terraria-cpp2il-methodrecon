using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace System.Diagnostics.Contracts
{
	// Token: 0x020005D6 RID: 1494
	public static class Contract
	{
		// Token: 0x06002D7A RID: 11642 RVA: 0x00064A80 File Offset: 0x00062C80
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			if (collection != null && !false)
			{
				return "collection" != null;
			}
			throw new OutOfMemoryException();
		}
	}
}
