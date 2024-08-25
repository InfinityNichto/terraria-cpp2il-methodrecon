using System;
using Cpp2IlInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000115 RID: 277
	public struct X509ChainStatus
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x00018378 File Offset: 0x00016578
		internal X509ChainStatus(X509ChainStatusFlags flag)
		{
			this.status = flag;
			string information = X509ChainStatus.GetInformation(flag);
			this.info = information;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0001839C File Offset: 0x0001659C
		public X509ChainStatusFlags Status
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.status = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x000183B0 File Offset: 0x000165B0
		public string StatusInformation
		{
			set
			{
				this.info = value;
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000183C4 File Offset: 0x000165C4
		internal static string GetInformation(X509ChainStatusFlags flags)
		{
			string text;
			return Locale.GetText(text);
		}

		// Token: 0x04000527 RID: 1319
		private X509ChainStatusFlags status;

		// Token: 0x04000528 RID: 1320
		private string info;
	}
}
