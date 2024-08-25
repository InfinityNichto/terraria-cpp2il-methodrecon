using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000114 RID: 276
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x06000AC9 RID: 2761 RVA: 0x00019F54 File Offset: 0x00018154
		public XDocumentTypeWrapper(XDocumentType documentType)
		{
			if (!true)
			{
			}
			base..ctor();
			this._xmlObject = documentType;
			this._documentType = documentType;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00019F78 File Offset: 0x00018178
		public string Name
		{
			get
			{
				return this._documentType._name;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00019F90 File Offset: 0x00018190
		public string System
		{
			get
			{
				return this._documentType._systemId;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00019FA8 File Offset: 0x000181A8
		public string Public
		{
			get
			{
				return this._documentType._publicId;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00019FC0 File Offset: 0x000181C0
		public string InternalSubset
		{
			get
			{
				return this._documentType._internalSubset;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00019FD8 File Offset: 0x000181D8
		public override string LocalName
		{
			get
			{
				return "DOCTYPE";
			}
		}

		// Token: 0x04000415 RID: 1045
		private readonly XDocumentType _documentType;
	}
}
