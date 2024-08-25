using System;
using Cpp2IlInjected;

namespace Terraria.DataStructures
{
	// Token: 0x02000647 RID: 1607
	public struct PlayerInteractionAnchor
	{
		// Token: 0x060036D4 RID: 14036 RVA: 0x00220998 File Offset: 0x0021EB98
		public PlayerInteractionAnchor(int entityID, int x = -1, int y = -1)
		{
			this.interactEntityID = entityID;
			this.Y = x;
			this.Y = y;
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x000021DB File Offset: 0x000003DB
		public bool InUse
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x002209BC File Offset: 0x0021EBBC
		public void Clear()
		{
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x002209CC File Offset: 0x0021EBCC
		public void Set(int entityID, int x, int y)
		{
			this.interactEntityID = entityID;
			this.Y = x;
			this.Y = y;
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x002209F0 File Offset: 0x0021EBF0
		public bool IsInValidUseTileEntity()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00220A04 File Offset: 0x0021EC04
		public TileEntity GetTileEntity()
		{
			bool flag = this.IsInValidUseTileEntity();
			if (!true)
			{
				return;
			}
		}

		// Token: 0x040077DE RID: 30686
		public int interactEntityID;

		// Token: 0x040077DF RID: 30687
		public int X;

		// Token: 0x040077E0 RID: 30688
		public int Y;
	}
}
