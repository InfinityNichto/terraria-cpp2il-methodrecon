using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AC9 RID: 2761
	public class UIResourcePackInfoButton<T> : UITextPanel<T>
	{
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x0027FA50 File Offset: 0x0027DC50
		public ResourcePack ResourcePack
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x0027FA60 File Offset: 0x0027DC60
		public UIResourcePackInfoButton(T text, float textScale = 1f, bool large = false)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x0027FA74 File Offset: 0x0027DC74
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			if (true)
			{
				int num = 32640;
				int num2 = 32768;
				if (10 != 0)
				{
					if (num == 0)
					{
					}
					if (num2 == 0)
					{
					}
				}
			}
		}

		// Token: 0x040089CF RID: 35279
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x040089D0 RID: 35280
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x040089D1 RID: 35281
		private ResourcePack _resourcePack;
	}
}
