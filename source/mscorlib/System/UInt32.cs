using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000115 RID: 277
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct UInt32 : IComparable, IConvertible, IFormattable, IComparable<uint>, IEquatable<uint>, ISpanFormattable
	{
		// Token: 0x06000AC6 RID: 2758 RVA: 0x000183EC File Offset: 0x000165EC
		public int CompareTo(object value)
		{
			if (value != null)
			{
			}
			return 1;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0000207A File Offset: 0x0000027A
		public int CompareTo(uint value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00018400 File Offset: 0x00016600
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000207A File Offset: 0x0000027A
		[NonVersionable]
		public bool Equals(uint obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00018414 File Offset: 0x00016614
		public override string ToString()
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00018428 File Offset: 0x00016628
		public string ToString(IFormatProvider provider)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0001843C File Offset: 0x0001663C
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

		// Token: 0x06000ACE RID: 2766 RVA: 0x00018460 File Offset: 0x00016660
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

		// Token: 0x06000ACF RID: 2767 RVA: 0x00018484 File Offset: 0x00016684
		public bool TryFormat(Span<char> destination, [Out] int charsWritten, [Optional] ReadOnlySpan<char> format, [Optional] IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00018498 File Offset: 0x00016698
		[CLSCompliant(false)]
		public static uint Parse(string s)
		{
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			uint num;
			return num;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000184B8 File Offset: 0x000166B8
		[CLSCompliant(false)]
		public static uint Parse(string s, IFormatProvider provider)
		{
			uint num;
			return num;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000184D0 File Offset: 0x000166D0
		[CLSCompliant(false)]
		public static uint Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			uint num;
			return num;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000184E8 File Offset: 0x000166E8
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, [Out] uint result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000184F8 File Offset: 0x000166F8
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt32;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00018508 File Offset: 0x00016708
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0001851C File Offset: 0x0001671C
		char IConvertible.ToChar(IFormatProvider provider)
		{
			if (!true)
			{
			}
			char c;
			return c;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00018530 File Offset: 0x00016730
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			sbyte b;
			return b;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00018544 File Offset: 0x00016744
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.ToByte((uint)0);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0001855C File Offset: 0x0001675C
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			short num;
			return num;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00018570 File Offset: 0x00016770
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ushort num;
			return num;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00018584 File Offset: 0x00016784
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0000207A File Offset: 0x0000027A
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00018598 File Offset: 0x00016798
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			long num;
			return num;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000185AC File Offset: 0x000167AC
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ulong num;
			return num;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x000185C0 File Offset: 0x000167C0
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000ADF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.UInt32::System.IConvertible.ToSingle(System.IFormatProvider)

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

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000185D0 File Offset: 0x000167D0
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000AE0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.UInt32::System.IConvertible.ToDouble(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldstr:string[exp:bool]("Shadow Key"))
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

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000185E4 File Offset: 0x000167E4
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x000185F8 File Offset: 0x000167F8
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000AE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.UInt32::System.IConvertible.ToDateTime(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_14, call:string(SR::Format, ldstr:string("Invalid cast from '{0}' to '{1}'."), ldstr:string[exp:object]("UInt32"), ldstr:string[exp:object]("DateTime")))
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

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0001861C File Offset: 0x0001681C
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			object obj;
			return obj;
		}

		// Token: 0x040003F9 RID: 1017
		private readonly uint m_value;

		// Token: 0x040003FA RID: 1018
		public const uint MaxValue = 4294967295U;

		// Token: 0x040003FB RID: 1019
		public const uint MinValue = 0U;
	}
}
