using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200007E RID: 126
	public sealed class Comparison<in T> : MulticastDelegate
	{
		// Token: 0x060003AD RID: 941 RVA: 0x0000BB30 File Offset: 0x00009D30
		public Comparison(object @object, IntPtr method)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000207A File Offset: 0x0000027A
		public int Invoke(T x, T y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
