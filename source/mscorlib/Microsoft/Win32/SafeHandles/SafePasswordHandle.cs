using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005A RID: 90
	internal sealed class SafePasswordHandle : SafeHandle
	{
		// Token: 0x06000214 RID: 532 RVA: 0x000080B0 File Offset: 0x000062B0
		private IntPtr CreateHandle(string password)
		{
			if (!true)
			{
			}
			return Marshal.StringToHGlobalAnsi(password);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000080C8 File Offset: 0x000062C8
		private void FreeHandle()
		{
			IntPtr handle = this.handle;
			if (!true)
			{
			}
			Marshal.ZeroFreeGlobalAllocAnsi(handle);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000080E8 File Offset: 0x000062E8
		public SafePasswordHandle(string password)
		{
			if (password != null)
			{
				IntPtr intPtr = this.CreateHandle(password);
				this.handle = intPtr;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00008108 File Offset: 0x00006308
		protected override bool ReleaseHandle()
		{
			IntPtr handle = this.handle;
			this.FreeHandle();
			IntPtr intPtr;
			this.handle = intPtr;
			return true;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000812C File Offset: 0x0000632C
		protected override void Dispose(bool disposing)
		{
			bool flag = SafeHandleCache.IsCachedInvalidHandle(this);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00008148 File Offset: 0x00006348
		public override bool IsInvalid
		{
			get
			{
				IntPtr intPtr;
				return this.handle == intPtr;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00008164 File Offset: 0x00006364
		internal string Mono_DangerousGetString()
		{
			IntPtr handle = this.handle;
			if (!true)
			{
			}
			return Marshal.PtrToStringAnsi(handle);
		}
	}
}
