using System;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.Map
{
	// Token: 0x020006BD RID: 1725
	public class PingMapLayer : IMapLayer
	{
		// Token: 0x06003922 RID: 14626 RVA: 0x0022C838 File Offset: 0x0022AA38
		public void Draw(MapOverlayDrawContext context, string text)
		{
			DateTime now = DateTime.Now;
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x0022C88C File Offset: 0x0022AA8C
		public void Add(Vector2 position)
		{
			int <Count>k__BackingField = this._pings.<Count>k__BackingField;
			SlotVector<PingMapLayer.Ping> pings = this._pings;
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0022C8AC File Offset: 0x0022AAAC
		public PingMapLayer()
		{
		}

		// Token: 0x040079B2 RID: 31154
		private const double PING_DURATION_IN_SECONDS = 15.0;

		// Token: 0x040079B3 RID: 31155
		private const double PING_FRAME_RATE = 10.0;

		// Token: 0x040079B4 RID: 31156
		private readonly SlotVector<PingMapLayer.Ping> _pings;

		// Token: 0x020006BE RID: 1726
		private struct Ping
		{
			// Token: 0x06003925 RID: 14629 RVA: 0x0022C8C0 File Offset: 0x0022AAC0
			public Ping(Vector2 position)
			{
				if (!true)
				{
				}
				DateTime now = DateTime.Now;
				this.Time = now;
			}

			// Token: 0x040079B5 RID: 31157
			public readonly Vector2 Position;

			// Token: 0x040079B6 RID: 31158
			public readonly DateTime Time;
		}
	}
}
