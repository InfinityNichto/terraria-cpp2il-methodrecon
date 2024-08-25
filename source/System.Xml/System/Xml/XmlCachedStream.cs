using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x0200009B RID: 155
	internal class XmlCachedStream : MemoryStream
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x000187E0 File Offset: 0x000169E0
		internal XmlCachedStream(Uri uri, Stream stream)
		{
			this.uri = uri;
		}

		// Token: 0x040003B6 RID: 950
		private Uri uri;
	}
}
