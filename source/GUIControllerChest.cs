using System;
using Controller;
using Microsoft.Xna.Framework;

// Token: 0x020000B6 RID: 182
public class GUIControllerChest : GUIPageContentController
{
	// Token: 0x06000453 RID: 1107 RVA: 0x0000DE20 File Offset: 0x0000C020
	public GUIControllerChest()
		: base(GUIPageIcons.Category.Chest)
	{
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x0000DE34 File Offset: 0x0000C034
	public override void Activate()
	{
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x0000DE44 File Offset: 0x0000C044
	public virtual bool IsInMenu()
	{
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x0000DE54 File Offset: 0x0000C054
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		int num = this.itemColumn;
		this.itemColumn = num;
		int num2 = this.itemColumn;
		this.itemColumn = num2;
		int num3 = this.itemRow;
		int num4 = this.itemRow;
		this.itemRow = num4;
		int num5 = this.itemRow;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x0000DE9C File Offset: 0x0000C09C
	public override Rectangle GetSelectedItemRegion()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		ItemGrid_Layout itemGrid_Layout;
		ControlAnchor.ControlId firstAnchorControl = itemGrid_Layout.FirstAnchorControl;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		ItemGrid_Layout itemGrid_Layout2;
		float x = itemGrid_Layout2.ExtraElementSpacing.X;
		!0 instance7 = PageControllerLayoutDefinition.Instance;
		ItemGrid_Layout itemGrid_Layout3;
		float y = itemGrid_Layout3.ExtraElementSpacing.Y;
		Vector2 pickingOffset = itemGrid_Layout3.PickingOffset;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x0400043B RID: 1083
	public int itemRow;

	// Token: 0x0400043C RID: 1084
	public int itemColumn;
}
