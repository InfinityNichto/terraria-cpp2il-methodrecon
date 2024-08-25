using System;
using System.IO;
using System.Text;

namespace System
{
	// Token: 0x0200016B RID: 363
	public static class Console
	{
		// Token: 0x06000E94 RID: 3732 RVA: 0x0001F7EC File Offset: 0x0001D9EC
		static Console()
		{
			Encoding encoding = Encoding.GetEncoding(Console.WindowsConsole.GetInputCodePage());
			Encoding encoding2 = Encoding.GetEncoding(Console.WindowsConsole.GetOutputCodePage());
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0001F848 File Offset: 0x0001DA48
		private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
		{
			bool isConsole = ConsoleDriver.IsConsole;
			Stream stream = Console.OpenStandardInput(0);
			Stream stream2 = Console.OpenStandardOutput(0);
			Stream stream3 = Console.OpenStandardError(0);
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0001F88C File Offset: 0x0001DA8C
		public static TextWriter Error
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E96)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.TextWriter System.Console::get_Error()

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
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0001F89C File Offset: 0x0001DA9C
		public static TextWriter Out
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0001F8B0 File Offset: 0x0001DAB0
		private static Stream Open(IntPtr handle, FileAccess access, int bufferSize)
		{
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
		public static Stream OpenStandardError(int bufferSize)
		{
			if (!true)
			{
			}
			IntPtr consoleError = MonoIO.ConsoleError;
			Stream stream;
			return stream;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0001F8DC File Offset: 0x0001DADC
		public static Stream OpenStandardInput(int bufferSize)
		{
			if (!true)
			{
			}
			IntPtr consoleInput = MonoIO.ConsoleInput;
			Stream stream;
			return stream;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
		public static Stream OpenStandardOutput(int bufferSize)
		{
			if (!true)
			{
			}
			IntPtr consoleOutput = MonoIO.ConsoleOutput;
			Stream stream;
			return stream;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0001F914 File Offset: 0x0001DB14
		public static void SetOut(TextWriter newOut)
		{
			while (newOut == null)
			{
			}
			TextWriter textWriter = TextWriter.Synchronized(newOut);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0001F92C File Offset: 0x0001DB2C
		public static void Write(string value)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0001F93C File Offset: 0x0001DB3C
		public static void Write(string format, object arg0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0001F94C File Offset: 0x0001DB4C
		public static void WriteLine(object value)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0001F95C File Offset: 0x0001DB5C
		public static void WriteLine(string value)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0001F96C File Offset: 0x0001DB6C
		public static void WriteLine(string format, params object[] arg)
		{
			if (!true)
			{
			}
			if (arg != null)
			{
				return;
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0001F980 File Offset: 0x0001DB80
		public static void WriteLine(string format, object arg0, object arg1)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0001F990 File Offset: 0x0001DB90
		public static string ReadLine()
		{
			int num;
			do
			{
				num = 1;
				if (num == 0)
				{
				}
			}
			while (num == 0);
			bool isConsole = ConsoleDriver.IsConsole;
			return ConsoleDriver.ReadLine();
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0001F9B0 File Offset: 0x0001DBB0
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		public static Encoding InputEncoding
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000EA4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.Encoding System.Console::get_InputEncoding()

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
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0001F9D0 File Offset: 0x0001DBD0
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		public static Encoding OutputEncoding
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000EA6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.Encoding System.Console::get_OutputEncoding()

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
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
		public static void Clear()
		{
			if (!true)
			{
			}
			ConsoleDriver.Clear();
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0001FA08 File Offset: 0x0001DC08
		public static ConsoleKeyInfo ReadKey()
		{
			if (!true)
			{
			}
			return Console.ReadKey(false);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0001FA20 File Offset: 0x0001DC20
		public static ConsoleKeyInfo ReadKey(bool intercept)
		{
			if (!true)
			{
			}
			return ConsoleDriver.ReadKey(true);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0001FA38 File Offset: 0x0001DC38
		private static void DoConsoleCancelEvent()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x0400064E RID: 1614
		internal static TextWriter stdout;

		// Token: 0x0400064F RID: 1615
		private static TextWriter stderr;

		// Token: 0x04000650 RID: 1616
		private static TextReader stdin;

		// Token: 0x04000651 RID: 1617
		private static Encoding inputEncoding;

		// Token: 0x04000652 RID: 1618
		private static Encoding outputEncoding;

		// Token: 0x04000653 RID: 1619
		private static ConsoleCancelEventHandler cancel_event;

		// Token: 0x0200016C RID: 364
		private class WindowsConsole
		{
			// Token: 0x06000EAC RID: 3756
			private static extern int GetConsoleCP();

			// Token: 0x06000EAD RID: 3757
			private static extern int GetConsoleOutputCP();

			// Token: 0x06000EAE RID: 3758 RVA: 0x0001FA60 File Offset: 0x0001DC60
			private static bool DoWindowsConsoleCancelEvent(int keyCode)
			{
				/*
An exception occurred when decompiling this method (06000EAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Console/WindowsConsole::DoWindowsConsoleCancelEvent(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(Console::DoConsoleCancelEvent)
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

			// Token: 0x06000EAF RID: 3759 RVA: 0x0001FA74 File Offset: 0x0001DC74
			public static int GetInputCodePage()
			{
				if (!true)
				{
				}
				return Console.WindowsConsole.GetConsoleCP();
			}

			// Token: 0x06000EB0 RID: 3760 RVA: 0x0001FA8C File Offset: 0x0001DC8C
			public static int GetOutputCodePage()
			{
				if (!true)
				{
				}
				return Console.WindowsConsole.GetConsoleOutputCP();
			}

			// Token: 0x06000EB1 RID: 3761 RVA: 0x0001FAA4 File Offset: 0x0001DCA4
			// Note: this type is marked as 'beforefieldinit'.
			static WindowsConsole()
			{
			}

			// Token: 0x04000654 RID: 1620
			public static bool ctrlHandlerAdded;

			// Token: 0x04000655 RID: 1621
			private static Console.WindowsConsole.WindowsCancelHandler cancelHandler;

			// Token: 0x0200016D RID: 365
			// (Invoke) Token: 0x06000EB3 RID: 3763
			private delegate bool WindowsCancelHandler(int keyCode);
		}
	}
}
