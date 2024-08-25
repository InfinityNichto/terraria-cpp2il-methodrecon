using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000B51 RID: 2897
	public class ZipContentSource : IContentSource, IDisposable
	{
		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x00285B30 File Offset: 0x00283D30
		public int EntryCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005447)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ReLogic.Content.Sources.ZipContentSource::get_EntryCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [Ionic.Zip.CF]Ionic.Zip.ZipEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [Ionic.Zip.CF]Ionic.Zip.ZipEntry>(ZipContentSource::_entries, ldloc:ZipContentSource(this)))
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06005448 RID: 21576 RVA: 0x00285B44 File Offset: 0x00283D44
		// (set) Token: 0x06005449 RID: 21577 RVA: 0x00285B58 File Offset: 0x00283D58
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

		// Token: 0x0600544A RID: 21578 RVA: 0x00285B6C File Offset: 0x00283D6C
		public ZipContentSource(string path)
		{
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00285B7C File Offset: 0x00283D7C
		public ZipContentSource(string path, string contentDir)
		{
			if (!true)
			{
			}
			ZipFile zipFile = ZipFile.Read(path);
			this._zipFile = zipFile;
			bool flag = ZipContentSource.ZipPathContainsInvalidCharacters(contentDir);
			string text = ZipContentSource.CleanZipPath(contentDir);
			this._basePath = text;
			this.BuildExtensionFreeEntryList();
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x00285BBC File Offset: 0x00283DBC
		public bool HasAsset(string assetName)
		{
			Dictionary<string, ZipEntry> entries = this._entries;
			return this._rejections.IsRejected(assetName);
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x00285BE0 File Offset: 0x00283DE0
		public string GetExtension(string assetName)
		{
			Dictionary<string, ZipEntry> entries = this._entries;
			return Path.GetExtension(assetName);
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x00285BFC File Offset: 0x00283DFC
		public Stream OpenStream(string assetName)
		{
			/*
An exception occurred when decompiling this method (0600544E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream ReLogic.Content.Sources.ZipContentSource::OpenStream(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [Ionic.Zip.CF]Ionic.Zip.ZipEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [Ionic.Zip.CF]Ionic.Zip.ZipEntry>(ZipContentSource::_entries, ldloc:ZipContentSource(this)))
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

		// Token: 0x0600544F RID: 21583 RVA: 0x00285C10 File Offset: 0x00283E10
		private void BuildExtensionFreeEntryList()
		{
			Dictionary<string, ZipEntry> entries = this._entries;
			ICollection<ZipEntry> entries2 = this._zipFile.Entries;
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00285CA0 File Offset: 0x00283EA0
		private static bool ZipPathContainsInvalidCharacters(string path)
		{
			return true;
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x00285CB0 File Offset: 0x00283EB0
		private static string CleanZipPath(string path)
		{
			string text2;
			string text = Regex.Replace(text2, "^[./]+", "");
			if (text._stringLength != 0)
			{
				bool flag = text.EndsWith("/");
			}
			return text;
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x00285CF0 File Offset: 0x00283EF0
		protected virtual void Dispose(bool disposing)
		{
			if (!this._isDisposed)
			{
				Dictionary<string, ZipEntry> entries = this._entries;
				this._zipFile.Dispose();
				this._isDisposed = true;
			}
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x00285D20 File Offset: 0x00283F20
		public void Dispose()
		{
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x00285D30 File Offset: 0x00283F30
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
			this._rejections.Reject(assetName, reason);
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x00285D4C File Offset: 0x00283F4C
		public void ClearRejections()
		{
			this._rejections.Clear();
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00285D64 File Offset: 0x00283F64
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return this._rejections.TryGetRejections(rejectionReasons);
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x00285D80 File Offset: 0x00283F80
		[CompilerGenerated]
		private bool <BuildExtensionFreeEntryList>b__14_0(ZipEntry entry)
		{
			if (entry._IsDirectory)
			{
			}
			string fileNameInArchive = entry._FileNameInArchive;
			bool flag;
			return flag;
		}

		// Token: 0x04008D20 RID: 36128
		[CompilerGenerated]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x04008D21 RID: 36129
		private readonly ZipFile _zipFile;

		// Token: 0x04008D22 RID: 36130
		private readonly Dictionary<string, ZipEntry> _entries;

		// Token: 0x04008D23 RID: 36131
		private readonly string _basePath;

		// Token: 0x04008D24 RID: 36132
		private bool _isDisposed;

		// Token: 0x04008D25 RID: 36133
		private readonly RejectedAssetCollection _rejections;
	}
}
