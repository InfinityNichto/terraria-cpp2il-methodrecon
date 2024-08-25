using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000AF RID: 175
	public class Regex : ISerializable
	{
		// Token: 0x06000353 RID: 851 RVA: 0x0000BA04 File Offset: 0x00009C04
		private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			if (!true)
			{
			}
			if (key._pattern == null)
			{
			}
			string text = key._pattern;
			return this.GetCachedCodeEntryInternal(key, isToAdd);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000BA30 File Offset: 0x00009C30
		private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			if (!true)
			{
			}
			string text = key._pattern;
			if (text == null)
			{
			}
			Regex.CachedCodeEntry cachedCodeEntry;
			long num2;
			if (cachedCodeEntry == null)
			{
				if (text == null)
				{
				}
				string text2 = key._pattern;
				Hashtable hashtable = this.caps;
				Hashtable hashtable2 = this.capnames;
				string[] array = this.capslist;
				int num = this.capsize;
				ExclusiveReference runnerref = this._runnerref;
				WeakReference<RegexReplacement> replref = this._replref;
				string text3 = key._pattern;
				if (text3 == null)
				{
				}
				if (text3 == null)
				{
				}
				if (text3 == null)
				{
				}
				string text4 = key._pattern;
				if (text3 == null)
				{
				}
				num2 = 0L;
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000BACC File Offset: 0x00009CCC
		private void FillCacheDictionary()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, [Out] Regex.CachedCodeEntry entry)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, [Out] Regex.CachedCodeEntry entry)
		{
			if (!true)
			{
			}
			if (true)
			{
				key._options = RegexOptions.IgnoreCase;
				if (true)
				{
					bool flag;
					return flag;
				}
			}
			return true;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000BB18 File Offset: 0x00009D18
		private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key)
		{
			/*
An exception occurred when decompiling this method (06000358)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.Regex/CachedCodeEntry System.Text.RegularExpressions.Regex::LookupCachedAndPromote(System.Text.RegularExpressions.Regex/CachedCodeEntryKey)

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

		// Token: 0x06000359 RID: 857 RVA: 0x0000BB28 File Offset: 0x00009D28
		public static bool IsMatch(string input, string pattern, RegexOptions options)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000BB3C File Offset: 0x00009D3C
		public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public bool IsMatch(string input)
		{
			while (input == null)
			{
			}
			RegexOptions regexOptions = this.roptions;
			int stringLength = input._stringLength;
			return this.IsMatch(input, stringLength);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000BB74 File Offset: 0x00009D74
		public bool IsMatch(string input, int startat)
		{
			/*
An exception occurred when decompiling this method (0600035C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.Regex::IsMatch(System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_09, ldfld:int32(string::_stringLength, ldloc:string(input)))
	stloc:int64(var_1_0B, ldc.i4:int64(0))
	stloc:Match(var_2_18, call:Match(Regex::Run, ldloc:Regex(this), ldc.i4:bool(1), ldloc:int32(startat), ldloc:string(input), ldloc:int64[exp:int32](var_1_0B), ldloc:int32(var_0_09), ldloc:int32(startat)))
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

		// Token: 0x0600035D RID: 861 RVA: 0x0000BB9C File Offset: 0x00009D9C
		public static Match Match(string input, string pattern)
		{
			if (!true)
			{
			}
			Match match;
			return match;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			Match match;
			return match;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000BBC0 File Offset: 0x00009DC0
		public Match Match(string input)
		{
			while (input == null)
			{
			}
			RegexOptions regexOptions = this.roptions;
			int stringLength = input._stringLength;
			return this.Match(input, stringLength);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000BBE8 File Offset: 0x00009DE8
		public Match Match(string input, int startat)
		{
			while (input == null)
			{
			}
			int stringLength = input._stringLength;
			long num = 0L;
			long num2 = 0L;
			return this.Run(num != 0L, startat, input, (int)num2, stringLength, startat);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000BC10 File Offset: 0x00009E10
		public MatchCollection Matches(string input)
		{
			while (input == null)
			{
			}
			RegexOptions regexOptions = this.roptions;
			int stringLength = input._stringLength;
			return this.Matches(input, stringLength);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000BC38 File Offset: 0x00009E38
		public MatchCollection Matches(string input, int startat)
		{
			/*
An exception occurred when decompiling this method (06000362)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.MatchCollection System.Text.RegularExpressions.Regex::Matches(System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_09, ldfld:int32(string::_stringLength, ldloc:string(input)))
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

		// Token: 0x06000363 RID: 867 RVA: 0x0000BC50 File Offset: 0x00009E50
		public static string Replace(string input, string pattern, string replacement)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000BC64 File Offset: 0x00009E64
		public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
		{
			string text;
			return text;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000BC74 File Offset: 0x00009E74
		public string Replace(string input, string replacement)
		{
			while (input == null)
			{
			}
			RegexOptions regexOptions = this.roptions;
			int stringLength = input._stringLength;
			string text;
			return text;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000BC94 File Offset: 0x00009E94
		public string Replace(string input, string replacement, int count, int startat)
		{
			while (input != null)
			{
				if (replacement != null)
				{
					WeakReference<RegexReplacement> replref = this._replref;
					int num = this.capsize;
					Hashtable hashtable = this.caps;
					Hashtable hashtable2 = this.capnames;
					RegexOptions regexOptions = this.roptions;
					return RegexReplacement.GetOrCreate(replref, replacement, hashtable, num, hashtable2, regexOptions).Replace(this, input, count, startat);
				}
			}
			return "input";
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public string Replace(string input, MatchEvaluator evaluator)
		{
			while (input == null)
			{
			}
			RegexOptions regexOptions = this.roptions;
			int stringLength = input._stringLength;
			string text;
			return text;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000BD08 File Offset: 0x00009F08
		public string Replace(string input, MatchEvaluator evaluator, int count, int startat)
		{
			while (input == null)
			{
			}
			return Regex.Replace(evaluator, this, input, count, startat);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000BD24 File Offset: 0x00009F24
		private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat)
		{
			Match match2;
			do
			{
				TimeSpan timeSpan = regex.internalMatchTimeout;
				Match match;
				if (input == null || match._capcount == 0)
				{
					goto IL_0052;
				}
				StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
				object target = evaluator.m_target;
				int <Index>k__BackingField = match.<Index>k__BackingField;
				int <Index>k__BackingField2 = match.<Index>k__BackingField;
				int <Length>k__BackingField = match.<Length>k__BackingField;
				match2 = match.NextMatch();
			}
			while (match2._capcount != 0);
			TimeSpan timeSpan2 = regex.internalMatchTimeout;
			IL_0052:
			TimeSpan timeSpan3 = regex.internalMatchTimeout;
			int <Index>k__BackingField3 = match2.<Index>k__BackingField;
			string <Text>k__BackingField = match2.<Text>k__BackingField;
			string text;
			return text;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		public static string[] Split(string input, string pattern)
		{
			if (!true)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000BDDC File Offset: 0x00009FDC
		public static string[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			string[] array;
			return array;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000BDEC File Offset: 0x00009FEC
		public string[] Split(string input)
		{
			while (input == null)
			{
			}
			RegexOptions regexOptions = this.roptions;
			int stringLength = input._stringLength;
			long num = 0L;
			return this.Split(input, (int)num, stringLength);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000BE18 File Offset: 0x0000A018
		public string[] Split(string input, int count, int startat)
		{
			while (input == null)
			{
			}
			return Regex.Split(this, input, count, startat);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000BE34 File Offset: 0x0000A034
		private static string[] Split(Regex regex, string input, int count, int startat)
		{
			TimeSpan timeSpan = regex.internalMatchTimeout;
			Match match;
			if (match._capcount != 0)
			{
				int <Index>k__BackingField = match.<Index>k__BackingField;
				string text;
				return text;
			}
			if (regex != null)
			{
				TimeSpan timeSpan2 = regex.internalMatchTimeout;
				Match match2;
				int <Index>k__BackingField2 = match2.<Index>k__BackingField;
				string <Text>k__BackingField = match2.<Text>k__BackingField;
				string text2;
				return text2;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000BF00 File Offset: 0x0000A100
		static Regex()
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(2147483646.0);
			if (15 == 0)
			{
			}
			TimeSpan timeSpan2 = Regex.InitDefaultMatchTimeout();
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000BF28 File Offset: 0x0000A128
		protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000BF38 File Offset: 0x0000A138
		private static TimeSpan InitDefaultMatchTimeout()
		{
			object data = AppDomain.CurrentDomain.GetData("REGEX_DEFAULT_MATCH_TIMEOUT");
			if (data != null)
			{
			}
			if (data == null)
			{
				return;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000BF60 File Offset: 0x0000A160
		public Regex(string pattern)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000BF70 File Offset: 0x0000A170
		public Regex(string pattern, RegexOptions options)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000BF80 File Offset: 0x0000A180
		private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache)
		{
			do
			{
				base..ctor();
			}
			while (pattern == null);
			if (!true)
			{
				if (!true)
				{
				}
				Regex.ValidateMatchTimeout(matchTimeout);
				this.internalMatchTimeout = matchTimeout;
				this.pattern = pattern;
				this.roptions = options;
				if (!true)
				{
				}
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				return;
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000C098 File Offset: 0x0000A298
		public static string Escape(string str)
		{
			string text;
			return text;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		public RegexOptions Options
		{
			get
			{
				return this.roptions;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		public bool RightToLeft
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000378)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.Regex::get_RightToLeft()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexOptions(var_0_06, ldfld:RegexOptions(Regex::roptions, ldloc:Regex(this)))
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

		// Token: 0x06000379 RID: 889 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public override string ToString()
		{
			return this.pattern;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		public string GroupNameFromNumber(int i)
		{
			if (this.capslist != null)
			{
				if (this.caps != null)
				{
				}
				string[] array = this.capslist;
			}
			int num = this.capsize;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000C11C File Offset: 0x0000A31C
		public int GroupNumberFromName(string name)
		{
			/*
An exception occurred when decompiling this method (0600037B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.Regex::GroupNumberFromName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:int32(var_1_11, ldfld:int32(string::_stringLength, ldloc:string(name)))
	stloc:int64(var_2_13, ldc.i4:int64(0))
	stloc:char(var_3_1B, callgetter:char(string::get_Chars, ldloc:string(name), ldloc:int64[exp:int32](var_2_13)))
	stloc:int32(var_4_22, ldfld:int32(string::_stringLength, ldloc:string(name)))
	stloc:int32(var_6_2D, ldfld:int32(Regex::capsize, ldloc:Regex(this)))
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

		// Token: 0x0600037C RID: 892 RVA: 0x0000C158 File Offset: 0x0000A358
		protected void InitializeReferences()
		{
			while (this._refsInitialized)
			{
			}
			this._refsInitialized = true;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000C174 File Offset: 0x0000A374
		internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
		{
			int stringLength = input._stringLength;
			if (this._runnerref.Get() == null)
			{
				if (this.factory != null)
				{
				}
				RegexCode code = this._code;
				RegexOptions regexOptions = this.roptions;
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			TimeSpan timeSpan = this.internalMatchTimeout;
			ExclusiveReference runnerref = this._runnerref;
			Match match;
			return match;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		protected internal bool UseOptionR()
		{
			/*
An exception occurred when decompiling this method (0600037E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.Regex::UseOptionR()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexOptions(var_0_06, ldfld:RegexOptions(Regex::roptions, ldloc:Regex(this)))
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

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		internal bool UseOptionInvariant()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040002A8 RID: 680
		private const int CacheDictionarySwitchLimit = 10;

		// Token: 0x040002A9 RID: 681
		private static int s_cacheSize;

		// Token: 0x040002AA RID: 682
		private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache;

		// Token: 0x040002AB RID: 683
		private static int s_cacheCount;

		// Token: 0x040002AC RID: 684
		private static Regex.CachedCodeEntry s_cacheFirst;

		// Token: 0x040002AD RID: 685
		private static Regex.CachedCodeEntry s_cacheLast;

		// Token: 0x040002AE RID: 686
		private static readonly TimeSpan s_maximumMatchTimeout;

		// Token: 0x040002AF RID: 687
		private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";

		// Token: 0x040002B0 RID: 688
		internal static readonly TimeSpan s_defaultMatchTimeout;

		// Token: 0x040002B1 RID: 689
		public static readonly TimeSpan InfiniteMatchTimeout;

		// Token: 0x040002B2 RID: 690
		protected internal TimeSpan internalMatchTimeout;

		// Token: 0x040002B3 RID: 691
		internal const int MaxOptionShift = 10;

		// Token: 0x040002B4 RID: 692
		protected internal string pattern;

		// Token: 0x040002B5 RID: 693
		protected internal RegexOptions roptions;

		// Token: 0x040002B6 RID: 694
		protected internal RegexRunnerFactory factory;

		// Token: 0x040002B7 RID: 695
		protected internal Hashtable caps;

		// Token: 0x040002B8 RID: 696
		protected internal Hashtable capnames;

		// Token: 0x040002B9 RID: 697
		protected internal string[] capslist;

		// Token: 0x040002BA RID: 698
		protected internal int capsize;

		// Token: 0x040002BB RID: 699
		internal ExclusiveReference _runnerref;

		// Token: 0x040002BC RID: 700
		internal WeakReference<RegexReplacement> _replref;

		// Token: 0x040002BD RID: 701
		internal RegexCode _code;

		// Token: 0x040002BE RID: 702
		internal bool _refsInitialized;

		// Token: 0x020000B0 RID: 176
		internal readonly struct CachedCodeEntryKey : IEquatable<Regex.CachedCodeEntryKey>
		{
			// Token: 0x06000380 RID: 896 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
			public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern)
			{
				this._options = options;
				this._cultureKey = cultureKey;
				this._pattern = pattern;
			}

			// Token: 0x06000381 RID: 897 RVA: 0x0000C21C File Offset: 0x0000A41C
			public override bool Equals(object obj)
			{
				if (obj != null)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x06000382 RID: 898 RVA: 0x0000C230 File Offset: 0x0000A430
			public bool Equals(Regex.CachedCodeEntryKey other)
			{
				string pattern = this._pattern;
				string pattern2 = other._pattern;
				bool flag = pattern.Equals(pattern2);
				string cultureKey = this._cultureKey;
				string cultureKey2 = other._cultureKey;
				return cultureKey.Equals(cultureKey2);
			}

			// Token: 0x06000383 RID: 899 RVA: 0x0000C270 File Offset: 0x0000A470
			public static bool operator ==(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right)
			{
				string pattern = left._pattern;
				bool flag;
				return flag;
			}

			// Token: 0x06000384 RID: 900 RVA: 0x0000C288 File Offset: 0x0000A488
			public override int GetHashCode()
			{
				/*
An exception occurred when decompiling this method (06000384)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.Regex/CachedCodeEntryKey::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(CachedCodeEntryKey::_cultureKey, ldloc:valuetype System.Text.RegularExpressions.Regex/CachedCodeEntryKey&(this)))
	stloc:string(var_1_0D, ldfld:string(CachedCodeEntryKey::_pattern, ldloc:valuetype System.Text.RegularExpressions.Regex/CachedCodeEntryKey&(this)))
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

			// Token: 0x040002BF RID: 703
			private readonly RegexOptions _options;

			// Token: 0x040002C0 RID: 704
			private readonly string _cultureKey;

			// Token: 0x040002C1 RID: 705
			private readonly string _pattern;
		}

		// Token: 0x020000B1 RID: 177
		internal sealed class CachedCodeEntry
		{
			// Token: 0x06000385 RID: 901 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
			public CachedCodeEntry(Regex.CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref)
			{
				string pattern = key._pattern;
				this.Caps = caps;
				this.Capnames = capnames;
				this.Capslist = capslist;
				this.Capsize = capsize;
				this.Key._pattern = pattern;
				this.Code = code;
				this.Runnerref = runner;
			}

			// Token: 0x040002C2 RID: 706
			public Regex.CachedCodeEntry Next;

			// Token: 0x040002C3 RID: 707
			public Regex.CachedCodeEntry Previous;

			// Token: 0x040002C4 RID: 708
			public readonly Regex.CachedCodeEntryKey Key;

			// Token: 0x040002C5 RID: 709
			public RegexCode Code;

			// Token: 0x040002C6 RID: 710
			public readonly Hashtable Caps;

			// Token: 0x040002C7 RID: 711
			public readonly Hashtable Capnames;

			// Token: 0x040002C8 RID: 712
			public readonly string[] Capslist;

			// Token: 0x040002C9 RID: 713
			public readonly int Capsize;

			// Token: 0x040002CA RID: 714
			public readonly ExclusiveReference Runnerref;

			// Token: 0x040002CB RID: 715
			public readonly WeakReference<RegexReplacement> ReplRef;
		}
	}
}
