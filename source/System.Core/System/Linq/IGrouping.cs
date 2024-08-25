using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x0200001E RID: 30
	public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E9 RID: 233
		TKey Key { get; }
	}
}
