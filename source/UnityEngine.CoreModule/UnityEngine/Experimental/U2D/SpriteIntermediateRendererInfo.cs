using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000128 RID: 296
	[NativeHeader("Runtime/2D/Renderer/SpriteRendererGroup.h")]
	[RequiredByNativeCode]
	internal struct SpriteIntermediateRendererInfo
	{
		// Token: 0x040004EA RID: 1258
		public int SpriteID;

		// Token: 0x040004EB RID: 1259
		public int TextureID;

		// Token: 0x040004EC RID: 1260
		public int MaterialID;

		// Token: 0x040004ED RID: 1261
		public Color Color;

		// Token: 0x040004EE RID: 1262
		public Matrix4x4 Transform;

		// Token: 0x040004EF RID: 1263
		public Bounds Bounds;

		// Token: 0x040004F0 RID: 1264
		public int Layer;

		// Token: 0x040004F1 RID: 1265
		public int SortingLayer;

		// Token: 0x040004F2 RID: 1266
		public int SortingOrder;

		// Token: 0x040004F3 RID: 1267
		public ulong SceneCullingMask;

		// Token: 0x040004F4 RID: 1268
		public IntPtr IndexData;

		// Token: 0x040004F5 RID: 1269
		public IntPtr VertexData;

		// Token: 0x040004F6 RID: 1270
		public int IndexCount;

		// Token: 0x040004F7 RID: 1271
		public int VertexCount;

		// Token: 0x040004F8 RID: 1272
		public int ShaderChannelMask;
	}
}
