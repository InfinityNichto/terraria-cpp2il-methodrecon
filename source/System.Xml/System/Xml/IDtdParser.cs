using System;

namespace System.Xml
{
	// Token: 0x0200001B RID: 27
	internal interface IDtdParser
	{
		// Token: 0x0600008E RID: 142
		IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

		// Token: 0x0600008F RID: 143
		IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
	}
}
