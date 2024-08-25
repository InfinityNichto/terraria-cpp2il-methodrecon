using System;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B3 RID: 179
	internal sealed class RegexBoyerMoore
	{
		// Token: 0x06000388 RID: 904 RVA: 0x0000C37C File Offset: 0x0000A57C
		public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(pattern._stringLength);
			int stringLength = pattern._stringLength;
			long num = 0L;
			char c = pattern[(int)num];
			int stringLength2 = pattern._stringLength;
			string stringAndRelease = StringBuilderCache.GetStringAndRelease(stringBuilder);
			this.Pattern = stringAndRelease;
			this._culture = culture;
			int stringLength3 = stringAndRelease._stringLength;
			char c2 = stringAndRelease[rightToLeft ? 1 : 0];
			int[] positive = this.Positive;
			char c3 = stringAndRelease[(int)num];
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000C488 File Offset: 0x0000A688
		private bool MatchPattern(string text, int index)
		{
			/*
An exception occurred when decompiling this method (06000389)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexBoyerMoore::MatchPattern(System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0056:
	stloc:string(var_11_5C, ldfld:string(RegexBoyerMoore::Pattern, ldloc:RegexBoyerMoore(this)))
	stloc:int64(var_12_5F, ldc.i4:int64(0))
	stloc:int32(var_13_68, ldfld:int32(string::_stringLength, ldloc:string(var_11_5C)))
	stloc:int32(var_14_77, call:int32(string::CompareOrdinal, ldloc:string(var_11_5C), ldloc:int64[exp:int32](var_12_5F), ldloc:string(text), ldloc:int32(index), ldloc:int32(var_13_68)))
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

		// Token: 0x0600038A RID: 906 RVA: 0x0000C510 File Offset: 0x0000A710
		public bool IsMatch(string text, int index, int beglimit, int endlimit)
		{
			if (this.RightToLeft)
			{
				int stringLength = this.Pattern._stringLength;
				return this.MatchPattern(text, index);
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000C540 File Offset: 0x0000A740
		public int Scan(string text, int index, int beglimit, int endlimit)
		{
			/*
An exception occurred when decompiling this method (0600038B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexBoyerMoore::Scan(System.String,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00A5:
	stloc:bool(var_16_AB, ldfld:bool(RegexBoyerMoore::RightToLeft, ldloc:RegexBoyerMoore(this)))
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

		// Token: 0x040002CC RID: 716
		public readonly int[] Positive;

		// Token: 0x040002CD RID: 717
		public readonly int[] NegativeASCII;

		// Token: 0x040002CE RID: 718
		public readonly int[][] NegativeUnicode;

		// Token: 0x040002CF RID: 719
		public readonly string Pattern;

		// Token: 0x040002D0 RID: 720
		public readonly int LowASCII;

		// Token: 0x040002D1 RID: 721
		public readonly int HighASCII;

		// Token: 0x040002D2 RID: 722
		public readonly bool RightToLeft;

		// Token: 0x040002D3 RID: 723
		public readonly bool CaseInsensitive;

		// Token: 0x040002D4 RID: 724
		private readonly CultureInfo _culture;
	}
}
