using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200038D RID: 909
	public class SpriteBatcher
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x00067A7C File Offset: 0x00065C7C
		public SpriteBatcher(GraphicsDevice device)
		{
			int num = 1;
			this._lastBatchListId = num;
			base..ctor();
			this._device = device;
			SpriteBatchItem[] batchItemList = this._batchItemList;
			SpriteBatchItemList[] batchItemListList = this._batchItemListList;
			this.InitialiseIndexBuffer();
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00067AD8 File Offset: 0x00065CD8
		private void InitialiseIndexBuffer()
		{
			if (this.indexData != null)
			{
				return;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x00067AF0 File Offset: 0x00065CF0
		public int BatchCount
		{
			get
			{
				return this._batchItemCount;
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00067B04 File Offset: 0x00065D04
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public SpriteBatchItem CreateBatchItem()
		{
			Texture2D texture = this._batchItemList.Texture;
			SpriteBatchItem[] batchItemList = this._batchItemList;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00067B2C File Offset: 0x00065D2C
		public void GetBatchItemList(int id, [Out] SpriteBatchItemList result)
		{
			int lastBatchListId = this._lastBatchListId;
			SpriteBatchItemList lastBatchList = this._lastBatchList;
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00067B64 File Offset: 0x00065D64
		public void CreateBatchItemList([Out] SpriteBatchItemList item)
		{
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00067B78 File Offset: 0x00065D78
		public void DrawImmediateBatch(Effect effect)
		{
			int batchItemCount = this._batchItemCount;
			if (batchItemCount != 0)
			{
				if (batchItemCount == 0)
				{
				}
				int num = 1;
				if (num == 0)
				{
				}
				int value = num.m_value;
				if (!true)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
					if (num2 == 0)
					{
					}
					bool gameMenu = Main.gameMenu;
					if (num2 == 0)
					{
					}
					int myPlayer = Main.myPlayer;
					if (num2 == 0)
					{
					}
					int screenHeight = Main.screenHeight;
				}
				EffectPass overloadedEffectPass = this._batchItemList.OverloadedEffectPass;
				SpriteBatcher.VertexData[] array = this.vertexData;
				string name = overloadedEffectPass.Name;
				if (array != null)
				{
					return;
				}
				int vertexOffset = this._vertexOffset;
				int indexOffset = this._indexOffset;
				int vertexOffset2 = this._vertexOffset;
				int batchIndex = overloadedEffectPass.BatchIndex;
				this._vertexOffset.m_value = batchIndex;
				this._vertexOffset.m_value = batchIndex;
				this._vertexOffset.m_value = batchIndex;
				int vertexOffset3 = this._vertexOffset;
				GraphicsDevice device = this._device;
				this._vertexOffset = vertexOffset3;
				Texture2D[] textures = device.Textures;
				if (name != null && name == null)
				{
					throw new ArrayTypeMismatchException();
				}
				textures.<Name>k__BackingField = name;
				Effect effect2 = overloadedEffectPass._effect;
				if (this._vertexOffset == 0)
				{
				}
				int num3 = 1;
				if (num3 == 0)
				{
				}
				int value2 = num3.m_value;
				if (!true)
				{
				}
				int num4 = 1;
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
					if (num4 == 0)
					{
					}
					bool gameMenu2 = Main.gameMenu;
					if (num4 == 0)
					{
					}
					int myPlayer2 = Main.myPlayer;
					if (num4 == 0)
					{
					}
					int screenHeight2 = Main.screenHeight;
				}
				int vertexOffset4 = this._vertexOffset;
				int materialOffset = this._materialOffset;
				Dictionary<int, SpriteBatchItemList> activeBatchLists = this._activeBatchLists;
				this._lastBatchListId = num4;
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00067CF4 File Offset: 0x00065EF4
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void FlushBatches()
		{
			if (this._vertexOffset == 0)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			if (!true)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				bool gameMenu = Main.gameMenu;
				if (num2 == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num2 == 0)
				{
				}
				int screenHeight = Main.screenHeight;
			}
			int vertexOffset = this._vertexOffset;
			int materialOffset = this._materialOffset;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00067D58 File Offset: 0x00065F58
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void DrawBatch(SpriteSortMode sortMode, Effect effect, bool overloadTranform, bool deffered, [Optional] SpriteBatchItem overrideFirstItem)
		{
			string name;
			for (;;)
			{
				int batchItemCount = this._batchItemCount;
				if (batchItemCount == 0)
				{
					return;
				}
				if (batchItemCount == 0)
				{
				}
				int num = 1;
				if (num == 0)
				{
				}
				int value = num.m_value;
				if (!true)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
					if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
					{
					}
					bool gameMenu = Main.gameMenu;
					if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
					{
					}
					int myPlayer = Main.myPlayer;
					if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
					{
					}
					int screenHeight = Main.screenHeight;
				}
				int batchItemCount2 = this._batchItemCount;
				SpriteBatchItem[] batchItemList = this._batchItemList;
				EffectPass overloadedEffectPass;
				if (overrideFirstItem == null)
				{
					overloadedEffectPass = this._batchItemList.OverloadedEffectPass;
				}
				SpriteBatcher.VertexData[] array = this.vertexData;
				int indexOffset = this._indexOffset;
				if (array != null)
				{
					if (overloadedEffectPass == null)
					{
						break;
					}
				}
				else if (overloadedEffectPass == null)
				{
					goto IL_018A;
				}
				int vertexOffset = this._vertexOffset;
				int vertexOffset2 = this._vertexOffset;
				int materialOffset = this._materialOffset;
				int passIndex = overloadedEffectPass.PassIndex;
				int indexOffset2 = this._indexOffset;
				int passIndex2 = overloadedEffectPass.PassIndex;
				GraphicsDevice device = this._device;
				name = overloadedEffectPass.Name;
				Effect effect2 = overloadedEffectPass._effect;
				Texture2D[] textures = device.Textures;
				if (name != null && name == null)
				{
					goto IL_017B;
				}
				textures.<Name>k__BackingField = name;
				int batchIndex = overloadedEffectPass.BatchIndex;
				this._vertexOffset.m_value = batchIndex;
				this._vertexOffset.m_value = batchIndex;
				this._vertexOffset.m_value = batchIndex;
				int vertexOffset3 = this._vertexOffset;
				int materialOffset2 = this._materialOffset;
				this._vertexOffset = vertexOffset3;
				this._materialOffset = materialOffset2;
				if (overloadedEffectPass._material == null)
				{
					goto Block_6;
				}
			}
			return;
			Block_6:
			Texture2D[] textures2 = this._device.Textures;
			if (name == null || name != null)
			{
				textures2.<Name>k__BackingField = name;
				goto IL_018A;
			}
			IL_017B:
			throw new ArrayTypeMismatchException();
			IL_018A:
			Dictionary<int, SpriteBatchItemList> activeBatchLists = this._activeBatchLists;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00067EF8 File Offset: 0x000660F8
		private void RenderVertexArray(Effect effect, Texture2D texture, EffectPass overloadEffectPass, Vector3 position, Vector3 scale)
		{
			if (overloadEffectPass != null)
			{
				GraphicsDevice device = this._device;
				List<Vector3> positions = this._positions;
				List<Vector2> uvs = this._uvs;
				List<Color32> colours = this._colours;
				List<int> indices = this._indices;
				return;
			}
			EffectPassCollection.Enumerator enumerator;
			bool flag = enumerator.MoveNext();
			Texture2D[] textures = this._device.Textures;
			if (texture == null || texture != null)
			{
				textures.<Name>k__BackingField = texture;
				GraphicsDevice device2 = this._device;
				List<Vector3> positions2 = this._positions;
				List<Vector2> uvs2 = this._uvs;
				List<Color32> colours2 = this._colours;
				List<int> indices2 = this._indices;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000021DB File Offset: 0x000003DB
		private void AddSubMesh(Effect effect, Texture2D texture, EffectPass overloadEffectPass)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000021DB File Offset: 0x000003DB
		private void RenderVertexArrayWithSubMeshes(int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0006802C File Offset: 0x0006622C
		private void RenderVertexArray2(Effect effect, Texture2D texture, EffectPass overloadEffectPass, int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
			if (overloadEffectPass != null)
			{
				GraphicsDevice device = this._device;
				SpriteBatcher.VertexData[] array = this.vertexData;
				short[] array2 = this.indexData;
				return;
			}
			EffectPassCollection.Enumerator enumerator;
			bool flag = enumerator.MoveNext();
			Texture2D[] textures = this._device.Textures;
			if (texture == null || texture != null)
			{
				textures.<Name>k__BackingField = texture;
				GraphicsDevice device2 = this._device;
				SpriteBatcher.VertexData[] array3 = this.vertexData;
				short[] array4 = this.indexData;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00068128 File Offset: 0x00066328
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteBatcher()
		{
		}

		// Token: 0x0400266D RID: 9837
		private const int InitialBatchSize = 256;

		// Token: 0x0400266E RID: 9838
		private const int MaxBatchSize = 5461;

		// Token: 0x0400266F RID: 9839
		private const int InitialVertexArraySize = 256;

		// Token: 0x04002670 RID: 9840
		public SpriteBatchItem[] _batchItemList;

		// Token: 0x04002671 RID: 9841
		public int _batchItemCount;

		// Token: 0x04002672 RID: 9842
		public int _lastBatchListId;

		// Token: 0x04002673 RID: 9843
		public SpriteBatchItemList _lastBatchList;

		// Token: 0x04002674 RID: 9844
		public Dictionary<int, SpriteBatchItemList> _activeBatchLists;

		// Token: 0x04002675 RID: 9845
		private SpriteBatchItemList[] _batchItemListList;

		// Token: 0x04002676 RID: 9846
		private int _batchItemListCount;

		// Token: 0x04002677 RID: 9847
		private readonly GraphicsDevice _device;

		// Token: 0x04002678 RID: 9848
		private const int maxQuadCount = 8192;

		// Token: 0x04002679 RID: 9849
		private const int maxVerts = 32768;

		// Token: 0x0400267A RID: 9850
		private const int maxIndices = 49152;

		// Token: 0x0400267B RID: 9851
		private int _vertexOffset;

		// Token: 0x0400267C RID: 9852
		private int _indexOffset;

		// Token: 0x0400267D RID: 9853
		private int _materialOffset;

		// Token: 0x0400267E RID: 9854
		private SpriteBatcher.VertexData[] vertexData;

		// Token: 0x0400267F RID: 9855
		private short[] indexData;

		// Token: 0x04002680 RID: 9856
		private List<Vector3> _positions;

		// Token: 0x04002681 RID: 9857
		private List<Vector2> _uvs;

		// Token: 0x04002682 RID: 9858
		private List<Vector4> _uv2s;

		// Token: 0x04002683 RID: 9859
		private List<Color32> _colours;

		// Token: 0x04002684 RID: 9860
		private List<int> _indices;

		// Token: 0x04002685 RID: 9861
		private List<Material> _immediateMaterials;

		// Token: 0x04002686 RID: 9862
		private List<int> _immediateMaterialsOffsets;

		// Token: 0x04002687 RID: 9863
		private List<SubMeshDescriptor> _submeshList;

		// Token: 0x04002688 RID: 9864
		private List<Material> _submeshListMaterials;

		// Token: 0x04002689 RID: 9865
		private static VertexAttributeDescriptor[] vertexDescription;

		// Token: 0x0200038E RID: 910
		public struct VertexData
		{
			// Token: 0x0400268A RID: 9866
			public Vector2 Position;

			// Token: 0x0400268B RID: 9867
			public Color32 Color;

			// Token: 0x0400268C RID: 9868
			public Vector2 TextureCoordinate;
		}
	}
}
