using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x0200058C RID: 1420
	internal class DateTimeFormatInfoScanner
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x0000207A File Offset: 0x0000027A
		private static Dictionary<string, string> KnownWords
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x0005E118 File Offset: 0x0005C318
		internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
		{
			/*
An exception occurred when decompiling this method (06002B0B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.DateTimeFormatInfoScanner::SkipWhiteSpacesAndNonLetter(System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_2_09, call:bool(char::IsLetter, ldloc:char(var_1)))
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

		// Token: 0x06002B0C RID: 11020 RVA: 0x0000207A File Offset: 0x0000027A
		internal void AddDateWordOrPostfix(string formatPostfix, string str)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0005E130 File Offset: 0x0005C330
		internal int AddDateWords(string pattern, int index, string formatPostfix)
		{
			/*
An exception occurred when decompiling this method (06002B0D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.DateTimeFormatInfoScanner::AddDateWords(System.String,System.Int32,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:int64(var_3_1B, ldc.i4:int64(0))
	stloc:bool(var_4_22, call:bool(char::IsWhiteSpace, ldloc:char(var_2_16)))
	stloc:int32(var_5_2A, ldfld:int32(string::_stringLength, ldloc:string(pattern)))
	stloc:char(var_6_33, callgetter:char(string::get_Chars, ldloc:string(pattern), ldloc:int64[exp:int32](var_3_1B)))
	stloc:int32(var_8_3B, ldfld:int32(string::_stringLength, ldloc:string(pattern)))
	stloc:int32(var_10_46, ldfld:int32(string::_stringLength, ldloc:string(pattern)))
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

		// Token: 0x06002B0E RID: 11022 RVA: 0x0005E188 File Offset: 0x0005C388
		internal static int ScanRepeatChar(string pattern, char ch, int index, [Out] int count)
		{
			/*
An exception occurred when decompiling this method (06002B0E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.DateTimeFormatInfoScanner::ScanRepeatChar(System.String,System.Char,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](index), ldloc:int32(var_0_01))
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

		// Token: 0x06002B0F RID: 11023 RVA: 0x0000207A File Offset: 0x0000027A
		internal void AddIgnorableSymbols(string text)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x0005E1A0 File Offset: 0x0005C3A0
		internal void ScanDateWord(string pattern)
		{
			int stringLength = pattern._stringLength;
			long num = 0L;
			char c = pattern[(int)num];
			int stringLength2 = pattern._stringLength;
			char c2 = pattern[(int)c];
			int stringLength3 = pattern._stringLength;
			int stringLength4 = pattern._stringLength;
			long num2 = 0L;
			char c3 = pattern[(int)c];
			int num3 = this.AddDateWords(pattern, (int)num2, "MMMM");
			DateTimeFormatInfoScanner.FoundDatePattern ymdFlags = this._ymdFlags;
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0005E288 File Offset: 0x0005C488
		internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
		{
			int num = 68;
			string[] allDateTimePatterns = dtfi.GetAllDateTimePatterns((char)num);
			int num2 = 100;
			string[] allDateTimePatterns2 = dtfi.GetAllDateTimePatterns((char)num2);
			int num3 = 121;
			string[] allDateTimePatterns3 = dtfi.GetAllDateTimePatterns((char)num3);
			string monthDayPattern = dtfi.MonthDayPattern;
			this.ScanDateWord(monthDayPattern);
			int num4 = 84;
			string[] allDateTimePatterns4 = dtfi.GetAllDateTimePatterns((char)num4);
			int num5 = 116;
			string[] allDateTimePatterns5 = dtfi.GetAllDateTimePatterns((char)num5);
			List<string> dateWords = this.m_dateWords;
			if (dateWords != null)
			{
				int size = dateWords._size;
				List<string> dateWords2 = this.m_dateWords;
				if (dateWords2 == null || dateWords2 != null)
				{
					List<string> dateWords3 = this.m_dateWords;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x0005E330 File Offset: 0x0005C530
		internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			bool flag = DateTimeFormatInfoScanner.EqualStringArrays(genitveMonthNames, abbrevMonthNames);
			return FORMATFLAGS.UseGenitiveMonth;
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x0005E348 File Offset: 0x0005C548
		internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			/*
An exception occurred when decompiling this method (06002B13)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.FORMATFLAGS System.Globalization.DateTimeFormatInfoScanner::GetFormatFlagUseSpaceInMonthNames(System.String[],System.String[],System.String[],System.String[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_06, call:bool(DateTimeFormatInfoScanner::ArrayElementsBeginWithDigit, ldloc:string[](monthNames)))
	stloc:bool(var_2_0D, call:bool(DateTimeFormatInfoScanner::ArrayElementsBeginWithDigit, ldloc:string[](genitveMonthNames)))
	stloc:bool(var_3_14, call:bool(DateTimeFormatInfoScanner::ArrayElementsBeginWithDigit, ldloc:string[](abbrevMonthNames)))
	stloc:bool(var_5_1B, call:bool(DateTimeFormatInfoScanner::ArrayElementsHaveSpace, ldloc:string[](monthNames)))
	stloc:bool(var_6_23, call:bool(DateTimeFormatInfoScanner::ArrayElementsHaveSpace, ldloc:string[](genitveMonthNames)))
	stloc:bool(var_7_2B, call:bool(DateTimeFormatInfoScanner::ArrayElementsHaveSpace, ldloc:string[](abbrevMonthNames)))
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

		// Token: 0x06002B14 RID: 11028 RVA: 0x0005E384 File Offset: 0x0005C584
		internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames)
		{
			bool flag = DateTimeFormatInfoScanner.ArrayElementsHaveSpace(dayNames);
			return FORMATFLAGS.UseSpacesInDayNames;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x0000207A File Offset: 0x0000027A
		internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x0005E39C File Offset: 0x0005C59C
		private static bool EqualStringArrays(string[] array1, string[] array2)
		{
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x0005E3B0 File Offset: 0x0005C5B0
		private static bool ArrayElementsHaveSpace(string[] array)
		{
			/*
An exception occurred when decompiling this method (06002B17)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.DateTimeFormatInfoScanner::ArrayElementsHaveSpace(System.String[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_4_0C, call:bool(char::IsWhiteSpace, ldloc:char(var_3)))
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

		// Token: 0x06002B18 RID: 11032 RVA: 0x0005E3D0 File Offset: 0x0005C5D0
		private static bool ArrayElementsBeginWithDigit(string[] array)
		{
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0005E404 File Offset: 0x0005C604
		public DateTimeFormatInfoScanner()
		{
		}

		// Token: 0x0400175C RID: 5980
		internal List<string> m_dateWords;

		// Token: 0x0400175D RID: 5981
		private static Dictionary<string, string> s_knownWords;

		// Token: 0x0400175E RID: 5982
		private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags;

		// Token: 0x0200058D RID: 1421
		private enum FoundDatePattern
		{
			// Token: 0x04001760 RID: 5984
			None,
			// Token: 0x04001761 RID: 5985
			FoundYearPatternFlag,
			// Token: 0x04001762 RID: 5986
			FoundMonthPatternFlag,
			// Token: 0x04001763 RID: 5987
			FoundDayPatternFlag = 4,
			// Token: 0x04001764 RID: 5988
			FoundYMDPatternFlag = 7
		}
	}
}
