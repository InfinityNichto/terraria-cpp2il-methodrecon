using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000175 RID: 373
	internal sealed class XPathNodeInfoAtom
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00021B5C File Offset: 0x0001FD5C
		public XPathNodePageInfo PageInfo
		{
			get
			{
				return this._pageInfo;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00021B70 File Offset: 0x0001FD70
		public string LocalName
		{
			get
			{
				return this._localName;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00021B84 File Offset: 0x0001FD84
		public string NamespaceUri
		{
			get
			{
				return this._namespaceUri;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00021B98 File Offset: 0x0001FD98
		public string Prefix
		{
			get
			{
				return this._prefix;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00021BAC File Offset: 0x0001FDAC
		public XPathNode[] SiblingPage
		{
			get
			{
				return this._pageSibling;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00021BC0 File Offset: 0x0001FDC0
		public XPathNode[] ParentPage
		{
			get
			{
				return this._pageParent;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00021BD4 File Offset: 0x0001FDD4
		public XPathDocument Document
		{
			get
			{
				return this._doc;
			}
		}

		// Token: 0x04000696 RID: 1686
		private string _localName;

		// Token: 0x04000697 RID: 1687
		private string _namespaceUri;

		// Token: 0x04000698 RID: 1688
		private string _prefix;

		// Token: 0x04000699 RID: 1689
		private XPathNode[] _pageParent;

		// Token: 0x0400069A RID: 1690
		private XPathNode[] _pageSibling;

		// Token: 0x0400069B RID: 1691
		private XPathDocument _doc;

		// Token: 0x0400069C RID: 1692
		private XPathNodePageInfo _pageInfo;
	}
}
