using System;
using System.Runtime.InteropServices;

namespace System.Xml.Schema
{
	// Token: 0x02000109 RID: 265
	internal class Datatype_integer : Datatype_decimal
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0001BDFC File Offset: 0x00019FFC
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Integer;
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0001BE0C File Offset: 0x0001A00C
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, [Out] object typedValue)
		{
			Exception ex;
			while (this != null || ex != null || this != null)
			{
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0001BE24 File Offset: 0x0001A024
		public Datatype_integer()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
