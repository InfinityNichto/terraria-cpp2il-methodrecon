using System;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Security
{
	// Token: 0x02000317 RID: 791
	internal sealed class SafeCredentialReference : CriticalHandleMinusOneIsInvalid
	{
		// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
		internal static SafeCredentialReference CreateReference(SafeFreeCredentials target)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0003E85C File Offset: 0x0003CA5C
		private SafeCredentialReference(SafeFreeCredentials target)
		{
			long num = 0L;
			base..ctor();
			target.DangerousAddRef(num != 0L);
			this.Target = target;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0003E884 File Offset: 0x0003CA84
		protected override bool ReleaseHandle()
		{
			SafeFreeCredentials target = this.Target;
			if (target != null)
			{
				target.DangerousRelease();
			}
			return true;
		}

		// Token: 0x04001134 RID: 4404
		internal SafeFreeCredentials Target;
	}
}
