using System;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000041 RID: 65
	public class Type3Message : MessageBase
	{
		// Token: 0x060001DE RID: 478 RVA: 0x000086C0 File Offset: 0x000068C0
		public Type3Message(Type2Message type2)
		{
			if (!true)
			{
			}
			base..ctor();
			this._type = 3;
			this._type2 = type2;
			if (3 == 0)
			{
			}
			if (!true)
			{
			}
			this._level = NtlmAuthLevel.LM_and_NTLM_and_try_NTLMv2_Session;
			byte[] nonce = type2.Nonce;
			object obj;
			if (obj != null)
			{
				if (obj != null)
				{
					this._challenge = obj;
					if (obj != null)
					{
						goto IL_0041;
					}
				}
				throw new InvalidCastException();
			}
			IL_0041:
			string targetName = type2._targetName;
			this._domain = targetName;
			string machineName = Environment.MachineName;
			this._host = machineName;
			string userName = Environment.UserName;
			this._username = userName;
			this._flags = NtlmFlags.NegotiateNtlm | NtlmFlags.NegotiateAlwaysSign;
			NtlmFlags flags = type2._flags;
			if (33280 != 0)
			{
				this._flags = NtlmFlags.NegotiateUnicode | NtlmFlags.NegotiateNtlm | NtlmFlags.NegotiateAlwaysSign;
				return;
			}
			NtlmFlags flags2 = this._flags;
			this._flags = flags2;
			if (flags2 == (NtlmFlags)0)
			{
			}
			NtlmFlags flags3 = this._flags;
			this._flags = flags3;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000878C File Offset: 0x0000698C
		protected override void Finalize()
		{
			if (this._challenge != null)
			{
			}
			if (this._lm != null)
			{
			}
			if (this._nt != null)
			{
			}
			base.Finalize();
		}

		// Token: 0x1700008B RID: 139
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000087DC File Offset: 0x000069DC
		public string Domain
		{
			set
			{
				bool flag = value == "";
				NtlmFlags flags = this._flags;
				this._domain = value;
				this._flags = flags;
			}
		}

		// Token: 0x1700008C RID: 140
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000880C File Offset: 0x00006A0C
		public string Password
		{
			set
			{
				this._password = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00008820 File Offset: 0x00006A20
		public string Username
		{
			set
			{
				this._username = value;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00008834 File Offset: 0x00006A34
		protected override void Decode(byte[] message)
		{
			base.Decode(message);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000890C File Offset: 0x00006B0C
		private string DecodeString(byte[] buffer, int offset, int len)
		{
			/*
An exception occurred when decompiling this method (060001E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Mono.Security.Protocol.Ntlm.Type3Message::DecodeString(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NtlmFlags(var_0_06, ldfld:NtlmFlags(MessageBase::_flags, ldloc:Type3Message[exp:MessageBase](this)))
	stloc:Encoding(var_2_0E, callgetter:Encoding(Encoding::get_ASCII))
	stloc:Encoding(var_3_14, callgetter:Encoding(Encoding::get_Unicode))
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

		// Token: 0x060001E5 RID: 485 RVA: 0x00008930 File Offset: 0x00006B30
		private byte[] EncodeString(string text)
		{
			/*
An exception occurred when decompiling this method (060001E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Protocol.Ntlm.Type3Message::EncodeString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:Encoding(var_5_1C, callgetter:Encoding(Encoding::get_Unicode))
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

		// Token: 0x060001E6 RID: 486 RVA: 0x0000895C File Offset: 0x00006B5C
		public override byte[] GetBytes()
		{
			string domain = this._domain;
			byte[] array = this.EncodeString(domain);
			string username = this._username;
			byte[] array2 = this.EncodeString(username);
			string host = this._host;
			byte[] array3 = this.EncodeString(host);
			Type2Message type = this._type2;
			if (type != null)
			{
				NtlmAuthLevel level = this._level;
				string domain2 = this._domain;
				string username2 = this._username;
				string password = this._password;
				if (type == null)
				{
					goto IL_0081;
				}
				byte[] nonce = type._nonce;
			}
			if (this._level != NtlmAuthLevel.LM_and_NTLM)
			{
				throw new OutOfMemoryException();
			}
			string password2 = this._password;
			byte[] challenge = this._challenge;
			IL_0081:
			byte[] array4 = base.PrepareMessage(42176280);
			NtlmFlags flags = this._flags;
			byte[] array5;
			if (array5 != null)
			{
			}
			return array4;
		}

		// Token: 0x040000EE RID: 238
		private NtlmAuthLevel _level;

		// Token: 0x040000EF RID: 239
		private byte[] _challenge;

		// Token: 0x040000F0 RID: 240
		private string _host;

		// Token: 0x040000F1 RID: 241
		private string _domain;

		// Token: 0x040000F2 RID: 242
		private string _username;

		// Token: 0x040000F3 RID: 243
		private string _password;

		// Token: 0x040000F4 RID: 244
		private Type2Message _type2;

		// Token: 0x040000F5 RID: 245
		private byte[] _lm;

		// Token: 0x040000F6 RID: 246
		private byte[] _nt;
	}
}
