using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000077 RID: 119
	internal class SafeGssCredHandle : SafeHandle
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00006040 File Offset: 0x00004240
		public static SafeGssCredHandle Create(string username, string password, bool isNtlmOnly)
		{
			bool flag = string.IsNullOrEmpty(username);
			Encoding utf = Encoding.UTF8;
			global::Interop.NetSecurityNative.Status status;
			SafeGssNameHandle safeGssNameHandle;
			if (status == global::Interop.NetSecurityNative.Status.GSS_S_COMPLETE)
			{
				long num = 0L;
				if (safeGssNameHandle != null)
				{
				}
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			long num2 = 0L;
			if (safeGssNameHandle != null)
			{
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000608C File Offset: 0x0000428C
		private SafeGssCredHandle()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000609C File Offset: 0x0000429C
		public override bool IsInvalid
		{
			get
			{
				IntPtr handle = this.handle;
				bool flag;
				return flag;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ReleaseHandle()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
