using System;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x02000637 RID: 1591
	[Serializable]
	public class KeyNotFoundException : SystemException
	{
		// Token: 0x0600309B RID: 12443 RVA: 0x0006A6FC File Offset: 0x000688FC
		public KeyNotFoundException()
			: base("The given key was not present in the dictionary.")
		{
			this._HResult = 5495;
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x0006A720 File Offset: 0x00068920
		public KeyNotFoundException(string message)
			: base(message)
		{
			this._HResult = 5495;
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x0006A740 File Offset: 0x00068940
		protected KeyNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
