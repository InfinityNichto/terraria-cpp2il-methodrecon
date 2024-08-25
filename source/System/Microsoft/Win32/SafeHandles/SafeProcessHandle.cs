using System;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000079 RID: 121
	public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060001CB RID: 459 RVA: 0x000060DC File Offset: 0x000042DC
		internal SafeProcessHandle(IntPtr handle)
			: base(true)
		{
			this.handle = handle;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000060F8 File Offset: 0x000042F8
		public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle)
			: base(existingHandle != 0)
		{
			this.handle = existingHandle;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00006114 File Offset: 0x00004314
		protected override bool ReleaseHandle()
		{
			return NativeMethods.CloseProcess(this.handle);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000612C File Offset: 0x0000432C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeProcessHandle()
		{
		}

		// Token: 0x0400015F RID: 351
		internal static SafeProcessHandle InvalidHandle;
	}
}
