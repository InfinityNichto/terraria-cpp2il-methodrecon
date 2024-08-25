using System;
using Microsoft.Xna.Framework;

// Token: 0x02000241 RID: 577
public class Shop_Layout : PageControllerLayoutDefinition<Shop_Layout>
{
	// Token: 0x06000D2A RID: 3370 RVA: 0x0003F028 File Offset: 0x0003D228
	public Shop_Layout()
	{
	}

	// Token: 0x040017EF RID: 6127
	public String_Layout Title;

	// Token: 0x040017F0 RID: 6128
	public float ItemScale = (float)16192;

	// Token: 0x040017F1 RID: 6129
	public ItemGrid_Layout ShopGrid;

	// Token: 0x040017F2 RID: 6130
	public ItemGrid_Layout ShopGridHorizontal;

	// Token: 0x040017F3 RID: 6131
	public Panel_Layout SavingsBacking;

	// Token: 0x040017F4 RID: 6132
	public String_Layout Savings;

	// Token: 0x040017F5 RID: 6133
	public Vector2 Savings1IconOffset = 17008;

	// Token: 0x040017F6 RID: 6134
	public Vector2 Savings2IconOffset = 16968;

	// Token: 0x040017F7 RID: 6135
	public Vector2 Savings3IconOffset = 16968;

	// Token: 0x040017F8 RID: 6136
	public Vector2 Savings4IconOffset = 16928;

	// Token: 0x040017F9 RID: 6137
	public String_Layout SavingsTitle;

	// Token: 0x040017FA RID: 6138
	public String_Layout Cost;

	// Token: 0x040017FB RID: 6139
	public String_Layout ControllerCost;

	// Token: 0x040017FC RID: 6140
	public String_Layout OtherCurrencyCost;

	// Token: 0x040017FD RID: 6141
	public TransactionButton_Layout BuyButton;

	// Token: 0x040017FE RID: 6142
	public float SlotMultiPurchaseDelay = (float)16256;

	// Token: 0x040017FF RID: 6143
	public int[] BartenderShopOrder;

	// Token: 0x04001800 RID: 6144
	public int[] BartenderShopOrderHorizontal;
}
