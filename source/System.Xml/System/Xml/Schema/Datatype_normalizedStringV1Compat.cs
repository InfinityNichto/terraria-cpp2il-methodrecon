using System;

namespace System.Xml.Schema
{
	// Token: 0x020000FE RID: 254
	internal class Datatype_normalizedStringV1Compat : Datatype_string
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0001BB70 File Offset: 0x00019D70
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NormalizedString;
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0001BB80 File Offset: 0x00019D80
		public Datatype_normalizedStringV1Compat()
		{
		}
	}
}
