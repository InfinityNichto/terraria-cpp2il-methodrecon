using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000080 RID: 128
	public sealed class Predicate<in T> : MulticastDelegate
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x0000BB68 File Offset: 0x00009D68
		public Predicate(object @object, IntPtr method)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000207A File Offset: 0x0000027A
		public bool Invoke(T obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
