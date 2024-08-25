using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	// Token: 0x02000B38 RID: 2872
	public interface IDebugDrawer
	{
		// Token: 0x060053BB RID: 21435
		void DrawSquare(Vector4 positionAndSize, Color color);

		// Token: 0x060053BC RID: 21436
		void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color);
	}
}
