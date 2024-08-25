using System;
using System.Runtime.InteropServices;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000846 RID: 2118
	public interface ISmartInteractCandidateProvider
	{
		// Token: 0x06004318 RID: 17176
		void ClearSelfAndPrepareForCheck();

		// Token: 0x06004319 RID: 17177
		bool ProvideCandidate(SmartInteractScanSettings settings, [Out] ISmartInteractCandidate candidate);
	}
}
