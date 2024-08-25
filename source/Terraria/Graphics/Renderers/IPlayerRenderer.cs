using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x0200075C RID: 1884
	public interface IPlayerRenderer
	{
		// Token: 0x06003DF7 RID: 15863
		void DrawPlayers(Camera camera, IEnumerable<Player> players);

		// Token: 0x06003DF8 RID: 15864
		void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor);

		// Token: 0x06003DF9 RID: 15865
		void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets);
	}
}
