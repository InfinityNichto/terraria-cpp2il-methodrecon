using System;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000162 RID: 354
	internal class XmlMiscConverter : XmlBaseConverter
	{
		// Token: 0x06000C12 RID: 3090 RVA: 0x0001FD28 File Offset: 0x0001DF28
		protected XmlMiscConverter(XmlSchemaType schemaType)
		{
			if (!true)
			{
			}
			base..ctor(schemaType);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00003FFD File Offset: 0x000021FD
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0001FD40 File Offset: 0x0001DF40
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			if (value == null)
			{
				throw new InvalidCastException();
			}
			Type type = value.GetType();
			if (this.typeCode == XmlTypeCode.None)
			{
			}
			if (value != null)
			{
				string text;
				return text;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
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
				XmlTypeCode typeCode = this.typeCode;
				if (typeCode == XmlTypeCode.None)
				{
				}
				byte[] array = XmlBaseConverter.StringToBase64Binary(value);
				if (typeCode == XmlTypeCode.None)
				{
				}
				XmlTypeCode typeCode2 = this.typeCode;
				if (typeCode2 == XmlTypeCode.None)
				{
				}
				XmlQualifiedName xmlQualifiedName = XmlBaseConverter.StringToQName(value, nsResolver);
				if (typeCode2 == XmlTypeCode.None)
				{
				}
				XmlTypeCode typeCode3 = this.typeCode;
				if (typeCode3 == XmlTypeCode.None)
				{
				}
				TimeSpan timeSpan = XmlBaseConverter.StringToDayTimeDuration(value);
				if (typeCode3 == XmlTypeCode.None)
				{
				}
				byte[] array2 = XmlBaseConverter.StringToHexBinary(value);
				if (typeCode3 == XmlTypeCode.None)
				{
				}
				XmlTypeCode typeCode4 = this.typeCode;
				Uri uri = XmlConvert.ToUri(value);
				XmlSchemaType schemaType = this.schemaType;
				object obj;
				return obj;
			}
			return "value";
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0001FE40 File Offset: 0x0001E040
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			int num = 1;
			if (value == null)
			{
				return "value";
			}
			if (num == 0)
			{
			}
			Type type = value.GetType();
			Type clrTypeDefault = this.clrTypeDefault;
			XmlTypeCode typeCode = this.typeCode;
			if (value == null)
			{
				throw new InvalidCastException();
			}
			bool flag = clrTypeDefault == clrTypeDefault;
			bool flag2 = type == clrTypeDefault;
			throw new InvalidCastException();
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0001FEA0 File Offset: 0x0001E0A0
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			Type type = value.GetType();
			if (value != null)
			{
			}
			return value;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (!true)
			{
			}
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}
	}
}
