using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020007B6 RID: 1974
	public class ChumBucketProjectileHelper
	{
		// Token: 0x06004056 RID: 16470 RVA: 0x00242FE0 File Offset: 0x002411E0
		public void OnPreUpdateAllProjectiles()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x00242FF0 File Offset: 0x002411F0
		public void AddChumLocation(Vector2 spot)
		{
			if (!true)
			{
			}
			Dictionary<Point, int> chumCountsPendingForThisFrame = this._chumCountsPendingForThisFrame;
			Dictionary<Point, int> chumCountsPendingForThisFrame2 = this._chumCountsPendingForThisFrame;
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x00243010 File Offset: 0x00241210
		public int GetChumsInLocation(Point tileCoords)
		{
			/*
An exception occurred when decompiling this method (06004058)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.ChumBucketProjectileHelper::GetChumsInLocation(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Microsoft.Xna.Framework.Point, int32>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Microsoft.Xna.Framework.Point, int32>(ChumBucketProjectileHelper::_chumCountsFromLastFrame, ldloc:ChumBucketProjectileHelper(this)))
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

		// Token: 0x06004059 RID: 16473 RVA: 0x00243024 File Offset: 0x00241224
		public ChumBucketProjectileHelper()
		{
		}

		// Token: 0x04007E1C RID: 32284
		private Dictionary<Point, int> _chumCountsPendingForThisFrame;

		// Token: 0x04007E1D RID: 32285
		private Dictionary<Point, int> _chumCountsFromLastFrame;
	}
}
