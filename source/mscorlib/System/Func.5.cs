using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200007C RID: 124
	public sealed class Func<in T1, in T2, in T3, in T4, out TResult> : MulticastDelegate
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		public Func(object @object, IntPtr method)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000207A File Offset: 0x0000027A
		public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
