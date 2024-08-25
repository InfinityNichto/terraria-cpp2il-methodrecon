using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[NativeHeader("Modules/UI/CanvasRenderer.h")]
	[NativeClass("UI::CanvasRenderer")]
	public sealed class CanvasRenderer : Component
	{
		// Token: 0x17000001 RID: 1
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002218 File Offset: 0x00000418
		public bool hasPopInstruction
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000222C File Offset: 0x0000042C
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002240 File Offset: 0x00000440
		public int materialCount
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002254 File Offset: 0x00000454
		public int popMaterialCount
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002268 File Offset: 0x00000468
		public int absoluteDepth
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000227C File Offset: 0x0000047C
		public bool hasMoved
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002290 File Offset: 0x00000490
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000022A4 File Offset: 0x000004A4
		[NativeProperty("ShouldCull", false, TargetType.Function)]
		public bool cull
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022B8 File Offset: 0x000004B8
		public void SetColor(Color color)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022CC File Offset: 0x000004CC
		public Color GetColor()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022E0 File Offset: 0x000004E0
		public void EnableRectClipping(Rect rect)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000022F4 File Offset: 0x000004F4
		public Vector2 clippingSoftness
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002308 File Offset: 0x00000508
		public void DisableRectClipping()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000231C File Offset: 0x0000051C
		public void SetMaterial(Material material, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002330 File Offset: 0x00000530
		public void SetPopMaterial(Material material, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002344 File Offset: 0x00000544
		public void SetTexture(Texture texture)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002358 File Offset: 0x00000558
		public void SetAlphaTexture(Texture texture)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000236C File Offset: 0x0000056C
		public void SetMesh(Mesh mesh)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002380 File Offset: 0x00000580
		public void Clear()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002394 File Offset: 0x00000594
		public void SetMaterial(Material material, Texture texture)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000023BC File Offset: 0x000005BC
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000023D8 File Offset: 0x000005D8
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000023EC File Offset: 0x000005EC
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002400 File Offset: 0x00000600
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void SplitIndicesStreamsInternal(object verts, object indices)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002414 File Offset: 0x00000614
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002428 File Offset: 0x00000628
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000243C File Offset: 0x0000063C
		private void SetColor_Injected(Color color)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002450 File Offset: 0x00000650
		private void GetColor_Injected([Out] Color ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002464 File Offset: 0x00000664
		private void EnableRectClipping_Injected(Rect rect)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002478 File Offset: 0x00000678
		private void set_clippingSoftness_Injected(Vector2 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000002 RID: 2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <isMask>k__BackingField;
	}
}
