using System;
using Cpp2IlInjected;

// Token: 0x02000010 RID: 16
public struct FloatArray_3
{
	// Token: 0x17000019 RID: 25
	public float this[int index]
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600004E RID: 78 RVA: 0x00002840 File Offset: 0x00000A40
	public int Length
	{
		get
		{
			return 3;
		}
	}

	// Token: 0x04000023 RID: 35
	private float val0;

	// Token: 0x04000024 RID: 36
	private float val1;

	// Token: 0x04000025 RID: 37
	private float val2;
}
