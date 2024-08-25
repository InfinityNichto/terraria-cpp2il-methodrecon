using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002EA RID: 746
	[ComVisible(true)]
	public abstract class RC2 : SymmetricAlgorithm
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x00035AB0 File Offset: 0x00033CB0
		protected RC2()
		{
			this.KeySizeValue = 128;
			if (128 == 0)
			{
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x00035AD8 File Offset: 0x00033CD8
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x00035AEC File Offset: 0x00033CEC
		public virtual int EffectiveKeySize
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600190D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.RC2::get_EffectiveKeySize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RC2::EffectiveKeySizeValue, ldloc:RC2(this)))
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
				int keySizeValue = this.KeySizeValue;
				if (value != 0)
				{
					bool flag = base.ValidKeySize(value);
				}
				this.EffectiveKeySizeValue = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00035B20 File Offset: 0x00033D20
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x00035B34 File Offset: 0x00033D34
		public override int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				int effectiveKeySizeValue = this.EffectiveKeySizeValue;
				base.KeySize = value;
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0000207A File Offset: 0x0000027A
		public new static RC2 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00035B5C File Offset: 0x00033D5C
		public new static RC2 Create(string AlgName)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00035B74 File Offset: 0x00033D74
		// Note: this type is marked as 'beforefieldinit'.
		static RC2()
		{
		}

		// Token: 0x04000CCF RID: 3279
		protected int EffectiveKeySizeValue;

		// Token: 0x04000CD0 RID: 3280
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000CD1 RID: 3281
		private static KeySizes[] s_legalKeySizes;
	}
}
