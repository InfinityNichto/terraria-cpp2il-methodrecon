using System;

namespace Mono.Security.Interface
{
	// Token: 0x0200004F RID: 79
	public sealed class TlsException : Exception
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00008FDC File Offset: 0x000071DC
		public TlsException(Alert alert, string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
			this.alert = alert;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00008FFC File Offset: 0x000071FC
		public TlsException(AlertDescription description, string message)
		{
		}

		// Token: 0x04000240 RID: 576
		private Alert alert;
	}
}
