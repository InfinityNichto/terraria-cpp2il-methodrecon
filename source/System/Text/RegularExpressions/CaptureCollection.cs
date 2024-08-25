using System;
using System.Diagnostics;
using System.Reflection;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000A5 RID: 165
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
	[DefaultMember("Item")]
	[DebuggerDisplay("Count = {Count}")]
	public class CaptureCollection
	{
		// Token: 0x04000283 RID: 643
		private readonly Group _group;

		// Token: 0x04000284 RID: 644
		private readonly int _capcount;

		// Token: 0x04000285 RID: 645
		private Capture[] _captures;
	}
}
