using System;
using System.Collections;
using System.Globalization;

namespace System
{
	// Token: 0x02000080 RID: 128
	[Serializable]
	internal class InvariantComparer : IComparer
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x000069D0 File Offset: 0x00004BD0
		internal InvariantComparer()
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			this.m_compareInfo = invariantCulture;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000069F8 File Offset: 0x00004BF8
		public int Compare(object a, object b)
		{
			long num;
			int num2;
			if (a == null || b == null)
			{
				num = 0L;
				if (b == null)
				{
					return num2;
				}
			}
			if (num != 0L && b != null)
			{
				CompareInfo compareInfo = this.m_compareInfo;
			}
			return num2;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00006A20 File Offset: 0x00004C20
		// Note: this type is marked as 'beforefieldinit'.
		static InvariantComparer()
		{
		}

		// Token: 0x0400016B RID: 363
		private CompareInfo m_compareInfo;

		// Token: 0x0400016C RID: 364
		internal static readonly global::System.InvariantComparer Default;
	}
}
