using System;

namespace System.Collections.Generic
{
	// Token: 0x02000630 RID: 1584
	public interface IEnumerable<out T> : IEnumerable
	{
		// Token: 0x0600308F RID: 12431
		IEnumerator<T> GetEnumerator();
	}
}
