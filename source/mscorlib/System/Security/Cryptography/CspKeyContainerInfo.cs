using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Cryptography
{
	// Token: 0x02000310 RID: 784
	[ComVisible(true)]
	public sealed class CspKeyContainerInfo
	{
		// Token: 0x06001A83 RID: 6787 RVA: 0x000391E0 File Offset: 0x000373E0
		public CspKeyContainerInfo(CspParameters parameters)
		{
			this._params = parameters;
			this._random = true;
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00039204 File Offset: 0x00037404
		public bool Accessible
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00039214 File Offset: 0x00037414
		public CryptoKeySecurity CryptoKeySecurity
		{
			get
			{
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x00039224 File Offset: 0x00037424
		public bool Exportable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00039234 File Offset: 0x00037434
		public bool HardwareDevice
		{
			get
			{
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00039244 File Offset: 0x00037444
		public string KeyContainerName
		{
			get
			{
				return this._params.KeyContainerName;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0003925C File Offset: 0x0003745C
		public KeyNumber KeyNumber
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A89)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.KeyNumber System.Security.Cryptography.CspKeyContainerInfo::get_KeyNumber()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(CspParameters::KeyNumber, ldfld:CspParameters(CspKeyContainerInfo::_params, ldloc:CspKeyContainerInfo(this))))
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

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x00039274 File Offset: 0x00037474
		public bool MachineKeyStore
		{
			get
			{
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00039284 File Offset: 0x00037484
		public bool Protected
		{
			get
			{
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00039294 File Offset: 0x00037494
		public string ProviderName
		{
			get
			{
				return this._params.ProviderName;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x000392AC File Offset: 0x000374AC
		public int ProviderType
		{
			get
			{
				return this._params.ProviderType;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x000392C4 File Offset: 0x000374C4
		public bool RandomlyGenerated
		{
			get
			{
				return this._random;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000392D8 File Offset: 0x000374D8
		public bool Removable
		{
			get
			{
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x000392E8 File Offset: 0x000374E8
		public string UniqueKeyContainerName
		{
			get
			{
				CspParameters @params = this._params;
				string providerName = @params.ProviderName;
				string keyContainerName = @params.KeyContainerName;
				return providerName + "\\" + keyContainerName;
			}
		}

		// Token: 0x04000D83 RID: 3459
		private CspParameters _params;

		// Token: 0x04000D84 RID: 3460
		internal bool _random;
	}
}
