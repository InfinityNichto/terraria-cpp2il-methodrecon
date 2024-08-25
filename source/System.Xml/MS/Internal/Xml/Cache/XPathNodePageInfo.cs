using System;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000174 RID: 372
	internal sealed class XPathNodePageInfo
	{
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00021B20 File Offset: 0x0001FD20
		public int PageNumber
		{
			get
			{
				return this._pageNum;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00021B34 File Offset: 0x0001FD34
		public int NodeCount
		{
			get
			{
				return this._nodeCount;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00021B48 File Offset: 0x0001FD48
		public XPathNode[] NextPage
		{
			get
			{
				return this._pageNext;
			}
		}

		// Token: 0x04000693 RID: 1683
		private int _pageNum;

		// Token: 0x04000694 RID: 1684
		private int _nodeCount;

		// Token: 0x04000695 RID: 1685
		private XPathNode[] _pageNext;
	}
}
