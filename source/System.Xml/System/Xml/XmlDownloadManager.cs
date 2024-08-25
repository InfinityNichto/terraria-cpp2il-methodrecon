using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x02000096 RID: 150
	internal class XmlDownloadManager
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x00018318 File Offset: 0x00016518
		internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			bool flag = uri.Scheme == "file";
			string localPath = uri.LocalPath;
			Stream stream;
			return stream;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00018340 File Offset: 0x00016540
		private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			if (!true)
			{
			}
			WebRequest webRequest = WebRequest.Create(uri);
			if (credentials != null)
			{
			}
			if (proxy != null)
			{
			}
			if (cachePolicy != null)
			{
			}
			if (webRequest != null)
			{
			}
			if (this.connections == null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000183B4 File Offset: 0x000165B4
		internal void Remove(string host)
		{
			Hashtable hashtable = this.connections;
			if (hashtable != null)
			{
				Hashtable.bucket[] buckets = hashtable._buckets;
				hashtable._buckets = buckets;
				Hashtable hashtable2 = this.connections;
			}
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00018418 File Offset: 0x00016618
		internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			bool flag = uri.Scheme == "file";
			Task<Stream> task;
			return task;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00018438 File Offset: 0x00016638
		private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			/*
An exception occurred when decompiling this method (0600072A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.IO.Stream> System.Xml.XmlDownloadManager::GetNonFileStreamAsync(System.Uri,System.Net.ICredentials,System.Net.IWebProxy,System.Net.Cache.RequestCachePolicy)

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

		// Token: 0x0600072B RID: 1835 RVA: 0x00018448 File Offset: 0x00016648
		public XmlDownloadManager()
		{
		}

		// Token: 0x040003A7 RID: 935
		private Hashtable connections;

		// Token: 0x02000097 RID: 151
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600072C RID: 1836 RVA: 0x0001845C File Offset: 0x0001665C
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x0600072D RID: 1837 RVA: 0x00018470 File Offset: 0x00016670
			internal Stream <GetStreamAsync>b__0()
			{
				/*
An exception occurred when decompiling this method (0600072D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream System.Xml.XmlDownloadManager/<>c__DisplayClass4_0::<GetStreamAsync>b__0()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, callgetter:string(Uri::get_LocalPath, ldfld:Uri('<>c__DisplayClass4_0'::uri, ldloc:'<>c__DisplayClass4_0'(this))))
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

			// Token: 0x040003A8 RID: 936
			public Uri uri;
		}

		// Token: 0x02000098 RID: 152
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <GetNonFileStreamAsync>d__5 : IAsyncStateMachine
		{
			// Token: 0x0600072E RID: 1838 RVA: 0x00018488 File Offset: 0x00016688
			private void MoveNext()
			{
				XmlDownloadManager xmlDownloadManager = this.<>4__this;
				WebRequest webRequest = WebRequest.Create(this.uri);
				ICredentials credentials = this.credentials;
				this.<req>5__2 = webRequest;
				if (credentials != null)
				{
				}
				if (this.proxy != null)
				{
					WebRequest webRequest2 = this.<req>5__2;
				}
				if (this.cachePolicy != null)
				{
					WebRequest webRequest3 = this.<req>5__2;
				}
				WebRequest webRequest4 = this.<req>5__2;
				WebRequest webRequest5 = this.<req>5__2;
			}

			// Token: 0x0600072F RID: 1839 RVA: 0x00018588 File Offset: 0x00016788
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040003A9 RID: 937
			public int <>1__state;

			// Token: 0x040003AA RID: 938
			public AsyncTaskMethodBuilder<Stream> <>t__builder;

			// Token: 0x040003AB RID: 939
			public Uri uri;

			// Token: 0x040003AC RID: 940
			public ICredentials credentials;

			// Token: 0x040003AD RID: 941
			public IWebProxy proxy;

			// Token: 0x040003AE RID: 942
			public RequestCachePolicy cachePolicy;

			// Token: 0x040003AF RID: 943
			public XmlDownloadManager <>4__this;

			// Token: 0x040003B0 RID: 944
			private WebRequest <req>5__2;

			// Token: 0x040003B1 RID: 945
			private ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
