using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x02000014 RID: 20
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00007")]
	[Serializable]
	public class BadStateException : ZipException
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000026A8 File Offset: 0x000008A8
		public BadStateException()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000026BC File Offset: 0x000008BC
		public BadStateException(string message)
			: base(message)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000026D0 File Offset: 0x000008D0
		public BadStateException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
