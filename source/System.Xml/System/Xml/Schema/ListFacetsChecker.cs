using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000128 RID: 296
	internal class ListFacetsChecker : FacetsChecker
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x0001CD20 File Offset: 0x0001AF20
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			if (value != null)
			{
			}
			return "The actual length is less than the MinLength value.";
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0001CD3C File Offset: 0x0001AF3C
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
				return;
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0001CD54 File Offset: 0x0001AF54
		public ListFacetsChecker()
		{
		}
	}
}
