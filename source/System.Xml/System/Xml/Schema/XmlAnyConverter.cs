using System;
using System.Xml.XPath;

namespace System.Xml.Schema
{
	// Token: 0x02000165 RID: 357
	internal class XmlAnyConverter : XmlBaseConverter
	{
		// Token: 0x06000C46 RID: 3142 RVA: 0x000204D8 File Offset: 0x0001E6D8
		protected XmlAnyConverter(XmlTypeCode typeCode)
		{
			if (!true)
			{
			}
			base..ctor(typeCode);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000204F0 File Offset: 0x0001E6F0
		public override bool ToBoolean(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0002050C File Offset: 0x0001E70C
		public override DateTime ToDateTime(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00020528 File Offset: 0x0001E728
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0002054C File Offset: 0x0001E74C
		public override decimal ToDecimal(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00020570 File Offset: 0x0001E770
		public override double ToDouble(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0002058C File Offset: 0x0001E78C
		public override int ToInt32(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000205A8 File Offset: 0x0001E7A8
		public override long ToInt64(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000205C4 File Offset: 0x0001E7C4
		public override float ToSingle(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000205E8 File Offset: 0x0001E7E8
		public override object ChangeType(bool value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			XmlSchemaSimpleType builtInSimpleType = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean);
			object obj;
			return obj;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00020610 File Offset: 0x0001E810
		public override object ChangeType(DateTime value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			if (!true)
			{
			}
			XmlSchemaSimpleType builtInSimpleType = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime);
			object obj;
			return obj;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00020638 File Offset: 0x0001E838
		public override object ChangeType(decimal value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			XmlSchemaSimpleType builtInSimpleType = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal);
			object obj;
			return obj;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00020660 File Offset: 0x0001E860
		public override object ChangeType(double value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			XmlSchemaSimpleType builtInSimpleType = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double);
			object obj;
			return obj;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00020688 File Offset: 0x0001E888
		public override object ChangeType(int value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			XmlSchemaSimpleType builtInSimpleType = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Int);
			object obj;
			return obj;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000206B0 File Offset: 0x0001E8B0
		public override object ChangeType(long value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			XmlSchemaSimpleType builtInSimpleType = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Long);
			object obj;
			return obj;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000206D8 File Offset: 0x0001E8D8
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				Type clrTypeDefault = this.clrTypeDefault;
				XmlSchemaSimpleType builtInSimpleType = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String);
				object obj;
				return obj;
			}
			return "value";
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00020708 File Offset: 0x0001E908
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			int num = 1;
			if (value != null)
			{
				if (num == 0)
				{
				}
				Type type = value.GetType();
				Type clrTypeDefault = this.clrTypeDefault;
				return value;
			}
			return "value";
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000207A4 File Offset: 0x0001E9A4
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			Type type = value.GetType();
			if (value != null)
			{
			}
			return value;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000207C4 File Offset: 0x0001E9C4
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000207DC File Offset: 0x0001E9DC
		private XPathNavigator ToNavigator(XPathNavigator nav)
		{
			XmlTypeCode typeCode = this.typeCode;
			return nav;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000207F4 File Offset: 0x0001E9F4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyConverter()
		{
		}

		// Token: 0x0400062B RID: 1579
		public static readonly XmlValueConverter Item;

		// Token: 0x0400062C RID: 1580
		public static readonly XmlValueConverter AnyAtomic;
	}
}
