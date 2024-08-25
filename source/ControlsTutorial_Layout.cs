using System;
using Microsoft.Xna.Framework;

// Token: 0x020001CC RID: 460
public class ControlsTutorial_Layout : LayoutDefinition
{
	// Token: 0x06000BF5 RID: 3061 RVA: 0x0003BAC4 File Offset: 0x00039CC4
	private void Awake()
	{
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0003BAD4 File Offset: 0x00039CD4
	public ControlsTutorial_Layout()
	{
	}

	// Token: 0x04000FBC RID: 4028
	public static ControlsTutorial_Layout Instance;

	// Token: 0x04000FBD RID: 4029
	public float TooltipTime = 0f;

	// Token: 0x04000FBE RID: 4030
	public float TooltipFadeTime;

	// Token: 0x04000FBF RID: 4031
	public int MaximumTooltipWidth = 300;

	// Token: 0x04000FC0 RID: 4032
	public int InteractPriority;

	// Token: 0x04000FC1 RID: 4033
	public int AutoSelectPriority;

	// Token: 0x04000FC2 RID: 4034
	public int AutoFirePriority;

	// Token: 0x04000FC3 RID: 4035
	public int QuickHealPriority;

	// Token: 0x04000FC4 RID: 4036
	public int QuickManaPriority;

	// Token: 0x04000FC5 RID: 4037
	public int QuickBuffPriority;

	// Token: 0x04000FC6 RID: 4038
	public int InventoryTogglePriority;

	// Token: 0x04000FC7 RID: 4039
	public int ZoomOutPriority;

	// Token: 0x04000FC8 RID: 4040
	public int MovementAxisPriority;

	// Token: 0x04000FC9 RID: 4041
	public ControlAnchor.ControlId LeftAnchorControl;

	// Token: 0x04000FCA RID: 4042
	public LayoutCalculator.AnchorType LeftAnchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000FCB RID: 4043
	public Vector2 LeftLocation;

	// Token: 0x04000FCC RID: 4044
	public int FirePriority;

	// Token: 0x04000FCD RID: 4045
	public int TargetLockOnPriority;

	// Token: 0x04000FCE RID: 4046
	public int SmartCursorPriority;

	// Token: 0x04000FCF RID: 4047
	public int JumpPriority;

	// Token: 0x04000FD0 RID: 4048
	public int QuickMountPriority;

	// Token: 0x04000FD1 RID: 4049
	public int ZoomInPriority;

	// Token: 0x04000FD2 RID: 4050
	public int FireAxisPriority;

	// Token: 0x04000FD3 RID: 4051
	public int GrappleAxisPriority;

	// Token: 0x04000FD4 RID: 4052
	public int ProfileSwitchPriority;

	// Token: 0x04000FD5 RID: 4053
	public ControlAnchor.ControlId RightAnchorControl;

	// Token: 0x04000FD6 RID: 4054
	public LayoutCalculator.AnchorType RightAnchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000FD7 RID: 4055
	public Vector2 RightLocation;

	// Token: 0x04000FD8 RID: 4056
	public TransactionButton_Layout TutorialButton;

	// Token: 0x04000FD9 RID: 4057
	public TransactionButton_Layout TutorialButtonOpen;

	// Token: 0x04000FDA RID: 4058
	public ControlAnchor.ControlId ToggleAnchorControl;

	// Token: 0x04000FDB RID: 4059
	public LayoutCalculator.AnchorType ToggleAnchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000FDC RID: 4060
	public Vector2 ToggleLocation;

	// Token: 0x04000FDD RID: 4061
	public String_Layout TitleFormat;

	// Token: 0x04000FDE RID: 4062
	public ControlAnchor.ControlId MenuAnchorControl;

	// Token: 0x04000FDF RID: 4063
	public LayoutCalculator.AnchorType MenuAnchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000FE0 RID: 4064
	public Vector2 MenuLocation;

	// Token: 0x04000FE1 RID: 4065
	public Vector2 MenuTopLocation;

	// Token: 0x04000FE2 RID: 4066
	public Vector2 MenuBottomLocation;
}
