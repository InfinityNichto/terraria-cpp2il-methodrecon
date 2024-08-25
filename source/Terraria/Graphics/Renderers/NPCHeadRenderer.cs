using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x0200075F RID: 1887
	public class NPCHeadRenderer : INeedRenderTargetContent
	{
		// Token: 0x06003E0D RID: 15885 RVA: 0x0023BAF0 File Offset: 0x00239CF0
		public NPCHeadRenderer(Asset<Texture2D>[] matchingArray)
		{
			this._matchingArray = matchingArray;
			this.Reset();
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x0023BB10 File Offset: 0x00239D10
		public void Reset()
		{
			Asset<Texture2D>[] matchingArray = this._matchingArray;
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x0023BB24 File Offset: 0x00239D24
		public void DrawWithOutlines(Entity entity, int headId, Vector2 position, Color color, float rotation, float scale, SpriteEffects effects)
		{
			int num = 1;
			NPCHeadDrawRenderTargetContent[] contents = this._contents;
			NPCHeadDrawRenderTargetContent[] contents2;
			Asset<Texture2D>[] matchingArray;
			if (num == 0)
			{
				contents2 = this._contents;
				matchingArray = this._matchingArray;
				int height = contents2.height;
				NPCHeadDrawRenderTargetContent[] contents3 = this._contents;
			}
			if (contents2 != null)
			{
				if (contents2 == null)
				{
				}
				if (matchingArray == null)
				{
				}
				if (matchingArray == null)
				{
				}
				return;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x0023BB74 File Offset: 0x00239D74
		public bool IsReady
		{
			get
			{
			}
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x0023BB84 File Offset: 0x00239D84
		public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			bool wasPrepared = this._contents._wasPrepared;
			if (this != null && this._matchingArray == null)
			{
				NPCHeadDrawRenderTargetContent[] contents = this._contents;
			}
		}

		// Token: 0x04007CCB RID: 31947
		private NPCHeadDrawRenderTargetContent[] _contents;

		// Token: 0x04007CCC RID: 31948
		private Asset<Texture2D>[] _matchingArray;
	}
}
