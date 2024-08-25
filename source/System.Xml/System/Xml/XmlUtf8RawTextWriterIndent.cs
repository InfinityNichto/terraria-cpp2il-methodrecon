using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x0200004D RID: 77
	internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x0000EC88 File Offset: 0x0000CE88
		public XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
			: base(stream, settings)
		{
			this.Init(settings);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
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

		// Token: 0x060003B3 RID: 947 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (this.mixedContent)
			{
				return;
			}
			int bufPos = this.bufPos;
			int contentPos = this.contentPos;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000ED38 File Offset: 0x0000CF38
		internal override void StartElementContent()
		{
			int num = this.indentLevel;
			ConformanceLevel conformanceLevel = this.conformanceLevel;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000ED84 File Offset: 0x0000CF84
		internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
			this.conformanceLevel = currentConformanceLevel;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000ED98 File Offset: 0x0000CF98
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			int num = this.indentLevel;
			bool flag = this.mixedContent;
			this.indentLevel = num;
			int bufPos;
			if (!flag)
			{
				int contentPos = this.contentPos;
				bufPos = this.bufPos;
				int textPos = this.textPos;
				this.WriteIndent();
			}
			bool flag2 = this.mixedContentStack.PopBit();
			this.mixedContent = bufPos != 0;
			base.WriteEndElement(prefix, localName, ns);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000EDF8 File Offset: 0x0000CFF8
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			int num = this.indentLevel;
			bool flag = this.mixedContent;
			this.indentLevel = num;
			int bufPos;
			if (!flag)
			{
				int contentPos = this.contentPos;
				bufPos = this.bufPos;
				int textPos = this.textPos;
				this.WriteIndent();
			}
			bool flag2 = this.mixedContentStack.PopBit();
			this.mixedContent = bufPos != 0;
			base.WriteFullEndElement(prefix, localName, ns);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000EE58 File Offset: 0x0000D058
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this.newLineOnAttributes)
			{
				this.WriteIndent();
			}
			base.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000EE7C File Offset: 0x0000D07C
		public override void WriteCData(string text)
		{
			this.mixedContent = true;
			base.WriteCData(text);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000EE98 File Offset: 0x0000D098
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

		// Token: 0x060003BB RID: 955 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
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

		// Token: 0x060003BC RID: 956 RVA: 0x0000EEFC File Offset: 0x0000D0FC
		public override void WriteEntityRef(string name)
		{
			this.mixedContent = true;
			base.WriteEntityRef(name);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000EF18 File Offset: 0x0000D118
		public override void WriteCharEntity(char ch)
		{
			this.mixedContent = true;
			base.WriteCharEntity(ch);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000EF34 File Offset: 0x0000D134
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.mixedContent = true;
			base.WriteSurrogateCharEntity(lowChar, highChar);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000EF50 File Offset: 0x0000D150
		public override void WriteWhitespace(string ws)
		{
			this.mixedContent = true;
			base.WriteWhitespace(ws);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000EF6C File Offset: 0x0000D16C
		public override void WriteString(string text)
		{
			this.mixedContent = true;
			base.WriteString(text);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000EF88 File Offset: 0x0000D188
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteChars(buffer, index, count);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			int num = 1;
			this.mixedContent = num != 0;
			int bufPos = this.bufPos;
			this.textPos = bufPos;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		public override void WriteRaw(string data)
		{
			this.mixedContent = true;
			base.WriteRaw(data);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteBase64(buffer, index, count);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000F008 File Offset: 0x0000D208
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

		// Token: 0x060003C6 RID: 966 RVA: 0x0000F098 File Offset: 0x0000D298
		private void WriteIndent()
		{
			string newLineChars = this.newLineChars;
			base.RawText(newLineChars);
			int num = this.indentLevel;
			string text = this.indentChars;
			base.RawText(text);
		}

		// Token: 0x040001D8 RID: 472
		protected int indentLevel;

		// Token: 0x040001D9 RID: 473
		protected bool newLineOnAttributes;

		// Token: 0x040001DA RID: 474
		protected string indentChars;

		// Token: 0x040001DB RID: 475
		protected bool mixedContent;

		// Token: 0x040001DC RID: 476
		private BitStack mixedContentStack;

		// Token: 0x040001DD RID: 477
		protected ConformanceLevel conformanceLevel;
	}
}
