using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;

namespace System.Net
{
	// Token: 0x02000251 RID: 593
	public sealed class HttpListenerResponse : IDisposable
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x000308E0 File Offset: 0x0002EAE0
		internal HttpListenerResponse(HttpListenerContext context)
		{
			this.keep_alive = true;
			if (!true)
			{
			}
			this.status_code = 200;
			this.version = 1;
			this.status_description = "OK";
			base..ctor();
			this.context = context;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00030924 File Offset: 0x0002EB24
		internal bool ForceCloseChunked
		{
			get
			{
				return this.force_close_chunked;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00030938 File Offset: 0x0002EB38
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0003095C File Offset: 0x0002EB5C
		public Encoding ContentEncoding
		{
			get
			{
				Encoding @default;
				if (this.content_encoding == null)
				{
					@default = Encoding.Default;
					this.content_encoding = @default;
				}
				return @default;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000F4A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpListenerResponse::set_ContentEncoding(System.Text.Encoding)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:Type(var_0_1E, call:Type(object::GetType, ldloc:HttpListenerResponse[exp:object](this)))
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00030988 File Offset: 0x0002EB88
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x0003099C File Offset: 0x0002EB9C
		public long ContentLength64
		{
			get
			{
				return this.content_length;
			}
			set
			{
				if (!this.disposed)
				{
					if (!this.HeadersSent)
					{
						this.cl_set = true;
						this.content_length = value;
						return;
					}
				}
				else
				{
					Type type = base.GetType();
				}
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000309D0 File Offset: 0x0002EBD0
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x000309E4 File Offset: 0x0002EBE4
		public string ContentType
		{
			get
			{
				return this.content_type;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000F4E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpListenerResponse::set_ContentType(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:Type(var_0_1E, call:Type(object::GetType, ldloc:HttpListenerResponse[exp:object](this)))
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

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00030A10 File Offset: 0x0002EC10
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00030A24 File Offset: 0x0002EC24
		public CookieCollection Cookies
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F4F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.CookieCollection System.Net.HttpListenerResponse::get_Cookies()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:CookieCollection[exp:bool](HttpListenerResponse::cookies, ldloc:HttpListenerResponse(this)))
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
			set
			{
				this.cookies = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00030A38 File Offset: 0x0002EC38
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x00030A4C File Offset: 0x0002EC4C
		public WebHeaderCollection Headers
		{
			get
			{
				return this.headers;
			}
			set
			{
				this.headers = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00030A60 File Offset: 0x0002EC60
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x00030A74 File Offset: 0x0002EC74
		public bool KeepAlive
		{
			get
			{
				return this.keep_alive;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000F54)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpListenerResponse::set_KeepAlive(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:Type(var_1_20, call:Type(object::GetType, ldloc:HttpListenerResponse[exp:object](this)))
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

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00030AA4 File Offset: 0x0002ECA4
		public Stream OutputStream
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F55)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream System.Net.HttpListenerResponse::get_OutputStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ResponseStream(var_0_18, call:ResponseStream(HttpConnection::GetResponseStream, ldfld:HttpConnection(HttpListenerContext::cnc, ldfld:HttpListenerContext(HttpListenerResponse::context, ldloc:HttpListenerResponse(this)))))
	stfld:ResponseStream(HttpListenerResponse::output_stream, ldloc:HttpListenerResponse(this), ldloc:ResponseStream(var_0_18))
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00030AD0 File Offset: 0x0002ECD0
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x00030AE4 File Offset: 0x0002ECE4
		public Version ProtocolVersion
		{
			get
			{
				return this.version;
			}
			set
			{
				if (!this.disposed && !this.HeadersSent)
				{
					int major = value._Major;
					int minor = value._Minor;
					if (!this.disposed)
					{
						this.version = value;
						return;
					}
				}
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00030B20 File Offset: 0x0002ED20
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00030B34 File Offset: 0x0002ED34
		public string RedirectLocation
		{
			get
			{
				return this.location;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000F59)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpListenerResponse::set_RedirectLocation(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:Type(var_0_1E, call:Type(object::GetType, ldloc:HttpListenerResponse[exp:object](this)))
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00030B60 File Offset: 0x0002ED60
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00030B74 File Offset: 0x0002ED74
		public bool SendChunked
		{
			get
			{
				return this.chunked;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000F5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpListenerResponse::set_SendChunked(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:Type(var_1_20, call:Type(object::GetType, ldloc:HttpListenerResponse[exp:object](this)))
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

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00030BA4 File Offset: 0x0002EDA4
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00030BB8 File Offset: 0x0002EDB8
		public int StatusCode
		{
			get
			{
				return this.status_code;
			}
			set
			{
				if (!this.disposed)
				{
					if (!this.HeadersSent)
					{
						this.status_code = value;
						string text = HttpStatusDescription.Get(value);
						this.status_description = text;
						return;
					}
				}
				else
				{
					Type type = base.GetType();
				}
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00030BF4 File Offset: 0x0002EDF4
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00030C08 File Offset: 0x0002EE08
		public string StatusDescription
		{
			get
			{
				return this.status_description;
			}
			set
			{
				this.status_description = value;
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00030C1C File Offset: 0x0002EE1C
		void IDisposable.Dispose()
		{
			HttpListenerContext httpListenerContext = this.context;
			this.disposed = true;
			httpListenerContext.cnc.Close(true);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00030C44 File Offset: 0x0002EE44
		public void Abort()
		{
			if (this.disposed)
			{
				return;
			}
			this.context.cnc.Close(true);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00030C6C File Offset: 0x0002EE6C
		public void AddHeader(string name, string value)
		{
			if (name != null)
			{
				bool flag = name == "";
				int stringLength = value._stringLength;
				WebHeaderCollection webHeaderCollection = this.headers;
				return;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00030C98 File Offset: 0x0002EE98
		public void AppendCookie(Cookie cookie)
		{
			while (cookie == null)
			{
			}
			this.Cookies.Add(cookie);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00030CB4 File Offset: 0x0002EEB4
		public void AppendHeader(string name, string value)
		{
			if (name != null)
			{
				bool flag = name == "";
				int stringLength = value._stringLength;
				WebHeaderCollection webHeaderCollection = this.headers;
				return;
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		private void Close(bool force)
		{
			HttpListenerContext httpListenerContext = this.context;
			this.disposed = true;
			httpListenerContext.cnc.Close(force);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00030D08 File Offset: 0x0002EF08
		public void Close()
		{
			if (this.disposed)
			{
				return;
			}
			HttpListenerContext httpListenerContext = this.context;
			this.disposed = true;
			long num = 0L;
			httpListenerContext.cnc.Close(num != 0L);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00030D3C File Offset: 0x0002EF3C
		public void Close(byte[] responseEntity, bool willBlock)
		{
			while (!this.disposed)
			{
				if (responseEntity != null)
				{
					if (this.output_stream == null)
					{
						ResponseStream responseStream = this.context.cnc.GetResponseStream();
						this.output_stream = responseStream;
					}
					long num = this.content_length;
					HttpListenerContext httpListenerContext = this.context;
					this.disposed = true;
					HttpConnection cnc = httpListenerContext.cnc;
					long num2 = 0L;
					cnc.Close(num2 != 0L);
					return;
				}
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00030D9C File Offset: 0x0002EF9C
		public void CopyFrom(HttpListenerResponse templateResponse)
		{
			WebHeaderCollection webHeaderCollection = this.headers;
			WebHeaderCollection webHeaderCollection2 = this.headers;
			WebHeaderCollection webHeaderCollection3 = templateResponse.headers;
			webHeaderCollection2.Add(webHeaderCollection3);
			long num = templateResponse.content_length;
			this.content_length = num;
			int num2 = templateResponse.status_code;
			this.status_code = num2;
			string text = templateResponse.status_description;
			this.status_description = text;
			bool flag = templateResponse.keep_alive;
			this.keep_alive = flag;
			Version version = templateResponse.version;
			this.version = version;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00030E14 File Offset: 0x0002F014
		public void Redirect(string url)
		{
			this.StatusCode = 302;
			this.location = url;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00030E34 File Offset: 0x0002F034
		private bool FindCookie(Cookie cookie)
		{
			CookieCollection cookieCollection = this.cookies;
			string domain = cookie.m_domain;
			string name = cookie.m_name;
			string path = cookie.m_path;
			IEnumerator enumerator = cookieCollection.GetEnumerator();
			if (enumerator != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00030E98 File Offset: 0x0002F098
		internal void SendHeaders(bool closing, MemoryStream ms)
		{
			if (this.content_encoding == null)
			{
				Encoding @default = Encoding.Default;
			}
			if (this.content_type != null)
			{
				if (this.content_encoding != null)
				{
					string text = this.content_type;
				}
				WebHeaderCollection webHeaderCollection = this.headers;
				return;
			}
			if (this.headers["Server"] == null)
			{
				this.headers.SetInternal("Server", "Mono-HTTPAPI/1.0");
			}
			if ("Mono-HTTPAPI/1.0" == null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (this.headers["Date"] == null)
			{
				WebHeaderCollection webHeaderCollection2 = this.headers;
				string text2 = DateTime.UtcNow.ToString("r", invariantCulture);
				webHeaderCollection2.SetInternal("Date", text2);
			}
			if (!this.chunked)
			{
				bool flag = this.cl_set;
				int num = 1;
				this.cl_set = num != 0;
				return;
			}
			if (!this.cl_set && !this.chunked)
			{
				HttpListenerRequest request = this.context.request;
				Version version = request.version;
				if ("charset=" == null)
				{
				}
				string[] accept_types = request.accept_types;
			}
			int num2 = this.status_code;
			if (this.keep_alive)
			{
				this.headers.SetInternal("Connection", "close");
			}
			if (this.chunked)
			{
				this.headers.SetInternal("Transfer-Encoding", "chunked");
			}
			int reuses = this.context.cnc.reuses;
			WebHeaderCollection webHeaderCollection3 = this.headers;
			int num3 = 100;
			string text3;
			webHeaderCollection3.SetInternal("Keep-Alive", text3);
			Version version2 = this.context.request.version;
			if (num3 == 0)
			{
			}
			WebHeaderCollection webHeaderCollection4 = this.headers;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0003118C File Offset: 0x0002F38C
		private static string FormatHeaders(WebHeaderCollection headers)
		{
			/*
An exception occurred when decompiling this method (06000F6C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.HttpListenerResponse::FormatHeaders(System.Net.WebHeaderCollection)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:StringBuilder(var_4_23, call:StringBuilder(StringBuilder::Append, call:StringBuilder(StringBuilder::Append, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_3), ldstr:string(": ")), ldstr:string(": ")), ldstr:string("\r\n")))
	stloc:StringBuilder(var_6_31, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_5), ldstr:string(": ")))
	stloc:StringBuilder(var_8_3F, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_7), ldstr:string("\r\n")))
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

		// Token: 0x06000F6D RID: 3949 RVA: 0x000311DC File Offset: 0x0002F3DC
		private static string CookieToClientString(Cookie cookie)
		{
			/*
An exception occurred when decompiling this method (06000F6D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.HttpListenerResponse::CookieToClientString(System.Net.Cookie)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0053:
	stloc:StringBuilder(var_8_5C, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_6), ldloc:string(var_7)))
	stloc:StringBuilder(var_10_6A, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_9), ldstr:string(";Port=")))
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

		// Token: 0x06000F6E RID: 3950 RVA: 0x00031254 File Offset: 0x0002F454
		private static string QuotedString(Cookie cookie, string value)
		{
			if (true)
			{
			}
			string text;
			return text + text + "\\\"";
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00031270 File Offset: 0x0002F470
		private static bool IsToken(string value)
		{
			if ("This blend state is already bound to a different graphics device." == null)
			{
				return;
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00031290 File Offset: 0x0002F490
		public void SetCookie(Cookie cookie)
		{
			if (cookie == null)
			{
				return;
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x000312A8 File Offset: 0x0002F4A8
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListenerResponse()
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x000312B8 File Offset: 0x0002F4B8
		internal HttpListenerResponse()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000C47 RID: 3143
		private bool disposed;

		// Token: 0x04000C48 RID: 3144
		private Encoding content_encoding;

		// Token: 0x04000C49 RID: 3145
		private long content_length;

		// Token: 0x04000C4A RID: 3146
		private bool cl_set;

		// Token: 0x04000C4B RID: 3147
		private string content_type;

		// Token: 0x04000C4C RID: 3148
		private CookieCollection cookies;

		// Token: 0x04000C4D RID: 3149
		private WebHeaderCollection headers;

		// Token: 0x04000C4E RID: 3150
		private bool keep_alive;

		// Token: 0x04000C4F RID: 3151
		private ResponseStream output_stream;

		// Token: 0x04000C50 RID: 3152
		private Version version;

		// Token: 0x04000C51 RID: 3153
		private string location;

		// Token: 0x04000C52 RID: 3154
		private int status_code;

		// Token: 0x04000C53 RID: 3155
		private string status_description;

		// Token: 0x04000C54 RID: 3156
		private bool chunked;

		// Token: 0x04000C55 RID: 3157
		private HttpListenerContext context;

		// Token: 0x04000C56 RID: 3158
		internal bool HeadersSent;

		// Token: 0x04000C57 RID: 3159
		internal object headers_lock;

		// Token: 0x04000C58 RID: 3160
		private bool force_close_chunked;

		// Token: 0x04000C59 RID: 3161
		private static string tspecials;
	}
}
