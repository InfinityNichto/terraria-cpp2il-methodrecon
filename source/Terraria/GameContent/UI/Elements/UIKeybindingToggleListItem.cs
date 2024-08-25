using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AC0 RID: 2752
	public class UIKeybindingToggleListItem : UIElement
	{
		// Token: 0x060050FD RID: 20733 RVA: 0x0027F0A4 File Offset: 0x0027D2A4
		public UIKeybindingToggleListItem(Func<string> getText, Func<bool> getStatus, Color color)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			num.m_value = color;
			if (num == 0)
			{
			}
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x0027F0DC File Offset: 0x0027D2DC
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			base.DrawSelf(spriteBatch);
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float width = this._dimensions.Width;
			bool <IsMouseHovering>k__BackingField = this.<IsMouseHovering>k__BackingField;
		}

		// Token: 0x040089B6 RID: 35254
		private Color _color;

		// Token: 0x040089B7 RID: 35255
		private Func<string> _TextDisplayFunction;

		// Token: 0x040089B8 RID: 35256
		private Func<bool> _IsOnFunction;

		// Token: 0x040089B9 RID: 35257
		private Asset<Texture2D> _toggleTexture;

		// Token: 0x02000AC1 RID: 2753
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060050FF RID: 20735 RVA: 0x0027F1F4 File Offset: 0x0027D3F4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005100 RID: 20736 RVA: 0x0027F204 File Offset: 0x0027D404
			public <>c()
			{
			}

			// Token: 0x06005101 RID: 20737 RVA: 0x0027F218 File Offset: 0x0027D418
			internal string <.ctor>b__4_0()
			{
				return "???";
			}

			// Token: 0x06005102 RID: 20738 RVA: 0x0027F22C File Offset: 0x0027D42C
			internal bool <.ctor>b__4_1()
			{
			}

			// Token: 0x040089BA RID: 35258
			public static readonly UIKeybindingToggleListItem.<>c <>9;

			// Token: 0x040089BB RID: 35259
			public static Func<string> <>9__4_0;

			// Token: 0x040089BC RID: 35260
			public static Func<bool> <>9__4_1;
		}
	}
}
