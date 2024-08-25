using System;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000844 RID: 2116
	public interface ISmartInteractCandidate
	{
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06004315 RID: 17173
		float DistanceFromCursor { get; }

		// Token: 0x06004316 RID: 17174
		void WinCandidacy();
	}
}
