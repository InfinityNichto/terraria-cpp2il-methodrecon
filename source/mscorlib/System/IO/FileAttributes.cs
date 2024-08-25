using System;

namespace System.IO
{
	// Token: 0x02000556 RID: 1366
	[Flags]
	public enum FileAttributes
	{
		// Token: 0x040015E2 RID: 5602
		ReadOnly = 1,
		// Token: 0x040015E3 RID: 5603
		Hidden = 2,
		// Token: 0x040015E4 RID: 5604
		System = 4,
		// Token: 0x040015E5 RID: 5605
		Directory = 16,
		// Token: 0x040015E6 RID: 5606
		Archive = 32,
		// Token: 0x040015E7 RID: 5607
		Device = 64,
		// Token: 0x040015E8 RID: 5608
		Normal = 128,
		// Token: 0x040015E9 RID: 5609
		Temporary = 256,
		// Token: 0x040015EA RID: 5610
		SparseFile = 512,
		// Token: 0x040015EB RID: 5611
		ReparsePoint = 1024,
		// Token: 0x040015EC RID: 5612
		Compressed = 2048,
		// Token: 0x040015ED RID: 5613
		Offline = 4096,
		// Token: 0x040015EE RID: 5614
		NotContentIndexed = 8192,
		// Token: 0x040015EF RID: 5615
		Encrypted = 16384,
		// Token: 0x040015F0 RID: 5616
		IntegrityStream = 32768,
		// Token: 0x040015F1 RID: 5617
		NoScrubData = 131072
	}
}
