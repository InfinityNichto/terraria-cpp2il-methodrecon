using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x02000236 RID: 566
public class Research_Layout : LayoutDefinition
{
	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000021DB File Offset: 0x000003DB
	public static Research_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x0003EA90 File Offset: 0x0003CC90
	private void Awake()
	{
		bool flag = this.name == "Research4Page";
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x0003EAB0 File Offset: 0x0003CCB0
	public Research_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001725 RID: 5925
	public static Research_Layout InstanceNormal;

	// Token: 0x04001726 RID: 5926
	public static Research_Layout Instance4Page;

	// Token: 0x04001727 RID: 5927
	public TransactionButton_Layout InventoryResearch;

	// Token: 0x04001728 RID: 5928
	public TransactionButton_Layout InventoryResearchController;

	// Token: 0x04001729 RID: 5929
	public Vector2 InventoryResearchControllerWiringOffset;

	// Token: 0x0400172A RID: 5930
	public Panel_Layout Backing;

	// Token: 0x0400172B RID: 5931
	public Panel_Layout BackingController;

	// Token: 0x0400172C RID: 5932
	public Panel_Layout ImageBacking;

	// Token: 0x0400172D RID: 5933
	public Panel_Layout ResearchItem;

	// Token: 0x0400172E RID: 5934
	public Panel_Layout ResearchItemBacking;

	// Token: 0x0400172F RID: 5935
	public Panel_Layout ResearchCogLeft1;

	// Token: 0x04001730 RID: 5936
	public Panel_Layout ResearchCogLeft2;

	// Token: 0x04001731 RID: 5937
	public Panel_Layout ResearchCogLeft3;

	// Token: 0x04001732 RID: 5938
	public Panel_Layout ResearchCogRight1;

	// Token: 0x04001733 RID: 5939
	public Panel_Layout ResearchCogRight2;

	// Token: 0x04001734 RID: 5940
	public Panel_Layout ResearchCogRight3;

	// Token: 0x04001735 RID: 5941
	public Panel_Layout Divider;

	// Token: 0x04001736 RID: 5942
	public Panel_Layout Divider2;

	// Token: 0x04001737 RID: 5943
	public TransactionButton_Layout Close;

	// Token: 0x04001738 RID: 5944
	public TransactionButton_Layout ActionResearch;

	// Token: 0x04001739 RID: 5945
	public String_Layout ItemName;

	// Token: 0x0400173A RID: 5946
	public String_Layout Description;

	// Token: 0x0400173B RID: 5947
	public Panel_Layout BarBacking;

	// Token: 0x0400173C RID: 5948
	public Panel_Layout CurrentProgress;

	// Token: 0x0400173D RID: 5949
	public Panel_Layout NewProgress;

	// Token: 0x0400173E RID: 5950
	public String_Layout Progress;

	// Token: 0x0400173F RID: 5951
	public String_Layout StackCount;
}
