using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000080 RID: 128
	public class XmlText : XmlCharacterData
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x000147D4 File Offset: 0x000129D4
		internal XmlText(string strData)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000147E4 File Offset: 0x000129E4
		protected internal XmlText(string strData, XmlDocument doc)
			: base(strData, doc)
		{
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string LocalName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000147FC File Offset: 0x000129FC
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Text;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001480C File Offset: 0x00012A0C
		public override XmlNode ParentNode
		{
			get
			{
				return this.parentNode;
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00003FFD File Offset: 0x000021FD
		public override XmlNode CloneNode(bool deep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00003FFD File Offset: 0x000021FD
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00014828 File Offset: 0x00012A28
		public override string Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				if (this.parentNode != null)
				{
				}
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00014840 File Offset: 0x00012A40
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}
	}
}
