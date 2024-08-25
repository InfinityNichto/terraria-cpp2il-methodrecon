using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x02000015 RID: 21
	internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
	{
		// Token: 0x06000065 RID: 101 RVA: 0x000036EC File Offset: 0x000018EC
		public HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
			: base(stream, settings)
		{
			base.Init(settings);
			string text = settings.indentChars;
			this.indentChars = text;
			bool flag = settings.newLineOnAttributes;
			this.newLineOnAttributes = flag;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003724 File Offset: 0x00001924
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			base.WriteDocType(name, pubid, sysid, subset);
			int bufPos = this.bufPos;
			this.endBlockPos = bufPos;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000374C File Offset: 0x0000194C
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			ByteStack elementScope = this.elementScope;
			ElementProperties currentElementProperties = this.currentElementProperties;
			if (ns._stringLength != 0)
			{
				int num = this.endBlockPos;
				int bufPos = this.bufPos;
				int num2 = 192;
				this.currentElementProperties = (ElementProperties)num2;
				this.WriteIndent();
				int bufPos2 = this.bufPos;
				int num3 = this.indentLevel;
				byte[] bufBytes = this.bufBytes;
				this.indentLevel = num3;
				if (prefix._stringLength != 0)
				{
					base.RawText(prefix);
					byte[] bufBytes2 = this.bufBytes;
					return;
				}
			}
			else
			{
				int bufPos3 = this.bufPos;
				byte[] bufBytes2;
				this.currentElementProperties = bufBytes2;
				int num4 = this.endBlockPos;
				this.WriteIndent();
				int bufPos4 = this.bufPos;
				int num5 = this.indentLevel;
				byte[] bufBytes3 = this.bufBytes;
				this.indentLevel = num5;
			}
			base.RawText(localName);
			int bufPos5 = this.bufPos;
			this.attrEndPos = bufPos5;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000382C File Offset: 0x00001A2C
		internal override void StartElementContent()
		{
			byte[] bufBytes = this.bufBytes;
			int bufPos = this.bufPos;
			ElementProperties currentElementProperties = this.currentElementProperties;
			this.contentPos = bufPos;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003864 File Offset: 0x00001A64
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			int num = this.indentLevel;
			ElementProperties currentElementProperties = this.currentElementProperties;
			this.indentLevel = num;
			base.WriteEndElement(prefix, localName, ns);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000038C8 File Offset: 0x00001AC8
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this.newLineOnAttributes)
			{
				string newLineChars = this.newLineChars;
				base.RawText(newLineChars);
				int num = this.indentLevel;
				this.indentLevel = num;
				this.WriteIndent();
				int num2 = this.indentLevel;
				this.indentLevel = num2;
			}
			base.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003918 File Offset: 0x00001B18
		protected override void FlushBuffer()
		{
			int num = this.endBlockPos;
			int bufPos = this.bufPos;
			this.endBlockPos = num;
			base.FlushBuffer();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003940 File Offset: 0x00001B40
		private void Init(XmlWriterSettings settings)
		{
			string text = settings.indentChars;
			this.indentChars = text;
			bool flag = settings.newLineOnAttributes;
			this.newLineOnAttributes = flag;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000396C File Offset: 0x00001B6C
		private void WriteIndent()
		{
			string newLineChars = this.newLineChars;
			base.RawText(newLineChars);
			int num = this.indentLevel;
			string text = this.indentChars;
			base.RawText(text);
		}

		// Token: 0x04000046 RID: 70
		private int indentLevel;

		// Token: 0x04000047 RID: 71
		private int endBlockPos;

		// Token: 0x04000048 RID: 72
		private string indentChars;

		// Token: 0x04000049 RID: 73
		private bool newLineOnAttributes;
	}
}
