using System;
using System.Runtime.InteropServices;

namespace System.Xml.Schema
{
	// Token: 0x02000104 RID: 260
	internal class Datatype_NCName : Datatype_Name
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0001BC68 File Offset: 0x00019E68
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NCName;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0001BC78 File Offset: 0x00019E78
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, [Out] object typedValue)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0001BC8C File Offset: 0x00019E8C
		public Datatype_NCName()
		{
		}
	}
}
