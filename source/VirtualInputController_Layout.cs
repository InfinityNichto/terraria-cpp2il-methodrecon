using System;
using Microsoft.Xna.Framework;

// Token: 0x02000250 RID: 592
public class VirtualInputController_Layout : LayoutDefinition
{
	// Token: 0x06000D50 RID: 3408 RVA: 0x0003FB0C File Offset: 0x0003DD0C
	private void Awake()
	{
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x0003FB1C File Offset: 0x0003DD1C
	public VirtualInputController_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001862 RID: 6242
	public static VirtualInputController_Layout Instance;

	// Token: 0x04001863 RID: 6243
	public QuickActionButton_Layout Jump;

	// Token: 0x04001864 RID: 6244
	public QuickActionButton_Layout Jump2;

	// Token: 0x04001865 RID: 6245
	public Axis_Layout Movement;

	// Token: 0x04001866 RID: 6246
	public QuickActionButton_Layout Heal;

	// Token: 0x04001867 RID: 6247
	public QuickActionButton_Layout Mana;

	// Token: 0x04001868 RID: 6248
	public QuickActionButton_Layout Buff;

	// Token: 0x04001869 RID: 6249
	public QuickActionButton_Layout Mount;

	// Token: 0x0400186A RID: 6250
	public QuickActionButton_Layout SmartCursor;

	// Token: 0x0400186B RID: 6251
	public QuickActionButton_Layout AutoFire;

	// Token: 0x0400186C RID: 6252
	public QuickActionButton_Layout ZoomIn;

	// Token: 0x0400186D RID: 6253
	public QuickActionButton_Layout ZoomOut;

	// Token: 0x0400186E RID: 6254
	public Panel_Layout ZoomBacking;

	// Token: 0x0400186F RID: 6255
	public QuickActionButton_Layout Interact;

	// Token: 0x04001870 RID: 6256
	public QuickActionButton_Layout Fire;

	// Token: 0x04001871 RID: 6257
	public QuickActionButton_Layout Fire2;

	// Token: 0x04001872 RID: 6258
	public QuickActionButton_Layout Inventory;

	// Token: 0x04001873 RID: 6259
	public QuickActionButton_Layout AutoSelect;

	// Token: 0x04001874 RID: 6260
	public QuickActionButton_Layout GrappleSelect;

	// Token: 0x04001875 RID: 6261
	public QuickActionButton_Layout TargetLockOn;

	// Token: 0x04001876 RID: 6262
	public FadeString_Layout ZoomValue;

	// Token: 0x04001877 RID: 6263
	public Axis_Layout FireAxis;

	// Token: 0x04001878 RID: 6264
	public Axis_Layout GrappleAxis;

	// Token: 0x04001879 RID: 6265
	public FadeString_Layout NotifySmartCursor;

	// Token: 0x0400187A RID: 6266
	public FadeString_Layout NotifyAutoFire;

	// Token: 0x0400187B RID: 6267
	public FadeString_Layout NotifyCombatTargeting;

	// Token: 0x0400187C RID: 6268
	public FadeString_Layout NotifyProfile;

	// Token: 0x0400187D RID: 6269
	public FadeString_Layout NotifySmartCursorController;

	// Token: 0x0400187E RID: 6270
	public FadeString_Layout NotifyAutoFireController;

	// Token: 0x0400187F RID: 6271
	public FadeString_Layout NotifyCombatTargetingController;

	// Token: 0x04001880 RID: 6272
	public FadeString_Layout NotifyProfileController;

	// Token: 0x04001881 RID: 6273
	public String_Layout ProfileSwitchString;

	// Token: 0x02000251 RID: 593
	public enum ContolType
	{
		// Token: 0x04001883 RID: 6275
		AutoFire,
		// Token: 0x04001884 RID: 6276
		SmartCursor,
		// Token: 0x04001885 RID: 6277
		CombatTargetting,
		// Token: 0x04001886 RID: 6278
		Jump,
		// Token: 0x04001887 RID: 6279
		Heal,
		// Token: 0x04001888 RID: 6280
		Mana,
		// Token: 0x04001889 RID: 6281
		Buff,
		// Token: 0x0400188A RID: 6282
		Mount,
		// Token: 0x0400188B RID: 6283
		Interact,
		// Token: 0x0400188C RID: 6284
		Fire,
		// Token: 0x0400188D RID: 6285
		GrappleAxis,
		// Token: 0x0400188E RID: 6286
		Count
	}

	// Token: 0x02000252 RID: 594
	[Serializable]
	public class SlotEntry
	{
		// Token: 0x06000D52 RID: 3410 RVA: 0x0003FB34 File Offset: 0x0003DD34
		public SlotEntry()
		{
			if (33 == 0)
			{
			}
			if (!true)
			{
			}
			this.Scale = (float)16256;
			base..ctor();
		}

		// Token: 0x0400188F RID: 6287
		public VirtualInputController_Layout.ContolType DefaultControl;

		// Token: 0x04001890 RID: 6288
		public ControlAnchor.ControlId AnchorControl;

		// Token: 0x04001891 RID: 6289
		public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

		// Token: 0x04001892 RID: 6290
		public Vector2 Location;

		// Token: 0x04001893 RID: 6291
		public float Scale;
	}
}
