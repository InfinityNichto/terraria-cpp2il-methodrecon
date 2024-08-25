using System;

namespace ReLogic.OS
{
	// Token: 0x02000B1F RID: 2847
	public interface IClipboard
	{
		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06005343 RID: 21315
		// (set) Token: 0x06005344 RID: 21316
		string Value { get; set; }

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06005345 RID: 21317
		string MultiLineValue { get; }
	}
}
