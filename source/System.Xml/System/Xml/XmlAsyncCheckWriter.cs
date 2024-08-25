using System;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x02000030 RID: 48
	internal class XmlAsyncCheckWriter : XmlWriter
	{
		// Token: 0x0600010D RID: 269 RVA: 0x0000446C File Offset: 0x0000266C
		public XmlAsyncCheckWriter(XmlWriter writer)
		{
			if (!true)
			{
			}
			this.lastTask = 1;
			base..ctor();
			this.coreWriter = writer;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004490 File Offset: 0x00002690
		private void CheckAsync()
		{
			bool isCompleted = this.lastTask.IsCompleted;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000044B4 File Offset: 0x000026B4
		public override void WriteStartDocument()
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000044D0 File Offset: 0x000026D0
		public override void WriteStartDocument(bool standalone)
		{
			/*
An exception occurred when decompiling this method (06000110)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlAsyncCheckWriter::WriteStartDocument(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(XmlAsyncCheckWriter::CheckAsync, ldloc:XmlAsyncCheckWriter(this))
	stloc:XmlWriter(var_0_0C, ldfld:XmlWriter(XmlAsyncCheckWriter::coreWriter, ldloc:XmlAsyncCheckWriter(this)))
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

		// Token: 0x06000111 RID: 273 RVA: 0x000044EC File Offset: 0x000026EC
		public override void WriteEndDocument()
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004508 File Offset: 0x00002708
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004524 File Offset: 0x00002724
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004540 File Offset: 0x00002740
		public override void WriteEndElement()
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000455C File Offset: 0x0000275C
		public override void WriteFullEndElement()
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004578 File Offset: 0x00002778
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004594 File Offset: 0x00002794
		public override void WriteEndAttribute()
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000045B0 File Offset: 0x000027B0
		public override void WriteCData(string text)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000045CC File Offset: 0x000027CC
		public override void WriteComment(string text)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000045E8 File Offset: 0x000027E8
		public override void WriteProcessingInstruction(string name, string text)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004604 File Offset: 0x00002804
		public override void WriteEntityRef(string name)
		{
			this.CheckAsync();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004618 File Offset: 0x00002818
		public override void WriteCharEntity(char ch)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004634 File Offset: 0x00002834
		public override void WriteWhitespace(string ws)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004650 File Offset: 0x00002850
		public override void WriteString(string text)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000466C File Offset: 0x0000286C
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004688 File Offset: 0x00002888
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000046A4 File Offset: 0x000028A4
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000046C0 File Offset: 0x000028C0
		public override void WriteRaw(string data)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000046DC File Offset: 0x000028DC
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000046F8 File Offset: 0x000028F8
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00004714 File Offset: 0x00002914
		public override WriteState WriteState
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000125)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.WriteState System.Xml.XmlAsyncCheckWriter::get_WriteState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(XmlAsyncCheckWriter::CheckAsync, ldloc:XmlAsyncCheckWriter(this))
	stloc:XmlWriter(var_0_0C, ldfld:XmlWriter(XmlAsyncCheckWriter::coreWriter, ldloc:XmlAsyncCheckWriter(this)))
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

		// Token: 0x06000126 RID: 294 RVA: 0x00004730 File Offset: 0x00002930
		public override void Close()
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000474C File Offset: 0x0000294C
		public override void Flush()
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004768 File Offset: 0x00002968
		public override string LookupPrefix(string ns)
		{
			/*
An exception occurred when decompiling this method (06000128)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlAsyncCheckWriter::LookupPrefix(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(XmlAsyncCheckWriter::CheckAsync, ldloc:XmlAsyncCheckWriter(this))
	stloc:XmlWriter(var_0_0C, ldfld:XmlWriter(XmlAsyncCheckWriter::coreWriter, ldloc:XmlAsyncCheckWriter(this)))
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

		// Token: 0x06000129 RID: 297 RVA: 0x00004784 File Offset: 0x00002984
		public override void WriteValue(string value)
		{
			this.CheckAsync();
			XmlWriter xmlWriter = this.coreWriter;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000047A0 File Offset: 0x000029A0
		protected override void Dispose(bool disposing)
		{
			this.CheckAsync();
			this.coreWriter.Dispose();
		}

		// Token: 0x0400007F RID: 127
		private readonly XmlWriter coreWriter;

		// Token: 0x04000080 RID: 128
		private Task lastTask;
	}
}
