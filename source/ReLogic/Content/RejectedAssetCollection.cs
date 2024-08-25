using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace ReLogic.Content
{
	// Token: 0x02000B3D RID: 2877
	public class RejectedAssetCollection
	{
		// Token: 0x060053D5 RID: 21461 RVA: 0x00285010 File Offset: 0x00283210
		public void Reject(string assetPath, IRejectionReason reason)
		{
			Dictionary<string, IRejectionReason> rejectedAssetsAndReasons = this._rejectedAssetsAndReasons;
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x00285024 File Offset: 0x00283224
		public bool IsRejected(string assetPath)
		{
			/*
An exception occurred when decompiling this method (060053D6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Content.RejectedAssetCollection::IsRejected(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class ReLogic.Content.IRejectionReason>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class ReLogic.Content.IRejectionReason>(RejectedAssetCollection::_rejectedAssetsAndReasons, ldloc:RejectedAssetCollection(this)))
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

		// Token: 0x060053D7 RID: 21463 RVA: 0x00285038 File Offset: 0x00283238
		public void Clear()
		{
			Dictionary<string, IRejectionReason> rejectedAssetsAndReasons = this._rejectedAssetsAndReasons;
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x000021DB File Offset: 0x000003DB
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x0028504C File Offset: 0x0028324C
		public RejectedAssetCollection()
		{
		}

		// Token: 0x04008CF7 RID: 36087
		private Dictionary<string, IRejectionReason> _rejectedAssetsAndReasons;
	}
}
