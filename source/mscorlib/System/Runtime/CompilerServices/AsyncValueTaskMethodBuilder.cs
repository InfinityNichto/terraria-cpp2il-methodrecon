using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000464 RID: 1124
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder
	{
		// Token: 0x040012A3 RID: 4771
		private AsyncTaskMethodBuilder _methodBuilder;

		// Token: 0x040012A4 RID: 4772
		private bool _haveResult;

		// Token: 0x040012A5 RID: 4773
		private bool _useBuilder;
	}
}
