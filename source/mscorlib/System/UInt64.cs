using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000116 RID: 278
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct UInt64 : IComparable, IConvertible, IFormattable, IComparable<ulong>, IEquatable<ulong>, ISpanFormattable
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001862C File Offset: 0x0001682C
		public int CompareTo(object value)
		{
			if (value != null)
			{
			}
			return 1;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0000207A File Offset: 0x0000027A
		public int CompareTo(ulong value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00018640 File Offset: 0x00016840
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0000207A File Offset: 0x0000027A
		[NonVersionable]
		public bool Equals(ulong obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00018654 File Offset: 0x00016854
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06000AE8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.UInt64::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, ldfld:uint64(uint64::m_value, ldloc:uint64&(this)))
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

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00018668 File Offset: 0x00016868
		public override string ToString()
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001867C File Offset: 0x0001687C
		public string ToString(IFormatProvider provider)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00018690 File Offset: 0x00016890
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

		// Token: 0x06000AEC RID: 2796 RVA: 0x000186B4 File Offset: 0x000168B4
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

		// Token: 0x06000AED RID: 2797 RVA: 0x000186D8 File Offset: 0x000168D8
		public bool TryFormat(Span<char> destination, [Out] int charsWritten, [Optional] ReadOnlySpan<char> format, [Optional] IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000186EC File Offset: 0x000168EC
		[CLSCompliant(false)]
		public static ulong Parse(string s, IFormatProvider provider)
		{
			ulong num;
			return num;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00018704 File Offset: 0x00016904
		[CLSCompliant(false)]
		public static ulong Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			ulong num;
			return num;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0001871C File Offset: 0x0001691C
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, [Out] ulong result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0001872C File Offset: 0x0001692C
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt64;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0001873C File Offset: 0x0001693C
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00018750 File Offset: 0x00016950
		char IConvertible.ToChar(IFormatProvider provider)
		{
			if (!true)
			{
			}
			char c;
			return c;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00018764 File Offset: 0x00016964
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			sbyte b;
			return b;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00018778 File Offset: 0x00016978
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			byte b;
			return b;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0001878C File Offset: 0x0001698C
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			short num;
			return num;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000187A0 File Offset: 0x000169A0
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ushort num;
			return num;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000187B4 File Offset: 0x000169B4
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			if ("Shadow Key" == null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000187CC File Offset: 0x000169CC
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			uint num;
			return num;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000187E0 File Offset: 0x000169E0
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			if ("Shadow Key" == null)
			{
			}
			return Convert.ToInt64((ulong)41672704L);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0000207A File Offset: 0x0000027A
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00018800 File Offset: 0x00016A00
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000AFC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.UInt64::System.IConvertible.ToSingle(System.IFormatProvider)

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

		// Token: 0x06000AFD RID: 2813 RVA: 0x00018810 File Offset: 0x00016A10
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000AFD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.UInt64::System.IConvertible.ToDouble(System.IFormatProvider)

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

		// Token: 0x06000AFE RID: 2814 RVA: 0x00018820 File Offset: 0x00016A20
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00018834 File Offset: 0x00016A34
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000AFF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.UInt64::System.IConvertible.ToDateTime(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_14, call:string(SR::Format, ldstr:string("Invalid cast from '{0}' to '{1}'."), ldstr:string[exp:object]("UInt64"), ldstr:string[exp:object]("DateTime")))
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

		// Token: 0x06000B00 RID: 2816 RVA: 0x00018858 File Offset: 0x00016A58
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			object obj;
			return obj;
		}

		// Token: 0x040003FC RID: 1020
		private readonly ulong m_value;

		// Token: 0x040003FD RID: 1021
		public const ulong MaxValue = 18446744073709551615UL;

		// Token: 0x040003FE RID: 1022
		public const ulong MinValue = 0UL;
	}
}
