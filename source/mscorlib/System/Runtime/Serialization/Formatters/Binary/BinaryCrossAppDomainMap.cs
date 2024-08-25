using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200040A RID: 1034
	internal sealed class BinaryCrossAppDomainMap
	{
		// Token: 0x06001FF9 RID: 8185 RVA: 0x00046350 File Offset: 0x00044550
		internal BinaryCrossAppDomainMap()
		{
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00046364 File Offset: 0x00044564
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.crossAppDomainArrayIndex = num;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00046380 File Offset: 0x00044580
		public void Dump()
		{
		}

		// Token: 0x0400107E RID: 4222
		internal int crossAppDomainArrayIndex;
	}
}
