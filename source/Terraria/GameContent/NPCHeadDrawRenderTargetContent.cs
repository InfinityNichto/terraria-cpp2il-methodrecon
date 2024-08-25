using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020007CC RID: 1996
	public class NPCHeadDrawRenderTargetContent : AnOutlinedDrawRenderTargetContent
	{
		// Token: 0x060040AA RID: 16554 RVA: 0x00243958 File Offset: 0x00241B58
		public void SetTexture(Texture2D texture)
		{
			Texture2D theTexture = this._theTexture;
			this._theTexture = texture;
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00243974 File Offset: 0x00241B74
		internal override void DrawTheContent(SpriteBatch spriteBatch)
		{
			Texture2D theTexture = this._theTexture;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x00243990 File Offset: 0x00241B90
		public NPCHeadDrawRenderTargetContent()
		{
		}

		// Token: 0x04007E5D RID: 32349
		private Texture2D _theTexture;
	}
}
