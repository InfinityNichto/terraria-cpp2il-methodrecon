using System;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Security
{
	// Token: 0x02000318 RID: 792
	internal sealed class SafeFreeNegoCredentials : SafeFreeCredentials
	{
		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0003E8A4 File Offset: 0x0003CAA4
		public Microsoft.Win32.SafeHandles.SafeGssCredHandle GssCredential
		{
			get
			{
				return this._credential;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0003E8B8 File Offset: 0x0003CAB8
		public bool IsNtlmOnly
		{
			get
			{
				return this._isNtlmOnly;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0003E8CC File Offset: 0x0003CACC
		public string UserName
		{
			get
			{
				return this._userName;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0003E8E0 File Offset: 0x0003CAE0
		public bool IsDefault
		{
			get
			{
				return this._isDefault;
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0003E8F4 File Offset: 0x0003CAF4
		public SafeFreeNegoCredentials(bool isNtlmOnly, string username, string password, string domain)
		{
			int num = 1;
			base..ctor(1073741824, num != 0);
			int num2 = 92;
			int num3 = username.IndexOf((char)num2);
			int num4 = 92;
			int num5 = username.IndexOf((char)num4, 1073741824);
			bool flag = string.IsNullOrEmpty(domain);
			long num6 = 0L;
			string text = username.Substring((int)num6, num3);
			string text2 = username.Substring(1073741824);
			string text3;
			if (text != null)
			{
				text3 = text.Trim();
			}
			string text4 = text2.Trim();
			int num7 = 64;
			int num8 = text4.IndexOf((char)num7);
			bool flag2 = string.IsNullOrEmpty(text3);
			string text5 = text4 + "@" + text3;
			this._isNtlmOnly = 1073741824 != 0;
			this._userName = text5;
			bool flag3 = string.IsNullOrEmpty(text5);
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0003E9C8 File Offset: 0x0003CBC8
		public override bool IsInvalid
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600149C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Security.SafeFreeNegoCredentials::get_IsInvalid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SafeGssCredHandle(var_0_06, ldfld:SafeGssCredHandle(SafeFreeNegoCredentials::_credential, ldloc:SafeFreeNegoCredentials(this)))
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

		// Token: 0x0600149D RID: 5277 RVA: 0x0003E9DC File Offset: 0x0003CBDC
		protected override bool ReleaseHandle()
		{
			this._credential.DangerousRelease();
			return true;
		}

		// Token: 0x04001135 RID: 4405
		private Microsoft.Win32.SafeHandles.SafeGssCredHandle _credential;

		// Token: 0x04001136 RID: 4406
		private readonly bool _isNtlmOnly;

		// Token: 0x04001137 RID: 4407
		private readonly string _userName;

		// Token: 0x04001138 RID: 4408
		private readonly bool _isDefault;
	}
}
