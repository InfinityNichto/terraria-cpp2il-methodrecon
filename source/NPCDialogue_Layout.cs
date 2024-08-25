using System;

// Token: 0x02000229 RID: 553
public class NPCDialogue_Layout : LayoutDefinition
{
	// Token: 0x06000CE8 RID: 3304 RVA: 0x0003E758 File Offset: 0x0003C958
	private void Awake()
	{
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x0003E768 File Offset: 0x0003C968
	public NPCDialogue_Layout()
	{
		if (150 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x040015C4 RID: 5572
	public static NPCDialogue_Layout Instance;

	// Token: 0x040015C5 RID: 5573
	public int BackingTextPadding;

	// Token: 0x040015C6 RID: 5574
	public int BackingTextPaddingController;

	// Token: 0x040015C7 RID: 5575
	public int MinTextHeight;

	// Token: 0x040015C8 RID: 5576
	public int TextBackingOffset;

	// Token: 0x040015C9 RID: 5577
	public int MaxWidthLastLineAddition = 150;

	// Token: 0x040015CA RID: 5578
	public Panel_Layout Backing;

	// Token: 0x040015CB RID: 5579
	public String_Layout Text;

	// Token: 0x040015CC RID: 5580
	public Panel_Layout TextBacking;

	// Token: 0x040015CD RID: 5581
	public Panel_Layout MenuDivider;

	// Token: 0x040015CE RID: 5582
	public TransactionButton_Layout Close;

	// Token: 0x040015CF RID: 5583
	public TransactionButton_Layout Option1;

	// Token: 0x040015D0 RID: 5584
	public TransactionButton_Layout Option2;

	// Token: 0x040015D1 RID: 5585
	public TransactionButton_Layout Happiness;

	// Token: 0x040015D2 RID: 5586
	public String_Layout Option1Cost;

	// Token: 0x040015D3 RID: 5587
	public String_Layout Option1CostController;

	// Token: 0x040015D4 RID: 5588
	public TransactionButton_Layout CornerImage;

	// Token: 0x040015D5 RID: 5589
	public TransactionButton_Layout CornerImageController;

	// Token: 0x040015D6 RID: 5590
	public String_Layout CornerText;

	// Token: 0x040015D7 RID: 5591
	public String_Layout CornerTextController;

	// Token: 0x040015D8 RID: 5592
	public String_Layout DialogueItemName;

	// Token: 0x040015D9 RID: 5593
	public Panel_Layout DialogueItemNameDivider;

	// Token: 0x040015DA RID: 5594
	public Panel_Layout DialogueItem;

	// Token: 0x040015DB RID: 5595
	public Panel_Layout DialogueItemBacking;

	// Token: 0x040015DC RID: 5596
	public NPCDialogue_Layout.Icons_Layout Icons;

	// Token: 0x0200022A RID: 554
	[Serializable]
	public class Icons_Layout
	{
		// Token: 0x06000CEA RID: 3306 RVA: 0x0003E790 File Offset: 0x0003C990
		public Icons_Layout()
		{
		}

		// Token: 0x040015DD RID: 5597
		public Texture_Layout SaveIcon;

		// Token: 0x040015DE RID: 5598
		public Texture_Layout EditIcon;

		// Token: 0x040015DF RID: 5599
		public Texture_Layout ShopIcon;

		// Token: 0x040015E0 RID: 5600
		public Texture_Layout StatusIcon;

		// Token: 0x040015E1 RID: 5601
		public Texture_Layout StatusIconShimmered;

		// Token: 0x040015E2 RID: 5602
		public Texture_Layout StrangePlantsIcon;

		// Token: 0x040015E3 RID: 5603
		public Texture_Layout StrangePlantsIconShimmered;

		// Token: 0x040015E4 RID: 5604
		public Texture_Layout HairIcon;

		// Token: 0x040015E5 RID: 5605
		public Texture_Layout HairIconShimmered;

		// Token: 0x040015E6 RID: 5606
		public Texture_Layout HealIcon;

		// Token: 0x040015E7 RID: 5607
		public Texture_Layout HealIconShimmered;

		// Token: 0x040015E8 RID: 5608
		public Texture_Layout CollectIcon;

		// Token: 0x040015E9 RID: 5609
		public Texture_Layout CollectIconShimmered;

		// Token: 0x040015EA RID: 5610
		public Texture_Layout ReforgeIcon;

		// Token: 0x040015EB RID: 5611
		public Texture_Layout ReforgeIconShimmered;

		// Token: 0x040015EC RID: 5612
		public Texture_Layout CraftIcon;

		// Token: 0x040015ED RID: 5613
		public Texture_Layout HelpIcon;

		// Token: 0x040015EE RID: 5614
		public Texture_Layout CurseIcon;

		// Token: 0x040015EF RID: 5615
		public Texture_Layout QuestIcon;

		// Token: 0x040015F0 RID: 5616
		public Texture_Layout QuestIconShimmered;

		// Token: 0x040015F1 RID: 5617
		public Texture_Layout BartenderIcon;

		// Token: 0x040015F2 RID: 5618
		public Texture_Layout BartenderIconShimmered;

		// Token: 0x040015F3 RID: 5619
		public Texture_Layout PetIcon;

		// Token: 0x040015F4 RID: 5620
		public Texture_Layout MusicIcon;

		// Token: 0x040015F5 RID: 5621
		public Texture_Layout MusicIconShimmered;

		// Token: 0x040015F6 RID: 5622
		public Texture_Layout PainterIcon;

		// Token: 0x040015F7 RID: 5623
		public Texture_Layout PainterIconShimmered;
	}
}
