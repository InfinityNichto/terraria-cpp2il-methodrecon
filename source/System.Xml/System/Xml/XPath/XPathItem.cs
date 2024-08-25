using System;
using System.Xml.Schema;
using Cpp2IlInjected;

namespace System.Xml.XPath
{
	// Token: 0x020000B5 RID: 181
	public abstract class XPathItem
	{
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007C7 RID: 1991
		public abstract XmlSchemaType XmlType { get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007C8 RID: 1992
		public abstract string Value { get; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007C9 RID: 1993
		public abstract object TypedValue { get; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007CA RID: 1994
		public abstract Type ValueType { get; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007CB RID: 1995
		public abstract bool ValueAsBoolean { get; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007CC RID: 1996
		public abstract DateTime ValueAsDateTime { get; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007CD RID: 1997
		public abstract double ValueAsDouble { get; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007CE RID: 1998
		public abstract int ValueAsInt { get; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007CF RID: 1999
		public abstract long ValueAsLong { get; }

		// Token: 0x060007D0 RID: 2000 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual object ValueAs(Type returnType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007D1 RID: 2001
		public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

		// Token: 0x060007D2 RID: 2002 RVA: 0x000198C8 File Offset: 0x00017AC8
		protected XPathItem()
		{
		}
	}
}
