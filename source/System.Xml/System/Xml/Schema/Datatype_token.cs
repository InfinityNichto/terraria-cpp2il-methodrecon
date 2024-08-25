using System;

namespace System.Xml.Schema
{
	// Token: 0x020000FF RID: 255
	internal class Datatype_token : Datatype_normalizedString
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0001BB94 File Offset: 0x00019D94
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Token;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0001BBB4 File Offset: 0x00019DB4
		public Datatype_token()
		{
		}
	}
}
