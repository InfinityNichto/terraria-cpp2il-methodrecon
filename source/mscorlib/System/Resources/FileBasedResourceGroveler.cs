using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace System.Resources
{
	// Token: 0x020004B0 RID: 1200
	internal class FileBasedResourceGroveler : IResourceGroveler
	{
		// Token: 0x060022EF RID: 8943 RVA: 0x0004E73C File Offset: 0x0004C93C
		public FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		{
			this._mediator = mediator;
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0004E758 File Offset: 0x0004C958
		public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, StackCrawlMark stackMark)
		{
			ResourceManager rm = this._mediator._rm;
			string text;
			if (text != null)
			{
				return this.CreateResourceSet(text);
			}
			bool hasInvariantCultureName = culture.HasInvariantCultureName;
			string resourceString = Environment.GetResourceString("Could not find any resources appropriate for the specified culture (or the neutral culture) on disk.");
			if (resourceString == null || resourceString != null)
			{
				string newLine = Environment.NewLine;
				if ((newLine == null || newLine != null) && ("baseName: " == null || "baseName: " != null))
				{
					string baseNameField = this._mediator._rm.BaseNameField;
					if ((baseNameField == null || baseNameField != null) && ("  locationInfo: " == null || "  locationInfo: " != null))
					{
						ResourceManager rm2 = this._mediator._rm;
						Type locationInfo = rm2._locationInfo;
						if (rm2 == null)
						{
						}
						return "<null>";
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0004E838 File Offset: 0x0004CA38
		private string FindResourceFile(CultureInfo culture, string fileName)
		{
			/*
An exception occurred when decompiling this method (060022F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Resources.FileBasedResourceGroveler::FindResourceFile(System.Globalization.CultureInfo,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stloc:bool(var_3_2B, call:bool(File::Exists, ldloc:string(fileName)))
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

		// Token: 0x060022F2 RID: 8946 RVA: 0x0004E870 File Offset: 0x0004CA70
		private ResourceSet CreateResourceSet(string file)
		{
			Type userResourceSet = this._mediator._rm._userResourceSet;
			if (file == null || file != null)
			{
				Type userResourceSet2 = this._mediator._rm._userResourceSet;
				object obj;
				if (obj != null)
				{
				}
				throw new InvalidCastException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04001321 RID: 4897
		private ResourceManager.ResourceManagerMediator _mediator;
	}
}
