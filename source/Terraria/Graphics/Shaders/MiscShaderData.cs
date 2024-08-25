using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x0200074A RID: 1866
	public class MiscShaderData : ShaderData
	{
		// Token: 0x06003D77 RID: 15735 RVA: 0x002394C4 File Offset: 0x002376C4
		public MiscShaderData(Ref<Effect> shader, string passName)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this._uSecondaryColor.Z = (float)1;
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			this._shader = shader;
			this._passName = passName;
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00239504 File Offset: 0x00237704
		public override void Apply(Entity entity, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00239514 File Offset: 0x00237714
		public virtual void Apply([Optional] DrawData? drawData)
		{
			!0 value = this._shader.Value;
			float x = this._uColor.X;
			float y = this._uColor.Y;
			float z = this._uColor.Z;
			!0 value2 = this._shader.Value;
			float uSaturation = this._uSaturation;
			!0 value3 = this._shader.Value;
			float x2 = this._uSecondaryColor.X;
			float y2 = this._uSecondaryColor.Y;
			float z2 = this._uSecondaryColor.Z;
			!0 value4 = this._shader.Value;
			!0 value5 = this._shader.Value;
			float uOpacity = this._uOpacity;
			!0 value6 = this._shader.Value;
			float x3 = this._shaderSpecificData.X;
			float y3 = this._shaderSpecificData.Y;
			float z3 = this._shaderSpecificData.Z;
			float w = this._shaderSpecificData.W;
			!0 value7 = this._shader.Value;
			!0 value8 = this._shader.Value;
			Vector2 screenPosition = Main.screenPosition;
			!0 value9 = this._shader.Value;
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x0023976C File Offset: 0x0023796C
		public MiscShaderData UseColor(float r, float g, float b)
		{
			return this;
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x0023977C File Offset: 0x0023797C
		public MiscShaderData UseColor(Color color)
		{
			return this;
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x0023978C File Offset: 0x0023798C
		public MiscShaderData UseColor(Vector3 color)
		{
			return this;
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x0023979C File Offset: 0x0023799C
		public MiscShaderData UseSamplerState(SamplerState state)
		{
			this._customSamplerState = state;
			return this;
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x002397B4 File Offset: 0x002379B4
		public MiscShaderData UseImage0(string path)
		{
			/*
An exception occurred when decompiling this method (06003D7E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Shaders.MiscShaderData Terraria.Graphics.Shaders.MiscShaderData::UseImage0(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x002397C4 File Offset: 0x002379C4
		public MiscShaderData UseImage0(Asset<Texture2D> texture)
		{
			this._uImage0 = texture;
			return this;
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x002397DC File Offset: 0x002379DC
		public MiscShaderData UseImage1(string path)
		{
			if (!true)
			{
			}
			return this;
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x002397F0 File Offset: 0x002379F0
		public MiscShaderData UseImage1(Asset<Texture2D> texture)
		{
			this._uImage1 = texture;
			return this;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00239808 File Offset: 0x00237A08
		public MiscShaderData UseImage2(string path)
		{
			if (!true)
			{
			}
			return this;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x0023981C File Offset: 0x00237A1C
		public MiscShaderData UseImage2(Asset<Texture2D> texture)
		{
			this._uImage2 = texture;
			return this;
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00239834 File Offset: 0x00237A34
		private static bool IsPowerOfTwo(int n)
		{
			/*
An exception occurred when decompiling this method (06003D84)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Graphics.Shaders.MiscShaderData::IsPowerOfTwo(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00239844 File Offset: 0x00237A44
		public MiscShaderData UseOpacity(float alpha)
		{
			return this;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00239854 File Offset: 0x00237A54
		public MiscShaderData UseSecondaryColor(float r, float g, float b)
		{
			return this;
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x00239864 File Offset: 0x00237A64
		public MiscShaderData UseSecondaryColor(Color color)
		{
			return this;
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00239874 File Offset: 0x00237A74
		public MiscShaderData UseSecondaryColor(Vector3 color)
		{
			return this;
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x00239884 File Offset: 0x00237A84
		public MiscShaderData UseProjectionMatrix(bool doUse)
		{
			return this;
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00239894 File Offset: 0x00237A94
		public MiscShaderData UseSaturation(float saturation)
		{
			return this;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x002398A4 File Offset: 0x00237AA4
		public virtual MiscShaderData GetSecondaryShader(Entity entity)
		{
			return this;
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x002398B4 File Offset: 0x00237AB4
		public MiscShaderData UseShaderSpecificData(Vector4 specificData)
		{
			return this;
		}

		// Token: 0x04007C50 RID: 31824
		private Vector3 _uColor;

		// Token: 0x04007C51 RID: 31825
		private Vector3 _uSecondaryColor;

		// Token: 0x04007C52 RID: 31826
		private float _uSaturation;

		// Token: 0x04007C53 RID: 31827
		private float _uOpacity;

		// Token: 0x04007C54 RID: 31828
		private Asset<Texture2D> _uImage0;

		// Token: 0x04007C55 RID: 31829
		private Asset<Texture2D> _uImage1;

		// Token: 0x04007C56 RID: 31830
		private Asset<Texture2D> _uImage2;

		// Token: 0x04007C57 RID: 31831
		private bool _useProjectionMatrix;

		// Token: 0x04007C58 RID: 31832
		private Vector4 _shaderSpecificData;

		// Token: 0x04007C59 RID: 31833
		private SamplerState _customSamplerState;
	}
}
