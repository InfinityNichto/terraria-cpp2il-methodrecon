using System;

namespace System.Collections.Generic
{
	// Token: 0x02000631 RID: 1585
	public interface IEnumerator<out T> : IDisposable, IEnumerator
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06003090 RID: 12432
		T Current { get; }
	}
}
