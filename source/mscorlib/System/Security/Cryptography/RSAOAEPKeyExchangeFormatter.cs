using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002F6 RID: 758
	[ComVisible(true)]
	public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		// Token: 0x060019AD RID: 6573 RVA: 0x000373F0 File Offset: 0x000355F0
		public RSAOAEPKeyExchangeFormatter()
		{
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00037404 File Offset: 0x00035604
		public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key)
		{
			do
			{
				base..ctor();
			}
			while (key == null);
			this._rsaKey = key;
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x00037428 File Offset: 0x00035628
		// (set) Token: 0x060019B0 RID: 6576 RVA: 0x00037448 File Offset: 0x00035648
		public byte[] Parameter
		{
			get
			{
				object obj;
				if (this.ParameterValue == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				object obj;
				if (value != null && obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					this.ParameterValue = obj;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x00037474 File Offset: 0x00035674
		public override string Parameters
		{
			get
			{
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x00037484 File Offset: 0x00035684
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x00037498 File Offset: 0x00035698
		public RandomNumberGenerator Rng
		{
			get
			{
				return this.RngValue;
			}
			set
			{
				this.RngValue = value;
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000374AC File Offset: 0x000356AC
		public override void SetKey(AsymmetricAlgorithm key)
		{
			while (key == null)
			{
			}
			this._rsaKey = key;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000374CC File Offset: 0x000356CC
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			/*
An exception occurred when decompiling this method (060019B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.RSAOAEPKeyExchangeFormatter::CreateKeyExchange(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0031:
	stloc:string(var_7_3B, call:string(Environment::GetResourceString, ldstr:string("No asymmetric key object has been associated with this formatter object.")))
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

		// Token: 0x060019B6 RID: 6582 RVA: 0x0000207A File Offset: 0x0000027A
		public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00037518 File Offset: 0x00035718
		private bool OverridesEncrypt
		{
			get
			{
				if (this._rsaOverridesEncrypt == null)
				{
					RSA rsaKey = this._rsaKey;
					Type type;
					if (type != null)
					{
					}
					Type type2;
					if (type2 == null || type2 != null)
					{
					}
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x04000D09 RID: 3337
		private byte[] ParameterValue;

		// Token: 0x04000D0A RID: 3338
		private RSA _rsaKey;

		// Token: 0x04000D0B RID: 3339
		private bool? _rsaOverridesEncrypt;

		// Token: 0x04000D0C RID: 3340
		private RandomNumberGenerator RngValue;
	}
}
