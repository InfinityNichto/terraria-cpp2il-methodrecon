using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x0200014D RID: 333
	public abstract class XmlSchemaParticle : XmlSchemaAnnotated
	{
		// Token: 0x17000328 RID: 808
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x0001E670 File Offset: 0x0001C870
		[XmlIgnore]
		public decimal MinOccurs
		{
			set
			{
				if (!true)
				{
				}
				bool flag = value < value;
				if (!true)
				{
				}
				decimal num = decimal.Truncate(value);
				bool flag2 = value != value;
				XmlSchemaParticle.Occurs occurs = this.flags;
				this.minOccurs = value;
				this.flags = occurs;
			}
		}

		// Token: 0x17000329 RID: 809
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x0001E6B0 File Offset: 0x0001C8B0
		[XmlIgnore]
		public decimal MaxOccurs
		{
			set
			{
				if (!true)
				{
				}
				bool flag = value < value;
				if (!true)
				{
				}
				decimal num = decimal.Truncate(value);
				bool flag2 = value != value;
				this.maxOccurs = value;
				if (!true)
				{
				}
				bool flag3 = value == value;
				XmlSchemaParticle.Occurs occurs = this.flags;
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
		protected XmlSchemaParticle()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001E70C File Offset: 0x0001C90C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaParticle()
		{
		}

		// Token: 0x040005A1 RID: 1441
		private decimal minOccurs;

		// Token: 0x040005A2 RID: 1442
		private decimal maxOccurs;

		// Token: 0x040005A3 RID: 1443
		private XmlSchemaParticle.Occurs flags;

		// Token: 0x040005A4 RID: 1444
		internal static readonly XmlSchemaParticle Empty;

		// Token: 0x0200014E RID: 334
		[Flags]
		private enum Occurs
		{
			// Token: 0x040005A6 RID: 1446
			None = 0,
			// Token: 0x040005A7 RID: 1447
			Min = 1,
			// Token: 0x040005A8 RID: 1448
			Max = 2
		}

		// Token: 0x0200014F RID: 335
		private class EmptyParticle : XmlSchemaParticle
		{
			// Token: 0x06000B01 RID: 2817 RVA: 0x0001E71C File Offset: 0x0001C91C
			public EmptyParticle()
			{
				if (!true)
				{
				}
				base..ctor();
			}
		}
	}
}
