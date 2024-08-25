using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200007B RID: 123
	public sealed class Func<in T1, in T2, in T3, out TResult> : MulticastDelegate
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		public Func(object @object, IntPtr method)
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000207A File Offset: 0x0000027A
		public TResult Invoke(T1 arg1, T2 arg2, T3 arg3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
