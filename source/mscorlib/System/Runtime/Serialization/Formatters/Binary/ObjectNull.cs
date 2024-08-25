using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000411 RID: 1041
	internal sealed class ObjectNull
	{
		// Token: 0x0600201C RID: 8220 RVA: 0x00046B68 File Offset: 0x00044D68
		internal ObjectNull()
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00046B7C File Offset: 0x00044D7C
		internal void SetNullCount(int nullCount)
		{
			this.nullCount = nullCount;
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00046B90 File Offset: 0x00044D90
		public void Write(__BinaryWriter sout)
		{
			int num = this.nullCount;
			BinaryWriter dataWriter = sout.dataWriter;
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00046BD4 File Offset: 0x00044DD4
		public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum)
		{
			byte b = input.ReadByte();
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00046BF4 File Offset: 0x00044DF4
		public void Dump()
		{
		}

		// Token: 0x0400109C RID: 4252
		internal int nullCount;
	}
}
