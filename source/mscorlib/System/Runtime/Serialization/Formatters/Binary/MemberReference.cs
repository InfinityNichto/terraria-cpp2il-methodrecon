using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000410 RID: 1040
	internal sealed class MemberReference
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x00046AF0 File Offset: 0x00044CF0
		internal MemberReference()
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00046B04 File Offset: 0x00044D04
		internal void Set(int idRef)
		{
			this.idRef = idRef;
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00046B18 File Offset: 0x00044D18
		public void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryWriter dataWriter2 = sout.dataWriter;
			int num = this.idRef;
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00046B3C File Offset: 0x00044D3C
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.idRef = num;
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00046B58 File Offset: 0x00044D58
		public void Dump()
		{
		}

		// Token: 0x0400109B RID: 4251
		internal int idRef;
	}
}
