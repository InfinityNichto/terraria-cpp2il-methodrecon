using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x02000033 RID: 51
	internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00005EE8 File Offset: 0x000040E8
		public XmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings)
			: base(writer, settings)
		{
			this.Init(settings);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005F04 File Offset: 0x00004104
		public XmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings)
			: base(stream, settings)
		{
			this.Init(settings);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00005F20 File Offset: 0x00004120
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (!this.mixedContent)
			{
				int bufPos = this.bufPos;
				int contentPos = this.contentPos;
				this.WriteIndent();
			}
			base.WriteDocType(name, pubid, sysid, subset);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005F54 File Offset: 0x00004154
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (this.mixedContent)
			{
				return;
			}
			int bufPos = this.bufPos;
			int contentPos = this.contentPos;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00005FC8 File Offset: 0x000041C8
		internal override void StartElementContent()
		{
			int num = this.indentLevel;
			ConformanceLevel conformanceLevel = this.conformanceLevel;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00006000 File Offset: 0x00004200
		internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
			this.conformanceLevel = currentConformanceLevel;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00006014 File Offset: 0x00004214
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			int num = this.indentLevel;
			bool flag = this.mixedContent;
			this.indentLevel = num;
			if (!flag)
			{
				int contentPos = this.contentPos;
				int bufPos = this.bufPos;
				int textPos = this.textPos;
				this.WriteIndent();
			}
			BitStack bitStack = this.mixedContentStack;
			uint curr = bitStack.curr;
			int stackPos = bitStack.stackPos;
			uint[] bitStack2 = bitStack.bitStack;
			bitStack.stackPos = stackPos;
			bitStack.curr = (uint)stackPos;
			this.mixedContent = curr != 0U;
			base.WriteEndElement(prefix, localName, ns);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000609C File Offset: 0x0000429C
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			int num = this.indentLevel;
			bool flag = this.mixedContent;
			this.indentLevel = num;
			if (!flag)
			{
				int contentPos = this.contentPos;
				int bufPos = this.bufPos;
				int textPos = this.textPos;
				this.WriteIndent();
			}
			BitStack bitStack = this.mixedContentStack;
			uint curr = bitStack.curr;
			int stackPos = bitStack.stackPos;
			uint[] bitStack2 = bitStack.bitStack;
			bitStack.stackPos = stackPos;
			bitStack.curr = (uint)stackPos;
			this.mixedContent = curr != 0U;
			base.WriteFullEndElement(prefix, localName, ns);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00006124 File Offset: 0x00004324
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this.newLineOnAttributes)
			{
				this.WriteIndent();
			}
			base.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006148 File Offset: 0x00004348
		public override void WriteCData(string text)
		{
			this.mixedContent = true;
			base.WriteCData(text);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006164 File Offset: 0x00004364
		public override void WriteComment(string text)
		{
			if (!this.mixedContent)
			{
				int bufPos = this.bufPos;
				int contentPos = this.contentPos;
				this.WriteIndent();
			}
			base.WriteComment(text);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006194 File Offset: 0x00004394
		public override void WriteProcessingInstruction(string target, string text)
		{
			if (!this.mixedContent)
			{
				int bufPos = this.bufPos;
				int contentPos = this.contentPos;
				this.WriteIndent();
			}
			base.WriteProcessingInstruction(target, text);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000061C8 File Offset: 0x000043C8
		public override void WriteEntityRef(string name)
		{
			this.mixedContent = true;
			base.WriteEntityRef(name);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000061E4 File Offset: 0x000043E4
		public override void WriteCharEntity(char ch)
		{
			this.mixedContent = true;
			base.WriteCharEntity(ch);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006200 File Offset: 0x00004400
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.mixedContent = true;
			base.WriteSurrogateCharEntity(lowChar, highChar);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000621C File Offset: 0x0000441C
		public override void WriteWhitespace(string ws)
		{
			this.mixedContent = true;
			base.WriteWhitespace(ws);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00006238 File Offset: 0x00004438
		public override void WriteString(string text)
		{
			this.mixedContent = true;
			base.WriteString(text);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00006254 File Offset: 0x00004454
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteChars(buffer, index, count);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00006274 File Offset: 0x00004474
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteRaw(buffer, index, count);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00006294 File Offset: 0x00004494
		public override void WriteRaw(string data)
		{
			this.mixedContent = true;
			base.WriteRaw(data);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000062B0 File Offset: 0x000044B0
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteBase64(buffer, index, count);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000062D0 File Offset: 0x000044D0
		private void Init(XmlWriterSettings settings)
		{
			string text = settings.indentChars;
			this.indentChars = text;
			bool flag = settings.newLineOnAttributes;
			this.newLineOnAttributes = flag;
			if (this.checkCharacters)
			{
				bool flag2 = this.newLineOnAttributes;
				string text2 = this.indentChars;
				string newLineChars;
				if (flag2)
				{
					base.ValidateContentChars(text2, "IndentChars", true);
					newLineChars = this.newLineChars;
					return;
				}
				long num = 0L;
				base.ValidateContentChars(newLineChars, "NewLineChars", num != 0L);
				if (this.newLineHandling != NewLineHandling.Replace)
				{
					string newLineChars2 = this.newLineChars;
					long num2 = 0L;
					base.ValidateContentChars(newLineChars2, "NewLineChars", num2 != 0L);
					return;
				}
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006360 File Offset: 0x00004560
		private void WriteIndent()
		{
			string newLineChars = this.newLineChars;
			base.RawText(newLineChars);
			int num = this.indentLevel;
			string text = this.indentChars;
			base.RawText(text);
		}

		// Token: 0x040000A7 RID: 167
		protected int indentLevel;

		// Token: 0x040000A8 RID: 168
		protected bool newLineOnAttributes;

		// Token: 0x040000A9 RID: 169
		protected string indentChars;

		// Token: 0x040000AA RID: 170
		protected bool mixedContent;

		// Token: 0x040000AB RID: 171
		private BitStack mixedContentStack;

		// Token: 0x040000AC RID: 172
		protected ConformanceLevel conformanceLevel;
	}
}
