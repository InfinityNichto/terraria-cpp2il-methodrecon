using System;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x02000581 RID: 1409
	public static class CharUnicodeInfo
	{
		// Token: 0x06002A50 RID: 10832 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int InternalConvertToUtf32(string s, int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x0005BF24 File Offset: 0x0005A124
		internal static double InternalGetNumericValue(int ch)
		{
			/*
An exception occurred when decompiling this method (06002A51)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.Globalization.CharUnicodeInfo::InternalGetNumericValue(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_0_05, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_NumericLevel1Index))
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_1_0B, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_NumericLevel1Index))
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_2_11, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_NumericLevel2Index))
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_3_17, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_NumericLevel3Index))
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_4_1D, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_NumericValues))
	stloc:uint8(var_6_26, ldfld:uint8(uint8::m_value, ldloc:uint8[exp:uint8&](var_5)))
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

		// Token: 0x06002A52 RID: 10834 RVA: 0x0000207A File Offset: 0x0000027A
		public static double GetNumericValue(char ch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0000207A File Offset: 0x0000027A
		public static UnicodeCategory GetUnicodeCategory(char ch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x0005BF58 File Offset: 0x0005A158
		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			/*
An exception occurred when decompiling this method (06002A54)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.UnicodeCategory System.Globalization.CharUnicodeInfo::GetUnicodeCategory(System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_01, ldc.i4:int64(0))
	stloc:uint8(var_2_09, call:uint8(CharUnicodeInfo::InternalGetCategoryValue, ldloc:int32(var_0), ldloc:int64[exp:int32](var_1_01)))
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

		// Token: 0x06002A55 RID: 10837 RVA: 0x0000207A File Offset: 0x0000027A
		public static UnicodeCategory GetUnicodeCategory(int codePoint)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x0005BF70 File Offset: 0x0005A170
		internal static byte InternalGetCategoryValue(int ch, int offset)
		{
			/*
An exception occurred when decompiling this method (06002A56)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte System.Globalization.CharUnicodeInfo::InternalGetCategoryValue(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_0_05, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_CategoryLevel1Index))
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_1_0B, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_CategoryLevel2Index))
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_3_11, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_CategoryLevel3Index))
	stloc:valuetype System.ReadOnlySpan`1<uint8>(var_4_17, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<uint8>](CharUnicodeInfo::get_CategoriesValue))
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

		// Token: 0x06002A57 RID: 10839 RVA: 0x0005BF98 File Offset: 0x0005A198
		internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
		{
			/*
An exception occurred when decompiling this method (06002A57)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.UnicodeCategory System.Globalization.CharUnicodeInfo::InternalGetUnicodeCategory(System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_01, ldc.i4:int64(0))
	stloc:uint8(var_2_09, call:uint8(CharUnicodeInfo::InternalGetCategoryValue, ldloc:int32(var_0), ldloc:int64[exp:int32](var_1_01)))
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

		// Token: 0x06002A58 RID: 10840 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsWhiteSpace(string s, int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsWhiteSpace(char c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x0000207A File Offset: 0x0000027A
		private static ReadOnlySpan<byte> CategoryLevel1Index
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x0000207A File Offset: 0x0000027A
		private static ReadOnlySpan<byte> CategoryLevel2Index
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x0000207A File Offset: 0x0000027A
		private static ReadOnlySpan<byte> CategoryLevel3Index
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x0000207A File Offset: 0x0000027A
		private static ReadOnlySpan<byte> CategoriesValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x0000207A File Offset: 0x0000027A
		private static ReadOnlySpan<byte> NumericLevel1Index
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x0000207A File Offset: 0x0000027A
		private static ReadOnlySpan<byte> NumericLevel2Index
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x0000207A File Offset: 0x0000027A
		private static ReadOnlySpan<byte> NumericLevel3Index
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x0000207A File Offset: 0x0000027A
		private static ReadOnlySpan<byte> NumericValues
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
