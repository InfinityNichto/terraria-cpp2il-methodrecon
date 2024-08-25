using System;

// Token: 0x0200005E RID: 94
public class SimpleProfilerFrameData
{
	// Token: 0x060001FD RID: 509 RVA: 0x00005E68 File Offset: 0x00004068
	public SimpleProfilerFrameData(int size)
	{
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00005E7C File Offset: 0x0000407C
	public void Reset()
	{
		int[] callCount = this.CallCount;
		long[] exececutionTime = this.ExececutionTime;
	}

	// Token: 0x040001EE RID: 494
	public long Overheads;

	// Token: 0x040001EF RID: 495
	public long FrameTime;

	// Token: 0x040001F0 RID: 496
	public readonly int[] CallCount;

	// Token: 0x040001F1 RID: 497
	public readonly long[] ExececutionTime;
}
