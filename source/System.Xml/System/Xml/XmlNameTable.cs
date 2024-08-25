using System;

namespace System.Xml
{
	// Token: 0x020000A9 RID: 169
	public abstract class XmlNameTable
	{
		// Token: 0x06000791 RID: 1937
		public abstract string Get(string array);

		// Token: 0x06000792 RID: 1938
		public abstract string Add(char[] array, int offset, int length);

		// Token: 0x06000793 RID: 1939
		public abstract string Add(string array);

		// Token: 0x06000794 RID: 1940 RVA: 0x00019184 File Offset: 0x00017384
		protected XmlNameTable()
		{
		}
	}
}
