using System;

namespace System.Xml
{
	// Token: 0x02000018 RID: 24
	internal interface IDtdAttributeInfo
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000077 RID: 119
		string Prefix { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000078 RID: 120
		string LocalName { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000079 RID: 121
		int LineNumber { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007A RID: 122
		int LinePosition { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007B RID: 123
		bool IsNonCDataType { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600007C RID: 124
		bool IsDeclaredInExternal { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007D RID: 125
		bool IsXmlAttribute { get; }
	}
}
