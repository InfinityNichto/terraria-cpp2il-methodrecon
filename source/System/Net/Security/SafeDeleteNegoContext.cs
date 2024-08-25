using System;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Security
{
	// Token: 0x02000315 RID: 789
	internal sealed class SafeDeleteNegoContext : SafeDeleteContext
	{
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0003E778 File Offset: 0x0003C978
		public Microsoft.Win32.SafeHandles.SafeGssNameHandle TargetName
		{
			get
			{
				return this._targetName;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0003E78C File Offset: 0x0003C98C
		public bool IsNtlmUsed
		{
			get
			{
				return this._isNtlmUsed;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0003E7A0 File Offset: 0x0003C9A0
		public Microsoft.Win32.SafeHandles.SafeGssContextHandle GssContext
		{
			get
			{
				return this._context;
			}
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0003E7B4 File Offset: 0x0003C9B4
		public SafeDeleteNegoContext(SafeFreeNegoCredentials credential, string targetName)
			: base(credential)
		{
			Microsoft.Win32.SafeHandles.SafeGssNameHandle safeGssNameHandle = Microsoft.Win32.SafeHandles.SafeGssNameHandle.CreatePrincipal(targetName);
			this._targetName = safeGssNameHandle;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0003E7E8 File Offset: 0x0003C9E8
		public void SetGssContext(Microsoft.Win32.SafeHandles.SafeGssContextHandle context)
		{
			this._context = context;
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0003E7FC File Offset: 0x0003C9FC
		public void SetAuthenticationPackage(bool isNtlmUsed)
		{
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0003E80C File Offset: 0x0003CA0C
		protected override void Dispose(bool disposing)
		{
			Microsoft.Win32.SafeHandles.SafeGssContextHandle context = this._context;
			if (context != null)
			{
				context.Dispose();
			}
			Microsoft.Win32.SafeHandles.SafeGssNameHandle targetName = this._targetName;
			long num;
			if (targetName != null)
			{
				num = 0L;
				targetName.Dispose();
			}
			base.Dispose(num != 0L);
		}

		// Token: 0x04001131 RID: 4401
		private Microsoft.Win32.SafeHandles.SafeGssNameHandle _targetName;

		// Token: 0x04001132 RID: 4402
		private Microsoft.Win32.SafeHandles.SafeGssContextHandle _context;

		// Token: 0x04001133 RID: 4403
		private bool _isNtlmUsed;
	}
}
