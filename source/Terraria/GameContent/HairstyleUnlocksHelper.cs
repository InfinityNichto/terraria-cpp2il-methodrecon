using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent
{
	// Token: 0x020007C7 RID: 1991
	public class HairstyleUnlocksHelper
	{
		// Token: 0x06004091 RID: 16529 RVA: 0x0024371C File Offset: 0x0024191C
		public void UpdateUnlocks()
		{
			bool flag = this.ListWarrantsRemake();
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00243734 File Offset: 0x00241934
		private bool ListWarrantsRemake()
		{
			return Main.gameMenu;
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x000021DB File Offset: 0x000003DB
		private void RebuildList()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x002437C8 File Offset: 0x002419C8
		public HairstyleUnlocksHelper()
		{
		}

		// Token: 0x04007E4B RID: 32331
		public List<int> AvailableHairstyles;

		// Token: 0x04007E4C RID: 32332
		private bool _defeatedMartians;

		// Token: 0x04007E4D RID: 32333
		private bool _defeatedMoonlord;

		// Token: 0x04007E4E RID: 32334
		private bool _defeatedPlantera;

		// Token: 0x04007E4F RID: 32335
		private bool _isAtStylist;

		// Token: 0x04007E50 RID: 32336
		private bool _isAtCharacterCreation;
	}
}
