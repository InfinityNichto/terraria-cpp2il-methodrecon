using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.UI
{
	// Token: 0x0200007F RID: 127
	public class VertexHelper : IDisposable
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x0000FD58 File Offset: 0x0000DF58
		public VertexHelper()
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		public VertexHelper(Mesh m)
		{
			this.InitializeListIfRequired();
			List<Vector3> positions = this.m_Positions;
			Vector3[] vertices = m.vertices;
			List<Color32> colors = this.m_Colors;
			Color32[] colors2 = m.colors32;
			List<Vector4> uv0S = this.m_Uv0S;
			List<Vector4> uv1S = this.m_Uv1S;
			List<Vector4> uv2S = this.m_Uv2S;
			List<Vector4> uv3S = this.m_Uv3S;
			List<Vector3> normals = this.m_Normals;
			Vector3[] normals2 = m.normals;
			List<Vector4> tangents = this.m_Tangents;
			Vector4[] tangents2 = m.tangents;
			List<int> indices = this.m_Indices;
			long num = 0L;
			int[] indices2 = m.GetIndices((int)num);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002207 File Offset: 0x00000407
		private void InitializeListIfRequired()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		public void Dispose()
		{
			if (this.m_ListsInitalized)
			{
				List<Vector3> positions = this.m_Positions;
				List<Color32> colors = this.m_Colors;
				List<Vector4> uv0S = this.m_Uv0S;
				List<Vector4> uv1S = this.m_Uv1S;
				List<Vector4> uv2S = this.m_Uv2S;
				List<Vector4> uv3S = this.m_Uv3S;
				List<Vector3> normals = this.m_Normals;
				List<Vector4> tangents = this.m_Tangents;
				List<int> indices = this.m_Indices;
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000FE54 File Offset: 0x0000E054
		public void Clear()
		{
			if (this.m_ListsInitalized)
			{
				List<Vector3> positions = this.m_Positions;
				int version = positions._version;
				positions._syncRoot = version;
				List<Color32> colors = this.m_Colors;
				int version2 = colors._version;
				colors._syncRoot = version2;
				List<Vector4> uv0S = this.m_Uv0S;
				int version3 = uv0S._version;
				uv0S._syncRoot = version3;
				List<Vector4> uv1S = this.m_Uv1S;
				int version4 = uv1S._version;
				uv1S._syncRoot = version4;
				List<Vector4> uv2S = this.m_Uv2S;
				int version5 = uv2S._version;
				uv2S._syncRoot = version5;
				List<Vector4> uv3S = this.m_Uv3S;
				int version6 = uv3S._version;
				uv3S._syncRoot = version6;
				List<Vector3> normals = this.m_Normals;
				int version7 = normals._version;
				normals._syncRoot = version7;
				List<Vector4> tangents = this.m_Tangents;
				int version8 = tangents._version;
				tangents._syncRoot = version8;
				List<int> indices = this.m_Indices;
				int version9 = indices._version;
				indices._syncRoot = version9;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0000FF4C File Offset: 0x0000E14C
		public int currentVertCount
		{
			get
			{
				List<Vector3> positions = this.m_Positions;
				if (positions != null)
				{
					return positions._size;
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0000FF6C File Offset: 0x0000E16C
		public int currentIndexCount
		{
			get
			{
				List<int> indices = this.m_Indices;
				if (indices != null)
				{
					return indices._size;
				}
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000FF8C File Offset: 0x0000E18C
		public void PopulateUIVertex(UIVertex vertex, int i)
		{
			this.InitializeListIfRequired();
			List<Vector3> positions = this.m_Positions;
			List<Color32> colors = this.m_Colors;
			vertex.color = colors;
			List<Vector4> uv0S = this.m_Uv0S;
			List<Vector4> uv1S = this.m_Uv1S;
			List<Vector4> uv2S = this.m_Uv2S;
			List<Vector4> uv3S = this.m_Uv3S;
			List<Vector3> normals = this.m_Normals;
			List<Vector4> tangents = this.m_Tangents;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		public void SetUIVertex(UIVertex vertex, int i)
		{
			this.InitializeListIfRequired();
			List<Vector3> positions = this.m_Positions;
			Vector3 position = vertex.position;
			List<Color32> colors = this.m_Colors;
			Color32 color = vertex.color;
			List<Vector4> uv0S = this.m_Uv0S;
			float x = vertex.uv0.x;
			float y = vertex.uv0.y;
			float z = vertex.uv0.z;
			float w = vertex.uv0.w;
			List<Vector4> uv1S = this.m_Uv1S;
			float x2 = vertex.uv1.x;
			float y2 = vertex.uv1.y;
			float z2 = vertex.uv1.z;
			float w2 = vertex.uv1.w;
			List<Vector4> uv2S = this.m_Uv2S;
			float x3 = vertex.uv2.x;
			float y3 = vertex.uv2.y;
			float z3 = vertex.uv2.z;
			float w3 = vertex.uv2.w;
			List<Vector4> uv3S = this.m_Uv3S;
			float x4 = vertex.uv3.x;
			float y4 = vertex.uv3.y;
			float z4 = vertex.uv3.z;
			float w4 = vertex.uv3.w;
			List<Vector3> normals = this.m_Normals;
			float x5 = vertex.normal.x;
			float y5 = vertex.normal.y;
			float z5 = vertex.normal.z;
			List<Vector4> tangents = this.m_Tangents;
			float x6 = vertex.tangent.x;
			float y6 = vertex.tangent.y;
			float z6 = vertex.tangent.z;
			float w5 = vertex.tangent.w;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00010170 File Offset: 0x0000E370
		public void FillMesh(Mesh mesh)
		{
			this.InitializeListIfRequired();
			mesh.Clear();
			List<Vector3> positions = this.m_Positions;
			int size = positions._size;
			mesh.SetVertices(positions);
			List<Color32> colors = this.m_Colors;
			mesh.SetColors(colors);
			List<Vector4> uv0S = this.m_Uv0S;
			long num = 0L;
			mesh.SetUVs((int)num, uv0S);
			List<Vector4> uv1S = this.m_Uv1S;
			mesh.SetUVs(1, uv1S);
			List<Vector4> uv2S = this.m_Uv2S;
			mesh.SetUVs(2, uv2S);
			List<Vector4> uv3S = this.m_Uv3S;
			mesh.SetUVs(3, uv3S);
			List<Vector3> normals = this.m_Normals;
			mesh.SetNormals(normals);
			List<Vector4> tangents = this.m_Tangents;
			mesh.SetTangents(tangents);
			List<int> indices = this.m_Indices;
			long num2 = 0L;
			mesh.SetTriangles(indices, (int)num2);
			mesh.RecalculateBounds();
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002207 File Offset: 0x00000407
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00010230 File Offset: 0x0000E430
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00010240 File Offset: 0x0000E440
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00010250 File Offset: 0x0000E450
		public void AddVert(UIVertex v)
		{
			Color32 color = v.color;
			Vector3 position = v.position;
			float x = v.uv0.x;
			float y = v.uv0.y;
			float z = v.uv0.z;
			float w = v.uv0.w;
			float z2 = v.uv1.z;
			float w2 = v.uv1.w;
			float y2 = v.uv2.y;
			float x2 = v.uv3.x;
			float y3 = v.uv3.y;
			float w3 = v.uv3.w;
			float z3 = v.normal.z;
			float x3 = v.tangent.x;
			float w4 = v.tangent.w;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002207 File Offset: 0x00000407
		public void AddTriangle(int idx0, int idx1, int idx2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00010314 File Offset: 0x0000E514
		public void AddUIVertexQuad(UIVertex[] verts)
		{
			List<Vector3> positions = this.m_Positions;
			if (positions != null)
			{
				int size = positions._size;
				return;
			}
			object syncRoot = positions._syncRoot;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001033C File Offset: 0x0000E53C
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
			this.InitializeListIfRequired();
			if (verts != null)
			{
				List<Vector3> positions = this.m_Positions;
				List<Color32> colors = this.m_Colors;
				List<Vector4> uv0S = this.m_Uv0S;
				List<Vector4> uv1S = this.m_Uv1S;
				List<Vector4> uv2S = this.m_Uv2S;
				List<Vector4> uv3S = this.m_Uv3S;
				List<Vector3> normals = this.m_Normals;
				List<Vector4> tangents = this.m_Tangents;
			}
			if (indices != null)
			{
				List<int> indices2 = this.m_Indices;
				return;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001039C File Offset: 0x0000E59C
		public void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
			if (verts != null)
			{
				this.InitializeListIfRequired();
				List<Vector3> positions = this.m_Positions;
				List<Color32> colors = this.m_Colors;
				List<Vector4> uv0S = this.m_Uv0S;
				List<Vector4> uv1S = this.m_Uv1S;
				List<Vector4> uv2S = this.m_Uv2S;
				List<Vector4> uv3S = this.m_Uv3S;
				List<Vector3> normals = this.m_Normals;
				List<Vector4> tangents = this.m_Tangents;
				List<int> indices = this.m_Indices;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000103F8 File Offset: 0x0000E5F8
		public void GetUIVertexStream(List<UIVertex> stream)
		{
			if (stream != null)
			{
				this.InitializeListIfRequired();
				List<Vector3> positions = this.m_Positions;
				List<Color32> colors = this.m_Colors;
				List<Vector4> uv0S = this.m_Uv0S;
				List<Vector4> uv1S = this.m_Uv1S;
				List<Vector4> uv2S = this.m_Uv2S;
				List<Vector4> uv3S = this.m_Uv3S;
				List<Vector3> normals = this.m_Normals;
				List<Vector4> tangents = this.m_Tangents;
				List<int> indices = this.m_Indices;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00010454 File Offset: 0x0000E654
		// Note: this type is marked as 'beforefieldinit'.
		static VertexHelper()
		{
		}

		// Token: 0x0400025E RID: 606
		private List<Vector3> m_Positions;

		// Token: 0x0400025F RID: 607
		private List<Color32> m_Colors;

		// Token: 0x04000260 RID: 608
		private List<Vector4> m_Uv0S;

		// Token: 0x04000261 RID: 609
		private List<Vector4> m_Uv1S;

		// Token: 0x04000262 RID: 610
		private List<Vector4> m_Uv2S;

		// Token: 0x04000263 RID: 611
		private List<Vector4> m_Uv3S;

		// Token: 0x04000264 RID: 612
		private List<Vector3> m_Normals;

		// Token: 0x04000265 RID: 613
		private List<Vector4> m_Tangents;

		// Token: 0x04000266 RID: 614
		private List<int> m_Indices;

		// Token: 0x04000267 RID: 615
		private static readonly Vector4 s_DefaultTangent;

		// Token: 0x04000268 RID: 616
		private static readonly Vector3 s_DefaultNormal;

		// Token: 0x04000269 RID: 617
		private bool m_ListsInitalized;
	}
}
