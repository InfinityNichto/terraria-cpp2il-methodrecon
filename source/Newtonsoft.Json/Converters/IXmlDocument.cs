using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010E RID: 270
	internal interface IXmlDocument : IXmlNode
	{
		// Token: 0x06000A9D RID: 2717
		IXmlNode CreateComment(string text);

		// Token: 0x06000A9E RID: 2718
		IXmlNode CreateTextNode(string text);

		// Token: 0x06000A9F RID: 2719
		IXmlNode CreateCDataSection(string data);

		// Token: 0x06000AA0 RID: 2720
		IXmlNode CreateWhitespace(string text);

		// Token: 0x06000AA1 RID: 2721
		IXmlNode CreateSignificantWhitespace(string text);

		// Token: 0x06000AA2 RID: 2722
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		// Token: 0x06000AA3 RID: 2723
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

		// Token: 0x06000AA4 RID: 2724
		IXmlNode CreateProcessingInstruction(string target, string data);

		// Token: 0x06000AA5 RID: 2725
		IXmlElement CreateElement(string elementName);

		// Token: 0x06000AA6 RID: 2726
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x06000AA7 RID: 2727
		IXmlNode CreateAttribute(string name, string value);

		// Token: 0x06000AA8 RID: 2728
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000AA9 RID: 2729
		IXmlElement DocumentElement { get; }
	}
}
