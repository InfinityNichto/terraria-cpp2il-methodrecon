using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020001AB RID: 427
	internal class WindowsConsoleDriver : IConsoleDriver
	{
		// Token: 0x0600100B RID: 4107 RVA: 0x00022344 File Offset: 0x00020544
		public WindowsConsoleDriver()
		{
			IntPtr intPtr;
			this.outputHandle = intPtr;
			IntPtr intPtr2;
			this.inputHandle = intPtr2;
			IntPtr intPtr3 = this.outputHandle;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0002236C File Offset: 0x0002056C
		public void Clear()
		{
			IntPtr intPtr = this.outputHandle;
			IntPtr intPtr2 = this.outputHandle;
			IntPtr intPtr3 = this.outputHandle;
			IntPtr intPtr4 = this.outputHandle;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00022398 File Offset: 0x00020598
		public string ReadLine()
		{
			/*
An exception occurred when decompiling this method (0600100D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.WindowsConsoleDriver::ReadLine()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_01, ldc.i4:int64(0))
	stloc:ConsoleKeyInfo(var_1_09, call:ConsoleKeyInfo(WindowsConsoleDriver::ReadKey, ldloc:WindowsConsoleDriver(this), ldloc:int64[exp:bool](var_0_01)))
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

		// Token: 0x0600100E RID: 4110 RVA: 0x000223B0 File Offset: 0x000205B0
		public ConsoleKeyInfo ReadKey(bool intercept)
		{
			/*
An exception occurred when decompiling this method (0600100E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ConsoleKeyInfo System.WindowsConsoleDriver::ReadKey(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(WindowsConsoleDriver::inputHandle, ldloc:WindowsConsoleDriver(this)))
	stloc:native int(var_3_0F, ldfld:native int(WindowsConsoleDriver::inputHandle, ldloc:WindowsConsoleDriver(this)))
	stloc:string(var_5_1D, call:string(int32::ToString, call:int32[exp:int32&](Marshal::GetLastWin32Error)))
	stloc:string(var_6_2B, call:string(string::Concat, ldstr:string("Error in ReadConsoleInput "), ldloc:string(var_5_1D)))
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

		// Token: 0x0600100F RID: 4111 RVA: 0x000223EC File Offset: 0x000205EC
		private static bool IsModifierKey(short virtualKeyCode)
		{
		}

		// Token: 0x06001010 RID: 4112
		private static extern IntPtr GetStdHandle(Handles handle);

		// Token: 0x06001011 RID: 4113
		private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, [Out] ConsoleScreenBufferInfo info);

		// Token: 0x06001012 RID: 4114
		private static extern bool FillConsoleOutputCharacter(IntPtr handle, char c, int size, Coord coord, [Out] int written);

		// Token: 0x06001013 RID: 4115
		private static extern bool FillConsoleOutputAttribute(IntPtr handle, short c, int size, Coord coord, [Out] int written);

		// Token: 0x06001014 RID: 4116
		private static extern bool SetConsoleCursorPosition(IntPtr handle, Coord coord);

		// Token: 0x06001015 RID: 4117
		private static extern bool ReadConsoleInput(IntPtr handle, [Out] InputRecord record, int length, [Out] int nread);

		// Token: 0x040008C4 RID: 2244
		private IntPtr inputHandle;

		// Token: 0x040008C5 RID: 2245
		private IntPtr outputHandle;

		// Token: 0x040008C6 RID: 2246
		private short defaultAttribute;
	}
}
