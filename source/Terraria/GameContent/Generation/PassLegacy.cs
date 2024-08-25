using System;
using System.Collections.Generic;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008D6 RID: 2262
	public class PassLegacy : GenPass
	{
		// Token: 0x0600459F RID: 17823 RVA: 0x00255168 File Offset: 0x00253368
		public PassLegacy(string name, WorldGenLegacyMethod method)
		{
			if (!true)
			{
			}
			float weight = PassLegacy.GetWeight(name);
			base..ctor(name, (double)weight);
			this._method = method;
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x00255190 File Offset: 0x00253390
		public PassLegacy(string name, WorldGenLegacyMethod method, double weight)
			: base(name, weight)
		{
			this._method = method;
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x002551AC File Offset: 0x002533AC
		private static float GetWeight(string name)
		{
			/*
An exception occurred when decompiling this method (060045A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Generation.PassLegacy::GetWeight(System.String)

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

		// Token: 0x060045A2 RID: 17826 RVA: 0x002551BC File Offset: 0x002533BC
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
			WorldGenLegacyMethod method = this._method;
			IntPtr invoke_impl = method.invoke_impl;
			IntPtr method_code = method.method_code;
			IntPtr method2 = method.method;
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x002551E8 File Offset: 0x002533E8
		// Note: this type is marked as 'beforefieldinit'.
		static PassLegacy()
		{
		}

		// Token: 0x04008208 RID: 33288
		private static readonly Dictionary<string, float> _weightMap_135;

		// Token: 0x04008209 RID: 33289
		private static readonly Dictionary<string, float> _weightMap;

		// Token: 0x0400820A RID: 33290
		private readonly WorldGenLegacyMethod _method;
	}
}
