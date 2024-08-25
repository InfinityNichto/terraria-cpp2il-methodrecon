using System;

namespace System.Xml
{
	// Token: 0x02000081 RID: 129
	internal class XmlUnspecifiedAttribute : XmlAttribute
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00014850 File Offset: 0x00012A50
		protected internal XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
			: base(prefix, localName, namespaceURI, doc)
		{
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00014868 File Offset: 0x00012A68
		public override bool Specified
		{
			get
			{
				return this.fSpecified;
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001487C File Offset: 0x00012A7C
		public override XmlNode CloneNode(bool deep)
		{
			int num = 1;
			this.fSpecified = num != 0;
			throw new InvalidCastException();
		}

		// Token: 0x170001A6 RID: 422
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00014898 File Offset: 0x00012A98
		public override string InnerText
		{
			set
			{
				base.InnerText = value;
				this.fSpecified = true;
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000148B4 File Offset: 0x00012AB4
		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			XmlNode xmlNode = base.RemoveChild(oldChild);
			this.fSpecified = true;
			return xmlNode;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000148D4 File Offset: 0x00012AD4
		public override XmlNode AppendChild(XmlNode newChild)
		{
			XmlNode xmlNode = base.AppendChild(newChild);
			this.fSpecified = true;
			return xmlNode;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000148F4 File Offset: 0x00012AF4
		internal void SetSpecified(bool f)
		{
		}

		// Token: 0x040002FE RID: 766
		private bool fSpecified;
	}
}
