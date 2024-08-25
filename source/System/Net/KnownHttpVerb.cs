using System;
using System.Collections.Specialized;

namespace System.Net
{
	// Token: 0x020001BA RID: 442
	internal class KnownHttpVerb
	{
		// Token: 0x06000AAF RID: 2735 RVA: 0x000238F4 File Offset: 0x00021AF4
		internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse)
		{
			this.Name = name;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00023910 File Offset: 0x00021B10
		static KnownHttpVerb()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0002392C File Offset: 0x00021B2C
		public bool Equals(KnownHttpVerb verb)
		{
			string name = this.Name;
			string name2 = verb.Name;
			int num = string.Compare(name, name2, StringComparison.OrdinalIgnoreCase);
			return true;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00023954 File Offset: 0x00021B54
		public static KnownHttpVerb Parse(string name)
		{
			/*
An exception occurred when decompiling this method (06000AB2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.KnownHttpVerb System.Net.KnownHttpVerb::Parse(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, logicnot:bool(ldloc:object[exp:bool](var_0)))
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

		// Token: 0x0400095C RID: 2396
		internal string Name;

		// Token: 0x0400095D RID: 2397
		internal bool RequireContentBody;

		// Token: 0x0400095E RID: 2398
		internal bool ContentBodyNotAllowed;

		// Token: 0x0400095F RID: 2399
		internal bool ConnectRequest;

		// Token: 0x04000960 RID: 2400
		internal bool ExpectNoContentResponse;

		// Token: 0x04000961 RID: 2401
		private static global::System.Collections.Specialized.ListDictionary NamedHeaders;

		// Token: 0x04000962 RID: 2402
		internal static KnownHttpVerb Get;

		// Token: 0x04000963 RID: 2403
		internal static KnownHttpVerb Connect;

		// Token: 0x04000964 RID: 2404
		internal static KnownHttpVerb Head;

		// Token: 0x04000965 RID: 2405
		internal static KnownHttpVerb Put;

		// Token: 0x04000966 RID: 2406
		internal static KnownHttpVerb Post;

		// Token: 0x04000967 RID: 2407
		internal static KnownHttpVerb MkCol;
	}
}
