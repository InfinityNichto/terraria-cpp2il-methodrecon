using System;
using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.UI;

// Token: 0x02000137 RID: 311
public class GUICraftGuidePopup
{
	// Token: 0x06000817 RID: 2071 RVA: 0x0001FF84 File Offset: 0x0001E184
	public void LoadRegion()
	{
		int num = this.focusGuideRecipe;
		int selectedNumMaterials = this.SelectedNumMaterials;
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
	public Rectangle GetRegion()
	{
		int num = this.focusGuideRecipe;
		int selectedNumMaterials = this.SelectedNumMaterials;
		this.UpdateText();
		float y = this.CachedTextSize.Y;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x0001FFFC File Offset: 0x0001E1FC
	public void OpenPopup()
	{
		if (!this.PopupDisplayed)
		{
			GUIInputRegionExclusive guiinputRegionExclusive;
			this.PickingInterceptor = guiinputRegionExclusive;
			guiinputRegionExclusive.Active = true;
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
		this.FindRecipes();
		this.PopupDisplayed = true;
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00020034 File Offset: 0x0001E234
	public void ClosePopup()
	{
		if (!this.PopupDisplayed || this.PickingInterceptor != null)
		{
		}
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00020054 File Offset: 0x0001E254
	public bool IsOver(Vector2 cursorPosition)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		bool flag;
		return flag;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x00020090 File Offset: 0x0001E290
	public void LoadPanelRegion()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x000200AC File Offset: 0x0001E2AC
	private void DrawItem()
	{
		int num = this.focusGuideRecipe;
		int num2 = this.focusGuideRecipe;
		int[] array = this.availableGuideRecipe;
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x0600081E RID: 2078 RVA: 0x00020100 File Offset: 0x0001E300
	public int SelectedNumMaterials
	{
		get
		{
			int[] array = this.availableGuideRecipe;
			return 15;
		}
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00020118 File Offset: 0x0001E318
	private void DrawMaterials()
	{
		this.cursorOver = 1;
		int selectedNumMaterials = this.SelectedNumMaterials;
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x000021DB File Offset: 0x000003DB
	public float MaterialItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x00020134 File Offset: 0x0001E334
	public void MaterialItemOver(int index)
	{
		if (!true)
		{
		}
		int[] array = this.availableGuideRecipe;
		this.cursorOver = index;
		if (array == null)
		{
			this._controller.GridNav.Activate(index);
		}
		if (array == null)
		{
		}
		ItemSlot.UpdateTooltipContext(22, index);
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00020184 File Offset: 0x0001E384
	public void MaterialItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (!true)
		{
		}
		int[] array = this.availableGuideRecipe;
		if (this.cursorOver == 0)
		{
		}
		int num = 1;
		if (num == 0)
		{
		}
		int num2 = 1;
		if (num == 0)
		{
		}
		Main.inventoryScale = scale;
		if (num2 == 0)
		{
		}
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x000021DB File Offset: 0x000003DB
	private void UpdateText()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x000201CC File Offset: 0x0001E3CC
	private void DrawText()
	{
		string text = this.displayString;
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x000201E0 File Offset: 0x0001E3E0
	public void Draw()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		Main.FlushBatches();
		if (this.PickingInterceptor != null)
		{
		}
		GUIControllerCraftingGuidePopup controller = this._controller;
		this._controller.Activate();
		this.FindRecipes();
		int num = this.focusGuideRecipe;
		int selectedNumMaterials = this.SelectedNumMaterials;
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x000202DC File Offset: 0x0001E4DC
	private void DrawGrid()
	{
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
		int num = this.numAvailableGuideRecipes;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x000021DB File Offset: 0x000003DB
	public float CraftItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0002030C File Offset: 0x0001E50C
	public void CraftItemOver(int index)
	{
		this.cursorOver = index;
		int num = this.numAvailableGuideRecipes;
		Item item;
		if (item.type != 0)
		{
			int[] array = this.availableGuideRecipe;
		}
		int num2 = this.focusGuideRecipe;
		int type = item.type;
		if (type != 0)
		{
			if (type == 0)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			if (type == 0)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
		}
		int num3 = this.numAvailableGuideRecipes;
		int type2 = item.type;
		if (type2 != 0)
		{
			if (type2 == 0)
			{
			}
			int[] array2 = this.availableGuideRecipe;
			int[] array3 = this.availableGuideRecipe;
			int num4 = 22;
			Item item2;
			item2.tooltipContext = num4;
			int[] array4 = this.availableGuideRecipe;
			if (num4 == 0)
			{
				int[] array5 = this.availableGuideRecipe;
			}
			ItemSlot.UpdateTooltipContext(40, index);
			return;
		}
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x000203E4 File Offset: 0x0001E5E4
	public void CraftItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (this.cursorOver == 0)
		{
		}
		if (!true)
		{
		}
		int num = this.numAvailableGuideRecipes;
		Item item;
		int type = item.type;
		!0 instance;
		int[] array2;
		if (type != 0)
		{
			if (type == 0)
			{
			}
			int[] array = this.availableGuideRecipe;
			if (type == 0)
			{
			}
			Main.inventoryScale = scale;
			int num2 = this.focusGuideRecipe;
			instance = PageControllerLayoutDefinition.Instance;
			if (array == null)
			{
			}
			ItemSlot.SetSelectHighlight(true, scale);
			if (instance == null)
			{
			}
			array2 = this.availableGuideRecipe;
			return;
		}
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		if (instance != null)
		{
			!0 instance3 = PageControllerLayoutDefinition.Instance;
			!0 instance4 = PageControllerLayoutDefinition.Instance;
			if (array2 == null)
			{
			}
			Texture2D texture2D;
			Vector2 vector = texture2D.Size();
			Texture2D texture2D2;
			Vector2 vector2 = texture2D2.Size();
			int num3 = 1;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			!0 instance5 = PageControllerLayoutDefinition.Instance;
			!0 instance6 = PageControllerLayoutDefinition.Instance;
		}
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x000204AC File Offset: 0x0001E6AC
	public void FindRecipes()
	{
		int[] array = this.availableGuideRecipe;
		Item item;
		int type = item.type;
		int stack = item.stack;
		bool flag = item.Name != "";
		if (stack == 0)
		{
		}
		if (stack != 0)
		{
			int type2 = item.type;
			int type3 = item.type;
			int type4 = item.type;
			int type5 = item.type;
			int type6 = item.type;
			int type7 = item.type;
			while (stack != 0)
			{
			}
			return;
		}
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0002053C File Offset: 0x0001E73C
	public GUICraftGuidePopup()
	{
	}

	// Token: 0x040006E4 RID: 1764
	public GUIControllerCraftingGuidePopup _controller;

	// Token: 0x040006E5 RID: 1765
	public float materialScrollOffset;

	// Token: 0x040006E6 RID: 1766
	private float materialScrollMomentum;

	// Token: 0x040006E7 RID: 1767
	private int materialScrollDragging;

	// Token: 0x040006E8 RID: 1768
	private Vector2 materialDragOffset;

	// Token: 0x040006E9 RID: 1769
	private int cursorOver;

	// Token: 0x040006EA RID: 1770
	private int OpenedFrame;

	// Token: 0x040006EB RID: 1771
	public bool PopupDisplayed;

	// Token: 0x040006EC RID: 1772
	private GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x040006ED RID: 1773
	private List<string> _requiredObjecsForCraftingText;

	// Token: 0x040006EE RID: 1774
	private string materialHoverItemName;

	// Token: 0x040006EF RID: 1775
	private Item materialToolTip;

	// Token: 0x040006F0 RID: 1776
	private int yoyoLogo;

	// Token: 0x040006F1 RID: 1777
	private int researchLine;

	// Token: 0x040006F2 RID: 1778
	private int setBonusLine;

	// Token: 0x040006F3 RID: 1779
	private int materialsLine;

	// Token: 0x040006F4 RID: 1780
	private int numLines;

	// Token: 0x040006F5 RID: 1781
	private string[] toolTipLine;

	// Token: 0x040006F6 RID: 1782
	private bool[] preFixLine;

	// Token: 0x040006F7 RID: 1783
	private bool[] badPreFixLine;

	// Token: 0x040006F8 RID: 1784
	private Item lastItem;

	// Token: 0x040006F9 RID: 1785
	private float CachedLayoutSize;

	// Token: 0x040006FA RID: 1786
	private float CachedLayoutWrapSize;

	// Token: 0x040006FB RID: 1787
	private int CachedMinTextHeight;

	// Token: 0x040006FC RID: 1788
	private Vector2 CachedTextSize;

	// Token: 0x040006FD RID: 1789
	private string displayString;

	// Token: 0x040006FE RID: 1790
	public float craftScrollOffset;

	// Token: 0x040006FF RID: 1791
	private float craftScrollMomentum;

	// Token: 0x04000700 RID: 1792
	private int craftScrollDragging;

	// Token: 0x04000701 RID: 1793
	private Vector2 craftDragOffset;

	// Token: 0x04000702 RID: 1794
	private int _selectedItem;

	// Token: 0x04000703 RID: 1795
	private int multiCraftDelay;

	// Token: 0x04000704 RID: 1796
	public int focusGuideRecipe;

	// Token: 0x04000705 RID: 1797
	public int[] availableGuideRecipe;

	// Token: 0x04000706 RID: 1798
	public int numAvailableGuideRecipes;
}
