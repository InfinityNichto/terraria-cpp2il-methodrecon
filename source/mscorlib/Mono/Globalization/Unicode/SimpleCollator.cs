using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Mono.Globalization.Unicode
{
	// Token: 0x0200003A RID: 58
	internal class SimpleCollator : ISimpleCollator
	{
		// Token: 0x060000CA RID: 202 RVA: 0x000035EC File Offset: 0x000017EC
		public SimpleCollator(CultureInfo culture)
		{
			TailoringInfo tailoringInfo;
			do
			{
				base..ctor();
				this.lcid = culture;
				this.textInfo = culture;
			}
			while (tailoringInfo != null);
			bool flag = MSCompatUnicodeTable.GetTailoringInfo(127).FrenchSort;
			this.frenchSort = flag;
			if (!flag)
			{
			}
			Contraction[] array = this.contractions;
			char[] source = array.Source;
			byte[] array2 = this.unsafeFlags;
			char[] source2 = array.Source;
			if (this.lcid == 0)
			{
			}
			byte[] array3 = this.unsafeFlags;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003668 File Offset: 0x00001868
		private unsafe void SetCJKTable(CultureInfo culture, CodePointIndexer cjkIndexer, byte* catTable, byte* lv1Table, CodePointIndexer lv2Indexer, byte* lv2Table)
		{
			if (!true)
			{
			}
			CultureInfo neutralCulture = SimpleCollator.GetNeutralCulture(culture);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000207A File Offset: 0x0000027A
		private static CultureInfo GetNeutralCulture(CultureInfo info)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003680 File Offset: 0x00001880
		private byte Category(int cp)
		{
			if (this.cjkCatTable != null)
			{
				int num = this.cjkIndexer.ToIndex(cp);
			}
			if (!true)
			{
			}
			return MSCompatUnicodeTable.Category(cp);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000036AC File Offset: 0x000018AC
		private byte Level1(int cp)
		{
			if (this.cjkLv1Table != null)
			{
				int num = this.cjkIndexer.ToIndex(cp);
			}
			if (!true)
			{
			}
			return MSCompatUnicodeTable.Level1(cp);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000036D8 File Offset: 0x000018D8
		private byte Level2(int cp, SimpleCollator.ExtenderType ext)
		{
			int num;
			do
			{
				num = 1;
				if (this.cjkLv2Table == null)
				{
					goto IL_0033;
				}
			}
			while (this.cjkLv2Indexer.ToIndex(cp) != 0);
			if (num == 0)
			{
			}
			byte b = MSCompatUnicodeTable.Level2(cp);
			Level2Map[] array = this.level2Maps;
			return b;
			IL_0033:
			if (array == null)
			{
			}
			return MSCompatUnicodeTable.Level2(cp);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000372C File Offset: 0x0000192C
		private static bool IsHalfKana(int cp, CompareOptions opt)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000373C File Offset: 0x0000193C
		private Contraction GetContraction(string s, int start, int end)
		{
			Contraction[] array = this.contractions;
			Contraction contraction;
			int num;
			if (contraction == null)
			{
				num = this.lcid;
			}
			if (num == 0)
			{
			}
			Contraction contraction2;
			return contraction2;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003764 File Offset: 0x00001964
		private Contraction GetContraction(string s, int start, int end, Contraction[] clist)
		{
			/*
An exception occurred when decompiling this method (060000D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Globalization.Unicode.Contraction Mono.Globalization.Unicode.SimpleCollator::GetContraction(System.String,System.Int32,System.Int32,Mono.Globalization.Unicode.Contraction[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_07, ldfld:char[](Contraction::Source, ldloc:class Mono.Globalization.Unicode.Contraction[][exp:Contraction](clist)))
	stloc:char(var_2_11, callgetter:char(string::get_Chars, ldloc:string(s), ldloc:int32(start)))
	stloc:char(var_4_1B, callgetter:char(string::get_Chars, ldloc:string(s), ldloc:int32(start)))
	stloc:char[](var_5_24, ldfld:char[](Contraction::Source, ldloc:class Mono.Globalization.Unicode.Contraction[][exp:Contraction](clist)))
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

		// Token: 0x060000D3 RID: 211 RVA: 0x0000379C File Offset: 0x0000199C
		private Contraction GetTailContraction(string s, int start, int end)
		{
			Contraction[] array = this.contractions;
			Contraction contraction;
			int num;
			if (contraction == null)
			{
				num = this.lcid;
			}
			if (num == 0)
			{
			}
			Contraction contraction2;
			return contraction2;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000037C4 File Offset: 0x000019C4
		private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist)
		{
			/*
An exception occurred when decompiling this method (060000D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Globalization.Unicode.Contraction Mono.Globalization.Unicode.SimpleCollator::GetTailContraction(System.String,System.Int32,System.Int32,Mono.Globalization.Unicode.Contraction[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(s)))
	stloc:char[](var_1_0E, ldfld:char[](Contraction::Source, ldloc:class Mono.Globalization.Unicode.Contraction[][exp:Contraction](clist)))
	stloc:char(var_3_18, callgetter:char(string::get_Chars, ldloc:string(s), ldloc:int32(start)))
	stloc:char(var_5_23, callgetter:char(string::get_Chars, ldloc:string(s), ldloc:int32(start)))
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

		// Token: 0x060000D5 RID: 213 RVA: 0x000037F8 File Offset: 0x000019F8
		private int FilterOptions(int i, CompareOptions opt)
		{
			if (!true)
			{
			}
			int num = MSCompatUnicodeTable.ToWidthCompat(i);
			TextInfo textInfo = this.textInfo;
			TextInfo textInfo2 = this.textInfo;
			return i;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000382C File Offset: 0x00001A2C
		private SimpleCollator.ExtenderType GetExtenderType(int i)
		{
			/*
An exception occurred when decompiling this method (060000D6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Globalization.Unicode.SimpleCollator/ExtenderType Mono.Globalization.Unicode.SimpleCollator::GetExtenderType(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_0C, ldfld:int32(SimpleCollator::lcid, ldloc:SimpleCollator(this)))
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

		// Token: 0x060000D7 RID: 215 RVA: 0x0000207A File Offset: 0x0000027A
		private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000038B0 File Offset: 0x00001AB0
		private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			if (!true)
			{
			}
			byte b = this.Level1(i);
			return 65393;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000038F0 File Offset: 0x00001AF0
		private static bool IsIgnorable(int i, CompareOptions opt)
		{
			if (20480 == 0)
			{
			}
			return MSCompatUnicodeTable.IsIgnorable(42179864, (byte)i);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003910 File Offset: 0x00001B10
		private bool IsSafe(int i)
		{
			/*
An exception occurred when decompiling this method (060000DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Globalization.Unicode.SimpleCollator::IsSafe(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](SimpleCollator::unsafeFlags, ldloc:SimpleCollator(this)))
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

		// Token: 0x060000DB RID: 219 RVA: 0x00003928 File Offset: 0x00001B28
		public SortKey GetSortKey(string s, CompareOptions options)
		{
			int stringLength = s._stringLength;
			long num = 0L;
			return this.GetSortKey(s, (int)num, stringLength, options);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003948 File Offset: 0x00001B48
		public SortKey GetSortKey(string s, int start, int length, CompareOptions options)
		{
			int num = this.lcid;
			bool flag = this.frenchSort;
			SortKey sortKey;
			return sortKey;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003964 File Offset: 0x00001B64
		private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt)
		{
			char c = s[start];
			SimpleCollator.ExtenderType extenderType;
			if (extenderType != SimpleCollator.ExtenderType.None)
			{
				int num = this.FilterExtender(43151360, extenderType, opt);
				return;
			}
			bool flag = SimpleCollator.IsIgnorable(43151360, opt);
			int num2 = this.FilterOptions(43151360, opt);
			Contraction contraction = this.GetContraction(s, start, end);
			if (contraction == null)
			{
				bool flag2 = MSCompatUnicodeTable.IsIgnorableNonSpacing(num2);
				return;
			}
			string replacement = contraction.Replacement;
			if (replacement != null)
			{
				int stringLength = replacement._stringLength;
				return;
			}
			byte b = MSCompatUnicodeTable.Level3(num2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000039FC File Offset: 0x00001BFC
		private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt)
		{
			UnicodeCategory unicodeCategory = char.GetUnicodeCategory((char)i);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003AB0 File Offset: 0x00001CB0
		private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003AD8 File Offset: 0x00001CD8
		int ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			return this.Compare(s1, idx1, len1, s2, idx2, len2, options);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003AF8 File Offset: 0x00001CF8
		internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			int num;
			return num;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003B0C File Offset: 0x00001D0C
		private unsafe void ClearBuffer(byte* buffer, int size)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003B1C File Offset: 0x00001D1C
		private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, [Out] bool targetConsumed, [Out] bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, SimpleCollator.Context ctx)
		{
			SimpleCollator.ExtenderType extenderType;
			if (extenderType != SimpleCollator.ExtenderType.None)
			{
			}
			char c = s2[idx2];
			SimpleCollator.ExtenderType extenderType2;
			if (extenderType2 != SimpleCollator.ExtenderType.None)
			{
			}
			long num = 0L;
			char c2 = s1[43151360];
			if (num == 0L)
			{
			}
			bool flag = SimpleCollator.IsIgnorable(42185744, (CompareOptions)43151360);
			char c3 = s2[idx2];
			if (num == 0L)
			{
			}
			char c4 = s1[43151360];
			char c5 = s2[idx2];
			char c6 = s1[43151360];
			char c7 = s1[43151360];
			while (idx2 != 0)
			{
			}
			while (idx2 != 0)
			{
			}
			char c8 = s1[43151360];
			char c9 = s2[idx2];
			SimpleCollator.ExtenderType extenderType3;
			if (extenderType3 != SimpleCollator.ExtenderType.None)
			{
			}
			SimpleCollator.ExtenderType extenderType4;
			int num2;
			if (extenderType4 != SimpleCollator.ExtenderType.None)
			{
				return num2;
			}
			return num2;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003DB8 File Offset: 0x00001FB8
		private int CompareFlagPair(bool b1, bool b2)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public bool IsPrefix(string src, string target, CompareOptions opt)
		{
			int stringLength = src._stringLength;
			long num = 0L;
			return this.IsPrefix(src, target, (int)num, stringLength, opt);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003DEC File Offset: 0x00001FEC
		public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt)
		{
			int stringLength = target._stringLength;
			if (stringLength != 0)
			{
				int stringLength2 = target._stringLength;
				stringLength.m_value = stringLength;
				return;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003E1C File Offset: 0x0000201C
		private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, SimpleCollator.Context ctx)
		{
			/*
An exception occurred when decompiling this method (060000E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Globalization.Unicode.SimpleCollator::IsPrefix(System.String,System.String,System.Int32,System.Int32,System.Boolean,Mono.Globalization.Unicode.SimpleCollator/Context)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(target)))
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

		// Token: 0x060000E8 RID: 232 RVA: 0x00003E30 File Offset: 0x00002030
		public bool IsSuffix(string src, string target, CompareOptions opt)
		{
			int stringLength = src._stringLength;
			bool flag;
			return flag;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003E48 File Offset: 0x00002048
		public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt)
		{
			if (target._stringLength != 0)
			{
				int num = this.LastIndexOf(s, target, start, length, opt);
				int stringLength = s._stringLength;
				int stringLength2 = target._stringLength;
				long num2 = 0L;
				int num3 = this.Compare(s, num, start, target, (int)num2, stringLength2, opt);
				return;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003E90 File Offset: 0x00002090
		private int QuickIndexOf(string s, string target, int start, int length, [Out] bool testWasUnable)
		{
			/*
An exception occurred when decompiling this method (060000EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Globalization.Unicode.SimpleCollator::QuickIndexOf(System.String,System.String,System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004E:
	stloc:int32(var_10_52, ldc.i4:int32(1))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](testWasUnable), ldloc:int32[exp:bool](var_10_52))
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

		// Token: 0x060000EB RID: 235 RVA: 0x00003EFC File Offset: 0x000020FC
		public int IndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			while (opt == CompareOptions.None)
			{
			}
			if (16384 != 0)
			{
			}
			int num;
			return num;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003F2C File Offset: 0x0000212C
		private int IndexOfOrdinal(string s, string target, int start, int length)
		{
			if (target._stringLength != 0)
			{
				long num = 0L;
				char c = target[(int)num];
				int stringLength = target._stringLength;
				int stringLength2 = target._stringLength;
				return;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003F5C File Offset: 0x0000215C
		private int IndexOfOrdinal(string s, char target, int start, int length)
		{
			char c = s[start];
			return start;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003F74 File Offset: 0x00002174
		private unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, SimpleCollator.Context ctx)
		{
			return start;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003F84 File Offset: 0x00002184
		private unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, SimpleCollator.Context ctx)
		{
			int stringLength = target._stringLength;
			long num = 0L;
			char c = target[(int)num];
			int stringLength2 = target._stringLength;
			int stringLength3 = target._stringLength;
			long num2 = 0L;
			char c2 = target[(int)num2];
			Contraction contraction = this.GetContraction(target, start, start);
			int num3;
			byte[] sortKey2;
			if (contraction != null)
			{
				string replacement = contraction.Replacement;
				if (targetSortKey == null)
				{
					return num3;
				}
				byte[] sortKey = contraction.SortKey;
				targetSortKey->m_value = sortKey;
				sortKey2 = contraction.SortKey;
			}
			if (targetSortKey != null)
			{
				char c3 = target[start];
				char c4 = target[start];
				int num4;
				byte b = this.Category(num4);
				targetSortKey->m_value = b;
				byte b2 = this.Level1(num4);
				if (sortKey2 == null)
				{
				}
				byte b3 = MSCompatUnicodeTable.Level3(num4);
				return num3;
			}
			return num3;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000040C4 File Offset: 0x000022C4
		public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			int num;
			return num;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000040EC File Offset: 0x000022EC
		private int LastIndexOfOrdinal(string s, string target, int start, int length)
		{
			if (target._stringLength != 0)
			{
				int stringLength = s._stringLength;
				char c = s[start];
				int stringLength2 = target._stringLength;
				char c2 = s[start];
				char c3 = target[start];
			}
			return start;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000412C File Offset: 0x0000232C
		private unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, SimpleCollator.Context ctx)
		{
			return start;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000413C File Offset: 0x0000233C
		private unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, SimpleCollator.Context ctx)
		{
			int stringLength = target._stringLength;
			long num = 0L;
			char c = target[(int)num];
			int stringLength2 = target._stringLength;
			int stringLength3 = target._stringLength;
			long num2 = 0L;
			char c2 = target[(int)num2];
			Contraction contraction = this.GetContraction(target, (int)num, start);
			int num3;
			byte[] sortKey2;
			if (contraction != null)
			{
				string replacement = contraction.Replacement;
				if (targetSortKey == null)
				{
					return num3;
				}
				byte[] sortKey = contraction.SortKey;
				targetSortKey->m_value = sortKey;
				sortKey2 = contraction.SortKey;
			}
			if (targetSortKey != null)
			{
				char c3 = target[(int)num];
				int num4;
				byte b = this.Category(num4);
				targetSortKey->m_value = b;
				byte b2 = this.Level1(num4);
				if (sortKey2 == null)
				{
				}
				byte b3 = MSCompatUnicodeTable.Level3(num4);
				return num3;
			}
			return num3;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000427C File Offset: 0x0000247C
		private unsafe bool MatchesForward(string s, int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.Context ctx)
		{
			/*
An exception occurred when decompiling this method (060000F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Globalization.Unicode.SimpleCollator::MatchesForward(System.String,System.Int32,System.Int32,System.Int32,System.Byte*,System.Boolean,Mono.Globalization.Unicode.SimpleCollator/Context)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_4:
	stfld:uint8(uint8::m_value, ldloc:uint8*[exp:uint8&](var_7_2D), ldloc:int32[exp:uint8](var_1))
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

		// Token: 0x060000F5 RID: 245 RVA: 0x000042CC File Offset: 0x000024CC
		private unsafe bool MatchesForwardCore(string s, int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, Contraction ct, SimpleCollator.Context ctx)
		{
			if (ext != SimpleCollator.ExtenderType.None)
			{
			}
			Contraction contraction;
			long num2;
			if (contraction == null)
			{
				int num;
				byte b = this.Category(num);
				byte b2 = this.Level1(num);
				num2 = 0L;
				byte b3 = this.Level2(num, ext);
				byte b4 = MSCompatUnicodeTable.Level3(num);
			}
			if (num2 == 0L)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000431C File Offset: 0x0000251C
		private unsafe bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4)
		{
			int num = 12353;
			if (num == 0)
			{
			}
			bool flag = MSCompatUnicodeTable.IsJapaneseSmallLetter((char)si);
			bool flag2 = MSCompatUnicodeTable.IsJapaneseSmallLetter((char)ti);
			if (num == 0)
			{
			}
			if (ext == SimpleCollator.ExtenderType.None)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				return SimpleCollator.IsHalfKana(si, opt);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004370 File Offset: 0x00002570
		private unsafe bool MatchesBackward(string s, int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.Context ctx)
		{
			SimpleCollator.ExtenderType extenderType;
			while (extenderType != SimpleCollator.ExtenderType.None || extenderType != SimpleCollator.ExtenderType.None)
			{
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000438C File Offset: 0x0000258C
		private unsafe bool MatchesBackwardCore(string s, int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, Contraction ct, SimpleCollator.Context ctx)
		{
			int num;
			byte b = this.Category(num);
			long num2 = 0L;
			byte b2;
			Contraction tailContraction = this.GetTailContraction(s, (int)num2, (int)b2);
			bool flag;
			if (tailContraction != null)
			{
				char[] source = tailContraction.Source;
				idx.m_value = source;
				if (tailContraction.SortKey == null)
				{
					goto IL_0064;
				}
				if (false)
				{
					return flag;
				}
				int num3;
				byte b3 = this.Level1(num3);
				byte b4 = MSCompatUnicodeTable.Level3(num3);
			}
			int num4;
			byte b5 = this.Category(num4);
			byte b6 = this.Level1(num4);
			IL_0064:
			int num5 = 1;
			byte b7 = MSCompatUnicodeTable.Level3(num4);
			char c = s[num5];
			byte b8 = this.Category(num5);
			if (b2 == 0)
			{
			}
			char c2 = s[num5];
			return flag;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004430 File Offset: 0x00002630
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleCollator()
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		}

		// Token: 0x04000105 RID: 261
		private static SimpleCollator invariant;

		// Token: 0x04000106 RID: 262
		private readonly TextInfo textInfo;

		// Token: 0x04000107 RID: 263
		private readonly CodePointIndexer cjkIndexer;

		// Token: 0x04000108 RID: 264
		private readonly Contraction[] contractions;

		// Token: 0x04000109 RID: 265
		private readonly Level2Map[] level2Maps;

		// Token: 0x0400010A RID: 266
		private readonly byte[] unsafeFlags;

		// Token: 0x0400010B RID: 267
		private unsafe readonly byte* cjkCatTable;

		// Token: 0x0400010C RID: 268
		private unsafe readonly byte* cjkLv1Table;

		// Token: 0x0400010D RID: 269
		private unsafe readonly byte* cjkLv2Table;

		// Token: 0x0400010E RID: 270
		private readonly CodePointIndexer cjkLv2Indexer;

		// Token: 0x0400010F RID: 271
		private readonly int lcid;

		// Token: 0x04000110 RID: 272
		private readonly bool frenchSort;

		// Token: 0x0200003B RID: 59
		internal struct Context
		{
			// Token: 0x060000FA RID: 250 RVA: 0x00004448 File Offset: 0x00002648
			public unsafe Context(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
			{
				this.Option = opt;
				this.NeverMatchFlags = neverMatchFlags;
				this.AlwaysMatchFlags = alwaysMatchFlags;
				this.Buffer1 = buffer1;
				this.Buffer2 = buffer2;
				this.PrevSortKey = prev1;
			}

			// Token: 0x04000111 RID: 273
			public readonly CompareOptions Option;

			// Token: 0x04000112 RID: 274
			public unsafe readonly byte* NeverMatchFlags;

			// Token: 0x04000113 RID: 275
			public unsafe readonly byte* AlwaysMatchFlags;

			// Token: 0x04000114 RID: 276
			public unsafe byte* Buffer1;

			// Token: 0x04000115 RID: 277
			public unsafe byte* Buffer2;

			// Token: 0x04000116 RID: 278
			public int PrevCode;

			// Token: 0x04000117 RID: 279
			public unsafe byte* PrevSortKey;
		}

		// Token: 0x0200003C RID: 60
		private struct PreviousInfo
		{
			// Token: 0x060000FB RID: 251 RVA: 0x00004484 File Offset: 0x00002684
			public PreviousInfo(bool dummy)
			{
			}

			// Token: 0x04000118 RID: 280
			public int Code;

			// Token: 0x04000119 RID: 281
			public unsafe byte* SortKey;
		}

		// Token: 0x0200003D RID: 61
		private struct Escape
		{
			// Token: 0x0400011A RID: 282
			public string Source;

			// Token: 0x0400011B RID: 283
			public int Index;

			// Token: 0x0400011C RID: 284
			public int Start;

			// Token: 0x0400011D RID: 285
			public int End;

			// Token: 0x0400011E RID: 286
			public int Optional;
		}

		// Token: 0x0200003E RID: 62
		private enum ExtenderType
		{
			// Token: 0x04000120 RID: 288
			None,
			// Token: 0x04000121 RID: 289
			Simple,
			// Token: 0x04000122 RID: 290
			Voiced,
			// Token: 0x04000123 RID: 291
			Conditional,
			// Token: 0x04000124 RID: 292
			Buggy
		}
	}
}
