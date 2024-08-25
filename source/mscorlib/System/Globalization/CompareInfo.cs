using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x02000582 RID: 1410
	[Serializable]
	public class CompareInfo : IDeserializationCallback
	{
		// Token: 0x06002A62 RID: 10850 RVA: 0x0005BFB0 File Offset: 0x0005A1B0
		internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			int num = 1;
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (source != null)
			{
				return RuntimeHelpers.OffsetToStringData;
			}
			int stringLength = source._stringLength;
			if (num == 0)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x0005BFE0 File Offset: 0x0005A1E0
		internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			int num = 1;
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (source != null)
			{
				return RuntimeHelpers.OffsetToStringData;
			}
			int stringLength = source._stringLength;
			if (num == 0)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x0005C010 File Offset: 0x0005A210
		private unsafe static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start)
		{
			int num = 1;
			if (value != null)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x0000207A File Offset: 0x0000027A
		private static char InvariantToUpper(char c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x0005C03C File Offset: 0x0005A23C
		private SortKey InvariantCreateSortKey(string source, CompareOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A66)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.SortKey System.Globalization.CompareInfo::InvariantCreateSortKey(System.String,System.Globalization.CompareOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:int32(var_2_19, ldfld:int32(string::_stringLength, ldloc:string(source)))
	stloc:int64(var_3_1B, ldc.i4:int64(0))
	stloc:char(var_4_23, callgetter:char(string::get_Chars, ldloc:string(source), ldloc:int64[exp:int32](var_3_1B)))
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

		// Token: 0x06002A67 RID: 10855 RVA: 0x0005C070 File Offset: 0x0005A270
		internal CompareInfo(CultureInfo culture)
		{
			string name = culture.m_name;
			this.m_name = name;
			this._sortName = name;
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x0000207A File Offset: 0x0000027A
		public static CompareInfo GetCompareInfo(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x0005C098 File Offset: 0x0005A298
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x0005C0A8 File Offset: 0x0005A2A8
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialized();
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x0005C0BC File Offset: 0x0005A2BC
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x0005C0D0 File Offset: 0x0005A2D0
		private void OnDeserialized()
		{
			string name = this.m_name;
			if (name != null)
			{
				CultureInfo cultureInfo = CultureInfo.GetCultureInfo(name);
				return;
			}
			string name2 = CultureInfo.GetCultureInfo(this.culture).m_name;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x0005C100 File Offset: 0x0005A300
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			CultureInfo cultureInfo;
			this.culture = cultureInfo;
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x0005C114 File Offset: 0x0005A314
		public virtual string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002A6E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.CompareInfo::get_Name()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0F, call:bool(string::op_Equality, ldstr:string("zh-CHS"), ldstr:string("zh-CHT")))
	stloc:bool(var_1_20, call:bool(string::op_Equality, ldfld:string(CompareInfo::m_name, ldloc:CompareInfo(this)), ldstr:string("zh-CHS")))
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

		// Token: 0x06002A6F RID: 10863 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual int Compare(string string1, string string2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x0005C144 File Offset: 0x0005A344
		public virtual int Compare(string string1, string string2, CompareOptions options)
		{
			return string.Compare(string1, string2, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0005C198 File Offset: 0x0005A398
		internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			if (options != CompareOptions.None)
			{
				if (options == CompareOptions.None)
				{
					return 1;
				}
				if (65504 == 0)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
					int num;
					return num;
				}
				if (options == CompareOptions.None)
				{
					int num2;
					return num2;
				}
				while (options != CompareOptions.None)
				{
				}
			}
			if (!true)
			{
			}
			int num3;
			return num3;
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x0005C1DC File Offset: 0x0005A3DC
		internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
		{
			int num = 1;
			int num2;
			if (string2 != null)
			{
				if (num == 0)
				{
				}
				if (!true)
				{
				}
				num2 = CompareInfo.CompareOrdinalIgnoreCase(string1, string2);
				return num2;
			}
			return num2;
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0005C204 File Offset: 0x0005A404
		public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A73)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.CompareInfo::Compare(System.String,System.Int32,System.String,System.Int32,System.Globalization.CompareOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	brtrue(IL_0014, ldloc:string[exp:bool](string2))
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

		// Token: 0x06002A74 RID: 10868 RVA: 0x0005C228 File Offset: 0x0005A428
		public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			int num;
			while (num != 0)
			{
			}
			return num;
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0005C2BC File Offset: 0x0005A4BC
		internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB)
		{
			if (true)
			{
			}
			int num = 1;
			if (lengthA != 0)
			{
			}
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x0005C2EC File Offset: 0x0005A4EC
		internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			if (!true)
			{
			}
			if ("QuickBuff" == null)
			{
			}
			if ("QuickBuff" == null)
			{
			}
			int num;
			if (num != 0)
			{
				while (num != 0)
				{
				}
			}
			return 41607168;
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0005C320 File Offset: 0x0005A520
		public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			while (prefix == null || source == null)
			{
			}
			if (prefix._stringLength == 0 || source._stringLength != 0)
			{
				return true;
			}
			if (4096 == 0)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return source.StartsWith(prefix, StringComparison.Ordinal);
			}
			return this.StartsWith(source, prefix, options);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0005C368 File Offset: 0x0005A568
		public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			while (suffix == null || source == null)
			{
			}
			if (suffix._stringLength == 0 || source._stringLength != 0)
			{
				return true;
			}
			if (4096 == 0)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return source.EndsWith(suffix, StringComparison.Ordinal);
			}
			return this.EndsWith(source, suffix, options);
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x0005C3B0 File Offset: 0x0005A5B0
		internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
		{
			return this.EndsWith(source, suffix, options);
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			while (source != null)
			{
				if (value != null)
				{
					if (source._stringLength != 0)
					{
					}
					int stringLength = value._stringLength;
					if (16384 == 0)
					{
					}
					if (!true)
					{
					}
					int num;
					return num;
				}
			}
			return "source";
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x0005C41C File Offset: 0x0005A61C
		internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return CompareInfo.InvariantIndexOf(source, value, startIndex, count, count != 0);
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x0005C440 File Offset: 0x0005A640
		public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			while (source != null)
			{
				if (value != null)
				{
					if (source._stringLength == 0)
					{
						int stringLength = value._stringLength;
						return 43155456;
					}
					if (value._stringLength == 0)
					{
						return 43155456;
					}
					int num;
					return num;
				}
			}
			return "source";
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x0005C4CC File Offset: 0x0005A6CC
		internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return CompareInfo.InvariantLastIndexOf(source, value, startIndex, count, count != 0);
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x0005C4F0 File Offset: 0x0005A6F0
		public virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return this.InvariantCreateSortKey(source, options);
			}
			return this.CreateSortKey(source, options);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x0005C518 File Offset: 0x0005A718
		public override bool Equals(object value)
		{
			if (value != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0005C52C File Offset: 0x0005A72C
		internal static int GetIgnoreCaseHash(string source)
		{
			int num = 1;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			long num2 = 0L;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			if (!true)
			{
			}
			ReadOnlySpan readOnlySpan;
			!0 reference = MemoryMarshal.GetReference(readOnlySpan);
			if (num2 != 0L)
			{
			}
			int num3;
			return num3;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x0005C57C File Offset: 0x0005A77C
		internal int GetHashCodeOfString(string source, CompareOptions options)
		{
			while (source == null)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
			}
			return CompareInfo.GetIgnoreCaseHash(source);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x0005C59C File Offset: 0x0005A79C
		public virtual int GetHashCode(string source, CompareOptions options)
		{
			while (source == null)
			{
			}
			return CompareInfo.GetIgnoreCaseHash(source);
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x0005C5BC File Offset: 0x0005A7BC
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x0005C5CC File Offset: 0x0005A7CC
		private static bool UseManagedCollation
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002A85)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.CompareInfo::get_UseManagedCollation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
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

		// Token: 0x06002A86 RID: 10886 RVA: 0x0005C600 File Offset: 0x0005A800
		private ISimpleCollator GetCollator()
		{
			ISimpleCollator simpleCollator = this.collator;
			if (simpleCollator == null)
			{
				if (simpleCollator == null)
				{
				}
				if (simpleCollator == null)
				{
					if (simpleCollator == null)
					{
					}
					if (simpleCollator == null)
					{
					}
					if (!true)
					{
					}
				}
				string sortName = this._sortName;
				CultureInfo cultureInfo = CultureInfo.GetCultureInfo(this.m_name);
				string sortName2 = this._sortName;
				long num = 0L;
				int num2 = 5;
				if (num != 0L || num2 == 0)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x0005C660 File Offset: 0x0005A860
		private SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A87)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.SortKey System.Globalization.CompareInfo::CreateSortKeyCore(System.String,System.Globalization.CompareOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_0_08, callgetter:bool(CompareInfo::get_UseManagedCollation))
	stloc:ISimpleCollator(var_1_0F, call:ISimpleCollator(CompareInfo::GetCollator, ldloc:CompareInfo(this)))
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

		// Token: 0x06002A88 RID: 10888 RVA: 0x0005C67C File Offset: 0x0005A87C
		private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			return s1.IndexOfUnchecked(s2, sindex, count);
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x0005C6BC File Offset: 0x0005A8BC
		private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			if (!true)
			{
			}
			bool useManagedCollation = CompareInfo.UseManagedCollation;
			return this.internal_compare_managed(str1, offset1, length1, str2, offset2, length2, options);
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x0005C6F8 File Offset: 0x0005A8F8
		private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A8A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.CompareInfo::internal_compare_managed(System.String,System.Int32,System.Int32,System.String,System.Int32,System.Int32,System.Globalization.CompareOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ISimpleCollator(var_0_06, call:ISimpleCollator(CompareInfo::GetCollator, ldloc:CompareInfo(this)))
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

		// Token: 0x06002A8B RID: 10891 RVA: 0x0005C70C File Offset: 0x0005A90C
		private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			/*
An exception occurred when decompiling this method (06002A8B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.CompareInfo::internal_index_managed(System.String,System.Int32,System.Int32,System.String,System.Globalization.CompareOptions,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ISimpleCollator(var_0_06, call:ISimpleCollator(CompareInfo::GetCollator, ldloc:CompareInfo(this)))
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

		// Token: 0x06002A8C RID: 10892 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x0005C720 File Offset: 0x0005A920
		private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A8D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.CompareInfo::internal_compare(System.String,System.Int32,System.Int32,System.String,System.Int32,System.Int32,System.Globalization.CompareOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
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

		// Token: 0x06002A8E RID: 10894 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x0005C748 File Offset: 0x0005A948
		private static int internal_index(string source, int sindex, int count, string value, bool first)
		{
			/*
An exception occurred when decompiling this method (06002A8F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.CompareInfo::internal_index(System.String,System.Int32,System.Int32,System.String,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002A90 RID: 10896 RVA: 0x0005C76C File Offset: 0x0005A96C
		private void InitSort(CultureInfo culture)
		{
			string name = culture.m_name;
			this._sortName = name;
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0005C788 File Offset: 0x0005A988
		private unsafe static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return 1;
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0005C7A4 File Offset: 0x0005A9A4
		internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			int num;
			return num;
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x0005C7B4 File Offset: 0x0005A9B4
		internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			int num;
			return num;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x0005C7C4 File Offset: 0x0005A9C4
		private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options)
		{
			long num = 0L;
			return this.internal_index_switch(source, startIndex, count, target, options, num != 0L);
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x0005C7E4 File Offset: 0x0005A9E4
		private unsafe int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
		{
			while (matchLengthPtr != null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x0005C7F8 File Offset: 0x0005A9F8
		private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			string text;
			int stringLength = text._stringLength;
			int num;
			return num;
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x0005C810 File Offset: 0x0005AA10
		private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
		{
			string text;
			int stringLength = text._stringLength;
			string text2;
			if (text2 != null)
			{
				char rawStringData = text2.GetRawStringData();
				int stringLength2 = text2._stringLength;
			}
			int stringLength3 = text2._stringLength;
			int num;
			return num;
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x0005C84C File Offset: 0x0005AA4C
		private SortKey CreateSortKey(string source, CompareOptions options)
		{
			while (source == null)
			{
			}
			return this.CreateSortKeyCore(source, options);
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0005C864 File Offset: 0x0005AA64
		private bool StartsWith(string source, string prefix, CompareOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A99)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.CompareInfo::StartsWith(System.String,System.String,System.Globalization.CompareOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_0_08, callgetter:bool(CompareInfo::get_UseManagedCollation))
	stloc:ISimpleCollator(var_1_0F, call:ISimpleCollator(CompareInfo::GetCollator, ldloc:CompareInfo(this)))
	stloc:int32(var_2_16, ldfld:int32(string::_stringLength, ldloc:string(source)))
	stloc:int32(var_3_1D, ldfld:int32(string::_stringLength, ldloc:string(prefix)))
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

		// Token: 0x06002A9A RID: 10906 RVA: 0x0005C894 File Offset: 0x0005AA94
		private bool EndsWith(string source, string suffix, CompareOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A9A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.CompareInfo::EndsWith(System.String,System.String,System.Globalization.CompareOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_0_08, callgetter:bool(CompareInfo::get_UseManagedCollation))
	stloc:ISimpleCollator(var_1_0F, call:ISimpleCollator(CompareInfo::GetCollator, ldloc:CompareInfo(this)))
	stloc:int32(var_2_16, ldfld:int32(string::_stringLength, ldloc:string(source)))
	stloc:int32(var_3_1D, ldfld:int32(string::_stringLength, ldloc:string(suffix)))
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

		// Token: 0x06002A9B RID: 10907 RVA: 0x0005C8C4 File Offset: 0x0005AAC4
		private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x0000207A File Offset: 0x0000027A
		internal int GetHashCodeOfStringCore(string source, CompareOptions options)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x0005C8D8 File Offset: 0x0005AAD8
		// Note: this type is marked as 'beforefieldinit'.
		static CompareInfo()
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0005C8F0 File Offset: 0x0005AAF0
		internal CompareInfo()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040016B6 RID: 5814
		private const CompareOptions ValidIndexMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x040016B7 RID: 5815
		private const CompareOptions ValidCompareMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x040016B8 RID: 5816
		private const CompareOptions ValidHashCodeOfStringMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x040016B9 RID: 5817
		private const CompareOptions ValidSortkeyCtorMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x040016BA RID: 5818
		internal static readonly CompareInfo Invariant;

		// Token: 0x040016BB RID: 5819
		[OptionalField(VersionAdded = 2)]
		private string m_name;

		// Token: 0x040016BC RID: 5820
		[NonSerialized]
		private string _sortName;

		// Token: 0x040016BD RID: 5821
		[OptionalField(VersionAdded = 3)]
		private SortVersion m_SortVersion;

		// Token: 0x040016BE RID: 5822
		private int culture;

		// Token: 0x040016BF RID: 5823
		[NonSerialized]
		private ISimpleCollator collator;

		// Token: 0x040016C0 RID: 5824
		private static Dictionary<string, ISimpleCollator> collators;

		// Token: 0x040016C1 RID: 5825
		private static bool managedCollation;

		// Token: 0x040016C2 RID: 5826
		private static bool managedCollationChecked;
	}
}
