using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x0200061D RID: 1565
	public struct ContainerTransferContext
	{
		// Token: 0x060035CC RID: 13772 RVA: 0x000021DB File Offset: 0x000003DB
		public static ContainerTransferContext FromProjectile(Projectile projectile)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x000021DB File Offset: 0x000003DB
		public static ContainerTransferContext FromBlockPosition(int x, int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x00211A8C File Offset: 0x0020FC8C
		public static ContainerTransferContext FromUnknown(Player player)
		{
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x00211A9C File Offset: 0x0020FC9C
		public ContainerTransferContext(Vector2 position)
		{
			this.CanVisualizeTransfers = true;
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x00211AB0 File Offset: 0x0020FCB0
		public Vector2 GetContainerWorldPosition()
		{
			Vector2 position = this._position;
			Vector2 vector;
			return vector;
		}

		// Token: 0x040076A3 RID: 30371
		private Vector2 _position;

		// Token: 0x040076A4 RID: 30372
		public bool CanVisualizeTransfers;
	}
}
