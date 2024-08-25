using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000079 RID: 121
	public sealed class Func<in T, out TResult> : MulticastDelegate
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x0000BA9C File Offset: 0x00009C9C
		public Func(object @object, IntPtr method)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000207A File Offset: 0x0000027A
		public TResult Invoke(T arg)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
