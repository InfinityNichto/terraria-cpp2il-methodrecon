using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000CF RID: 207
	[Serializable]
	public readonly struct Int32 : IComparable, IConvertible, IFormattable, IComparable<int>, IEquatable<int>, ISpanFormattable
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x0001253C File Offset: 0x0001073C
		public int CompareTo(object value)
		{
			if (value != null)
			{
			}
			return 1;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00012550 File Offset: 0x00010750
		public int CompareTo(int value)
		{
			return ref this;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00012560 File Offset: 0x00010760
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000207A File Offset: 0x0000027A
		[NonVersionable]
		public bool Equals(int obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00012574 File Offset: 0x00010774
		public override string ToString()
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00012588 File Offset: 0x00010788
		public string ToString(string format)
		{
			if (format != null)
			{
				char rawStringData = format.GetRawStringData();
				int stringLength = format._stringLength;
			}
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000125AC File Offset: 0x000107AC
		public string ToString(IFormatProvider provider)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000125C0 File Offset: 0x000107C0
		public string ToString(string format, IFormatProvider provider)
		{
			if (format != null)
			{
				char rawStringData = format.GetRawStringData();
				int stringLength = format._stringLength;
			}
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000125E4 File Offset: 0x000107E4
		public bool TryFormat(Span<char> destination, [Out] int charsWritten, [Optional] ReadOnlySpan<char> format, [Optional] IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000125F8 File Offset: 0x000107F8
		public static int Parse(string s)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			int num;
			return num;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00012618 File Offset: 0x00010818
		public static int Parse(string s, NumberStyles style)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			int num;
			return num;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00012638 File Offset: 0x00010838
		public static int Parse(string s, IFormatProvider provider)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			int num;
			return num;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00012650 File Offset: 0x00010850
		public static int Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			int num;
			return num;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00012668 File Offset: 0x00010868
		public static int Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Optional] IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			int num;
			return num;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00012684 File Offset: 0x00010884
		public static bool TryParse(string s, [Out] int result)
		{
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			bool flag;
			return flag;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000126A0 File Offset: 0x000108A0
		public static bool TryParse(ReadOnlySpan<char> s, [Out] int result)
		{
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			bool flag;
			return flag;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000126B8 File Offset: 0x000108B8
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, [Out] int result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000126C8 File Offset: 0x000108C8
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [Out] int result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			bool flag;
			return flag;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000126E4 File Offset: 0x000108E4
		public TypeCode GetTypeCode()
		{
			return TypeCode.Int32;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000126F4 File Offset: 0x000108F4
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00012708 File Offset: 0x00010908
		char IConvertible.ToChar(IFormatProvider provider)
		{
			if (!true)
			{
			}
			char c;
			return c;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0001271C File Offset: 0x0001091C
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			sbyte b;
			return b;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00012730 File Offset: 0x00010930
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			byte b;
			return b;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00012744 File Offset: 0x00010944
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			short num;
			return num;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00012758 File Offset: 0x00010958
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ushort num;
			return num;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000207A File Offset: 0x0000027A
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0001276C File Offset: 0x0001096C
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			uint num;
			return num;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00012780 File Offset: 0x00010980
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			long num;
			return num;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00012794 File Offset: 0x00010994
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ulong num;
			return num;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000127A8 File Offset: 0x000109A8
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (060007B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.Int32::System.IConvertible.ToSingle(System.IFormatProvider)

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

		// Token: 0x060007B1 RID: 1969 RVA: 0x000127B8 File Offset: 0x000109B8
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (060007B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.Int32::System.IConvertible.ToDouble(System.IFormatProvider)

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

		// Token: 0x060007B2 RID: 1970 RVA: 0x000127C8 File Offset: 0x000109C8
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000127DC File Offset: 0x000109DC
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (060007B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Int32::System.IConvertible.ToDateTime(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_14, call:string(SR::Format, ldstr:string("Invalid cast from '{0}' to '{1}'."), ldstr:string[exp:object]("Int32"), ldstr:string[exp:object]("DateTime")))
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

		// Token: 0x060007B4 RID: 1972 RVA: 0x00012800 File Offset: 0x00010A00
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			object obj;
			return obj;
		}

		// Token: 0x0400035E RID: 862
		private readonly int m_value;

		// Token: 0x0400035F RID: 863
		public const int MaxValue = 2147483647;

		// Token: 0x04000360 RID: 864
		public const int MinValue = -2147483648;
	}
}
