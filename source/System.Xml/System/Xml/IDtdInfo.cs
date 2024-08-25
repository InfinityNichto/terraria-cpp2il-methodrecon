using System;

namespace System.Xml
{
	// Token: 0x02000016 RID: 22
	internal interface IDtdInfo
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600006E RID: 110
		XmlQualifiedName Name { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600006F RID: 111
		string InternalDtdSubset { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000070 RID: 112
		bool HasDefaultAttributes { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000071 RID: 113
		bool HasNonCDataAttributes { get; }

		// Token: 0x06000072 RID: 114
		IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

		// Token: 0x06000073 RID: 115
		IDtdEntityInfo LookupEntity(string name);
	}
}
