using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x0200002C RID: 44
	internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter
	{
		// Token: 0x060000DE RID: 222 RVA: 0x000040B4 File Offset: 0x000022B4
		public TextEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
			: base(writer, settings)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000040CC File Offset: 0x000022CC
		public TextEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
			: base(stream, settings)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000040E4 File Offset: 0x000022E4
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000040F4 File Offset: 0x000022F4
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004104 File Offset: 0x00002304
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004114 File Offset: 0x00002314
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004124 File Offset: 0x00002324
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004134 File Offset: 0x00002334
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004144 File Offset: 0x00002344
		internal override void StartElementContent()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004154 File Offset: 0x00002354
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.inAttributeValue = true;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004168 File Offset: 0x00002368
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004178 File Offset: 0x00002378
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00004188 File Offset: 0x00002388
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004198 File Offset: 0x00002398
		public override void WriteCData(string text)
		{
			base.WriteRaw(text);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000041AC File Offset: 0x000023AC
		public override void WriteComment(string text)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000041BC File Offset: 0x000023BC
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000041CC File Offset: 0x000023CC
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000041DC File Offset: 0x000023DC
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000041EC File Offset: 0x000023EC
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000041FC File Offset: 0x000023FC
		public override void WriteWhitespace(string ws)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(ws);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000421C File Offset: 0x0000241C
		public override void WriteString(string textBlock)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(textBlock);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000423C File Offset: 0x0000243C
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(buffer, index, count);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000425C File Offset: 0x0000245C
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(buffer, index, count);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000427C File Offset: 0x0000247C
		public override void WriteRaw(string data)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(data);
		}
	}
}
