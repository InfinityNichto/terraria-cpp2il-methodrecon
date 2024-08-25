using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000BF RID: 191
	internal sealed class RegexParser
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x00010B4C File Offset: 0x0000ED4C
		public static RegexTree Parse(string re, RegexOptions op)
		{
			/*
An exception occurred when decompiling this method (06000414)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.RegexTree System.Text.RegularExpressions.RegexParser::Parse(System.String,System.Text.RegularExpressions.RegexOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
	stloc:CultureInfo(var_2_10, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000415 RID: 1045 RVA: 0x00010B6C File Offset: 0x0000ED6C
		public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op)
		{
			/*
An exception occurred when decompiling this method (06000415)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.RegexReplacement System.Text.RegularExpressions.RegexParser::ParseReplacement(System.String,System.Collections.Hashtable,System.Int32,System.Collections.Hashtable,System.Text.RegularExpressions.RegexOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
	stloc:CultureInfo(var_2_10, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000416 RID: 1046 RVA: 0x00010B8C File Offset: 0x0000ED8C
		public static string Escape(string input)
		{
			char c;
			bool flag = RegexParser.IsMetachar(c);
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			int num = 92;
			StringBuilder stringBuilder2 = stringBuilder.Append((char)num);
			int num2 = 114;
			StringBuilder stringBuilder3 = stringBuilder.Append((char)num2);
			char c2;
			bool flag2 = RegexParser.IsMetachar(c2);
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00010BDC File Offset: 0x0000EDDC
		private RegexParser(CultureInfo culture)
		{
			this._culture = culture;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		private void SetPattern(string Re)
		{
			if (Re == null)
			{
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00010C08 File Offset: 0x0000EE08
		private void Reset(RegexOptions topopts)
		{
			List<RegexOptions> optionsStack = this._optionsStack;
			this._autocap = 1;
			int size = optionsStack._size;
			this._options = topopts;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00010C34 File Offset: 0x0000EE34
		private RegexNode ScanRegex()
		{
			RegexOptions options = this._options;
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			this.ScanBlank();
			string pattern2 = this._pattern;
			int currentPos2 = this._currentPos;
			RegexOptions options2 = this._options;
			int stringLength2 = pattern2._stringLength;
			char c = pattern2[currentPos2];
			if (options2 == RegexOptions.None)
			{
			}
			bool flag = RegexParser.IsSpecial(c);
			bool flag2 = this.IsTrueQuantifier();
			int currentPos3 = this._currentPos;
			string pattern3 = this._pattern;
			this._currentPos = currentPos2;
			int stringLength3 = pattern3._stringLength;
			char c2 = pattern3[currentPos2];
			if (options2 == RegexOptions.None)
			{
			}
			bool flag3 = RegexParser.IsStopperX(c2);
			bool flag4 = this.IsTrueQuantifier();
			int currentPos4 = this._currentPos;
			string pattern4 = this._pattern;
			this._currentPos = currentPos2;
			int stringLength4 = pattern4._stringLength;
			int currentPos5 = this._currentPos;
			this.ScanBlank();
			string pattern5 = this._pattern;
			int currentPos6 = this._currentPos;
			int stringLength5 = pattern5._stringLength;
			long num = 0L;
			char c3 = pattern5[currentPos6];
			if (options2 == RegexOptions.None)
			{
			}
			bool flag5 = RegexParser.IsSpecial(c3);
			bool flag6 = RegexParser.IsQuantifier(c3);
			int currentPos7 = this._currentPos;
			this._currentPos = currentPos7;
			long num2 = 0L;
			long num3 = 0L;
			this.AddConcatenate(currentPos2, (int)num, num3 != 0L);
			char c4;
			if (num2 != 0L)
			{
				c4 = this._pattern[currentPos2];
				this.AddUnitOne(c4);
			}
			RegexOptions options3 = this._options;
			this.AddAlternate();
			RegexOptions options4 = this._options;
			long num4 = 0L;
			string text = this.ScanCharClass(c4 != '\0', num4 != 0L).ToStringClass();
			RegexOptions options5 = this._options;
			long num5 = 0L;
			RegexNode regexNode = this.ScanBackslash(num5 != 0L);
			this._unit = regexNode;
			return regexNode;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00011098 File Offset: 0x0000F298
		private RegexNode ScanReplacement()
		{
			RegexOptions options = this._options;
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			char c = pattern[currentPos];
			int currentPos2 = this._currentPos;
			this._currentPos = currentPos;
			string pattern2 = this._pattern;
			long num = 0L;
			char c2 = pattern2[currentPos];
			int currentPos3 = this._currentPos;
			int num2 = 1;
			this.AddConcatenate(currentPos, (int)num, num2 != 0);
			int currentPos4 = this._currentPos;
			string pattern3 = this._pattern;
			this._currentPos = currentPos3;
			char c3 = pattern3[currentPos4];
			RegexNode regexNode = this.ScanDollar();
			this._unit = regexNode;
			return regexNode;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00011180 File Offset: 0x0000F380
		private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly)
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			char c = pattern[currentPos];
			int currentPos2 = this._currentPos;
			this._currentPos = currentPos2;
			string pattern2 = this._pattern;
			int stringLength2 = pattern2._stringLength;
			long num = 0L;
			this._currentPos = stringLength2;
			char c2 = pattern2[currentPos2];
			string pattern3 = this._pattern;
			int currentPos3 = this._currentPos;
			int stringLength3 = pattern3._stringLength;
			this._currentPos = stringLength3;
			char c3 = pattern3[currentPos3];
			RegexOptions options = this._options;
			string pattern4 = this._pattern;
			string pattern5 = this._pattern;
			int currentPos4 = this._currentPos;
			int stringLength4 = pattern5._stringLength;
			char c4 = pattern5[currentPos4];
			long num2 = 0L;
			RegexCharClass regexCharClass = this.ScanCharClass(num != 0L, num2 != 0L);
			string pattern6 = this._pattern;
			int currentPos5 = this._currentPos;
			int stringLength5 = pattern6._stringLength;
			char c5 = pattern6[currentPos5];
			int currentPos6 = this._currentPos;
			this._currentPos = stringLength5;
			string text = this.ScanCapname();
			string pattern7 = this._pattern;
			int currentPos7 = this._currentPos;
			int stringLength6 = pattern7._stringLength;
			this._currentPos = stringLength6;
			char c6 = pattern7[currentPos7];
			int currentPos8 = this._currentPos;
			string pattern8 = this._pattern;
			this._currentPos = stringLength6;
			char c7 = pattern8[currentPos8];
			this._currentPos = currentPos6;
			int num3 = 91;
			string pattern9 = this._pattern;
			int currentPos9 = this._currentPos;
			int stringLength7 = pattern9._stringLength;
			char c8 = pattern9[currentPos9];
			int currentPos10 = this._currentPos;
			char c9 = this._pattern[currentPos9];
			string pattern10 = this._pattern;
			int currentPos11 = this._currentPos;
			int stringLength8 = pattern10._stringLength;
			char c10 = pattern10[currentPos11];
			string pattern11 = this._pattern;
			int currentPos12 = this._currentPos;
			int stringLength9 = pattern11._stringLength;
			int currentPos13 = this._currentPos;
			this._currentPos = currentPos13;
			RegexCharClass regexCharClass2 = this.ScanCharClass(currentPos12 != 0, num3 != 0);
			string pattern12 = this._pattern;
			int currentPos14 = this._currentPos;
			int stringLength10 = pattern12._stringLength;
			char c11 = pattern12[currentPos14];
			int currentPos15 = this._currentPos;
			this._currentPos = currentPos15;
			RegexOptions options2 = this._options;
			int currentPos16 = this._currentPos;
			this._currentPos = currentPos16;
			char c12 = this.ScanCharEscape();
			RegexOptions options3 = this._options;
			string text2 = this.ParseProperty();
			string text3 = this.ParseProperty();
			string pattern13 = this._pattern;
			CultureInfo culture = this._culture;
			ArgumentException ex = this.MakeException("Unterminated [] set.");
			return "[x-y] range in reverse order.";
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00011430 File Offset: 0x0000F630
		private RegexNode ScanGroupOpen()
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			char c = pattern[currentPos];
			string pattern2 = this._pattern;
			int currentPos2 = this._currentPos;
			char c2 = pattern2[currentPos2];
			string pattern3 = this._pattern;
			int currentPos3 = this._currentPos;
			int stringLength2 = pattern3._stringLength;
			char c3 = pattern3[currentPos2];
			RegexOptions options = this._options;
			int currentPos4;
			if (this._ignoreNextParen)
			{
				long num = 0L;
				currentPos4 = this._currentPos;
				string pattern4 = this._pattern;
				this._currentPos = (int)num;
				int stringLength3 = pattern4._stringLength;
				this._currentPos = currentPos4;
				char c4 = pattern4[(int)num];
			}
			int autocap = this._autocap;
			this._autocap = currentPos4;
			string pattern5 = this._pattern;
			int currentPos5 = this._currentPos;
			int stringLength4 = pattern5._stringLength;
			this._currentPos = stringLength4;
			char c5 = pattern5[currentPos5];
			RegexOptions options2 = this._options;
			RegexOptions options3 = this._options;
			string pattern6 = this._pattern;
			int currentPos6 = this._currentPos;
			int stringLength5 = pattern6._stringLength;
			char c6 = pattern6[currentPos6];
			if (stringLength5 == 0)
			{
			}
			bool flag = RegexCharClass.IsWordChar(c6);
			string text = this.ScanCapname();
			if (this._capnames != null)
			{
				string pattern7 = this._pattern;
				int currentPos7 = this._currentPos;
				int stringLength6 = pattern7._stringLength;
				this._currentPos = stringLength6;
				char c7 = pattern7[currentPos7];
				RegexOptions options4 = this._options;
				int num2 = this.CaptureSlotFromName(text);
				int num3 = 33;
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
					goto IL_01B1;
				}
			}
			int num4;
			if (num4 == 0)
			{
				return "Capture number cannot be zero.";
			}
			int num5 = 1;
			bool flag2;
			if (!flag2)
			{
			}
			char c8;
			bool flag3 = RegexCharClass.IsWordChar(c8);
			if (!flag2)
			{
				return "Reference to undefined group name {0}.";
			}
			if (num5 != 0)
			{
			}
			IL_01B1:
			return "Invalid group name: Group names must begin with a word character.";
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0001162C File Offset: 0x0000F82C
		private void ScanBlank()
		{
			RegexOptions options = this._options;
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			int currentPos2 = this._currentPos;
			string pattern2 = this._pattern;
			string pattern3 = this._pattern;
			int currentPos3 = this._currentPos;
			char c = pattern3[currentPos3];
			string pattern4 = this._pattern;
			int currentPos4 = this._currentPos;
			int stringLength2 = pattern4._stringLength;
			char c2 = pattern4[currentPos4];
			int currentPos5 = this._currentPos;
			string pattern5 = this._pattern;
			this._currentPos = currentPos4;
			int stringLength3 = pattern5._stringLength;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001183C File Offset: 0x0000FA3C
		private RegexNode ScanBackslash(bool scanOnly)
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			char c = pattern[currentPos];
			int currentPos2 = this._currentPos;
			this._currentPos = currentPos2;
			RegexOptions options = this._options;
			if (currentPos2 == 0)
			{
			}
			int currentPos3 = this._currentPos;
			this._currentPos = currentPos3;
			string text = this.ParseProperty();
			RegexOptions options2 = this._options;
			string pattern2 = this._pattern;
			RegexOptions options3 = this._options;
			CultureInfo culture = this._culture;
			RegexOptions options4 = this._options;
			RegexNode regexNode;
			return regexNode;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000118CC File Offset: 0x0000FACC
		private RegexNode ScanBasicBackslash(bool scanOnly)
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			char c = pattern[currentPos];
			string pattern2 = this._pattern;
			int currentPos2 = this._currentPos;
			int stringLength2 = pattern2._stringLength;
			this._currentPos = currentPos2;
			char c2 = pattern2[currentPos];
			string pattern3 = this._pattern;
			int currentPos3 = this._currentPos;
			int stringLength3 = pattern3._stringLength;
			return "Malformed \\k<...> named back reference.";
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000119CC File Offset: 0x0000FBCC
		private RegexNode ScanDollar()
		{
			/*
An exception occurred when decompiling this method (06000421)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.RegexNode System.Text.RegularExpressions.RegexParser::ScanDollar()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00D2:
	stloc:int32(var_21_D8, ldfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this)))
	stfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this), ldloc:int32(var_21_D8))
	stloc:int32(var_22_E8, call:int32(RegexParser::ScanDecimal, ldloc:RegexParser(this)))
	stloc:bool(var_23_F2, call:bool(RegexParser::IsCaptureSlot, ldloc:RegexParser(this), ldloc:int32(var_22_E8)))
	stloc:int32(var_24_FA, ldfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this)))
	stfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this), ldloc:int32(var_24_FA))
	stloc:bool(var_25_10C, call:bool(RegexParser::IsCaptureSlot, ldloc:RegexParser(this), ldloc:int32(var_22_E8)))
	stloc:int32(var_26_114, ldfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this)))
	stfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this), ldloc:int32(var_26_114))
	stloc:RegexOptions(var_27_124, ldfld:RegexOptions(RegexParser::_options, ldloc:RegexParser(this)))
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

		// Token: 0x06000422 RID: 1058 RVA: 0x00011B08 File Offset: 0x0000FD08
		private string ScanCapname()
		{
			int currentPos = this._currentPos;
			string pattern = this._pattern;
			int stringLength = pattern._stringLength;
			long num = 0L;
			this._currentPos = stringLength;
			bool flag = RegexCharClass.IsWordChar(pattern[currentPos]);
			int currentPos2 = this._currentPos;
			string pattern2 = this._pattern;
			this._currentPos = currentPos2;
			return pattern2.Substring(currentPos, (int)num);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00011B64 File Offset: 0x0000FD64
		private char ScanOctal()
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			char c = pattern[currentPos];
			int currentPos2 = this._currentPos;
			this._currentPos = currentPos;
			return this._pattern[currentPos];
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		private int ScanDecimal()
		{
			/*
An exception occurred when decompiling this method (06000424)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexParser::ScanDecimal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(RegexParser::_pattern, ldloc:RegexParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this)))
	stloc:int32(var_2_14, ldfld:int32(string::_stringLength, ldloc:string(var_0_06)))
	stloc:char(var_5_25, callgetter:char(string::get_Chars, ldloc:string(var_0_06), ldloc:int32(var_1_0D)))
	stloc:int32(var_6_2D, ldfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this)))
	stfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this), ldloc:int32(var_1_0D))
	stloc:int32(var_7_41, ldfld:int32(string::_stringLength, ldfld:string(RegexParser::_pattern, ldloc:RegexParser(this))))
	stloc:ArgumentException(var_9_51, call:ArgumentException(RegexParser::MakeException, ldloc:RegexParser(this), ldstr:string("Capture group numbers must be less than or equal to Int32.MaxValue.")))
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

		// Token: 0x06000425 RID: 1061 RVA: 0x00011C10 File Offset: 0x0000FE10
		private char ScanHex(int c)
		{
			/*
An exception occurred when decompiling this method (06000425)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Text.RegularExpressions.RegexParser::ScanHex(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(RegexParser::_pattern, ldloc:RegexParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this)))
	stloc:int32(var_2_14, ldfld:int32(string::_stringLength, ldloc:string(var_0_06)))
	stfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this), ldloc:int32(var_2_14))
	stloc:char(var_3_23, callgetter:char(string::get_Chars, ldloc:string(var_0_06), ldloc:int32(var_1_0D)))
	stloc:string(var_4_2A, ldfld:string(RegexParser::_pattern, ldloc:RegexParser(this)))
	stloc:int32(var_5_32, ldfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this)))
	stloc:ArgumentException(var_7_42, call:ArgumentException(RegexParser::MakeException, ldloc:RegexParser(this), ldstr:string("Insufficient hexadecimal digits.")))
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

		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		private static int HexDigit(char ch)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00011C60 File Offset: 0x0000FE60
		private char ScanControl()
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			this._currentPos = stringLength;
			return pattern[currentPos];
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		private bool IsOnlyTopOption(RegexOptions option)
		{
			return true;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00011CB4 File Offset: 0x0000FEB4
		private void ScanOptions()
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			char c = pattern[currentPos];
			if (stringLength == 0)
			{
			}
			RegexOptions regexOptions = RegexParser.OptionFromCode(c);
			RegexOptions options = this._options;
			this._options = options;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00011D24 File Offset: 0x0000FF24
		private char ScanCharEscape()
		{
			int num = 1;
			int currentPos = this._currentPos;
			string pattern = this._pattern;
			this._currentPos = num;
			char c = pattern[currentPos];
			int currentPos2 = this._currentPos;
			this._currentPos = currentPos2;
			return this.ScanOctal();
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00011DC8 File Offset: 0x0000FFC8
		private string ParseProperty()
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			this._currentPos = stringLength;
			char c = pattern[currentPos];
			int currentPos2 = this._currentPos;
			string pattern2 = this._pattern;
			int stringLength2 = pattern2._stringLength;
			long num = 0L;
			this._currentPos = stringLength2;
			bool flag = RegexCharClass.IsWordChar(pattern2[currentPos2]);
			int currentPos3 = this._currentPos;
			string pattern3 = this._pattern;
			this._currentPos = currentPos3;
			string text = pattern3.Substring(currentPos2, (int)num);
			string pattern4 = this._pattern;
			int currentPos4 = this._currentPos;
			int stringLength3 = pattern4._stringLength;
			this._currentPos = stringLength3;
			char c2 = pattern4[currentPos4];
			return text;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00011E94 File Offset: 0x00010094
		private int TypeFromCode(char ch)
		{
			return 19;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00011EB8 File Offset: 0x000100B8
		private static RegexOptions OptionFromCode(char ch)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00011ECC File Offset: 0x000100CC
		private void CountCaptures()
		{
			long num = 0L;
			long num2 = 0L;
			this.NoteCaptureSlot((int)num, (int)num2);
			string pattern = this._pattern;
			int num3 = 1;
			this._autocap = num3;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			this._currentPos = stringLength;
			char c = pattern[currentPos];
			string pattern2 = this._pattern;
			int currentPos2 = this._currentPos;
			int stringLength2 = pattern2._stringLength;
			char c2 = pattern2[currentPos];
			string pattern3 = this._pattern;
			int currentPos3 = this._currentPos;
			char c3 = pattern3[currentPos3];
			int currentPos4 = this._currentPos;
			this._currentPos = currentPos4;
			this.ScanBlank();
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00012140 File Offset: 0x00010340
		private void NoteCaptureSlot(int i, int pos)
		{
			Hashtable caps = this._caps;
			Hashtable caps2 = this._caps;
			int capcount = this._capcount;
			int capsize = this._capsize;
			this._capcount = capcount;
			this._captop = capcount;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		private void NoteCaptureName(string name, int pos)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00012178 File Offset: 0x00010378
		private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames)
		{
			this._capsize = capsize;
			this._caps = caps;
			this._capnames = capnames;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		private void AssignNameSlots()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0001219C File Offset: 0x0001039C
		private int CaptureSlotFromName(string capname)
		{
			Hashtable capnames = this._capnames;
			throw new InvalidCastException();
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000121B8 File Offset: 0x000103B8
		private bool IsCaptureSlot(int i)
		{
			/*
An exception occurred when decompiling this method (06000434)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::IsCaptureSlot(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int32(var_0_0E, ldfld:int32(RegexParser::_capsize, ldloc:RegexParser(this)))
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

		// Token: 0x06000435 RID: 1077 RVA: 0x000121D8 File Offset: 0x000103D8
		private bool IsCaptureName(string capname)
		{
			/*
An exception occurred when decompiling this method (06000435)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::IsCaptureName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:Hashtable[exp:bool](RegexParser::_capnames, ldloc:RegexParser(this))))
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

		// Token: 0x06000436 RID: 1078 RVA: 0x000121EC File Offset: 0x000103EC
		private bool UseOptionN()
		{
			/*
An exception occurred when decompiling this method (06000436)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::UseOptionN()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexOptions(var_0_06, ldfld:RegexOptions(RegexParser::_options, ldloc:RegexParser(this)))
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

		// Token: 0x06000437 RID: 1079 RVA: 0x00012200 File Offset: 0x00010400
		private bool UseOptionI()
		{
			/*
An exception occurred when decompiling this method (06000437)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::UseOptionI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexOptions(var_0_06, ldfld:RegexOptions(RegexParser::_options, ldloc:RegexParser(this)))
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

		// Token: 0x06000438 RID: 1080 RVA: 0x00012214 File Offset: 0x00010414
		private bool UseOptionM()
		{
			/*
An exception occurred when decompiling this method (06000438)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::UseOptionM()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexOptions(var_0_06, ldfld:RegexOptions(RegexParser::_options, ldloc:RegexParser(this)))
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

		// Token: 0x06000439 RID: 1081 RVA: 0x00012228 File Offset: 0x00010428
		private bool UseOptionS()
		{
			/*
An exception occurred when decompiling this method (06000439)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::UseOptionS()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexOptions(var_0_06, ldfld:RegexOptions(RegexParser::_options, ldloc:RegexParser(this)))
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

		// Token: 0x0600043A RID: 1082 RVA: 0x0001223C File Offset: 0x0001043C
		private bool UseOptionX()
		{
			/*
An exception occurred when decompiling this method (0600043A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::UseOptionX()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexOptions(var_0_06, ldfld:RegexOptions(RegexParser::_options, ldloc:RegexParser(this)))
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

		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		private bool UseOptionE()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00012250 File Offset: 0x00010450
		private static bool IsSpecial(char ch)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00012264 File Offset: 0x00010464
		private static bool IsStopperX(char ch)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00012278 File Offset: 0x00010478
		private static bool IsQuantifier(char ch)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0001228C File Offset: 0x0001048C
		private bool IsTrueQuantifier()
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			int stringLength = pattern._stringLength;
			char c = pattern[currentPos];
			char c2 = this._pattern[currentPos];
			if (stringLength == 0)
			{
				return;
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000122D0 File Offset: 0x000104D0
		private static bool IsSpace(char ch)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000122E4 File Offset: 0x000104E4
		private static bool IsMetachar(char ch)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000122F8 File Offset: 0x000104F8
		private void AddConcatenate(int pos, int cch, bool isReplacement)
		{
			if (cch != 0)
			{
				char c = this._pattern[pos];
				RegexOptions options = this._options;
				CultureInfo culture = this._culture;
				RegexOptions options2 = this._options;
				return;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00012384 File Offset: 0x00010584
		private void PushGroup()
		{
			RegexNode stack = this._stack;
			RegexNode group = this._group;
			group.Next = stack;
			RegexNode alternation = this._alternation;
			alternation.Next = group;
			RegexNode concatenation = this._concatenation;
			concatenation.Next = alternation;
			this._stack = concatenation;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000123CC File Offset: 0x000105CC
		private void PopGroup()
		{
			/*
An exception occurred when decompiling this method (06000444)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Text.RegularExpressions.RegexParser::PopGroup()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006F:
	stloc:ArgumentException(var_7_7A, call:ArgumentException(RegexParser::MakeException, ldloc:RegexParser(this), ldstr:string("Illegal conditional (?(...)) expression.")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000445 RID: 1093 RVA: 0x00012454 File Offset: 0x00010654
		private bool EmptyStack()
		{
			/*
An exception occurred when decompiling this method (06000445)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::EmptyStack()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexNode(var_0_06, ldfld:RegexNode(RegexParser::_stack, ldloc:RegexParser(this)))
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

		// Token: 0x06000446 RID: 1094 RVA: 0x00012468 File Offset: 0x00010668
		private void StartGroup(RegexNode openGroup)
		{
			this._group = openGroup;
			RegexOptions options = this._options;
			RegexOptions options2 = this._options;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001248C File Offset: 0x0001068C
		private void AddAlternate()
		{
			int ntype = this._group.NType;
			RegexNode alternation = this._alternation;
			RegexNode concatenation = this._concatenation;
			RegexNode regexNode = concatenation.ReverseLeft();
			alternation.AddChild(concatenation);
			RegexOptions options = this._options;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000124CC File Offset: 0x000106CC
		private void AddConcatenate()
		{
			RegexNode concatenation = this._concatenation;
			RegexNode unit = this._unit;
			concatenation.AddChild(unit);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000124F0 File Offset: 0x000106F0
		private void AddConcatenate(bool lazy, int min, int max)
		{
			RegexNode concatenation = this._concatenation;
			RegexNode regexNode = this._unit.MakeQuantifier(lazy, min, max);
			concatenation.AddChild(regexNode);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001251C File Offset: 0x0001071C
		private RegexNode Unit()
		{
			return this._unit;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00012530 File Offset: 0x00010730
		private void AddUnitOne(char ch)
		{
			RegexOptions options = this._options;
			CultureInfo culture = this._culture;
			RegexOptions options2 = this._options;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00012554 File Offset: 0x00010754
		private void AddUnitNotone(char ch)
		{
			RegexOptions options = this._options;
			CultureInfo culture = this._culture;
			RegexOptions options2 = this._options;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00012578 File Offset: 0x00010778
		private void AddUnitSet(string cc)
		{
			RegexOptions options = this._options;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001258C File Offset: 0x0001078C
		private void AddUnitNode(RegexNode node)
		{
			this._unit = node;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000125A0 File Offset: 0x000107A0
		private void AddUnitType(int type)
		{
			RegexOptions options = this._options;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000125B4 File Offset: 0x000107B4
		private void AddGroup()
		{
			RegexNode group = this._group;
			int ntype = group.NType;
			RegexNode concatenation = this._concatenation;
			RegexNode regexNode = concatenation.ReverseLeft();
			group.AddChild(concatenation);
			RegexNode group2 = this._group;
			int ntype2 = group2.NType;
			List<RegexNode> children = group2.Children;
			if (children != null)
			{
				int size = children._size;
			}
			RegexNode group3 = this._group;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		private void PushOptions()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00012690 File Offset: 0x00010890
		private void PopOptions()
		{
			List<RegexOptions> optionsStack = this._optionsStack;
			int size = optionsStack._size;
			List<RegexOptions> optionsStack2 = this._optionsStack;
			this._options = optionsStack;
			int size2 = optionsStack2._size;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000126C0 File Offset: 0x000108C0
		private bool EmptyOptionsStack()
		{
			/*
An exception occurred when decompiling this method (06000453)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexParser::EmptyOptionsStack()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype System.Text.RegularExpressions.RegexOptions>[exp:List`1](RegexParser::_optionsStack, ldloc:RegexParser(this))))
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

		// Token: 0x06000454 RID: 1108 RVA: 0x000126D8 File Offset: 0x000108D8
		private void PopKeepOptions()
		{
			int size = this._optionsStack._size;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000126F4 File Offset: 0x000108F4
		private ArgumentException MakeException(string message)
		{
			/*
An exception occurred when decompiling this method (06000455)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ArgumentException System.Text.RegularExpressions.RegexParser::MakeException(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(RegexParser::_pattern, ldloc:RegexParser(this)))
	stloc:string(var_1_13, call:string(SR::Format, ldstr:string("parsing \"{0}\" - {1}"), ldloc:string[exp:object](var_0_06), ldloc:string[exp:object](message)))
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

		// Token: 0x06000456 RID: 1110 RVA: 0x00012714 File Offset: 0x00010914
		private int Textpos()
		{
			return this._currentPos;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00012728 File Offset: 0x00010928
		private void Textto(int pos)
		{
			this._currentPos = pos;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0001273C File Offset: 0x0001093C
		private char RightCharMoveRight()
		{
			int currentPos = this._currentPos;
			return this._pattern[currentPos];
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001275C File Offset: 0x0001095C
		private void MoveRight()
		{
			int currentPos = this._currentPos;
			this._currentPos = currentPos;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00012778 File Offset: 0x00010978
		private void MoveRight(int i)
		{
			int currentPos = this._currentPos;
			this._currentPos = currentPos;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00012794 File Offset: 0x00010994
		private void MoveLeft()
		{
			int currentPos = this._currentPos;
			this._currentPos = currentPos;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000127B0 File Offset: 0x000109B0
		private char CharAt(int i)
		{
			return this._pattern[i];
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000127CC File Offset: 0x000109CC
		internal char RightChar()
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			return pattern[currentPos];
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000127F0 File Offset: 0x000109F0
		private char RightChar(int i)
		{
			int currentPos = this._currentPos;
			return this._pattern[i];
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00012810 File Offset: 0x00010A10
		private int CharsRight()
		{
			/*
An exception occurred when decompiling this method (0600045F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexParser::CharsRight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(RegexParser::_pattern, ldloc:RegexParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(RegexParser::_currentPos, ldloc:RegexParser(this)))
	stloc:int32(var_2_14, ldfld:int32(string::_stringLength, ldloc:string(var_0_06)))
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

		// Token: 0x06000460 RID: 1120 RVA: 0x00012834 File Offset: 0x00010A34
		// Note: this type is marked as 'beforefieldinit'.
		static RegexParser()
		{
		}

		// Token: 0x0400034C RID: 844
		private RegexNode _stack;

		// Token: 0x0400034D RID: 845
		private RegexNode _group;

		// Token: 0x0400034E RID: 846
		private RegexNode _alternation;

		// Token: 0x0400034F RID: 847
		private RegexNode _concatenation;

		// Token: 0x04000350 RID: 848
		private RegexNode _unit;

		// Token: 0x04000351 RID: 849
		private string _pattern;

		// Token: 0x04000352 RID: 850
		private int _currentPos;

		// Token: 0x04000353 RID: 851
		private CultureInfo _culture;

		// Token: 0x04000354 RID: 852
		private int _autocap;

		// Token: 0x04000355 RID: 853
		private int _capcount;

		// Token: 0x04000356 RID: 854
		private int _captop;

		// Token: 0x04000357 RID: 855
		private int _capsize;

		// Token: 0x04000358 RID: 856
		private Hashtable _caps;

		// Token: 0x04000359 RID: 857
		private Hashtable _capnames;

		// Token: 0x0400035A RID: 858
		private int[] _capnumlist;

		// Token: 0x0400035B RID: 859
		private List<string> _capnamelist;

		// Token: 0x0400035C RID: 860
		private RegexOptions _options;

		// Token: 0x0400035D RID: 861
		private List<RegexOptions> _optionsStack;

		// Token: 0x0400035E RID: 862
		private bool _ignoreNextParen;

		// Token: 0x0400035F RID: 863
		private static readonly byte[] s_category;
	}
}
