using System;

namespace System.Security.Cryptography
{
	// Token: 0x020002C1 RID: 705
	public sealed class RSASignaturePadding : IEquatable<RSASignaturePadding>
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x00033740 File Offset: 0x00031940
		private RSASignaturePadding(RSASignaturePaddingMode mode)
		{
			this._mode = mode;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0003375C File Offset: 0x0003195C
		public static RSASignaturePadding Pkcs1
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x00033770 File Offset: 0x00031970
		public static RSASignaturePadding Pss
		{
			get
			{
				/*
An exception occurred when decompiling this method (060017EB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.RSASignaturePadding System.Security.Cryptography.RSASignaturePadding::get_Pss()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x00033780 File Offset: 0x00031980
		public RSASignaturePaddingMode Mode
		{
			get
			{
				return this._mode;
			}
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00033794 File Offset: 0x00031994
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x000337A4 File Offset: 0x000319A4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x000337B8 File Offset: 0x000319B8
		public bool Equals(RSASignaturePadding other)
		{
			if (!true)
			{
			}
			RSASignaturePaddingMode mode = this._mode;
			RSASignaturePaddingMode mode2 = other._mode;
			bool flag;
			return flag;
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000337DC File Offset: 0x000319DC
		public static bool operator ==(RSASignaturePadding left, RSASignaturePadding right)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x000337EC File Offset: 0x000319EC
		public static bool operator !=(RSASignaturePadding left, RSASignaturePadding right)
		{
			bool flag;
			if (true)
			{
				return flag;
			}
			return flag;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00033800 File Offset: 0x00031A00
		public override string ToString()
		{
			RSASignaturePaddingMode mode = this._mode;
			string text;
			return text;
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00033818 File Offset: 0x00031A18
		// Note: this type is marked as 'beforefieldinit'.
		static RSASignaturePadding()
		{
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00033828 File Offset: 0x00031A28
		internal RSASignaturePadding()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000C6F RID: 3183
		private static readonly RSASignaturePadding s_pkcs1;

		// Token: 0x04000C70 RID: 3184
		private static readonly RSASignaturePadding s_pss;

		// Token: 0x04000C71 RID: 3185
		private readonly RSASignaturePaddingMode _mode;
	}
}
