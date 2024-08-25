using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000B4F RID: 2895
	public class XnaContentSource : IContentSource
	{
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x00285858 File Offset: 0x00283A58
		// (set) Token: 0x06005433 RID: 21555 RVA: 0x0028586C File Offset: 0x00283A6C
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

		// Token: 0x06005434 RID: 21556 RVA: 0x00285880 File Offset: 0x00283A80
		public XnaContentSource(string rootDirectory)
		{
			string text;
			this._rootDirectory = text;
			this.BuildFileMap();
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x002858A0 File Offset: 0x00283AA0
		private void BuildFileMap()
		{
			HashSet<string> files = this._files;
			string rootDirectory = this._rootDirectory;
			HashSet<string> files2 = this._files;
			string[] array;
			string text = array.ToLower();
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x002858D0 File Offset: 0x00283AD0
		public bool HasAsset(string assetName)
		{
			/*
An exception occurred when decompiling this method (06005436)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Content.Sources.XnaContentSource::HasAsset(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:string(var_1_1B, call:string(string::Concat, call:string(Path::Combine, ldloc:string(var_0_06), ldloc:string(assetName)), ldstr:string(".xnb")))
	stloc:bool(var_2_28, call:bool(RejectedAssetCollection::IsRejected, ldfld:RejectedAssetCollection(XnaContentSource::_rejections, ldloc:XnaContentSource(this)), ldloc:string(assetName)))
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<string>(var_4_31, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<string>(XnaContentSource::_files, ldloc:XnaContentSource(this)))
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

		// Token: 0x06005437 RID: 21559 RVA: 0x00285918 File Offset: 0x00283B18
		public string GetExtension(string assetName)
		{
			return ".xnb";
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x0028592C File Offset: 0x00283B2C
		public Stream OpenStream(string assetName)
		{
			int num = 1;
			string rootDirectory = this._rootDirectory;
			if (num == 0)
			{
			}
			string text = Path.Combine(rootDirectory, assetName) + ".xnb";
			return TitleContainer.OpenStream(text);
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x00285964 File Offset: 0x00283B64
		public static string GetTitleLocationPath()
		{
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			string text;
			return text;
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00285984 File Offset: 0x00283B84
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
			this._rejections.Reject(assetName, reason);
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x002859A0 File Offset: 0x00283BA0
		public void ClearRejections()
		{
			this._rejections.Clear();
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x002859B8 File Offset: 0x00283BB8
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return this._rejections.TryGetRejections(rejectionReasons);
		}

		// Token: 0x04008D18 RID: 36120
		private readonly string _rootDirectory;

		// Token: 0x04008D19 RID: 36121
		private readonly HashSet<string> _files;

		// Token: 0x04008D1A RID: 36122
		[CompilerGenerated]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x04008D1B RID: 36123
		private readonly RejectedAssetCollection _rejections;
	}
}
