using System;

namespace System.Xml.Schema
{
	// Token: 0x02000110 RID: 272
	internal class Datatype_nonNegativeInteger : Datatype_integer
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0001C124 File Offset: 0x0001A324
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

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0001C138 File Offset: 0x0001A338
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NonNegativeInteger;
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0001C148 File Offset: 0x0001A348
		public Datatype_nonNegativeInteger()
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0001C15C File Offset: 0x0001A35C
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_nonNegativeInteger()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040004F9 RID: 1273
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
