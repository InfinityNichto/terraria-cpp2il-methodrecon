using System;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net
{
	// Token: 0x0200012B RID: 299
	internal class NTAuthentication
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00019B4C File Offset: 0x00017D4C
		internal bool IsCompleted
		{
			get
			{
				return this._isCompleted;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00019B60 File Offset: 0x00017D60
		internal bool IsValidContext
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600071A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.NTAuthentication::get_IsValidContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:SafeDeleteContext[exp:bool](NTAuthentication::_securityContext, ldloc:NTAuthentication(this))))
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00019B74 File Offset: 0x00017D74
		internal string Package
		{
			get
			{
				return this._package;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00019B88 File Offset: 0x00017D88
		internal bool IsServer
		{
			get
			{
				return this._isServer;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00019B9C File Offset: 0x00017D9C
		internal string ClientSpecifiedSpn
		{
			get
			{
				string clientSpecifiedSpn;
				if (this._clientSpecifiedSpn == null)
				{
					clientSpecifiedSpn = this.GetClientSpecifiedSpn();
					this._clientSpecifiedSpn = clientSpecifiedSpn;
				}
				return clientSpecifiedSpn;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00019BC0 File Offset: 0x00017DC0
		internal string ProtocolName
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600071E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.NTAuthentication::get_ProtocolName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002B:
	brtrue(IL_0000, ldloc:string[exp:bool](var_0_1B))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00019BFC File Offset: 0x00017DFC
		internal bool IsKerberos
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600071F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.NTAuthentication::get_IsKerberos()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0E, callgetter:string(NTAuthentication::get_ProtocolName, ldloc:NTAuthentication(this)))
	stfld:string(NTAuthentication::_lastProtocolName, ldloc:NTAuthentication(this), ldloc:string(var_0_0E))
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

		// Token: 0x06000720 RID: 1824 RVA: 0x00019C20 File Offset: 0x00017E20
		internal NTAuthentication(bool isServer, string package, NetworkCredential credential, string spn, ContextFlagsPal requestedContextFlags, global::System.Security.Authentication.ExtendedProtection.ChannelBinding channelBinding)
		{
			long num = 0L;
			base..ctor();
			this.Initialize(num != 0L, package, credential, spn, requestedContextFlags, channelBinding);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00019C44 File Offset: 0x00017E44
		private void Initialize(bool isServer, string package, NetworkCredential credential, string spn, ContextFlagsPal requestedContextFlags, global::System.Security.Authentication.ExtendedProtection.ChannelBinding channelBinding)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			int num = global::System.Net.Security.NegotiateStreamPal.QueryMaxTokenSize(package);
			this._spn = spn;
			this._tokenSize = num;
			this._contextFlags = requestedContextFlags;
			this._package = package;
			this._channelBinding = channelBinding;
			bool isEnabled2 = NetEventSource.IsEnabled;
			string spn2 = this._spn;
			if (spn2 == null || spn2 != null)
			{
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "Initialize");
				bool isServer2 = this._isServer;
				global::System.Net.Security.SafeFreeCredentials safeFreeCredentials = global::System.Net.Security.NegotiateStreamPal.AcquireCredentialsHandle(package, isServer2, credential);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00019CF8 File Offset: 0x00017EF8
		internal global::System.Net.Security.SafeDeleteContext GetContext([Out] SecurityStatusPal status)
		{
			if (!this._isCompleted || this._securityContext != null)
			{
			}
			NetEventSource.Fail(this, "Should be called only when completed with success, currently is not!", "GetContext");
			bool isServer = this._isServer;
			if (!isServer)
			{
				if (!isServer)
				{
				}
				NetEventSource.Fail(this, "The method must not be called by the client side!", "GetContext");
			}
			if (this._securityContext != null)
			{
			}
			return this._securityContext;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00019D54 File Offset: 0x00017F54
		internal void CloseContext()
		{
			global::System.Net.Security.SafeDeleteContext securityContext = this._securityContext;
			if (securityContext != null)
			{
				bool isClosed = securityContext.IsClosed;
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00019D80 File Offset: 0x00017F80
		internal int VerifySignature(byte[] buffer, int offset, int count)
		{
			return global::System.Net.Security.NegotiateStreamPal.VerifySignature(this._securityContext, buffer, offset, count);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00019D9C File Offset: 0x00017F9C
		internal int MakeSignature(byte[] buffer, int offset, int count, byte[] output)
		{
			return global::System.Net.Security.NegotiateStreamPal.MakeSignature(this._securityContext, buffer, offset, count, output);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00019DBC File Offset: 0x00017FBC
		internal string GetOutgoingBlob(string incomingBlob)
		{
			/*
An exception occurred when decompiling this method (06000726)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.NTAuthentication::GetOutgoingBlob(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_5:
	call:void(NTAuthentication::CloseContext, ldloc:NTAuthentication(this))
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

		// Token: 0x06000727 RID: 1831 RVA: 0x00019E28 File Offset: 0x00018028
		internal byte[] GetOutgoingBlob(byte[] incomingBlob, bool thrownOnError)
		{
			byte[] array;
			return array;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00019E38 File Offset: 0x00018038
		internal byte[] GetOutgoingBlob(byte[] incomingBlob, bool throwOnError, [Out] SecurityStatusPal statusCode)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			NetEventSource.Enter(this, incomingBlob, "GetOutgoingBlob");
			global::System.Security.Authentication.ExtendedProtection.ChannelBinding channelBinding = this._channelBinding;
			if (incomingBlob != null)
			{
				if (channelBinding == null)
				{
					goto IL_003C;
				}
				global::System.Security.Authentication.ExtendedProtection.ChannelBinding channelBinding2 = this._channelBinding;
			}
			global::System.Security.Authentication.ExtendedProtection.ChannelBinding channelBinding3 = this._channelBinding;
			IL_003C:
			int tokenSize = this._tokenSize;
			global::System.Net.Security.SafeDeleteContext securityContext = this._securityContext;
			ContextFlagsPal requestedContextFlags = this._requestedContextFlags;
			SecurityStatusPal securityStatusPal;
			statusCode.ErrorCode = securityStatusPal;
			statusCode.Exception = this;
			bool isEnabled2 = NetEventSource.IsEnabled;
			if ("SSPIWrapper.AcceptSecurityContext() returns statusCode:0x{0:x8} ({1})" == null)
			{
			}
			FormattableString formattableString;
			NetEventSource.Info(this, formattableString, "GetOutgoingBlob");
			string spn = this._spn;
			ContextFlagsPal requestedContextFlags2 = this._requestedContextFlags;
			SecurityStatusPal securityStatusPal2;
			statusCode.ErrorCode = securityStatusPal2;
			statusCode.Exception = this;
			if ("SSPIWrapper.AcceptSecurityContext() returns statusCode:0x{0:x8} ({1})" == null)
			{
			}
			bool isEnabled3 = NetEventSource.IsEnabled;
			if ("SSPIWrapper.InitializeSecurityContext() returns statusCode:0x{0:x8} ({1})" == null)
			{
			}
			FormattableString formattableString2;
			NetEventSource.Info(this, formattableString2, "GetOutgoingBlob");
			SecurityStatusPal securityStatusPal3;
			statusCode.ErrorCode = securityStatusPal3;
			statusCode.Exception = "GetOutgoingBlob";
			if ("GetOutgoingBlob" == null)
			{
			}
			bool isEnabled4 = NetEventSource.IsEnabled;
			if ("SSPIWrapper.CompleteAuthToken() returns statusCode:0x{0:x8} ({1})" == null)
			{
			}
			FormattableString formattableString3;
			NetEventSource.Info(this, formattableString3, "GetOutgoingBlob");
			long num2 = 0L;
			long num3;
			int num4;
			if (securityContext == null)
			{
				global::System.Net.Security.SafeFreeCredentials credentialsHandle = this._credentialsHandle;
				if (credentialsHandle != null)
				{
					credentialsHandle.Dispose();
					if (num2 == 0L)
					{
						goto IL_0133;
					}
					num3 = 0L;
					num4 = 10;
					while (securityContext == null)
					{
					}
				}
			}
			if (num3 != 0L)
			{
				throw new OutOfMemoryException();
			}
			IL_0133:
			if (num4 == 0)
			{
				if (securityContext == null)
				{
					global::System.Net.Security.SafeFreeCredentials credentialsHandle2 = this._credentialsHandle;
					if (credentialsHandle2 != null)
					{
						global::System.Net.Security.SSPIHandleCache.CacheCredential(credentialsHandle2);
					}
				}
				this.CloseContext();
				int num5 = 1;
				this._isCompleted = num5 != 0;
				if (num5 == 0)
				{
				}
				bool isEnabled5 = NetEventSource.IsEnabled;
				FormattableString formattableString4;
				NetEventSource.Exit(this, formattableString4, "GetOutgoingBlob");
				bool isEnabled6 = NetEventSource.IsEnabled;
				bool isEnabled7 = NetEventSource.IsEnabled;
				FormattableString formattableString5;
				NetEventSource.Info(this, formattableString5, "GetOutgoingBlob");
				bool isEnabled8 = NetEventSource.IsEnabled;
				bool isEnabled9 = NetEventSource.IsEnabled;
				bool isCompleted = this._isCompleted;
				FormattableString formattableString6;
				NetEventSource.Exit(this, formattableString6, "GetOutgoingBlob");
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001A080 File Offset: 0x00018280
		private string GetClientSpecifiedSpn()
		{
			bool isCompleted;
			if (this._securityContext != null)
			{
				isCompleted = this._isCompleted;
				if (isCompleted)
				{
					goto IL_0025;
				}
			}
			if (!isCompleted)
			{
			}
			NetEventSource.Fail(this, "Trying to get the client SPN before handshaking is done!", "GetClientSpecifiedSpn");
			IL_0025:
			string text = global::System.Net.Security.NegotiateStreamPal.QueryContextClientSpecifiedSpn(this._securityContext);
			bool isEnabled = NetEventSource.IsEnabled;
			if (text == null || text != null)
			{
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "GetClientSpecifiedSpn");
				return text;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000584 RID: 1412
		private bool _isServer;

		// Token: 0x04000585 RID: 1413
		private global::System.Net.Security.SafeFreeCredentials _credentialsHandle;

		// Token: 0x04000586 RID: 1414
		private global::System.Net.Security.SafeDeleteContext _securityContext;

		// Token: 0x04000587 RID: 1415
		private string _spn;

		// Token: 0x04000588 RID: 1416
		private int _tokenSize;

		// Token: 0x04000589 RID: 1417
		private ContextFlagsPal _requestedContextFlags;

		// Token: 0x0400058A RID: 1418
		private ContextFlagsPal _contextFlags;

		// Token: 0x0400058B RID: 1419
		private bool _isCompleted;

		// Token: 0x0400058C RID: 1420
		private string _package;

		// Token: 0x0400058D RID: 1421
		private string _lastProtocolName;

		// Token: 0x0400058E RID: 1422
		private string _protocolName;

		// Token: 0x0400058F RID: 1423
		private string _clientSpecifiedSpn;

		// Token: 0x04000590 RID: 1424
		private global::System.Security.Authentication.ExtendedProtection.ChannelBinding _channelBinding;
	}
}
