using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200062E RID: 1582
	public class IssueReport
	{
		// Token: 0x06003622 RID: 13858 RVA: 0x00212374 File Offset: 0x00210574
		public IssueReport(string reportText)
		{
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
			this.timeReported = now;
			this.reportText = reportText;
		}

		// Token: 0x040076E6 RID: 30438
		public DateTime timeReported;

		// Token: 0x040076E7 RID: 30439
		public string reportText;
	}
}
