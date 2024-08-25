using System;
using System.IO;
using System.Text;

namespace ReLogic.IO
{
	// Token: 0x02000B34 RID: 2868
	public class ConsoleOutputMirror : IDisposable
	{
		// Token: 0x060053A8 RID: 21416 RVA: 0x00284C10 File Offset: 0x00282E10
		public static void ToFile(string path)
		{
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x00284C20 File Offset: 0x00282E20
		private ConsoleOutputMirror(string path)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._oldConsoleOutput = 1;
			DirectoryInfo parent = Directory.GetParent(path);
			FileStream fileStream = File.Create(path);
			this._fileStream = fileStream;
			TextWriter oldConsoleOutput = this._oldConsoleOutput;
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x00284C5C File Offset: 0x00282E5C
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposedValue)
			{
				Console.SetOut(this._oldConsoleOutput);
				if (this._fileWriter != null)
				{
					StreamWriter fileWriter = this._fileWriter;
				}
				if (this._fileStream != null)
				{
				}
				this._disposedValue = true;
			}
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00284C9C File Offset: 0x00282E9C
		public void Dispose()
		{
		}

		// Token: 0x04008CE0 RID: 36064
		private static ConsoleOutputMirror _instance;

		// Token: 0x04008CE1 RID: 36065
		private FileStream _fileStream;

		// Token: 0x04008CE2 RID: 36066
		private StreamWriter _fileWriter;

		// Token: 0x04008CE3 RID: 36067
		private TextWriter _newConsoleOutput;

		// Token: 0x04008CE4 RID: 36068
		private readonly TextWriter _oldConsoleOutput;

		// Token: 0x04008CE5 RID: 36069
		private bool _disposedValue;

		// Token: 0x02000B35 RID: 2869
		private class DoubleWriter : TextWriter
		{
			// Token: 0x060053AC RID: 21420 RVA: 0x00284CAC File Offset: 0x00282EAC
			public DoubleWriter(TextWriter first, TextWriter second)
			{
				if (!true)
				{
				}
				base..ctor();
				this._first = first;
				this._second = second;
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x060053AD RID: 21421 RVA: 0x00284CD0 File Offset: 0x00282ED0
			public override Encoding Encoding
			{
				get
				{
					/*
An exception occurred when decompiling this method (060053AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.Encoding ReLogic.IO.ConsoleOutputMirror/DoubleWriter::get_Encoding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TextWriter(var_0_06, ldfld:TextWriter(DoubleWriter::_first, ldloc:DoubleWriter(this)))
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
			}

			// Token: 0x060053AE RID: 21422 RVA: 0x00284CE4 File Offset: 0x00282EE4
			public override void Flush()
			{
				TextWriter first = this._first;
				TextWriter second = this._second;
			}

			// Token: 0x060053AF RID: 21423 RVA: 0x00284D00 File Offset: 0x00282F00
			public override void Write(char value)
			{
				TextWriter first = this._first;
				TextWriter second = this._second;
			}

			// Token: 0x04008CE6 RID: 36070
			private readonly TextWriter _first;

			// Token: 0x04008CE7 RID: 36071
			private readonly TextWriter _second;
		}
	}
}
