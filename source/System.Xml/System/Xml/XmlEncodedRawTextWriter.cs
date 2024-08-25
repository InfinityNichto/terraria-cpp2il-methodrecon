using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000032 RID: 50
	internal class XmlEncodedRawTextWriter : XmlRawWriter
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00004C78 File Offset: 0x00002E78
		protected XmlEncodedRawTextWriter(XmlWriterSettings settings)
		{
			XmlCharType instance = XmlCharType.Instance;
			this.xmlCharType = instance;
			this.bufLen = 6144;
			base..ctor();
			bool flag = settings.useAsync;
			this.useAsync = flag;
			NewLineHandling newLineHandling = settings.newLineHandling;
			this.newLineHandling = newLineHandling;
			bool omitXmlDecl = settings.omitXmlDecl;
			this.omitXmlDeclaration = omitXmlDecl;
			string text = settings.newLineChars;
			this.newLineChars = text;
			bool flag2 = settings.checkCharacters;
			this.checkCharacters = flag2;
			bool flag3 = settings.closeOutput;
			this.closeOutput = flag3;
			XmlStandalone xmlStandalone = settings.standalone;
			this.standalone = xmlStandalone;
			XmlOutputMethod xmlOutputMethod = settings.outputMethod;
			this.outputMethod = xmlOutputMethod;
			bool flag4 = settings.mergeCDataSections;
			this.mergeCDataSections = flag4;
			if (newLineHandling == NewLineHandling.Replace && flag2)
			{
				long num = 0L;
				this.ValidateContentChars(text, "NewLineChars", num != 0L);
				return;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00004D4C File Offset: 0x00002F4C
		public XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
		{
			this.writer = writer;
			this.encoding = writer;
			if (settings.useAsync)
			{
				int num = 1;
				this.bufLen = num;
				return;
			}
			int num2 = this.bufLen;
			if (settings.autoXmlDecl)
			{
				XmlStandalone xmlStandalone = this.standalone;
				int num3 = 1;
				this.autoXmlDeclaration = num3 != 0;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00004DA0 File Offset: 0x00002FA0
		public XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
		{
			this.stream = stream;
			Encoding encoding = settings.encoding;
			this.encoding = encoding;
			if (settings.useAsync)
			{
				int num = 1;
				this.bufLen = num;
				return;
			}
			int num2 = this.bufLen;
			int num3 = 1;
			this.trackTextContent = num3 != 0;
			Encoding encoding2 = settings.encoding;
			if (encoding2 != null)
			{
				this.encoding = encoding2;
				throw new InvalidCastException();
			}
			CharEntityEncoderFallback charEntityEncoderFallback = this.charEntityFallback;
			encoding2.EncoderFallback = charEntityEncoderFallback;
			Encoding encoding3 = this.encoding;
			this.encoder = encoding3;
			if (stream == null && this.encoding.dataItem != null)
			{
				Stream stream2 = this.stream;
			}
			if (settings.autoXmlDecl)
			{
				XmlStandalone xmlStandalone = this.standalone;
				int num4 = 1;
				this.autoXmlDeclaration = num4 != 0;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00004E5C File Offset: 0x0000305C
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			if (this.omitXmlDeclaration || this.autoXmlDeclaration)
			{
				return;
			}
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			this.RawText("<?xml version=\"");
			this.RawText("1.0");
			if (this.encoding != null)
			{
				this.RawText("\" encoding=\"");
				Encoding encoding = this.encoding;
			}
			if (standalone != XmlStandalone.Omit)
			{
				this.RawText("\" standalone=\"");
				this.RawText("\" standalone=\"");
			}
			this.RawText("\"?>");
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00004EE8 File Offset: 0x000030E8
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			if (this.omitXmlDeclaration || this.autoXmlDeclaration)
			{
				return;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00004F08 File Offset: 0x00003108
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			this.RawText("<!DOCTYPE ");
			this.RawText(name);
			if (pubid != null)
			{
				this.RawText(" PUBLIC \"");
				this.RawText(pubid);
				this.RawText("\" \"");
				if (sysid == null)
				{
					return;
				}
			}
			else
			{
				if (sysid == null)
				{
					int num2 = this.bufPos;
					char[] array = this.bufChars;
					return;
				}
				this.RawText(" SYSTEM \"");
			}
			this.RawText(sysid);
			int num3 = this.bufPos;
			char[] array2 = this.bufChars;
			if (subset != null)
			{
				int num4 = 91;
				this.bufPos = num3;
				this.RawText(subset);
				char[] array3 = this.bufChars;
				this.bufPos = num4;
			}
			this.bufPos = num3;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00004FD4 File Offset: 0x000031D4
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
			if (prefix != null && prefix._stringLength != 0)
			{
				this.RawText(prefix);
				char[] array2 = this.bufChars;
			}
			this.RawText(localName);
			int num2 = this.bufPos;
			this.attrEndPos = num2;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005038 File Offset: 0x00003238
		internal override void StartElementContent()
		{
			char[] array = this.bufChars;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000504C File Offset: 0x0000324C
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000050EC File Offset: 0x000032EC
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
			int num2 = 60;
			int num3 = 47;
			array.m_value = (char)num2;
			array.m_value = (char)num3;
			if (prefix != null && prefix._stringLength != 0)
			{
				this.RawText(prefix);
				char[] array2 = this.bufChars;
				this.bufPos = num3;
			}
			this.RawText(localName);
			char[] array3 = this.bufChars;
			this.bufPos = num3;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000516C File Offset: 0x0000336C
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			int num2 = this.bufPos;
			char[] array = this.bufChars;
			if (prefix != null)
			{
				int stringLength = prefix._stringLength;
				this.RawText(prefix);
				char[] array2 = this.bufChars;
			}
			this.RawText(localName);
			char[] array3 = this.bufChars;
			int num3 = 61;
			int num4 = 34;
			int num5 = 1;
			array3.m_value = (char)num3;
			array3.m_value = (char)num4;
			this.inAttributeValue = num5 != 0;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000051F8 File Offset: 0x000033F8
		public override void WriteEndAttribute()
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005228 File Offset: 0x00003428
		internal override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00005238 File Offset: 0x00003438
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005248 File Offset: 0x00003448
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			if (prefix._stringLength != 0)
			{
				this.RawText(" xmlns:");
				this.RawText(prefix);
				char[] array = this.bufChars;
				int num2 = 61;
				int num3 = 34;
				array.m_value = (char)num2;
				array.m_value = (char)num3;
				return;
			}
			this.RawText(" xmlns=\"");
			bool flag = this.trackTextContent;
			int num4 = 1;
			this.inAttributeValue = num4 != 0;
			if (!flag || this.inTextContent)
			{
				return;
			}
			int num5 = 1;
			this.ChangeTextContentMark(num5 != 0);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000052DC File Offset: 0x000034DC
		internal override void WriteEndNamespaceDeclaration()
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000530C File Offset: 0x0000350C
		public override void WriteCData(string text)
		{
			bool flag;
			if (this.trackTextContent)
			{
				flag = this.inTextContent;
				if (flag)
				{
					long num = 0L;
					this.ChangeTextContentMark(num != 0L);
				}
			}
			if (this.mergeCDataSections)
			{
				int num2 = this.cdataPos;
				this.bufPos = (flag ? 1 : 0);
				return;
			}
			char[] array = this.bufChars;
			int num3 = 60;
			int num4 = 33;
			array.m_value = (char)num3;
			int num5 = 91;
			array.m_value = (char)num4;
			int num6 = 67;
			array.m_value = (char)num5;
			array.m_value = (char)num6;
			int num7 = 68;
			array.m_value = (char)num7;
			int num8 = 65;
			array.m_value = (char)num8;
			int num9 = 84;
			array.m_value = (char)num9;
			array.m_value = (char)num8;
			this.bufPos = (flag ? 1 : 0);
			array.m_value = (char)num5;
			this.WriteCDataSection(text);
			char[] array2 = this.bufChars;
			int num10 = 93;
			int num11 = 62;
			array2.m_value = (char)num10;
			array2.m_value = (char)num10;
			array2.m_value = (char)num11;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000053F0 File Offset: 0x000035F0
		public override void WriteComment(string text)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
			int num2 = 60;
			int num3 = 33;
			int num4 = 45;
			int num5 = 45;
			array.m_value = (char)num2;
			array.m_value = (char)num3;
			array.m_value = (char)num4;
			array.m_value = (char)num4;
			this.WriteCommentOrPi(text, num5);
			char[] array2 = this.bufChars;
			int num6 = 62;
			array2.m_value = (char)num4;
			array2.m_value = (char)num4;
			array2.m_value = (char)num6;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000547C File Offset: 0x0000367C
		public override void WriteProcessingInstruction(string name, string text)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
			int num2 = 60;
			int num3 = 63;
			array.m_value = (char)num2;
			array.m_value = (char)num3;
			this.RawText(name);
			int stringLength = text._stringLength;
			char[] array2 = this.bufChars;
			int num4 = 63;
			this.WriteCommentOrPi(text, num4);
			char[] array3 = this.bufChars;
			int num5 = 62;
			array3.m_value = (char)num3;
			array3.m_value = (char)num5;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00005504 File Offset: 0x00003704
		public override void WriteEntityRef(string name)
		{
			bool flag;
			if (this.trackTextContent)
			{
				flag = this.inTextContent;
				if (flag)
				{
					long num = 0L;
					this.ChangeTextContentMark(num != 0L);
				}
			}
			char[] array = this.bufChars;
			this.RawText(name);
			char[] array2 = this.bufChars;
			this.bufPos = (flag ? 1 : 0);
			int num2 = this.bufLen;
			int num3 = this.bufPos;
			this.textPos = num3;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00005568 File Offset: 0x00003768
		public override void WriteCharEntity(char ch)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if (this.checkCharacters)
			{
			}
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
			int num2 = 38;
			int num3 = 35;
			int num4 = 120;
			array.m_value = (char)num2;
			array.m_value = (char)num3;
			array.m_value = (char)num4;
			string text;
			this.RawText(text);
			char[] array2 = this.bufChars;
			this.bufPos = array;
			int num5 = this.bufLen;
			int num6 = this.bufPos;
			this.textPos = num6;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000560C File Offset: 0x0000380C
		public override void WriteWhitespace(string ws)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			if (ws != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005648 File Offset: 0x00003848
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
				this.ChangeTextContentMark(num != 0);
				while (text != null)
				{
				}
			}
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005688 File Offset: 0x00003888
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			char[] array = this.bufChars;
			int num2 = 38;
			int num3 = 35;
			int num4 = 120;
			array.m_value = (char)num2;
			array.m_value = (char)num3;
			array.m_value = (char)num4;
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			this.RawText(text);
			char[] array2 = this.bufChars;
			this.bufPos = num3;
			this.textPos = num3;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005708 File Offset: 0x00003908
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.trackTextContent && !this.inTextContent)
			{
				int num = 1;
				this.ChangeTextContentMark(num != 0);
			}
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005738 File Offset: 0x00003938
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			int num2 = this.bufPos;
			this.textPos = num2;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000576C File Offset: 0x0000396C
		public override void WriteRaw(string data)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				long num = 0L;
				this.ChangeTextContentMark(num != 0L);
			}
			if (data != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
			int num2 = this.bufPos;
			this.textPos = num2;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000057AC File Offset: 0x000039AC
		public override void Close()
		{
			this.FlushEncoder();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000057C0 File Offset: 0x000039C0
		public override void Flush()
		{
			this.FlushEncoder();
			if (this.stream != null)
			{
				return;
			}
			if (this.writer != null)
			{
				return;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000057E8 File Offset: 0x000039E8
		protected virtual void FlushBuffer()
		{
			if (!this.writeToNull)
			{
				if (this.stream != null)
				{
					if (this.trackTextContent)
					{
						int[] array = this.textContentMarks;
						CharEntityEncoderFallback charEntityEncoderFallback = this.charEntityFallback;
						int num = this.lastMarkPos;
						charEntityEncoderFallback.textContentMarks = array;
						charEntityEncoderFallback.endMarkPos = num;
						int num2 = 1;
						this.lastMarkPos = num2;
					}
					int num3 = this.bufPos;
					int num4 = 1;
					int num5 = 1;
					this.EncodeChars(num4, num3, num5 != 0);
					return;
				}
				TextWriter textWriter = this.writer;
				char[] array2 = this.bufChars;
				int num6 = this.bufPos;
			}
			long num7 = 0L;
			int num8 = this.bufPos;
			char[] array3 = this.bufChars;
			int num9 = 1;
			int num10 = this.textPos;
			int num11 = this.attrEndPos;
			this.bufPos = num9;
			this.contentPos = num10;
			this.attrEndPos = num8;
			if (num7 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005914 File Offset: 0x00003B14
		private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream)
		{
			CharEntityEncoderFallback charEntityEncoderFallback = this.charEntityFallback;
			if (charEntityEncoderFallback != null)
			{
				charEntityEncoderFallback.startOffset = startOffset;
			}
			char[] array = this.bufChars;
			Encoder encoder = this.encoder;
			byte[] array2 = this.bufBytes;
			int num = this.bufBytesUsed;
			int num2 = this.bufBytesUsed;
			byte[] array3 = this.bufBytes;
			this.bufBytesUsed = (writeAllToStream ? 1 : 0);
			Stream stream = this.stream;
			int num3 = this.bufBytesUsed;
			byte[] array4 = this.bufBytes;
			Stream stream2 = this.stream;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00005988 File Offset: 0x00003B88
		private void FlushEncoder()
		{
			if (this.stream != null)
			{
				Encoder encoder = this.encoder;
				byte[] array = this.bufBytes;
				char[] array2 = this.bufChars;
				if (false)
				{
					byte[] array3 = this.bufBytes;
					Stream stream = this.stream;
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000059C4 File Offset: 0x00003BC4
		protected unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			if (this.bufChars != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00005A60 File Offset: 0x00003C60
		protected unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			if (this.bufChars != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005AF8 File Offset: 0x00003CF8
		protected void RawText(string s)
		{
			if (s != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005B14 File Offset: 0x00003D14
		protected unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
			if (this.bufChars != null)
			{
				return;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005B50 File Offset: 0x00003D50
		protected unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
			if (this.bufChars != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005BBC File Offset: 0x00003DBC
		protected void WriteCommentOrPi(string text, int stopChar)
		{
			if (text._stringLength == 0)
			{
				int num = this.bufPos;
				int num2 = this.bufLen;
				return;
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (this.bufChars != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005C64 File Offset: 0x00003E64
		protected void WriteCDataSection(string text)
		{
			if (text._stringLength == 0)
			{
				int num = this.bufPos;
				int num2 = this.bufLen;
				return;
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (this.bufChars != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005D2C File Offset: 0x00003F2C
		private unsafe static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst)
		{
			/*
An exception occurred when decompiling this method (06000177)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char* System.Xml.XmlEncodedRawTextWriter::EncodeSurrogate(System.Char*,System.Char*,System.Char*)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:char(char::m_value, ldloc:char*[exp:char&](pSrcEnd), ldloc:int32[exp:char](var_0_01))
	stloc:Exception(var_1_10, call:Exception(XmlConvert::CreateInvalidSurrogatePairException, ldloc:char*[exp:char](pSrcEnd), ldloc:int32[exp:char](var_0_01)))
	stloc:Exception(var_2_17, call:Exception(XmlConvert::CreateInvalidHighSurrogateCharException, ldloc:int32[exp:char](var_0_01)))
	stloc:string(var_3_22, call:string(Res::GetString, ldstr:string("The surrogate pair is invalid. Missing a low surrogate character.")))
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

		// Token: 0x06000178 RID: 376 RVA: 0x00005D5C File Offset: 0x00003F5C
		private unsafe char* InvalidXmlChar(int ch, char* pDst, bool entitize)
		{
			/*
An exception occurred when decompiling this method (06000178)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char* System.Xml.XmlEncodedRawTextWriter::InvalidXmlChar(System.Int32,System.Char*,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:int64(var_0_13, ldc.i4:int64(0))
	stloc:Exception(var_1_1B, call:Exception(XmlConvert::CreateInvalidCharException, ldloc:int32[exp:char](ch), ldloc:int64[exp:char](var_0_13)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005D84 File Offset: 0x00003F84
		internal unsafe void EncodeChar(char* pSrc, char* pSrcEnd, char* pDst)
		{
			char* ptr;
			pDst->m_value = ptr;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005DB8 File Offset: 0x00003FB8
		protected void ChangeTextContentMark(bool value)
		{
			int[] array = this.textContentMarks;
			int num = this.lastMarkPos;
			this.GrowTextContentMarks();
			int num2 = this.lastMarkPos;
			int[] array2 = this.textContentMarks;
			int num3 = this.bufPos;
			this.lastMarkPos = num2;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005DF8 File Offset: 0x00003FF8
		private void GrowTextContentMarks()
		{
			int[] array = this.textContentMarks;
			int[] array2 = this.textContentMarks;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005E14 File Offset: 0x00004014
		protected unsafe char* WriteNewLine(char* pDst)
		{
			/*
An exception occurred when decompiling this method (0600017C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char* System.Xml.XmlEncodedRawTextWriter::WriteNewLine(System.Char*)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:string(var_1_10, ldfld:string(XmlEncodedRawTextWriter::newLineChars, ldloc:XmlEncodedRawTextWriter(this)))
	stfld:int32(XmlEncodedRawTextWriter::bufPos, ldloc:XmlEncodedRawTextWriter(this), ldloc:char[][exp:int32](var_0_06))
	call:void(XmlEncodedRawTextWriter::RawText, ldloc:XmlEncodedRawTextWriter(this), ldloc:string(var_1_10))
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

		// Token: 0x0600017D RID: 381 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* LtEntity(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* GtEntity(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* AmpEntity(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* QuoteEntity(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* TabEntity(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* LineFeedEntity(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* CarriageReturnEntity(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005E40 File Offset: 0x00004040
		private unsafe static char* CharEntity(char* pDst, char ch)
		{
			/*
An exception occurred when decompiling this method (06000184)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char* System.Xml.XmlEncodedRawTextWriter::CharEntity(System.Char*,System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	brtrue(IL_0018, ldloc:int32[exp:bool](var_3_0A))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* RawStartCData(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static char* RawEndCData(char* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00005E68 File Offset: 0x00004068
		protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000087 RID: 135
		private readonly bool useAsync;

		// Token: 0x04000088 RID: 136
		protected byte[] bufBytes;

		// Token: 0x04000089 RID: 137
		protected Stream stream;

		// Token: 0x0400008A RID: 138
		protected Encoding encoding;

		// Token: 0x0400008B RID: 139
		protected XmlCharType xmlCharType;

		// Token: 0x0400008C RID: 140
		protected int bufPos;

		// Token: 0x0400008D RID: 141
		protected int textPos;

		// Token: 0x0400008E RID: 142
		protected int contentPos;

		// Token: 0x0400008F RID: 143
		protected int cdataPos;

		// Token: 0x04000090 RID: 144
		protected int attrEndPos;

		// Token: 0x04000091 RID: 145
		protected int bufLen;

		// Token: 0x04000092 RID: 146
		protected bool writeToNull;

		// Token: 0x04000093 RID: 147
		protected bool hadDoubleBracket;

		// Token: 0x04000094 RID: 148
		protected bool inAttributeValue;

		// Token: 0x04000095 RID: 149
		protected int bufBytesUsed;

		// Token: 0x04000096 RID: 150
		protected char[] bufChars;

		// Token: 0x04000097 RID: 151
		protected Encoder encoder;

		// Token: 0x04000098 RID: 152
		protected TextWriter writer;

		// Token: 0x04000099 RID: 153
		protected bool trackTextContent;

		// Token: 0x0400009A RID: 154
		protected bool inTextContent;

		// Token: 0x0400009B RID: 155
		private int lastMarkPos;

		// Token: 0x0400009C RID: 156
		private int[] textContentMarks;

		// Token: 0x0400009D RID: 157
		private CharEntityEncoderFallback charEntityFallback;

		// Token: 0x0400009E RID: 158
		protected NewLineHandling newLineHandling;

		// Token: 0x0400009F RID: 159
		protected bool closeOutput;

		// Token: 0x040000A0 RID: 160
		protected bool omitXmlDeclaration;

		// Token: 0x040000A1 RID: 161
		protected string newLineChars;

		// Token: 0x040000A2 RID: 162
		protected bool checkCharacters;

		// Token: 0x040000A3 RID: 163
		protected XmlStandalone standalone;

		// Token: 0x040000A4 RID: 164
		protected XmlOutputMethod outputMethod;

		// Token: 0x040000A5 RID: 165
		protected bool autoXmlDeclaration;

		// Token: 0x040000A6 RID: 166
		protected bool mergeCDataSections;
	}
}
