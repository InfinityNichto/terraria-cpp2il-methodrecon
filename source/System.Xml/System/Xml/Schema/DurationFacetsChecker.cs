using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000122 RID: 290
	internal class DurationFacetsChecker : FacetsChecker
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x0001CA70 File Offset: 0x0001AC70
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0001CA84 File Offset: 0x0001AC84
		internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0001CA9C File Offset: 0x0001AC9C
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
		private bool MatchEnumeration(TimeSpan value, ArrayList enumeration)
		{
			int num;
			if (num != 0)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0001CACC File Offset: 0x0001ACCC
		public DurationFacetsChecker()
		{
		}
	}
}
