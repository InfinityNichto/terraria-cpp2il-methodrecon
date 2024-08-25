using System;

namespace System.Net
{
	// Token: 0x020001EB RID: 491
	internal class HeaderInfo
	{
		// Token: 0x06000C0C RID: 3084 RVA: 0x000270FC File Offset: 0x000252FC
		internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
		{
			this.Parser = p;
			this.HeaderName = name;
		}

		// Token: 0x04000A76 RID: 2678
		internal readonly bool IsRequestRestricted;

		// Token: 0x04000A77 RID: 2679
		internal readonly bool IsResponseRestricted;

		// Token: 0x04000A78 RID: 2680
		internal readonly HeaderParser Parser;

		// Token: 0x04000A79 RID: 2681
		internal readonly string HeaderName;

		// Token: 0x04000A7A RID: 2682
		internal readonly bool AllowMultiValues;
	}
}
