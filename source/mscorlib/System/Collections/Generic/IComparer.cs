using System;

namespace System.Collections.Generic
{
	// Token: 0x0200062B RID: 1579
	public interface IComparer<in T>
	{
		// Token: 0x06003086 RID: 12422
		int Compare(T x, T y);
	}
}
