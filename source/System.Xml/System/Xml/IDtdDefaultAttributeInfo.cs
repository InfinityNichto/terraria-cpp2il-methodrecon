using System;

namespace System.Xml
{
	// Token: 0x02000019 RID: 25
	internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007E RID: 126
		string DefaultValueExpanded { get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007F RID: 127
		object DefaultValueTyped { get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000080 RID: 128
		int ValueLineNumber { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000081 RID: 129
		int ValueLinePosition { get; }
	}
}
