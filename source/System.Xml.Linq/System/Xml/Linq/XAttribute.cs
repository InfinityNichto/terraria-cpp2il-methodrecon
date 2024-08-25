using System;
using System.Globalization;

namespace System.Xml.Linq
{
	// Token: 0x02000003 RID: 3
	public class XAttribute : XObject
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002070 File Offset: 0x00000270
		public XAttribute(XName name, object value)
		{
			do
			{
				base..ctor();
				if (name == null)
				{
					return;
				}
			}
			while (value == null);
			string stringValue = XContainer.GetStringValue(value);
			XAttribute.ValidateAttribute(name, stringValue);
			this.name = name;
			this.value = stringValue;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020A8 File Offset: 0x000002A8
		public XAttribute(XAttribute other)
		{
			do
			{
				base..ctor();
			}
			while (other == null);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020C0 File Offset: 0x000002C0
		public bool IsNamespaceDeclaration
		{
			get
			{
				if (this.name._ns._namespaceName._stringLength != 0)
				{
					return "xmlns" != null;
				}
				return "xmlns" == "xmlns";
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020FC File Offset: 0x000002FC
		public XName Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002110 File Offset: 0x00000310
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Attribute;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002120 File Offset: 0x00000320
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002134 File Offset: 0x00000334
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				while (value == null)
				{
				}
				XAttribute.ValidateAttribute(this.name, value);
				if (!true)
				{
				}
				this.value = value;
				if (!true)
				{
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00000360
		public override string ToString()
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			XNamespace ns = this.name._ns;
			string prefixOfNamespace = this.GetPrefixOfNamespace(ns);
			XName xname = this.name;
			string text = this.value;
			XNamespace ns2 = xname._ns;
			string localName = xname._localName;
			string namespaceName = ns2._namespaceName;
			XmlWriter xmlWriter;
			xmlWriter.WriteAttributeString(prefixOfNamespace, localName, namespaceName, text);
			long num = 0L;
			if (xmlWriter == null || ns2 != null)
			{
			}
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			long num2 = 0L;
			if (ns2 != null)
			{
			}
			if (num2 == 0L)
			{
				string text2;
				return text2;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002240 File Offset: 0x00000440
		internal string GetPrefixOfNamespace(XNamespace ns)
		{
			if (ns._namespaceName._stringLength != 0 && this.parent != null)
			{
				string text;
				return text;
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000226C File Offset: 0x0000046C
		private static void ValidateAttribute(XName name, string value)
		{
			if (name._ns._namespaceName._stringLength == 0)
			{
				bool flag = name._localName == "xmlns";
				bool flag2 = value == "http://www.w3.org/XML/1998/namespace";
				return;
			}
		}

		// Token: 0x04000001 RID: 1
		internal XAttribute next;

		// Token: 0x04000002 RID: 2
		internal XName name;

		// Token: 0x04000003 RID: 3
		internal string value;
	}
}
