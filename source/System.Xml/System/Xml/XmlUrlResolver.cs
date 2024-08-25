using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x020000B0 RID: 176
	public class XmlUrlResolver : XmlResolver
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00019714 File Offset: 0x00017914
		private static XmlDownloadManager DownloadManager
		{
			get
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00019728 File Offset: 0x00017928
		public XmlUrlResolver()
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0001973C File Offset: 0x0001793C
		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			/*
An exception occurred when decompiling this method (060007BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.XmlUrlResolver::GetEntity(System.Uri,System.String,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_2_0A, call:bool(Type::op_Equality, ldloc:Type(ofObjectToReturn), ldloc:Type(var_1)))
	stloc:bool(var_4_12, call:bool(Type::op_Equality, ldloc:Type(ofObjectToReturn), ldloc:Type(var_3)))
	stloc:XmlDownloadManager(var_5_19, callgetter:XmlDownloadManager(XmlUrlResolver::get_DownloadManager))
	stloc:ICredentials(var_6_21, ldfld:ICredentials(XmlUrlResolver::_credentials, ldloc:XmlUrlResolver(this)))
	stloc:IWebProxy(var_7_29, ldfld:IWebProxy(XmlUrlResolver::_proxy, ldloc:XmlUrlResolver(this)))
	stloc:RequestCachePolicy(var_8_31, ldfld:RequestCachePolicy(XmlUrlResolver::_cachePolicy, ldloc:XmlUrlResolver(this)))
	stloc:Stream(var_9_41, call:Stream(XmlDownloadManager::GetStream, ldloc:XmlDownloadManager(var_5_19), ldloc:Uri(absoluteUri), ldloc:ICredentials(var_6_21), ldloc:IWebProxy(var_7_29), ldloc:RequestCachePolicy(var_8_31)))
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

		// Token: 0x060007BD RID: 1981 RVA: 0x0001978C File Offset: 0x0001798C
		public override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return base.ResolveUri(baseUri, relativeUri);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000197A4 File Offset: 0x000179A4
		public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			/*
An exception occurred when decompiling this method (060007BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Object> System.Xml.XmlUrlResolver::GetEntityAsync(System.Uri,System.String,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x040003E6 RID: 998
		private static object s_DownloadManager;

		// Token: 0x040003E7 RID: 999
		private ICredentials _credentials;

		// Token: 0x040003E8 RID: 1000
		private IWebProxy _proxy;

		// Token: 0x040003E9 RID: 1001
		private RequestCachePolicy _cachePolicy;

		// Token: 0x020000B1 RID: 177
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <GetEntityAsync>d__15 : IAsyncStateMachine
		{
			// Token: 0x060007BF RID: 1983 RVA: 0x000197B4 File Offset: 0x000179B4
			private void MoveNext()
			{
				XmlUrlResolver xmlUrlResolver = this.<>4__this;
				Type type = this.ofObjectToReturn;
				Type type2;
				bool flag = this.ofObjectToReturn == type2;
				Type type3;
				bool flag2 = this.ofObjectToReturn == type3;
				XmlDownloadManager downloadManager = XmlUrlResolver.DownloadManager;
				Uri uri = this.absoluteUri;
				ICredentials credentials = xmlUrlResolver._credentials;
				IWebProxy proxy = xmlUrlResolver._proxy;
				RequestCachePolicy cachePolicy = xmlUrlResolver._cachePolicy;
				Task<Stream> streamAsync = downloadManager.GetStreamAsync(uri, credentials, proxy, cachePolicy);
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x00019838 File Offset: 0x00017A38
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040003EA RID: 1002
			public int <>1__state;

			// Token: 0x040003EB RID: 1003
			public AsyncTaskMethodBuilder<object> <>t__builder;

			// Token: 0x040003EC RID: 1004
			public Type ofObjectToReturn;

			// Token: 0x040003ED RID: 1005
			public Uri absoluteUri;

			// Token: 0x040003EE RID: 1006
			public XmlUrlResolver <>4__this;

			// Token: 0x040003EF RID: 1007
			private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
