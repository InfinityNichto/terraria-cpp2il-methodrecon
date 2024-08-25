using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000848 RID: 2120
	public class SmartInteractSystem
	{
		// Token: 0x0600431A RID: 17178 RVA: 0x000021DB File Offset: 0x000003DB
		public SmartInteractSystem()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x0024D630 File Offset: 0x0024B830
		public void Clear()
		{
			List<ISmartInteractCandidate> candidates = this._candidates;
			int size = candidates._size;
			object syncRoot = candidates._syncRoot;
			candidates._syncRoot = syncRoot;
			List<ISmartInteractCandidateProvider> candidateProvidersByOrderOfPriority = this._candidateProvidersByOrderOfPriority;
			if (syncRoot != null)
			{
			}
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x000021DB File Offset: 0x000003DB
		public void RunQuery(SmartInteractScanSettings settings)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400814B RID: 33099
		private List<ISmartInteractCandidateProvider> _candidateProvidersByOrderOfPriority;

		// Token: 0x0400814C RID: 33100
		private List<ISmartInteractBlockReasonProvider> _blockProviders;

		// Token: 0x0400814D RID: 33101
		private List<ISmartInteractCandidate> _candidates;
	}
}
