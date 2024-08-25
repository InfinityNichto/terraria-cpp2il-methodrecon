using System;
using System.Globalization;
using System.Text;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x02000545 RID: 1349
	[Serializable]
	public abstract class TextWriter : MarshalByRefObject, IDisposable
	{
		// Token: 0x060027E3 RID: 10211 RVA: 0x00056B28 File Offset: 0x00054D28
		protected TextWriter()
		{
			if (!true)
			{
			}
			this.CoreNewLine = 1;
			string newLine = Environment.NewLine;
			this.CoreNewLineStr = newLine;
			base..ctor();
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00056B54 File Offset: 0x00054D54
		protected TextWriter(IFormatProvider formatProvider)
		{
			if (!true)
			{
			}
			this.CoreNewLine = 1;
			string newLine = Environment.NewLine;
			this.CoreNewLineStr = newLine;
			base..ctor();
			this._internalFormatProvider = formatProvider;
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x00056B88 File Offset: 0x00054D88
		public virtual IFormatProvider FormatProvider
		{
			get
			{
				/*
An exception occurred when decompiling this method (060027E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IFormatProvider System.IO.TextWriter::get_FormatProvider()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:CultureInfo(var_2_13, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
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

		// Token: 0x060027E6 RID: 10214 RVA: 0x00056BA8 File Offset: 0x00054DA8
		public virtual void Close()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00056BBC File Offset: 0x00054DBC
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00056BCC File Offset: 0x00054DCC
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00056BE0 File Offset: 0x00054DE0
		public virtual void Flush()
		{
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060027EA RID: 10218
		public abstract Encoding Encoding { get; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x00056BF0 File Offset: 0x00054DF0
		public virtual string NewLine
		{
			get
			{
				return this.CoreNewLineStr;
			}
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00056C04 File Offset: 0x00054E04
		public virtual void Write(char value)
		{
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00056C14 File Offset: 0x00054E14
		public virtual void Write(char[] buffer)
		{
			if (buffer != null)
			{
			}
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00056C24 File Offset: 0x00054E24
		public virtual void Write(char[] buffer, int index, int count)
		{
			if (buffer != null)
			{
				return;
			}
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x00056C38 File Offset: 0x00054E38
		public virtual void Write(string value)
		{
			if (value != null)
			{
				char[] array = value.ToCharArray();
				return;
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00056C50 File Offset: 0x00054E50
		public virtual void Write(string format, object arg0)
		{
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00056C60 File Offset: 0x00054E60
		public virtual void Write(string format, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00056C70 File Offset: 0x00054E70
		public virtual void WriteLine()
		{
			char[] coreNewLine = this.CoreNewLine;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00056C84 File Offset: 0x00054E84
		public virtual void WriteLine(string value)
		{
			if (value != null)
			{
			}
			string coreNewLineStr = this.CoreNewLineStr;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00056C9C File Offset: 0x00054E9C
		public virtual void WriteLine(object value)
		{
			if (value == null)
			{
				return;
			}
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00056CB4 File Offset: 0x00054EB4
		public virtual void WriteLine(string format, object arg0)
		{
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00056CC4 File Offset: 0x00054EC4
		public virtual void WriteLine(string format, object arg0, object arg1)
		{
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00056CD4 File Offset: 0x00054ED4
		public virtual void WriteLine(string format, params object[] arg)
		{
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0000207A File Offset: 0x0000027A
		public static TextWriter Synchronized(TextWriter writer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00056CE4 File Offset: 0x00054EE4
		// Note: this type is marked as 'beforefieldinit'.
		static TextWriter()
		{
			char[] array = Environment.NewLine.ToCharArray();
		}

		// Token: 0x040015B2 RID: 5554
		public static readonly TextWriter Null;

		// Token: 0x040015B3 RID: 5555
		private static readonly char[] s_coreNewLine;

		// Token: 0x040015B4 RID: 5556
		protected char[] CoreNewLine;

		// Token: 0x040015B5 RID: 5557
		private string CoreNewLineStr;

		// Token: 0x040015B6 RID: 5558
		private IFormatProvider _internalFormatProvider;

		// Token: 0x02000546 RID: 1350
		[Serializable]
		private sealed class NullTextWriter : TextWriter
		{
			// Token: 0x060027FA RID: 10234 RVA: 0x00056CFC File Offset: 0x00054EFC
			internal NullTextWriter()
			{
				if (!true)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				base..ctor(invariantCulture);
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x060027FB RID: 10235 RVA: 0x00056D1C File Offset: 0x00054F1C
			public override Encoding Encoding
			{
				get
				{
					return Encoding.Unicode;
				}
			}

			// Token: 0x060027FC RID: 10236 RVA: 0x00056D30 File Offset: 0x00054F30
			public override void Write(char[] buffer, int index, int count)
			{
			}

			// Token: 0x060027FD RID: 10237 RVA: 0x00056D40 File Offset: 0x00054F40
			public override void Write(string value)
			{
			}

			// Token: 0x060027FE RID: 10238 RVA: 0x00056D50 File Offset: 0x00054F50
			public override void WriteLine()
			{
			}

			// Token: 0x060027FF RID: 10239 RVA: 0x00056D60 File Offset: 0x00054F60
			public override void WriteLine(string value)
			{
			}

			// Token: 0x06002800 RID: 10240 RVA: 0x00056D70 File Offset: 0x00054F70
			public override void WriteLine(object value)
			{
			}

			// Token: 0x06002801 RID: 10241 RVA: 0x00056D80 File Offset: 0x00054F80
			public override void Write(char value)
			{
			}
		}

		// Token: 0x02000547 RID: 1351
		[Serializable]
		internal sealed class SyncTextWriter : TextWriter, IDisposable
		{
			// Token: 0x06002802 RID: 10242 RVA: 0x00056D90 File Offset: 0x00054F90
			internal SyncTextWriter(TextWriter t)
			{
				if (!true)
				{
				}
				this._out = t;
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x06002803 RID: 10243 RVA: 0x00056DA8 File Offset: 0x00054FA8
			public override Encoding Encoding
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002803)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.Encoding System.IO.TextWriter/SyncTextWriter::get_Encoding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TextWriter(var_0_06, ldfld:TextWriter(SyncTextWriter::_out, ldloc:SyncTextWriter(this)))
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

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x06002804 RID: 10244 RVA: 0x00056DBC File Offset: 0x00054FBC
			public override IFormatProvider FormatProvider
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002804)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IFormatProvider System.IO.TextWriter/SyncTextWriter::get_FormatProvider()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TextWriter(var_0_06, ldfld:TextWriter(SyncTextWriter::_out, ldloc:SyncTextWriter(this)))
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

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x06002805 RID: 10245 RVA: 0x00056DD0 File Offset: 0x00054FD0
			public override string NewLine
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002805)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.IO.TextWriter/SyncTextWriter::get_NewLine()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TextWriter(var_0_06, ldfld:TextWriter(SyncTextWriter::_out, ldloc:SyncTextWriter(this)))
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

			// Token: 0x06002806 RID: 10246 RVA: 0x00056DE4 File Offset: 0x00054FE4
			public override void Close()
			{
				TextWriter @out = this._out;
			}

			// Token: 0x06002807 RID: 10247 RVA: 0x00056DF8 File Offset: 0x00054FF8
			protected override void Dispose(bool disposing)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x06002808 RID: 10248 RVA: 0x00056E10 File Offset: 0x00055010
			public override void Flush()
			{
				TextWriter @out = this._out;
			}

			// Token: 0x06002809 RID: 10249 RVA: 0x00056E24 File Offset: 0x00055024
			public override void Write(char value)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x0600280A RID: 10250 RVA: 0x00056E38 File Offset: 0x00055038
			public override void Write(char[] buffer)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x0600280B RID: 10251 RVA: 0x00056E4C File Offset: 0x0005504C
			public override void Write(char[] buffer, int index, int count)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x0600280C RID: 10252 RVA: 0x00056E60 File Offset: 0x00055060
			public override void Write(string value)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x0600280D RID: 10253 RVA: 0x00056E74 File Offset: 0x00055074
			public override void Write(string format, object arg0)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x0600280E RID: 10254 RVA: 0x00056E88 File Offset: 0x00055088
			public override void Write(string format, object arg0, object arg1, object arg2)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x0600280F RID: 10255 RVA: 0x00056E9C File Offset: 0x0005509C
			public override void WriteLine()
			{
				TextWriter @out = this._out;
			}

			// Token: 0x06002810 RID: 10256 RVA: 0x00056EB0 File Offset: 0x000550B0
			public override void WriteLine(string value)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x06002811 RID: 10257 RVA: 0x00056EC4 File Offset: 0x000550C4
			public override void WriteLine(object value)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x06002812 RID: 10258 RVA: 0x00056ED8 File Offset: 0x000550D8
			public override void WriteLine(string format, object arg0)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x06002813 RID: 10259 RVA: 0x00056EEC File Offset: 0x000550EC
			public override void WriteLine(string format, object arg0, object arg1)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x06002814 RID: 10260 RVA: 0x00056F00 File Offset: 0x00055100
			public override void WriteLine(string format, params object[] arg)
			{
				TextWriter @out = this._out;
			}

			// Token: 0x040015B7 RID: 5559
			private readonly TextWriter _out;
		}
	}
}
