using System;
using System.Runtime.CompilerServices;

namespace System.Xml.Serialization
{
	// Token: 0x020000BA RID: 186
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	internal class XmlTypeConvertorAttribute : Attribute
	{
		// Token: 0x170001EC RID: 492
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00019AC0 File Offset: 0x00017CC0
		private string Method
		{
			[CompilerGenerated]
			set
			{
				this.<Method>k__BackingField = value;
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00019AD4 File Offset: 0x00017CD4
		public XmlTypeConvertorAttribute(string method)
		{
		}

		// Token: 0x04000407 RID: 1031
		[CompilerGenerated]
		private string <Method>k__BackingField;
	}
}
