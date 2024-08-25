using System;

namespace System.Xml
{
	// Token: 0x02000084 RID: 132
	public interface IXmlNamespaceResolver
	{
		// Token: 0x06000637 RID: 1591
		string LookupNamespace(string prefix);

		// Token: 0x06000638 RID: 1592
		string LookupPrefix(string namespaceName);
	}
}
