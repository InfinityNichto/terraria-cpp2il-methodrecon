using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures
{
	// Token: 0x0200062F RID: 1583
	public class GeneralIssueReporter : IProvideReports
	{
		// Token: 0x06003623 RID: 13859 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddReport(string textToShow)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x002123A0 File Offset: 0x002105A0
		public List<IssueReport> GetReports()
		{
			return this._reports;
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x002123B4 File Offset: 0x002105B4
		public GeneralIssueReporter()
		{
		}

		// Token: 0x040076E8 RID: 30440
		private List<IssueReport> _reports;
	}
}
