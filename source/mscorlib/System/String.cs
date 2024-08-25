using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000067 RID: 103
	[Serializable]
	public sealed class String : IComparable, IEnumerable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable
	{
		// Token: 0x06000243 RID: 579 RVA: 0x00008438 File Offset: 0x00006638
		private static bool EqualsHelper(string strA, string strB)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00008448 File Offset: 0x00006648
		private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
		{
			int num;
			return num;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00008458 File Offset: 0x00006658
		private static int CompareOrdinalHelper(string strA, string strB)
		{
			int num = 1;
			int stringLength = strA._stringLength;
			if (num == 0)
			{
			}
			int num2 = Math.Min(0, stringLength);
			int stringLength2 = strA._stringLength;
			return num2;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008484 File Offset: 0x00006684
		public static int Compare(string strA, string strB)
		{
			int num;
			return num;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00008494 File Offset: 0x00006694
		public static int Compare(string strA, string strB, bool ignoreCase)
		{
			int num;
			return num;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000084A4 File Offset: 0x000066A4
		public static int Compare(string strA, string strB, StringComparison comparisonType)
		{
			if (strA != null)
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				return 49;
			}
			return 1;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000084EC File Offset: 0x000066EC
		public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
		{
			/*
An exception occurred when decompiling this method (06000249)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.String::Compare(System.String,System.String,System.Globalization.CultureInfo,System.Globalization.CompareOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:string[exp:bool](strB)))
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

		// Token: 0x0600024A RID: 586 RVA: 0x000084FC File Offset: 0x000066FC
		public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
		{
			int num;
			return num;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000850C File Offset: 0x0000670C
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
		{
			int num;
			long num2;
			int num3;
			if (indexA != 0)
			{
				if (indexB != 0)
				{
					num = Math.Min(indexB, 43151360);
					num2 = 0L;
					num3 = Math.Min(indexB, 43151360);
					return num3;
				}
			}
			return SpanHelpers.SequenceCompareTo('\0', num, (char)num2, num3);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00008574 File Offset: 0x00006774
		public static int CompareOrdinal(string strA, string strB)
		{
			if (strA != null)
			{
				char firstChar = strA._firstChar;
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00008590 File Offset: 0x00006790
		internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			int num;
			return num;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000085A0 File Offset: 0x000067A0
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			if (indexA == 0)
			{
				int num;
				return num;
			}
			long num2 = 0L;
			if (indexB != 0)
			{
				int num3;
				int num4;
				int num = SpanHelpers.SequenceCompareTo((char)num3, num4, (char)num2, num3);
				return num;
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000085C8 File Offset: 0x000067C8
		public int CompareTo(object value)
		{
			if (value != null)
			{
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000085DC File Offset: 0x000067DC
		public int CompareTo(string strB)
		{
			int num;
			return num;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000085EC File Offset: 0x000067EC
		public bool EndsWith(string value)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000085FC File Offset: 0x000067FC
		public bool EndsWith(string value, StringComparison comparisonType)
		{
			/*
An exception occurred when decompiling this method (06000252)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.String::EndsWith(System.String,System.StringComparison)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0037:
	stloc:CultureInfo(var_9_3F, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
	brtrue(IL_0000, ldfld:int32[exp:bool](string::_stringLength, ldloc:string(this)))
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

		// Token: 0x06000253 RID: 595 RVA: 0x00008658 File Offset: 0x00006858
		public bool EndsWith(char value)
		{
			/*
An exception occurred when decompiling this method (06000253)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.String::EndsWith(System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowIndexOutOfRangeException)
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

		// Token: 0x06000254 RID: 596 RVA: 0x00008670 File Offset: 0x00006870
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00008688 File Offset: 0x00006888
		public bool Equals(string value)
		{
			if (value != null)
			{
				int stringLength = value._stringLength;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000086A4 File Offset: 0x000068A4
		public bool Equals(string value, StringComparison comparisonType)
		{
			if (value != null)
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
			}
			int num = 49;
			int num2 = 47;
			long num3 = 0L;
			int stringLength = value._stringLength;
			return SpanHelpers.SequenceEqual((byte)num, (byte)num2, (ulong)num3);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00008714 File Offset: 0x00006914
		public static bool Equals(string a, string b)
		{
			while (a == null)
			{
			}
			int stringLength = a._stringLength;
			bool flag;
			return flag;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00008734 File Offset: 0x00006934
		public static bool Equals(string a, string b, StringComparison comparisonType)
		{
			if (a != null)
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
			}
			int num = 47;
			long num2 = 0L;
			long num3 = 0L;
			int stringLength = a._stringLength;
			return SpanHelpers.SequenceEqual((byte)num3, (byte)num, (ulong)num2);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00008784 File Offset: 0x00006984
		public static bool operator ==(string a, string b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00008794 File Offset: 0x00006994
		public static bool operator !=(string a, string b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000087A4 File Offset: 0x000069A4
		public override int GetHashCode()
		{
			return this.GetLegacyNonRandomizedHashCode();
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000087B8 File Offset: 0x000069B8
		internal int GetLegacyNonRandomizedHashCode()
		{
			/*
An exception occurred when decompiling this method (0600025C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.String::GetLegacyNonRandomizedHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	brtrue(IL_000A, ldloc:char[exp:bool](var_0_06))
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

		// Token: 0x0600025D RID: 605 RVA: 0x000087D4 File Offset: 0x000069D4
		public bool StartsWith(string value)
		{
			while (value == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000087E8 File Offset: 0x000069E8
		public bool StartsWith(string value, StringComparison comparisonType)
		{
			while (value == null)
			{
			}
			if (43151360 != 0)
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
			}
			int stringLength = this._stringLength;
			char firstChar = this._firstChar;
			char firstChar2 = value._firstChar;
			bool flag;
			return flag;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00008860 File Offset: 0x00006A60
		internal static void CheckStringComparison(StringComparison comparisonType)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.NotSupported_StringComparison, ExceptionArgument.comparisonType);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00008878 File Offset: 0x00006A78
		private static void FillStringChecked(string dest, int destPos, string src)
		{
			int stringLength = dest._stringLength;
			int stringLength2 = src._stringLength;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00008894 File Offset: 0x00006A94
		public static string Concat(object arg0, object arg1)
		{
			string text;
			if (arg0 != null)
			{
				return text;
			}
			return text;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000088AC File Offset: 0x00006AAC
		public static string Concat(object arg0, object arg1, object arg2)
		{
			string text;
			if (arg0 != null)
			{
				if (arg1 != null)
				{
					return text;
				}
			}
			else
			{
				while (arg1 != null)
				{
				}
			}
			return text;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000088C8 File Offset: 0x00006AC8
		public static string Concat(string str0, string str1)
		{
			/*
An exception occurred when decompiling this method (06000263)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::Concat(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](var_1)))
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

		// Token: 0x06000264 RID: 612 RVA: 0x000088F4 File Offset: 0x00006AF4
		public static string Concat(string str0, string str1, string str2)
		{
			string text;
			if (str0 == null || str0._stringLength == 0)
			{
				text = str0 + str1;
				return text;
			}
			if (str1 != null && str1._stringLength != 0)
			{
				int stringLength = str0._stringLength;
				return str0;
			}
			return text;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000892C File Offset: 0x00006B2C
		public static string Concat(string str0, string str1, string str2, string str3)
		{
			string text;
			if (str0 == null || str0._stringLength == 0)
			{
				text = str0 + str1 + str2;
				return text;
			}
			if (str1 == null || str1._stringLength == 0)
			{
				return text;
			}
			if (str2 != null && str2._stringLength != 0)
			{
				int stringLength = str0._stringLength;
				int stringLength2 = str0._stringLength;
				int stringLength3 = str1._stringLength;
				return str0;
			}
			return text;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00008980 File Offset: 0x00006B80
		public static string Concat(params string[] values)
		{
			int num = 1;
			if (false)
			{
				object obj;
				if (obj != null)
				{
					while (obj != null)
					{
					}
				}
				if (num != 0)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000089AC File Offset: 0x00006BAC
		public static string Format(string format, object arg0)
		{
			string text;
			return text;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000089BC File Offset: 0x00006BBC
		public static string Format(string format, object arg0, object arg1)
		{
			string text;
			return text;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000089CC File Offset: 0x00006BCC
		public static string Format(string format, object arg0, object arg1, object arg2)
		{
			string text;
			return text;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000089DC File Offset: 0x00006BDC
		public static string Format(string format, params object[] args)
		{
			while (format == null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000089F0 File Offset: 0x00006BF0
		public static string Format(IFormatProvider provider, string format, object arg0)
		{
			string text;
			return text;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00008A00 File Offset: 0x00006C00
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1)
		{
			string text;
			return text;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00008A10 File Offset: 0x00006C10
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
		{
			string text;
			return text;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00008A20 File Offset: 0x00006C20
		public static string Format(IFormatProvider provider, string format, params object[] args)
		{
			while (format == null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00008A34 File Offset: 0x00006C34
		private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			while (provider == null)
			{
			}
			int num;
			StringBuilder stringBuilder = StringBuilderCache.Acquire(num);
			StringBuilder stringBuilder2;
			return StringBuilderCache.GetStringAndRelease(stringBuilder2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00008A54 File Offset: 0x00006C54
		public string Insert(int startIndex, string value)
		{
			while (value == null)
			{
			}
			if (this._stringLength != 0)
			{
				return this;
			}
			return this;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00008A70 File Offset: 0x00006C70
		public static string Join(string separator, params string[] value)
		{
			while (separator == null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00008A84 File Offset: 0x00006C84
		public static string Join(string separator, IEnumerable<string> values)
		{
			if (separator != null)
			{
				return separator;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public static string Join(string separator, string[] value, int startIndex, int count)
		{
			string text;
			return text;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00008B00 File Offset: 0x00006D00
		private unsafe static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count)
		{
			if (separatorLength != 0)
			{
				object obj;
				if (obj != null)
				{
					while (obj != null)
					{
					}
				}
				if (startIndex == 0 || obj == null)
				{
				}
			}
			return "StartIndex cannot be less than zero.";
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00008B38 File Offset: 0x00006D38
		public string PadRight(int totalWidth, char paddingChar)
		{
			/*
An exception occurred when decompiling this method (06000275)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::PadRight(System.Int32,System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(this)))
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

		// Token: 0x06000276 RID: 630 RVA: 0x00008B4C File Offset: 0x00006D4C
		public string Remove(int startIndex, int count)
		{
			int stringLength = this._stringLength;
			if (count != 0)
			{
			}
			return "StartIndex cannot be less than zero.";
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00008B70 File Offset: 0x00006D70
		public string Remove(int startIndex)
		{
			int stringLength = this._stringLength;
			long num = 0L;
			return this.Substring((int)num, startIndex);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00008B94 File Offset: 0x00006D94
		public string Replace(char oldChar, char newChar)
		{
			/*
An exception occurred when decompiling this method (06000278)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::Replace(System.Char,System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0E, ldfld:int32(string::_stringLength, ldloc:string(this)))
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

		// Token: 0x06000279 RID: 633 RVA: 0x00008BB0 File Offset: 0x00006DB0
		public string Replace(string oldValue, string newValue)
		{
			while (oldValue == null || oldValue._stringLength == 0)
			{
			}
			if (newValue == null)
			{
			}
			int stringLength = this._stringLength;
			int stringLength2 = oldValue._stringLength;
			long num = 0L;
			ThrowHelper.ThrowIndexOutOfRangeException();
			stringLength2.m_value = (int)num;
			int stringLength3 = oldValue._stringLength;
			if (oldValue._stringLength != 0)
			{
				int stringLength4 = oldValue._stringLength;
			}
			string text;
			return text;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00008C08 File Offset: 0x00006E08
		private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices)
		{
			/*
An exception occurred when decompiling this method (0600027A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::ReplaceHelper(System.Int32,System.String,System.ReadOnlySpan`1<System.Int32>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0041:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x0600027B RID: 635 RVA: 0x00008C60 File Offset: 0x00006E60
		public string[] Split(char separator, StringSplitOptions options = StringSplitOptions.None)
		{
			string[] array;
			return array;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00008C70 File Offset: 0x00006E70
		public string[] Split(params char[] separator)
		{
			string[] array;
			return array;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00008C80 File Offset: 0x00006E80
		public string[] Split(char[] separator, int count)
		{
			string[] array;
			return array;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00008C90 File Offset: 0x00006E90
		public string[] Split(char[] separator, StringSplitOptions options)
		{
			string[] array;
			return array;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00008CA0 File Offset: 0x00006EA0
		private string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options)
		{
			if (options != StringSplitOptions.None && this._stringLength != 0)
			{
				string[] array;
				return array;
			}
			string[] array2;
			return array2;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00008CC4 File Offset: 0x00006EC4
		public string[] Split(string[] separator, StringSplitOptions options)
		{
			string[] array;
			return array;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00008CD4 File Offset: 0x00006ED4
		private string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options)
		{
			if (separator == null)
			{
				if (separators != null)
				{
				}
				string[] array;
				return array;
			}
			if (count == 0 || this._stringLength == 0)
			{
				return 1073741824;
			}
			if (this == null || this != null)
			{
				return this;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00008D1C File Offset: 0x00006F1C
		private string[] SplitInternal(string separator, int count, StringSplitOptions options)
		{
			if (128 != 0)
			{
				int stringLength = separator._stringLength;
				string[] array;
				return array;
			}
			if (this == null || this != null)
			{
				return this;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00008D4C File Offset: 0x00006F4C
		private string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			int stringLength = this._stringLength;
			string text;
			if (text == null || text != null)
			{
				return text;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00008D88 File Offset: 0x00006F88
		private string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			int stringLength = this._stringLength;
			string text;
			if (text == null || text != null)
			{
				return text;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00008DC8 File Offset: 0x00006FC8
		private void MakeSeparatorList(ReadOnlySpan<char> separators, ValueListBuilder<int> sepListBuilder)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00008E4C File Offset: 0x0000704C
		private void MakeSeparatorList(string separator, ValueListBuilder<int> sepListBuilder)
		{
			int stringLength = this._stringLength;
			int stringLength2 = separator._stringLength;
			ThrowHelper.ThrowIndexOutOfRangeException();
			int stringLength3 = separator._stringLength;
			ThrowHelper.ThrowIndexOutOfRangeException();
			int stringLength4 = this._stringLength;
			sepListBuilder.Grow();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00008EB0 File Offset: 0x000070B0
		private void MakeSeparatorList(string[] separators, ValueListBuilder<int> sepListBuilder, ValueListBuilder<int> lengthListBuilder)
		{
			int stringLength = this._stringLength;
			ThrowHelper.ThrowIndexOutOfRangeException();
			ThrowHelper.ThrowIndexOutOfRangeException();
			int stringLength2 = this._stringLength;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00008F00 File Offset: 0x00007100
		public string Substring(int startIndex)
		{
			int stringLength = this._stringLength;
			string text;
			return text;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00008F18 File Offset: 0x00007118
		public string Substring(int startIndex, int length)
		{
			int stringLength = this._stringLength;
			if (length == 0 || startIndex == 0)
			{
			}
			return "StartIndex cannot be less than zero.";
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000207A File Offset: 0x0000027A
		private string InternalSubString(int startIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00008F44 File Offset: 0x00007144
		public string ToLower()
		{
			/*
An exception occurred when decompiling this method (0600028B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::ToLower()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
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

		// Token: 0x0600028C RID: 652 RVA: 0x00008F5C File Offset: 0x0000715C
		public string ToLower(CultureInfo culture)
		{
			/*
An exception occurred when decompiling this method (0600028C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::ToLower(System.Globalization.CultureInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:CultureInfo[exp:bool](culture)))
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

		// Token: 0x0600028D RID: 653 RVA: 0x00008F6C File Offset: 0x0000716C
		public string ToLowerInvariant()
		{
			/*
An exception occurred when decompiling this method (0600028D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::ToLowerInvariant()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x0600028E RID: 654 RVA: 0x00008F84 File Offset: 0x00007184
		public string ToUpper()
		{
			/*
An exception occurred when decompiling this method (0600028E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::ToUpper()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
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

		// Token: 0x0600028F RID: 655 RVA: 0x00008F9C File Offset: 0x0000719C
		public string ToUpper(CultureInfo culture)
		{
			/*
An exception occurred when decompiling this method (0600028F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::ToUpper(System.Globalization.CultureInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:CultureInfo[exp:bool](culture)))
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

		// Token: 0x06000290 RID: 656 RVA: 0x00008FAC File Offset: 0x000071AC
		public string ToUpperInvariant()
		{
			/*
An exception occurred when decompiling this method (06000290)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::ToUpperInvariant()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000291 RID: 657 RVA: 0x00008FC4 File Offset: 0x000071C4
		public string Trim()
		{
			return this.TrimWhiteSpaceHelper(string.TrimType.Both);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00008FD8 File Offset: 0x000071D8
		public string Trim(char trimChar)
		{
			return this.TrimHelper(trimChar, 1, string.TrimType.Both);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00008FF0 File Offset: 0x000071F0
		public string Trim(params char[] trimChars)
		{
			if (trimChars != null)
			{
				string text;
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00009004 File Offset: 0x00007204
		public string TrimStart(params char[] trimChars)
		{
			if (trimChars != null)
			{
				string text;
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00009018 File Offset: 0x00007218
		public string TrimEnd()
		{
			return this.TrimWhiteSpaceHelper(string.TrimType.Tail);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000902C File Offset: 0x0000722C
		public string TrimEnd(params char[] trimChars)
		{
			if (trimChars != null)
			{
				string text;
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00009040 File Offset: 0x00007240
		private string TrimWhiteSpaceHelper(string.TrimType trimType)
		{
			int stringLength = this._stringLength;
			ThrowHelper.ThrowIndexOutOfRangeException();
			if (stringLength == 0)
			{
			}
			long num;
			if (trimType != string.TrimType.Head)
			{
				int stringLength2 = this._stringLength;
				ThrowHelper.ThrowIndexOutOfRangeException();
				if (stringLength == 0)
				{
				}
				num = 0L;
				while (stringLength != 0)
				{
				}
			}
			return this.CreateTrimmedString((int)num, stringLength);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00009088 File Offset: 0x00007288
		private unsafe string TrimHelper(char* trimChars, int trimCharsLength, string.TrimType trimType)
		{
			int stringLength = this._stringLength;
			return this;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000090D4 File Offset: 0x000072D4
		private string CreateTrimmedString(int start, int end)
		{
			/*
An exception occurred when decompiling this method (06000299)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::CreateTrimmedString(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(this)))
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](end)))
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

		// Token: 0x0600029A RID: 666 RVA: 0x000090EC File Offset: 0x000072EC
		public bool Contains(string value)
		{
			/*
An exception occurred when decompiling this method (0600029A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.String::Contains(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	stloc:int32(var_2_13, call:int32(string::IndexOf, ldloc:string(this), ldloc:string(value), ldloc:int64[exp:int32](var_1_08), ldloc:int32(var_0_06), ldc.i4:StringComparison(4)))
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

		// Token: 0x0600029B RID: 667 RVA: 0x0000910C File Offset: 0x0000730C
		public int IndexOf(char value)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00009124 File Offset: 0x00007324
		public int IndexOf(char value, int startIndex)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000913C File Offset: 0x0000733C
		public int IndexOf(char value, int startIndex, int count)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00009158 File Offset: 0x00007358
		public int IndexOfAny(char[] anyOf)
		{
			int stringLength = this._stringLength;
			long num = 0L;
			return this.IndexOfAny(anyOf, (int)num, stringLength);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00009178 File Offset: 0x00007378
		public int IndexOfAny(char[] anyOf, int startIndex)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00009190 File Offset: 0x00007390
		public int IndexOfAny(char[] anyOf, int startIndex, int count)
		{
			if (anyOf != null)
			{
				int stringLength = this._stringLength;
				return this.IndexOfAny(anyOf, (char)startIndex, startIndex, count);
			}
			return "Index was out of range. Must be non-negative and less than the size of the collection.";
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000207A File Offset: 0x0000027A
		private int IndexOfAny(char value1, char value2, int startIndex, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000207A File Offset: 0x0000027A
		private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000091C4 File Offset: 0x000073C4
		private int IndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000091D4 File Offset: 0x000073D4
		private unsafe static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000091E4 File Offset: 0x000073E4
		private static bool ArrayContains(char searchChar, char[] anyOf)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static bool IsCharBitSet(uint* charMap, byte value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000091F8 File Offset: 0x000073F8
		private unsafe static void SetCharBit(uint* charMap, byte value)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00009208 File Offset: 0x00007408
		public int IndexOf(string value)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00009220 File Offset: 0x00007420
		public int IndexOf(string value, int startIndex)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00009238 File Offset: 0x00007438
		public int IndexOf(string value, StringComparison comparisonType)
		{
			int stringLength = this._stringLength;
			long num = 0L;
			return this.IndexOf(value, (int)num, stringLength, comparisonType);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00009258 File Offset: 0x00007458
		public int IndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00009270 File Offset: 0x00007470
		public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			while (value == null)
			{
			}
			int stringLength = this._stringLength;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
			int num;
			return num;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000092A4 File Offset: 0x000074A4
		public int LastIndexOf(char value)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000092BC File Offset: 0x000074BC
		public int LastIndexOf(char value, int startIndex)
		{
			int num;
			return num;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000092CC File Offset: 0x000074CC
		public int LastIndexOf(char value, int startIndex, int count)
		{
			int num;
			if (this._stringLength != 0)
			{
				return num;
			}
			return num;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000092EC File Offset: 0x000074EC
		public int LastIndexOfAny(char[] anyOf)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00009304 File Offset: 0x00007504
		public int LastIndexOfAny(char[] anyOf, int startIndex)
		{
			int num;
			return num;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00009314 File Offset: 0x00007514
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
		{
			while (anyOf == null)
			{
			}
			if (this._stringLength != 0)
			{
				return this.LastIndexOfCharArray(anyOf, startIndex, count);
			}
			int num;
			return num;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00009340 File Offset: 0x00007540
		private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00009350 File Offset: 0x00007550
		public int LastIndexOf(string value)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00009368 File Offset: 0x00007568
		public int LastIndexOf(string value, StringComparison comparisonType)
		{
			int stringLength = this._stringLength;
			int num;
			return num;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00009380 File Offset: 0x00007580
		public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			int num;
			do
			{
				num = 1;
			}
			while (value == null);
			if (num != 0)
			{
				if (value._stringLength == 0)
				{
					return startIndex;
				}
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
			}
			int stringLength = value._stringLength;
			return startIndex;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000093CC File Offset: 0x000075CC
		public String(char[] value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000093E0 File Offset: 0x000075E0
		private static string Ctor(char[] value)
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000093F0 File Offset: 0x000075F0
		public String(char[] value, int startIndex, int length)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00009404 File Offset: 0x00007604
		private static string Ctor(char[] value, int startIndex, int length)
		{
			if (startIndex != 0)
			{
			}
			return "StartIndex cannot be less than zero.";
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00009424 File Offset: 0x00007624
		[CLSCompliant(false)]
		public unsafe String(char* value, int startIndex, int length)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00009438 File Offset: 0x00007638
		private unsafe static string Ctor(char* ptr, int startIndex, int length)
		{
			if (startIndex != 0)
			{
			}
			return "Length cannot be less than zero.";
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000945C File Offset: 0x0000765C
		[CLSCompliant(false)]
		public unsafe String(sbyte* value, int startIndex, int length)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00009470 File Offset: 0x00007670
		private unsafe static string Ctor(sbyte* value, int startIndex, int length)
		{
			string text;
			return text;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00009490 File Offset: 0x00007690
		private unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
		{
			string text;
			if (pb != null)
			{
				Encoding utf = Encoding.UTF8;
				return text;
			}
			return text;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000094AC File Offset: 0x000076AC
		[CLSCompliant(false)]
		public unsafe String(sbyte* value, int startIndex, int length, Encoding enc)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000094C0 File Offset: 0x000076C0
		private unsafe static string Ctor(sbyte* value, int startIndex, int length, Encoding enc)
		{
			if (length != 0)
			{
				if (!true)
				{
				}
				string text;
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000094E8 File Offset: 0x000076E8
		public String(char c, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000094FC File Offset: 0x000076FC
		private static string Ctor(char c, int count)
		{
			/*
An exception occurred when decompiling this method (060002C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::Ctor(System.Char,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldloc:char[exp:bool](c))
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

		// Token: 0x060002C4 RID: 708 RVA: 0x00009510 File Offset: 0x00007710
		public String(ReadOnlySpan<char> value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009524 File Offset: 0x00007724
		private static string Ctor(ReadOnlySpan<char> value)
		{
			/*
An exception occurred when decompiling this method (060002C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::Ctor(System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:valuetype System.ReadOnlySpan`1<char>[exp:bool](value)))
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

		// Token: 0x060002C6 RID: 710 RVA: 0x00009534 File Offset: 0x00007734
		public static string Create<TState>(int length, TState state, SpanAction<char, TState> action)
		{
			/*
An exception occurred when decompiling this method (060002C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::Create<TState>(System.Int32,TState,System.Buffers.SpanAction`2<System.Char,TState>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char(var_0_12, call:char(string::GetRawStringData, call:string(string::FastAllocateString, ldc.i4:int32(-2147483648))))
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

		// Token: 0x060002C7 RID: 711 RVA: 0x00009554 File Offset: 0x00007754
		public static implicit operator ReadOnlySpan<char>(string value)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000207A File Offset: 0x0000027A
		public object Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000207A File Offset: 0x0000027A
		public static string Copy(string str)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00009564 File Offset: 0x00007764
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			if (destination != null)
			{
				int stringLength = this._stringLength;
				return;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00009580 File Offset: 0x00007780
		public char[] ToCharArray()
		{
			/*
An exception occurred when decompiling this method (060002CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char[] System.String::ToCharArray()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0E, ldfld:int32(string::_stringLength, ldloc:string(this)))
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

		// Token: 0x060002CC RID: 716 RVA: 0x0000959C File Offset: 0x0000779C
		[NonVersionable]
		public static bool IsNullOrEmpty(string value)
		{
			return true;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000095AC File Offset: 0x000077AC
		public static bool IsNullOrWhiteSpace(string value)
		{
			int num = 1;
			ThrowHelper.ThrowIndexOutOfRangeException();
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000207A File Offset: 0x0000027A
		internal char GetRawStringData()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000095CC File Offset: 0x000077CC
		internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
		{
			/*
An exception occurred when decompiling this method (060002CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.String::CreateStringFromEncoding(System.Byte*,System.Int32,System.Text.Encoding)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](byteLength)))
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

		// Token: 0x060002D0 RID: 720 RVA: 0x000095DC File Offset: 0x000077DC
		internal static string CreateFromChar(char c)
		{
			return 1;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000095EC File Offset: 0x000077EC
		internal unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000095FC File Offset: 0x000077FC
		public override string ToString()
		{
			return this;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000960C File Offset: 0x0000780C
		public string ToString(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000207A File Offset: 0x0000027A
		IEnumerator<char> IEnumerable<char>.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000207A File Offset: 0x0000027A
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000961C File Offset: 0x0000781C
		internal unsafe static int wcslen(char* ptr)
		{
			return IntPtr.Size;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000963C File Offset: 0x0000783C
		public TypeCode GetTypeCode()
		{
			return TypeCode.String;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000964C File Offset: 0x0000784C
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToBoolean(this, provider);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00009664 File Offset: 0x00007864
		char IConvertible.ToChar(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToChar(this, provider);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000967C File Offset: 0x0000787C
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToSByte(this, provider);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00009694 File Offset: 0x00007894
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToByte(this, provider);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000096AC File Offset: 0x000078AC
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToInt16(this, provider);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000096C4 File Offset: 0x000078C4
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToUInt16(this, provider);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000096DC File Offset: 0x000078DC
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToInt32(this, provider);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000096F4 File Offset: 0x000078F4
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToUInt32(this, provider);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000970C File Offset: 0x0000790C
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToInt64(this, provider);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00009724 File Offset: 0x00007924
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToUInt64(this, provider);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000973C File Offset: 0x0000793C
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (060002E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.String::System.IConvertible.ToSingle(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float32(var_0_0A, call:float32(Convert::ToSingle, ldloc:string(this), ldloc:IFormatProvider(provider)))
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

		// Token: 0x060002E3 RID: 739 RVA: 0x00009754 File Offset: 0x00007954
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (060002E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.String::System.IConvertible.ToDouble(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float64(var_0_0A, call:float64(Convert::ToDouble, ldloc:string(this), ldloc:IFormatProvider(provider)))
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

		// Token: 0x060002E4 RID: 740 RVA: 0x0000976C File Offset: 0x0000796C
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			if (!true)
			{
			}
			decimal num = Convert.ToDecimal(this, provider);
			return 1;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00009788 File Offset: 0x00007988
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			if (!true)
			{
			}
			DateTime dateTime = Convert.ToDateTime(this, provider);
			return 1;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000097A4 File Offset: 0x000079A4
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000097BC File Offset: 0x000079BC
		public string Normalize(NormalizationForm normalizationForm)
		{
			if (!true)
			{
			}
			return Normalization.Normalize(this, normalizationForm);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x000097D4 File Offset: 0x000079D4
		public int Length
		{
			get
			{
				return this._stringLength;
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000097E8 File Offset: 0x000079E8
		internal int IndexOfUnchecked(string value, int startIndex, int count)
		{
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			return startIndex;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00009808 File Offset: 0x00007A08
		internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			return startIndex;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00009828 File Offset: 0x00007A28
		internal int LastIndexOfUnchecked(string value, int startIndex, int count)
		{
			return RuntimeHelpers.OffsetToStringData;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00009840 File Offset: 0x00007A40
		internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			return startIndex;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00009860 File Offset: 0x00007A60
		internal bool StartsWithOrdinalUnchecked(string value)
		{
			int stringLength = this._stringLength;
			char firstChar = this._firstChar;
			char firstChar2 = value._firstChar;
			return true;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string FastAllocateString(int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00009888 File Offset: 0x00007A88
		private unsafe static void memset(byte* dest, int val, int len)
		{
			if (val != 0)
			{
				return;
			}
			long num = 0L;
			dest->m_value = (byte)num;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000098A8 File Offset: 0x00007AA8
		private unsafe static void memcpy(byte* dest, byte* src, int size)
		{
			long num = 0L;
			Buffer.Memcpy(dest, src, size, num != 0L);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000098C0 File Offset: 0x00007AC0
		internal unsafe static void bzero(byte* dest, int len)
		{
			long num = 0L;
			string.memset(dest, (int)num, len);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000098D8 File Offset: 0x00007AD8
		internal unsafe static void bzero_aligned_1(byte* dest, int len)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000098E8 File Offset: 0x00007AE8
		internal unsafe static void bzero_aligned_2(byte* dest, int len)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000098F8 File Offset: 0x00007AF8
		internal unsafe static void bzero_aligned_4(byte* dest, int len)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00009908 File Offset: 0x00007B08
		internal unsafe static void bzero_aligned_8(byte* dest, int len)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00009918 File Offset: 0x00007B18
		internal unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00009928 File Offset: 0x00007B28
		internal unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00009938 File Offset: 0x00007B38
		internal unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00009948 File Offset: 0x00007B48
		internal unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00009958 File Offset: 0x00007B58
		private unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			return string.Ctor(value, startIndex, startIndex);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00009970 File Offset: 0x00007B70
		private unsafe string CreateString(char* value, int startIndex, int length)
		{
			return string.Ctor(value, startIndex, length);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00009988 File Offset: 0x00007B88
		private string CreateString(char[] val, int startIndex, int length)
		{
			return string.Ctor(val, startIndex, length);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000099A0 File Offset: 0x00007BA0
		private string CreateString(char[] val)
		{
			return string.Ctor(val);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000099B4 File Offset: 0x00007BB4
		private string CreateString(char c, int count)
		{
			return string.Ctor(c, count);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000099C8 File Offset: 0x00007BC8
		private unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
		{
			return string.Ctor(value, startIndex, length, enc);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000099E0 File Offset: 0x00007BE0
		private string CreateString(ReadOnlySpan<char> value)
		{
			return string.Ctor(value);
		}

		// Token: 0x1700003F RID: 63
		[IndexerName("Chars")]
		public char this[int index]
		{
			[Intrinsic]
			get
			{
				/*
An exception occurred when decompiling this method (06000301)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.String::get_Chars(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowIndexOutOfRangeException)
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

		// Token: 0x04000198 RID: 408
		private const int StackallocIntBufferSizeLimit = 128;

		// Token: 0x04000199 RID: 409
		private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;

		// Token: 0x0400019A RID: 410
		private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;

		// Token: 0x0400019B RID: 411
		private const int PROBABILISTICMAP_SIZE = 8;

		// Token: 0x0400019C RID: 412
		[NonSerialized]
		private int _stringLength;

		// Token: 0x0400019D RID: 413
		[NonSerialized]
		private char _firstChar;

		// Token: 0x0400019E RID: 414
		public static readonly string Empty;

		// Token: 0x02000068 RID: 104
		private enum TrimType
		{
			// Token: 0x040001A0 RID: 416
			Head,
			// Token: 0x040001A1 RID: 417
			Tail,
			// Token: 0x040001A2 RID: 418
			Both
		}

		// Token: 0x02000069 RID: 105
		[StructLayout(2, Pack = 1, Size = 32)]
		private struct ProbabilisticMap
		{
		}
	}
}
