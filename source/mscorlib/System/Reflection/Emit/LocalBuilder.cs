using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x02000521 RID: 1313
	[StructLayout(0)]
	public sealed class LocalBuilder : LocalVariableInfo
	{
		// Token: 0x04001516 RID: 5398
		private string name;

		// Token: 0x04001517 RID: 5399
		internal ILGenerator ilgen;

		// Token: 0x04001518 RID: 5400
		private int startOffset;

		// Token: 0x04001519 RID: 5401
		private int endOffset;
	}
}
