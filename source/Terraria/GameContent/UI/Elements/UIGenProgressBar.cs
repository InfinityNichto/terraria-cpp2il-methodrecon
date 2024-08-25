using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB4 RID: 2740
	public class UIGenProgressBar : UIElement
	{
		// Token: 0x060050C7 RID: 20679 RVA: 0x0027E49C File Offset: 0x0027C69C
		public UIGenProgressBar()
		{
			bool logicClient = Main.LogicClient;
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x0027E4BC File Offset: 0x0027C6BC
		public override void Recalculate()
		{
			base.Recalculate();
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x0027E4D0 File Offset: 0x0027C6D0
		public void SetProgress(float overallProgress, float currentProgress)
		{
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x0027E4E0 File Offset: 0x0027C6E0
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			int num = 1;
			bool isLoaded = this._texOuterCorrupt.IsLoaded;
			bool isLoaded2 = this._texOuterCrimson.IsLoaded;
			bool isLoaded3 = this._texOuterLower.IsLoaded;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
			}
			float targetOverallProgress = this._targetOverallProgress;
			int longBarWidth = this._longBarWidth;
			float targetCurrentProgress = this._targetCurrentProgress;
			int smallBarWidth = this._smallBarWidth;
			float y = this._dimensions.Y;
			this._visualOverallProgress = targetOverallProgress;
			this._visualCurrentProgress = targetCurrentProgress;
			int num2 = 16928;
			if (num2 == 0)
			{
			}
			int longBarWidth2 = this._longBarWidth;
			if (num2 == 0)
			{
			}
			int num3 = 43095;
			Color color;
			color.PackedValue = (uint)num3;
			int smallBarWidth2 = this._smallBarWidth;
			float x = this._dimensions.X;
			if (328 == 0)
			{
			}
			Rectangle rectangle;
			if (rectangle == null)
			{
			}
			Asset<Texture2D> texOuterLower = this._texOuterLower;
			if (16944 == 0)
			{
			}
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x0027E5D8 File Offset: 0x0027C7D8
		private void DrawFilling(SpriteBatch spritebatch, Texture2D tex, Texture2D texShadow, Vector2 topLeft, int completedWidth, int totalWidth, Color separator, Color empty)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rectangle rectangle;
			if (rectangle == null)
			{
			}
			if (texShadow != null)
			{
				int height = texShadow.Height;
				if (rectangle == null)
				{
				}
			}
			if (rectangle == null)
			{
			}
			int height2 = tex.Height;
			int height3 = tex.Height;
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x0027E63C File Offset: 0x0027C83C
		private void DrawFilling2(SpriteBatch spritebatch, Vector2 topLeft, int height, int completedWidth, int totalWidth, Color filled, Color separator, Color empty)
		{
			if (!true)
			{
			}
		}

		// Token: 0x04008983 RID: 35203
		private Asset<Texture2D> _texOuterCrimson;

		// Token: 0x04008984 RID: 35204
		private Asset<Texture2D> _texOuterCorrupt;

		// Token: 0x04008985 RID: 35205
		private Asset<Texture2D> _texOuterLower;

		// Token: 0x04008986 RID: 35206
		private float _visualOverallProgress;

		// Token: 0x04008987 RID: 35207
		private float _targetOverallProgress;

		// Token: 0x04008988 RID: 35208
		private float _visualCurrentProgress;

		// Token: 0x04008989 RID: 35209
		private float _targetCurrentProgress;

		// Token: 0x0400898A RID: 35210
		private int _smallBarWidth;

		// Token: 0x0400898B RID: 35211
		private int _longBarWidth;
	}
}
