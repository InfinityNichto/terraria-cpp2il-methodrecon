using System;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x0200001C RID: 28
	public class XProcessingInstruction : XNode
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00003B80 File Offset: 0x00001D80
		public XProcessingInstruction(string target, string data)
		{
			do
			{
				base..ctor();
			}
			while (data == null);
			XProcessingInstruction.ValidateName(target);
			this.target = target;
			this.data = data;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003BAC File Offset: 0x00001DAC
		public XProcessingInstruction(XProcessingInstruction other)
		{
			do
			{
				base..ctor();
			}
			while (other == null);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003BC4 File Offset: 0x00001DC4
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00003BD8 File Offset: 0x00001DD8
		public string Data
		{
			get
			{
				return this.data;
			}
			set
			{
				while (value == null)
				{
				}
				if (!true)
				{
				}
				this.data = value;
				if (!true)
				{
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003BF8 File Offset: 0x00001DF8
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.ProcessingInstruction;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003C08 File Offset: 0x00001E08
		public string Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003C1C File Offset: 0x00001E1C
		public override void WriteTo(XmlWriter writer)
		{
			while (writer == null)
			{
			}
			string text = this.target;
			string text2 = this.data;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002367 File Offset: 0x00000567
		internal override XNode CloneNode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003C3C File Offset: 0x00001E3C
		private static void ValidateName(string name)
		{
			if (!true)
			{
			}
			string text = XmlConvert.VerifyNCName(name);
			bool flag = string.Equals(name, "xml", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0400004A RID: 74
		internal string target;

		// Token: 0x0400004B RID: 75
		internal string data;
	}
}
