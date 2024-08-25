using System;

namespace System.Xml.Schema
{
	// Token: 0x02000116 RID: 278
	internal class Datatype_doubleXdr : Datatype_double
	{
		// Token: 0x060009AA RID: 2474 RVA: 0x0001C418 File Offset: 0x0001A618
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			if (!true)
			{
			}
			double num = XmlConvert.ToDouble(s);
			if (!true)
			{
			}
			if (!true)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0001C448 File Offset: 0x0001A648
		public Datatype_doubleXdr()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
