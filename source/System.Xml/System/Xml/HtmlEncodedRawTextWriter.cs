using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Xml
{
	// Token: 0x02000011 RID: 17
	internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002628 File Offset: 0x00000828
		public HtmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
			: base(writer, settings)
		{
			this.Init(settings);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002644 File Offset: 0x00000844
		public HtmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
			: base(stream, settings)
		{
			this.Init(settings);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002660 File Offset: 0x00000860
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002670 File Offset: 0x00000870
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002680 File Offset: 0x00000880
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				base.ChangeTextContentMark(num != 0L);
			}
			base.RawText("<!DOCTYPE ");
			bool flag = name == "HTML";
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
					int bufPos = this.bufPos;
					char[] bufChars = this.bufChars;
					return;
				}
				base.RawText(" SYSTEM \"");
				base.RawText(sysid);
			}
			int bufPos2 = this.bufPos;
			char[] bufChars2 = this.bufChars;
			if (subset != null)
			{
				int num2 = 91;
				this.bufPos = bufPos2;
				base.RawText(subset);
				char[] bufChars3 = this.bufChars;
				this.bufPos = num2;
			}
			this.bufPos = bufPos2;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002744 File Offset: 0x00000944
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
			if (this.trackTextContent && this.inTextContent)
			{
				long num2 = 0L;
				base.ChangeTextContentMark(num2 != 0L);
			}
			char[] bufChars = this.bufChars;
			base.RawText(localName);
			int bufPos = this.bufPos;
			this.attrEndPos = bufPos;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000027B8 File Offset: 0x000009B8
		internal override void StartElementContent()
		{
			char[] bufChars = this.bufChars;
			ElementProperties elementProperties = this.currentElementProperties;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000027DC File Offset: 0x000009DC
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			if (ns._stringLength != 0)
			{
				base.WriteEndElement(prefix, localName, ns);
				return;
			}
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				base.ChangeTextContentMark(num != 0L);
			}
			ElementProperties elementProperties = this.currentElementProperties;
			char[] bufChars = this.bufChars;
			int num2 = 60;
			int num3 = 47;
			bufChars.m_value = (char)num2;
			bufChars.m_value = (char)num3;
			base.RawText(localName);
			char[] bufChars2 = this.bufChars;
			this.bufPos = num3;
			ByteStack byteStack = this.elementScope;
			byte[] stack = byteStack.stack;
			byteStack.top = bufChars2;
			int size = byteStack.size;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002884 File Offset: 0x00000A84
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			if (ns._stringLength != 0)
			{
				base.WriteFullEndElement(prefix, localName, ns);
				return;
			}
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				base.ChangeTextContentMark(num != 0L);
			}
			ElementProperties elementProperties = this.currentElementProperties;
			char[] bufChars = this.bufChars;
			int num2 = 60;
			int num3 = 47;
			bufChars.m_value = (char)num2;
			bufChars.m_value = (char)num3;
			char[] bufChars2 = this.bufChars;
			this.bufPos = num3;
			ByteStack byteStack = this.elementScope;
			byteStack.top = bufChars2;
			int size = byteStack.size;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002918 File Offset: 0x00000B18
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (ns._stringLength != 0)
			{
				base.WriteStartAttribute(prefix, localName, ns);
				return;
			}
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				base.ChangeTextContentMark(num != 0L);
			}
			int bufPos = this.bufPos;
			char[] bufChars = this.bufChars;
			int num2 = 32;
			base.RawText(localName);
			ElementProperties elementProperties = this.currentElementProperties;
			ElementProperties elementProperties2 = this.currentElementProperties;
			this.currentAttributeProperties = (AttributeProperties)num2;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000029A0 File Offset: 0x00000BA0
		public override void WriteEndAttribute()
		{
			AttributeProperties attributeProperties = this.currentAttributeProperties;
			if (this.endsWithAmpersand)
			{
				char[] bufChars = this.bufChars;
				int num = 97;
				int num2 = 109;
				bufChars.m_value = (char)num;
				int num3 = 112;
				bufChars.m_value = (char)num2;
				int num4 = 59;
				bufChars.m_value = (char)num3;
				bufChars.m_value = (char)num4;
			}
			bool inTextContent;
			if (this.trackTextContent)
			{
				inTextContent = this.inTextContent;
				if (inTextContent)
				{
					long num5 = 0L;
					base.ChangeTextContentMark(num5 != 0L);
				}
			}
			char[] bufChars2 = this.bufChars;
			this.bufPos = (inTextContent ? 1 : 0);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A38 File Offset: 0x00000C38
		public override void WriteProcessingInstruction(string target, string text)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				base.ChangeTextContentMark(num != 0L);
			}
			char[] bufChars = this.bufChars;
			int num2 = 60;
			int num3 = 63;
			bufChars.m_value = (char)num2;
			bufChars.m_value = (char)num3;
			base.RawText(target);
			char[] bufChars2 = this.bufChars;
			int num4 = 63;
			this.bufPos = num3;
			base.WriteCommentOrPi(text, num4);
			char[] bufChars3 = this.bufChars;
			this.bufPos = num3;
			int bufLen = this.bufLen;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002ABC File Offset: 0x00000CBC
		public override void WriteString(string text)
		{
			if (!this.trackTextContent || this.inTextContent)
			{
				if (text != null)
				{
					int offsetToStringData = RuntimeHelpers.OffsetToStringData;
					return;
				}
			}
			else
			{
				int num = 1;
				base.ChangeTextContentMark(num != 0);
				while (text != null)
				{
				}
			}
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002AFC File Offset: 0x00000CFC
		public override void WriteEntityRef(string name)
		{
			/*
An exception occurred when decompiling this method (06000038)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.HtmlEncodedRawTextWriter::WriteEntityRef(System.String)

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

		// Token: 0x06000039 RID: 57 RVA: 0x00002B14 File Offset: 0x00000D14
		public override void WriteCharEntity(char ch)
		{
			/*
An exception occurred when decompiling this method (06000039)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.HtmlEncodedRawTextWriter::WriteCharEntity(System.Char)

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

		// Token: 0x0600003A RID: 58 RVA: 0x00002B2C File Offset: 0x00000D2C
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			/*
An exception occurred when decompiling this method (0600003A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.HtmlEncodedRawTextWriter::WriteSurrogateCharEntity(System.Char,System.Char)

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

		// Token: 0x0600003B RID: 59 RVA: 0x00002B44 File Offset: 0x00000D44
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.trackTextContent && !this.inTextContent)
			{
				int num = 1;
				base.ChangeTextContentMark(num != 0);
			}
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002B74 File Offset: 0x00000D74
		private void Init(XmlWriterSettings settings)
		{
			string text = settings.mediaType;
			this.mediaType = text;
			bool flag = settings.doNotEscapeUriAttributes;
			this.doNotEscapeUriAttributes = flag;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002BA0 File Offset: 0x00000DA0
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

		// Token: 0x0600003E RID: 62 RVA: 0x00002C04 File Offset: 0x00000E04
		protected unsafe void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			ElementProperties elementProperties = this.currentElementProperties;
			base.WriteElementTextBlock(pSrc, pSrcEnd);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002C2C File Offset: 0x00000E2C
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

		// Token: 0x06000040 RID: 64 RVA: 0x00002C74 File Offset: 0x00000E74
		private unsafe void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd)
		{
			if (this.endsWithAmpersand)
			{
				char[] bufChars = this.bufChars;
				int num = 97;
				int num2 = 109;
				bufChars.m_value = (char)num;
				int num3 = 112;
				bufChars.m_value = (char)num2;
				int num4 = 59;
				bufChars.m_value = (char)num3;
				bufChars.m_value = (char)num4;
			}
			char[] bufChars2 = this.bufChars;
			if (bufChars2 != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002CF4 File Offset: 0x00000EF4
		private unsafe void WriteUriAttributeText(char* pSrc, char* pSrcEnd)
		{
			if (this.endsWithAmpersand)
			{
				char[] bufChars = this.bufChars;
				int num = 97;
				int num2 = 109;
				bufChars.m_value = (char)num;
				int num3 = 112;
				bufChars.m_value = (char)num2;
				int num4 = 59;
				bufChars.m_value = (char)num3;
				bufChars.m_value = (char)num4;
			}
			char[] bufChars2 = this.bufChars;
			if (bufChars2 != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void OutputRestAmps()
		{
			char[] bufChars = this.bufChars;
			int num = 97;
			int num2 = 109;
			bufChars.m_value = (char)num;
			int num3 = 112;
			bufChars.m_value = (char)num2;
			int num4 = 59;
			bufChars.m_value = (char)num3;
			bufChars.m_value = (char)num4;
		}

		// Token: 0x0400002E RID: 46
		protected ByteStack elementScope;

		// Token: 0x0400002F RID: 47
		protected ElementProperties currentElementProperties;

		// Token: 0x04000030 RID: 48
		private AttributeProperties currentAttributeProperties;

		// Token: 0x04000031 RID: 49
		private bool endsWithAmpersand;

		// Token: 0x04000032 RID: 50
		private byte[] uriEscapingBuffer;

		// Token: 0x04000033 RID: 51
		private string mediaType;

		// Token: 0x04000034 RID: 52
		private bool doNotEscapeUriAttributes;

		// Token: 0x04000035 RID: 53
		protected static TernaryTreeReadOnly elementPropertySearch;

		// Token: 0x04000036 RID: 54
		protected static TernaryTreeReadOnly attributePropertySearch;
	}
}
