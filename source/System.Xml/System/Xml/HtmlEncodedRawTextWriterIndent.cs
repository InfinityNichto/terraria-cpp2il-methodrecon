using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x02000012 RID: 18
	internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002DF4 File Offset: 0x00000FF4
		public HtmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings)
			: base(writer, settings)
		{
			base.Init(settings);
			string text = settings.indentChars;
			this.indentChars = text;
			bool flag = settings.newLineOnAttributes;
			this.newLineOnAttributes = flag;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002E2C File Offset: 0x0000102C
		public HtmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings)
			: base(stream, settings)
		{
			base.Init(settings);
			string text = settings.indentChars;
			this.indentChars = text;
			bool flag = settings.newLineOnAttributes;
			this.newLineOnAttributes = flag;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002E64 File Offset: 0x00001064
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			base.WriteDocType(name, pubid, sysid, subset);
			int bufPos = this.bufPos;
			this.endBlockPos = bufPos;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002E8C File Offset: 0x0000108C
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				base.ChangeTextContentMark(num != 0L);
			}
			ByteStack elementScope = this.elementScope;
			ElementProperties currentElementProperties = this.currentElementProperties;
			if (ns._stringLength != 0)
			{
				int bufPos = this.bufPos;
				int num2 = 192;
				string newLineChars = this.newLineChars;
				this.writer = num2;
				this.WriteIndent();
				int bufPos2 = this.bufPos;
				char[] bufChars = this.bufChars;
				if (prefix._stringLength != 0)
				{
					base.RawText(prefix);
					int bufPos3 = this.bufPos;
					int num3 = 58;
					return;
				}
			}
			else
			{
				int bufPos4 = this.bufPos;
				int num3;
				this.writer = num3;
				string newLineChars2 = this.newLineChars;
				this.WriteIndent();
				int bufPos5 = this.bufPos;
				int num4 = this.indentLevel;
				this.indentLevel = num4;
			}
			base.RawText(localName);
			int bufPos6 = this.bufPos;
			this.attrEndPos = bufPos6;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002F70 File Offset: 0x00001170
		internal override void StartElementContent()
		{
			char[] bufChars = this.bufChars;
			ElementProperties currentElementProperties = this.currentElementProperties;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002FA8 File Offset: 0x000011A8
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			int num = this.indentLevel;
			ElementProperties currentElementProperties = this.currentElementProperties;
			this.indentLevel = num;
			base.WriteEndElement(prefix, localName, ns);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000300C File Offset: 0x0000120C
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			string newLineChars = this.newLineChars;
			base.RawText(newLineChars);
			int num = this.indentLevel;
			this.indentLevel = num;
			this.WriteIndent();
			int num2 = this.indentLevel;
			this.indentLevel = num2;
			base.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003054 File Offset: 0x00001254
		protected override void FlushBuffer()
		{
			int num = this.endBlockPos;
			int bufPos = this.bufPos;
			this.endBlockPos = num;
			base.FlushBuffer();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000307C File Offset: 0x0000127C
		private void Init(XmlWriterSettings settings)
		{
			string text = settings.indentChars;
			this.indentChars = text;
			bool flag = settings.newLineOnAttributes;
			this.newLineOnAttributes = flag;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000030A8 File Offset: 0x000012A8
		private void WriteIndent()
		{
			string newLineChars = this.newLineChars;
			base.RawText(newLineChars);
			int num = this.indentLevel;
			string text = this.indentChars;
			base.RawText(text);
		}

		// Token: 0x04000037 RID: 55
		private int indentLevel;

		// Token: 0x04000038 RID: 56
		private int endBlockPos;

		// Token: 0x04000039 RID: 57
		private string indentChars;

		// Token: 0x0400003A RID: 58
		private bool newLineOnAttributes;
	}
}
