using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Collections.Concurrent
{
	// Token: 0x0200061C RID: 1564
	public interface IProducerConsumerCollection<T> : IEnumerable<T>, IEnumerable, ICollection
	{
		// Token: 0x06002FC7 RID: 12231
		bool TryAdd(T item);

		// Token: 0x06002FC8 RID: 12232
		bool TryTake([Out] T item);

		// Token: 0x06002FC9 RID: 12233
		T[] ToArray();
	}
}
