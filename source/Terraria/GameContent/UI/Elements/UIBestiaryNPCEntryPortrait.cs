using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AA7 RID: 2727
	public class UIBestiaryNPCEntryPortrait : UIElement
	{
		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06005061 RID: 20577 RVA: 0x0027CFB0 File Offset: 0x0027B1B0
		// (set) Token: 0x06005062 RID: 20578 RVA: 0x0027CFC4 File Offset: 0x0027B1C4
		public BestiaryEntry Entry
		{
			[CompilerGenerated]
			get
			{
				return this.<Entry>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Entry>k__BackingField = value;
			}
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x0027CFD8 File Offset: 0x0027B1D8
		public UIBestiaryNPCEntryPortrait(BestiaryEntry entry, Asset<Texture2D> portraitBackgroundAsset, Color portraitColor, List<IBestiaryBackgroundOverlayAndColorProvider> overlays)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Entry = entry;
			int num = 257;
			if (portraitBackgroundAsset != null)
			{
				int num2 = 1;
				num.m_value = portraitColor;
				if (num2 == 0)
				{
				}
			}
			int size = overlays._size;
			if (num != 0)
			{
			}
		}

		// Token: 0x04008921 RID: 35105
		[CompilerGenerated]
		private BestiaryEntry <Entry>k__BackingField;
	}
}
