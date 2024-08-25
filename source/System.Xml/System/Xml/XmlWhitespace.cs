using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000082 RID: 130
	public class XmlWhitespace : XmlCharacterData
	{
		// Token: 0x0600062A RID: 1578 RVA: 0x00014904 File Offset: 0x00012B04
		protected internal XmlWhitespace(string strData, XmlDocument doc)
			: base(strData, doc)
		{
			if (!doc.isLoading)
			{
				bool flag = base.CheckOnData(strData);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string LocalName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00014934 File Offset: 0x00012B34
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Whitespace;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00014944 File Offset: 0x00012B44
		public override XmlNode ParentNode
		{
			get
			{
				XmlNode parentNode = this.parentNode;
				return base.ParentNode;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00003FFD File Offset: 0x000021FD
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00014978 File Offset: 0x00012B78
		public override string Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				bool flag = base.CheckOnData(value);
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00003FFD File Offset: 0x000021FD
		public override XmlNode CloneNode(bool deep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00014998 File Offset: 0x00012B98
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}
	}
}
