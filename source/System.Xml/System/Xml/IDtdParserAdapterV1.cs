using System;

namespace System.Xml
{
	// Token: 0x0200001E RID: 30
	internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AB RID: 171
		bool V1CompatibilityMode { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AC RID: 172
		bool Normalization { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AD RID: 173
		bool Namespaces { get; }
	}
}
