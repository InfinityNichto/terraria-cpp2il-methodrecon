using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001FE RID: 510
	internal class ServiceNameStore
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00027DD0 File Offset: 0x00025FD0
		public global::System.Security.Authentication.ExtendedProtection.ServiceNameCollection ServiceNames
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000C7E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Authentication.ExtendedProtection.ServiceNameCollection System.Net.ServiceNameStore::get_ServiceNames()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<string>(var_0_0E, ldfld:class [mscorlib]System.Collections.Generic.List`1<string>(ServiceNameStore::serviceNames, ldloc:ServiceNameStore(this)))
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

		// Token: 0x06000C7F RID: 3199 RVA: 0x00027DEC File Offset: 0x00025FEC
		public ServiceNameStore()
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002050 File Offset: 0x00000250
		private bool AddSingleServiceName(string spn)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00027E00 File Offset: 0x00026000
		public bool Add(string uriPrefix)
		{
			/*
An exception occurred when decompiling this method (06000C81)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.ServiceNameStore::Add(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_07, call:string[](ServiceNameStore::BuildServiceNames, ldloc:ServiceNameStore(this), ldloc:string(uriPrefix)))
	stloc:bool(var_2_11, call:bool(ServiceNameStore::AddSingleServiceName, ldloc:ServiceNameStore(this), ldloc:string(uriPrefix)))
	stloc:bool(var_4_19, callgetter:bool(Logging::get_On))
	stloc:bool(var_7_26, callgetter:bool(Logging::get_On))
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

		// Token: 0x06000C82 RID: 3202 RVA: 0x00027E38 File Offset: 0x00026038
		public bool Remove(string uriPrefix)
		{
			/*
An exception occurred when decompiling this method (06000C82)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.ServiceNameStore::Remove(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0026:
	stloc:bool(var_6_31, callgetter:bool(Logging::get_On))
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

		// Token: 0x06000C83 RID: 3203 RVA: 0x00027E78 File Offset: 0x00026078
		private bool Contains(string newServiceName)
		{
			if (newServiceName != null)
			{
				List<string> list = this.serviceNames;
				return global::System.Security.Authentication.ExtendedProtection.ServiceNameCollection.Contains(newServiceName, list);
			}
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00002050 File Offset: 0x00000250
		public void Clear()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00027E98 File Offset: 0x00026098
		private string ExtractHostname(string uriPrefix, bool allowInvalidUriStrings)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00027F0C File Offset: 0x0002610C
		public string BuildSimpleServiceName(string uriPrefix)
		{
			string text;
			string text2;
			if (text != null)
			{
				text2 = "HTTP/" + text;
				return text2;
			}
			return text2;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00027F30 File Offset: 0x00026130
		public string[] BuildServiceNames(string uriPrefix)
		{
			int num;
			int num2;
			if (num == 0 || num2 != 0)
			{
			}
			IPHostEntry iphostEntry;
			string hostName = iphostEntry.hostName;
			string text = "HTTP/" + hostName;
			if (text == null || text != null)
			{
				bool flag = text.Contains(".");
				string text2 = "HTTP/" + text;
				while (text2 == null)
				{
				}
				while (text2 != null)
				{
				}
				throw new ArrayTypeMismatchException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000AB8 RID: 2744
		private List<string> serviceNames;

		// Token: 0x04000AB9 RID: 2745
		private global::System.Security.Authentication.ExtendedProtection.ServiceNameCollection serviceNameCollection;
	}
}
