using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002F5 RID: 757
	[ComVisible(true)]
	public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x060019A6 RID: 6566 RVA: 0x00037308 File Offset: 0x00035508
		public RSAOAEPKeyExchangeDeformatter()
		{
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0003731C File Offset: 0x0003551C
		public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
			do
			{
				base..ctor();
			}
			while (key == null);
			this._rsaKey = key;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x00037340 File Offset: 0x00035540
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x00037350 File Offset: 0x00035550
		public override string Parameters
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00037360 File Offset: 0x00035560
		public override byte[] DecryptKeyExchange(byte[] rgbData)
		{
			/*
An exception occurred when decompiling this method (060019AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter::DecryptKeyExchange(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0027:
	stloc:string(var_5_31, call:string(Environment::GetResourceString, ldstr:string("No asymmetric key object has been associated with this formatter object.")))
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

		// Token: 0x060019AB RID: 6571 RVA: 0x000373A0 File Offset: 0x000355A0
		public override void SetKey(AsymmetricAlgorithm key)
		{
			while (key == null)
			{
			}
			this._rsaKey = key;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x000373C0 File Offset: 0x000355C0
		private bool OverridesDecrypt
		{
			get
			{
				if (this._rsaOverridesDecrypt == null)
				{
					RSA rsaKey = this._rsaKey;
					Type type;
					Type type2;
					if ((type != null && type == null) || type2 == null || type2 != null)
					{
					}
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x04000D07 RID: 3335
		private RSA _rsaKey;

		// Token: 0x04000D08 RID: 3336
		private bool? _rsaOverridesDecrypt;
	}
}
