using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000B4D RID: 2893
	public class FileSystemContentSource : IContentSource
	{
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600541F RID: 21535 RVA: 0x00285698 File Offset: 0x00283898
		// (set) Token: 0x06005420 RID: 21536 RVA: 0x002856AC File Offset: 0x002838AC
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

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06005421 RID: 21537 RVA: 0x002856C0 File Offset: 0x002838C0
		public int FileCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005421)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ReLogic.Content.Sources.FileSystemContentSource::get_FileCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, string>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, string>(FileSystemContentSource::_nameToAbsolutePath, ldloc:FileSystemContentSource(this)))
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

		// Token: 0x06005422 RID: 21538 RVA: 0x002856D4 File Offset: 0x002838D4
		public FileSystemContentSource(string basePath)
		{
			if (!true)
			{
			}
			string fullPath = Path.GetFullPath(basePath);
			this._basePath = fullPath;
			bool flag = fullPath.EndsWith("/");
			bool flag2 = this._basePath.EndsWith("\\");
			string basePath2 = this._basePath;
			if ("\\" == null)
			{
			}
			string text2;
			string text = basePath2 + text2;
			this._basePath = text;
			this.BuildNameToAbsolutePathDictionary();
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x0028573C File Offset: 0x0028393C
		public bool HasAsset(string assetName)
		{
			/*
An exception occurred when decompiling this method (06005423)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Content.Sources.FileSystemContentSource::HasAsset(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0C, call:bool(RejectedAssetCollection::IsRejected, ldfld:RejectedAssetCollection(FileSystemContentSource::_rejections, ldloc:FileSystemContentSource(this)), ldloc:string(assetName)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, string>(var_2_15, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, string>(FileSystemContentSource::_nameToAbsolutePath, ldloc:FileSystemContentSource(this)))
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

		// Token: 0x06005424 RID: 21540 RVA: 0x00285760 File Offset: 0x00283960
		public string GetExtension(string assetName)
		{
			Dictionary<string, string> nameToAbsolutePath = this._nameToAbsolutePath;
			return Path.GetExtension(assetName);
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0028577C File Offset: 0x0028397C
		public Stream OpenStream(string assetName)
		{
			/*
An exception occurred when decompiling this method (06005425)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream ReLogic.Content.Sources.FileSystemContentSource::OpenStream(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, string>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, string>(FileSystemContentSource::_nameToAbsolutePath, ldloc:FileSystemContentSource(this)))
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

		// Token: 0x06005426 RID: 21542 RVA: 0x00285794 File Offset: 0x00283994
		private void BuildNameToAbsolutePathDictionary()
		{
			bool flag = Directory.Exists(this._basePath);
			string basePath = this._basePath;
			int num = 1;
			if ("*" == null)
			{
			}
			string text;
			string extension = Path.GetExtension(text);
			int stringLength = this._basePath._stringLength;
			int stringLength2 = text._stringLength;
			string text2 = text.Substring(stringLength, num);
			int num2 = 92;
			int num3 = 47;
			string text3 = text2.Replace((char)num2, (char)num3);
			Dictionary<string, string> nameToAbsolutePath = this._nameToAbsolutePath;
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x00285808 File Offset: 0x00283A08
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
			this._rejections.Reject(assetName, reason);
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x00285824 File Offset: 0x00283A24
		public void ClearRejections()
		{
			this._rejections.Clear();
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x0028583C File Offset: 0x00283A3C
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return this._rejections.TryGetRejections(rejectionReasons);
		}

		// Token: 0x04008D14 RID: 36116
		[CompilerGenerated]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x04008D15 RID: 36117
		private readonly string _basePath;

		// Token: 0x04008D16 RID: 36118
		private readonly Dictionary<string, string> _nameToAbsolutePath;

		// Token: 0x04008D17 RID: 36119
		private readonly RejectedAssetCollection _rejections;
	}
}
