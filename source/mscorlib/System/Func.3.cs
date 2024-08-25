using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200007A RID: 122
	public sealed class Func<in T1, in T2, out TResult> : MulticastDelegate
	{
		// Token: 0x060003A5 RID: 933 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		public Func(object @object, IntPtr method)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000207A File Offset: 0x0000027A
		public TResult Invoke(T1 arg1, T2 arg2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
