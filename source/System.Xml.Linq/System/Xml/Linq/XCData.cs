using System;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x02000004 RID: 4
	public class XCData : XText
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002318 File Offset: 0x00000518
		public XCData(string value)
			: base(value)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000232C File Offset: 0x0000052C
		public XCData(XCData other)
			: base(other)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002340 File Offset: 0x00000540
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.CDATA;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002350 File Offset: 0x00000550
		public override void WriteTo(XmlWriter writer)
		{
			while (writer == null)
			{
			}
			string text = this.text;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002367 File Offset: 0x00000567
		internal override XNode CloneNode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
