using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x0200002D RID: 45
	internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0000429C File Offset: 0x0000249C
		public TextUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
			: base(stream, settings)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000042B4 File Offset: 0x000024B4
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000042C4 File Offset: 0x000024C4
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000042D4 File Offset: 0x000024D4
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000042E4 File Offset: 0x000024E4
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000042F4 File Offset: 0x000024F4
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004304 File Offset: 0x00002504
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004314 File Offset: 0x00002514
		internal override void StartElementContent()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004324 File Offset: 0x00002524
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.inAttributeValue = true;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004338 File Offset: 0x00002538
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004348 File Offset: 0x00002548
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00004358 File Offset: 0x00002558
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004368 File Offset: 0x00002568
		public override void WriteCData(string text)
		{
			base.WriteRaw(text);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000437C File Offset: 0x0000257C
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000438C File Offset: 0x0000258C
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000439C File Offset: 0x0000259C
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000043AC File Offset: 0x000025AC
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000043BC File Offset: 0x000025BC
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000043CC File Offset: 0x000025CC
		public override void WriteWhitespace(string ws)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(ws);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000043EC File Offset: 0x000025EC
		public override void WriteString(string textBlock)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(textBlock);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000440C File Offset: 0x0000260C
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(buffer, index, count);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000442C File Offset: 0x0000262C
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			if (this.inAttributeValue)
			{
				return;
			}
			base.WriteRaw(buffer, index, count);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000444C File Offset: 0x0000264C
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
