using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics
{
	// Token: 0x02000740 RID: 1856
	public class VertexStrip
	{
		// Token: 0x06003D36 RID: 15670 RVA: 0x00238A7C File Offset: 0x00236C7C
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void PrepareStrip(Vector2Array_10 positions, FloatArray_10 rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, [Optional] Vector2 offsetForAllPositions, [Optional] int? expectedVertexPairsAmount, bool includeBacksides = false)
		{
			int length = positions.Length;
			VertexStrip.CustomVertexInfo[] vertices = this._vertices;
			long num = 0L;
			Vector2 vector = positions[(int)num];
			Vector2 vector2 = positions[(int)num];
			float num2 = rotations[(int)num];
			float num3 = MathHelper.WrapAngle(num2);
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x00238ACC File Offset: 0x00236CCC
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void PrepareStrip(Vector2[] positions, float[] rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, [Optional] Vector2 offsetForAllPositions, [Optional] int? expectedVertexPairsAmount, bool includeBacksides = false)
		{
			VertexStrip.CustomVertexInfo[] vertices = this._vertices;
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			if (num == 0)
			{
			}
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x000021DB File Offset: 0x000003DB
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void PrepareStripWithProceduralPadding(Vector2Array_10 positions, FloatArray_10 rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, [Optional] Vector2 offsetForAllPositions, bool includeBacksides = false)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x000021DB File Offset: 0x000003DB
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void PrepareStripWithProceduralPadding(Vector2[] positions, float[] rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, [Optional] Vector2 offsetForAllPositions, bool includeBacksides = false)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x00238B08 File Offset: 0x00236D08
		private void PrepareIndices(int vertexPaidsAdded)
		{
			short[] indices = this._indices;
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x00238B20 File Offset: 0x00236D20
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private void AddVertex(VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, Vector2 pos, float rot, int indexOnVertexArray, float progressOnStrip)
		{
			VertexStrip.CustomVertexInfo[] vertices = this._vertices;
			IntPtr invoke_impl = colorFunction.invoke_impl;
			IntPtr method_code = colorFunction.method_code;
			IntPtr method = colorFunction.method;
			IntPtr invoke_impl2 = widthFunction.invoke_impl;
			IntPtr method_code2 = widthFunction.method_code;
			IntPtr method2 = widthFunction.method;
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x00238B6C File Offset: 0x00236D6C
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void DrawTrail(bool includeBacksides)
		{
			if (this._vertexAmountCurrentlyMaintained == 0)
			{
			}
			GraphicsDevice graphicsDevice;
			Texture2D[] textures = graphicsDevice.Textures;
			if (textures.<Name>k__BackingField != null && textures != null)
			{
				return;
			}
			if (textures == null)
			{
			}
			int indicesAmountCurrentlyMaintained = this._indicesAmountCurrentlyMaintained;
			short[] indices = this._indices;
			VertexStrip.CustomVertexInfo[] vertices = this._vertices;
			SpriteBatchItem spriteBatchItem;
			int batchKey = spriteBatchItem.BatchKey;
			int batchKey2 = spriteBatchItem.BatchKey;
			SpriteBatchItem spriteBatchItem2;
			spriteBatchItem2.vertexTL.TextureCoordinate.y = (float)batchKey2;
			int batchKey3 = spriteBatchItem.BatchKey;
			spriteBatchItem2.vertexTR.TextureCoordinate.y = (float)batchKey3;
			int batchKey4 = spriteBatchItem.BatchKey;
			spriteBatchItem2.vertexBR.TextureCoordinate.y = (float)batchKey4;
			int batchKey5 = spriteBatchItem.BatchKey;
			spriteBatchItem2.vertexBL.TextureCoordinate.y = (float)batchKey5;
			int indicesAmountCurrentlyMaintained2 = this._indicesAmountCurrentlyMaintained;
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x00238C34 File Offset: 0x00236E34
		public VertexStrip()
		{
		}

		// Token: 0x04007C1F RID: 31775
		private VertexStrip.CustomVertexInfo[] _vertices;

		// Token: 0x04007C20 RID: 31776
		private int _vertexAmountCurrentlyMaintained;

		// Token: 0x04007C21 RID: 31777
		private short[] _indices;

		// Token: 0x04007C22 RID: 31778
		private int _indicesAmountCurrentlyMaintained;

		// Token: 0x04007C23 RID: 31779
		private List<Vector2> _temporaryPositionsCache;

		// Token: 0x04007C24 RID: 31780
		private List<float> _temporaryRotationsCache;

		// Token: 0x02000741 RID: 1857
		public sealed class StripColorFunction : MulticastDelegate
		{
			// Token: 0x06003D3E RID: 15678 RVA: 0x00238C48 File Offset: 0x00236E48
			public StripColorFunction(object @object, IntPtr method)
			{
				this.method_ptr = this;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003D3F RID: 15679 RVA: 0x00238C9C File Offset: 0x00236E9C
			public void Invoke(float progressOnStrip, [Out] Color col)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003D40 RID: 15680 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(float progressOnStrip, [Out] Color col, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003D41 RID: 15681 RVA: 0x00238CC0 File Offset: 0x00236EC0
			public void EndInvoke([Out] Color col, IAsyncResult result)
			{
			}
		}

		// Token: 0x02000742 RID: 1858
		public sealed class StripHalfWidthFunction : MulticastDelegate
		{
			// Token: 0x06003D42 RID: 15682 RVA: 0x00238CD0 File Offset: 0x00236ED0
			public StripHalfWidthFunction(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003D43 RID: 15683 RVA: 0x00238D1C File Offset: 0x00236F1C
			public float Invoke(float progressOnStrip)
			{
				/*
An exception occurred when decompiling this method (06003D43)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Graphics.VertexStrip/StripHalfWidthFunction::Invoke(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:StripHalfWidthFunction[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:StripHalfWidthFunction[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:StripHalfWidthFunction[exp:Delegate](this)))
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

			// Token: 0x06003D44 RID: 15684 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(float progressOnStrip, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003D45 RID: 15685 RVA: 0x000021DB File Offset: 0x000003DB
			public float EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000743 RID: 1859
		private struct CustomVertexInfo
		{
			// Token: 0x06003D46 RID: 15686 RVA: 0x00238D40 File Offset: 0x00236F40
			public CustomVertexInfo(Vector2 position, Color color, Vector3 texCoord)
			{
				this.Color = position;
			}

			// Token: 0x04007C25 RID: 31781
			public Vector2 Position;

			// Token: 0x04007C26 RID: 31782
			public Color Color;

			// Token: 0x04007C27 RID: 31783
			public Vector3 TexCoord;
		}
	}
}
