using System;
using System.Runtime.InteropServices;

namespace Terraria.Modules
{
	// Token: 0x02000547 RID: 1351
	public class AnchorTypesModule
	{
		// Token: 0x060032EA RID: 13034 RVA: 0x001FDF40 File Offset: 0x001FC140
		public AnchorTypesModule([Optional] AnchorTypesModule copyFrom)
		{
			if (copyFrom == null)
			{
				return;
			}
			if (copyFrom.tileValid != null)
			{
				int[] array = copyFrom.tileValid;
				return;
			}
			if (copyFrom.tileInvalid != null)
			{
				int[] array2 = copyFrom.tileInvalid;
				return;
			}
			if (copyFrom.tileAlternates != null)
			{
				int[] array3 = copyFrom.tileAlternates;
				return;
			}
			if (copyFrom.wallValid != null)
			{
				int[] array4 = copyFrom.wallValid;
				return;
			}
		}

		// Token: 0x04003BDC RID: 15324
		public int[] tileValid;

		// Token: 0x04003BDD RID: 15325
		public int[] tileInvalid;

		// Token: 0x04003BDE RID: 15326
		public int[] tileAlternates;

		// Token: 0x04003BDF RID: 15327
		public int[] wallValid;
	}
}
