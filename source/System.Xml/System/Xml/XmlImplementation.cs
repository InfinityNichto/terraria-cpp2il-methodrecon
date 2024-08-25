using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000071 RID: 113
	public class XmlImplementation
	{
		// Token: 0x0600056E RID: 1390 RVA: 0x00012F58 File Offset: 0x00011158
		public XmlImplementation()
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00012F6C File Offset: 0x0001116C
		public XmlImplementation(XmlNameTable nt)
		{
			this.nameTable = nt;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlDocument CreateDocument()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00012F88 File Offset: 0x00011188
		internal XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x040002DD RID: 733
		private XmlNameTable nameTable;
	}
}
