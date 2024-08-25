using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x0200005C RID: 92
	public abstract class XmlWriter : IDisposable
	{
		// Token: 0x0600041A RID: 1050
		public abstract void WriteStartDocument();

		// Token: 0x0600041B RID: 1051
		public abstract void WriteStartDocument(bool standalone);

		// Token: 0x0600041C RID: 1052
		public abstract void WriteEndDocument();

		// Token: 0x0600041D RID: 1053
		public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

		// Token: 0x0600041E RID: 1054
		public abstract void WriteStartElement(string prefix, string localName, string ns);

		// Token: 0x0600041F RID: 1055
		public abstract void WriteEndElement();

		// Token: 0x06000420 RID: 1056
		public abstract void WriteFullEndElement();

		// Token: 0x06000421 RID: 1057 RVA: 0x00010C2C File Offset: 0x0000EE2C
		public void WriteAttributeString(string prefix, string localName, string ns, string value)
		{
		}

		// Token: 0x06000422 RID: 1058
		public abstract void WriteStartAttribute(string prefix, string localName, string ns);

		// Token: 0x06000423 RID: 1059
		public abstract void WriteEndAttribute();

		// Token: 0x06000424 RID: 1060
		public abstract void WriteCData(string text);

		// Token: 0x06000425 RID: 1061
		public abstract void WriteComment(string text);

		// Token: 0x06000426 RID: 1062
		public abstract void WriteProcessingInstruction(string name, string text);

		// Token: 0x06000427 RID: 1063
		public abstract void WriteEntityRef(string name);

		// Token: 0x06000428 RID: 1064
		public abstract void WriteCharEntity(char ch);

		// Token: 0x06000429 RID: 1065
		public abstract void WriteWhitespace(string ws);

		// Token: 0x0600042A RID: 1066
		public abstract void WriteString(string text);

		// Token: 0x0600042B RID: 1067
		public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

		// Token: 0x0600042C RID: 1068
		public abstract void WriteChars(char[] buffer, int index, int count);

		// Token: 0x0600042D RID: 1069
		public abstract void WriteRaw(char[] buffer, int index, int count);

		// Token: 0x0600042E RID: 1070
		public abstract void WriteRaw(string data);

		// Token: 0x0600042F RID: 1071
		public abstract void WriteBase64(byte[] buffer, int index, int count);

		// Token: 0x06000430 RID: 1072 RVA: 0x00010C3C File Offset: 0x0000EE3C
		public virtual void WriteBinHex(byte[] buffer, int index, int count)
		{
			BinHexEncoder.Encode(buffer, index, count, this);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000431 RID: 1073
		public abstract WriteState WriteState { get; }

		// Token: 0x06000432 RID: 1074 RVA: 0x00010C54 File Offset: 0x0000EE54
		public virtual void Close()
		{
		}

		// Token: 0x06000433 RID: 1075
		public abstract void Flush();

		// Token: 0x06000434 RID: 1076
		public abstract string LookupPrefix(string ns);

		// Token: 0x06000435 RID: 1077 RVA: 0x00010C64 File Offset: 0x0000EE64
		public virtual void WriteValue(string value)
		{
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00010C78 File Offset: 0x0000EE78
		public void Dispose()
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00010C88 File Offset: 0x0000EE88
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00010C98 File Offset: 0x0000EE98
		public static XmlWriter Create(Stream output, XmlWriterSettings settings)
		{
			if (output == null)
			{
			}
			XmlWriter xmlWriter;
			return xmlWriter;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00010CAC File Offset: 0x0000EEAC
		public static XmlWriter Create(TextWriter output, XmlWriterSettings settings)
		{
			if (output == null)
			{
			}
			XmlWriter xmlWriter;
			return xmlWriter;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00010CC0 File Offset: 0x0000EEC0
		protected XmlWriter()
		{
		}
	}
}
