using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Cryptography
{
	// Token: 0x020002D2 RID: 722
	[ComVisible(true)]
	public sealed class CspParameters
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00033FD0 File Offset: 0x000321D0
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x00033FE4 File Offset: 0x000321E4
		public CspProviderFlags Flags
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001851)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.CspProviderFlags System.Security.Cryptography.CspParameters::get_Flags()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CspParameters::m_flags, ldloc:CspParameters(this)))
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
			set
			{
				this.m_flags = (int)value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x00034000 File Offset: 0x00032200
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x00034014 File Offset: 0x00032214
		public CryptoKeySecurity CryptoKeySecurity
		{
			get
			{
				return this.m_cryptoKeySecurity;
			}
			set
			{
				this.m_cryptoKeySecurity = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00034028 File Offset: 0x00032228
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x0003403C File Offset: 0x0003223C
		public SecureString KeyPassword
		{
			get
			{
				return this.m_keyPassword;
			}
			set
			{
				this.m_keyPassword = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x00034050 File Offset: 0x00032250
		// (set) Token: 0x06001858 RID: 6232 RVA: 0x00034064 File Offset: 0x00032264
		public IntPtr ParentWindowHandle
		{
			get
			{
				return this.m_parentWindowHandle;
			}
			set
			{
				this.m_parentWindowHandle = value;
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00034078 File Offset: 0x00032278
		public CspParameters()
		{
			this.ProviderType = 1;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00034094 File Offset: 0x00032294
		public CspParameters(int dwTypeIn)
		{
			this.ProviderType = dwTypeIn;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000340B0 File Offset: 0x000322B0
		public CspParameters(int dwTypeIn, string strProviderNameIn)
		{
			this.ProviderType = dwTypeIn;
			this.ProviderName = strProviderNameIn;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000340D4 File Offset: 0x000322D4
		public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
		{
			this.ProviderType = dwTypeIn;
			this.ProviderName = strProviderNameIn;
			this.KeyContainerName = strContainerNameIn;
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x000340FC File Offset: 0x000322FC
		public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword)
		{
			this.ProviderType = providerType;
			this.ProviderName = providerName;
			this.KeyContainerName = keyContainerName;
			this.m_cryptoKeySecurity = cryptoKeySecurity;
			this.m_keyPassword = keyPassword;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00034134 File Offset: 0x00032334
		public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, IntPtr parentWindowHandle)
		{
			this.ProviderType = providerType;
			this.ProviderName = providerName;
			this.KeyContainerName = keyContainerName;
			this.m_cryptoKeySecurity = cryptoKeySecurity;
			this.m_parentWindowHandle = parentWindowHandle;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0003416C File Offset: 0x0003236C
		internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
		{
			this.ProviderType = providerType;
			this.ProviderName = providerName;
			this.KeyContainerName = keyContainerName;
			this.Flags = flags;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0003419C File Offset: 0x0003239C
		internal CspParameters(CspParameters parameters)
		{
			int providerType = parameters.ProviderType;
			this.ProviderType = providerType;
			int keyNumber = parameters.KeyNumber;
			this.KeyNumber = keyNumber;
			int flags = parameters.m_flags;
			CryptoKeySecurity cryptoKeySecurity = parameters.m_cryptoKeySecurity;
			this.m_cryptoKeySecurity = cryptoKeySecurity;
			IntPtr parentWindowHandle = parameters.m_parentWindowHandle;
			this.m_parentWindowHandle = parentWindowHandle;
		}

		// Token: 0x04000C9B RID: 3227
		public int ProviderType;

		// Token: 0x04000C9C RID: 3228
		public string ProviderName;

		// Token: 0x04000C9D RID: 3229
		public string KeyContainerName;

		// Token: 0x04000C9E RID: 3230
		public int KeyNumber;

		// Token: 0x04000C9F RID: 3231
		private int m_flags;

		// Token: 0x04000CA0 RID: 3232
		private CryptoKeySecurity m_cryptoKeySecurity;

		// Token: 0x04000CA1 RID: 3233
		private SecureString m_keyPassword;

		// Token: 0x04000CA2 RID: 3234
		private IntPtr m_parentWindowHandle;
	}
}
