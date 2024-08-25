using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public readonly struct Single : IComparable, IConvertible, IFormattable, IComparable<float>, IEquatable<float>, ISpanFormattable
	{
		// Token: 0x06000933 RID: 2355 RVA: 0x00016278 File Offset: 0x00014478
		[NonVersionable]
		public static bool IsInfinity(float f)
		{
			/*
An exception occurred when decompiling this method (06000933)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Single::IsInfinity(System.Single)

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

		// Token: 0x06000934 RID: 2356 RVA: 0x00016288 File Offset: 0x00014488
		[NonVersionable]
		public static bool IsNaN(float f)
		{
			/*
An exception occurred when decompiling this method (06000934)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Single::IsNaN(System.Single)

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

		// Token: 0x06000935 RID: 2357 RVA: 0x0000207A File Offset: 0x0000027A
		[NonVersionable]
		public static bool IsNegativeInfinity(float f)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0000207A File Offset: 0x0000027A
		[NonVersionable]
		public static bool IsPositiveInfinity(float f)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00016298 File Offset: 0x00014498
		public int CompareTo(object value)
		{
			if (value != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
			return 1;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000162B4 File Offset: 0x000144B4
		public int CompareTo(float value)
		{
			return 1;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000162CC File Offset: 0x000144CC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000162E8 File Offset: 0x000144E8
		public bool Equals(float obj)
		{
			return true;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00016300 File Offset: 0x00014500
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600093B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Single::GetHashCode()

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

		// Token: 0x0600093C RID: 2364 RVA: 0x00016310 File Offset: 0x00014510
		public override string ToString()
		{
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			string text;
			return text;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00016328 File Offset: 0x00014528
		public string ToString(IFormatProvider provider)
		{
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			string text;
			return text;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00016340 File Offset: 0x00014540
		public string ToString(string format)
		{
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			string text;
			return text;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00016358 File Offset: 0x00014558
		public string ToString(string format, IFormatProvider provider)
		{
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			string text;
			return text;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00016370 File Offset: 0x00014570
		public bool TryFormat(Span<char> destination, [Out] int charsWritten, [Optional] ReadOnlySpan<char> format, [Optional] IFormatProvider provider)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00016380 File Offset: 0x00014580
		public static float Parse(string s, IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000941)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.Single::Parse(System.String,System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentNullException, ldc.i4:ExceptionArgument(48))
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

		// Token: 0x06000942 RID: 2370 RVA: 0x00016394 File Offset: 0x00014594
		public static float Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000942)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.Single::Parse(System.String,System.Globalization.NumberStyles,System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentNullException, ldc.i4:ExceptionArgument(48))
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

		// Token: 0x06000943 RID: 2371 RVA: 0x000163A8 File Offset: 0x000145A8
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, [Out] float result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000163B8 File Offset: 0x000145B8
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, [Out] float result)
		{
			for (;;)
			{
				if (!true)
				{
				}
				if (style != NumberStyles.None)
				{
					while (style != NumberStyles.None)
					{
					}
				}
				if (s != null)
				{
					break;
				}
				string negativeInfinitySymbol = info.negativeInfinitySymbol;
				if (negativeInfinitySymbol != null)
				{
					char rawStringData = negativeInfinitySymbol.GetRawStringData();
					if (negativeInfinitySymbol._stringLength != 0)
					{
						continue;
					}
				}
				if (s != null)
				{
					goto Block_2;
				}
				string nanSymbol = info.nanSymbol;
				if (nanSymbol == null)
				{
					goto IL_0068;
				}
				char rawStringData2 = nanSymbol.GetRawStringData();
				if (nanSymbol._stringLength == 0)
				{
					goto IL_0068;
				}
			}
			bool flag;
			return flag;
			Block_2:
			int length = s._length;
			int length2 = s._length;
			bool flag2;
			return flag2;
			IL_0068:
			if (s != null)
			{
				int length3 = s._length;
				int length4 = s._length;
				int length5 = s._length;
			}
			return true;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0001644C File Offset: 0x0001464C
		public TypeCode GetTypeCode()
		{
			return TypeCode.Single;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0001645C File Offset: 0x0001465C
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00016470 File Offset: 0x00014670
		char IConvertible.ToChar(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000947)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Single::System.IConvertible.ToChar(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_14, call:string(SR::Format, ldstr:string("Invalid cast from '{0}' to '{1}'."), ldstr:string[exp:object]("Single"), ldstr:string[exp:object]("Char")))
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

		// Token: 0x06000948 RID: 2376 RVA: 0x00016494 File Offset: 0x00014694
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			sbyte b;
			return b;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000164A8 File Offset: 0x000146A8
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			byte b;
			return b;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000164BC File Offset: 0x000146BC
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			short num;
			return num;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000164D0 File Offset: 0x000146D0
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ushort num;
			return num;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000164E4 File Offset: 0x000146E4
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000164F8 File Offset: 0x000146F8
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			uint num;
			return num;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0001650C File Offset: 0x0001470C
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			long num;
			return num;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00016520 File Offset: 0x00014720
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			ulong num;
			return num;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00016534 File Offset: 0x00014734
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return ref this;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00016544 File Offset: 0x00014744
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00016558 File Offset: 0x00014758
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0001656C File Offset: 0x0001476C
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (06000953)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Single::System.IConvertible.ToDateTime(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_14, call:string(SR::Format, ldstr:string("DateTime"), ldstr:string[exp:object]("Single"), ldstr:string[exp:object]("DateTime")))
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

		// Token: 0x06000954 RID: 2388 RVA: 0x00016590 File Offset: 0x00014790
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			object obj;
			return obj;
		}

		// Token: 0x04000398 RID: 920
		private readonly float m_value;

		// Token: 0x04000399 RID: 921
		public const float MinValue = -3.4028235E+38f;

		// Token: 0x0400039A RID: 922
		public const float Epsilon = 1E-45f;

		// Token: 0x0400039B RID: 923
		public const float MaxValue = 3.4028235E+38f;

		// Token: 0x0400039C RID: 924
		public const float PositiveInfinity = float.PositiveInfinity;

		// Token: 0x0400039D RID: 925
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x0400039E RID: 926
		public const float NaN = float.NaN;

		// Token: 0x0400039F RID: 927
		internal const float NegativeZero = -0f;
	}
}
