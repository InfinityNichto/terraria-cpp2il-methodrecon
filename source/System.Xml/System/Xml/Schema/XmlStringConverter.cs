using System;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000163 RID: 355
	internal class XmlStringConverter : XmlBaseConverter
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x0001FED8 File Offset: 0x0001E0D8
		protected XmlStringConverter(XmlSchemaType schemaType)
		{
			if (!true)
			{
			}
			base..ctor(schemaType);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00003FFD File Offset: 0x000021FD
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				Type type = value.GetType();
				if (this != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0001FF10 File Offset: 0x0001E110
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
				XmlSchemaType schemaType = this.schemaType;
			}
			return "value";
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0001FF3C File Offset: 0x0001E13C
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				if (!true)
				{
				}
				Type type = value.GetType();
				Type clrTypeDefault = this.clrTypeDefault;
				XmlSchemaType schemaType = this.schemaType;
			}
			return "value";
		}
	}
}
