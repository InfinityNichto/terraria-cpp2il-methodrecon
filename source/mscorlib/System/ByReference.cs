using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200013B RID: 315
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct ByReference<T>
	{
		// Token: 0x06000CA8 RID: 3240 RVA: 0x0000207A File Offset: 0x0000027A
		[Intrinsic]
		public ByReference(T value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0000207A File Offset: 0x0000027A
		public T Value
		{
			[Intrinsic]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x040004E0 RID: 1248
		private IntPtr _value;
	}
}
