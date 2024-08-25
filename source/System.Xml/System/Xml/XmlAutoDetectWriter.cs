using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x02000031 RID: 49
	internal class XmlAutoDetectWriter : XmlRawWriter
	{
		// Token: 0x0600012B RID: 299 RVA: 0x000047C0 File Offset: 0x000029C0
		private XmlAutoDetectWriter(XmlWriterSettings writerSettings)
		{
			XmlWriterSettings xmlWriterSettings = writerSettings.Clone();
			this.writerSettings = xmlWriterSettings;
			xmlWriterSettings.isReadOnly = true;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000047E8 File Offset: 0x000029E8
		public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings)
		{
			this.textWriter = textWriter;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000047FC File Offset: 0x000029FC
		public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings)
		{
			this.strm = strm;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004810 File Offset: 0x00002A10
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000482C File Offset: 0x00002A2C
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (this.wrapped == null && ns._stringLength == 0)
			{
				bool flag = XmlAutoDetectWriter.IsHtmlTag(localName);
				return;
			}
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004858 File Offset: 0x00002A58
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004870 File Offset: 0x00002A70
		public override void WriteEndAttribute()
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004884 File Offset: 0x00002A84
		public override void WriteCData(string text)
		{
			bool flag = this.TextBlockCreatesWriter(text);
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000048A8 File Offset: 0x00002AA8
		public override void WriteComment(string text)
		{
			if (this.wrapped == null)
			{
				XmlEventCache xmlEventCache = this.eventCache;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000048C4 File Offset: 0x00002AC4
		public override void WriteProcessingInstruction(string name, string text)
		{
			if (this.wrapped == null)
			{
				XmlEventCache xmlEventCache = this.eventCache;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000048E0 File Offset: 0x00002AE0
		public override void WriteWhitespace(string ws)
		{
			if (this.wrapped == null)
			{
				XmlEventCache xmlEventCache = this.eventCache;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000048FC File Offset: 0x00002AFC
		public override void WriteString(string text)
		{
			bool flag = this.TextBlockCreatesWriter(text);
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004920 File Offset: 0x00002B20
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004930 File Offset: 0x00002B30
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004940 File Offset: 0x00002B40
		public override void WriteRaw(string data)
		{
			bool flag = this.TextBlockCreatesWriter(data);
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004964 File Offset: 0x00002B64
		public override void WriteEntityRef(string name)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004980 File Offset: 0x00002B80
		public override void WriteCharEntity(char ch)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000499C File Offset: 0x00002B9C
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000049B8 File Offset: 0x00002BB8
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000049D4 File Offset: 0x00002BD4
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000049F0 File Offset: 0x00002BF0
		public override void Close()
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004A0C File Offset: 0x00002C0C
		public override void Flush()
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004A28 File Offset: 0x00002C28
		public override void WriteValue(string value)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x17000038 RID: 56
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00004A44 File Offset: 0x00002C44
		internal override IXmlNamespaceResolver NamespaceResolver
		{
			set
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
				this.resolver = value;
				if (xmlRawWriter == null)
				{
					XmlEventCache xmlEventCache = this.eventCache;
				}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004A6C File Offset: 0x00002C6C
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00004A88 File Offset: 0x00002C88
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00004AA4 File Offset: 0x00002CA4
		internal override void StartElementContent()
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00004AB8 File Offset: 0x00002CB8
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00004ACC File Offset: 0x00002CCC
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004AE0 File Offset: 0x00002CE0
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			if (this.wrapped == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00004AFC File Offset: 0x00002CFC
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000149)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlAutoDetectWriter::get_SupportsNamespaceDeclarationInChunks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlRawWriter(var_0_06, ldfld:XmlRawWriter(XmlAutoDetectWriter::wrapped, ldloc:XmlAutoDetectWriter(this)))
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

		// Token: 0x0600014A RID: 330 RVA: 0x00004B10 File Offset: 0x00002D10
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			if (this == null)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004B28 File Offset: 0x00002D28
		internal override void WriteEndNamespaceDeclaration()
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004B3C File Offset: 0x00002D3C
		private static bool IsHtmlTag(string tagName)
		{
			return true;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00004B54 File Offset: 0x00002D54
		private void EnsureWrappedWriter(XmlOutputMethod outMethod)
		{
			if (this.wrapped != null)
			{
				return;
			}
			this.CreateWrappedWriter(outMethod);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004B74 File Offset: 0x00002D74
		private bool TextBlockCreatesWriter(string textBlock)
		{
			if (this.wrapped == null)
			{
				bool flag = XmlCharType.Instance.IsOnlyWhitespace(textBlock);
			}
			return true;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004B9C File Offset: 0x00002D9C
		private void CreateWrappedWriter(XmlOutputMethod outMethod)
		{
			XmlWriterSettings xmlWriterSettings = this.writerSettings;
			xmlWriterSettings.outputMethod = outMethod;
			TriState indent = xmlWriterSettings.indent;
			int num = 1;
			xmlWriterSettings.Indent = num != 0;
			XmlWriterSettings xmlWriterSettings2 = this.writerSettings;
			int num2 = 1;
			xmlWriterSettings2.isReadOnly = num2 != 0;
			TextWriter textWriter = this.textWriter;
			if (textWriter != null)
			{
				if (XmlWriter.Create(textWriter, xmlWriterSettings2) == null)
				{
					return;
				}
			}
			else if (XmlWriter.Create(this.strm, xmlWriterSettings2) != null)
			{
			}
			XmlEventCache xmlEventCache = this.eventCache;
			XmlEventCache xmlEventCache2;
			XmlRawWriter xmlRawWriter;
			if (xmlEventCache.singleText.idxStr == 0)
			{
				int num3 = xmlEventCache.NewEvent();
				XmlEventCache.XmlEvent[] pageCurr = xmlEventCache.pageCurr;
				xmlEventCache2 = this.eventCache;
				xmlRawWriter = this.wrapped;
			}
			xmlEventCache2.EventsToWriter(xmlRawWriter);
			OnRemoveWriter onRemoveWriter = this.onRemove;
			if (onRemoveWriter != null)
			{
				XmlRawWriter xmlRawWriter2 = this.wrapped;
				IntPtr invoke_impl = onRemoveWriter.invoke_impl;
				IntPtr method_code = onRemoveWriter.method_code;
				IntPtr method = onRemoveWriter.method;
				return;
			}
		}

		// Token: 0x04000081 RID: 129
		private XmlRawWriter wrapped;

		// Token: 0x04000082 RID: 130
		private OnRemoveWriter onRemove;

		// Token: 0x04000083 RID: 131
		private XmlWriterSettings writerSettings;

		// Token: 0x04000084 RID: 132
		private XmlEventCache eventCache;

		// Token: 0x04000085 RID: 133
		private TextWriter textWriter;

		// Token: 0x04000086 RID: 134
		private Stream strm;
	}
}
