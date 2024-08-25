using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200016A RID: 362
	[StructLayout(3)]
	public struct ArgIterator
	{
		// Token: 0x06000E92 RID: 3730 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool Equals(object o)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400064A RID: 1610
		private IntPtr sig;

		// Token: 0x0400064B RID: 1611
		private IntPtr args;

		// Token: 0x0400064C RID: 1612
		private int next_arg;

		// Token: 0x0400064D RID: 1613
		private int num_args;
	}
}
