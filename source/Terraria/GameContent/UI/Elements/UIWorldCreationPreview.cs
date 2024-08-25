using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AD5 RID: 2773
	public class UIWorldCreationPreview : UIElement
	{
		// Token: 0x0600519C RID: 20892 RVA: 0x00280DBC File Offset: 0x0027EFBC
		public UIWorldCreationPreview()
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			if (num == 0)
			{
			}
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00280E00 File Offset: 0x0027F000
		public void UpdateOption(byte difficulty, byte evil, byte size)
		{
			this._difficulty = difficulty;
			this._evil = evil;
			this._size = size;
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x00280E24 File Offset: 0x0027F024
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			int num = 1;
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			if (num == 0)
			{
			}
			byte difficulty = this._difficulty;
		}

		// Token: 0x04008A20 RID: 35360
		private readonly Asset<Texture2D> _BorderTexture;

		// Token: 0x04008A21 RID: 35361
		private readonly Asset<Texture2D> _BackgroundExpertTexture;

		// Token: 0x04008A22 RID: 35362
		private readonly Asset<Texture2D> _BackgroundNormalTexture;

		// Token: 0x04008A23 RID: 35363
		private readonly Asset<Texture2D> _BackgroundMasterTexture;

		// Token: 0x04008A24 RID: 35364
		private readonly Asset<Texture2D> _BunnyExpertTexture;

		// Token: 0x04008A25 RID: 35365
		private readonly Asset<Texture2D> _BunnyNormalTexture;

		// Token: 0x04008A26 RID: 35366
		private readonly Asset<Texture2D> _BunnyCreativeTexture;

		// Token: 0x04008A27 RID: 35367
		private readonly Asset<Texture2D> _BunnyMasterTexture;

		// Token: 0x04008A28 RID: 35368
		private readonly Asset<Texture2D> _EvilRandomTexture;

		// Token: 0x04008A29 RID: 35369
		private readonly Asset<Texture2D> _EvilCorruptionTexture;

		// Token: 0x04008A2A RID: 35370
		private readonly Asset<Texture2D> _EvilCrimsonTexture;

		// Token: 0x04008A2B RID: 35371
		private readonly Asset<Texture2D> _SizeSmallTexture;

		// Token: 0x04008A2C RID: 35372
		private readonly Asset<Texture2D> _SizeMediumTexture;

		// Token: 0x04008A2D RID: 35373
		private readonly Asset<Texture2D> _SizeLargeTexture;

		// Token: 0x04008A2E RID: 35374
		private byte _difficulty;

		// Token: 0x04008A2F RID: 35375
		private byte _evil;

		// Token: 0x04008A30 RID: 35376
		private byte _size;
	}
}
