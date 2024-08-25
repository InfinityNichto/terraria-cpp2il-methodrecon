using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;

// Token: 0x0200013C RID: 316
public class GUIEmotesWindow
{
	// Token: 0x06000860 RID: 2144 RVA: 0x00021FA0 File Offset: 0x000201A0
	public static void LoadContent(ContentManager content)
	{
		if (!true)
		{
		}
		string text2;
		string text = "Images/Extra_" + text2;
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00021FC0 File Offset: 0x000201C0
	public void SetDisplayingEmotes(bool value)
	{
		bool displayingEmotes = this.DisplayingEmotes;
		GUIInputRegionExclusive guiinputRegionExclusive;
		this.PickingInterceptor = guiinputRegionExclusive;
		guiinputRegionExclusive.Active = true;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00021FEC File Offset: 0x000201EC
	public bool IsOver(Vector2 cursorPosition)
	{
		if (this.DisplayingEmotes)
		{
			return true;
		}
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00022004 File Offset: 0x00020204
	public void SetCategory(GUIEmotesWindow.Category cat)
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x000021DB File Offset: 0x000003DB
	private void GetEmotesGeneral(List<int> emotes)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x000021DB File Offset: 0x000003DB
	private void GetEmotesRPS(List<int> emotes)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x000021DB File Offset: 0x000003DB
	private void GetEmotesItems(List<int> emotes)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x000021DB File Offset: 0x000003DB
	private void GetEmotesBiomesAndEvents(List<int> emotes)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x000021DB File Offset: 0x000003DB
	private void GetEmotesTownNPCs(List<int> emotes)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x000021DB File Offset: 0x000003DB
	private void GetEmotesCritters(List<int> emotes)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x000021DB File Offset: 0x000003DB
	private void GetEmotesBosses(List<int> emotes)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0002201C File Offset: 0x0002021C
	public void Draw()
	{
		int frameCounter;
		do
		{
			frameCounter = this._frameCounter;
			GUIInputRegionExclusive pickingInterceptor = this.PickingInterceptor;
			this._frameCounter = frameCounter;
			if (pickingInterceptor != null)
			{
			}
			if (pickingInterceptor == null)
			{
			}
		}
		while (frameCounter == 0);
		if (frameCounter == 0)
		{
		}
		if (!true)
		{
		}
		Main.FlushBatches();
		this.DrawEntries();
		this.DrawCategories();
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		GUIInputRegionExclusive pickingInterceptor2 = this.PickingInterceptor;
		if (pickingInterceptor2 != null)
		{
			int num = 1;
			pickingInterceptor2.Active = num != 0;
		}
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00022080 File Offset: 0x00020280
	private void DrawBacking()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00022094 File Offset: 0x00020294
	private void DrawEntries()
	{
		List<int> emoteEntries = this._emoteEntries;
		int size = emoteEntries._size;
		if (emoteEntries == null)
		{
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x000220B4 File Offset: 0x000202B4
	private void DrawCategories()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int num = 17096;
		this.TimeSinceItemChange = (float)num;
		long num2 = 0L;
		GUIEmotesWindow.Category currentSelection = this.CurrentSelection;
		this.CurrentSelection = (GUIEmotesWindow.Category)num2;
		long num3 = 0L;
		GUIEmotesWindow.Category currentSelection2 = this.CurrentSelection;
		this.CurrentSelection = (GUIEmotesWindow.Category)num3;
		GUIEmotesWindow.Category currentSelection3 = this.CurrentSelection;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		GUIEmotesWindow.Category currentSelection4 = this.CurrentSelection;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUIEmotesWindow.Category currentSelection5 = this.CurrentSelection;
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUIEmotesWindow.Category currentSelection6 = this.CurrentSelection;
		GUITransactionButton.InputState inputState4;
		if (inputState4 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUIEmotesWindow.Category currentSelection7 = this.CurrentSelection;
		GUITransactionButton.InputState inputState5;
		if (inputState5 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUIEmotesWindow.Category currentSelection8 = this.CurrentSelection;
		GUITransactionButton.InputState inputState6;
		if (inputState6 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUITransactionButton.InputState inputState7;
		if (inputState7 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUIEmotesWindow.Category currentSelection9 = this.CurrentSelection;
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x000021DB File Offset: 0x000003DB
	public float EmoteScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x000221A4 File Offset: 0x000203A4
	public void EmoteOver(int index)
	{
		int num = 1;
		this.emoteOver = index;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x00022278 File Offset: 0x00020478
	public void EmoteDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (this._emoteEntries._size == 0)
		{
		}
		if (this.emoteOver == 0)
		{
		}
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x000222F8 File Offset: 0x000204F8
	private Rectangle GetFrame(int emoteIndex)
	{
		int frameCounter = this._frameCounter;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00022310 File Offset: 0x00020510
	public GUIEmotesWindow()
	{
	}

	// Token: 0x04000734 RID: 1844
	public List<int> _emoteEntries;

	// Token: 0x04000735 RID: 1845
	private static Asset<Texture2D> _emoteTexture;

	// Token: 0x04000736 RID: 1846
	private static Asset<Texture2D> _emoteTextureBorder;

	// Token: 0x04000737 RID: 1847
	private int _frameCounter;

	// Token: 0x04000738 RID: 1848
	private GUIEmotesWindow.Category CurrentSelection;

	// Token: 0x04000739 RID: 1849
	private float TimeSinceItemChange = (float)1;

	// Token: 0x0400073A RID: 1850
	private int emoteOver;

	// Token: 0x0400073B RID: 1851
	public bool DisplayingEmotes;

	// Token: 0x0400073C RID: 1852
	public GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x0400073D RID: 1853
	private float EmotesCloseScale;

	// Token: 0x0400073E RID: 1854
	private float emotesGeneralScale;

	// Token: 0x0400073F RID: 1855
	private float emotesRPSScale;

	// Token: 0x04000740 RID: 1856
	private float emotesItemsScale;

	// Token: 0x04000741 RID: 1857
	private float emotesBiomesAndEventsScale;

	// Token: 0x04000742 RID: 1858
	private float emotesTownNPCsScale;

	// Token: 0x04000743 RID: 1859
	private float emotesCrittersScale;

	// Token: 0x04000744 RID: 1860
	private float emotesBossesScale;

	// Token: 0x04000745 RID: 1861
	public float emoteScrollOffset;

	// Token: 0x04000746 RID: 1862
	private float emoteScrollMomentum;

	// Token: 0x04000747 RID: 1863
	private int emoteScrollDragging;

	// Token: 0x04000748 RID: 1864
	private Vector2 emoteDragOffset;

	// Token: 0x04000749 RID: 1865
	private float TitleScale;

	// Token: 0x0200013D RID: 317
	public enum Category
	{
		// Token: 0x0400074B RID: 1867
		General,
		// Token: 0x0400074C RID: 1868
		RPS,
		// Token: 0x0400074D RID: 1869
		Items,
		// Token: 0x0400074E RID: 1870
		BiomesAndEvents,
		// Token: 0x0400074F RID: 1871
		TownNPCs,
		// Token: 0x04000750 RID: 1872
		Critters,
		// Token: 0x04000751 RID: 1873
		Bosses
	}
}
