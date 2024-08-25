using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000118 RID: 280
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0001A230 File Offset: 0x00018430
		private XProcessingInstruction ProcessingInstruction
		{
			get
			{
				if (this._xmlObject != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0001A24C File Offset: 0x0001844C
		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
		{
			if (!true)
			{
			}
			base..ctor();
			this._xmlObject = processingInstruction;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0001A26C File Offset: 0x0001846C
		public override string LocalName
		{
			get
			{
				return this.ProcessingInstruction.target;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0001A284 File Offset: 0x00018484
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x0001A29C File Offset: 0x0001849C
		public override string Value
		{
			get
			{
				return this.ProcessingInstruction.data;
			}
			set
			{
				this.ProcessingInstruction.Data = value;
			}
		}
	}
}
