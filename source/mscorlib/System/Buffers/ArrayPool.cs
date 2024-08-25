using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Buffers
{
	// Token: 0x02000660 RID: 1632
	public abstract class ArrayPool<T>
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x0000207A File Offset: 0x0000027A
		public static ArrayPool<T> Shared
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060031BD RID: 12733
		public abstract T[] Rent(int minimumLength);

		// Token: 0x060031BE RID: 12734
		public abstract void Return(T[] array, bool clearArray = false);

		// Token: 0x060031BF RID: 12735 RVA: 0x0006BA50 File Offset: 0x00069C50
		protected ArrayPool()
		{
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0006BA64 File Offset: 0x00069C64
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayPool()
		{
		}

		// Token: 0x04001AA9 RID: 6825
		[CompilerGenerated]
		private static readonly ArrayPool<T> <Shared>k__BackingField;
	}
}
