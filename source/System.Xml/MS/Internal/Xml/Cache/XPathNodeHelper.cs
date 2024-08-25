using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000173 RID: 371
	internal abstract class XPathNodeHelper
	{
		// Token: 0x06000CC4 RID: 3268 RVA: 0x00021AB8 File Offset: 0x0001FCB8
		public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, [Out] XPathNode[] pageNmsp)
		{
			int num;
			return num;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, [Out] XPathNode[] pageNmsp)
		{
			if (pageElem != null)
			{
				int num;
				return num;
			}
			int num2;
			return num2;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		public static bool GetParent(XPathNode[] pageNode, int idxNode)
		{
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00003FFD File Offset: 0x000021FD
		public static int GetLocation(XPathNode[] pageNode, int idxNode)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00021AF0 File Offset: 0x0001FCF0
		public static bool GetTextFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00021B10 File Offset: 0x0001FD10
		public static bool GetNonDescendant(XPathNode[] pageNode, int idxNode)
		{
		}
	}
}
