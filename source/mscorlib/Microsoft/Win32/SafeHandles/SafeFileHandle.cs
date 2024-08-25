using System;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005B RID: 91
	public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600021B RID: 539 RVA: 0x00008184 File Offset: 0x00006384
		public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle)
			: base(preexistingHandle != null)
		{
			this.handle = preexistingHandle;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000081A0 File Offset: 0x000063A0
		protected override bool ReleaseHandle()
		{
			IntPtr handle = this.handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}
	}
}
