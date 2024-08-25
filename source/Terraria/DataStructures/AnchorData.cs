using System;
using Terraria.Enums;

namespace Terraria.DataStructures
{
	// Token: 0x02000618 RID: 1560
	public struct AnchorData
	{
		// Token: 0x060035B3 RID: 13747 RVA: 0x00211770 File Offset: 0x0020F970
		public AnchorData(AnchorType type, int count, int start)
		{
			this.type = type;
			this.checkStart = count;
			this.checkStart = start;
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00211794 File Offset: 0x0020F994
		public static bool operator ==(AnchorData data1, AnchorData data2)
		{
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x002117A4 File Offset: 0x0020F9A4
		public static bool operator !=(AnchorData data1, AnchorData data2)
		{
			return true;
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x002117B4 File Offset: 0x0020F9B4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				int num = this.tileCount;
				int num2 = this.checkStart;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x002117DC File Offset: 0x0020F9DC
		public override int GetHashCode()
		{
			int num = this.checkStart;
			AnchorType anchorType = this.type;
			int num2 = this.checkStart;
			return num;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00211800 File Offset: 0x0020FA00
		// Note: this type is marked as 'beforefieldinit'.
		static AnchorData()
		{
		}

		// Token: 0x0400768E RID: 30350
		public AnchorType type;

		// Token: 0x0400768F RID: 30351
		public int tileCount;

		// Token: 0x04007690 RID: 30352
		public int checkStart;

		// Token: 0x04007691 RID: 30353
		public static AnchorData Empty;
	}
}
