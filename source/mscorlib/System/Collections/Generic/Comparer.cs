using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000651 RID: 1617
	[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
	[Serializable]
	public abstract class Comparer<T> : IComparer, IComparer<T>
	{
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x0000207A File Offset: 0x0000027A
		public static Comparer<T> Default
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x0006B4A8 File Offset: 0x000696A8
		private static Comparer<T> CreateComparer()
		{
			Type type;
			if (type != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600316E RID: 12654
		public abstract int Compare(T x, T y);

		// Token: 0x0600316F RID: 12655 RVA: 0x0006B4CC File Offset: 0x000696CC
		int IComparer.Compare(object x, object y)
		{
			if (x != null)
			{
				if (y == null)
				{
					return 1;
				}
				if (x == null || y != null)
				{
				}
			}
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
			return 1;
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x0006B4F4 File Offset: 0x000696F4
		protected Comparer()
		{
		}

		// Token: 0x04001AA7 RID: 6823
		private static Comparer<T> defaultComparer;
	}
}
