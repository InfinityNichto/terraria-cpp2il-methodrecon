using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000123 RID: 291
	internal class DateTimeFacetsChecker : FacetsChecker
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x00003FFD File Offset: 0x000021FD
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0001CAE0 File Offset: 0x0001ACE0
		internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0001CB08 File Offset: 0x0001AD08
		private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0001CB24 File Offset: 0x0001AD24
		public DateTimeFacetsChecker()
		{
		}
	}
}
