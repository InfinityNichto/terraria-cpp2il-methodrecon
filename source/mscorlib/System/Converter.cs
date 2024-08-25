using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200007F RID: 127
	public sealed class Converter<in TInput, out TOutput> : MulticastDelegate
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public Converter(object @object, IntPtr method)
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000207A File Offset: 0x0000027A
		public TOutput Invoke(TInput input)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
