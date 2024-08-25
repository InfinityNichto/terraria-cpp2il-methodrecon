using System;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x02000538 RID: 1336
	[Serializable]
	public class IOException : SystemException
	{
		// Token: 0x06002749 RID: 10057 RVA: 0x000550E0 File Offset: 0x000532E0
		public IOException()
			: base("I/O error occurred.")
		{
			this._HResult = 5664;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00055104 File Offset: 0x00053304
		public IOException(string message)
			: base(message)
		{
			this._HResult = 5664;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00055124 File Offset: 0x00053324
		public IOException(string message, int hresult)
			: base(message)
		{
			this._HResult = hresult;
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x00055140 File Offset: 0x00053340
		public IOException(string message, Exception innerException)
			: base(message, innerException)
		{
			this._HResult = 5664;
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00055160 File Offset: 0x00053360
		protected IOException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
