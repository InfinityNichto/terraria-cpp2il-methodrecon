using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB6 RID: 2742
	public class UIHeader : UIElement
	{
		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060050D3 RID: 20691 RVA: 0x0027E854 File Offset: 0x0027CA54
		// (set) Token: 0x060050D4 RID: 20692 RVA: 0x0027E868 File Offset: 0x0027CA68
		public string Text
		{
			get
			{
				return this._text;
			}
			set
			{
				bool flag = this._text != value;
				this._text = value;
				if (!true)
				{
				}
				if (!true)
				{
					if (!true)
					{
					}
					string text = this._text;
				}
			}
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x0027E89C File Offset: 0x0027CA9C
		public UIHeader()
		{
			if (!true)
			{
			}
			base..ctor();
			this.Text = "";
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x0027E8C0 File Offset: 0x0027CAC0
		public UIHeader(string text)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Text = text;
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x0027E8E0 File Offset: 0x0027CAE0
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			if (!true)
			{
			}
			string text = this._text;
			if (!true)
			{
			}
			string text2 = this._text;
			string text3 = this._text;
			string text4 = this._text;
			string text5 = this._text;
		}

		// Token: 0x04008993 RID: 35219
		private string _text;
	}
}
