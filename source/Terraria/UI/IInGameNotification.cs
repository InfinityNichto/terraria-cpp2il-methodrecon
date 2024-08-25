using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x020006E1 RID: 1761
	public interface IInGameNotification
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06003B1F RID: 15135
		object CreationObject { get; }

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06003B20 RID: 15136
		bool ShouldBeRemoved { get; }

		// Token: 0x06003B21 RID: 15137
		void Update();

		// Token: 0x06003B22 RID: 15138
		void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition);

		// Token: 0x06003B23 RID: 15139
		void PushAnchor(Vector2 positionAnchorBottom);

		// Token: 0x06003B24 RID: 15140
		void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, int gamepadPointLocalIndexTouse);
	}
}
