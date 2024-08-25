using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010D RID: 269
	public struct SubMeshDescriptor
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x000099B8 File Offset: 0x00007BB8
		public SubMeshDescriptor(int indexStart, int indexCount, MeshTopology topology = MeshTopology.Triangles)
		{
			this.topology = topology;
			this.indexCount = indexStart;
			this.indexCount = indexCount;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000021B3 File Offset: 0x000003B3
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x000099DC File Offset: 0x00007BDC
		public Bounds bounds
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
				float y = value.m_Extents.y;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x000099F8 File Offset: 0x00007BF8
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00009A0C File Offset: 0x00007C0C
		public MeshTopology topology
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<topology>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<topology>k__BackingField = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00009A20 File Offset: 0x00007C20
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00009A34 File Offset: 0x00007C34
		public int indexStart
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<indexStart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<indexStart>k__BackingField = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00009A48 File Offset: 0x00007C48
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00009A5C File Offset: 0x00007C5C
		public int indexCount
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<indexCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<indexCount>k__BackingField = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00009A70 File Offset: 0x00007C70
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00009A84 File Offset: 0x00007C84
		public int baseVertex
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<baseVertex>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<baseVertex>k__BackingField = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00009A98 File Offset: 0x00007C98
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00009AAC File Offset: 0x00007CAC
		public int firstVertex
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<firstVertex>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<firstVertex>k__BackingField = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00009AC0 File Offset: 0x00007CC0
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00009AD4 File Offset: 0x00007CD4
		public int vertexCount
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<vertexCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<vertexCount>k__BackingField = value;
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00009AE8 File Offset: 0x00007CE8
		public override string ToString()
		{
			MeshTopology meshTopology = this.<topology>k__BackingField;
			int num = this.<indexStart>k__BackingField;
			int num2 = this.<indexCount>k__BackingField;
			int num3 = this.<firstVertex>k__BackingField;
			int num4 = this.<vertexCount>k__BackingField;
			int num5 = this.<baseVertex>k__BackingField;
			string text;
			return text;
		}

		// Token: 0x0400046D RID: 1133
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Bounds <bounds>k__BackingField;

		// Token: 0x0400046E RID: 1134
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private MeshTopology <topology>k__BackingField;

		// Token: 0x0400046F RID: 1135
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <indexStart>k__BackingField;

		// Token: 0x04000470 RID: 1136
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <indexCount>k__BackingField;

		// Token: 0x04000471 RID: 1137
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <baseVertex>k__BackingField;

		// Token: 0x04000472 RID: 1138
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int <firstVertex>k__BackingField;

		// Token: 0x04000473 RID: 1139
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int <vertexCount>k__BackingField;
	}
}
