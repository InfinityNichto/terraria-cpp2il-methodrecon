using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000227 RID: 551
internal class MultiplayerChat_Layout : LayoutDefinition
{
	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x000021DB File Offset: 0x000003DB
	public static MultiplayerChat_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000021DB File Offset: 0x000003DB
	public static MultiplayerChat_Layout EmotesWindowInstance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000021DB File Offset: 0x000003DB
	public static MultiplayerChat_Layout MiniChatInstance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x0003E694 File Offset: 0x0003C894
	private void Awake()
	{
		bool flag = this.name.Contains("Left");
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x0003E6EC File Offset: 0x0003C8EC
	public MultiplayerChat_Layout()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		this.ItemTextInset = 1;
		if (!true)
		{
		}
		this.PlayerNameMaxLen = (float)16968;
		this.ChattingTextColor = 1;
		this.EmoteIconScale = (float)16256;
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001590 RID: 5520
	public static bool FromPage;

	// Token: 0x04001591 RID: 5521
	public static MultiplayerChat_Layout _instance;

	// Token: 0x04001592 RID: 5522
	public static MultiplayerChat_Layout _miniChatInstance;

	// Token: 0x04001593 RID: 5523
	public static MultiplayerChat_Layout _instanceMobile;

	// Token: 0x04001594 RID: 5524
	public static MultiplayerChat_Layout _miniChatInstanceMobile;

	// Token: 0x04001595 RID: 5525
	public static MultiplayerChat_Layout _instanceLeft;

	// Token: 0x04001596 RID: 5526
	public static MultiplayerChat_Layout _instanceRight;

	// Token: 0x04001597 RID: 5527
	public Panel_Layout Backing;

	// Token: 0x04001598 RID: 5528
	public Vector2 BackingNotificationTLOffset;

	// Token: 0x04001599 RID: 5529
	public Vector2 BackingNotificationBROffset;

	// Token: 0x0400159A RID: 5530
	public Panel_Layout BackingNotification;

	// Token: 0x0400159B RID: 5531
	public TransactionButton_Layout Toggle;

	// Token: 0x0400159C RID: 5532
	public TransactionButton_Layout ToggleOpen;

	// Token: 0x0400159D RID: 5533
	public ItemGrid_Layout NotificationGrid;

	// Token: 0x0400159E RID: 5534
	public DraggableItemGrid_Layout TextGrid;

	// Token: 0x0400159F RID: 5535
	public Panel_Layout ItemIcon;

	// Token: 0x040015A0 RID: 5536
	public String_Layout ItemWho;

	// Token: 0x040015A1 RID: 5537
	public Panel_Layout ItemBacking;

	// Token: 0x040015A2 RID: 5538
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x040015A3 RID: 5539
	public String_Layout ItemText;

	// Token: 0x040015A4 RID: 5540
	public Vector2 ItemTextInset;

	// Token: 0x040015A5 RID: 5541
	public Panel_Layout BeginChatBacking;

	// Token: 0x040015A6 RID: 5542
	public Panel_Layout BeginChatDivider;

	// Token: 0x040015A7 RID: 5543
	public TransactionButton_Layout BeginChat;

	// Token: 0x040015A8 RID: 5544
	public TransactionButton_Layout BeginChatBarsUI;

	// Token: 0x040015A9 RID: 5545
	public String_Layout ChatText;

	// Token: 0x040015AA RID: 5546
	public Color ChattingTextColor;

	// Token: 0x040015AB RID: 5547
	public float TextWrapSize;

	// Token: 0x040015AC RID: 5548
	public float TextWrapSizeBarsUI;

	// Token: 0x040015AD RID: 5549
	public String_Layout PlayerNameText;

	// Token: 0x040015AE RID: 5550
	public float PlayerNameMaxLen;

	// Token: 0x040015AF RID: 5551
	public Panel_Layout EmotesGridBacking;

	// Token: 0x040015B0 RID: 5552
	public StringButton_Layout EmotesTitle;

	// Token: 0x040015B1 RID: 5553
	public Panel_Layout EmotesMenuDivider;

	// Token: 0x040015B2 RID: 5554
	public Panel_Layout EmotesMenuDivider2;

	// Token: 0x040015B3 RID: 5555
	public TransactionButton_Layout EmotesGeneral;

	// Token: 0x040015B4 RID: 5556
	public TransactionButton_Layout EmotesRPS;

	// Token: 0x040015B5 RID: 5557
	public TransactionButton_Layout EmotesItems;

	// Token: 0x040015B6 RID: 5558
	public TransactionButton_Layout EmotesBiomesAndEvents;

	// Token: 0x040015B7 RID: 5559
	public TransactionButton_Layout EmotesTownNPCs;

	// Token: 0x040015B8 RID: 5560
	public TransactionButton_Layout EmotesCritters;

	// Token: 0x040015B9 RID: 5561
	public TransactionButton_Layout EmotesBosses;

	// Token: 0x040015BA RID: 5562
	public DraggableItemGrid_Layout EmotesGrid;

	// Token: 0x040015BB RID: 5563
	public TransactionButton_Layout PrimaryChat;

	// Token: 0x040015BC RID: 5564
	public TransactionButton_Layout Emote;

	// Token: 0x040015BD RID: 5565
	public TransactionButton_Layout EmotesClose;

	// Token: 0x040015BE RID: 5566
	public float EmoteScale;

	// Token: 0x040015BF RID: 5567
	public Vector2 EmoteIconOffset;

	// Token: 0x040015C0 RID: 5568
	public float EmoteIconScale;
}
