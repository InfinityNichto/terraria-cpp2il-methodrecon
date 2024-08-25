using System;

namespace System.Xml.Schema
{
	// Token: 0x0200011D RID: 285
	internal sealed class DtdValidator : BaseValidator
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter)
		{
			if (attdef.defExpanded == null)
			{
			}
			XmlSchemaDatatype datatype = attdef.datatype;
			if (datatype != null)
			{
				if (datatype != null)
				{
				}
				return;
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0001C734 File Offset: 0x0001A934
		// Note: this type is marked as 'beforefieldinit'.
		static DtdValidator()
		{
		}

		// Token: 0x0400050D RID: 1293
		private static DtdValidator.NamespaceManager namespaceManager;

		// Token: 0x0200011E RID: 286
		private class NamespaceManager : XmlNamespaceManager
		{
			// Token: 0x060009C9 RID: 2505 RVA: 0x0001C744 File Offset: 0x0001A944
			public override string LookupNamespace(string prefix)
			{
				return prefix;
			}

			// Token: 0x060009CA RID: 2506 RVA: 0x0001C754 File Offset: 0x0001A954
			public NamespaceManager()
			{
			}
		}
	}
}
