using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

// Token: 0x0200011F RID: 287
public class GUIAccessoryInfo
{
	// Token: 0x06000737 RID: 1847 RVA: 0x00019B28 File Offset: 0x00017D28
	public GUIAccessoryInfo()
	{
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00019B3C File Offset: 0x00017D3C
	public void Draw()
	{
		this.BuildInfoAccs();
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int allowRowHeight = RightSideHUDAnchorUpdator.AllowRowHeight;
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x000021DB File Offset: 0x000003DB
	public float ItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00019D84 File Offset: 0x00017F84
	public void ItemOver(int index)
	{
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00019D94 File Offset: 0x00017F94
	public void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
		int num = this.itemOffset;
		int[] displayIcons = this.DisplayIcons;
		string[] infoText = this.InfoText;
		if (num == 0)
		{
		}
		GUIAccessoryInfo.StringState[] infoState = this.InfoState;
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00019E0C File Offset: 0x0001800C
	public void BuildInfoAccs()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (num != 0)
		{
			if (num == 0)
			{
			}
			bool playerInventory = Main.playerInventory;
		}
		string text = "0" + "";
		int num2;
		if ("0" == null)
		{
			num2 = 12;
			return;
		}
		if (num2 == 0)
		{
		}
		int myPlayer3 = Main.myPlayer;
		if (num2 == 0)
		{
		}
		int myPlayer4 = Main.myPlayer;
		int[] displayIcons = this.DisplayIcons;
		string[] iconText = this.IconText;
		if (displayIcons == null)
		{
		}
		if ("00" == null || "00" != null)
		{
			string[] infoText = this.InfoText;
			string text2;
			string text3;
			if ((text2 == null || text2 != null) && (":" == null || ":" != null) && ("00" == null || "00" != null) && (" " == null || " " != null) && ("AM" == null || "AM" != null) && (text3 == null || text3 != null))
			{
				GUIAccessoryInfo.StringState[] infoState = this.InfoState;
				int num3 = this.numInfoAccessories;
				this.numInfoAccessories = num3;
				if (num3 == 0)
				{
				}
				int myPlayer5 = Main.myPlayer;
				if (num3 != 0)
				{
					if (num3 == 0)
					{
					}
					int myPlayer6 = Main.myPlayer;
					if (num3 != 0)
					{
						if (num3 == 0)
						{
						}
						bool playerInventory2 = Main.playerInventory;
					}
					if (num3 == 0)
					{
					}
					return;
				}
				int num4;
				if (num4 == 0)
				{
				}
				int myPlayer7 = Main.myPlayer;
				if (num4 != 0)
				{
					if (num4 == 0)
					{
					}
					int myPlayer8 = Main.myPlayer;
					if (num4 != 0)
					{
						if (num4 == 0)
						{
						}
						bool playerInventory3 = Main.playerInventory;
					}
					if (num4 == 0)
					{
					}
					int num5;
					if (num5 != 0)
					{
						if (num5 == 0)
						{
						}
						if (num4 == 0)
						{
							return;
						}
					}
					if (num4 == 0)
					{
					}
					if (num5 != 0)
					{
						if (num5 == 0)
						{
						}
					}
					else
					{
						int num6 = 7;
						int[] displayIcons2 = this.DisplayIcons;
						string[] iconText2 = this.IconText;
						if (num6 == 0)
						{
						}
						string text4;
						if (text4 == null || text4 != null)
						{
							if (displayIcons2 == null)
							{
							}
							return;
						}
						goto IL_0BB1;
					}
					return;
				}
				int num7;
				if (num7 == 0)
				{
				}
				int myPlayer9 = Main.myPlayer;
				string text6;
				int num9;
				if (num7 != 0)
				{
					if (num7 == 0)
					{
					}
					int myPlayer10 = Main.myPlayer;
					if (num7 != 0)
					{
						if (num7 == 0)
						{
						}
						bool playerInventory4 = Main.playerInventory;
					}
					int[] displayIcons3 = this.DisplayIcons;
					int num8 = 2;
					string[] iconText3 = this.IconText;
					if (displayIcons3 == null)
					{
					}
					string text5;
					if (text5 == null || text5 != null)
					{
						if (num8 != 0)
						{
							if (num8 == 0)
							{
							}
							int myPlayer11 = Main.myPlayer;
							if (num8 != 0)
							{
								string[] infoText2 = this.InfoText;
								if (num8 == 0)
								{
								}
								int myPlayer12 = Main.myPlayer;
								if (text6 == null || text6 != null)
								{
									GUIAccessoryInfo.StringState[] infoState2 = this.InfoState;
									num9 = this.numInfoAccessories;
									this.numInfoAccessories = num9;
									goto IL_03CB;
								}
								goto IL_0BB1;
							}
						}
						return;
					}
					goto IL_0BB1;
				}
				IL_03CB:
				if (num9 == 0)
				{
				}
				int myPlayer13 = Main.myPlayer;
				if (num9 != 0)
				{
					if (num9 == 0)
					{
					}
					int myPlayer14 = Main.myPlayer;
					if (num9 != 0)
					{
						if (num9 == 0)
						{
						}
						bool playerInventory5 = Main.playerInventory;
					}
					int[] displayIcons4 = this.DisplayIcons;
					int num10 = 10;
					string[] iconText4 = this.IconText;
					if (displayIcons4 == null)
					{
					}
					if (text6 == null || text6 != null)
					{
						if (this.InfoState == null)
						{
						}
						if (Main.SceneMetrics.bestOre == 0)
						{
						}
						int bestOre = Main.SceneMetrics.bestOre;
						if (Main.SceneMetrics.<ClosestOrePosition>k__BackingField == null)
						{
						}
						Point? <ClosestOrePosition>k__BackingField = Main.SceneMetrics.<ClosestOrePosition>k__BackingField;
						Tile tile;
						bool flag = tile.active();
						if (num10 == 0)
						{
						}
						if (num10 != 0 || num10 == 0)
						{
						}
						string[] infoText3 = this.InfoText;
						if (num10 == 0)
						{
						}
						int num11;
						string mapObjectName = Lang.GetMapObjectName(num11);
						string textValue = Language.GetTextValue("GameUI.OreDetected", mapObjectName);
						if (textValue == null || textValue != null)
						{
							return;
						}
					}
				}
				else
				{
					int num12;
					if (num12 == 0)
					{
					}
					int myPlayer15 = Main.myPlayer;
					if (num12 != 0)
					{
						if (num12 == 0)
						{
						}
						int myPlayer16 = Main.myPlayer;
						if (num12 != 0)
						{
							if (num12 == 0)
							{
							}
							bool playerInventory6 = Main.playerInventory;
						}
						int[] displayIcons5 = this.DisplayIcons;
						int num13 = 11;
						string[] iconText5 = this.IconText;
						if (displayIcons5 == null)
						{
						}
						string text7;
						if (text7 == null || text7 != null)
						{
							if (this.InfoState == null)
							{
							}
							int myPlayer17 = Main.myPlayer;
							if (num13 == 0)
							{
							}
							int myPlayer18 = Main.myPlayer;
							if (text7 != null)
							{
								int myPlayer19 = Main.myPlayer;
								return;
							}
							int num14 = 15;
							if (num14 != 0)
							{
								if (num14 == 0)
								{
								}
								int myPlayer20 = Main.myPlayer;
								Vector2 vector;
								float num15 = vector.Length();
							}
							return;
						}
					}
					else
					{
						int num16;
						if (num16 == 0)
						{
						}
						int myPlayer21 = Main.myPlayer;
						if (num16 != 0)
						{
							if (num16 == 0)
							{
							}
							int myPlayer22 = Main.myPlayer;
							if (num16 != 0)
							{
								if (num16 == 0)
								{
								}
								bool playerInventory7 = Main.playerInventory;
							}
							int[] displayIcons6 = this.DisplayIcons;
							int num17 = 5;
							string[] iconText6 = this.IconText;
							if (displayIcons6 == null)
							{
							}
							string text8;
							if (text8 == null || text8 != null)
							{
								if (this.InfoState == null)
								{
								}
								int myPlayer23 = Main.myPlayer;
								if (num17 == 0)
								{
								}
								int myPlayer24 = Main.myPlayer;
								if (text8 != null)
								{
									return;
								}
								int myPlayer25 = Main.myPlayer;
								return;
							}
						}
						else
						{
							int num18;
							if (num18 == 0)
							{
							}
							int myPlayer26 = Main.myPlayer;
							if (num18 != 0)
							{
								if (num18 == 0)
								{
								}
								int myPlayer27 = Main.myPlayer;
								if (num18 != 0)
								{
									if (num18 == 0)
									{
									}
									bool playerInventory8 = Main.playerInventory;
								}
								int[] displayIcons7 = this.DisplayIcons;
								int num19 = 6;
								string[] iconText7 = this.IconText;
								if (displayIcons7 == null)
								{
								}
								string text9;
								if (text9 == null || text9 != null)
								{
									if (this.InfoState == null)
									{
									}
									int myPlayer28 = Main.myPlayer;
									string[] infoText4 = this.InfoText;
									if (num19 == 0)
									{
									}
									int num20;
									string npcnameValue = Lang.GetNPCNameValue(num20);
									if (num19 == 0)
									{
									}
									string text11;
									string text10 = npcnameValue + ": " + text11;
									if (text10 == null || text10 != null)
									{
										return;
									}
								}
							}
							else
							{
								int num21;
								if (num21 == 0)
								{
								}
								int myPlayer29 = Main.myPlayer;
								string textValue2;
								int num23;
								if (num21 != 0)
								{
									if (num21 == 0)
									{
									}
									int myPlayer30 = Main.myPlayer;
									if (num21 != 0)
									{
										if (num21 == 0)
										{
										}
										bool playerInventory9 = Main.playerInventory;
									}
									int[] displayIcons8 = this.DisplayIcons;
									string[] iconText8 = this.IconText;
									if (displayIcons8 == null)
									{
									}
									string text12;
									if (text12 != null && text12 == null)
									{
										goto IL_0BB1;
									}
									if (this.InfoState == null)
									{
									}
									int myPlayer31 = Main.myPlayer;
									int myPlayer32 = Main.myPlayer;
									string[] infoText5 = this.InfoText;
									int num22;
									if (num22 != 0)
									{
										int myPlayer33 = Main.myPlayer;
										string text13;
										if (text13 == null || text13 != null)
										{
											return;
										}
										goto IL_0BB1;
									}
									else
									{
										textValue2 = Language.GetTextValue("GameUI.NoDPS");
										if (textValue2 != null && textValue2 == null)
										{
											goto IL_0BB1;
										}
										GUIAccessoryInfo.StringState[] infoState3 = this.InfoState;
										num23 = this.numInfoAccessories;
									}
								}
								if (num23 == 0)
								{
								}
								int myPlayer34 = Main.myPlayer;
								if (num23 != 0)
								{
									if (num23 == 0)
									{
									}
									int myPlayer35 = Main.myPlayer;
									if (num23 != 0)
									{
										if (num23 == 0)
										{
										}
										bool playerInventory10 = Main.playerInventory;
									}
									int[] displayIcons9 = this.DisplayIcons;
									string[] iconText9 = this.IconText;
									if (displayIcons9 == null)
									{
									}
									if (textValue2 == null || textValue2 != null)
									{
										if (this.InfoState == null)
										{
										}
										int myPlayer36 = Main.myPlayer;
										int num24 = 32768;
										int myPlayer37 = Main.myPlayer;
										if (num24 == 0)
										{
										}
										int myPlayer38 = Main.myPlayer;
										if (num24 == 0)
										{
										}
										int myPlayer39 = Main.myPlayer;
										int myPlayer40 = Main.myPlayer;
										return;
									}
								}
								else
								{
									int num25;
									if (num25 == 0)
									{
									}
									int myPlayer41 = Main.myPlayer;
									if (num25 == 0)
									{
									}
									int myPlayer42 = Main.myPlayer;
									if (num25 != 0)
									{
										if (num25 == 0)
										{
										}
										bool playerInventory11 = Main.playerInventory;
									}
									int[] displayIcons10 = this.DisplayIcons;
									string[] iconText10 = this.IconText;
									if (displayIcons10 == null)
									{
									}
									string text14;
									if (text14 == null || text14 != null)
									{
										if (this.InfoState == null)
										{
										}
										int myPlayer43 = Main.myPlayer;
										int myPlayer44 = Main.myPlayer;
										string[] infoText6 = this.InfoText;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		IL_0BB1:
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x0400059A RID: 1434
	public int numInfoAccessories;

	// Token: 0x0400059B RID: 1435
	public int[] DisplayIcons;

	// Token: 0x0400059C RID: 1436
	public string[] IconText;

	// Token: 0x0400059D RID: 1437
	public string[] InfoText;

	// Token: 0x0400059E RID: 1438
	private GUIAccessoryInfo.StringState[] InfoState;

	// Token: 0x0400059F RID: 1439
	private Rectangle lastDrawRegion;

	// Token: 0x040005A0 RID: 1440
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x040005A1 RID: 1441
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x040005A2 RID: 1442
	private GUIItemGrid.DrawItemHandler itemDraw;

	// Token: 0x040005A3 RID: 1443
	private int itemOffset;

	// Token: 0x02000120 RID: 288
	private enum StringState
	{
		// Token: 0x040005A5 RID: 1445
		Normal,
		// Token: 0x040005A6 RID: 1446
		Disabled,
		// Token: 0x040005A7 RID: 1447
		Critter
	}
}
