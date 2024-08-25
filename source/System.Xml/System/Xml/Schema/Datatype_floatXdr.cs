using System;

namespace System.Xml.Schema
{
	// Token: 0x02000117 RID: 279
	internal class Datatype_floatXdr : Datatype_float
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x0001C460 File Offset: 0x0001A660
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			if (!true)
			{
			}
			float num = XmlConvert.ToSingle(s);
			if (!true)
			{
			}
			if (!true)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0001C490 File Offset: 0x0001A690
		public Datatype_floatXdr()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
