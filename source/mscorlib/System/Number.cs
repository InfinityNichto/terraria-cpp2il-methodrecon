using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000E5 RID: 229
	internal static class Number
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x000135D4 File Offset: 0x000117D4
		public static string FormatDecimal(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000135F0 File Offset: 0x000117F0
		public static bool TryFormatDecimal(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, [Out] int charsWritten)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0001360C File Offset: 0x0001180C
		private static void DecimalToNumber(decimal value, Number.NumberBuffer number)
		{
			int num = 29;
			int num2;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				num2 = 7;
				while (num2 != 0)
				{
				}
				return;
			}
			if (num2 == 0)
			{
			}
			uint num3;
			if (num3 != 0U)
			{
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0001363C File Offset: 0x0001183C
		public static string FormatDouble(double value, string format, NumberFormatInfo info)
		{
			if (!true)
			{
			}
			string text;
			if (text == null)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00013654 File Offset: 0x00011854
		public static bool TryFormatDouble(double value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, [Out] int charsWritten)
		{
			int num = 1;
			if (num == 0)
			{
			}
			string text;
			if (text != null)
			{
				if (num == 0)
				{
				}
				return Number.TryCopyTo(text, destination, charsWritten);
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0001367C File Offset: 0x0001187C
		private static string FormatDouble(ValueStringBuilder sb, double value, ReadOnlySpan<char> format, NumberFormatInfo info)
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
			if (!true)
			{
			}
			if (15 == 0)
			{
			}
			return info.nanSymbol;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000136B8 File Offset: 0x000118B8
		public static string FormatSingle(float value, string format, NumberFormatInfo info)
		{
			if (!true)
			{
			}
			string text;
			if (text == null)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000136D0 File Offset: 0x000118D0
		public static bool TryFormatSingle(float value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, [Out] int charsWritten)
		{
			int num = 1;
			if (num == 0)
			{
			}
			string text;
			if (text != null)
			{
				if (num == 0)
				{
				}
				return Number.TryCopyTo(text, destination, charsWritten);
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000136F8 File Offset: 0x000118F8
		private static string FormatSingle(ValueStringBuilder sb, float value, ReadOnlySpan<char> format, NumberFormatInfo info)
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
			if (!true)
			{
			}
			if (!true)
			{
			}
			return info.nanSymbol;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00013730 File Offset: 0x00011930
		private static bool TryCopyTo(string source, Span<char> destination, [Out] int charsWritten)
		{
			return true;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0001374C File Offset: 0x0001194C
		public static string FormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			int num = 1;
			if (format == null)
			{
				if (num == 0)
				{
				}
				return 42181520;
			}
			if (num == 0)
			{
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			int num2 = 65503;
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				string text;
				return text;
			}
			if (num2 == 0)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000137BC File Offset: 0x000119BC
		public static bool TryFormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, [Out] int charsWritten)
		{
			int num = 1;
			if (format == null)
			{
				if (num == 0)
				{
				}
				return true;
			}
			if (num == 0)
			{
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			int num2 = 65503;
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				bool flag;
				return flag;
			}
			if (num2 == 0)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00013818 File Offset: 0x00011A18
		public static string FormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			int num = 1;
			int num2;
			string text;
			if (format == null)
			{
				if (num2 == 0)
				{
				}
				return text;
			}
			if (num == 0)
			{
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			num2 = 65503;
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				return text;
			}
			if (num2 == 0)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00013870 File Offset: 0x00011A70
		public static bool TryFormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, [Out] int charsWritten)
		{
			bool flag;
			if (format == null)
			{
				if (42181520 == 0)
				{
				}
				return flag;
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			if (65503 == 0)
			{
				return flag;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000138A0 File Offset: 0x00011AA0
		public static string FormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			int num2 = 65503;
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				string text;
				return text;
			}
			if (num2 == 0)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000138E4 File Offset: 0x00011AE4
		public static bool TryFormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, [Out] int charsWritten)
		{
			int num = 1;
			if (format != null || num == 0)
			{
			}
			if (num == 0)
			{
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			int num2 = 65503;
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				bool flag;
				return flag;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00013924 File Offset: 0x00011B24
		public static string FormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			int num = 1;
			int num2;
			string text;
			if (format == null)
			{
				if (num2 == 0)
				{
				}
				return text;
			}
			if (num == 0)
			{
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			num2 = 65503;
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00013970 File Offset: 0x00011B70
		public static bool TryFormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, [Out] int charsWritten)
		{
			int num = 1;
			int num2;
			bool flag;
			if (format == null)
			{
				if (num2 == 0)
				{
				}
				return flag;
			}
			if (num == 0)
			{
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			num2 = 65503;
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				return flag;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000139B4 File Offset: 0x00011BB4
		private static void Int32ToNumber(int value, Number.NumberBuffer number)
		{
			int num = 10;
			number.precision = num;
			long num2 = 0L;
			number.sign = num2 != 0L;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000139F8 File Offset: 0x00011BF8
		private static string NegativeInt32ToDecStr(int value, int digits, string sNegative)
		{
			string text = string.FastAllocateString(value);
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			return text;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00013A1C File Offset: 0x00011C1C
		private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<char> destination, [Out] int charsWritten)
		{
			if (6 == 0)
			{
				return;
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00013A34 File Offset: 0x00011C34
		private static string Int32ToHexStr(int value, char hexBase, int digits)
		{
			int num = 1;
			if (5 == 0)
			{
			}
			string text = string.FastAllocateString(0);
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			if (num == 0)
			{
			}
			return text;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00013A5C File Offset: 0x00011C5C
		private static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<char> destination, [Out] int charsWritten)
		{
			if (5 == 0)
			{
				return;
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00013A74 File Offset: 0x00011C74
		private unsafe static char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits)
		{
			/*
An exception occurred when decompiling this method (06000870)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char* System.Number::Int32ToHexChars(System.Char*,System.UInt32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0003, ldloc:char*[exp:bool](buffer))
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

		// Token: 0x06000871 RID: 2161 RVA: 0x00013A88 File Offset: 0x00011C88
		private unsafe static void UInt32ToNumber(uint value, Number.NumberBuffer number)
		{
			int num = 10;
			long num2 = 0L;
			number.precision = num;
			number.sign = num2 != 0L;
			char* digits = number.digits;
			if (value != 0U)
			{
				return;
			}
			number.scale = (int)value;
			char* digits2 = number.digits;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00013AC4 File Offset: 0x00011CC4
		internal unsafe static char* UInt32ToDecChars(char* bufferEnd, uint value, int digits)
		{
			/*
An exception occurred when decompiling this method (06000872)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char* System.Number::UInt32ToDecChars(System.Char*,System.UInt32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:char*[exp:bool](bufferEnd)))
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

		// Token: 0x06000873 RID: 2163 RVA: 0x00013AD4 File Offset: 0x00011CD4
		private static string UInt32ToDecStr(uint value, int digits)
		{
			string text = string.FastAllocateString(0);
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			return text;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00013AF4 File Offset: 0x00011CF4
		private static bool TryUInt32ToDecStr(uint value, int digits, Span<char> destination, [Out] int charsWritten)
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00013B08 File Offset: 0x00011D08
		private unsafe static void Int64ToNumber(long input, Number.NumberBuffer number)
		{
			int num = 19;
			number.precision = num;
			bool sign = number.sign;
			char* digits = number.digits;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00013B4C File Offset: 0x00011D4C
		private static string NegativeInt64ToDecStr(long input, int digits, string sNegative)
		{
			long num = 16383L;
			string text = string.FastAllocateString(0);
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			if (text == null)
			{
			}
			if (num == 0L || text == null)
			{
			}
			if ((text != null && text == null) || text == null)
			{
			}
			return text;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00013B98 File Offset: 0x00011D98
		private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<char> destination, [Out] int charsWritten)
		{
			long num = 16383L;
			if (num != 0L)
			{
				return;
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00013BC0 File Offset: 0x00011DC0
		private static string Int64ToHexStr(long value, char hexBase, int digits)
		{
			string text = string.FastAllocateString(0);
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			if (text != null)
			{
			}
			if (48 == 0)
			{
			}
			return text;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00013BEC File Offset: 0x00011DEC
		private static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<char> destination, [Out] int charsWritten)
		{
			if (48 == 0)
			{
				return;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00013C04 File Offset: 0x00011E04
		private unsafe static void UInt64ToNumber(ulong value, Number.NumberBuffer number)
		{
			int num = 20;
			long num2 = 0L;
			number.precision = num;
			number.sign = num2 != 0L;
			char* digits = number.digits;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00013C54 File Offset: 0x00011E54
		private static string UInt64ToDecStr(ulong value, int digits)
		{
			long num = 16383L;
			string text = string.FastAllocateString(43155456);
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			if (text == null)
			{
			}
			if (num == 0L || text == null)
			{
			}
			if ((text != null && text == null) || text == null)
			{
			}
			return text;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00013CA8 File Offset: 0x00011EA8
		private static bool TryUInt64ToDecStr(ulong value, int digits, Span<char> destination, [Out] int charsWritten)
		{
			long num = 16383L;
			if (num != 0L)
			{
				return;
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00013CD4 File Offset: 0x00011ED4
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, [Out] int digits)
		{
			/*
An exception occurred when decompiling this method (0600087D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Number::ParseFormatSpecifier(System.ReadOnlySpan`1<System.Char>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](digits), ldloc:int64[exp:int32](var_5_25))
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

		// Token: 0x0600087E RID: 2174 RVA: 0x00013D14 File Offset: 0x00011F14
		internal static void NumberToString(ValueStringBuilder sb, Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00013ED4 File Offset: 0x000120D4
		internal unsafe static void NumberToStringFormat(ValueStringBuilder sb, Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
			char* digits = number.digits;
			bool sign = number.sign;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00014168 File Offset: 0x00012368
		private static void FormatCurrency(ValueStringBuilder sb, Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			bool sign = number.sign;
			long num = 0L;
			int[] currencyGroupSizes = info.currencyGroupSizes;
			string currencyGroupSeparator = info.currencyGroupSeparator;
			string currencyDecimalSeparator = info.currencyDecimalSeparator;
			Number.FormatFixed(sb, number, (int)num, nMaxDigits, info, currencyGroupSizes, currencyDecimalSeparator, currencyGroupSeparator);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00014234 File Offset: 0x00012434
		private unsafe static void FormatFixed(ValueStringBuilder sb, Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
		{
			int num = 1;
			int scale = number.scale;
			char* digits = number.digits;
			long num2;
			if (groupDigits == null)
			{
				num2.m_value = groupDigits;
				return;
			}
			num2 = 0L;
			if (num != 0)
			{
				int stringLength = sGroup._stringLength;
				int num3 = 48;
				num2.m_value = (long)num3;
				return;
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000142D0 File Offset: 0x000124D0
		private static void FormatNumber(ValueStringBuilder sb, Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			int num = 1;
			bool sign = number.sign;
			if (num == 0)
			{
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00014390 File Offset: 0x00012590
		private unsafe static void FormatScientific(ValueStringBuilder sb, Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
		{
			char* digits = number.digits;
			int length = sb._chars._length;
			Span<char> chars = sb._chars;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00014450 File Offset: 0x00012650
		private static void FormatExponent(ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
		{
			int length = sb._chars._length;
			sb._chars._pointer = expChar;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0001451C File Offset: 0x0001271C
		private static void FormatGeneral(ValueStringBuilder sb, Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
		{
			int scale = number.scale;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00014614 File Offset: 0x00012814
		private static void FormatPercent(ValueStringBuilder sb, Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			bool sign = number.sign;
			long num = 0L;
			int[] percentGroupSizes = info.percentGroupSizes;
			string percentDecimalSeparator = info.percentDecimalSeparator;
			string percentGroupSeparator = info.percentGroupSeparator;
			Number.FormatFixed(sb, number, (int)num, nMaxDigits, info, percentGroupSizes, percentDecimalSeparator, percentGroupSeparator);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000146E0 File Offset: 0x000128E0
		private unsafe static void RoundNumber(Number.NumberBuffer number, int pos)
		{
			char* digits = number.digits;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00014728 File Offset: 0x00012928
		private static int FindSection(ReadOnlySpan<char> format, int section)
		{
			if (section != 0)
			{
				return;
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint Low32(ulong value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint High32(ulong value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint Int64DivMod1E9(ulong value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0001473C File Offset: 0x0001293C
		private static bool NumberToInt32(Number.NumberBuffer number, int value)
		{
			/*
An exception occurred when decompiling this method (0600088C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::NumberToInt32(System.Number/NumberBuffer,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_2_07, ldc.i4:int64(0))
	stfld:int32(NumberBuffer::precision, ldloc:NumberBuffer[exp:valuetype System.Number/NumberBuffer&](number), ldloc:int64[exp:int32](var_2_07))
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

		// Token: 0x0600088D RID: 2189 RVA: 0x00014760 File Offset: 0x00012960
		private static bool NumberToInt64(Number.NumberBuffer number, long value)
		{
			/*
An exception occurred when decompiling this method (0600088D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::NumberToInt64(System.Number/NumberBuffer,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_2_07, ldc.i4:int64(0))
	stfld:int32(NumberBuffer::precision, ldloc:NumberBuffer[exp:valuetype System.Number/NumberBuffer&](number), ldloc:int64[exp:int32](var_2_07))
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

		// Token: 0x0600088E RID: 2190 RVA: 0x00014784 File Offset: 0x00012984
		private static bool NumberToUInt32(Number.NumberBuffer number, uint value)
		{
			/*
An exception occurred when decompiling this method (0600088E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::NumberToUInt32(System.Number/NumberBuffer,System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_3_07, ldc.i4:int64(0))
	stfld:int32(NumberBuffer::precision, ldloc:NumberBuffer[exp:valuetype System.Number/NumberBuffer&](number), ldloc:int64[exp:int32](var_3_07))
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

		// Token: 0x0600088F RID: 2191 RVA: 0x000147A4 File Offset: 0x000129A4
		private static bool NumberToUInt64(Number.NumberBuffer number, ulong value)
		{
			/*
An exception occurred when decompiling this method (0600088F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::NumberToUInt64(System.Number/NumberBuffer,System.UInt64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_3_07, ldc.i4:int64(0))
	stfld:int32(NumberBuffer::precision, ldloc:NumberBuffer[exp:valuetype System.Number/NumberBuffer&](number), ldloc:int64[exp:int32](var_3_07))
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

		// Token: 0x06000890 RID: 2192 RVA: 0x000147C4 File Offset: 0x000129C4
		internal static int ParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			/*
An exception occurred when decompiling this method (06000890)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Number::ParseInt32(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
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

		// Token: 0x06000891 RID: 2193 RVA: 0x000147E4 File Offset: 0x000129E4
		internal static long ParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			/*
An exception occurred when decompiling this method (06000891)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.Number::ParseInt64(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
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

		// Token: 0x06000892 RID: 2194 RVA: 0x00014804 File Offset: 0x00012A04
		internal static uint ParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			/*
An exception occurred when decompiling this method (06000892)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 System.Number::ParseUInt32(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
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

		// Token: 0x06000893 RID: 2195 RVA: 0x00014824 File Offset: 0x00012A24
		internal static ulong ParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			/*
An exception occurred when decompiling this method (06000893)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt64 System.Number::ParseUInt64(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
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

		// Token: 0x06000894 RID: 2196 RVA: 0x00014844 File Offset: 0x00012A44
		private unsafe static bool ParseNumber(char* str, char* strEnd, NumberStyles styles, Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
		{
			/*
An exception occurred when decompiling this method (06000894)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::ParseNumber(System.Char*,System.Char*,System.Globalization.NumberStyles,System.Number/NumberBuffer,System.Globalization.NumberFormatInfo,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_009C:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_23_6F), ldloc:int32(var_22_64))
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

		// Token: 0x06000895 RID: 2197 RVA: 0x00014900 File Offset: 0x00012B00
		internal static bool TryParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] int result)
		{
			if (!true)
			{
			}
			bool flag;
			if (!flag)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00014920 File Offset: 0x00012B20
		private static bool TryParseInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] int result, bool failureIsOverflow)
		{
			/*
An exception occurred when decompiling this method (06000896)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::TryParseInt32IntegerStyle(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0123:
	stloc:int32(var_37_127, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_28), ldloc:int32(var_37_127))
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

		// Token: 0x06000897 RID: 2199 RVA: 0x00014A60 File Offset: 0x00012C60
		private static bool TryParseInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] long result, bool failureIsOverflow)
		{
			/*
An exception occurred when decompiling this method (06000897)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::TryParseInt64IntegerStyle(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo,System.Int64,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0110:
	stloc:int32(var_36_114, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_29), ldloc:int32(var_36_114))
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

		// Token: 0x06000898 RID: 2200 RVA: 0x00014B8C File Offset: 0x00012D8C
		internal static bool TryParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] long result)
		{
			if (!true)
			{
			}
			bool flag;
			if (!flag)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00014BAC File Offset: 0x00012DAC
		internal static bool TryParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] uint result)
		{
			if (!true)
			{
			}
			bool flag;
			if (!flag)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00014BCC File Offset: 0x00012DCC
		private static bool TryParseUInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] uint result, bool failureIsOverflow)
		{
			/*
An exception occurred when decompiling this method (0600089A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::TryParseUInt32IntegerStyle(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo,System.UInt32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00FF:
	stloc:int64(var_33_100, ldc.i4:int64(0))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_25), ldloc:int64[exp:int32](var_33_100))
	brtrue(IL_0000, ldc.i4:bool(0))
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

		// Token: 0x0600089B RID: 2203 RVA: 0x00014CEC File Offset: 0x00012EEC
		private static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] uint result, bool failureIsOverflow)
		{
			/*
An exception occurred when decompiling this method (0600089B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::TryParseUInt32HexNumberStyle(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo,System.UInt32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002E:
	stloc:int32(var_7_2F, ldc.i4:int32(1))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](failureIsOverflow), ldloc:int32[exp:bool](var_7_2F))
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

		// Token: 0x0600089C RID: 2204 RVA: 0x00014D38 File Offset: 0x00012F38
		internal static bool TryParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] ulong result)
		{
			if (!true)
			{
			}
			bool flag;
			if (!flag)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00014D58 File Offset: 0x00012F58
		private static bool TryParseUInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] ulong result, bool failureIsOverflow)
		{
			/*
An exception occurred when decompiling this method (0600089D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::TryParseUInt64IntegerStyle(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo,System.UInt64,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0104:
	stloc:int64(var_33_105, ldc.i4:int64(0))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_25), ldloc:int64[exp:int32](var_33_105))
	brtrue(IL_0000, ldc.i4:bool(0))
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

		// Token: 0x0600089E RID: 2206 RVA: 0x00014E80 File Offset: 0x00013080
		private static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] ulong result, bool failureIsOverflow)
		{
			/*
An exception occurred when decompiling this method (0600089E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::TryParseUInt64HexNumberStyle(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo,System.UInt64,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002E:
	stloc:int32(var_7_2F, ldc.i4:int32(1))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](failureIsOverflow), ldloc:int32[exp:bool](var_7_2F))
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

		// Token: 0x0600089F RID: 2207 RVA: 0x00014ECC File Offset: 0x000130CC
		internal static decimal ParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00014EE8 File Offset: 0x000130E8
		private static bool NumberBufferToDecimal(Number.NumberBuffer number, decimal value)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00014F3C File Offset: 0x0001313C
		internal static double ParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			string positiveInfinitySymbol;
			do
			{
				ReadOnlySpan<char> readOnlySpan2;
				ReadOnlySpan<char> readOnlySpan = MemoryExtensions.TrimEnd(readOnlySpan2);
				positiveInfinitySymbol = info.positiveInfinitySymbol;
				if (positiveInfinitySymbol == null)
				{
					break;
				}
				char rawStringData = positiveInfinitySymbol.GetRawStringData();
			}
			while (positiveInfinitySymbol._stringLength != 0);
			if (value != null)
			{
			}
			return 0.0;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00015014 File Offset: 0x00013214
		internal static float ParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			/*
An exception occurred when decompiling this method (060008A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.Number::ParseSingle(System.ReadOnlySpan`1<System.Char>,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0083:
	brtrue(IL_0000, logicnot:bool(ldstr:string[exp:bool]("Value was either too large or too small for a Single.")))
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

		// Token: 0x060008A3 RID: 2211 RVA: 0x000150B0 File Offset: 0x000132B0
		internal static bool TryParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] decimal result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000150C8 File Offset: 0x000132C8
		internal static bool TryParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] double result)
		{
			if (!true)
			{
			}
			bool flag;
			if (!flag)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000150DC File Offset: 0x000132DC
		internal static bool TryParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, [Out] float result)
		{
			if (!true)
			{
			}
			bool flag;
			if (!flag)
			{
			}
			return true;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000150F4 File Offset: 0x000132F4
		private static void StringToNumber(ReadOnlySpan<char> value, NumberStyles styles, Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00015104 File Offset: 0x00013304
		internal static bool TryStringToNumber(ReadOnlySpan<char> value, NumberStyles styles, Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
		{
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00015114 File Offset: 0x00013314
		private static bool TrailingZeros(ReadOnlySpan<char> value, int index)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00015128 File Offset: 0x00013328
		private unsafe static char* MatchChars(char* p, char* pEnd, string value)
		{
			if (pEnd != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool IsWhite(int ch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool IsDigit(int ch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00015148 File Offset: 0x00013348
		private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey)
		{
			string resourceString = SR.GetResourceString(overflowResourceKey);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0001515C File Offset: 0x0001335C
		private static bool NumberBufferToDouble(Number.NumberBuffer number, double value)
		{
			/*
An exception occurred when decompiling this method (060008AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number::NumberBufferToDouble(System.Number/NumberBuffer,System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stfld:int32(NumberBuffer::precision, ldloc:NumberBuffer[exp:valuetype System.Number/NumberBuffer&](number), ldloc:float64[exp:int32](var_0))
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

		// Token: 0x060008AE RID: 2222 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static uint DigitsToInt(char* p, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0000207A File Offset: 0x0000027A
		private static ulong Mul32x32To64(uint a, uint b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00015174 File Offset: 0x00013374
		private static ulong Mul64Lossy(ulong a, ulong b, int pexp)
		{
			/*
An exception occurred when decompiling this method (060008B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt64 System.Number::Mul64Lossy(System.UInt64,System.UInt64,System.Int32)

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

		// Token: 0x060008B1 RID: 2225 RVA: 0x0000207A File Offset: 0x0000027A
		private static int abs(int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00015184 File Offset: 0x00013384
		private unsafe static double NumberToDouble(Number.NumberBuffer number)
		{
			char* ptr;
			int num;
			int num2;
			if (string.wcslen(ptr) != 0)
			{
				num = 9;
				if (ptr == null)
				{
				}
				num2 = 9;
				if (ptr == null)
				{
				}
			}
			if (num2 == 0)
			{
			}
			if (num != 0)
			{
				if (ptr == null)
				{
				}
				if (ptr == null)
				{
				}
				if (ptr == null)
				{
				}
			}
			if (ptr == null)
			{
				return;
			}
			if (ptr == null)
			{
			}
			if (ptr == null)
			{
			}
			if (ptr == null)
			{
				return;
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000151D0 File Offset: 0x000133D0
		private unsafe static void DoubleToNumber(double value, int precision, Number.NumberBuffer number)
		{
			number.precision = precision;
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = 32768;
			number.scale = num;
			if (!true)
			{
			}
			char* digits = number.digits;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000152B0 File Offset: 0x000134B0
		// Note: this type is marked as 'beforefieldinit'.
		static Number()
		{
			if (("$#" == null || "$#" != null) && ("#$" == null || "#$" != null) && ("$ #" == null || "$ #" != null) && ("# $" == null || "# $" != null) && ("($#)" == null || "($#)" != null) && ("-$#" == null || "-$#" != null) && ("$-#" == null || "$-#" != null) && ("$#-" == null || "$#-" != null) && ("(#$)" == null || "(#$)" != null) && ("-#$" == null || "-#$" != null) && ("#-$" == null || "#-$" != null) && ("#$-" == null || "#$-" != null) && ("-# $" == null || "-# $" != null) && ("-$ #" == null || "-$ #" != null) && ("# $-" == null || "# $-" != null) && ("$ #-" == null || "$ #-" != null) && ("$ -#" == null || "$ -#" != null) && ("#- $" == null || "#- $" != null) && ("($ #)" == null || "($ #)" != null) && ("(# $)" == null || "(# $)" != null) && ("# %" == null || "# %" != null) && ("#%" == null || "#%" != null) && ("%#" == null || "%#" != null) && ("% #" == null || "% #" != null) && ("-# %" == null || "-# %" != null) && ("-#%" == null || "-#%" != null) && ("-%#" == null || "-%#" != null) && ("%-#" == null || "%-#" != null) && ("%#-" == null || "%#-" != null) && ("#-%" == null || "#-%" != null) && ("#%-" == null || "#%-" != null) && ("-% #" == null || "-% #" != null) && ("# %-" == null || "# %-" != null) && ("% #-" == null || "% #-" != null) && ("% -#" == null || "% -#" != null) && ("(#)" == null || "(#)" != null) && ("-#" == null || "-#" != null) && ("- #" == null || "- #" != null) && ("#-" == null || "#-" != null) && ("# -" == null || "# -" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400036F RID: 879
		private static readonly string[] s_posCurrencyFormats;

		// Token: 0x04000370 RID: 880
		private static readonly string[] s_negCurrencyFormats;

		// Token: 0x04000371 RID: 881
		private static readonly string[] s_posPercentFormats;

		// Token: 0x04000372 RID: 882
		private static readonly string[] s_negPercentFormats;

		// Token: 0x04000373 RID: 883
		private static readonly string[] s_negNumberFormats;

		// Token: 0x04000374 RID: 884
		private static readonly int[] s_charToHexLookup;

		// Token: 0x04000375 RID: 885
		private static readonly ulong[] s_rgval64Power10;

		// Token: 0x04000376 RID: 886
		private static readonly sbyte[] s_rgexp64Power10;

		// Token: 0x04000377 RID: 887
		private static readonly ulong[] s_rgval64Power10By16;

		// Token: 0x04000378 RID: 888
		private static readonly short[] s_rgexp64Power10By16;

		// Token: 0x020000E6 RID: 230
		[StructLayout(0, Pack = 1, Size = 122)]
		internal ref struct NumberBuffer
		{
			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00015558 File Offset: 0x00013758
			// (set) Token: 0x060008B6 RID: 2230 RVA: 0x0001556C File Offset: 0x0001376C
			public bool sign
			{
				get
				{
					/*
An exception occurred when decompiling this method (060008B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Number/NumberBuffer::get_sign()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NumberBuffer::_sign, ldloc:valuetype System.Number/NumberBuffer&(this)))
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
				set
				{
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0000207A File Offset: 0x0000027A
			public unsafe char* digits
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x04000379 RID: 889
			public int precision;

			// Token: 0x0400037A RID: 890
			public int scale;

			// Token: 0x0400037B RID: 891
			private int _sign;

			// Token: 0x0400037C RID: 892
			private Number.NumberBuffer.DigitsAndNullTerminator _digits;

			// Token: 0x0400037D RID: 893
			private unsafe char* _allDigits;

			// Token: 0x020000E7 RID: 231
			private struct DigitsAndNullTerminator
			{
			}
		}
	}
}
