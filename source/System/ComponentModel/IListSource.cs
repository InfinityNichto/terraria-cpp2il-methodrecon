using System;
using System.Collections;

namespace System.ComponentModel
{
	// Token: 0x02000384 RID: 900
	[MergableProperty(false)]
	public interface IListSource
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600179A RID: 6042
		bool ContainsListCollection { get; }

		// Token: 0x0600179B RID: 6043
		IList GetList();
	}
}
