using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003EF RID: 1007
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum StreamingContextStates
	{
		// Token: 0x04000FDD RID: 4061
		CrossProcess = 1,
		// Token: 0x04000FDE RID: 4062
		CrossMachine = 2,
		// Token: 0x04000FDF RID: 4063
		File = 4,
		// Token: 0x04000FE0 RID: 4064
		Persistence = 8,
		// Token: 0x04000FE1 RID: 4065
		Remoting = 16,
		// Token: 0x04000FE2 RID: 4066
		Other = 32,
		// Token: 0x04000FE3 RID: 4067
		Clone = 64,
		// Token: 0x04000FE4 RID: 4068
		CrossAppDomain = 128,
		// Token: 0x04000FE5 RID: 4069
		All = 255
	}
}
