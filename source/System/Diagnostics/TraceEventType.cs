using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	// Token: 0x020000CD RID: 205
	public enum TraceEventType
	{
		// Token: 0x0400039B RID: 923
		Critical = 1,
		// Token: 0x0400039C RID: 924
		Error,
		// Token: 0x0400039D RID: 925
		Warning = 4,
		// Token: 0x0400039E RID: 926
		Information = 8,
		// Token: 0x0400039F RID: 927
		Verbose = 16,
		// Token: 0x040003A0 RID: 928
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Start = 256,
		// Token: 0x040003A1 RID: 929
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Stop = 512,
		// Token: 0x040003A2 RID: 930
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Suspend = 1024,
		// Token: 0x040003A3 RID: 931
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Resume = 2048,
		// Token: 0x040003A4 RID: 932
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Transfer = 4096
	}
}
