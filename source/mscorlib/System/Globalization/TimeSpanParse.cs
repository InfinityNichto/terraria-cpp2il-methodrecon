using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x0200059C RID: 1436
	internal static class TimeSpanParse
	{
		// Token: 0x06002B34 RID: 11060 RVA: 0x0005E9A8 File Offset: 0x0005CBA8
		internal static long Pow10(int pow)
		{
			return 0L;
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x0005E9B8 File Offset: 0x0005CBB8
		private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, [Out] long result)
		{
			/*
An exception occurred when decompiling this method (06002B35)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.TimeSpanParse::TryTimeToTicks(System.Boolean,System.Globalization.TimeSpanParse/TimeSpanToken,System.Globalization.TimeSpanParse/TimeSpanToken,System.Globalization.TimeSpanParse/TimeSpanToken,System.Globalization.TimeSpanParse/TimeSpanToken,System.Globalization.TimeSpanParse/TimeSpanToken,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004A:
	stloc:int32(var_10_4F, ldc.i4:int32(38528))
	stfld:TTT(TimeSpanToken::_ttt, ldloc:TimeSpanToken[exp:valuetype System.Globalization.TimeSpanParse/TimeSpanToken&](fraction), ldloc:int32[exp:TTT](var_10_4F))
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

		// Token: 0x06002B36 RID: 11062 RVA: 0x0005EA20 File Offset: 0x0005CC20
		internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider)
		{
			return 1;
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x0005EA30 File Offset: 0x0005CC30
		internal static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, [Out] TimeSpan result)
		{
			return true;
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x0005EA40 File Offset: 0x0005CC40
		private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, TimeSpanParse.TimeSpanResult result)
		{
			DateTimeFormatInfo instance = DateTimeFormatInfo.GetInstance(formatProvider);
			string fullTimeSpanPositivePattern = instance.FullTimeSpanPositivePattern;
			string fullTimeSpanNegativePattern = instance.FullTimeSpanNegativePattern;
			bool flag;
			return flag;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0005EA6C File Offset: 0x0005CC6C
		private static bool ProcessTerminalState(TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, TimeSpanParse.TimeSpanResult result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x0005EA90 File Offset: 0x0005CC90
		private static bool ProcessTerminal_DHMSF(TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, TimeSpanParse.TimeSpanResult result)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			bool flag;
			return flag;
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x0005EAD0 File Offset: 0x0005CCD0
		private static bool ProcessTerminal_HMS_F_D(TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, TimeSpanParse.TimeSpanResult result)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			bool flag;
			return flag;
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x0005EB88 File Offset: 0x0005CD88
		private static bool ProcessTerminal_HM_S_D(TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, TimeSpanParse.TimeSpanResult result)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x0005EBF4 File Offset: 0x0005CDF4
		private static bool ProcessTerminal_HM(TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, TimeSpanParse.TimeSpanResult result)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x0005EC1C File Offset: 0x0005CE1C
		private static bool ProcessTerminal_D(TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, TimeSpanParse.TimeSpanResult result)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x0005EC44 File Offset: 0x0005CE44
		private static bool TryParseExactTimeSpan(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, TimeSpanParse.TimeSpanResult result)
		{
			if (formatProvider == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0005EC60 File Offset: 0x0005CE60
		private static bool TryParseByFormat(ReadOnlySpan<char> input, ReadOnlySpan<char> format, TimeSpanStyles styles, TimeSpanParse.TimeSpanResult result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (43155456 == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x0005ECD0 File Offset: 0x0005CED0
		private static bool ParseExactDigits(TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, [Out] int result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x0005ECE0 File Offset: 0x0005CEE0
		private static bool ParseExactDigits(TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, [Out] int zeroes, [Out] int result)
		{
			/*
An exception occurred when decompiling this method (06002B42)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.TimeSpanParse::ParseExactDigits(System.Globalization.TimeSpanParse/TimeSpanTokenizer,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_3_05, ldc.i4:int64(0))
	stloc:int64(var_4_07, ldc.i4:int64(0))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](maxDigitLength), ldloc:int64[exp:int32](var_3_05))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](zeroes), ldloc:int64[exp:int32](var_4_07))
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

		// Token: 0x06002B43 RID: 11075 RVA: 0x0005ED04 File Offset: 0x0005CF04
		private static bool ParseExactLiteral(TimeSpanParse.TimeSpanTokenizer tokenizer, StringBuilder enquotedString)
		{
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x0005ED18 File Offset: 0x0005CF18
		private static bool TryParseTimeSpanConstant(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanResult result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0200059D RID: 1437
		private enum ParseFailureKind : byte
		{
			// Token: 0x040017C4 RID: 6084
			None,
			// Token: 0x040017C5 RID: 6085
			ArgumentNull,
			// Token: 0x040017C6 RID: 6086
			Format,
			// Token: 0x040017C7 RID: 6087
			FormatWithParameter,
			// Token: 0x040017C8 RID: 6088
			Overflow
		}

		// Token: 0x0200059E RID: 1438
		[Flags]
		private enum TimeSpanStandardStyles : byte
		{
			// Token: 0x040017CA RID: 6090
			None = 0,
			// Token: 0x040017CB RID: 6091
			Invariant = 1,
			// Token: 0x040017CC RID: 6092
			Localized = 2,
			// Token: 0x040017CD RID: 6093
			RequireFull = 4,
			// Token: 0x040017CE RID: 6094
			Any = 3
		}

		// Token: 0x0200059F RID: 1439
		private enum TTT : byte
		{
			// Token: 0x040017D0 RID: 6096
			None,
			// Token: 0x040017D1 RID: 6097
			End,
			// Token: 0x040017D2 RID: 6098
			Num,
			// Token: 0x040017D3 RID: 6099
			Sep,
			// Token: 0x040017D4 RID: 6100
			NumOverflow
		}

		// Token: 0x020005A0 RID: 1440
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		private ref struct TimeSpanToken
		{
			// Token: 0x06002B45 RID: 11077 RVA: 0x0005ED28 File Offset: 0x0005CF28
			public TimeSpanToken(TimeSpanParse.TTT type)
			{
				this._ttt = type;
			}

			// Token: 0x06002B46 RID: 11078 RVA: 0x0005ED3C File Offset: 0x0005CF3C
			public TimeSpanToken(int number)
			{
				this._num = number;
				this._ttt = TimeSpanParse.TTT.Num;
			}

			// Token: 0x06002B47 RID: 11079 RVA: 0x0005ED58 File Offset: 0x0005CF58
			public TimeSpanToken(int number, int leadingZeroes)
			{
				this._num = number;
				this._ttt = TimeSpanParse.TTT.Num;
			}

			// Token: 0x06002B48 RID: 11080 RVA: 0x0005ED74 File Offset: 0x0005CF74
			public TimeSpanToken(TimeSpanParse.TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator)
			{
				this._ttt = type;
				this._num = number;
				this._sep = separator;
			}

			// Token: 0x06002B49 RID: 11081 RVA: 0x0005ED98 File Offset: 0x0005CF98
			public bool IsInvalidFraction()
			{
				/*
An exception occurred when decompiling this method (06002B49)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.TimeSpanParse/TimeSpanToken::IsInvalidFraction()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int64(var_4_1A, call:int64(TimeSpanParse::Pow10, ldloc:int64[exp:int32](var_3_10)))
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

			// Token: 0x040017D5 RID: 6101
			internal TimeSpanParse.TTT _ttt;

			// Token: 0x040017D6 RID: 6102
			internal int _num;

			// Token: 0x040017D7 RID: 6103
			internal int _zeroes;

			// Token: 0x040017D8 RID: 6104
			internal ReadOnlySpan<char> _sep;
		}

		// Token: 0x020005A1 RID: 1441
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		private ref struct TimeSpanTokenizer
		{
			// Token: 0x06002B4A RID: 11082 RVA: 0x0005EDC8 File Offset: 0x0005CFC8
			internal TimeSpanTokenizer(ReadOnlySpan<char> input)
			{
				this._value = input;
			}

			// Token: 0x06002B4B RID: 11083 RVA: 0x0005EDDC File Offset: 0x0005CFDC
			internal TimeSpanTokenizer(ReadOnlySpan<char> input, int startPosition)
			{
				this._value = input;
			}

			// Token: 0x06002B4C RID: 11084 RVA: 0x0005EDF0 File Offset: 0x0005CFF0
			internal TimeSpanParse.TimeSpanToken GetNextToken()
			{
				/*
An exception occurred when decompiling this method (06002B4C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.TimeSpanParse/TimeSpanToken System.Globalization.TimeSpanParse/TimeSpanTokenizer::GetNextToken()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_06, ldfld:int32(TimeSpanTokenizer::_pos, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanTokenizer&(this)))
	stloc:int64(var_2_08, ldc.i4:int64(0))
	stfld:int32(TimeSpanTokenizer::_pos, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanTokenizer&(this), ldloc:int32(var_1_06))
	stfld:int32(TimeSpanTokenizer::_pos, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanTokenizer&(this), ldloc:int64[exp:int32](var_2_08))
	stloc:int32(var_6_20, ldc.i4:int32(1))
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
	stloc:int32(var_8_2B, ldc.i4:int32(3))
	stfld:TTT(TimeSpanToken::_ttt, ldloc:TimeSpanToken[exp:valuetype System.Globalization.TimeSpanParse/TimeSpanToken&](var_0), ldloc:int32[exp:TTT](var_8_2B))
	stfld:valuetype System.ReadOnlySpan`1<char>(TimeSpanToken::_sep, ldloc:TimeSpanToken[exp:valuetype System.Globalization.TimeSpanParse/TimeSpanToken&](var_0), ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanTokenizer&[exp:valuetype System.ReadOnlySpan`1<char>](this))
	stfld:int32(ReadOnlySpan`1::_length, ldfld:valuetype System.ReadOnlySpan`1<char>[exp:valuetype System.ReadOnlySpan`1&](TimeSpanToken::_sep, ldloc:TimeSpanToken[exp:valuetype System.Globalization.TimeSpanParse/TimeSpanToken&](var_0)), ldloc:int32(var_6_20))
	stfld:int32(TimeSpanTokenizer::_pos, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanTokenizer&(this), ldloc:int32(var_8_2B))
	stloc:int32(var_11_58, ldc.i4:int32(2))
	stfld:TTT(TimeSpanToken::_ttt, ldloc:TimeSpanToken[exp:valuetype System.Globalization.TimeSpanParse/TimeSpanToken&](var_0), ldloc:int32[exp:TTT](var_11_58))
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

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x06002B4D RID: 11085 RVA: 0x0005EE60 File Offset: 0x0005D060
			internal bool EOL
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B4D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.TimeSpanParse/TimeSpanTokenizer::get_EOL()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_08, ldfld:int32(TimeSpanTokenizer::_pos, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanTokenizer&(this)))
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

			// Token: 0x06002B4E RID: 11086 RVA: 0x0005EE78 File Offset: 0x0005D078
			internal void BackOne()
			{
				int pos = this._pos;
				this._pos = pos;
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x06002B4F RID: 11087 RVA: 0x0005EE94 File Offset: 0x0005D094
			internal char NextChar
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B4F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Globalization.TimeSpanParse/TimeSpanTokenizer::get_NextChar()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TimeSpanTokenizer::_pos, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanTokenizer&(this)))
	stfld:int32(TimeSpanTokenizer::_pos, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanTokenizer&(this), ldloc:int32(var_0_06))
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

			// Token: 0x040017D9 RID: 6105
			private ReadOnlySpan<char> _value;

			// Token: 0x040017DA RID: 6106
			private int _pos;
		}

		// Token: 0x020005A2 RID: 1442
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		private ref struct TimeSpanRawInfo
		{
			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x06002B50 RID: 11088 RVA: 0x0005EEB0 File Offset: 0x0005D0B0
			internal TimeSpanFormat.FormatLiterals PositiveInvariant
			{
				get
				{
					if (!true)
					{
					}
					return 1;
				}
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x06002B51 RID: 11089 RVA: 0x0005EEC4 File Offset: 0x0005D0C4
			internal TimeSpanFormat.FormatLiterals NegativeInvariant
			{
				get
				{
					if (!true)
					{
					}
					return 1;
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x06002B52 RID: 11090 RVA: 0x0005EED8 File Offset: 0x0005D0D8
			internal TimeSpanFormat.FormatLiterals PositiveLocalized
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B52)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.TimeSpanFormat/FormatLiterals System.Globalization.TimeSpanParse/TimeSpanRawInfo::get_PositiveLocalized()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	stloc:string[](var_4_3A, ldfld:string[](FormatLiterals::_literals, ldfld:FormatLiterals[exp:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&](TimeSpanRawInfo::_posLoc, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanRawInfo&(this))))
	stloc:string(var_5_47, ldfld:string(FormatLiterals::AppCompatLiteral, ldfld:FormatLiterals[exp:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&](TimeSpanRawInfo::_posLoc, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanRawInfo&(this))))
	stfld:string[](FormatLiterals::_literals, ldloc:FormatLiterals[exp:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&](var_0), ldloc:string[](var_4_3A))
	stfld:string(FormatLiterals::AppCompatLiteral, ldloc:FormatLiterals[exp:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&](var_0), ldloc:string(var_5_47))
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

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x06002B53 RID: 11091 RVA: 0x0005EF40 File Offset: 0x0005D140
			internal TimeSpanFormat.FormatLiterals NegativeLocalized
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B53)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.TimeSpanFormat/FormatLiterals System.Globalization.TimeSpanParse/TimeSpanRawInfo::get_NegativeLocalized()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stloc:string[](var_4_2E, ldfld:string[](FormatLiterals::_literals, ldfld:FormatLiterals[exp:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&](TimeSpanRawInfo::_negLoc, ldloc:valuetype System.Globalization.TimeSpanParse/TimeSpanRawInfo&(this))))
	stfld:string[](FormatLiterals::_literals, ldloc:FormatLiterals[exp:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&](var_0), ldloc:string[](var_4_2E))
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

			// Token: 0x06002B54 RID: 11092 RVA: 0x0005EF84 File Offset: 0x0005D184
			internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				if (this._literals0._length != 0)
				{
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				if (this._literals1._length != 0)
				{
					bool flag2;
					return flag2;
				}
				string[] literals5 = pattern._literals;
				ReadOnlySpan<char> literals6 = this._literals2;
				if (this._literals2._length != 0)
				{
					bool flag3;
					return flag3;
				}
				ReadOnlySpan<char> literals7 = this._literals3;
				int length = this._literals3._length;
				if (length != 0)
				{
					bool flag4;
					return flag4;
				}
				string[] literals8 = pattern._literals;
				ReadOnlySpan<char> literals9 = this._literals4;
				int length2 = this._literals4._length;
				if (length != 0)
				{
				}
				bool flag5;
				return length2 == 0 || flag5;
			}

			// Token: 0x06002B55 RID: 11093 RVA: 0x0005F048 File Offset: 0x0005D248
			internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				if (this._literals0._length != 0)
				{
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				if (this._literals1._length != 0)
				{
					bool flag2;
					return flag2;
				}
				ReadOnlySpan<char> literals5 = this._literals2;
				int length = this._literals2._length;
				if (length != 0)
				{
					bool flag3;
					return flag3;
				}
				string[] literals6 = pattern._literals;
				ReadOnlySpan<char> literals7 = this._literals3;
				int length2 = this._literals3._length;
				if (length != 0)
				{
				}
				if (length2 != 0)
				{
					bool flag4;
					return flag4;
				}
			}

			// Token: 0x06002B56 RID: 11094 RVA: 0x0005F0EC File Offset: 0x0005D2EC
			internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				if (this._literals0._length != 0)
				{
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				if (this._literals1._length != 0)
				{
					bool flag2;
					return flag2;
				}
				string[] literals5 = pattern._literals;
				ReadOnlySpan<char> literals6 = this._literals2;
				if (this._literals2._length != 0)
				{
					bool flag3;
					return flag3;
				}
				string[] literals7 = pattern._literals;
				ReadOnlySpan<char> literals8 = this._literals3;
				if (this._literals3._length != 0)
				{
					bool flag4;
					return flag4;
				}
				string[] literals9 = pattern._literals;
				ReadOnlySpan<char> literals10 = this._literals4;
				int length = this._literals4._length;
				if (length != 0)
				{
					bool flag5;
					return flag5;
				}
				string[] literals11 = pattern._literals;
				ReadOnlySpan<char> literals12 = this._literals5;
				int length2 = this._literals5._length;
				if (length != 0)
				{
				}
				bool flag6;
				return length2 == 0 || flag6;
			}

			// Token: 0x06002B57 RID: 11095 RVA: 0x0005F1D8 File Offset: 0x0005D3D8
			internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				int length = this._literals0._length;
				if (length != 0)
				{
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				int length2 = this._literals1._length;
				if (length != 0)
				{
				}
				bool flag2;
				return length2 == 0 || flag2;
			}

			// Token: 0x06002B58 RID: 11096 RVA: 0x0005F244 File Offset: 0x0005D444
			internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				if (this._literals0._length != 0)
				{
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				int length = this._literals1._length;
				if (length != 0)
				{
					bool flag2;
					return flag2;
				}
				string[] literals5 = pattern._literals;
				if (length != 0)
				{
				}
				bool flag3;
				return (ref this) == null || flag3;
			}

			// Token: 0x06002B59 RID: 11097 RVA: 0x0005F2B8 File Offset: 0x0005D4B8
			internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				if (this._literals0._length != 0)
				{
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				if (this._literals1._length != 0)
				{
					bool flag2;
					return flag2;
				}
				string[] literals5 = pattern._literals;
				ReadOnlySpan<char> literals6 = this._literals2;
				int length = this._literals2._length;
				if (length != 0)
				{
					bool flag3;
					return flag3;
				}
				string[] literals7 = pattern._literals;
				ReadOnlySpan<char> literals8 = this._literals3;
				int length2 = this._literals3._length;
				if (length != 0)
				{
				}
				bool flag4;
				return length2 == 0 || flag4;
			}

			// Token: 0x06002B5A RID: 11098 RVA: 0x0005F364 File Offset: 0x0005D564
			internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				if (this._literals0._length != 0)
				{
					int dd = pattern.dd;
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				if (this._literals1._length != 0)
				{
					bool flag2;
					return flag2;
				}
				string[] literals5 = pattern._literals;
				ReadOnlySpan<char> literals6 = this._literals2;
				int length = this._literals2._length;
				if (length != 0)
				{
					bool flag3;
					return flag3;
				}
				string[] literals7 = pattern._literals;
				ReadOnlySpan<char> literals8 = this._literals3;
				int length2 = this._literals3._length;
				if (length != 0)
				{
				}
				bool flag4;
				return length2 == 0 || flag4;
			}

			// Token: 0x06002B5B RID: 11099 RVA: 0x0005F418 File Offset: 0x0005D618
			internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				if (this._literals0._length != 0)
				{
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				if (this._literals1._length != 0)
				{
					bool flag2;
					return flag2;
				}
				string[] literals5 = pattern._literals;
				ReadOnlySpan<char> literals6 = this._literals2;
				if (this._literals2._length != 0)
				{
					bool flag3;
					return flag3;
				}
				string[] literals7 = pattern._literals;
				ReadOnlySpan<char> literals8 = this._literals3;
				int length = this._literals3._length;
				if (length != 0)
				{
					bool flag4;
					return flag4;
				}
				string[] literals9 = pattern._literals;
				ReadOnlySpan<char> literals10 = this._literals4;
				int length2 = this._literals4._length;
				if (length != 0)
				{
				}
				bool flag5;
				return length2 == 0 || flag5;
			}

			// Token: 0x06002B5C RID: 11100 RVA: 0x0005F4E4 File Offset: 0x0005D6E4
			internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				int sepCount = this._sepCount;
				int numCount = this._numCount;
				string[] literals = pattern._literals;
				ReadOnlySpan<char> literals2 = this._literals0;
				if (this._literals0._length != 0)
				{
					bool flag;
					return flag;
				}
				string[] literals3 = pattern._literals;
				ReadOnlySpan<char> literals4 = this._literals1;
				if (this._literals1._length != 0)
				{
					bool flag2;
					return flag2;
				}
				string[] literals5 = pattern._literals;
				ReadOnlySpan<char> literals6 = this._literals2;
				if (this._literals2._length != 0)
				{
					bool flag3;
					return flag3;
				}
				string[] literals7 = pattern._literals;
				ReadOnlySpan<char> literals8 = this._literals3;
				int length = this._literals3._length;
				if (length != 0)
				{
					bool flag4;
					return flag4;
				}
				string[] literals9 = pattern._literals;
				ReadOnlySpan<char> literals10 = this._literals4;
				int length2 = this._literals4._length;
				if (length != 0)
				{
				}
				bool flag5;
				return length2 == 0 || flag5;
			}

			// Token: 0x06002B5D RID: 11101 RVA: 0x0005F5B0 File Offset: 0x0005D7B0
			internal void Init(DateTimeFormatInfo dtfi)
			{
				string fullTimeSpanPositivePattern = dtfi.FullTimeSpanPositivePattern;
				this._fullPosPattern = fullTimeSpanPositivePattern;
				string text;
				this._fullNegPattern = text;
			}

			// Token: 0x06002B5E RID: 11102 RVA: 0x0005F5D4 File Offset: 0x0005D7D4
			internal bool ProcessToken(TimeSpanParse.TimeSpanToken tok, TimeSpanParse.TimeSpanResult result)
			{
				if (this._tokenCount == 0)
				{
				}
				TimeSpanParse.TTT ttt = tok._ttt;
				int num = tok._num;
				bool flag;
				return flag;
			}

			// Token: 0x06002B5F RID: 11103 RVA: 0x0005F614 File Offset: 0x0005D814
			private bool AddSep(ReadOnlySpan<char> sep, TimeSpanParse.TimeSpanResult result)
			{
				int sepCount = this._sepCount;
				int tokenCount = this._tokenCount;
				return "String was not recognized as a valid TimeSpan." != null;
			}

			// Token: 0x06002B60 RID: 11104 RVA: 0x0005F67C File Offset: 0x0005D87C
			private bool AddNum(TimeSpanParse.TimeSpanToken num, TimeSpanParse.TimeSpanResult result)
			{
				int numCount = this._numCount;
				int tokenCount = this._tokenCount;
				return "String was not recognized as a valid TimeSpan." != null;
			}

			// Token: 0x040017DB RID: 6107
			internal TimeSpanParse.TTT _lastSeenTTT;

			// Token: 0x040017DC RID: 6108
			internal int _tokenCount;

			// Token: 0x040017DD RID: 6109
			internal int _sepCount;

			// Token: 0x040017DE RID: 6110
			internal int _numCount;

			// Token: 0x040017DF RID: 6111
			private TimeSpanFormat.FormatLiterals _posLoc;

			// Token: 0x040017E0 RID: 6112
			private TimeSpanFormat.FormatLiterals _negLoc;

			// Token: 0x040017E1 RID: 6113
			private bool _posLocInit;

			// Token: 0x040017E2 RID: 6114
			private bool _negLocInit;

			// Token: 0x040017E3 RID: 6115
			private string _fullPosPattern;

			// Token: 0x040017E4 RID: 6116
			private string _fullNegPattern;

			// Token: 0x040017E5 RID: 6117
			internal TimeSpanParse.TimeSpanToken _numbers0;

			// Token: 0x040017E6 RID: 6118
			internal TimeSpanParse.TimeSpanToken _numbers1;

			// Token: 0x040017E7 RID: 6119
			internal TimeSpanParse.TimeSpanToken _numbers2;

			// Token: 0x040017E8 RID: 6120
			internal TimeSpanParse.TimeSpanToken _numbers3;

			// Token: 0x040017E9 RID: 6121
			internal TimeSpanParse.TimeSpanToken _numbers4;

			// Token: 0x040017EA RID: 6122
			internal ReadOnlySpan<char> _literals0;

			// Token: 0x040017EB RID: 6123
			internal ReadOnlySpan<char> _literals1;

			// Token: 0x040017EC RID: 6124
			internal ReadOnlySpan<char> _literals2;

			// Token: 0x040017ED RID: 6125
			internal ReadOnlySpan<char> _literals3;

			// Token: 0x040017EE RID: 6126
			internal ReadOnlySpan<char> _literals4;

			// Token: 0x040017EF RID: 6127
			internal ReadOnlySpan<char> _literals5;
		}

		// Token: 0x020005A3 RID: 1443
		private struct TimeSpanResult
		{
			// Token: 0x06002B61 RID: 11105 RVA: 0x0005F704 File Offset: 0x0005D904
			internal TimeSpanResult(bool throwOnFailure)
			{
			}

			// Token: 0x06002B62 RID: 11106 RVA: 0x0005F714 File Offset: 0x0005D914
			internal bool SetFailure(TimeSpanParse.ParseFailureKind kind, string resourceKey, [Optional] object messageArgument, [Optional] string argumentName)
			{
				/*
An exception occurred when decompiling this method (06002B62)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.TimeSpanParse/TimeSpanResult::SetFailure(System.Globalization.TimeSpanParse/ParseFailureKind,System.String,System.Object,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:string(var_1_10, call:string(SR::GetResourceString, ldloc:string(resourceKey)))
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

			// Token: 0x040017F0 RID: 6128
			internal TimeSpan parsedTimeSpan;

			// Token: 0x040017F1 RID: 6129
			private readonly bool _throwOnFailure;
		}

		// Token: 0x020005A4 RID: 1444
		private ref struct StringParser
		{
			// Token: 0x06002B63 RID: 11107 RVA: 0x0005F734 File Offset: 0x0005D934
			internal void NextChar()
			{
				int pos = this._pos;
				this._pos = pos;
			}

			// Token: 0x06002B64 RID: 11108 RVA: 0x0005F75C File Offset: 0x0005D95C
			internal char NextNonDigit()
			{
				/*
An exception occurred when decompiling this method (06002B64)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Globalization.TimeSpanParse/StringParser::NextNonDigit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(StringParser::_pos, ldloc:valuetype System.Globalization.TimeSpanParse/StringParser&(this)))
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

			// Token: 0x06002B65 RID: 11109 RVA: 0x0005F774 File Offset: 0x0005D974
			internal bool TryParse(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanResult result)
			{
				int num = 1;
				this._str = input;
				this._pos = num;
				this._pos = num;
				return "String was not recognized as a valid TimeSpan." != null;
			}

			// Token: 0x06002B66 RID: 11110 RVA: 0x0005F84C File Offset: 0x0005DA4C
			internal bool ParseInt(int max, [Out] int i, TimeSpanParse.TimeSpanResult result)
			{
				char ch = this._ch;
				int pos = this._pos;
				i.m_value = (int)ch;
				int pos2 = this._pos;
				this._pos = pos2;
				return "String was not recognized as a valid TimeSpan." != null;
			}

			// Token: 0x06002B67 RID: 11111 RVA: 0x0005F890 File Offset: 0x0005DA90
			internal bool ParseTime([Out] long time, TimeSpanParse.TimeSpanResult result)
			{
				bool flag;
				time.m_value = (flag ? 1L : 0L);
				char ch = this._ch;
				int pos = this._pos;
				this._pos = pos;
				bool flag2;
				return flag2;
			}

			// Token: 0x06002B68 RID: 11112 RVA: 0x0005F944 File Offset: 0x0005DB44
			internal void SkipBlanks()
			{
				char ch = this._ch;
				int pos = this._pos;
				this._pos = pos;
			}

			// Token: 0x040017F2 RID: 6130
			private ReadOnlySpan<char> _str;

			// Token: 0x040017F3 RID: 6131
			private char _ch;

			// Token: 0x040017F4 RID: 6132
			private int _pos;

			// Token: 0x040017F5 RID: 6133
			private int _len;
		}
	}
}
