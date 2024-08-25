using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000090 RID: 144
	public static class BitConverter
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x0000207A File Offset: 0x0000027A
		public static byte[] GetBytes(int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000207A File Offset: 0x0000027A
		public static byte[] GetBytes(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000207A File Offset: 0x0000027A
		[CLSCompliant(false)]
		public static byte[] GetBytes(ushort value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000207A File Offset: 0x0000027A
		[CLSCompliant(false)]
		public static byte[] GetBytes(uint value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000C914 File Offset: 0x0000AB14
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, uint value)
		{
			return true;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000207A File Offset: 0x0000027A
		public static byte[] GetBytes(float value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000C924 File Offset: 0x0000AB24
		public static short ToInt16(byte[] value, int startIndex)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000C938 File Offset: 0x0000AB38
		public static int ToInt32(byte[] value, int startIndex)
		{
			return 5;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000C94C File Offset: 0x0000AB4C
		public static long ToInt64(byte[] value, int startIndex)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000C960 File Offset: 0x0000AB60
		[CLSCompliant(false)]
		public static ushort ToUInt16(byte[] value, int startIndex)
		{
			/*
An exception occurred when decompiling this method (0600041E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt16 System.BitConverter::ToUInt16(System.Byte[],System.Int32)

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

		// Token: 0x0600041F RID: 1055 RVA: 0x0000C970 File Offset: 0x0000AB70
		[CLSCompliant(false)]
		public static uint ToUInt32(byte[] value, int startIndex)
		{
			/*
An exception occurred when decompiling this method (0600041F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 System.BitConverter::ToUInt32(System.Byte[],System.Int32)

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

		// Token: 0x06000420 RID: 1056 RVA: 0x0000C980 File Offset: 0x0000AB80
		public static string ToString(byte[] value, int startIndex, int length)
		{
			do
			{
				if (value != null)
				{
				}
			}
			while (startIndex == 0);
			string text;
			return text;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000C9A0 File Offset: 0x0000ABA0
		public static string ToString(byte[] value)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000207A File Offset: 0x0000027A
		public static long DoubleToInt64Bits(double value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000207A File Offset: 0x0000027A
		public static double Int64BitsToDouble(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000207A File Offset: 0x0000027A
		public static int SingleToInt32Bits(float value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		static BitConverter()
		{
		}

		// Token: 0x040001FD RID: 509
		[Intrinsic]
		public static readonly bool IsLittleEndian;

		// Token: 0x02000091 RID: 145
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000426 RID: 1062 RVA: 0x0000C9C8 File Offset: 0x0000ABC8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
			public <>c()
			{
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x0000C9EC File Offset: 0x0000ABEC
			internal void <ToString>b__38_0(Span<char> dst, [TupleElementNames(new string[] { "value", "startIndex", "length" })] ValueTuple<byte[], int, int> state)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				char c;
				dst._pointer = c;
				int num = 45;
				dst._pointer = num;
				char c2;
				dst._pointer = c2;
				char c3;
				dst._pointer = c3;
			}

			// Token: 0x040001FE RID: 510
			public static readonly BitConverter.<>c <>9;

			// Token: 0x040001FF RID: 511
			[TupleElementNames(new string[] { "value", "startIndex", "length" })]
			public static SpanAction<char, ValueTuple<byte[], int, int>> <>9__38_0;
		}
	}
}
