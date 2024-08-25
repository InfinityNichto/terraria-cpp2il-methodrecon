using System;
using Controller;
using Microsoft.Xna.Framework;

// Token: 0x020000B4 RID: 180
public class GUIControllerAmmo : GUIPageContentController
{
	// Token: 0x06000447 RID: 1095 RVA: 0x0000DBC4 File Offset: 0x0000BDC4
	public GUIControllerAmmo()
		: base(GUIPageIcons.Category.Inventory)
	{
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
	public override void Activate()
	{
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
	public virtual void NavigateFromInventoryRow(int row)
	{
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x0000DC00 File Offset: 0x0000BE00
	public virtual int GetInventoryRow()
	{
		int num = this.itemRow;
		return 3;
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x0000DC18 File Offset: 0x0000BE18
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		GUIControllerInventory guicontrollerInventory;
		guicontrollerInventory.itemRow = this;
		int num = 9;
		GUIControllerInventory guicontrollerInventory2;
		guicontrollerInventory2.itemColumn = num;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x0000DC5C File Offset: 0x0000BE5C
	public override Rectangle GetSelectedItemRegion()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x04000439 RID: 1081
	public int itemRow;

	// Token: 0x0400043A RID: 1082
	public int itemColmun;
}
