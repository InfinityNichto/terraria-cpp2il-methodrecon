using System;

namespace System.Xml.Schema
{
	// Token: 0x0200014A RID: 330
	public class XmlSchemaInfo : IXmlSchemaInfo
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x0001E4D0 File Offset: 0x0001C6D0
		public XmlSchemaInfo()
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001E4E4 File Offset: 0x0001C6E4
		internal XmlSchemaInfo(XmlSchemaValidity validity)
		{
			this.validity = validity;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0001E500 File Offset: 0x0001C700
		public XmlSchemaValidity Validity
		{
			get
			{
				return this.validity;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0001E514 File Offset: 0x0001C714
		public bool IsDefault
		{
			get
			{
				return this.isDefault;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0001E528 File Offset: 0x0001C728
		public bool IsNil
		{
			get
			{
				return this.isNil;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0001E53C File Offset: 0x0001C73C
		public XmlSchemaSimpleType MemberType
		{
			get
			{
				return this.memberType;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0001E550 File Offset: 0x0001C750
		public XmlSchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0001E564 File Offset: 0x0001C764
		public XmlSchemaElement SchemaElement
		{
			get
			{
				return this.schemaElement;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0001E578 File Offset: 0x0001C778
		public XmlSchemaAttribute SchemaAttribute
		{
			get
			{
				return this.schemaAttribute;
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0001E58C File Offset: 0x0001C78C
		internal void Clear()
		{
		}

		// Token: 0x04000598 RID: 1432
		private bool isDefault;

		// Token: 0x04000599 RID: 1433
		private bool isNil;

		// Token: 0x0400059A RID: 1434
		private XmlSchemaElement schemaElement;

		// Token: 0x0400059B RID: 1435
		private XmlSchemaAttribute schemaAttribute;

		// Token: 0x0400059C RID: 1436
		private XmlSchemaType schemaType;

		// Token: 0x0400059D RID: 1437
		private XmlSchemaSimpleType memberType;

		// Token: 0x0400059E RID: 1438
		private XmlSchemaValidity validity;

		// Token: 0x0400059F RID: 1439
		private XmlSchemaContentType contentType;
	}
}
