using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B4 RID: 180
	internal sealed class RegexCharClass
	{
		// Token: 0x0600038C RID: 908 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		public RegexCharClass()
		{
			this._canonical = true;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000C618 File Offset: 0x0000A818
		private RegexCharClass(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
		{
			this._rangelist = ranges;
			this._categories = categories;
			this._canonical = true;
			this._subtractor = subtraction;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000C648 File Offset: 0x0000A848
		public bool CanMerge
		{
			get
			{
				while (!this._negate)
				{
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000C660 File Offset: 0x0000A860
		public bool Negate
		{
			set
			{
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000C670 File Offset: 0x0000A870
		public void AddChar(char c)
		{
			this.AddRange(c, c);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		public void AddCharClass(RegexCharClass cc)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		private void AddSet(string set)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000C688 File Offset: 0x0000A888
		public void AddSubtraction(RegexCharClass sub)
		{
			this._subtractor = sub;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		public void AddRange(char first, char last)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000C69C File Offset: 0x0000A89C
		public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text = RegexCharClass.SetFromProperty(categoryName, true, pattern);
			this.AddSet(text);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000C708 File Offset: 0x0000A908
		private void AddCategory(string category)
		{
			StringBuilder stringBuilder = this._categories.Append(category);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000C724 File Offset: 0x0000A924
		public void AddLowercase(CultureInfo culture)
		{
			int size = this._rangelist._size;
			List<RegexCharClass.SingleRange> rangelist = this._rangelist;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000C750 File Offset: 0x0000A950
		private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000C780 File Offset: 0x0000A980
		public void AddWord(bool ecma, bool negate)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000C7BC File Offset: 0x0000A9BC
		public void AddSpace(bool ecma, bool negate)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		public void AddDigit(bool ecma, bool negate, string pattern)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000C824 File Offset: 0x0000AA24
		public static char SingletonChar(string set)
		{
			char c;
			return c;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000C834 File Offset: 0x0000AA34
		public static bool IsMergeable(string charClass)
		{
			if (true)
			{
			}
			if (!false)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public static bool IsEmpty(string charClass)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000C860 File Offset: 0x0000AA60
		public static bool IsSingleton(string set)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000C884 File Offset: 0x0000AA84
		public static bool IsSingletonInverse(string set)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		private static bool IsSubtraction(string charClass)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		private static bool IsNegated(string set)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
		public static bool IsECMAWordChar(char ch)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000C8DC File Offset: 0x0000AADC
		public static bool IsWordChar(char ch)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		public static bool CharInClass(char ch, string set)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000C904 File Offset: 0x0000AB04
		private static bool CharInClassRecursive(char ch, string set, int start)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000C920 File Offset: 0x0000AB20
		private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			if (start != 0)
			{
			}
			if (mySetLength != 0)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000C93C File Offset: 0x0000AB3C
		private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, int i)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000C964 File Offset: 0x0000AB64
		private static string NegateCategory(string category)
		{
			long num = 0L;
			StringBuilder stringBuilder2;
			StringBuilder stringBuilder = stringBuilder2.Append((char)num);
			return StringBuilderCache.GetStringAndRelease(stringBuilder2);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000C988 File Offset: 0x0000AB88
		public static RegexCharClass Parse(string charClass)
		{
			if (!true)
			{
			}
			RegexCharClass regexCharClass;
			return regexCharClass;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000C99C File Offset: 0x0000AB9C
		private static RegexCharClass ParseRecursive(string charClass, int start)
		{
			RegexCharClass regexCharClass;
			return regexCharClass;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		private int RangeCount()
		{
			return this._rangelist._size;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		public string ToStringClass()
		{
			if (!this._canonical)
			{
				this.Canonicalize();
			}
			List<RegexCharClass.SingleRange> rangelist = this._rangelist;
			StringBuilder categories = this._categories;
			int size = rangelist._size;
			StringBuilder stringBuilder = StringBuilderCache.Acquire(categories.Length);
			bool negate = this._negate;
			StringBuilder stringBuilder2 = stringBuilder.Append(negate ? '\u0001' : '\0');
			StringBuilder stringBuilder3 = stringBuilder.Append(negate ? '\u0001' : '\0');
			int length = this._categories.Length;
			StringBuilder stringBuilder4 = stringBuilder.Append((char)length);
			int size2 = this._rangelist._size;
			long num = 0L;
			int size3 = this._rangelist._size;
			int length2 = stringBuilder.Length;
			int num2 = 1;
			stringBuilder[num2] = (char)num;
			StringBuilder categories2 = this._categories;
			StringBuilder stringBuilder5 = stringBuilder.Append(categories2);
			RegexCharClass subtractor = this._subtractor;
			if (subtractor != null)
			{
				string text = subtractor.ToStringClass();
				StringBuilder stringBuilder6 = stringBuilder.Append(text);
			}
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		private RegexCharClass.SingleRange GetRangeAt(int i)
		{
			/*
An exception occurred when decompiling this method (060003AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.RegexCharClass/SingleRange System.Text.RegularExpressions.RegexCharClass::GetRangeAt(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype System.Text.RegularExpressions.RegexCharClass/SingleRange>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype System.Text.RegularExpressions.RegexCharClass/SingleRange>(RegexCharClass::_rangelist, ldloc:RegexCharClass(this)))
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

		// Token: 0x060003B0 RID: 944 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		private void Canonicalize()
		{
			int num = 1;
			this._canonical = num != 0;
			List<RegexCharClass.SingleRange> rangelist = this._rangelist;
			if (num == 0)
			{
			}
			int size = this._rangelist._size;
			int size2 = this._rangelist._size;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000CB44 File Offset: 0x0000AD44
		private static string SetFromProperty(string capname, bool invert, string pattern)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			if (num2 != 0)
			{
				string text = SR.Format("Unknown property '{0}'.", capname);
				string text2 = SR.Format("parsing \"{0}\" - {1}", invert, text);
			}
			if (num == 0)
			{
			}
			string text3;
			return text3;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000CB88 File Offset: 0x0000AD88
		// Note: this type is marked as 'beforefieldinit'.
		static RegexCharClass()
		{
		}

		// Token: 0x040002D5 RID: 725
		private static readonly string s_internalRegexIgnoreCase;

		// Token: 0x040002D6 RID: 726
		private static readonly string s_space;

		// Token: 0x040002D7 RID: 727
		private static readonly string s_notSpace;

		// Token: 0x040002D8 RID: 728
		private static readonly string s_word;

		// Token: 0x040002D9 RID: 729
		private static readonly string s_notWord;

		// Token: 0x040002DA RID: 730
		public static readonly string SpaceClass;

		// Token: 0x040002DB RID: 731
		public static readonly string NotSpaceClass;

		// Token: 0x040002DC RID: 732
		public static readonly string WordClass;

		// Token: 0x040002DD RID: 733
		public static readonly string NotWordClass;

		// Token: 0x040002DE RID: 734
		public static readonly string DigitClass;

		// Token: 0x040002DF RID: 735
		public static readonly string NotDigitClass;

		// Token: 0x040002E0 RID: 736
		private static readonly Dictionary<string, string> s_definedCategories;

		// Token: 0x040002E1 RID: 737
		private static readonly string[][] s_propTable;

		// Token: 0x040002E2 RID: 738
		private static readonly RegexCharClass.LowerCaseMapping[] s_lcTable;

		// Token: 0x040002E3 RID: 739
		private List<RegexCharClass.SingleRange> _rangelist;

		// Token: 0x040002E4 RID: 740
		private StringBuilder _categories;

		// Token: 0x040002E5 RID: 741
		private bool _canonical;

		// Token: 0x040002E6 RID: 742
		private bool _negate;

		// Token: 0x040002E7 RID: 743
		private RegexCharClass _subtractor;

		// Token: 0x020000B5 RID: 181
		private readonly struct LowerCaseMapping
		{
			// Token: 0x060003B3 RID: 947 RVA: 0x0000E568 File Offset: 0x0000C768
			internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
			{
				this.ChMin = chMin;
				this.ChMax = chMax;
				this.LcOp = lcOp;
			}

			// Token: 0x040002E8 RID: 744
			public readonly char ChMin;

			// Token: 0x040002E9 RID: 745
			public readonly char ChMax;

			// Token: 0x040002EA RID: 746
			public readonly int LcOp;

			// Token: 0x040002EB RID: 747
			public readonly int Data;
		}

		// Token: 0x020000B6 RID: 182
		private sealed class SingleRangeComparer : IComparer<RegexCharClass.SingleRange>
		{
			// Token: 0x060003B4 RID: 948 RVA: 0x0000E58C File Offset: 0x0000C78C
			private SingleRangeComparer()
			{
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
			public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y)
			{
				int num;
				return num;
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
			// Note: this type is marked as 'beforefieldinit'.
			static SingleRangeComparer()
			{
			}

			// Token: 0x040002EC RID: 748
			public static readonly RegexCharClass.SingleRangeComparer Instance;
		}

		// Token: 0x020000B7 RID: 183
		private readonly struct SingleRange
		{
			// Token: 0x060003B7 RID: 951 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
			internal SingleRange(char first, char last)
			{
				this.First = first;
				this.Last = last;
			}

			// Token: 0x040002ED RID: 749
			public readonly char First;

			// Token: 0x040002EE RID: 750
			public readonly char Last;
		}
	}
}
