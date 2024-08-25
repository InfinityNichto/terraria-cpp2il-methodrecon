using System;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	// Token: 0x0200032C RID: 812
	[ComVisible(true)]
	public class WindowsImpersonationContext : IDisposable
	{
		// Token: 0x06001B69 RID: 7017 RVA: 0x0003AD34 File Offset: 0x00038F34
		internal WindowsImpersonationContext(IntPtr token)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0003AD5C File Offset: 0x00038F5C
		[ComVisible(false)]
		public void Dispose()
		{
			if (this.undo)
			{
				return;
			}
			this.Undo();
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0003AD78 File Offset: 0x00038F78
		public void Undo()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0003ADA8 File Offset: 0x00038FA8
		private static bool CloseToken(IntPtr token)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0003ADBC File Offset: 0x00038FBC
		private static IntPtr DuplicateToken(IntPtr token)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0003ADD0 File Offset: 0x00038FD0
		private static bool SetCurrentToken(IntPtr token)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0003ADE4 File Offset: 0x00038FE4
		private static bool RevertToSelf()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000DF5 RID: 3573
		private IntPtr _token;

		// Token: 0x04000DF6 RID: 3574
		private bool undo;
	}
}
