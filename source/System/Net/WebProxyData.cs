using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x0200021F RID: 543
	internal class WebProxyData
	{
		// Token: 0x06000D9C RID: 3484 RVA: 0x0002BBEC File Offset: 0x00029DEC
		public WebProxyData()
		{
		}

		// Token: 0x04000B6F RID: 2927
		internal bool bypassOnLocal;

		// Token: 0x04000B70 RID: 2928
		internal bool automaticallyDetectSettings;

		// Token: 0x04000B71 RID: 2929
		internal global::System.Uri proxyAddress;

		// Token: 0x04000B72 RID: 2930
		internal Hashtable proxyHostAddresses;

		// Token: 0x04000B73 RID: 2931
		internal global::System.Uri scriptLocation;

		// Token: 0x04000B74 RID: 2932
		internal ArrayList bypassList;
	}
}
