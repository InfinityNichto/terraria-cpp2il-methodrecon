using System;
using Cpp2IlInjected;

// Token: 0x0200000F RID: 15
public struct FloatArray_2
{
	// Token: 0x17000017 RID: 23
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

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600004B RID: 75 RVA: 0x00002820 File Offset: 0x00000A20
	public int Length
	{
		get
		{
			return 2;
		}
	}

	// Token: 0x04000021 RID: 33
	private float val0;

	// Token: 0x04000022 RID: 34
	private float val1;
}
