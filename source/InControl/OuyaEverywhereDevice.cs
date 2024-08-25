using System;
using System.Runtime.CompilerServices;

namespace InControl
{
	// Token: 0x02000044 RID: 68
	public class OuyaEverywhereDevice : InputDevice
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000AC00 File Offset: 0x00008E00
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0000AC14 File Offset: 0x00008E14
		public int DeviceIndex
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceIndex>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<DeviceIndex>k__BackingField = value;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000AC28 File Offset: 0x00008E28
		public OuyaEverywhereDevice(int deviceIndex)
		{
			if (!true)
			{
			}
			base..ctor("OUYA Controller");
			this.DeviceIndex = deviceIndex;
			this.<SortOrder>k__BackingField = deviceIndex;
			string text2;
			string text = "OUYA Everywhere Device #" + text2;
			this.<Meta>k__BackingField = text;
			InputControl inputControl = base.AddControl(InputControlType.LeftStickLeft, "Left Stick Left");
			InputControl inputControl2 = base.AddControl(InputControlType.LeftStickRight, "Left Stick Right");
			InputControl inputControl3 = base.AddControl(InputControlType.LeftStickUp, "Left Stick Right");
			InputControl inputControl4 = base.AddControl(InputControlType.RightStickRight, "Right Stick Right");
			InputControl inputControl5 = base.AddControl(InputControlType.RightStickUp, "Right Stick Up");
			InputControl inputControl6 = base.AddControl(InputControlType.LeftTrigger, "Left Trigger");
			InputControl inputControl7 = base.AddControl(InputControlType.LeftTrigger, "Right Trigger");
			InputControl inputControl8 = base.AddControl(InputControlType.DPadDown, "DPad Down");
			InputControl inputControl9 = base.AddControl(InputControlType.DPadLeft, "DPad Left");
			InputControl inputControl10 = base.AddControl(InputControlType.DPadRight, "DPad Right");
			InputControl inputControl11 = base.AddControl(InputControlType.Action1, "O");
			InputControl inputControl12 = base.AddControl(InputControlType.Action2, "A");
			InputControl inputControl13 = base.AddControl(InputControlType.Action3, "Y");
			InputControl inputControl14 = base.AddControl(InputControlType.Action4, "U");
			InputControl inputControl15 = base.AddControl(InputControlType.LeftBumper, "Left Bumper");
			InputControl inputControl16 = base.AddControl(InputControlType.RightBumper, "Right Bumper");
			InputControl inputControl17 = base.AddControl(InputControlType.LeftStickButton, "Left Stick Button");
			InputControl inputControl18 = base.AddControl(InputControlType.RightStickButton, "Right Stick Button");
			InputControl inputControl19 = base.AddControl(InputControlType.Menu, "Menu");
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000AD7C File Offset: 0x00008F7C
		public void BeforeAttach()
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000AD8C File Offset: 0x00008F8C
		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000AD9C File Offset: 0x00008F9C
		public bool IsConnected
		{
			get
			{
			}
		}

		// Token: 0x040002EA RID: 746
		private const float LowerDeadZone = 0.2f;

		// Token: 0x040002EB RID: 747
		private const float UpperDeadZone = 0.9f;

		// Token: 0x040002EC RID: 748
		[CompilerGenerated]
		private int <DeviceIndex>k__BackingField;
	}
}
