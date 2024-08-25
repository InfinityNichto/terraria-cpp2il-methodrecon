using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x02000011 RID: 17
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000A")]
	[Serializable]
	public class BadReadException : ZipException
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002618 File Offset: 0x00000818
		public BadReadException()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000262C File Offset: 0x0000082C
		public BadReadException(string message)
			: base(message)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002640 File Offset: 0x00000840
		public BadReadException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
