using System;
using System.Globalization;
using System.Numerics;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000FB RID: 251
	internal static class SpanHelpers
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x00016770 File Offset: 0x00014970
		public static int IndexOfAny(byte searchSpace, int searchSpaceLength, byte value, int valueLength)
		{
			int num;
			while (value != 0)
			{
				if (num != 0)
				{
					return num;
				}
			}
			return num;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00016788 File Offset: 0x00014988
		public static int IndexOf(byte searchSpace, byte value, int length)
		{
			/*
An exception occurred when decompiling this method (06000969)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.SpanHelpers::IndexOf(System.Byte,System.Byte,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_20_C3, call:native int(native int::op_Subtraction, ldloc:native int(var_8_48), ldc.i4:int32(1)))
	stloc:void*(var_21_CC, call:void*(native int::op_Explicit, ldloc:native int(var_19_AD)))
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

		// Token: 0x0600096A RID: 2410 RVA: 0x00016864 File Offset: 0x00014A64
		public unsafe static bool SequenceEqual(byte first, byte second, ulong length)
		{
			IntPtr intPtr = (IntPtr)0;
			IntPtr intPtr2;
			void* ptr = (void*)intPtr2;
			IntPtr intPtr3 = intPtr2 - 8;
			void* ptr2 = (void*)intPtr3;
			void* ptr3 = (void*)intPtr;
			if (!true)
			{
			}
			IntPtr intPtr4 = intPtr + 8;
			void* ptr4 = (void*)intPtr3;
			void* ptr5 = (void*)intPtr4;
			IntPtr intPtr5 = intPtr4 + 1;
			void* ptr6 = (void*)intPtr3;
			void* ptr7 = (void*)intPtr5;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000168D8 File Offset: 0x00014AD8
		public unsafe static int SequenceCompareTo(char first, int firstLength, char second, int secondLength)
		{
			IntPtr intPtr = (IntPtr)0;
			IntPtr intPtr2 = (IntPtr)0;
			void* ptr = (void*)intPtr;
			bool isHardwareAccelerated = Vector.IsHardwareAccelerated;
			void* ptr2 = (void*)intPtr;
			IntPtr intPtr3 = intPtr - 0;
			if (!false)
			{
			}
			return 42247576;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000169D4 File Offset: 0x00014BD4
		public static int IndexOf(char searchSpace, char value, int length)
		{
			/*
An exception occurred when decompiling this method (0600096C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.SpanHelpers::IndexOf(System.Char,System.Char,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:bool(var_3_1E, callgetter:bool(Vector::get_IsHardwareAccelerated))
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

		// Token: 0x0600096D RID: 2413 RVA: 0x00016A08 File Offset: 0x00014C08
		public static int LastIndexOf(char searchSpace, char value, int length)
		{
			/*
An exception occurred when decompiling this method (0600096D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.SpanHelpers::LastIndexOf(System.Char,System.Char,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:bool(var_4_17, callgetter:bool(Vector::get_IsHardwareAccelerated))
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

		// Token: 0x0600096E RID: 2414 RVA: 0x00016A30 File Offset: 0x00014C30
		private static int LocateFirstFoundChar(Vector<ushort> match)
		{
			int num = 1;
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

		// Token: 0x0600096F RID: 2415 RVA: 0x0000207A File Offset: 0x0000027A
		private static int LocateFirstFoundChar(ulong match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00016A4C File Offset: 0x00014C4C
		private static int LocateLastFoundChar(Vector<ushort> match)
		{
			/*
An exception occurred when decompiling this method (06000970)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.SpanHelpers::LocateLastFoundChar(System.Numerics.Vector`1<System.UInt16>)

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

		// Token: 0x06000971 RID: 2417 RVA: 0x00016A5C File Offset: 0x00014C5C
		private static int LocateLastFoundChar(ulong match)
		{
			return 3;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00016A6C File Offset: 0x00014C6C
		public static int IndexOf<T>(T searchSpace, T value, int length) where T : IEquatable<T>
		{
			/*
An exception occurred when decompiling this method (06000972)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.SpanHelpers::IndexOf<T>(T,T,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_01, ldc.i4:int64(0))
	stloc:native int(var_2_0A, call:native int(native int::op_Explicit, ldloc:int64[exp:int32](var_0_01)))
	stloc:int32(var_4_0C, ldc.i4:int32(1))
	stloc:native int(var_5_16, call:native int(native int::op_Addition, ldloc:native int(var_2_0A), ldloc:int32(var_4_0C)))
	stloc:int32(var_7_19, ldc.i4:int32(1))
	stloc:native int(var_8_24, call:native int(native int::op_Addition, ldloc:native int(var_5_16), ldloc:int32(var_7_19)))
	stloc:int32(var_10_27, ldc.i4:int32(2))
	stloc:native int(var_11_32, call:native int(native int::op_Addition, ldloc:native int(var_5_16), ldloc:int32(var_10_27)))
	stloc:int32(var_13_35, ldc.i4:int32(3))
	stloc:native int(var_14_40, call:native int(native int::op_Addition, ldloc:native int(var_5_16), ldloc:int32(var_13_35)))
	stloc:int32(var_16_43, ldc.i4:int32(4))
	stloc:native int(var_17_4E, call:native int(native int::op_Addition, ldloc:native int(var_5_16), ldloc:int32(var_16_43)))
	stloc:int32(var_19_51, ldc.i4:int32(5))
	stloc:native int(var_20_5C, call:native int(native int::op_Addition, ldloc:native int(var_5_16), ldloc:int32(var_19_51)))
	stloc:int32(var_22_5F, ldc.i4:int32(6))
	stloc:native int(var_23_6A, call:native int(native int::op_Addition, ldloc:native int(var_5_16), ldloc:int32(var_22_5F)))
	stloc:int32(var_25_6D, ldc.i4:int32(7))
	stloc:native int(var_26_78, call:native int(native int::op_Addition, ldloc:native int(var_5_16), ldloc:int32(var_25_6D)))
	stloc:int32(var_28_7B, ldc.i4:int32(8))
	stloc:native int(var_29_86, call:native int(native int::op_Addition, ldloc:native int(var_5_16), ldloc:int32(var_28_7B)))
	stloc:int32(var_31_89, ldc.i4:int32(1))
	stloc:native int(var_32_94, call:native int(native int::op_Addition, ldloc:native int(var_29_86), ldloc:int32(var_31_89)))
	stloc:int32(var_34_97, ldc.i4:int32(2))
	stloc:native int(var_35_A2, call:native int(native int::op_Addition, ldloc:native int(var_29_86), ldloc:int32(var_34_97)))
	stloc:int32(var_37_A5, ldc.i4:int32(3))
	stloc:native int(var_38_B0, call:native int(native int::op_Addition, ldloc:native int(var_29_86), ldloc:int32(var_37_A5)))
	stloc:int32(var_40_B3, ldc.i4:int32(3))
	stloc:void*(var_41_C3, call:void*(native int::op_Explicit, call:native int(native int::op_Addition, ldloc:native int(var_29_86), ldloc:int32(var_40_B3))))
	stloc:int32(var_42_C6, ldc.i4:int32(4))
	stloc:native int(var_43_D1, call:native int(native int::op_Addition, ldloc:native int(var_29_86), ldloc:int32(var_42_C6)))
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

		// Token: 0x06000973 RID: 2419 RVA: 0x00016B4C File Offset: 0x00014D4C
		public static int IndexOfAny<T>(T searchSpace, int searchSpaceLength, T value, int valueLength) where T : IEquatable<T>
		{
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00016B60 File Offset: 0x00014D60
		public static bool SequenceEqual<T>(T first, T second, int length) where T : IEquatable<T>
		{
			/*
An exception occurred when decompiling this method (06000974)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.SpanHelpers::SequenceEqual<T>(T,T,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_01, ldc.i4:int64(0))
	stloc:native int(var_2_0A, call:native int(native int::op_Explicit, ldloc:int64[exp:int32](var_0_01)))
	stloc:int32(var_5_0E, ldc.i4:int32(1))
	stloc:native int(var_6_18, call:native int(native int::op_Addition, ldloc:native int(var_2_0A), ldloc:int32(var_5_0E)))
	stloc:int32(var_8_1B, ldc.i4:int32(1))
	stloc:native int(var_9_26, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_8_1B)))
	stloc:int32(var_10_29, ldc.i4:int32(1))
	stloc:native int(var_11_34, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_10_29)))
	stloc:int32(var_13_37, ldc.i4:int32(2))
	stloc:native int(var_14_42, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_13_37)))
	stloc:int32(var_15_45, ldc.i4:int32(2))
	stloc:native int(var_16_50, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_15_45)))
	stloc:int32(var_18_53, ldc.i4:int32(3))
	stloc:native int(var_19_5E, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_18_53)))
	stloc:int32(var_20_61, ldc.i4:int32(3))
	stloc:native int(var_21_6C, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_20_61)))
	stloc:int32(var_23_6F, ldc.i4:int32(4))
	stloc:native int(var_24_7A, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_23_6F)))
	stloc:int32(var_25_7D, ldc.i4:int32(4))
	stloc:native int(var_26_88, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_25_7D)))
	stloc:int32(var_28_8B, ldc.i4:int32(5))
	stloc:native int(var_29_96, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_28_8B)))
	stloc:int32(var_30_99, ldc.i4:int32(5))
	stloc:native int(var_31_A4, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_30_99)))
	stloc:int32(var_33_A7, ldc.i4:int32(6))
	stloc:native int(var_34_B2, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_33_A7)))
	stloc:int32(var_35_B5, ldc.i4:int32(6))
	stloc:native int(var_36_C0, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_35_B5)))
	stloc:int32(var_38_C3, ldc.i4:int32(7))
	stloc:native int(var_39_CE, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_38_C3)))
	stloc:int32(var_40_D1, ldc.i4:int32(7))
	stloc:native int(var_41_DC, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_40_D1)))
	stloc:int32(var_43_DF, ldc.i4:int32(8))
	stloc:native int(var_44_EA, call:native int(native int::op_Addition, ldloc:native int(var_6_18), ldloc:int32(var_43_DF)))
	stloc:int32(var_47_F0, ldc.i4:int32(1))
	stloc:native int(var_48_FB, call:native int(native int::op_Addition, ldloc:native int(var_44_EA), ldloc:int32(var_47_F0)))
	stloc:int32(var_49_FE, ldc.i4:int32(1))
	stloc:native int(var_50_109, call:native int(native int::op_Addition, ldloc:native int(var_44_EA), ldloc:int32(var_49_FE)))
	stloc:int32(var_52_10C, ldc.i4:int32(2))
	stloc:native int(var_53_117, call:native int(native int::op_Addition, ldloc:native int(var_44_EA), ldloc:int32(var_52_10C)))
	stloc:int32(var_54_11A, ldc.i4:int32(2))
	stloc:native int(var_55_125, call:native int(native int::op_Addition, ldloc:native int(var_44_EA), ldloc:int32(var_54_11A)))
	stloc:int32(var_57_128, ldc.i4:int32(3))
	stloc:native int(var_58_133, call:native int(native int::op_Addition, ldloc:native int(var_44_EA), ldloc:int32(var_57_128)))
	stloc:int32(var_59_136, ldc.i4:int32(3))
	stloc:native int(var_60_141, call:native int(native int::op_Addition, ldloc:native int(var_44_EA), ldloc:int32(var_59_136)))
	stloc:int32(var_62_144, ldc.i4:int32(4))
	stloc:native int(var_63_14F, call:native int(native int::op_Addition, ldloc:native int(var_44_EA), ldloc:int32(var_62_144)))
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

		// Token: 0x06000975 RID: 2421 RVA: 0x00016CC0 File Offset: 0x00014EC0
		public static bool EndsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int length = span._length;
			int length2 = value._length;
			int length3 = value._length;
			bool flag;
			return flag;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00016D0C File Offset: 0x00014F0C
		public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				bool flag;
				return flag;
			}
			if (span != null)
			{
				bool flag2;
				return flag2;
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00016D2C File Offset: 0x00014F2C
		public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			/*
An exception occurred when decompiling this method (06000977)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.SpanHelpers::EndsWithOrdinalIgnoreCaseHelper(System.ReadOnlySpan`1<System.Char>,System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_09, call:int32(CompareInfo::CompareOrdinalIgnoreCase, ldloc:valuetype System.ReadOnlySpan`1<char>[exp:ReadOnlySpan`1](span), ldloc:valuetype System.ReadOnlySpan`1<char>[exp:ReadOnlySpan`1](span)))
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

		// Token: 0x06000978 RID: 2424 RVA: 0x00016D48 File Offset: 0x00014F48
		public static void ClearWithoutReferences(byte b, ulong byteLength)
		{
			if (byteLength != 0UL)
			{
				return;
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00016D7C File Offset: 0x00014F7C
		public static void ClearWithReferences(IntPtr ip, ulong pointerSizeLength)
		{
			IntPtr intPtr = (IntPtr)((long)pointerSizeLength);
			IntPtr intPtr2 = (IntPtr)((long)pointerSizeLength);
			IntPtr intPtr3 = (IntPtr)((long)pointerSizeLength);
			IntPtr intPtr4 = (IntPtr)((long)pointerSizeLength);
			IntPtr intPtr5 = (IntPtr)((long)pointerSizeLength);
			IntPtr intPtr6 = (IntPtr)((long)pointerSizeLength);
			IntPtr intPtr7 = (IntPtr)((long)pointerSizeLength);
			IntPtr intPtr8 = (IntPtr)((long)pointerSizeLength);
			if (pointerSizeLength == 0UL)
			{
				return;
			}
		}
	}
}
