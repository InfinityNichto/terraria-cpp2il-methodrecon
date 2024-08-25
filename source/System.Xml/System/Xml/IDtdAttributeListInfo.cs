using System;
using System.Collections.Generic;

namespace System.Xml
{
	// Token: 0x02000017 RID: 23
	internal interface IDtdAttributeListInfo
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000074 RID: 116
		bool HasNonCDataAttributes { get; }

		// Token: 0x06000075 RID: 117
		IDtdAttributeInfo LookupAttribute(string prefix, string localName);

		// Token: 0x06000076 RID: 118
		IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
	}
}
