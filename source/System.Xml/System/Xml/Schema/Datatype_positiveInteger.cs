using System;

namespace System.Xml.Schema
{
	// Token: 0x02000115 RID: 277
	internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0001C3E8 File Offset: 0x0001A5E8
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.PositiveInteger;
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		public Datatype_positiveInteger()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0001C408 File Offset: 0x0001A608
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_positiveInteger()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000506 RID: 1286
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
