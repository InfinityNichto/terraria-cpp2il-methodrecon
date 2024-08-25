using System;
using System.Runtime.InteropServices;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000B3A RID: 2874
	public class AssetLoader : IAssetLoader
	{
		// Token: 0x060053D1 RID: 21457 RVA: 0x00284FD8 File Offset: 0x002831D8
		public AssetLoader(AssetReaderCollection readers)
		{
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x00284FEC File Offset: 0x002831EC
		public bool TryLoad<T>(string assetName, IContentSource source, [Out] T resultAsset) where T : class
		{
			/*
An exception occurred when decompiling this method (060053D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Content.AssetLoader::TryLoad<T>(System.String,ReLogic.Content.Sources.IContentSource,T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AssetReaderCollection(var_0_06, ldfld:AssetReaderCollection(AssetLoader::_readers, ldloc:AssetLoader(this)))
	stloc:AssetReaderCollection(var_2_0D, ldfld:AssetReaderCollection(AssetLoader::_readers, ldloc:AssetLoader(this)))
	stloc:int64(var_3_14, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x04008CF6 RID: 36086
		private readonly AssetReaderCollection _readers;
	}
}
