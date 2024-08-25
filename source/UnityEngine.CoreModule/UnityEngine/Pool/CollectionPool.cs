using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityEngine.Pool
{
	// Token: 0x02000156 RID: 342
	public class CollectionPool<TCollection, TItem> where TCollection : class, ICollection<TItem>, new()
	{
		// Token: 0x06000668 RID: 1640 RVA: 0x000021B3 File Offset: 0x000003B3
		public static TCollection Get()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0000B64C File Offset: 0x0000984C
		public static void Release(TCollection toRelease)
		{
			if (toRelease == null)
			{
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0000B660 File Offset: 0x00009860
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionPool()
		{
		}

		// Token: 0x04000636 RID: 1590
		internal static readonly ObjectPool<TCollection> s_Pool;

		// Token: 0x02000157 RID: 343
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600066B RID: 1643 RVA: 0x0000B674 File Offset: 0x00009874
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x0000B684 File Offset: 0x00009884
			public <>c()
			{
			}

			// Token: 0x0600066D RID: 1645 RVA: 0x000021B3 File Offset: 0x000003B3
			internal TCollection <.cctor>b__5_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600066E RID: 1646 RVA: 0x0000B698 File Offset: 0x00009898
			internal void <.cctor>b__5_1(TCollection l)
			{
			}

			// Token: 0x04000637 RID: 1591
			public static readonly CollectionPool<TCollection, TItem>.<>c <>9;
		}
	}
}
