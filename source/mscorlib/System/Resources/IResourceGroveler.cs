using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace System.Resources
{
	// Token: 0x020004B1 RID: 1201
	internal interface IResourceGroveler
	{
		// Token: 0x060022F3 RID: 8947
		ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, StackCrawlMark stackMark);
	}
}
