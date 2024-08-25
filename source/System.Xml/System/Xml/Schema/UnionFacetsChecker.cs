using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000129 RID: 297
	internal class UnionFacetsChecker : FacetsChecker
	{
		// Token: 0x06000A0D RID: 2573 RVA: 0x0001CD68 File Offset: 0x0001AF68
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
				return;
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0001CD7C File Offset: 0x0001AF7C
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
				return;
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0001CD94 File Offset: 0x0001AF94
		public UnionFacetsChecker()
		{
		}
	}
}
