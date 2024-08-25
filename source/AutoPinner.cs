using System;
using System.Runtime.InteropServices;

// Token: 0x02000044 RID: 68
internal class AutoPinner : IDisposable
{
	// Token: 0x0600017A RID: 378 RVA: 0x000048C4 File Offset: 0x00002AC4
	public AutoPinner(object obj)
	{
		GCHandle gchandle = GCHandle.Alloc(obj, GCHandleType.Pinned);
		this._pinnedArray = gchandle;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x000048E8 File Offset: 0x00002AE8
	public static implicit operator IntPtr(AutoPinner ap)
	{
		IntPtr intPtr;
		return intPtr;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x000048F8 File Offset: 0x00002AF8
	public void Dispose()
	{
	}

	// Token: 0x04000112 RID: 274
	private GCHandle _pinnedArray;
}
