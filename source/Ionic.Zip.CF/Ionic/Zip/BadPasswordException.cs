using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x02000010 RID: 16
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
	[Serializable]
	public class BadPasswordException : ZipException
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000025D8 File Offset: 0x000007D8
		public BadPasswordException()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000025EC File Offset: 0x000007EC
		public BadPasswordException(string message)
			: base(message)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002600 File Offset: 0x00000800
		public BadPasswordException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
