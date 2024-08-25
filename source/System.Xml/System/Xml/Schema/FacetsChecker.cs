using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200011F RID: 287
	internal abstract class FacetsChecker
	{
		// Token: 0x060009CB RID: 2507 RVA: 0x0001C768 File Offset: 0x0001A968
		internal virtual Exception CheckLexicalFacets(string parseString, XmlSchemaDatatype datatype)
		{
			this.CheckWhitespaceFacets(parseString, datatype);
			Exception ex;
			return ex;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0001C780 File Offset: 0x0001A980
		internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0001C790 File Offset: 0x0001A990
		internal virtual Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0001C7B0 File Offset: 0x0001A9B0
		internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
		internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0001C7E0 File Offset: 0x0001A9E0
		internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
		internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001C800 File Offset: 0x0001AA00
		internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001C810 File Offset: 0x0001AA10
		internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001C820 File Offset: 0x0001AA20
		internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0001C830 File Offset: 0x0001AA30
		internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0001C840 File Offset: 0x0001AA40
		internal void CheckWhitespaceFacets(string s, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
				return;
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0001C858 File Offset: 0x0001AA58
		internal Exception CheckPatternFacets(RestrictionFacets restriction, string value)
		{
			if (restriction != null)
			{
				RestrictionFlags flags = restriction.Flags;
				ArrayList patterns = restriction.Patterns;
				if (restriction.Patterns != null)
				{
				}
				ArrayList patterns2 = restriction.Patterns;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0001C890 File Offset: 0x0001AA90
		internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0001C8A0 File Offset: 0x0001AAA0
		internal static decimal Power(int x, int y)
		{
			if (!true)
			{
			}
			decimal num = x;
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		protected FacetsChecker()
		{
		}
	}
}
