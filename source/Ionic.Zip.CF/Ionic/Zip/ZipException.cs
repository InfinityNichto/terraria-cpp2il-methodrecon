using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x0200000F RID: 15
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00006")]
	[Serializable]
	public class ZipException : Exception
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002590 File Offset: 0x00000790
		public ZipException()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000025A8 File Offset: 0x000007A8
		public ZipException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000025C0 File Offset: 0x000007C0
		public ZipException(string message, Exception innerException)
		{
			if (!true)
			{
			}
			base..ctor(message, innerException);
		}
	}
}
