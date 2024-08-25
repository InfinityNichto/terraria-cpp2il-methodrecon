using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x0200074C RID: 1868
	public class ShaderData
	{
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x00239CFC File Offset: 0x00237EFC
		public Effect Shader
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003DA4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Effect Terraria.Graphics.Shaders.ShaderData::get_Shader()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_1_10, ldfld:!T[exp:!0](Ref`1::Value, ldloc:class Terraria.Ref`1<class Microsoft.Xna.Framework.Graphics.Effect>[exp:Ref`1](var_0_06)))
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
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00239D1C File Offset: 0x00237F1C
		public ShaderData(Ref<Effect> shader, string passName)
		{
			this._shader = shader;
			this._passName = passName;
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00239D40 File Offset: 0x00237F40
		public virtual void Apply(Entity entity, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00239D50 File Offset: 0x00237F50
		public virtual void Apply()
		{
			if (this._effectPass == null)
			{
				Ref<Effect> shader = this._shader;
				string passName = this._passName;
				!0 value = shader.Value;
				EffectPass effectPass;
				this._effectPass = effectPass;
			}
		}

		// Token: 0x04007C67 RID: 31847
		private readonly Ref<Effect> _shader;

		// Token: 0x04007C68 RID: 31848
		protected string _passName;

		// Token: 0x04007C69 RID: 31849
		public EffectPass _effectPass;
	}
}
