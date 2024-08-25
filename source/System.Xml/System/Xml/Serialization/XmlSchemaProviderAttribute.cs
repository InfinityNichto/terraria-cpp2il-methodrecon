using System;

namespace System.Xml.Serialization
{
	// Token: 0x020000BF RID: 191
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class XmlSchemaProviderAttribute : Attribute
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x00019B50 File Offset: 0x00017D50
		public XmlSchemaProviderAttribute(string methodName)
		{
			this._methodName = methodName;
		}

		// Token: 0x170001ED RID: 493
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00019B6C File Offset: 0x00017D6C
		public bool IsAny
		{
			set
			{
			}
		}

		// Token: 0x0400040D RID: 1037
		private string _methodName;

		// Token: 0x0400040E RID: 1038
		private bool _isAny;
	}
}
