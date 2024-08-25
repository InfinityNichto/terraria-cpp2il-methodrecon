using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000669 RID: 1641
	public class EntitySource_TileEntity : IEntitySource
	{
		// Token: 0x06003707 RID: 14087 RVA: 0x00220F80 File Offset: 0x0021F180
		public EntitySource_TileEntity(TileEntity tileEntity)
		{
			this.TileEntity = tileEntity;
		}

		// Token: 0x04007811 RID: 30737
		public TileEntity TileEntity;
	}
}
