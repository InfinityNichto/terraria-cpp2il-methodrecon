using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Map
{
	// Token: 0x020006B9 RID: 1721
	public class MapIconOverlay
	{
		// Token: 0x0600390F RID: 14607 RVA: 0x000021DB File Offset: 0x000003DB
		public MapIconOverlay AddLayer(IMapLayer layer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x0022C588 File Offset: 0x0022A788
		public void Draw(Vector2 mapPosition, Vector2 mapOffset, Rectangle? clippingRect, float mapScale, float drawScale, string text)
		{
			List<IMapLayer> layers = this._layers;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x0022C5B4 File Offset: 0x0022A7B4
		public MapIconOverlay()
		{
		}

		// Token: 0x040079A7 RID: 31143
		private readonly List<IMapLayer> _layers;
	}
}
