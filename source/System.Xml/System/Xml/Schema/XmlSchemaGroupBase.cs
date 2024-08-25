using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000148 RID: 328
	public abstract class XmlSchemaGroupBase : XmlSchemaParticle
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000AE7 RID: 2791
		[XmlIgnore]
		public abstract XmlSchemaObjectCollection Items { get; }

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0001E4B8 File Offset: 0x0001C6B8
		protected XmlSchemaGroupBase()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
