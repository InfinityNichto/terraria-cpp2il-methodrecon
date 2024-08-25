using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x02000070 RID: 112
	public static class StencilMaterial
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Material.Add instead.", true)]
		public static Material Add(Material baseMat, int stencilID)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			if (!true)
			{
			}
			Material material;
			return material;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
		private static void LogWarningWhenNotInBatchmode(string warning, Object context)
		{
			bool isBatchMode = Application.isBatchMode;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000E9E4 File Offset: 0x0000CBE4
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			if (!true)
			{
			}
			if ("_ColorMask" == null)
			{
			}
			if ("_ColorMask" == null)
			{
			}
			string text;
			if (text == null || text != null)
			{
				if ("_ColorMask" != null)
				{
				}
				if ("_ColorMask" == null)
				{
				}
				return "_ColorMask";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000EA38 File Offset: 0x0000CC38
		public static void Remove(Material customMat)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000EA54 File Offset: 0x0000CC54
		public static void ClearAll()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000EA68 File Offset: 0x0000CC68
		// Note: this type is marked as 'beforefieldinit'.
		static StencilMaterial()
		{
		}

		// Token: 0x04000238 RID: 568
		private static List<StencilMaterial.MatEntry> m_List;

		// Token: 0x02000071 RID: 113
		private class MatEntry
		{
			// Token: 0x0600049A RID: 1178 RVA: 0x0000EA78 File Offset: 0x0000CC78
			public MatEntry()
			{
			}

			// Token: 0x04000239 RID: 569
			public Material baseMat;

			// Token: 0x0400023A RID: 570
			public Material customMat;

			// Token: 0x0400023B RID: 571
			public int count;

			// Token: 0x0400023C RID: 572
			public int stencilId;

			// Token: 0x0400023D RID: 573
			public StencilOp operation;

			// Token: 0x0400023E RID: 574
			public CompareFunction compareFunction = CompareFunction.Always;

			// Token: 0x0400023F RID: 575
			public int readMask;

			// Token: 0x04000240 RID: 576
			public int writeMask;

			// Token: 0x04000241 RID: 577
			public bool useAlphaClip;

			// Token: 0x04000242 RID: 578
			public ColorWriteMask colorMask;
		}
	}
}
