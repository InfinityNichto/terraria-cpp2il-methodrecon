using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Xml
{
	// Token: 0x0200001C RID: 28
	internal interface IDtdParserAdapter
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000090 RID: 144
		XmlNameTable NameTable { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000091 RID: 145
		IXmlNamespaceResolver NamespaceResolver { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000092 RID: 146
		Uri BaseUri { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000093 RID: 147
		char[] ParsingBuffer { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000094 RID: 148
		int ParsingBufferLength { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000095 RID: 149
		// (set) Token: 0x06000096 RID: 150
		int CurrentPosition { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000097 RID: 151
		int LineNo { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000098 RID: 152
		int LineStartPosition { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000099 RID: 153
		bool IsEof { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009A RID: 154
		int EntityStackLength { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009B RID: 155
		bool IsEntityEolNormalized { get; }

		// Token: 0x0600009C RID: 156
		int ReadData();

		// Token: 0x0600009D RID: 157
		void OnNewLine(int pos);

		// Token: 0x0600009E RID: 158
		int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

		// Token: 0x0600009F RID: 159
		int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

		// Token: 0x060000A0 RID: 160
		void ParsePI(StringBuilder sb);

		// Token: 0x060000A1 RID: 161
		void ParseComment(StringBuilder sb);

		// Token: 0x060000A2 RID: 162
		bool PushEntity(IDtdEntityInfo entity, [Out] int entityId);

		// Token: 0x060000A3 RID: 163
		bool PopEntity([Out] IDtdEntityInfo oldEntity, [Out] int newEntityId);

		// Token: 0x060000A4 RID: 164
		bool PushExternalSubset(string systemId, string publicId);

		// Token: 0x060000A5 RID: 165
		void PushInternalDtd(string baseUri, string internalDtd);

		// Token: 0x060000A6 RID: 166
		void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

		// Token: 0x060000A7 RID: 167
		void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

		// Token: 0x060000A8 RID: 168
		void Throw(Exception e);
	}
}
