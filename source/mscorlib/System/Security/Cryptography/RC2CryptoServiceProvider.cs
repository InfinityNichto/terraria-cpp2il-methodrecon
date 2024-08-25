using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002EB RID: 747
	[ComVisible(true)]
	public sealed class RC2CryptoServiceProvider : RC2
	{
		// Token: 0x06001914 RID: 6420 RVA: 0x00035B88 File Offset: 0x00033D88
		public RC2CryptoServiceProvider()
		{
			if (!true)
			{
			}
			base..ctor();
			if (!true)
			{
			}
			bool allowOnlyFipsAlgorithms = CryptoConfig.AllowOnlyFipsAlgorithms;
			long num = 0L;
			bool flag = Utils.HasAlgorithm(26114, (int)num);
			this.FeedbackSizeValue = 8;
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00035BD8 File Offset: 0x00033DD8
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x00035BEC File Offset: 0x00033DEC
		public override int EffectiveKeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				int keySizeValue = this.KeySizeValue;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x00035C0C File Offset: 0x00033E0C
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x00035C20 File Offset: 0x00033E20
		[ComVisible(false)]
		public bool UseSalt
		{
			get
			{
				return this.m_use40bitSalt;
			}
			set
			{
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00035C30 File Offset: 0x00033E30
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			/*
An exception occurred when decompiling this method (06001919)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.ICryptoTransform System.Security.Cryptography.RC2CryptoServiceProvider::CreateEncryptor(System.Byte[],System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:bool(RC2CryptoServiceProvider::m_use40bitSalt, ldloc:RC2CryptoServiceProvider(this)))
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

		// Token: 0x0600191A RID: 6426 RVA: 0x00035C44 File Offset: 0x00033E44
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			while (this.m_use40bitSalt)
			{
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00035C5C File Offset: 0x00033E5C
		public override void GenerateKey()
		{
			if (this.KeySizeValue == 0)
			{
			}
			RNGCryptoServiceProvider staticRandomNumberGenerator = Utils.StaticRandomNumberGenerator;
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00035C7C File Offset: 0x00033E7C
		public override void GenerateIV()
		{
			if (!true)
			{
			}
			RNGCryptoServiceProvider staticRandomNumberGenerator = Utils.StaticRandomNumberGenerator;
			byte[] ivvalue = this.IVValue;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00035C9C File Offset: 0x00033E9C
		// Note: this type is marked as 'beforefieldinit'.
		static RC2CryptoServiceProvider()
		{
		}

		// Token: 0x04000CD2 RID: 3282
		private bool m_use40bitSalt;

		// Token: 0x04000CD3 RID: 3283
		private static KeySizes[] s_legalKeySizes;
	}
}
