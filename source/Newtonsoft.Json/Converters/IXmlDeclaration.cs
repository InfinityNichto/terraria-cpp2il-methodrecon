using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010F RID: 271
	internal interface IXmlDeclaration : IXmlNode
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AAA RID: 2730
		string Version { get; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AAB RID: 2731
		// (set) Token: 0x06000AAC RID: 2732
		string Encoding { get; set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AAD RID: 2733
		// (set) Token: 0x06000AAE RID: 2734
		string Standalone { get; set; }
	}
}
