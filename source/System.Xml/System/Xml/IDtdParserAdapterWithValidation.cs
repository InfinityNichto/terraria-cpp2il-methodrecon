using System;

namespace System.Xml
{
	// Token: 0x0200001D RID: 29
	internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A9 RID: 169
		bool DtdValidation { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170
		IValidationEventHandling ValidationEventHandling { get; }
	}
}
