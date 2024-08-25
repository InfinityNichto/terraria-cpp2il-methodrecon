using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Animations
{
	// Token: 0x020009A3 RID: 2467
	public class StardewValleyAnimation
	{
		// Token: 0x06004901 RID: 18689 RVA: 0x00260EE4 File Offset: 0x0025F0E4
		public StardewValleyAnimation()
		{
			this.ComposeAnimation();
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00260F00 File Offset: 0x0025F100
		private void ComposeAnimation()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			Rectangle rectangle;
			Vector2 vector = rectangle.Size();
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value2 = num3.m_value;
			if (!true)
			{
			}
			int num4 = 1;
			if (num4 == 0)
			{
			}
			int value3 = num4.m_value;
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x00260FC8 File Offset: 0x0025F1C8
		private Matrix GetMatrixForAnimation()
		{
			if (!true)
			{
			}
			Matrix transform = Main.Transform;
			return 1;
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x00260FE4 File Offset: 0x0025F1E4
		public void Draw(SpriteBatch spriteBatch, int timeInAnimation, Vector2 positionInScreen)
		{
			int size = this._segments._size;
		}

		// Token: 0x0400842D RID: 33837
		private List<IAnimationSegment> _segments;
	}
}
