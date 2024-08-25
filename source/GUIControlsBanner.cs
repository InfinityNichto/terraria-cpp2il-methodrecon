using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200012F RID: 303
public class GUIControlsBanner
{
	// Token: 0x060007E5 RID: 2021 RVA: 0x000021DB File Offset: 0x000003DB
	private float ItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x0001F274 File Offset: 0x0001D474
	private void ItemOver(int index)
	{
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x000021DB File Offset: 0x000003DB
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x000021DB File Offset: 0x000003DB
	public void ItemRightDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x000021DB File Offset: 0x000003DB
	public static GUIControllerInputButton.LinkedControlType FromButton(Buttons button)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x0001F284 File Offset: 0x0001D484
	public string GetControlTag(ControllerActionVector action)
	{
		bool hasMapping = action.HasMapping;
		ControllerActionAxis.Entry firstEntry = action.X.FirstEntry;
		ControllerActionButton.RequiredButtonState requiredState = firstEntry.RequiredState;
		string text;
		if (requiredState != null)
		{
			Buttons button = requiredState.Button;
			if (requiredState.state)
			{
				Buttons button2 = requiredState.Button2;
			}
			Buttons button3 = requiredState.Button2;
			bool state = requiredState.state2;
			long num = 0L;
			if (requiredState.state)
			{
			}
			bool state2 = requiredState.state2;
			long num2 = 0L;
			if (num != 0L)
			{
			}
			if (num2 != 0L)
			{
				string text2;
				string text3;
				text = text2 + "[cb:" + text3 + "]";
			}
		}
		Axis axis = firstEntry.Axis0;
		return text;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x0001F32C File Offset: 0x0001D52C
	public string GetControlTag(ControllerActionButton action)
	{
		bool hasMapping = action.HasMapping;
		ControllerActionButton.Entry firstEntry = action.FirstEntry;
		ControllerActionButton.RequiredButtonState requiredState = firstEntry.RequiredState;
		string text;
		if (requiredState != null)
		{
			Buttons button = requiredState.Button;
			if (requiredState.state)
			{
				Buttons button2 = requiredState.Button2;
			}
			Buttons button3 = requiredState.Button2;
			bool state = requiredState.state2;
			long num = 0L;
			if (requiredState.state)
			{
			}
			bool state2 = requiredState.state2;
			long num2 = 0L;
			if (num != 0L)
			{
			}
			if (num2 != 0L)
			{
				string text2;
				string text3;
				text = text2 + "[cb:" + text3 + "]";
			}
		}
		if (firstEntry.MappingType != ControllerActionButton.Entry.Type.Axis)
		{
			Buttons button4 = firstEntry.Button;
		}
		string text4;
		return text + "[ca:" + text4 + "]";
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0001F3D0 File Offset: 0x0001D5D0
	public static GUIControllerInputButton.AxisControl FromAxis(Axis axis, float threshold)
	{
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x000021DB File Offset: 0x000003DB
	private Vector2 ItemSize(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
	private Rectangle ItemRightTextRegion(int index)
	{
		TransactionButton_Layout actionStyle = this.ActionStyle;
		List<GUIControlsBanner.Action> list = this.currentActions;
		String_Layout label = actionStyle.Label;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x0001F414 File Offset: 0x0001D614
	private void LoadControlPosition(TransactionButton_Layout layout, ControlsBanner_Layout.ControlGroupingPosition position, Vector2 offset)
	{
		LayoutCalculator.AnchorType anchor = position.Anchor;
		layout.Anchor = anchor;
		ControlAnchor.ControlId anchorControl = position.AnchorControl;
		layout.AnchorControl = anchorControl;
		float x = position.Location.X;
		float y = position.Location.Y;
		if (anchorControl == ControlAnchor.ControlId.Screen)
		{
		}
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x0001F45C File Offset: 0x0001D65C
	private void DrawControl(TransactionButton_Layout layout, ControlsBanner_Layout.ControlGroupingPosition position, Vector2 offset, GUIControlsBanner.Action action, float scale)
	{
		if (offset != null)
		{
			Texture_Layout iconTexture = layout.IconTexture;
			return;
		}
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x0001F474 File Offset: 0x0001D674
	private Vector2 GetControlPoint(ControlsBanner_Layout.ControlGroupingPosition layoutItem)
	{
		ControlAnchor.ControlId anchorControl = layoutItem.AnchorControl;
		Vector2 location = layoutItem.Location;
		float x = layoutItem.Location.X;
		float y = layoutItem.Location.Y;
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x0001F4AC File Offset: 0x0001D6AC
	private bool AddAction(GUIControlsBanner.Action action, int maxWidth)
	{
		if (!true)
		{
		}
		bool disabled = action.Disabled;
		if (disabled)
		{
			return;
		}
		ControllerActionVector axis = action.Axis;
		int num;
		if (axis != null)
		{
			bool hasMapping = axis.HasMapping;
			if (num == 0 || !disabled)
			{
			}
			if (!disabled)
			{
			}
			ControllerActionVector axis2 = action.Axis;
		}
		ControllerActionButton button = action.Button;
		if (button != null)
		{
			bool hasMapping2 = button.HasMapping;
			if (num == 0 || !disabled)
			{
			}
			if (!disabled)
			{
			}
			ControllerActionButton button2 = action.Button;
			string name = action.Name;
			StringBuilder stringBuilder2;
			StringBuilder stringBuilder = stringBuilder2.Append(name);
			return;
		}
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x0001F52C File Offset: 0x0001D72C
	private bool AddMore(int maxWidth)
	{
		if (!true)
		{
		}
		bool moreLeftActions = this.MoreLeftActions;
		bool moreRightActions;
		if (!moreLeftActions)
		{
			moreRightActions = this.MoreRightActions;
			if (!moreRightActions)
			{
				goto IL_007C;
			}
		}
		int num;
		bool moreLeftActions2;
		if (num != 0)
		{
			if (!moreLeftActions)
			{
			}
			moreLeftActions2 = this.MoreLeftActions;
		}
		if (moreLeftActions2)
		{
			if (!moreLeftActions2)
			{
			}
			string text2;
			string text = "[cb:" + text2 + "]";
			bool moreRightActions2 = this.MoreRightActions;
			if ("[cb:" == null)
			{
			}
		}
		bool moreRightActions3 = this.MoreRightActions;
		if (moreRightActions3)
		{
			if (!moreRightActions3)
			{
			}
			string text4;
			string text3 = "[cb:" + text4 + "] ";
		}
		if ("[cb:" == null)
		{
		}
		IL_007C:
		if (!moreRightActions)
		{
			return;
		}
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
	public int SortActionByDisplayPriority(GUIControlsBanner.Action x, GUIControlsBanner.Action y)
	{
		ControllerActionVector axis = x.Axis;
		if (axis != null)
		{
			int displayPriority = axis.DisplayPriority;
		}
		ControllerActionButton button = x.Button;
		if (button != null)
		{
			int displayPriority2 = button.DisplayPriority;
		}
		int displayPriorityOffset = x.DisplayPriorityOffset;
		ControllerActionVector axis2 = y.Axis;
		if (axis2 != null)
		{
			int displayPriority3 = axis2.DisplayPriority;
		}
		ControllerActionButton button2 = y.Button;
		if (button2 != null)
		{
			int displayPriority4 = button2.DisplayPriority;
		}
		int displayPriorityOffset2 = y.DisplayPriorityOffset;
		int num;
		return num;
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x0001F62C File Offset: 0x0001D82C
	public void DrawHorizontalControlsBanner()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		List<GUIControlsBanner.Action> allActions = this.AllActions;
		int size = this.AllActions._size;
		int size2 = this.AllActions._size;
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
	public void DrawLeftControlsBanner()
	{
		int num = 1;
		List<GUIControlsBanner.Action> leftActions = this.LeftActions;
		this.currentActions = leftActions;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int num2 = 32640;
		int num3 = 1;
		this.secondLine = num3 != 0;
		int size = this.currentActions._size;
		if (num2 == 0)
		{
		}
		if (this.lastDrawRegion2.Width != 0)
		{
			if (num2 == 0)
			{
			}
			if (this.secondLine)
			{
				Rectangle rectangle = this.lastDrawRegion2;
				int width = this.lastDrawRegion2.Width;
				Vector2 vector = rectangle.TopLeft();
				Rectangle rectangle2 = this.lastDrawRegion2;
				int width2 = this.lastDrawRegion2.Width;
				Vector2 vector2 = rectangle2.BottomRight();
			}
		}
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x0001F77C File Offset: 0x0001D97C
	public void DrawRightControlsBanner()
	{
		List<GUIControlsBanner.Action> rightActions = this.RightActions;
		this.currentActions = rightActions;
		if (!true)
		{
		}
		if (!true)
		{
		}
		this.secondLine = true;
		int size = this.currentActions._size;
		if (32640 == 0)
		{
		}
		if (this.lastDrawRegion2.Width != 0)
		{
			if (32640 == 0)
			{
			}
			if (this.secondLine)
			{
				Rectangle rectangle = this.lastDrawRegion2;
				int width = this.lastDrawRegion2.Width;
				Vector2 vector = rectangle.TopLeft();
				Rectangle rectangle2 = this.lastDrawRegion2;
				int width2 = this.lastDrawRegion2.Width;
				Vector2 vector2 = rectangle2.BottomRight();
			}
		}
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x0001F824 File Offset: 0x0001DA24
	public void DrawControlsBanner(GUIControlsBanner.ActionSource source)
	{
		bool[] moreLeftStateActions = this.MoreLeftStateActions;
		this.itemsDrawing = (int)source;
		if (moreLeftStateActions != null)
		{
			return;
		}
		bool[] moreRightStateActions = this.MoreRightStateActions;
		if (moreRightStateActions == null || moreRightStateActions == null)
		{
		}
		List<GUIControlsBanner.Action>[] array = this.sourceActions;
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0001F940 File Offset: 0x0001DB40
	public void DrawMoreOptionsBanner()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		if (this.MoreLeftActions)
		{
			return;
		}
		if (this.MoreRightActions)
		{
			return;
		}
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x000021DB File Offset: 0x000003DB
	public void Draw()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x0001F970 File Offset: 0x0001DB70
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionVector action, string label)
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x0001F980 File Offset: 0x0001DB80
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionVector action, string label, Texture2D itemTexture, TransactionButton_Layout styleSource, bool disabled)
	{
		if (itemTexture != null)
		{
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			Rectangle rectangle = itemTexture.Frame(1, 1, (int)num, (int)num2, (int)num3, (int)num4);
			return;
		}
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x000021DB File Offset: 0x000003DB
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionVector action, string label, Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x0001F9AC File Offset: 0x0001DBAC
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionButton action, string label)
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x0001F9BC File Offset: 0x0001DBBC
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionButton action, string label, Texture2D itemTexture, TransactionButton_Layout styleSource, bool disabled)
	{
		if (itemTexture != null)
		{
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			Rectangle rectangle = itemTexture.Frame(1, 1, (int)num, (int)num2, (int)num3, (int)num4);
			return;
		}
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x000021DB File Offset: 0x000003DB
	public void AddAction(GUIControlsBanner.ActionSource source, ControllerActionButton action, string label, Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
	public GUIControlsBanner()
	{
	}

	// Token: 0x0400067F RID: 1663
	private Vector2 itemSize;

	// Token: 0x04000680 RID: 1664
	private List<GUIControlsBanner.Action> currentActions;

	// Token: 0x04000681 RID: 1665
	private bool[] MoreLeftStateActions;

	// Token: 0x04000682 RID: 1666
	private bool[] MoreRightStateActions;

	// Token: 0x04000683 RID: 1667
	private List<GUIControlsBanner.Action>[] sourceActions;

	// Token: 0x04000684 RID: 1668
	private List<GUIControlsBanner.Action> AllActions;

	// Token: 0x04000685 RID: 1669
	private List<GUIControlsBanner.Action> LeftActions;

	// Token: 0x04000686 RID: 1670
	private List<GUIControlsBanner.Action> RightActions;

	// Token: 0x04000687 RID: 1671
	private bool MoreLeftActions;

	// Token: 0x04000688 RID: 1672
	private bool MoreRightActions;

	// Token: 0x04000689 RID: 1673
	public bool ShowBanner = true;

	// Token: 0x0400068A RID: 1674
	public bool DisplayingSecondLine;

	// Token: 0x0400068B RID: 1675
	private bool secondLine;

	// Token: 0x0400068C RID: 1676
	private Rectangle lastDrawRegion;

	// Token: 0x0400068D RID: 1677
	private Rectangle lastDrawRegion2;

	// Token: 0x0400068E RID: 1678
	private TransactionButton_Layout ActionStyle;

	// Token: 0x0400068F RID: 1679
	private TransactionButton_Layout ActionStyleMultiple;

	// Token: 0x04000690 RID: 1680
	private GUIControlsBanner.Action LTAction;

	// Token: 0x04000691 RID: 1681
	private GUIControlsBanner.Action LBAction;

	// Token: 0x04000692 RID: 1682
	private float ScaleLB;

	// Token: 0x04000693 RID: 1683
	private GUIControlsBanner.Action RBAction;

	// Token: 0x04000694 RID: 1684
	private GUIControlsBanner.Action RTAction;

	// Token: 0x04000695 RID: 1685
	private float ScaleRB;

	// Token: 0x04000696 RID: 1686
	private GUIControlsBanner.ActionGroup LSActions;

	// Token: 0x04000697 RID: 1687
	private GUIControlsBanner.ActionGroup RSActions;

	// Token: 0x04000698 RID: 1688
	private GUIControlsBanner.ActionGroup DPadActions;

	// Token: 0x04000699 RID: 1689
	private GUIControlsBanner.ActionGroup ButtonActions;

	// Token: 0x0400069A RID: 1690
	private int itemsDrawing;

	// Token: 0x0400069B RID: 1691
	private float leftMoreScale;

	// Token: 0x0400069C RID: 1692
	private float rightMoreScale;

	// Token: 0x02000130 RID: 304
	public enum ActionSource
	{
		// Token: 0x0400069E RID: 1694
		MainMenu,
		// Token: 0x0400069F RID: 1695
		World,
		// Token: 0x040006A0 RID: 1696
		InterfaceLeft,
		// Token: 0x040006A1 RID: 1697
		InterfaceRight,
		// Token: 0x040006A2 RID: 1698
		NPCDialogue,
		// Token: 0x040006A3 RID: 1699
		Dresser,
		// Token: 0x040006A4 RID: 1700
		HairStylist,
		// Token: 0x040006A5 RID: 1701
		Map,
		// Token: 0x040006A6 RID: 1702
		Count
	}

	// Token: 0x02000131 RID: 305
	public class Action
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x0001FA04 File Offset: 0x0001DC04
		public Action(GUIControlsBanner.ActionSource source, ControllerActionVector action, string name, Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout style, bool disabled, int displayPriorityOffset)
		{
			this.ActionTextureRegion.Width = style;
			this.Name = name;
			this.Axis = action;
			this.ActionStyle = disabled;
			this.ActionTexture = itemTexture;
			this.ActionTextureRegion = srcRegion;
			ControllerActionButton.RequiredButtonState requiredState = action.X.RequiredState;
			ControllerActionAxis.Entry firstEntry = action.MappedX.FirstEntry;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0001FA64 File Offset: 0x0001DC64
		public Action(GUIControlsBanner.ActionSource source, ControllerActionButton action, string name, Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled, int displayPriorityOffset)
		{
			this.ActionTextureRegion.Width = styleSource;
			this.Name = name;
			this.Button = action;
			this.ActionStyle = disabled;
			this.ActionTexture = itemTexture;
			this.ActionTextureRegion = srcRegion;
			ControllerActionButton.RequiredButtonState requiredState = action.RequiredState;
			ControllerActionButton.Entry.Type mappingType = action.FirstEntry.MappingType;
			ControllerActionButton.Entry firstEntry = action.FirstEntry;
			Buttons button = firstEntry.Button;
		}

		// Token: 0x040006A7 RID: 1703
		public const GUIControlsBanner.Action.ControlPriority MinRightControl = GUIControlsBanner.Action.ControlPriority.RightTrigger;

		// Token: 0x040006A8 RID: 1704
		public ControllerActionVector Axis;

		// Token: 0x040006A9 RID: 1705
		public ControllerActionButton Button;

		// Token: 0x040006AA RID: 1706
		public TransactionButton_Layout ActionStyle;

		// Token: 0x040006AB RID: 1707
		public Texture2D ActionTexture;

		// Token: 0x040006AC RID: 1708
		public Rectangle ActionTextureRegion;

		// Token: 0x040006AD RID: 1709
		public string Name;

		// Token: 0x040006AE RID: 1710
		public int InputPriority;

		// Token: 0x040006AF RID: 1711
		public bool Disabled;

		// Token: 0x040006B0 RID: 1712
		public int DisplayPriorityOffset;

		// Token: 0x02000132 RID: 306
		public enum ControlPriority
		{
			// Token: 0x040006B2 RID: 1714
			LeftTrigger,
			// Token: 0x040006B3 RID: 1715
			LeftShoulder,
			// Token: 0x040006B4 RID: 1716
			DPadDown,
			// Token: 0x040006B5 RID: 1717
			DPadUp,
			// Token: 0x040006B6 RID: 1718
			DPadLeft,
			// Token: 0x040006B7 RID: 1719
			DPadRight,
			// Token: 0x040006B8 RID: 1720
			LSDown,
			// Token: 0x040006B9 RID: 1721
			LSUp,
			// Token: 0x040006BA RID: 1722
			LSLeft,
			// Token: 0x040006BB RID: 1723
			LSRight,
			// Token: 0x040006BC RID: 1724
			LSClick,
			// Token: 0x040006BD RID: 1725
			ViewButton,
			// Token: 0x040006BE RID: 1726
			LeftMore,
			// Token: 0x040006BF RID: 1727
			RightTrigger,
			// Token: 0x040006C0 RID: 1728
			RightShoulder,
			// Token: 0x040006C1 RID: 1729
			Action2,
			// Token: 0x040006C2 RID: 1730
			Action4,
			// Token: 0x040006C3 RID: 1731
			Action3,
			// Token: 0x040006C4 RID: 1732
			Action1,
			// Token: 0x040006C5 RID: 1733
			RSDown,
			// Token: 0x040006C6 RID: 1734
			RSUp,
			// Token: 0x040006C7 RID: 1735
			RSLeft,
			// Token: 0x040006C8 RID: 1736
			RSRight,
			// Token: 0x040006C9 RID: 1737
			RSClick,
			// Token: 0x040006CA RID: 1738
			Settings,
			// Token: 0x040006CB RID: 1739
			RightMore
		}
	}

	// Token: 0x02000133 RID: 307
	private class ActionGroup
	{
		// Token: 0x06000804 RID: 2052 RVA: 0x0001FB14 File Offset: 0x0001DD14
		public ActionGroup()
		{
		}

		// Token: 0x040006CC RID: 1740
		public GUIControlsBanner.Action ActionUp;

		// Token: 0x040006CD RID: 1741
		public GUIControlsBanner.Action ActionDown;

		// Token: 0x040006CE RID: 1742
		public GUIControlsBanner.Action ActionLeft;

		// Token: 0x040006CF RID: 1743
		public GUIControlsBanner.Action ActionRight;

		// Token: 0x040006D0 RID: 1744
		public float ScaleUp;

		// Token: 0x040006D1 RID: 1745
		public float ScaleDown;

		// Token: 0x040006D2 RID: 1746
		public float ScaleLeft;

		// Token: 0x040006D3 RID: 1747
		public float ScaleRight;
	}

	// Token: 0x02000134 RID: 308
	[CompilerGenerated]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x0001FB28 File Offset: 0x0001DD28
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0001FB38 File Offset: 0x0001DD38
		public <>c()
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0001FB4C File Offset: 0x0001DD4C
		internal int <DrawLeftControlsBanner>b__48_0(GUIControlsBanner.Action e1, GUIControlsBanner.Action e2)
		{
			int inputPriority = e2.InputPriority;
			int num;
			return num;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0001FB64 File Offset: 0x0001DD64
		internal int <DrawRightControlsBanner>b__49_0(GUIControlsBanner.Action e1, GUIControlsBanner.Action e2)
		{
			int inputPriority = e2.InputPriority;
			int num;
			return num;
		}

		// Token: 0x040006D4 RID: 1748
		public static readonly GUIControlsBanner.<>c <>9;

		// Token: 0x040006D5 RID: 1749
		public static Comparison<GUIControlsBanner.Action> <>9__48_0;

		// Token: 0x040006D6 RID: 1750
		public static Comparison<GUIControlsBanner.Action> <>9__49_0;
	}
}
