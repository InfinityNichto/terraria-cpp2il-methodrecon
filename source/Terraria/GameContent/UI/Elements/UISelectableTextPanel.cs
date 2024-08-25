using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ACC RID: 2764
	public class UISelectableTextPanel<T> : UITextPanel<T>
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06005151 RID: 20817 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06005152 RID: 20818 RVA: 0x00280274 File Offset: 0x0027E474
		public Func<UISelectableTextPanel<T>, bool> IsSelected
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00280284 File Offset: 0x0027E484
		public UISelectableTextPanel(T text, float textScale = 1f, bool large = false)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x00280298 File Offset: 0x0027E498
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			for (;;)
			{
				int num = 32640;
				int num2 = 32768;
				int num3 = 10;
				if (this != null)
				{
					if (num3 == 0)
					{
					}
					if (num == 0)
					{
					}
					if (10 == 0)
					{
						break;
					}
					if (num == 0)
					{
					}
					if (num2 == 0)
					{
						break;
					}
					break;
				}
			}
		}

		// Token: 0x040089E4 RID: 35300
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x040089E5 RID: 35301
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x040089E6 RID: 35302
		private Func<UISelectableTextPanel<T>, bool> _isSelected;
	}
}
