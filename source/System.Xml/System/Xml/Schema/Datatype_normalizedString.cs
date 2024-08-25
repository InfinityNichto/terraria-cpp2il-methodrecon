using System;

namespace System.Xml.Schema
{
	// Token: 0x020000FD RID: 253
	internal class Datatype_normalizedString : Datatype_string
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0001BB3C File Offset: 0x00019D3C
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NormalizedString;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0001BB4C File Offset: 0x00019D4C
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Replace;
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001BB5C File Offset: 0x00019D5C
		public Datatype_normalizedString()
		{
		}
	}
}
