using System;

namespace System.Collections.Generic
{
	// Token: 0x02000632 RID: 1586
	public interface IEqualityComparer<in T>
	{
		// Token: 0x06003091 RID: 12433
		bool Equals(T x, T y);

		// Token: 0x06003092 RID: 12434
		int GetHashCode(T obj);
	}
}
