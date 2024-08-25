using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[UsedByNativeCode]
	public struct UIVertex
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000025B4 File Offset: 0x000007B4
		// Note: this type is marked as 'beforefieldinit'.
		static UIVertex()
		{
		}

		// Token: 0x0400003E RID: 62
		public Vector3 position;

		// Token: 0x0400003F RID: 63
		public Vector3 normal;

		// Token: 0x04000040 RID: 64
		public Vector4 tangent;

		// Token: 0x04000041 RID: 65
		public Color32 color;

		// Token: 0x04000042 RID: 66
		public Vector4 uv0;

		// Token: 0x04000043 RID: 67
		public Vector4 uv1;

		// Token: 0x04000044 RID: 68
		public Vector4 uv2;

		// Token: 0x04000045 RID: 69
		public Vector4 uv3;

		// Token: 0x04000046 RID: 70
		private static readonly Color32 s_DefaultColor;

		// Token: 0x04000047 RID: 71
		private static readonly Vector4 s_DefaultTangent;

		// Token: 0x04000048 RID: 72
		public static UIVertex simpleVert;
	}
}
