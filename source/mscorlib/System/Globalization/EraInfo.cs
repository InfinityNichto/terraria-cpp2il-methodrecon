using System;
using System.Runtime.Serialization;

namespace System.Globalization
{
	// Token: 0x020005AB RID: 1451
	[Serializable]
	internal class EraInfo
	{
		// Token: 0x06002BB2 RID: 11186 RVA: 0x000607C0 File Offset: 0x0005E9C0
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear)
		{
			this.era = era;
			this.yearOffset = yearOffset;
			this.maxEraYear = minEraYear;
			this.maxEraYear = maxEraYear;
			long num;
			this.ticks = num;
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000607FC File Offset: 0x0005E9FC
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName)
		{
			this.era = era;
			this.yearOffset = yearOffset;
			this.maxEraYear = minEraYear;
			this.maxEraYear = maxEraYear;
			long num;
			this.ticks = num;
		}

		// Token: 0x0400185E RID: 6238
		internal int era;

		// Token: 0x0400185F RID: 6239
		internal long ticks;

		// Token: 0x04001860 RID: 6240
		internal int yearOffset;

		// Token: 0x04001861 RID: 6241
		internal int minEraYear;

		// Token: 0x04001862 RID: 6242
		internal int maxEraYear;

		// Token: 0x04001863 RID: 6243
		[OptionalField(VersionAdded = 4)]
		internal string eraName;

		// Token: 0x04001864 RID: 6244
		[OptionalField(VersionAdded = 4)]
		internal string abbrevEraName;

		// Token: 0x04001865 RID: 6245
		[OptionalField(VersionAdded = 4)]
		internal string englishEraName;
	}
}
