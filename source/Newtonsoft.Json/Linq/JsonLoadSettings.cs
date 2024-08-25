using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BB RID: 187
	[Preserve]
	public class JsonLoadSettings
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00012208 File Offset: 0x00010408
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x0001221C File Offset: 0x0001041C
		public CommentHandling CommentHandling
		{
			get
			{
				return this._commentHandling;
			}
			set
			{
				this._commentHandling = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00012230 File Offset: 0x00010430
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00012244 File Offset: 0x00010444
		public LineInfoHandling LineInfoHandling
		{
			get
			{
				return this._lineInfoHandling;
			}
			set
			{
				this._lineInfoHandling = value;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00012258 File Offset: 0x00010458
		public JsonLoadSettings()
		{
		}

		// Token: 0x040002F1 RID: 753
		private CommentHandling _commentHandling;

		// Token: 0x040002F2 RID: 754
		private LineInfoHandling _lineInfoHandling;
	}
}
