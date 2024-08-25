using System;

namespace System.Collections.Generic
{
	// Token: 0x02000653 RID: 1619
	[Serializable]
	internal class NullableComparer<T> : Comparer<T?> where T : struct, IComparable<T>
	{
		// Token: 0x06003175 RID: 12661 RVA: 0x0006B550 File Offset: 0x00069750
		public override int Compare(T? x, T? y)
		{
			return 0;
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0006B568 File Offset: 0x00069768
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x0006B580 File Offset: 0x00069780
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x0001B05E File Offset: 0x0001925E
		public NullableComparer()
		{
		}
	}
}
