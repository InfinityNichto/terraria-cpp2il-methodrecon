using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

// Token: 0x02000247 RID: 583
[JsonObject(MemberSerialization.Fields)]
[Serializable]
public class VirtualControlsButtonConfiguration_Layout
{
	// Token: 0x06000D32 RID: 3378 RVA: 0x0003F134 File Offset: 0x0003D334
	public void Validate()
	{
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x000021DB File Offset: 0x000003DB
	public QuickActionButton_Layout GetStyle(VirtualControlsButtonConfiguration_Layout.Style stlyeIndex)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x0003F144 File Offset: 0x0003D344
	public VirtualControlsButtonConfiguration_Layout()
	{
	}

	// Token: 0x04001819 RID: 6169
	public string Id;

	// Token: 0x0400181A RID: 6170
	public QuickActionButton_Layout BlueLayout;

	// Token: 0x0400181B RID: 6171
	public QuickActionButton_Layout GreenLayout;

	// Token: 0x0400181C RID: 6172
	public QuickActionButton_Layout TealLayout;

	// Token: 0x0400181D RID: 6173
	public QuickActionButton_Layout BadPositionLayout;

	// Token: 0x0400181E RID: 6174
	public QuickActionButton_Layout ControlLayout;

	// Token: 0x02000248 RID: 584
	public enum Style
	{
		// Token: 0x04001820 RID: 6176
		Blue,
		// Token: 0x04001821 RID: 6177
		Green,
		// Token: 0x04001822 RID: 6178
		Teal,
		// Token: 0x04001823 RID: 6179
		Bad
	}
}
