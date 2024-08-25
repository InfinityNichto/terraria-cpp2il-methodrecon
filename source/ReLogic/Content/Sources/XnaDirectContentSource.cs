using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000B50 RID: 2896
	public class XnaDirectContentSource : IContentSource
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x002859D4 File Offset: 0x00283BD4
		// (set) Token: 0x0600543E RID: 21566 RVA: 0x002859E8 File Offset: 0x00283BE8
		public IContentValidator ContentValidator
		{
			[CompilerGenerated]
			get
			{
				return this.<ContentValidator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ContentValidator>k__BackingField = value;
			}
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x002859FC File Offset: 0x00283BFC
		public XnaDirectContentSource(string rootDirectory)
		{
			string text;
			this._rootDirectory = text;
			this.BuildFileMap();
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x00285A1C File Offset: 0x00283C1C
		private void BuildFileMap()
		{
			HashSet<string> files = this._files;
			string rootDirectory = this._rootDirectory;
			HashSet<string> files2 = this._files;
			string[] array;
			string text = array.ToLower();
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x00285A4C File Offset: 0x00283C4C
		public bool HasAsset(string assetName)
		{
			/*
An exception occurred when decompiling this method (06005441)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Content.Sources.XnaDirectContentSource::HasAsset(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:string(var_1_1B, call:string(string::Concat, call:string(Path::Combine, ldloc:string(var_0_06), ldloc:string(assetName)), ldstr:string(".xnb")))
	stloc:bool(var_2_28, call:bool(RejectedAssetCollection::IsRejected, ldfld:RejectedAssetCollection(XnaDirectContentSource::_rejections, ldloc:XnaDirectContentSource(this)), ldloc:string(assetName)))
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<string>(var_4_31, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<string>(XnaDirectContentSource::_files, ldloc:XnaDirectContentSource(this)))
	stloc:string(var_5_39, call:string(string::ToLower, ldloc:string(var_1_1B)))
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

		// Token: 0x06005442 RID: 21570 RVA: 0x00285A94 File Offset: 0x00283C94
		public string GetExtension(string assetName)
		{
			return ".xnb";
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x00285AA8 File Offset: 0x00283CA8
		public Stream OpenStream(string assetName)
		{
			/*
An exception occurred when decompiling this method (06005443)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream ReLogic.Content.Sources.XnaDirectContentSource::OpenStream(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:string(var_2_1D, call:string(string::Concat, call:string(Path::Combine, ldloc:string(var_1_08), ldloc:string(assetName)), ldstr:string(".xnb")))
	stloc:FileStream(var_4_26, call:FileStream(File::OpenRead, ldloc:string(var_2_1D)))
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

		// Token: 0x06005444 RID: 21572 RVA: 0x00285AE0 File Offset: 0x00283CE0
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
			this._rejections.Reject(assetName, reason);
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x00285AFC File Offset: 0x00283CFC
		public void ClearRejections()
		{
			this._rejections.Clear();
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x00285B14 File Offset: 0x00283D14
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return this._rejections.TryGetRejections(rejectionReasons);
		}

		// Token: 0x04008D1C RID: 36124
		private readonly string _rootDirectory;

		// Token: 0x04008D1D RID: 36125
		private readonly HashSet<string> _files;

		// Token: 0x04008D1E RID: 36126
		[CompilerGenerated]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x04008D1F RID: 36127
		private readonly RejectedAssetCollection _rejections;
	}
}
