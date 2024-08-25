using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000110 RID: 272
	internal interface IXmlDocumentType : IXmlNode
	{
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AAF RID: 2735
		string Name { get; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000AB0 RID: 2736
		string System { get; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000AB1 RID: 2737
		string Public { get; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000AB2 RID: 2738
		string InternalSubset { get; }
	}
}
