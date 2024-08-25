using System;

namespace System.Xml.Schema
{
	// Token: 0x02000134 RID: 308
	internal sealed class SchemaNotation
	{
		// Token: 0x06000A96 RID: 2710 RVA: 0x0001D930 File Offset: 0x0001BB30
		internal SchemaNotation(XmlQualifiedName name)
		{
			this.name = name;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0001D94C File Offset: 0x0001BB4C
		internal XmlQualifiedName Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0001D960 File Offset: 0x0001BB60
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0001D974 File Offset: 0x0001BB74
		internal string SystemLiteral
		{
			get
			{
				return this.systemLiteral;
			}
			set
			{
				this.systemLiteral = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0001D988 File Offset: 0x0001BB88
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x0001D99C File Offset: 0x0001BB9C
		internal string Pubid
		{
			get
			{
				return this.pubid;
			}
			set
			{
				this.pubid = value;
			}
		}

		// Token: 0x04000559 RID: 1369
		private XmlQualifiedName name;

		// Token: 0x0400055A RID: 1370
		private string systemLiteral;

		// Token: 0x0400055B RID: 1371
		private string pubid;
	}
}
