using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020001C5 RID: 453
public class ControlsBanner_Layout : LayoutDefinition
{
	// Token: 0x06000BEB RID: 3051 RVA: 0x0003BA00 File Offset: 0x00039C00
	private void Awake()
	{
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x000021DB File Offset: 0x000003DB
	public int GetMappingPriority(string id)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x0003BA10 File Offset: 0x00039C10
	public ControlsBanner_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000F79 RID: 3961
	public static ControlsBanner_Layout Instance;

	// Token: 0x04000F7A RID: 3962
	public ControlsBanner_Layout.PriorityMappings MappingPriority;

	// Token: 0x04000F7B RID: 3963
	public Panel_Layout Backing;

	// Token: 0x04000F7C RID: 3964
	public Vector2 BackingTLOffset;

	// Token: 0x04000F7D RID: 3965
	public Vector2 BackingBROffset;

	// Token: 0x04000F7E RID: 3966
	public bool DebugBannerLength;

	// Token: 0x04000F7F RID: 3967
	public ItemGrid_Layout Actions;

	// Token: 0x04000F80 RID: 3968
	public ControlsBanner_Layout.ControlGroupingPosition ActionsWidth;

	// Token: 0x04000F81 RID: 3969
	public ItemGrid_Layout LeftInterface;

	// Token: 0x04000F82 RID: 3970
	public ControlsBanner_Layout.ControlGroupingPosition LeftInterfaceWidth;

	// Token: 0x04000F83 RID: 3971
	public ItemGrid_Layout RightInterface;

	// Token: 0x04000F84 RID: 3972
	public ControlsBanner_Layout.ControlGroupingPosition RightInterfaceWidth;

	// Token: 0x04000F85 RID: 3973
	public ItemGrid_Layout NPCDialogue;

	// Token: 0x04000F86 RID: 3974
	public ControlsBanner_Layout.ControlGroupingPosition NPCDialogueWidth;

	// Token: 0x04000F87 RID: 3975
	public TransactionButton_Layout ActionStyle;

	// Token: 0x04000F88 RID: 3976
	public TransactionButton_Layout ActionStyleMultiple;

	// Token: 0x04000F89 RID: 3977
	public Panel_Layout InterfaceBacking;

	// Token: 0x04000F8A RID: 3978
	public Vector2 InterfaceBackingTLOffset;

	// Token: 0x04000F8B RID: 3979
	public Vector2 InterfaceBackingBROffset;

	// Token: 0x04000F8C RID: 3980
	public TransactionButton_Layout InterfaceActionStyle;

	// Token: 0x04000F8D RID: 3981
	public TransactionButton_Layout InterfaceActionStyleMultiple;

	// Token: 0x04000F8E RID: 3982
	public ItemGrid_Layout LeftActions;

	// Token: 0x04000F8F RID: 3983
	public Panel_Layout LeftActionBacking;

	// Token: 0x04000F90 RID: 3984
	public Vector2 LeftActionBackingTLOffset;

	// Token: 0x04000F91 RID: 3985
	public Vector2 LeftActionBackingBROffset;

	// Token: 0x04000F92 RID: 3986
	public ItemGrid_Layout RightActions;

	// Token: 0x04000F93 RID: 3987
	public Panel_Layout RightActionBacking;

	// Token: 0x04000F94 RID: 3988
	public Vector2 RightActionBackingTLOffset;

	// Token: 0x04000F95 RID: 3989
	public Vector2 RightActionBackingBROffset;

	// Token: 0x04000F96 RID: 3990
	public String_Layout ActionDisplay;

	// Token: 0x04000F97 RID: 3991
	public String_Layout ActionDisplay2;

	// Token: 0x04000F98 RID: 3992
	public int ScreenEdgeAmount;

	// Token: 0x04000F99 RID: 3993
	public int MaxWidth;

	// Token: 0x04000F9A RID: 3994
	public TransactionButton_Layout LeftActionStyle;

	// Token: 0x04000F9B RID: 3995
	public TransactionButton_Layout LeftActionStyleMultiple;

	// Token: 0x04000F9C RID: 3996
	public TransactionButton_Layout RightActionStyle;

	// Token: 0x04000F9D RID: 3997
	public TransactionButton_Layout RightActionStyleMultiple;

	// Token: 0x04000F9E RID: 3998
	public String_Layout MoreText;

	// Token: 0x04000F9F RID: 3999
	public TransactionButton_Layout LeftMoreButton;

	// Token: 0x04000FA0 RID: 4000
	public TransactionButton_Layout RightMoreButton;

	// Token: 0x04000FA1 RID: 4001
	public Panel_Layout MoreButtonBacking;

	// Token: 0x020001C6 RID: 454
	[Serializable]
	public class PriorityMappings
	{
		// Token: 0x06000BEE RID: 3054 RVA: 0x0003BA28 File Offset: 0x00039C28
		public PriorityMappings()
		{
		}

		// Token: 0x04000FA2 RID: 4002
		public List<string> Ids;
	}

	// Token: 0x020001C7 RID: 455
	[Serializable]
	public class ControlGrouping
	{
		// Token: 0x06000BEF RID: 3055 RVA: 0x0003BA3C File Offset: 0x00039C3C
		public ControlGrouping()
		{
		}

		// Token: 0x04000FA3 RID: 4003
		public Vector2 Left;

		// Token: 0x04000FA4 RID: 4004
		public Vector2 Right;

		// Token: 0x04000FA5 RID: 4005
		public Vector2 Up;

		// Token: 0x04000FA6 RID: 4006
		public Vector2 Down;
	}

	// Token: 0x020001C8 RID: 456
	[Serializable]
	public class ControlGroupingPosition
	{
		// Token: 0x06000BF0 RID: 3056 RVA: 0x0003BA50 File Offset: 0x00039C50
		public ControlGroupingPosition()
		{
		}

		// Token: 0x04000FA7 RID: 4007
		public ControlAnchor.ControlId AnchorControl;

		// Token: 0x04000FA8 RID: 4008
		public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.CentreBoth;

		// Token: 0x04000FA9 RID: 4009
		public Vector2 Location = 18;
	}

	// Token: 0x020001C9 RID: 457
	[Serializable]
	public class MenuLayout
	{
		// Token: 0x06000BF1 RID: 3057 RVA: 0x0003BA74 File Offset: 0x00039C74
		public MenuLayout()
		{
		}

		// Token: 0x04000FAA RID: 4010
		public TransactionButton_Layout LSIcon;

		// Token: 0x04000FAB RID: 4011
		public ControlsBanner_Layout.ControlGroupingPosition LS;

		// Token: 0x04000FAC RID: 4012
		public TransactionButton_Layout Button1;

		// Token: 0x04000FAD RID: 4013
		public TransactionButton_Layout Button2;

		// Token: 0x04000FAE RID: 4014
		public TransactionButton_Layout Button3;

		// Token: 0x04000FAF RID: 4015
		public TransactionButton_Layout Button4;

		// Token: 0x04000FB0 RID: 4016
		public ControlsBanner_Layout.ControlGroupingPosition Buttons;

		// Token: 0x04000FB1 RID: 4017
		public TransactionButton_Layout LBIcon;

		// Token: 0x04000FB2 RID: 4018
		public ControlsBanner_Layout.ControlGroupingPosition LB;

		// Token: 0x04000FB3 RID: 4019
		public TransactionButton_Layout RBIcon;

		// Token: 0x04000FB4 RID: 4020
		public ControlsBanner_Layout.ControlGroupingPosition RB;
	}
}
