using System;
using Controller;
using Microsoft.Xna.Framework;

// Token: 0x020000B5 RID: 181
public class GUIControllerAmmo4Page : GUIControllerAmmo
{
	// Token: 0x0600044D RID: 1101 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
	public override int GetNavigationOutDirs()
	{
		int itemColmun = this.itemColmun;
		int itemRow = this.itemRow;
		return 8;
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x0000DCBC File Offset: 0x0000BEBC
	public override void NavigateFromInventoryRow(int row)
	{
		this.itemRow = 3;
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x0000DCD0 File Offset: 0x0000BED0
	public override int GetInventoryRow()
	{
		return this.itemRow;
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		base.LoadPageAnchor();
		int itemColmun = this.itemColmun;
		this.itemColmun = itemColmun;
		int itemRow = this.itemRow;
		int itemColmun2 = this.itemColmun;
		GUIPageIconGrouping parentGrouping = base.ParentGrouping;
		GUIControllerItem guicontrollerItem;
		if (guicontrollerItem == null)
		{
			return guicontrollerItem;
		}
		long num = 0L;
		GUIPageIconGrouping parentGrouping2 = base.ParentGrouping;
		int itemColmun3 = this.itemColmun;
		GUIControllerItem guicontrollerItem2 = parentGrouping2.NavigateDown((int)num);
		while (guicontrollerItem2 != null)
		{
		}
		return guicontrollerItem2;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x0000DD94 File Offset: 0x0000BF94
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x0000DE0C File Offset: 0x0000C00C
	public GUIControllerAmmo4Page()
		: base(GUIPageIcons.Category.Inventory)
	{
	}
}
