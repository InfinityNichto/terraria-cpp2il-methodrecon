using System;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x020007F6 RID: 2038
	public struct TeleportPylonInfo : IEquatable<TeleportPylonInfo>
	{
		// Token: 0x06004188 RID: 16776 RVA: 0x00247EE8 File Offset: 0x002460E8
		public bool Equals(TeleportPylonInfo other)
		{
			if (!true)
			{
			}
			TeleportPylonType typeOfPylon = this.TypeOfPylon;
			bool flag;
			return flag;
		}

		// Token: 0x04007F0E RID: 32526
		public Point16 PositionInTiles;

		// Token: 0x04007F0F RID: 32527
		public TeleportPylonType TypeOfPylon;
	}
}
