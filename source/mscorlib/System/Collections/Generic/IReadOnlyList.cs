using System;

namespace System.Collections.Generic
{
	// Token: 0x02000636 RID: 1590
	public interface IReadOnlyList<out T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x170007D3 RID: 2003
		T this[int index] { get; }
	}
}
