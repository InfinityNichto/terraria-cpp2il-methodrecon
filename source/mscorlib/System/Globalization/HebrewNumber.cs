using System;

namespace System.Globalization
{
	// Token: 0x02000593 RID: 1427
	internal class HebrewNumber
	{
		// Token: 0x06002B20 RID: 11040 RVA: 0x0005E4C0 File Offset: 0x0005C6C0
		internal static string ToString(int Number)
		{
			int num = 1514;
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x0005E4FC File Offset: 0x0005C6FC
		internal static HebrewNumberParsingState ParseByChar(char ch, HebrewNumberParsingContext context)
		{
			int num = 1;
			if (num == 0)
			{
			}
			ch.m_value = (char)num;
			if (2 == 0)
			{
				return;
			}
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x0005E51C File Offset: 0x0005C71C
		internal static bool IsDigit(char ch)
		{
			/*
An exception occurred when decompiling this method (06002B22)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.HebrewNumber::IsDigit(System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002B23 RID: 11043 RVA: 0x0005E530 File Offset: 0x0005C730
		// Note: this type is marked as 'beforefieldinit'.
		static HebrewNumber()
		{
		}

		// Token: 0x0400177D RID: 6013
		private static readonly HebrewNumber.HebrewValue[] s_hebrewValues;

		// Token: 0x0400177E RID: 6014
		private static char s_maxHebrewNumberCh;

		// Token: 0x0400177F RID: 6015
		private static readonly HebrewNumber.HS[] s_numberPasingState;

		// Token: 0x02000594 RID: 1428
		private enum HebrewToken : short
		{
			// Token: 0x04001781 RID: 6017
			Invalid = -1,
			// Token: 0x04001782 RID: 6018
			Digit400,
			// Token: 0x04001783 RID: 6019
			Digit200_300,
			// Token: 0x04001784 RID: 6020
			Digit100,
			// Token: 0x04001785 RID: 6021
			Digit10,
			// Token: 0x04001786 RID: 6022
			Digit1,
			// Token: 0x04001787 RID: 6023
			Digit6_7,
			// Token: 0x04001788 RID: 6024
			Digit7,
			// Token: 0x04001789 RID: 6025
			Digit9,
			// Token: 0x0400178A RID: 6026
			SingleQuote,
			// Token: 0x0400178B RID: 6027
			DoubleQuote
		}

		// Token: 0x02000595 RID: 1429
		private struct HebrewValue
		{
			// Token: 0x06002B24 RID: 11044 RVA: 0x0005E548 File Offset: 0x0005C748
			internal HebrewValue(HebrewNumber.HebrewToken token, short value)
			{
				this.token = token;
				this.value = value;
			}

			// Token: 0x0400178C RID: 6028
			internal HebrewNumber.HebrewToken token;

			// Token: 0x0400178D RID: 6029
			internal short value;
		}

		// Token: 0x02000596 RID: 1430
		internal enum HS : sbyte
		{
			// Token: 0x0400178F RID: 6031
			_err = -1,
			// Token: 0x04001790 RID: 6032
			Start,
			// Token: 0x04001791 RID: 6033
			S400,
			// Token: 0x04001792 RID: 6034
			S400_400,
			// Token: 0x04001793 RID: 6035
			S400_X00,
			// Token: 0x04001794 RID: 6036
			S400_X0,
			// Token: 0x04001795 RID: 6037
			X00_DQ,
			// Token: 0x04001796 RID: 6038
			S400_X00_X0,
			// Token: 0x04001797 RID: 6039
			X0_DQ,
			// Token: 0x04001798 RID: 6040
			X,
			// Token: 0x04001799 RID: 6041
			X0,
			// Token: 0x0400179A RID: 6042
			X00,
			// Token: 0x0400179B RID: 6043
			S400_DQ,
			// Token: 0x0400179C RID: 6044
			S400_400_DQ,
			// Token: 0x0400179D RID: 6045
			S400_400_100,
			// Token: 0x0400179E RID: 6046
			S9,
			// Token: 0x0400179F RID: 6047
			X00_S9,
			// Token: 0x040017A0 RID: 6048
			S9_DQ,
			// Token: 0x040017A1 RID: 6049
			END = 100
		}
	}
}
