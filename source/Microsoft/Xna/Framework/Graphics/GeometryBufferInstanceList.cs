using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000373 RID: 883
	public class GeometryBufferInstanceList
	{
		// Token: 0x06001704 RID: 5892 RVA: 0x000646D0 File Offset: 0x000628D0
		public GeometryBufferInstanceList(int vertexCount, [Optional] string rootName, int forcedLayer = -1)
		{
			this._rootName = rootName;
			this._vertexCount = vertexCount;
			this._finalPending = forcedLayer != 0;
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x000021DB File Offset: 0x000003DB
		public GeometryBufferInstance GetBatchInstance(int bufferOffest)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000021DB File Offset: 0x000003DB
		public GeometryBufferInstance GetInstance(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, int bufferOffest)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000021DB File Offset: 0x000003DB
		public GeometryBufferInstance GetInstance(List<Vector3> positions, List<Vector2> uvs, List<Vector4> uv2s, List<Color32> colours, List<int> indices, int bufferOffest)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000646F8 File Offset: 0x000628F8
		private void SetupParent()
		{
			GameObject parent = this._parent;
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag = string.IsNullOrEmpty(this._rootName);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00064758 File Offset: 0x00062958
		public void SetOffset(Vector2 offset)
		{
			GameObject parent = this._parent;
			if (!true)
			{
			}
			this.SetupParent();
			Transform parentTransform = this._parentTransform;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000021DB File Offset: 0x000003DB
		public void FinaliseInstances()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x000021DB File Offset: 0x000003DB
		public void ClearInstances()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0006477C File Offset: 0x0006297C
		// Note: this type is marked as 'beforefieldinit'.
		static GeometryBufferInstanceList()
		{
		}

		// Token: 0x0400259D RID: 9629
		private static GameObject _root;

		// Token: 0x0400259E RID: 9630
		private readonly string _rootName;

		// Token: 0x0400259F RID: 9631
		private GameObject _parent;

		// Token: 0x040025A0 RID: 9632
		private Transform _parentTransform;

		// Token: 0x040025A1 RID: 9633
		private List<GeometryBufferInstance> _freeInstances;

		// Token: 0x040025A2 RID: 9634
		private List<GeometryBufferInstance> _usedInstances;

		// Token: 0x040025A3 RID: 9635
		private int _resetOffset;

		// Token: 0x040025A4 RID: 9636
		private int _vertexCount;

		// Token: 0x040025A5 RID: 9637
		private int _forcedLayer;

		// Token: 0x040025A6 RID: 9638
		public static VertexAttributeDescriptor[] vertexDescription;

		// Token: 0x040025A7 RID: 9639
		private static SubMeshDescriptor[] subMeshes;

		// Token: 0x040025A8 RID: 9640
		private bool _finalPending;
	}
}
