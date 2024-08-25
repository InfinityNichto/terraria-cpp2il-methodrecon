using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000078 RID: 120
	public sealed class Func<out TResult> : MulticastDelegate
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x0000BA80 File Offset: 0x00009C80
		public Func(object @object, IntPtr method)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000207A File Offset: 0x0000027A
		public TResult Invoke()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
