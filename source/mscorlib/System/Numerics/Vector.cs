using System;
using System.Globalization;
using System.Numerics.Hashing;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Numerics
{
	// Token: 0x0200052B RID: 1323
	[Intrinsic]
	public struct Vector<T> : IEquatable<Vector<T>>, IFormattable where T : struct
	{
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x0000207A File Offset: 0x0000027A
		public static int Count
		{
			[Intrinsic]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x0000207A File Offset: 0x0000027A
		public static Vector<T> Zero
		{
			[Intrinsic]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00054244 File Offset: 0x00052444
		private static int InitializeCount()
		{
			/*
An exception occurred when decompiling this method (06002714)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Numerics.Vector`1::InitializeCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_2_07, call:bool(Type::op_Equality, ldloc:Type(var_0), ldloc:Type(var_1)))
	stloc:bool(var_5_10, call:bool(Type::op_Equality, ldloc:Type(var_3), ldloc:Type(var_4)))
	stloc:bool(var_8_1B, call:bool(Type::op_Equality, ldloc:Type(var_6), ldloc:Type(var_7)))
	stloc:bool(var_11_26, call:bool(Type::op_Equality, ldloc:Type(var_9), ldloc:Type(var_10)))
	stloc:bool(var_14_31, call:bool(Type::op_Equality, ldloc:Type(var_12), ldloc:Type(var_13)))
	stloc:bool(var_17_3C, call:bool(Type::op_Equality, ldloc:Type(var_15), ldloc:Type(var_16)))
	stloc:bool(var_20_47, call:bool(Type::op_Equality, ldloc:Type(var_18), ldloc:Type(var_19)))
	stloc:bool(var_23_52, call:bool(Type::op_Equality, ldloc:Type(var_21), ldloc:Type(var_22)))
	stloc:bool(var_26_5D, call:bool(Type::op_Equality, ldloc:Type(var_24), ldloc:Type(var_25)))
	stloc:bool(var_29_68, call:bool(Type::op_Equality, ldloc:Type(var_27), ldloc:Type(var_28)))
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

		// Token: 0x06002715 RID: 10005 RVA: 0x000542BC File Offset: 0x000524BC
		[Intrinsic]
		public Vector(T value)
		{
			bool isHardwareAccelerated = Vector.IsHardwareAccelerated;
			Type type;
			Type type2;
			bool flag = type == type2;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000543E8 File Offset: 0x000525E8
		internal unsafe Vector(void* dataPointer)
		{
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000543F8 File Offset: 0x000525F8
		internal unsafe Vector(void* dataPointer, int offset)
		{
			Type type;
			Type type2;
			bool flag = type == type2;
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000544A4 File Offset: 0x000526A4
		private Vector(Register existingRegister)
		{
		}

		// Token: 0x170005A1 RID: 1441
		public T this[int index]
		{
			[Intrinsic]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000544B4 File Offset: 0x000526B4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000544D0 File Offset: 0x000526D0
		[Intrinsic]
		public bool Equals(Vector<T> other)
		{
			int num = 1;
			bool isHardwareAccelerated = Vector.IsHardwareAccelerated;
			long num2 = 0L;
			if (num == 0)
			{
			}
			T t = this[(int)num2];
			if (num == 0)
			{
			}
			Type type;
			Type type2;
			return type == type2;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00054564 File Offset: 0x00052764
		public override int GetHashCode()
		{
			bool isHardwareAccelerated = Vector.IsHardwareAccelerated;
			Type type;
			Type type2;
			bool flag = type == type2;
			long num = 0L;
			long num2 = 0L;
			T t = this[(int)num];
			int num3;
			return HashHelpers.Combine((int)num2, num3);
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00054928 File Offset: 0x00052B28
		public override string ToString()
		{
			if (!true)
			{
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			return this.ToString("G", currentCulture);
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0005494C File Offset: 0x00052B4C
		public string ToString(string format, IFormatProvider formatProvider)
		{
			/*
An exception occurred when decompiling this method (0600271E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Numerics.Vector`1::ToString(System.String,System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:!T(var_5_1F, callgetter:!0[exp:!T](Vector`1::get_Item, ldloc:valuetype System.Numerics.Vector`1&(this), ldloc:int64[exp:int32](var_4_12)))
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

		// Token: 0x0600271F RID: 10015 RVA: 0x00054984 File Offset: 0x00052B84
		public static bool operator ==(Vector<T> left, Vector<T> right)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator !=(Vector<T> left, Vector<T> right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x0000207A File Offset: 0x0000027A
		[Intrinsic]
		[CLSCompliant(false)]
		public static explicit operator Vector<ulong>(Vector<T> value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00054994 File Offset: 0x00052B94
		[Intrinsic]
		internal static Vector<T> Equals(Vector<T> left, Vector<T> right)
		{
			/*
An exception occurred when decompiling this method (06002722)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Numerics.Vector`1<T> System.Numerics.Vector`1::Equals(System.Numerics.Vector`1<T>,System.Numerics.Vector`1<T>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_011D:
	brtrue(IL_0000, ldloc:int64[exp:bool](var_90_102))
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

		// Token: 0x06002723 RID: 10019 RVA: 0x00054AC4 File Offset: 0x00052CC4
		private static bool ScalarEquals(T left, T right)
		{
			Type type;
			Type type2;
			bool flag = type == type2;
			Type type3;
			Type type4;
			bool flag2 = type3 == type4;
			Type type5;
			Type type6;
			bool flag3 = type5 == type6;
			Type type7;
			Type type8;
			bool flag4 = type7 == type8;
			Type type9;
			Type type10;
			bool flag5 = type9 == type10;
			Type type11;
			Type type12;
			bool flag6 = type11 == type12;
			Type type13;
			Type type14;
			bool flag7 = type13 == type14;
			Type type15;
			Type type16;
			bool flag8 = type15 == type16;
			throw new InvalidCastException();
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00054B34 File Offset: 0x00052D34
		private static T GetOneValue()
		{
			Type type;
			Type type2;
			bool flag = type == type2;
			Type type3;
			Type type4;
			bool flag2 = type3 == type4;
			Type type5;
			Type type6;
			bool flag3 = type5 == type6;
			Type type7;
			Type type8;
			bool flag4 = type7 == type8;
			Type type9;
			Type type10;
			bool flag5 = type9 == type10;
			Type type11;
			Type type12;
			bool flag6 = type11 == type12;
			Type type13;
			Type type14;
			bool flag7 = type13 == type14;
			Type type15;
			bool flag8 = type15 == type15;
			Type type16;
			Type type17;
			bool flag9 = type16 == type17;
			Type type18;
			Type type19;
			bool flag10 = type18 == type19;
			throw new InvalidCastException();
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00054BB0 File Offset: 0x00052DB0
		private static T GetAllBitsSetValue()
		{
			Type type;
			Type type2;
			bool flag = type == type2;
			Type type3;
			Type type4;
			bool flag2 = type3 == type4;
			Type type5;
			Type type6;
			bool flag3 = type5 == type6;
			Type type7;
			Type type8;
			bool flag4 = type7 == type8;
			Type type9;
			Type type10;
			bool flag5 = type9 == type10;
			Type type11;
			Type type12;
			bool flag6 = type11 == type12;
			Type type13;
			Type type14;
			bool flag7 = type13 == type14;
			Type type15;
			Type type16;
			bool flag8 = type15 == type16;
			Type type17;
			Type type18;
			bool flag9 = type17 == type18;
			Type type19;
			Type type20;
			bool flag10 = type19 == type20;
			throw new InvalidCastException();
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00054C2C File Offset: 0x00052E2C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector()
		{
		}

		// Token: 0x0400155D RID: 5469
		private Register register;

		// Token: 0x0400155E RID: 5470
		private static readonly int s_count;

		// Token: 0x0400155F RID: 5471
		private static readonly Vector<T> s_zero;

		// Token: 0x04001560 RID: 5472
		private static readonly Vector<T> s_one;

		// Token: 0x04001561 RID: 5473
		private static readonly Vector<T> s_allOnes;

		// Token: 0x0200052C RID: 1324
		private struct VectorSizeHelper
		{
			// Token: 0x04001562 RID: 5474
			internal Vector<T> _placeholder;

			// Token: 0x04001563 RID: 5475
			internal byte _byte;
		}
	}
}
