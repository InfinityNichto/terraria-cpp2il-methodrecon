using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ABE RID: 2750
	public class UIKeybindingSimpleListItem : UIElement
	{
		// Token: 0x060050F8 RID: 20728 RVA: 0x0027EF88 File Offset: 0x0027D188
		public UIKeybindingSimpleListItem(Func<string> getText, Color color)
		{
			int num = 1;
			if (num == 0)
			{
			}
			num.m_value = color;
			if (getText == null)
			{
				if (num == 0)
				{
				}
				if (getText != null || num == 0)
				{
				}
			}
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x0027EFB0 File Offset: 0x0027D1B0
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			base.DrawSelf(spriteBatch);
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float width = this._dimensions.Width;
			bool <IsMouseHovering>k__BackingField = this.<IsMouseHovering>k__BackingField;
		}

		// Token: 0x040089B2 RID: 35250
		private Color _color;

		// Token: 0x040089B3 RID: 35251
		private Func<string> _GetTextFunction;

		// Token: 0x02000ABF RID: 2751
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060050FA RID: 20730 RVA: 0x0027F06C File Offset: 0x0027D26C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060050FB RID: 20731 RVA: 0x0027F07C File Offset: 0x0027D27C
			public <>c()
			{
			}

			// Token: 0x060050FC RID: 20732 RVA: 0x0027F090 File Offset: 0x0027D290
			internal string <.ctor>b__2_0()
			{
				return "???";
			}

			// Token: 0x040089B4 RID: 35252
			public static readonly UIKeybindingSimpleListItem.<>c <>9;

			// Token: 0x040089B5 RID: 35253
			public static Func<string> <>9__2_0;
		}
	}
}
