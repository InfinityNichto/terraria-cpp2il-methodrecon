using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000F6 RID: 246
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct SByte : IComparable, IConvertible, IFormattable, IComparable<sbyte>, IEquatable<sbyte>, ISpanFormattable
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x00016034 File Offset: 0x00014234
		public int CompareTo(object obj)
		{
			if (obj != null)
			{
			}
			return 1;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0000207A File Offset: 0x0000027A
		public int CompareTo(sbyte value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00016048 File Offset: 0x00014248
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0000207A File Offset: 0x0000027A
		[NonVersionable]
		public bool Equals(sbyte obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001605C File Offset: 0x0001425C
		public override string ToString()
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00016070 File Offset: 0x00014270
		public string ToString(IFormatProvider provider)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00016084 File Offset: 0x00014284
		public string ToString(string format, IFormatProvider provider)
		{
			int stringLength2;
			if (format != null)
			{
				int stringLength = format._stringLength;
				long num = 0L;
				char c = format[(int)num];
				long num2 = 0L;
				char c2 = format[(int)num2];
				char rawStringData = format.GetRawStringData();
				stringLength2 = format._stringLength;
				string text;
				return text;
			}
			if (stringLength2 != 0)
			{
			}
			if (!true)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000160CC File Offset: 0x000142CC
		public bool TryFormat(Span<char> destination, [Out] int charsWritten, [Optional] ReadOnlySpan<char> format, [Optional] IFormatProvider provider)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000160DC File Offset: 0x000142DC
		[CLSCompliant(false)]
		public static sbyte Parse(string s, IFormatProvider provider)
		{
			sbyte b;
			return b;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000160F4 File Offset: 0x000142F4
		[CLSCompliant(false)]
		public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			sbyte b;
			return b;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0001610C File Offset: 0x0001430C
		private static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00016120 File Offset: 0x00014320
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, [Out] sbyte result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00016130 File Offset: 0x00014330
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, [Out] sbyte result)
		{
			if (!true)
			{
			}
			result.m_value = 1;
			return true;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0001614C File Offset: 0x0001434C
		public TypeCode GetTypeCode()
		{
			return TypeCode.SByte;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0001615C File Offset: 0x0001435C
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00016170 File Offset: 0x00014370
		char IConvertible.ToChar(IFormatProvider provider)
		{
			if (!true)
			{
			}
			char c;
			return c;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0000207A File Offset: 0x0000027A
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00016184 File Offset: 0x00014384
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			byte b;
			return b;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00016198 File Offset: 0x00014398
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			short num;
			return num;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x000161AC File Offset: 0x000143AC
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ushort num;
			return num;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0000207A File Offset: 0x0000027A
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000161C0 File Offset: 0x000143C0
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			uint num;
			return num;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000161D4 File Offset: 0x000143D4
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			long num;
			return num;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000161E8 File Offset: 0x000143E8
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ulong num;
			return num;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000161FC File Offset: 0x000143FC
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (0600092D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.SByte::System.IConvertible.ToSingle(System.IFormatProvider)

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

		// Token: 0x0600092E RID: 2350 RVA: 0x0001620C File Offset: 0x0001440C
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (0600092E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.SByte::System.IConvertible.ToDouble(System.IFormatProvider)

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

		// Token: 0x0600092F RID: 2351 RVA: 0x0001621C File Offset: 0x0001441C
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00016230 File Offset: 0x00014430
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000930)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.SByte::System.IConvertible.ToDateTime(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_14, call:string(SR::Format, ldstr:string("Invalid cast from '{0}' to '{1}'."), ldstr:string[exp:object]("SByte"), ldstr:string[exp:object]("DateTime")))
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

		// Token: 0x06000931 RID: 2353 RVA: 0x00016254 File Offset: 0x00014454
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			object obj;
			return obj;
		}

		// Token: 0x04000395 RID: 917
		private readonly sbyte m_value;

		// Token: 0x04000396 RID: 918
		public const sbyte MaxValue = 127;

		// Token: 0x04000397 RID: 919
		public const sbyte MinValue = -128;
	}
}
