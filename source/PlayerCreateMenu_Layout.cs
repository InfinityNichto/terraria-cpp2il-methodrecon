using System;

// Token: 0x0200020A RID: 522
public class PlayerCreateMenu_Layout : LayoutDefinition
{
	// Token: 0x06000CB2 RID: 3250 RVA: 0x0003E164 File Offset: 0x0003C364
	private void Awake()
	{
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x0003E174 File Offset: 0x0003C374
	public PlayerCreateMenu_Layout()
	{
		if (39322 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x0400132E RID: 4910
	public static PlayerCreateMenu_Layout Instance;

	// Token: 0x0400132F RID: 4911
	public Panel_Layout Backing;

	// Token: 0x04001330 RID: 4912
	public Panel_Layout Greyout;

	// Token: 0x04001331 RID: 4913
	public StringButton_Layout Title;

	// Token: 0x04001332 RID: 4914
	public Panel_Layout CharacterBacking;

	// Token: 0x04001333 RID: 4915
	public Panel_Layout CharacterPosition;

	// Token: 0x04001334 RID: 4916
	public TransactionButton_Layout Info;

	// Token: 0x04001335 RID: 4917
	public TransactionButton_Layout Gender;

	// Token: 0x04001336 RID: 4918
	public TransactionButton_Layout ChangeHair;

	// Token: 0x04001337 RID: 4919
	public TransactionButton_Layout Hair;

	// Token: 0x04001338 RID: 4920
	public TransactionButton_Layout Eyes;

	// Token: 0x04001339 RID: 4921
	public TransactionButton_Layout Skin;

	// Token: 0x0400133A RID: 4922
	public TransactionButton_Layout Shirt;

	// Token: 0x0400133B RID: 4923
	public TransactionButton_Layout Undershirt;

	// Token: 0x0400133C RID: 4924
	public TransactionButton_Layout Pants;

	// Token: 0x0400133D RID: 4925
	public TransactionButton_Layout Shoes;

	// Token: 0x0400133E RID: 4926
	public Panel_Layout MenuDivider;

	// Token: 0x0400133F RID: 4927
	public String_Layout NameTitle;

	// Token: 0x04001340 RID: 4928
	public TransactionButton_Layout PlayerName;

	// Token: 0x04001341 RID: 4929
	public String_Layout PlayerNameEdit;

	// Token: 0x04001342 RID: 4930
	public String_Layout DifficultyTitle;

	// Token: 0x04001343 RID: 4931
	public TransactionButton_Layout Difficulty;

	// Token: 0x04001344 RID: 4932
	public TransactionButton_Layout TypeDescription;

	// Token: 0x04001345 RID: 4933
	public Panel_Layout OptionsGreyout;

	// Token: 0x04001346 RID: 4934
	public Panel_Layout OptionsBacking;

	// Token: 0x04001347 RID: 4935
	public TransactionButton_Layout SoftcoreOption;

	// Token: 0x04001348 RID: 4936
	public TransactionButton_Layout MediumCoreOption;

	// Token: 0x04001349 RID: 4937
	public TransactionButton_Layout HardCoreOption;

	// Token: 0x0400134A RID: 4938
	public TransactionButton_Layout JourneyOption;

	// Token: 0x0400134B RID: 4939
	public StringButton_Layout Softcore;

	// Token: 0x0400134C RID: 4940
	public StringButton_Layout MediumCore;

	// Token: 0x0400134D RID: 4941
	public StringButton_Layout HardCore;

	// Token: 0x0400134E RID: 4942
	public StringButton_Layout DifficultyDescription;

	// Token: 0x0400134F RID: 4943
	public Panel_Layout StyleBacking;

	// Token: 0x04001350 RID: 4944
	public Panel_Layout SelectedStyleBacking;

	// Token: 0x04001351 RID: 4945
	public ItemGrid_Layout MalePresetsGrid;

	// Token: 0x04001352 RID: 4946
	public ItemGrid_Layout FemalePresetsGrid;

	// Token: 0x04001353 RID: 4947
	public TransactionButton_Layout Male;

	// Token: 0x04001354 RID: 4948
	public TransactionButton_Layout Female;

	// Token: 0x04001355 RID: 4949
	public TransactionButton_Layout Randomise;

	// Token: 0x04001356 RID: 4950
	public Panel_Layout MenuDivider2;

	// Token: 0x04001357 RID: 4951
	public DraggableItemGrid_Layout HairGrid;

	// Token: 0x04001358 RID: 4952
	public float HairScale;

	// Token: 0x04001359 RID: 4953
	public float HairHighlightScale;

	// Token: 0x0400135A RID: 4954
	public Panel_Layout SliderBacking;

	// Token: 0x0400135B RID: 4955
	public TransactionButton_Layout LightnessBacking;

	// Token: 0x0400135C RID: 4956
	public Slider_Layout Lightness;

	// Token: 0x0400135D RID: 4957
	public TransactionButton_Layout SaturationBacking;

	// Token: 0x0400135E RID: 4958
	public Slider_Layout Saturation;

	// Token: 0x0400135F RID: 4959
	public TransactionButton_Layout HueBacking;

	// Token: 0x04001360 RID: 4960
	public Slider_Layout Hue;

	// Token: 0x04001361 RID: 4961
	public TransactionButton_Layout ColourValue;

	// Token: 0x04001362 RID: 4962
	public TransactionButton_Layout ColourRandomise;

	// Token: 0x04001363 RID: 4963
	public TransactionButton_Layout Create;

	// Token: 0x04001364 RID: 4964
	public TransactionButton_Layout Back;
}
