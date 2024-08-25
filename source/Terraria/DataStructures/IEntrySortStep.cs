using System;
using System.Collections.Generic;

namespace Terraria.DataStructures
{
	// Token: 0x02000626 RID: 1574
	public interface IEntrySortStep<T> : IComparer<T>
	{
		// Token: 0x060035F5 RID: 13813
		string GetDisplayNameKey();
	}
}
