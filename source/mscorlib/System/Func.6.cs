using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200007D RID: 125
	public sealed class Func<in T1, in T2, in T3, in T4, in T5, in T6, out TResult> : MulticastDelegate
	{
		// Token: 0x060003AB RID: 939 RVA: 0x0000BB14 File Offset: 0x00009D14
		public Func(object @object, IntPtr method)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000207A File Offset: 0x0000027A
		public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
