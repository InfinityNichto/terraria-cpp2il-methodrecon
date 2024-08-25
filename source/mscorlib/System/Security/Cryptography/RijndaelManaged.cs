using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002ED RID: 749
	[ComVisible(true)]
	public sealed class RijndaelManaged : Rijndael
	{
		// Token: 0x06001922 RID: 6434 RVA: 0x00035D04 File Offset: 0x00033F04
		public RijndaelManaged()
		{
			if (!true)
			{
			}
			base..ctor();
			if (!true)
			{
			}
			bool allowOnlyFipsAlgorithms = CryptoConfig.AllowOnlyFipsAlgorithms;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00035D30 File Offset: 0x00033F30
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			CipherMode modeValue = this.ModeValue;
			int feedbackSizeValue = this.FeedbackSizeValue;
			ICryptoTransform cryptoTransform;
			return cryptoTransform;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00035D4C File Offset: 0x00033F4C
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			CipherMode modeValue = this.ModeValue;
			int feedbackSizeValue = this.FeedbackSizeValue;
			return this.NewEncryptor(rgbKey, modeValue, rgbIV, feedbackSizeValue, RijndaelManagedTransformMode.Decrypt);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00035D74 File Offset: 0x00033F74
		public override void GenerateKey()
		{
			int num = 1;
			int keySizeValue = this.KeySizeValue;
			if (num == 0)
			{
			}
			byte[] array = Utils.GenerateRandom(0);
			this.KeyValue = array;
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00035D9C File Offset: 0x00033F9C
		public override void GenerateIV()
		{
			int num = 1;
			int blockSizeValue = this.BlockSizeValue;
			if (num == 0)
			{
			}
			byte[] array = Utils.GenerateRandom(0);
			this.IVValue = array;
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00035DC4 File Offset: 0x00033FC4
		private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode)
		{
			/*
An exception occurred when decompiling this method (06001927)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.ICryptoTransform System.Security.Cryptography.RijndaelManaged::NewEncryptor(System.Byte[],System.Security.Cryptography.CipherMode,System.Byte[],System.Int32,System.Security.Cryptography.RijndaelManagedTransformMode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002B:
	stloc:int32(var_5_31, ldfld:int32(SymmetricAlgorithm::BlockSizeValue, ldloc:RijndaelManaged[exp:SymmetricAlgorithm](this)))
	stloc:PaddingMode(var_6_39, ldfld:PaddingMode(SymmetricAlgorithm::PaddingValue, ldloc:RijndaelManaged[exp:SymmetricAlgorithm](this)))
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
}
