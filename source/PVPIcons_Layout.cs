using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000232 RID: 562
public class PVPIcons_Layout : PageControllerLayoutDefinition<PVPIcons_Layout>
{
	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000CFC RID: 3324 RVA: 0x000021DB File Offset: 0x000003DB
	public ItemGrid_Layout TeamGridLayout
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0003E938 File Offset: 0x0003CB38
	public DraggableItemGrid_Layout Grid
	{
		get
		{
			DraggableItemGrid_Layout draggableItemGrid_Layout;
			return draggableItemGrid_Layout;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000CFE RID: 3326 RVA: 0x000021DB File Offset: 0x000003DB
	public TransactionButton_Layout PVPIcon
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000021DB File Offset: 0x000003DB
	public TransactionButton_Layout PlayerTeamIcon
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x0003E948 File Offset: 0x0003CB48
	public PVPIcons_Layout()
	{
	}

	// Token: 0x0400169C RID: 5788
	public String_Layout Title;

	// Token: 0x0400169D RID: 5789
	public TransactionButton_Layout PlatformInvite;

	// Token: 0x0400169E RID: 5790
	public TransactionButton_Layout PVP;

	// Token: 0x0400169F RID: 5791
	public TransactionButton_Layout PVP_Horizontal;

	// Token: 0x040016A0 RID: 5792
	public ItemGrid_Layout TeamGrid;

	// Token: 0x040016A1 RID: 5793
	public ItemGrid_Layout TeamGrid_Horizontal;

	// Token: 0x040016A2 RID: 5794
	public Vector2 TeamGridLocationTouch;

	// Token: 0x040016A3 RID: 5795
	public Vector2 TeamGridOffset;

	// Token: 0x040016A4 RID: 5796
	public Vector2 TeamGridControllerOffset;

	// Token: 0x040016A5 RID: 5797
	public Panel_Layout TeamGridBacking;

	// Token: 0x040016A6 RID: 5798
	public Vector2 TeamBackingTLOffset;

	// Token: 0x040016A7 RID: 5799
	public Vector2 TeamBackingBROffset;

	// Token: 0x040016A8 RID: 5800
	public Vector2 CharacterDrawOffset = 1;

	// Token: 0x040016A9 RID: 5801
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x040016AA RID: 5802
	public DraggableItemGrid_Layout PlayerGridCollapsed;

	// Token: 0x040016AB RID: 5803
	public TransactionButton_Layout PlayerTeam;

	// Token: 0x040016AC RID: 5804
	public TransactionButton_Layout PlayerTeam_Horizontal;

	// Token: 0x040016AD RID: 5805
	public String_Layout SelectedPlayerName;

	// Token: 0x040016AE RID: 5806
	public Panel_Layout SelectedPlayerNameDivider;

	// Token: 0x040016AF RID: 5807
	public TransactionButton_Layout SelectedPlayerTeam;

	// Token: 0x040016B0 RID: 5808
	public String_Layout SelectedPlayerTeamName;

	// Token: 0x040016B1 RID: 5809
	public TransactionButton_Layout SelectedPlayerTeleport;

	// Token: 0x040016B2 RID: 5810
	public TransactionButton_Layout SelectedPlayerVoiceMute;

	// Token: 0x040016B3 RID: 5811
	public TransactionButton_Layout SelectedPlayerVoiceUnMute;

	// Token: 0x040016B4 RID: 5812
	public TransactionButton_Layout SelectedPlayerMap;

	// Token: 0x040016B5 RID: 5813
	public TransactionButton_Layout SelectedPlayerViewPlatformProfile;

	// Token: 0x040016B6 RID: 5814
	public TransactionButton_Layout SelectedPlayerClose;

	// Token: 0x040016B7 RID: 5815
	public Panel_Layout SelectedPlayerDivider;

	// Token: 0x040016B8 RID: 5816
	public Panel_Layout SelectedPlayerDivider2;

	// Token: 0x040016B9 RID: 5817
	public Panel_Layout SelectedPlayerHealthBacking;

	// Token: 0x040016BA RID: 5818
	public Button_Layout SelectedPlayerHealthIcon;

	// Token: 0x040016BB RID: 5819
	public String_Layout SelectedPlayerHealth;

	// Token: 0x040016BC RID: 5820
	public Panel_Layout SelectedPlayerManaBacking;

	// Token: 0x040016BD RID: 5821
	public Button_Layout SelectedPlayerManaIcon;

	// Token: 0x040016BE RID: 5822
	public String_Layout SelectedPlayerMana;

	// Token: 0x040016BF RID: 5823
	public Panel_Layout SelectedPlayerBacking;

	// Token: 0x040016C0 RID: 5824
	public String_Layout SelectedPlayerPlatformProfileName;

	// Token: 0x040016C1 RID: 5825
	public Panel_Layout SelectedPlayerPlatformProfileBacking;

	// Token: 0x040016C2 RID: 5826
	public Panel_Layout SelectedPlayerImagePosition;

	// Token: 0x040016C3 RID: 5827
	public Panel_Layout SelectedPlayerImageClipRegion;

	// Token: 0x040016C4 RID: 5828
	public Vector2 SelectedPlayerImageDrawOffset;

	// Token: 0x040016C5 RID: 5829
	public Panel_Layout PlayerClipRegion;

	// Token: 0x040016C6 RID: 5830
	public float TeamScale;

	// Token: 0x040016C7 RID: 5831
	public float TeamIconScale = (float)16384;

	// Token: 0x040016C8 RID: 5832
	public Vector2 TeamIconOffset;

	// Token: 0x040016C9 RID: 5833
	public float PlayerScale;

	// Token: 0x040016CA RID: 5834
	public float PlayerIconScale = (float)16256;

	// Token: 0x040016CB RID: 5835
	public Vector2 PlayerIconOffset;

	// Token: 0x040016CC RID: 5836
	public Vector2 PlayerHeadOffset;

	// Token: 0x040016CD RID: 5837
	public float PlayerHeadScale;

	// Token: 0x040016CE RID: 5838
	public float TalkingIconScale;

	// Token: 0x040016CF RID: 5839
	public Vector2 TalkIconOffset;

	// Token: 0x040016D0 RID: 5840
	public Texture_Layout TalkingIcon;

	// Token: 0x040016D1 RID: 5841
	public float MutedIconScale = (float)16256;

	// Token: 0x040016D2 RID: 5842
	public Vector2 MutedIconOffset;

	// Token: 0x040016D3 RID: 5843
	public Texture_Layout MutedIcon;

	// Token: 0x040016D4 RID: 5844
	public Color Team1BackingColour;

	// Token: 0x040016D5 RID: 5845
	public Color Team2BackingColour;

	// Token: 0x040016D6 RID: 5846
	public Color Team3BackingColour;

	// Token: 0x040016D7 RID: 5847
	public Color Team4BackingColour;

	// Token: 0x040016D8 RID: 5848
	public Color Team5BackingColour;

	// Token: 0x040016D9 RID: 5849
	public Color Team6BackingColour;

	// Token: 0x040016DA RID: 5850
	public Color TeamBackingColourDisabled;

	// Token: 0x040016DB RID: 5851
	public Color TeamIconColourDisabled;

	// Token: 0x040016DC RID: 5852
	public Color Team1PlayerBackingColour;

	// Token: 0x040016DD RID: 5853
	public Color Team2PlayerBackingColour;

	// Token: 0x040016DE RID: 5854
	public Color Team3PlayerBackingColour;

	// Token: 0x040016DF RID: 5855
	public Color Team4PlayerBackingColour;

	// Token: 0x040016E0 RID: 5856
	public Color Team5PlayerBackingColour;

	// Token: 0x040016E1 RID: 5857
	public Color Team6PlayerBackingColour;

	// Token: 0x040016E2 RID: 5858
	public Color EmptySlotColour;

	// Token: 0x040016E3 RID: 5859
	public Color EmptySlotIconColour;

	// Token: 0x040016E4 RID: 5860
	public float EmptySlotIconScale;

	// Token: 0x040016E5 RID: 5861
	public Texture_Layout EmptySlotIcon;

	// Token: 0x040016E6 RID: 5862
	public float CharacterScale = (float)16256;

	// Token: 0x040016E7 RID: 5863
	public String_Layout TeamCooldownCounter;
}
