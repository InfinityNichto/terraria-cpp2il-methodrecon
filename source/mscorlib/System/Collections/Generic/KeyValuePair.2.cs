using System;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000639 RID: 1593
	[Serializable]
	public readonly struct KeyValuePair<TKey, TValue>
	{
		// Token: 0x0600309F RID: 12447 RVA: 0x0006A78C File Offset: 0x0006898C
		public KeyValuePair(TKey key, TValue value)
		{
			this.key = key;
			this.value = value;
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x0006A7A8 File Offset: 0x000689A8
		public TKey Key
		{
			get
			{
				TKey tkey = this.key;
				TValue tvalue = this.value;
				return tkey;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x0000207A File Offset: 0x0000027A
		public TValue Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x0006A7C4 File Offset: 0x000689C4
		public override string ToString()
		{
			TKey tkey = this.key;
			TValue tvalue = this.value;
			TValue tvalue2 = this.value;
			string text;
			return text;
		}

		// Token: 0x04001A6D RID: 6765
		private readonly TKey key;

		// Token: 0x04001A6E RID: 6766
		private readonly TValue value;
	}
}
