using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AC7 RID: 2759
	public class UIProgressBar : UIElement
	{
		// Token: 0x06005127 RID: 20775 RVA: 0x0027F968 File Offset: 0x0027DB68
		public UIProgressBar()
		{
			if (!true)
			{
			}
			base..ctor();
			this._progressBar.Height.Precent = (float)16256;
			UIProgressBar.UIInnerProgressBar progressBar = this._progressBar;
			base.Append(progressBar);
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x0027F9A4 File Offset: 0x0027DBA4
		public void SetProgress(float value)
		{
			float visualProgress = this._visualProgress;
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x0027F9B8 File Offset: 0x0027DBB8
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float visualProgress = this._visualProgress;
			float targetProgress = this._targetProgress;
			UIProgressBar.UIInnerProgressBar progressBar = this._progressBar;
			this._visualProgress = visualProgress;
			progressBar.Width.Precent = visualProgress;
		}

		// Token: 0x040089CC RID: 35276
		private UIProgressBar.UIInnerProgressBar _progressBar;

		// Token: 0x040089CD RID: 35277
		private float _visualProgress;

		// Token: 0x040089CE RID: 35278
		private float _targetProgress;

		// Token: 0x02000AC8 RID: 2760
		private class UIInnerProgressBar : UIElement
		{
			// Token: 0x0600512A RID: 20778 RVA: 0x0027F9F0 File Offset: 0x0027DBF0
			protected override void DrawSelf(SpriteBatch spriteBatch)
			{
				float x = this._dimensions.X;
				float y = this._dimensions.Y;
				float width = this._dimensions.Width;
				float height = this._dimensions.Height;
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
			}

			// Token: 0x0600512B RID: 20779 RVA: 0x0027FA38 File Offset: 0x0027DC38
			public UIInnerProgressBar()
			{
				if (!true)
				{
				}
				base..ctor();
			}
		}
	}
}
