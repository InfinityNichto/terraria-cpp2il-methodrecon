using System;

namespace System.Collections
{
	// Token: 0x020005E8 RID: 1512
	public interface IEnumerator
	{
		// Token: 0x06002DB7 RID: 11703
		bool MoveNext();

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002DB8 RID: 11704
		object Current { get; }

		// Token: 0x06002DB9 RID: 11705
		void Reset();
	}
}
