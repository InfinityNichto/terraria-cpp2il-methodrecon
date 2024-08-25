using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200066C RID: 1644
	public class RejectionMenuInfo
	{
		// Token: 0x0600370D RID: 14093 RVA: 0x00221038 File Offset: 0x0021F238
		public void DefaultExitAction()
		{
			if (!true)
			{
			}
			Main.menuMode = 0;
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00221050 File Offset: 0x0021F250
		public RejectionMenuInfo()
		{
		}

		// Token: 0x04007812 RID: 30738
		public ReturnFromRejectionMenuAction ExitAction;

		// Token: 0x04007813 RID: 30739
		public string TextToShow;
	}
}
