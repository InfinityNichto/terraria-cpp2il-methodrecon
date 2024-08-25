using System;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000A83 RID: 2691
	public class PlayerResourceSetsManager2 : SelectionHolder<IPlayerResourcesDisplaySet>
	{
		// Token: 0x06004F8F RID: 20367 RVA: 0x0027AD18 File Offset: 0x00278F18
		protected override void Configuration_Save(Preferences obj)
		{
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x0027AD28 File Offset: 0x00278F28
		protected override void Configuration_OnLoad(Preferences obj)
		{
			if (!true)
			{
			}
			Preferences configuration = Main.Configuration;
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x0027AD40 File Offset: 0x00278F40
		protected override void PopulateOptionsAndLoadContent(AssetRequestMode mode)
		{
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x0027AD50 File Offset: 0x00278F50
		public void TryToHoverOverResources()
		{
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x0027AD68 File Offset: 0x00278F68
		public void Draw()
		{
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x0027AD80 File Offset: 0x00278F80
		public PlayerResourceSetsManager2()
		{
		}
	}
}
