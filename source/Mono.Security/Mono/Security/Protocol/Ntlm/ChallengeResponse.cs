using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000039 RID: 57
	[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
	public class ChallengeResponse : IDisposable
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public ChallengeResponse()
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007DFC File Offset: 0x00005FFC
		public ChallengeResponse(string password, byte[] challenge)
		{
			this.Password = password;
			this.Challenge = challenge;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007E18 File Offset: 0x00006018
		protected override void Finalize()
		{
			if (!this._disposed)
			{
				this.Dispose();
			}
			base.Finalize();
		}

		// Token: 0x1700007F RID: 127
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00007E5C File Offset: 0x0000605C
		public string Password
		{
			set
			{
				while (this._disposed)
				{
				}
				DES des = DES.Create();
				if (value != null)
				{
					int stringLength = value._stringLength;
					long num = 0L;
					byte[] array = this.PasswordToKey(value, (int)num);
					byte[] lmpwd = this._lmpwd;
					return;
				}
				byte[] lmpwd2 = this._lmpwd;
				if (value == null)
				{
					return;
				}
				int stringLength2 = value._stringLength;
				int num2 = 7;
				byte[] array2 = this.PasswordToKey(value, num2);
				byte[] lmpwd3 = this._lmpwd;
			}
		}

		// Token: 0x17000080 RID: 128
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00007F10 File Offset: 0x00006110
		public byte[] Challenge
		{
			set
			{
				if (value != null)
				{
					if (!this._disposed)
					{
						object obj;
						if (obj == null)
						{
							return;
						}
						if (obj != null)
						{
							this._challenge = obj;
							throw new InvalidCastException();
						}
					}
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00007F44 File Offset: 0x00006144
		public byte[] LM
		{
			get
			{
				while (this._disposed)
				{
				}
				byte[] lmpwd = this._lmpwd;
				return this.GetResponse(lmpwd);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00007F68 File Offset: 0x00006168
		public byte[] NT
		{
			get
			{
				while (this._disposed)
				{
				}
				byte[] ntpwd = this._ntpwd;
				return this.GetResponse(ntpwd);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00007F8C File Offset: 0x0000618C
		public void Dispose()
		{
			long num = 0L;
			this.Dispose(num != 0L);
			if (!true)
			{
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007FAC File Offset: 0x000061AC
		private void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				byte[] lmpwd = this._lmpwd;
				byte[] ntpwd = this._ntpwd;
				if (this._challenge != null)
				{
				}
				this._disposed = true;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00007FE0 File Offset: 0x000061E0
		private byte[] GetResponse(byte[] pwd)
		{
			/*
An exception occurred when decompiling this method (060001B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Protocol.Ntlm.ChallengeResponse::GetResponse(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DES(var_2_0A, call:DES(DES::Create))
	stloc:uint8[](var_5_13, ldfld:uint8[](ChallengeResponse::_challenge, ldloc:ChallengeResponse(this)))
	stloc:uint8[](var_8_1E, ldfld:uint8[](ChallengeResponse::_challenge, ldloc:ChallengeResponse(this)))
	stloc:uint8[](var_11_2A, ldfld:uint8[](ChallengeResponse::_challenge, ldloc:ChallengeResponse(this)))
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

		// Token: 0x060001BA RID: 442 RVA: 0x00008018 File Offset: 0x00006218
		private byte[] PrepareDESKey(byte[] key56bits, int position)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00008028 File Offset: 0x00006228
		private byte[] PasswordToKey(string password, int position)
		{
			int stringLength = password._stringLength;
			int num = 7;
			int num2 = Math.Min(0, num);
			Encoding ascii = Encoding.ASCII;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text = password.ToUpper(currentCulture);
			byte[] array;
			return array;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00008068 File Offset: 0x00006268
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeResponse()
		{
		}

		// Token: 0x040000CD RID: 205
		private static byte[] magic;

		// Token: 0x040000CE RID: 206
		private static byte[] nullEncMagic;

		// Token: 0x040000CF RID: 207
		private bool _disposed;

		// Token: 0x040000D0 RID: 208
		private byte[] _challenge;

		// Token: 0x040000D1 RID: 209
		private byte[] _lmpwd;

		// Token: 0x040000D2 RID: 210
		private byte[] _ntpwd;
	}
}
