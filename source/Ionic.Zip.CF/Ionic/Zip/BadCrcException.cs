using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x02000012 RID: 18
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00009")]
	[Serializable]
	public class BadCrcException : ZipException
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002658 File Offset: 0x00000858
		public BadCrcException()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000266C File Offset: 0x0000086C
		public BadCrcException(string message)
			: base(message)
		{
		}
	}
}
