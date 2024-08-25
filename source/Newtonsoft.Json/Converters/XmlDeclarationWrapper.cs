using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010B RID: 267
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x06000A85 RID: 2693 RVA: 0x00019C54 File Offset: 0x00017E54
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
			this._node = declaration;
			this._declaration = declaration;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00019C78 File Offset: 0x00017E78
		public string Version
		{
			get
			{
				return this._declaration.version;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00019C90 File Offset: 0x00017E90
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00019CA8 File Offset: 0x00017EA8
		public string Encoding
		{
			get
			{
				return this._declaration.encoding;
			}
			set
			{
				this._declaration.Encoding = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00019CC4 File Offset: 0x00017EC4
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00019CDC File Offset: 0x00017EDC
		public string Standalone
		{
			get
			{
				return this._declaration.standalone;
			}
			set
			{
				this._declaration.Standalone = value;
			}
		}

		// Token: 0x0400040F RID: 1039
		private readonly XmlDeclaration _declaration;
	}
}
