using System;

namespace System.Collections.Generic
{
	// Token: 0x02000634 RID: 1588
	public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06003098 RID: 12440
		int Count { get; }
	}
}
