using System;

namespace System.Xml.Linq
{
	// Token: 0x02000011 RID: 17
	internal struct ElementWriter
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000336C File Offset: 0x0000156C
		public ElementWriter(XmlWriter writer)
		{
			this._writer = writer;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003380 File Offset: 0x00001580
		public void WriteElement(XElement e)
		{
			this.PushAncestors(e);
			object content = e.parent.content;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000033AC File Offset: 0x000015AC
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			string text;
			if (ns._namespaceName._stringLength == 0)
			{
				return text;
			}
			if (text == null)
			{
				return text;
			}
			return "xml";
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000033D4 File Offset: 0x000015D4
		private void PushAncestors(XElement e)
		{
			if (e.parent == null)
			{
				return;
			}
			XAttribute lastAttr = e.lastAttr;
			while (lastAttr == null)
			{
			}
			XAttribute next = lastAttr.next;
			bool isNamespaceDeclaration = next.IsNamespaceDeclaration;
			if (next.name._ns._namespaceName._stringLength != 0)
			{
				return;
			}
			XNamespace xnamespace = XNamespace.Get(next.value);
			XAttribute lastAttr2 = e.lastAttr;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003430 File Offset: 0x00001630
		private void PushElement(XElement e)
		{
			NamespaceResolver resolver = this._resolver;
			this._writer = resolver;
			XAttribute lastAttr = e.lastAttr;
			if (lastAttr != null)
			{
				XAttribute next = lastAttr.next;
				bool isNamespaceDeclaration = next.IsNamespaceDeclaration;
				if (next.name._ns._namespaceName._stringLength != 0)
				{
					return;
				}
				XNamespace xnamespace = XNamespace.Get(next.value);
				XAttribute lastAttr2 = e.lastAttr;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003490 File Offset: 0x00001690
		private void WriteEndElement()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000034A0 File Offset: 0x000016A0
		private void WriteFullEndElement()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000034B0 File Offset: 0x000016B0
		private void WriteStartElement(XElement e)
		{
			this.PushElement(e);
			XNamespace ns = e.name._ns;
			string prefixOfNamespace = this.GetPrefixOfNamespace(ns, true);
			XName name = e.name;
			string namespaceName = ns._namespaceName;
			string localName = name._localName;
			XAttribute lastAttr = e.lastAttr;
			if (lastAttr != null)
			{
				XAttribute next = lastAttr.next;
				long num = 0L;
				XName name2 = next.name;
				XNamespace ns2 = name2._ns;
				string localName2 = name2._localName;
				string namespaceName2 = ns2._namespaceName;
				string prefixOfNamespace2 = this.GetPrefixOfNamespace(ns2, num != 0L);
				if (namespaceName2._stringLength == 0)
				{
					bool flag = localName2 == "xmlns";
				}
				string value = next.value;
				XAttribute lastAttr2 = e.lastAttr;
			}
		}

		// Token: 0x04000024 RID: 36
		private XmlWriter _writer;

		// Token: 0x04000025 RID: 37
		private NamespaceResolver _resolver;
	}
}
