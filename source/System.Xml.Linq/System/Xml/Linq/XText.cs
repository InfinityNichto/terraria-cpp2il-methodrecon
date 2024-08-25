using System;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x0200001E RID: 30
	public class XText : XNode
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00003C6C File Offset: 0x00001E6C
		public XText(string value)
		{
			do
			{
				base..ctor();
			}
			while (value == null);
			this.text = value;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003C8C File Offset: 0x00001E8C
		public XText(XText other)
		{
			do
			{
				base..ctor();
			}
			while (other == null);
			string text = other.text;
			this.text = text;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Text;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003CC0 File Offset: 0x00001EC0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public string Value
		{
			get
			{
				return this.text;
			}
			set
			{
				while (value == null)
				{
				}
				if (!true)
				{
				}
				this.text = value;
				if (!true)
				{
				}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public override void WriteTo(XmlWriter writer)
		{
			while (writer == null)
			{
			}
			if (this.parent != null)
			{
			}
			string text = this.text;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003D1C File Offset: 0x00001F1C
		internal override void AppendText(StringBuilder sb)
		{
			string text = this.text;
			StringBuilder stringBuilder = sb.Append(text);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002367 File Offset: 0x00000567
		internal override XNode CloneNode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400004E RID: 78
		internal string text;
	}
}
