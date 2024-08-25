using System;

namespace System.Xml
{
	// Token: 0x02000026 RID: 38
	internal enum ElementProperties : uint
	{
		// Token: 0x0400005E RID: 94
		DEFAULT,
		// Token: 0x0400005F RID: 95
		URI_PARENT,
		// Token: 0x04000060 RID: 96
		BOOL_PARENT,
		// Token: 0x04000061 RID: 97
		NAME_PARENT = 4U,
		// Token: 0x04000062 RID: 98
		EMPTY = 8U,
		// Token: 0x04000063 RID: 99
		NO_ENTITIES = 16U,
		// Token: 0x04000064 RID: 100
		HEAD = 32U,
		// Token: 0x04000065 RID: 101
		BLOCK_WS = 64U,
		// Token: 0x04000066 RID: 102
		HAS_NS = 128U
	}
}
