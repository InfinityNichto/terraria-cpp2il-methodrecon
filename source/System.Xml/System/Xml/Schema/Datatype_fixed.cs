using System;
using System.Runtime.InteropServices;

namespace System.Xml.Schema
{
	// Token: 0x0200011B RID: 283
	internal class Datatype_fixed : Datatype_decimal
	{
		// Token: 0x060009BD RID: 2493 RVA: 0x0001C5EC File Offset: 0x0001A7EC
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			decimal num = XmlConvert.ToDecimal(s);
			Exception ex;
			if (ex == null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0001C61C File Offset: 0x0001A81C
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, [Out] object typedValue)
		{
			for (;;)
			{
				if (!true)
				{
				}
				Exception ex;
				Exception ex2;
				if (ex == null && ex2 == null)
				{
					return;
				}
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0001C634 File Offset: 0x0001A834
		public Datatype_fixed()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
