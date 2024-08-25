using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200018E RID: 398
	internal static class ParameterizedStrings
	{
		// Token: 0x06000F9D RID: 3997 RVA: 0x00021678 File Offset: 0x0001F878
		public static string Evaluate(string format, params ParameterizedStrings.FormatParam[] args)
		{
			while (format == null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00021690 File Offset: 0x0001F890
		private static string EvaluateInternal(string format, int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ParameterizedStrings.FormatParam[] dynamicVars, ParameterizedStrings.FormatParam[] staticVars)
		{
			for (;;)
			{
				string text;
				int stringLength = text._stringLength;
				int num = 1;
				char c = text[num];
				int num2 = 1;
				int num3 = 1;
				string text2 = text.Remove(num2, num3);
				ParameterizedStrings.FormatParam formatParam;
				object @object = formatParam.Object;
				string text3 = ParameterizedStrings.FormatPrintF(text2, @object);
				ParameterizedStrings.FormatParam formatParam2;
				if (formatParam2 == null)
				{
				}
				ParameterizedStrings.FormatParam formatParam3;
				if (formatParam3 == null)
				{
				}
				ParameterizedStrings.FormatParam formatParam4;
				if (formatParam4 != null)
				{
				}
				ParameterizedStrings.FormatParam formatParam5;
				if (formatParam5 != null)
				{
					return;
				}
				if (formatParam4 == null)
				{
				}
				ParameterizedStrings.FormatParam formatParam6;
				if (formatParam6 != null)
				{
					return;
				}
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool AsBool(int i)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0000207A File Offset: 0x0000027A
		private static int AsInt(bool b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00021708 File Offset: 0x0001F908
		private static string StringFromAsciiBytes(byte[] buffer, int offset, int length)
		{
			while (offset == 0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000FA2 RID: 4002
		private unsafe static extern int snprintf(byte* str, IntPtr size, string format, string arg1);

		// Token: 0x06000FA3 RID: 4003
		private unsafe static extern int snprintf(byte* str, IntPtr size, string format, int arg1);

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0002171C File Offset: 0x0001F91C
		private static string FormatPrintF(string format, object arg)
		{
			int num;
			if (num != 0)
			{
				int num2;
				while (num2 != 0)
				{
				}
			}
			string text;
			return text;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00021744 File Offset: 0x0001F944
		private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ParameterizedStrings.FormatParam[] dynamicVars, ParameterizedStrings.FormatParam[] staticVars, [Out] int index)
		{
		}

		// Token: 0x040006C4 RID: 1732
		[ThreadStatic]
		private static ParameterizedStrings.LowLevelStack _cachedStack;

		// Token: 0x0200018F RID: 399
		public struct FormatParam
		{
			// Token: 0x06000FA6 RID: 4006 RVA: 0x00021758 File Offset: 0x0001F958
			public FormatParam(int value)
			{
				this._int32 = value;
			}

			// Token: 0x06000FA7 RID: 4007 RVA: 0x0002176C File Offset: 0x0001F96C
			private FormatParam(int intValue, string stringValue)
			{
				this._int32 = intValue;
				this._string = stringValue;
			}

			// Token: 0x06000FA8 RID: 4008 RVA: 0x0000207A File Offset: 0x0000027A
			public static implicit operator ParameterizedStrings.FormatParam(int value)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0000207A File Offset: 0x0000027A
			public int Int32
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00021788 File Offset: 0x0001F988
			public string String
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000FAA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.ParameterizedStrings/FormatParam::get_String()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](FormatParam::_string, ldloc:valuetype System.ParameterizedStrings/FormatParam&(this)))
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
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0002179C File Offset: 0x0001F99C
			public object Object
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000FAB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ParameterizedStrings/FormatParam::get_Object()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](FormatParam::_string, ldloc:valuetype System.ParameterizedStrings/FormatParam&(this)))
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
			}

			// Token: 0x040006C5 RID: 1733
			private readonly int _int32;

			// Token: 0x040006C6 RID: 1734
			private readonly string _string;
		}

		// Token: 0x02000190 RID: 400
		private sealed class LowLevelStack
		{
			// Token: 0x06000FAC RID: 4012 RVA: 0x000217B0 File Offset: 0x0001F9B0
			public LowLevelStack()
			{
			}

			// Token: 0x06000FAD RID: 4013 RVA: 0x000217C0 File Offset: 0x0001F9C0
			public ParameterizedStrings.FormatParam Pop()
			{
				/*
An exception occurred when decompiling this method (06000FAD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ParameterizedStrings/FormatParam System.ParameterizedStrings/LowLevelStack::Pop()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.ParameterizedStrings/FormatParam[](var_0_06, ldfld:valuetype System.ParameterizedStrings/FormatParam[](LowLevelStack::_arr, ldloc:LowLevelStack(this)))
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

			// Token: 0x06000FAE RID: 4014 RVA: 0x000217D4 File Offset: 0x0001F9D4
			public void Push(ParameterizedStrings.FormatParam item)
			{
				ParameterizedStrings.FormatParam[] arr = this._arr;
				int count = this._count;
				ParameterizedStrings.FormatParam[] arr2 = this._arr;
				int count2 = this._count;
			}

			// Token: 0x06000FAF RID: 4015 RVA: 0x00021800 File Offset: 0x0001FA00
			public void Clear()
			{
				ParameterizedStrings.FormatParam[] arr = this._arr;
				int count = this._count;
				long num = 0L;
				Array.Clear(arr, (int)num, count);
			}

			// Token: 0x040006C7 RID: 1735
			private ParameterizedStrings.FormatParam[] _arr;

			// Token: 0x040006C8 RID: 1736
			private int _count;
		}
	}
}
