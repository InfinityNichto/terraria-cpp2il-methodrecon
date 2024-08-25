using System;

namespace System.Xml.Schema
{
	// Token: 0x02000166 RID: 358
	internal class XmlAnyListConverter : XmlListConverter
	{
		// Token: 0x06000C5B RID: 3163 RVA: 0x00020804 File Offset: 0x0001EA04
		protected XmlAnyListConverter(XmlBaseConverter atomicConverter)
			: base(atomicConverter)
		{
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00020818 File Offset: 0x0001EA18
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				if (!true)
				{
				}
				if (value != null)
				{
					Type type = value.GetType();
					Type type2 = value.GetType();
				}
				if (value == null)
				{
					throw new ArrayTypeMismatchException();
				}
			}
			return "value";
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0002084C File Offset: 0x0001EA4C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyListConverter()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0400062D RID: 1581
		public static readonly XmlValueConverter ItemList;

		// Token: 0x0400062E RID: 1582
		public static readonly XmlValueConverter AnyAtomicList;
	}
}
