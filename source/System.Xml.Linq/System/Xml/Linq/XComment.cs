using System;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x02000005 RID: 5
	public class XComment : XNode
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002374 File Offset: 0x00000574
		public XComment(string value)
		{
			do
			{
				base..ctor();
			}
			while (value == null);
			this.value = value;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002394 File Offset: 0x00000594
		public XComment(XComment other)
		{
			do
			{
				base..ctor();
			}
			while (other == null);
			string text = other.value;
			this.value = text;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000023B8 File Offset: 0x000005B8
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Comment;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000023C8 File Offset: 0x000005C8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000023DC File Offset: 0x000005DC
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				while (value == null)
				{
				}
				if (!true)
				{
				}
				this.value = value;
				if (!true)
				{
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023FC File Offset: 0x000005FC
		public override void WriteTo(XmlWriter writer)
		{
			while (writer == null)
			{
			}
			string text = this.value;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002367 File Offset: 0x00000567
		internal override XNode CloneNode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000004 RID: 4
		internal string value;
	}
}
