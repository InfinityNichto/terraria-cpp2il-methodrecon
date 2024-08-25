using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Xml
{
	// Token: 0x02000014 RID: 20
	internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000030E8 File Offset: 0x000012E8
		public HtmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
			: base(stream, settings)
		{
			this.Init(settings);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003104 File Offset: 0x00001304
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003114 File Offset: 0x00001314
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003124 File Offset: 0x00001324
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			base.RawText("<!DOCTYPE ");
			if (pubid != null)
			{
				base.RawText(" PUBLIC \"");
				base.RawText(pubid);
				if (sysid != null)
				{
					return;
				}
			}
			else
			{
				if (sysid == null)
				{
					return;
				}
				base.RawText(" SYSTEM \"");
				base.RawText(sysid);
			}
			byte[] bufBytes = this.bufBytes;
			if (subset != null)
			{
				byte[] bufBytes2 = this.bufBytes;
				base.RawText(subset);
				byte[] bufBytes3 = this.bufBytes;
			}
			byte[] bufBytes4 = this.bufBytes;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000031A4 File Offset: 0x000013A4
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			ByteStack byteStack = this.elementScope;
			ElementProperties elementProperties = this.currentElementProperties;
			if (ns._stringLength != 0)
			{
				int num = 128;
				this.currentElementProperties = (ElementProperties)num;
				base.WriteStartElement(prefix, localName, ns);
				return;
			}
			byte[] bufBytes = this.bufBytes;
			base.RawText(localName);
			int bufPos = this.bufPos;
			this.attrEndPos = bufPos;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003200 File Offset: 0x00001400
		internal override void StartElementContent()
		{
			byte[] bufBytes = this.bufBytes;
			int bufPos = this.bufPos;
			ElementProperties elementProperties = this.currentElementProperties;
			this.contentPos = bufPos;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003230 File Offset: 0x00001430
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			if (ns._stringLength != 0)
			{
				base.WriteEndElement(prefix, localName, ns);
				return;
			}
			ElementProperties elementProperties = this.currentElementProperties;
			byte[] bufBytes = this.bufBytes;
			base.RawText(localName);
			byte[] bufBytes2 = this.bufBytes;
			ByteStack byteStack = this.elementScope;
			byte[] stack = byteStack.stack;
			byteStack.top = bufBytes2;
			int size = byteStack.size;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000032A8 File Offset: 0x000014A8
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			if (ns._stringLength != 0)
			{
				base.WriteFullEndElement(prefix, localName, ns);
				return;
			}
			ElementProperties elementProperties = this.currentElementProperties;
			byte[] bufBytes = this.bufBytes;
			byte[] bufBytes2 = this.bufBytes;
			base.RawText(localName);
			byte[] bufBytes3 = this.bufBytes;
			ByteStack byteStack = this.elementScope;
			byte[] stack = byteStack.stack;
			byteStack.top = bufBytes3;
			int size = byteStack.size;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003328 File Offset: 0x00001528
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (ns._stringLength != 0)
			{
				base.WriteStartAttribute(prefix, localName, ns);
				return;
			}
			int bufPos = this.bufPos;
			byte[] bufBytes = this.bufBytes;
			int num = 32;
			base.RawText(localName);
			ElementProperties elementProperties = this.currentElementProperties;
			ElementProperties elementProperties2 = this.currentElementProperties;
			this.currentAttributeProperties = (AttributeProperties)num;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000339C File Offset: 0x0000159C
		public override void WriteEndAttribute()
		{
			AttributeProperties attributeProperties = this.currentAttributeProperties;
			if (this.endsWithAmpersand)
			{
				this.OutputRestAmps();
			}
			byte[] bufBytes = this.bufBytes;
			int bufPos = this.bufPos;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000033E8 File Offset: 0x000015E8
		public override void WriteProcessingInstruction(string target, string text)
		{
			byte[] bufBytes = this.bufBytes;
			byte[] bufBytes2 = this.bufBytes;
			base.RawText(target);
			byte[] bufBytes3 = this.bufBytes;
			int num = 63;
			base.WriteCommentOrPi(text, num);
			byte[] bufBytes4 = this.bufBytes;
			int bufPos = this.bufPos;
			int bufLen = this.bufLen;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003448 File Offset: 0x00001648
		public override void WriteString(string text)
		{
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000346C File Offset: 0x0000166C
		public override void WriteEntityRef(string name)
		{
			/*
An exception occurred when decompiling this method (0600005A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.HtmlUtf8RawTextWriter::WriteEntityRef(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Res::GetString, ldstr:string("Operation is not valid due to the current state of the object.")))
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

		// Token: 0x0600005B RID: 91 RVA: 0x00003484 File Offset: 0x00001684
		public override void WriteCharEntity(char ch)
		{
			/*
An exception occurred when decompiling this method (0600005B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.HtmlUtf8RawTextWriter::WriteCharEntity(System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Res::GetString, ldstr:string("Operation is not valid due to the current state of the object.")))
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

		// Token: 0x0600005C RID: 92 RVA: 0x0000349C File Offset: 0x0000169C
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			/*
An exception occurred when decompiling this method (0600005C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.HtmlUtf8RawTextWriter::WriteSurrogateCharEntity(System.Char,System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Res::GetString, ldstr:string("Operation is not valid due to the current state of the object.")))
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

		// Token: 0x0600005D RID: 93 RVA: 0x000034B4 File Offset: 0x000016B4
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000034CC File Offset: 0x000016CC
		private void Init(XmlWriterSettings settings)
		{
			string text = settings.mediaType;
			this.mediaType = text;
			bool flag = settings.doNotEscapeUriAttributes;
			this.doNotEscapeUriAttributes = flag;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000034F8 File Offset: 0x000016F8
		protected void WriteMetaElement()
		{
			base.RawText("<META http-equiv=\"Content-Type\"");
			if (this.mediaType == null)
			{
				this.mediaType = "text/html";
			}
			base.RawText(" content=\"");
			string text = this.mediaType;
			base.RawText(text);
			base.RawText("; charset=");
			Encoding encoding = this.encoding;
			base.RawText("\">");
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000355C File Offset: 0x0000175C
		protected unsafe void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			ElementProperties elementProperties = this.currentElementProperties;
			base.WriteElementTextBlock(pSrc, pSrcEnd);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003584 File Offset: 0x00001784
		protected unsafe void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			AttributeProperties attributeProperties = this.currentAttributeProperties;
			if (this.doNotEscapeUriAttributes)
			{
				this.WriteHtmlAttributeText(pSrc, pSrcEnd);
				return;
			}
			this.WriteUriAttributeText(pSrc, pSrcEnd);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000035CC File Offset: 0x000017CC
		private unsafe void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd)
		{
			if (this.endsWithAmpersand)
			{
				this.OutputRestAmps();
			}
			if (this.bufBytes != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
			XmlCharType xmlCharType2 = this.xmlCharType;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000363C File Offset: 0x0000183C
		private unsafe void WriteUriAttributeText(char* pSrc, char* pSrcEnd)
		{
			if (this.endsWithAmpersand)
			{
				this.OutputRestAmps();
			}
			if (this.bufBytes != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
			XmlCharType xmlCharType2 = this.xmlCharType;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000036B0 File Offset: 0x000018B0
		private void OutputRestAmps()
		{
			byte[] bufBytes = this.bufBytes;
			byte[] bufBytes2 = this.bufBytes;
			byte[] bufBytes3 = this.bufBytes;
			byte[] bufBytes4 = this.bufBytes;
		}

		// Token: 0x0400003D RID: 61
		protected ByteStack elementScope;

		// Token: 0x0400003E RID: 62
		protected ElementProperties currentElementProperties;

		// Token: 0x0400003F RID: 63
		private AttributeProperties currentAttributeProperties;

		// Token: 0x04000040 RID: 64
		private bool endsWithAmpersand;

		// Token: 0x04000041 RID: 65
		private byte[] uriEscapingBuffer;

		// Token: 0x04000042 RID: 66
		private string mediaType;

		// Token: 0x04000043 RID: 67
		private bool doNotEscapeUriAttributes;

		// Token: 0x04000044 RID: 68
		protected static TernaryTreeReadOnly elementPropertySearch;

		// Token: 0x04000045 RID: 69
		protected static TernaryTreeReadOnly attributePropertySearch;
	}
}
