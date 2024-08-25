using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000405 RID: 1029
	internal sealed class BinaryObject
	{
		// Token: 0x06001FE5 RID: 8165 RVA: 0x00046054 File Offset: 0x00044254
		internal BinaryObject()
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00046068 File Offset: 0x00044268
		internal void Set(int objectId, int mapId)
		{
			this.objectId = objectId;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0004607C File Offset: 0x0004427C
		public void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryWriter dataWriter2 = sout.dataWriter;
			int num = this.objectId;
			BinaryWriter dataWriter3 = sout.dataWriter;
			int num2 = this.mapId;
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x000460B0 File Offset: 0x000442B0
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.objectId = num;
			int num2 = input.ReadInt32();
			this.mapId = num2;
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x000460DC File Offset: 0x000442DC
		public void Dump()
		{
		}

		// Token: 0x04001069 RID: 4201
		internal int objectId;

		// Token: 0x0400106A RID: 4202
		internal int mapId;
	}
}
