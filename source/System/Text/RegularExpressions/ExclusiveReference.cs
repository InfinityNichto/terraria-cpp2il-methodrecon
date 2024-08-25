using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000AE RID: 174
	internal sealed class ExclusiveReference
	{
		// Token: 0x06000350 RID: 848 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		public RegexRunner Get()
		{
			int num;
			while (num != 0)
			{
			}
			RegexRunner @ref = this._ref;
			if (@ref != null)
			{
				this._obj = @ref;
				return @ref;
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		public void Release(RegexRunner obj)
		{
			while (obj == null)
			{
			}
			int num;
			if (this._obj == null && num == 0)
			{
				if (this._ref == null)
				{
					this._ref = obj;
				}
				return;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public ExclusiveReference()
		{
		}

		// Token: 0x040002A5 RID: 677
		private RegexRunner _ref;

		// Token: 0x040002A6 RID: 678
		private RegexRunner _obj;

		// Token: 0x040002A7 RID: 679
		private int _locked;
	}
}
