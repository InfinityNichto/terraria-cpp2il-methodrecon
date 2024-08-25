using System;
using Newtonsoft.Json;

// Token: 0x0200024D RID: 589
[JsonObject(MemberSerialization.OptIn)]
[Serializable]
public class VirtualControlsSlotTypeMapping_Layout
{
	// Token: 0x06000D43 RID: 3395 RVA: 0x0003F738 File Offset: 0x0003D938
	public VirtualControlsSlotTypeMapping_Layout()
	{
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0003F74C File Offset: 0x0003D94C
	public VirtualControlsButtonConfiguration_Layout ButtonConfiguration
	{
		get
		{
			string lastControlTypeId = this._lastControlTypeId;
			string controlTypeId = this.ControlTypeId;
			bool flag = lastControlTypeId != controlTypeId;
			VirtualControlsButtonConfiguration_Layout buttonMapping = this._buttonMapping;
			if (buttonMapping != null)
			{
				string id = buttonMapping.Id;
				string controlTypeId2 = this.ControlTypeId;
				bool flag2 = id != controlTypeId2;
				string controlTypeId3 = this.ControlTypeId;
				this._lastControlTypeId = controlTypeId3;
			}
			bool flag3 = string.IsNullOrEmpty(this.ControlTypeId);
			return this._buttonMapping;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0003F7DC File Offset: 0x0003D9DC
	public VirtualControlsAxisConfiguration_Layout AxisConfiguration
	{
		get
		{
			string lastControlTypeId = this._lastControlTypeId;
			string controlTypeId = this.ControlTypeId;
			bool flag = lastControlTypeId != controlTypeId;
			VirtualControlsAxisConfiguration_Layout axisMapping = this._axisMapping;
			if (axisMapping != null)
			{
				string id = axisMapping.Id;
				string controlTypeId2 = this.ControlTypeId;
				bool flag2 = id != controlTypeId2;
				string controlTypeId3 = this.ControlTypeId;
				this._lastControlTypeId = controlTypeId3;
			}
			bool flag3 = string.IsNullOrEmpty(this.ControlTypeId);
			return this._axisMapping;
		}
	}

	// Token: 0x04001853 RID: 6227
	[JsonProperty]
	public string ControlTypeId;

	// Token: 0x04001854 RID: 6228
	[JsonProperty]
	public VirtualControlsSlotTypeMapping_Layout.SlotType ControlType;

	// Token: 0x04001855 RID: 6229
	private VirtualControlsButtonConfiguration_Layout _buttonMapping;

	// Token: 0x04001856 RID: 6230
	private VirtualControlsAxisConfiguration_Layout _axisMapping;

	// Token: 0x04001857 RID: 6231
	private string _lastControlTypeId;

	// Token: 0x0200024E RID: 590
	public enum SlotType
	{
		// Token: 0x04001859 RID: 6233
		Axis,
		// Token: 0x0400185A RID: 6234
		Button
	}
}
