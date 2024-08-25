using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Linq
{
	// Token: 0x0200001B RID: 27
	internal class IdentityFunction<TElement>
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		public static Func<TElement, TElement> Instance
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0200001C RID: 28
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060000E5 RID: 229 RVA: 0x0000380C File Offset: 0x00001A0C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x0000381C File Offset: 0x00001A1C
			public <>c()
			{
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x00003830 File Offset: 0x00001A30
			internal TElement <get_Instance>b__1_0(TElement x)
			{
				return x;
			}

			// Token: 0x04000072 RID: 114
			public static readonly IdentityFunction<TElement>.<>c <>9;

			// Token: 0x04000073 RID: 115
			public static Func<TElement, TElement> <>9__1_0;
		}
	}
}
