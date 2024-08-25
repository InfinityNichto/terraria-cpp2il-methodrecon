using System;

// Token: 0x020001F1 RID: 497
public class Mana_Layout : LayoutDefinition
{
	// Token: 0x06000C79 RID: 3193 RVA: 0x0003DC7C File Offset: 0x0003BE7C
	private void Awake()
	{
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x0003DC8C File Offset: 0x0003BE8C
	public Mana_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001206 RID: 4614
	public static Mana_Layout Instance;

	// Token: 0x04001207 RID: 4615
	public bool HideWhenInventoryOpen = true;

	// Token: 0x04001208 RID: 4616
	public String_Layout Mana;

	// Token: 0x04001209 RID: 4617
	public String_Layout ManaHorizontal;

	// Token: 0x0400120A RID: 4618
	public String_Layout ManaValue;

	// Token: 0x0400120B RID: 4619
	public String_Layout ManaValueHorizontal;

	// Token: 0x0400120C RID: 4620
	public float StarScale = (float)16256;

	// Token: 0x0400120D RID: 4621
	public ItemGrid_Layout ManaGrid;

	// Token: 0x0400120E RID: 4622
	public String_Layout ManaController;

	// Token: 0x0400120F RID: 4623
	public String_Layout ManaControllerHorizontal;

	// Token: 0x04001210 RID: 4624
	public String_Layout ManaValueController;

	// Token: 0x04001211 RID: 4625
	public String_Layout ManaValueControllerHorizontal;

	// Token: 0x04001212 RID: 4626
	public ItemGrid_Layout ManaGridController;

	// Token: 0x04001213 RID: 4627
	public ItemGrid_Layout ManaGridHorizontal;

	// Token: 0x04001214 RID: 4628
	public ItemGrid_Layout ManaGridControllerHorizontal;
}
