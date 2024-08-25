using System;

namespace System.Collections.Generic
{
	// Token: 0x02000657 RID: 1623
	[Serializable]
	internal class NullableEqualityComparer<T> : EqualityComparer<T?> where T : struct, IEquatable<T>
	{
		// Token: 0x0600318D RID: 12685 RVA: 0x0006B724 File Offset: 0x00069924
		public override bool Equals(T? x, T? y)
		{
			return default(bool);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x0006B73C File Offset: 0x0006993C
		public override int GetHashCode(T? obj)
		{
			return 0;
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x0006B754 File Offset: 0x00069954
		internal override int IndexOf(T?[] array, T? value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x0006B76C File Offset: 0x0006996C
		internal override int LastIndexOf(T?[] array, T? value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x0006B784 File Offset: 0x00069984
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x0006B79C File Offset: 0x0006999C
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x0001B05E File Offset: 0x0001925E
		public NullableEqualityComparer()
		{
		}
	}
}
