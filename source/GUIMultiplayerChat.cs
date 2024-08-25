using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.UI.Chat;

// Token: 0x0200015A RID: 346
public class GUIMultiplayerChat
{
	// Token: 0x0600097A RID: 2426 RVA: 0x0002B310 File Offset: 0x00029510
	public void LoadPageRegion()
	{
		ControlAnchor.PageContentRegion = GUIPanel.Region(MultiplayerChat_Layout.Instance.Backing);
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x0002B334 File Offset: 0x00029534
	public Vector2 ChatSize(int index)
	{
		bool netClient = Main.NetClient;
		GUIMultiplayerChat.ChatMode chatMode = this.mode;
		int num = this.notificationCount;
		float y = this.oneLineSize.Y;
		throw new InvalidCastException();
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x000021DB File Offset: 0x000003DB
	private float ChatScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x0002B36C File Offset: 0x0002956C
	private void ChatOver(int index)
	{
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x0600097E RID: 2430 RVA: 0x000021DB File Offset: 0x000003DB
	public float MaxChatLineWidth
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x0600097F RID: 2431 RVA: 0x000021DB File Offset: 0x000003DB
	public float MaxMiniChatLineWidth
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000980 RID: 2432 RVA: 0x000021DB File Offset: 0x000003DB
	public float MaxMiniTouchChatLineWidth
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0002B390 File Offset: 0x00029590
	public Vector2 CalulatePageSnippetSize(TextSnippet[] parsedText)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x0002B3A8 File Offset: 0x000295A8
	public Vector2 CalulateMiniSnippetSize(TextSnippet[] parsedText)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0002B3C0 File Offset: 0x000295C0
	public Vector2 CalulateMiniTouchSnippetSize(TextSnippet[] parsedText)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x0002B3D8 File Offset: 0x000295D8
	private void ChatDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x0002B4E0 File Offset: 0x000296E0
	public void CloseChat()
	{
		if (!true)
		{
		}
		Main.clrInput();
		Main.CloseKeyboard();
		this.mode = GUIMultiplayerChat.ChatMode.DisplayNotification;
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x0002B508 File Offset: 0x00029708
	public void DrawNotification()
	{
		MultiplayerChat_Layout instance = MultiplayerChat_Layout.Instance;
		MultiplayerChat_Layout miniChatInstance = MultiplayerChat_Layout.MiniChatInstance;
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUIMultiplayerChat.ChatMode chatMode = this.mode;
		if (chatMode == GUIMultiplayerChat.ChatMode.Hidden)
		{
		}
		bool mapFullscreen = Main.mapFullscreen;
		if (chatMode == GUIMultiplayerChat.ChatMode.Hidden)
		{
		}
		Main.CloseKeyboard();
		if (this.mode != GUIMultiplayerChat.ChatMode.Hidden)
		{
			return;
		}
		int num = 1;
		this.mode = (GUIMultiplayerChat.ChatMode)num;
		if (num == 0)
		{
		}
		float y = miniChatInstance.NotificationGrid.ExtraElementSpacing.Y;
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x0002B7E4 File Offset: 0x000299E4
	public void OpenChat()
	{
		if (!true)
		{
		}
		bool hasChatPermissions = DrPlatform.User.HasChatPermissions;
		this.mode = GUIMultiplayerChat.ChatMode.Shown;
		if (2 == 0)
		{
		}
		Main.clrInput();
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x0002B810 File Offset: 0x00029A10
	public void Draw()
	{
		MultiplayerChat_Layout instance = MultiplayerChat_Layout.Instance;
		MultiplayerChat_Layout miniChatInstance = MultiplayerChat_Layout.MiniChatInstance;
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUIMultiplayerChat.ChatMode chatMode = this.mode;
		Panel_Layout backing = miniChatInstance.Backing;
		Cursor cursor;
		if (cursor != null)
		{
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			Panel_Layout backing2 = miniChatInstance.Backing;
			DraggableItemGrid_Layout textGrid = miniChatInstance.TextGrid;
			return;
		}
		if (miniChatInstance.TextGrid == null)
		{
		}
		Panel_Layout beginChatBacking = miniChatInstance.BeginChatBacking;
		Panel_Layout beginChatDivider = miniChatInstance.BeginChatDivider;
		bool hasChatPermissions = DrPlatform.User.HasChatPermissions;
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0002BC14 File Offset: 0x00029E14
	public GUIMultiplayerChat()
	{
	}

	// Token: 0x04000948 RID: 2376
	private float NoficiationDisplayTime;

	// Token: 0x04000949 RID: 2377
	public GUIMultiplayerChat.ChatMode mode;

	// Token: 0x0400094A RID: 2378
	public float ScrollOffset;

	// Token: 0x0400094B RID: 2379
	private float ScrollMomentum;

	// Token: 0x0400094C RID: 2380
	private int ScrollDragging;

	// Token: 0x0400094D RID: 2381
	private Vector2 DragOffset;

	// Token: 0x0400094E RID: 2382
	private float ToggleScale;

	// Token: 0x0400094F RID: 2383
	private float BeginChatScale;

	// Token: 0x04000950 RID: 2384
	private float PrimaryChatScale;

	// Token: 0x04000951 RID: 2385
	private float EmotesScale;

	// Token: 0x04000952 RID: 2386
	private float EmotesCloseScale;

	// Token: 0x04000953 RID: 2387
	private Vector2 oneLineSize;

	// Token: 0x04000954 RID: 2388
	private int notificationCount;

	// Token: 0x04000955 RID: 2389
	private bool miniMapWasEnabled;

	// Token: 0x04000956 RID: 2390
	private bool beginChatClicked;

	// Token: 0x0200015B RID: 347
	public enum ChatMode
	{
		// Token: 0x04000958 RID: 2392
		Hidden,
		// Token: 0x04000959 RID: 2393
		DisplayNotification,
		// Token: 0x0400095A RID: 2394
		Shown
	}
}
