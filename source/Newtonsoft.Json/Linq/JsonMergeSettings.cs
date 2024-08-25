using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BC RID: 188
	[Preserve]
	public class JsonMergeSettings
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0001226C File Offset: 0x0001046C
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00012280 File Offset: 0x00010480
		public MergeArrayHandling MergeArrayHandling
		{
			get
			{
				return this._mergeArrayHandling;
			}
			set
			{
				this._mergeArrayHandling = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00012294 File Offset: 0x00010494
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000122A8 File Offset: 0x000104A8
		public MergeNullValueHandling MergeNullValueHandling
		{
			get
			{
				return this._mergeNullValueHandling;
			}
			set
			{
				this._mergeNullValueHandling = value;
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000122BC File Offset: 0x000104BC
		public JsonMergeSettings()
		{
		}

		// Token: 0x040002F3 RID: 755
		private MergeArrayHandling _mergeArrayHandling;

		// Token: 0x040002F4 RID: 756
		private MergeNullValueHandling _mergeNullValueHandling;
	}
}
