using System;

namespace Ionic.Zip
{
	// Token: 0x02000022 RID: 34
	[Flags]
	public enum ZipEntryTimestamp
	{
		// Token: 0x040000A7 RID: 167
		None = 0,
		// Token: 0x040000A8 RID: 168
		DOS = 1,
		// Token: 0x040000A9 RID: 169
		Windows = 2,
		// Token: 0x040000AA RID: 170
		Unix = 4,
		// Token: 0x040000AB RID: 171
		InfoZip1 = 8
	}
}
