using System;
using System.Text;

namespace System.Xml
{
	// Token: 0x02000037 RID: 55
	public class XmlParserContext
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00006A40 File Offset: 0x00004C40
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00006A50 File Offset: 0x00004C50
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
		{
			if (nsMgr == null || nt != null)
			{
			}
			if (docTypeName == null)
			{
			}
			if (pubId == null)
			{
			}
			if (sysId == null)
			{
			}
			if (internalSubset == null)
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00006A78 File Offset: 0x00004C78
		public XmlNameTable NameTable
		{
			get
			{
				return this._nt;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00006A8C File Offset: 0x00004C8C
		public XmlNamespaceManager NamespaceManager
		{
			get
			{
				return this._nsMgr;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00006AA0 File Offset: 0x00004CA0
		public string DocTypeName
		{
			get
			{
				return this._docTypeName;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00006AB4 File Offset: 0x00004CB4
		public string PublicId
		{
			get
			{
				return this._pubId;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00006AC8 File Offset: 0x00004CC8
		public string SystemId
		{
			get
			{
				return this._sysId;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00006ADC File Offset: 0x00004CDC
		public string BaseURI
		{
			get
			{
				return this._baseURI;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00006AF0 File Offset: 0x00004CF0
		public string InternalSubset
		{
			get
			{
				return this._internalSubset;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00006B04 File Offset: 0x00004D04
		public string XmlLang
		{
			get
			{
				return this._xmlLang;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00006B18 File Offset: 0x00004D18
		public XmlSpace XmlSpace
		{
			get
			{
				return this._xmlSpace;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00006B2C File Offset: 0x00004D2C
		public Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00006B40 File Offset: 0x00004D40
		internal bool HasDtdInfo
		{
			get
			{
				string internalSubset = this._internalSubset;
				string pubId = this._pubId;
				return true;
			}
		}

		// Token: 0x040000D3 RID: 211
		private XmlNameTable _nt;

		// Token: 0x040000D4 RID: 212
		private XmlNamespaceManager _nsMgr;

		// Token: 0x040000D5 RID: 213
		private string _docTypeName;

		// Token: 0x040000D6 RID: 214
		private string _pubId;

		// Token: 0x040000D7 RID: 215
		private string _sysId;

		// Token: 0x040000D8 RID: 216
		private string _internalSubset;

		// Token: 0x040000D9 RID: 217
		private string _xmlLang;

		// Token: 0x040000DA RID: 218
		private XmlSpace _xmlSpace;

		// Token: 0x040000DB RID: 219
		private string _baseURI;

		// Token: 0x040000DC RID: 220
		private Encoding _encoding;
	}
}
