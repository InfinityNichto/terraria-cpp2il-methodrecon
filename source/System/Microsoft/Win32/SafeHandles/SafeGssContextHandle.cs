using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000078 RID: 120
	internal sealed class SafeGssContextHandle : SafeHandle
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x000060B4 File Offset: 0x000042B4
		public SafeGssContextHandle()
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000060C4 File Offset: 0x000042C4
		public override bool IsInvalid
		{
			get
			{
				IntPtr handle = this.handle;
				bool flag;
				return flag;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ReleaseHandle()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
