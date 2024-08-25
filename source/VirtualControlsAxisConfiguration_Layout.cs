using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

// Token: 0x02000244 RID: 580
[JsonObject(MemberSerialization.Fields)]
[Serializable]
public class VirtualControlsAxisConfiguration_Layout
{
	// Token: 0x06000D2E RID: 3374 RVA: 0x0003F0FC File Offset: 0x0003D2FC
	public void Validate()
	{
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x000021DB File Offset: 0x000003DB
	public Axis_Layout GetStyle(VirtualControlsAxisConfiguration_Layout.Style stlyeIndex)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x0003F10C File Offset: 0x0003D30C
	public VirtualControlsAxisConfiguration_Layout()
	{
	}

	// Token: 0x0400180E RID: 6158
	public string Id;

	// Token: 0x0400180F RID: 6159
	public Axis_Layout BlueLayout;

	// Token: 0x04001810 RID: 6160
	public Axis_Layout GreenLayout;

	// Token: 0x04001811 RID: 6161
	public Axis_Layout BadLayout;

	// Token: 0x04001812 RID: 6162
	public Axis_Layout ControlLayout;

	// Token: 0x02000245 RID: 581
	public enum Style
	{
		// Token: 0x04001814 RID: 6164
		Blue,
		// Token: 0x04001815 RID: 6165
		Green,
		// Token: 0x04001816 RID: 6166
		BadPosition
	}
}
