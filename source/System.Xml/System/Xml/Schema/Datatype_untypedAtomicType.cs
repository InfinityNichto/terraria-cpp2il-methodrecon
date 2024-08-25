using System;

namespace System.Xml.Schema
{
	// Token: 0x020000E3 RID: 227
	internal class Datatype_untypedAtomicType : Datatype_anyAtomicType
	{
		// Token: 0x060008A8 RID: 2216 RVA: 0x0001B084 File Offset: 0x00019284
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0001B098 File Offset: 0x00019298
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0001B0A8 File Offset: 0x000192A8
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.UntypedAtomic;
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0001B0B8 File Offset: 0x000192B8
		public Datatype_untypedAtomicType()
		{
		}
	}
}
