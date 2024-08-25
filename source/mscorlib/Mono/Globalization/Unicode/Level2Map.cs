using System;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000035 RID: 53
	internal class Level2Map
	{
		// Token: 0x060000AD RID: 173 RVA: 0x000030E4 File Offset: 0x000012E4
		public Level2Map(byte source, byte replace)
		{
			this.Source = source;
			this.Replace = replace;
		}

		// Token: 0x040000E2 RID: 226
		public byte Source;

		// Token: 0x040000E3 RID: 227
		public byte Replace;
	}
}
