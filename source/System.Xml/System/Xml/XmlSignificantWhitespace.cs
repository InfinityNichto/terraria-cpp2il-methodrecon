using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200007F RID: 127
	public class XmlSignificantWhitespace : XmlCharacterData
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x00014730 File Offset: 0x00012930
		protected internal XmlSignificantWhitespace(string strData, XmlDocument doc)
			: base(strData, doc)
		{
			if (!doc.isLoading)
			{
				bool flag = base.CheckOnData(strData);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string LocalName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00014760 File Offset: 0x00012960
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.SignificantWhitespace;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00014770 File Offset: 0x00012970
		public override XmlNode ParentNode
		{
			get
			{
				XmlNode parentNode = this.parentNode;
				return base.ParentNode;
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00003FFD File Offset: 0x000021FD
		public override XmlNode CloneNode(bool deep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00003FFD File Offset: 0x000021FD
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x000147A4 File Offset: 0x000129A4
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x000147C4 File Offset: 0x000129C4
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}
	}
}
