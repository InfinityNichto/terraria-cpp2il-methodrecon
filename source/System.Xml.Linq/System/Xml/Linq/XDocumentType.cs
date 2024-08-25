using System;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x0200000A RID: 10
	public class XDocumentType : XNode
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002BF8 File Offset: 0x00000DF8
		public XDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			if (!true)
			{
			}
			string text = XmlConvert.VerifyName(name);
			this._name = text;
			this._publicId = publicId;
			this._systemId = systemId;
			this._internalSubset = internalSubset;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002C34 File Offset: 0x00000E34
		public XDocumentType(XDocumentType other)
		{
			do
			{
				base..ctor();
			}
			while (other == null);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002C4C File Offset: 0x00000E4C
		public string InternalSubset
		{
			get
			{
				return this._internalSubset;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002C60 File Offset: 0x00000E60
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002C74 File Offset: 0x00000E74
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.DocumentType;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002C84 File Offset: 0x00000E84
		public string PublicId
		{
			get
			{
				return this._publicId;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002C98 File Offset: 0x00000E98
		public string SystemId
		{
			get
			{
				return this._systemId;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002CAC File Offset: 0x00000EAC
		public override void WriteTo(XmlWriter writer)
		{
			while (writer == null)
			{
			}
			string name = this._name;
			string publicId = this._publicId;
			string systemId = this._systemId;
			string internalSubset = this._internalSubset;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002367 File Offset: 0x00000567
		internal override XNode CloneNode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400000F RID: 15
		private string _name;

		// Token: 0x04000010 RID: 16
		private string _publicId;

		// Token: 0x04000011 RID: 17
		private string _systemId;

		// Token: 0x04000012 RID: 18
		private string _internalSubset;
	}
}
