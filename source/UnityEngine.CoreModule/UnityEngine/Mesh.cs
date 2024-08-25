using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000048 RID: 72
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[RequiredByNativeCode]
	public sealed class Mesh : Object
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00002DE4 File Offset: 0x00000FE4
		[FreeFunction("MeshScripting::CreateMesh")]
		private static void Internal_Create([Writable] Mesh mono)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002DF8 File Offset: 0x00000FF8
		[RequiredByNativeCode]
		public Mesh()
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002E14 File Offset: 0x00001014
		[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = true, ThrowsException = true)]
		public void SetIndexBufferParams(int indexCount, IndexFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002E28 File Offset: 0x00001028
		[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002E3C File Offset: 0x0000103C
		[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = true, ThrowsException = true)]
		private void SetVertexBufferParamsFromArray(int vertexCount, params VertexAttributeDescriptor[] attributes)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002E50 File Offset: 0x00001050
		[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = true)]
		private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002E64 File Offset: 0x00001064
		[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = true)]
		private int[] GetIndicesImpl(int submesh, bool applyBaseVertex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002E78 File Offset: 0x00001078
		[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = true, ThrowsException = true)]
		private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002E8C File Offset: 0x0000108C
		[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = true)]
		private void PrintErrorCantAccessChannel(VertexAttribute ch)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002EA0 File Offset: 0x000010A0
		[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = true)]
		public bool HasVertexAttribute(VertexAttribute attr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002EB4 File Offset: 0x000010B4
		[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = true)]
		private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002EC8 File Offset: 0x000010C8
		[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = true)]
		private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002EDC File Offset: 0x000010DC
		[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = true)]
		private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002EF0 File Offset: 0x000010F0
		internal bool canAccess
		{
			[NativeMethod("CanAccessFromScript")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002F04 File Offset: 0x00001104
		public int vertexCount
		{
			[NativeMethod("GetVertexCount")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002F18 File Offset: 0x00001118
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002F2C File Offset: 0x0000112C
		public int subMeshCount
		{
			[NativeMethod(Name = "GetSubMeshCount")]
			get
			{
				throw new MissingMethodException();
			}
			[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = true)]
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002F40 File Offset: 0x00001140
		[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = true, ThrowsException = true)]
		public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000029 RID: 41
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002F54 File Offset: 0x00001154
		public Bounds bounds
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002F68 File Offset: 0x00001168
		[NativeMethod("Clear")]
		private void ClearImpl(bool keepVertexLayout)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002F7C File Offset: 0x0000117C
		[NativeMethod("RecalculateBounds")]
		private void RecalculateBoundsImpl(MeshUpdateFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002F90 File Offset: 0x00001190
		[NativeMethod("MarkDynamic")]
		private void MarkDynamicImpl()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002FA4 File Offset: 0x000011A4
		[NativeMethod("UploadMeshData")]
		private void UploadMeshDataImpl(bool markNoLongerReadable)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000021B3 File Offset: 0x000003B3
		internal static VertexAttribute GetUVChannel(int uvIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002FB8 File Offset: 0x000011B8
		internal static int DefaultDimensionForChannel(VertexAttribute channel)
		{
			return 4;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002FCC File Offset: 0x000011CC
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute A_1, VertexAttributeFormat A_2, int A_3)
		{
			Array allocArrayFromChannelImpl;
			do
			{
				bool canAccess = this.canAccess;
				bool flag = this.HasVertexAttribute(A_1);
				allocArrayFromChannelImpl = this.GetAllocArrayFromChannelImpl(A_1, A_2, A_3);
				if (allocArrayFromChannelImpl == null)
				{
					return;
				}
			}
			while (allocArrayFromChannelImpl != null);
			throw new InvalidCastException();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003000 File Offset: 0x00001200
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel)
		{
			/*
An exception occurred when decompiling this method (060000C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T[] UnityEngine.Mesh::GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, call:int32(Mesh::DefaultDimensionForChannel, ldloc:VertexAttribute(channel)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003014 File Offset: 0x00001214
		private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000303C File Offset: 0x0000123C
		private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
			Array array = NoAllocHelpers.ExtractArrayFromList(values);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003054 File Offset: 0x00001254
		private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
			int num = Mesh.DefaultDimensionForChannel(channel);
			Array array = NoAllocHelpers.ExtractArrayFromList(values);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003070 File Offset: 0x00001270
		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003080 File Offset: 0x00001280
		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType)
		{
			bool canAccess = this.canAccess;
			bool flag = this.HasVertexAttribute(channel);
			Array array = NoAllocHelpers.ExtractArrayFromList(buffer);
			this.GetArrayFromChannelImpl(channel, channelType, dim, array);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000021B3 File Offset: 0x000003B3
		public Vector3[] vertices
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000021B3 File Offset: 0x000003B3
		public Vector3[] normals
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000021B3 File Offset: 0x000003B3
		public Vector4[] tangents
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000030B8 File Offset: 0x000012B8
		public Color32[] colors32
		{
			get
			{
				return this.GetAllocArrayFromChannel<Color32>(VertexAttribute.Color, VertexAttributeFormat.UNorm8, 4);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000030D0 File Offset: 0x000012D0
		public void SetVertices(List<Vector3> inVertices)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000030E0 File Offset: 0x000012E0
		[ExcludeFromDocs]
		public void SetVertices(List<Vector3> inVertices, int start, int length)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000030F0 File Offset: 0x000012F0
		public void SetVertices(List<Vector3> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003100 File Offset: 0x00001300
		public void SetNormals(List<Vector3> inNormals)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003110 File Offset: 0x00001310
		[ExcludeFromDocs]
		public void SetNormals(List<Vector3> inNormals, int start, int length)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003120 File Offset: 0x00001320
		public void SetNormals(List<Vector3> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003130 File Offset: 0x00001330
		public void SetTangents(List<Vector4> inTangents)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003140 File Offset: 0x00001340
		[ExcludeFromDocs]
		public void SetTangents(List<Vector4> inTangents, int start, int length)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003150 File Offset: 0x00001350
		public void SetTangents(List<Vector4> inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003160 File Offset: 0x00001360
		public void SetColors(List<Color32> inColors)
		{
			int num = NoAllocHelpers.SafeLength(inColors);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003174 File Offset: 0x00001374
		[ExcludeFromDocs]
		public void SetColors(List<Color32> inColors, int start, int length)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003184 File Offset: 0x00001384
		public void SetColors(List<Color32> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			this.SetListForChannel(VertexAttribute.Color, VertexAttributeFormat.UNorm8, 4, inColors, start, length, flags);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000031A0 File Offset: 0x000013A0
		private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags)
		{
			Debug.LogError("The uv index is invalid. Must be in the range 0 to 7.");
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000031C0 File Offset: 0x000013C0
		public void SetUVs(int channel, List<Vector2> uvs)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000031D0 File Offset: 0x000013D0
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000031E0 File Offset: 0x000013E0
		[ExcludeFromDocs]
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000031F0 File Offset: 0x000013F0
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003200 File Offset: 0x00001400
		[ExcludeFromDocs]
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003210 File Offset: 0x00001410
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003220 File Offset: 0x00001420
		private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
			if (uvs != null)
			{
				int vertexCount = this.vertexCount;
				VertexAttribute uvchannel = Mesh.GetUVChannel(uvIndex);
				return;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003240 File Offset: 0x00001440
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003250 File Offset: 0x00001450
		public void SetVertexBufferParams(int vertexCount, params VertexAttributeDescriptor[] attributes)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003264 File Offset: 0x00001464
		public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
		{
			bool canAccess = this.canAccess;
			bool flag = UnsafeUtility.IsArrayBlittable(data);
			this.InternalSetVertexBufferDataFromArray(stream, data, dataStart, meshBufferStart, count, flag ? 1 : 0, flags);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000032B8 File Offset: 0x000014B8
		private void PrintErrorCantAccessIndices()
		{
			string name = base.name;
			Debug.LogError(string.Format("Not allowed to access triangles/indices on mesh '{0}' (isReadable is false; Read/Write must be enabled in import settings)", name));
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000032DC File Offset: 0x000014DC
		private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000331C File Offset: 0x0000151C
		private bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			return this.CheckCanAccessSubmesh(submesh, true);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003334 File Offset: 0x00001534
		private bool CheckCanAccessSubmeshIndices(int submesh)
		{
			long num = 0L;
			return this.CheckCanAccessSubmesh(submesh, num != 0L);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000334C File Offset: 0x0000154C
		[ExcludeFromDocs]
		public int[] GetIndices(int submesh)
		{
			return this.GetIndices(submesh, true);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003364 File Offset: 0x00001564
		public int[] GetIndices(int submesh, [DefaultValue("true")] bool applyBaseVertex)
		{
			long num = 0L;
			bool flag = this.CheckCanAccessSubmesh(submesh, num != 0L);
			throw new MissingMethodException();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003384 File Offset: 0x00001584
		public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
		{
			bool canAccess = this.canAccess;
			bool flag = UnsafeUtility.IsArrayBlittable(data);
			this.InternalSetIndexBufferDataFromArray(data, dataStart, meshBufferStart, count, flag ? 1 : 0, flags);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000033C4 File Offset: 0x000015C4
		private void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
			if (length == 0)
			{
				return;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000033D8 File Offset: 0x000015D8
		private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
		{
			this.CheckIndicesArrayRange(trianglesArrayLength, start, length);
			throw new MissingMethodException();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000033F8 File Offset: 0x000015F8
		[ExcludeFromDocs]
		public void SetTriangles(List<int> triangles, int submesh)
		{
			long num = 0L;
			this.SetTriangles(triangles, submesh, true, (int)num);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003414 File Offset: 0x00001614
		[ExcludeFromDocs]
		public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds)
		{
			long num = 0L;
			this.SetTriangles(triangles, submesh, calculateBounds, (int)num);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003430 File Offset: 0x00001630
		public void SetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003440 File Offset: 0x00001640
		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			int num = 1;
			bool flag = this.CheckCanAccessSubmesh(submesh, num != 0);
			throw new MissingMethodException();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003460 File Offset: 0x00001660
		public void Clear([DefaultValue("true")] bool keepVertexLayout)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003474 File Offset: 0x00001674
		[ExcludeFromDocs]
		public void Clear()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003488 File Offset: 0x00001688
		[ExcludeFromDocs]
		public void RecalculateBounds()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003498 File Offset: 0x00001698
		public void RecalculateBounds([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000034CC File Offset: 0x000016CC
		public void MarkDynamic()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000034E8 File Offset: 0x000016E8
		public void UploadMeshData(bool markNoLongerReadable)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003504 File Offset: 0x00001704
		private void SetSubMesh_Injected(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003518 File Offset: 0x00001718
		private void set_bounds_Injected(Bounds value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x02000049 RID: 73
		[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
		[StaticAccessor("MeshDataBindings", StaticAccessorType.DoubleColon)]
		public struct MeshData
		{
			// Token: 0x04000210 RID: 528
			[NativeDisableUnsafePtrRestriction]
			internal IntPtr m_Ptr;
		}
	}
}
