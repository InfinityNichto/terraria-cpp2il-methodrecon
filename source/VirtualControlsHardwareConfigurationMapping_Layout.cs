using System;
using Microsoft.Xna.Framework;

// Token: 0x02000249 RID: 585
[Serializable]
public class VirtualControlsHardwareConfigurationMapping_Layout
{
	// Token: 0x06000D35 RID: 3381 RVA: 0x0003F158 File Offset: 0x0003D358
	public void Copy(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
		string slotId = other.SlotId;
		this.SlotId = slotId;
		VirtualControlsSlotTypeMapping_Layout style = other.Style;
		string controlTypeId = style.ControlTypeId;
		VirtualControlsSlotTypeMapping_Layout.SlotType controlType = style.ControlType;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = other.DefaultControl;
		this.DefaultControl = defaultControl;
		LayoutCalculator.AnchorType anchor = other.Anchor;
		this.Anchor = anchor;
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x0003F1A8 File Offset: 0x0003D3A8
	public bool IsSame(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
		string slotId = this.SlotId;
		string slotId2 = other.SlotId;
		bool flag = slotId != slotId2;
		VirtualControlsSlotTypeMapping_Layout style = this.Style;
		VirtualControlsSlotTypeMapping_Layout style2 = other.Style;
		string controlTypeId = style.ControlTypeId;
		string controlTypeId2 = style2.ControlTypeId;
		bool flag2 = controlTypeId != controlTypeId2;
		VirtualControlsSlotTypeMapping_Layout style3 = this.Style;
		VirtualControlsSlotTypeMapping_Layout style4 = other.Style;
		VirtualControlsSlotTypeMapping_Layout.SlotType controlType = style3.ControlType;
		VirtualControlsSlotTypeMapping_Layout.SlotType controlType2 = style4.ControlType;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = this.DefaultControl;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl2 = other.DefaultControl;
		ControlAnchor.ControlId anchorControl = this.AnchorControl;
		ControlAnchor.ControlId anchorControl2 = other.AnchorControl;
		LayoutCalculator.AnchorType anchor = this.Anchor;
		LayoutCalculator.AnchorType anchor2 = other.Anchor;
		float x = this.Location.X;
		float y = this.Location.Y;
		float x2 = other.Location.X;
		float y2 = other.Location.Y;
		bool flag3;
		return flag3;
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x0003F284 File Offset: 0x0003D484
	public VirtualControlsHardwareConfigurationMapping_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001824 RID: 6180
	public string SlotId;

	// Token: 0x04001825 RID: 6181
	public VirtualControlsSlotTypeMapping_Layout Style;

	// Token: 0x04001826 RID: 6182
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType DefaultControl;

	// Token: 0x04001827 RID: 6183
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04001828 RID: 6184
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04001829 RID: 6185
	public Vector2 Location;

	// Token: 0x0200024A RID: 586
	public enum ContolType
	{
		// Token: 0x0400182B RID: 6187
		AutoFire,
		// Token: 0x0400182C RID: 6188
		SmartCursor,
		// Token: 0x0400182D RID: 6189
		CombatTargetting,
		// Token: 0x0400182E RID: 6190
		Jump,
		// Token: 0x0400182F RID: 6191
		Heal,
		// Token: 0x04001830 RID: 6192
		Mana,
		// Token: 0x04001831 RID: 6193
		Buff,
		// Token: 0x04001832 RID: 6194
		Mount,
		// Token: 0x04001833 RID: 6195
		Interact,
		// Token: 0x04001834 RID: 6196
		Fire,
		// Token: 0x04001835 RID: 6197
		GrappleAxis,
		// Token: 0x04001836 RID: 6198
		AutoSelect,
		// Token: 0x04001837 RID: 6199
		ZoomIn,
		// Token: 0x04001838 RID: 6200
		ZoomOut,
		// Token: 0x04001839 RID: 6201
		Move,
		// Token: 0x0400183A RID: 6202
		Aim,
		// Token: 0x0400183B RID: 6203
		GrappleFire,
		// Token: 0x0400183C RID: 6204
		ProfileSwitch,
		// Token: 0x0400183D RID: 6205
		InventoryToggle,
		// Token: 0x0400183E RID: 6206
		Settings,
		// Token: 0x0400183F RID: 6207
		Loadout1,
		// Token: 0x04001840 RID: 6208
		Loadout2,
		// Token: 0x04001841 RID: 6209
		Loadout3,
		// Token: 0x04001842 RID: 6210
		LoadoutCycle,
		// Token: 0x04001843 RID: 6211
		Count
	}
}
