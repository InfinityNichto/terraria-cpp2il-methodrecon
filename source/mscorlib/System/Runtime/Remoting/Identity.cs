using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x0200033F RID: 831
	internal abstract class Identity
	{
		// Token: 0x06001BBF RID: 7103 RVA: 0x0003BCB8 File Offset: 0x00039EB8
		public Identity(string objectUri)
		{
			this._objectUri = objectUri;
		}

		// Token: 0x06001BC0 RID: 7104
		public abstract ObjRef CreateObjRef(Type requestedType);

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x0003BCD4 File Offset: 0x00039ED4
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x0003BCE8 File Offset: 0x00039EE8
		public IMessageSink ChannelSink
		{
			get
			{
				return this._channelSink;
			}
			set
			{
				this._channelSink = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x0003BCFC File Offset: 0x00039EFC
		public IMessageSink EnvoySink
		{
			get
			{
				return this._envoySink;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x0003BD10 File Offset: 0x00039F10
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x0003BD24 File Offset: 0x00039F24
		public string ObjectUri
		{
			get
			{
				return this._objectUri;
			}
			set
			{
				this._objectUri = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x0003BD38 File Offset: 0x00039F38
		public bool IsConnected
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001BC6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.Identity::get_IsConnected()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(Identity::_objectUri, ldloc:Identity(this)))
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x0003BD4C File Offset: 0x00039F4C
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0003BD60 File Offset: 0x00039F60
		public bool Disposed
		{
			get
			{
				return this._disposed;
			}
			set
			{
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x0003BD70 File Offset: 0x00039F70
		public DynamicPropertyCollection ClientDynamicProperties
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001BC9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Contexts.DynamicPropertyCollection System.Runtime.Remoting.Identity::get_ClientDynamicProperties()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:DynamicPropertyCollection[exp:bool](Identity::_clientDynamicProperties, ldloc:Identity(this)))
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
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0003BD84 File Offset: 0x00039F84
		public bool HasServerDynamicSinks
		{
			get
			{
				DynamicPropertyCollection serverDynamicProperties = this._serverDynamicProperties;
				bool hasProperties;
				if (serverDynamicProperties != null)
				{
					hasProperties = serverDynamicProperties.HasProperties;
					return hasProperties;
				}
				return hasProperties;
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0003BDA8 File Offset: 0x00039FA8
		public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			DynamicPropertyCollection clientDynamicProperties = this._clientDynamicProperties;
			if (clientDynamicProperties != null)
			{
				long num = 0L;
				bool hasProperties = clientDynamicProperties.HasProperties;
				this._clientDynamicProperties.NotifyMessage(num != 0L, req_msg, client_site, async);
				return;
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0003BDDC File Offset: 0x00039FDC
		public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			DynamicPropertyCollection serverDynamicProperties = this._serverDynamicProperties;
			if (serverDynamicProperties != null)
			{
				long num = 0L;
				bool hasProperties = serverDynamicProperties.HasProperties;
				this._serverDynamicProperties.NotifyMessage(num != 0L, req_msg, client_site, async);
				return;
			}
		}

		// Token: 0x04000E21 RID: 3617
		protected string _objectUri;

		// Token: 0x04000E22 RID: 3618
		protected IMessageSink _channelSink;

		// Token: 0x04000E23 RID: 3619
		protected IMessageSink _envoySink;

		// Token: 0x04000E24 RID: 3620
		private DynamicPropertyCollection _clientDynamicProperties;

		// Token: 0x04000E25 RID: 3621
		private DynamicPropertyCollection _serverDynamicProperties;

		// Token: 0x04000E26 RID: 3622
		protected ObjRef _objRef;

		// Token: 0x04000E27 RID: 3623
		private bool _disposed;
	}
}
