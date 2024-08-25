using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x020007CB RID: 1995
	public class PlayerHeadDrawRenderTargetContent : AnOutlinedDrawRenderTargetContent
	{
		// Token: 0x060040A7 RID: 16551 RVA: 0x002438D8 File Offset: 0x00241AD8
		public void UsePlayer(Player player)
		{
			this._player = player;
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x002438EC File Offset: 0x00241AEC
		internal override void DrawTheContent(SpriteBatch spriteBatch)
		{
			if (this._player != null)
			{
				List<int> dust = this._dust;
				int version = dust._version;
				dust._syncRoot = version;
				List<int> gore = this._gore;
				int version2 = gore._version;
				gore._syncRoot = version2;
				int width = this.width;
				Color borderColor = this._borderColor;
				DrawData[] drawData = this._drawData;
			}
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00243944 File Offset: 0x00241B44
		public PlayerHeadDrawRenderTargetContent()
		{
		}

		// Token: 0x04007E59 RID: 32345
		private Player _player;

		// Token: 0x04007E5A RID: 32346
		private readonly DrawData[] _drawData;

		// Token: 0x04007E5B RID: 32347
		private readonly List<int> _dust;

		// Token: 0x04007E5C RID: 32348
		private readonly List<int> _gore;
	}
}
