using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;

// Token: 0x0200014A RID: 330
public class GUIInstance
{
	// Token: 0x060008FC RID: 2300 RVA: 0x000267C8 File Offset: 0x000249C8
	public void ClosePopups()
	{
		GUIInventorySplitStack guiinventorySplitStack = this.GUIInventorySplitStack;
		this.GUIChestSplitStack.Close();
		this.GUIBuilderAccToggles.Close();
		GUIPVPIcons guipvpicons = this.GUIPVPIcons;
		this.GUIAccessoryInfoToggles.CloseExpandedFilter();
		this.GUIEquipmentLoadout.CloseExpandedFilter();
		this.GUICrafting.Filter.CloseExpandedFilter();
		this.GUIItemDuplication.Filter.CloseExpandedFilter();
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00026830 File Offset: 0x00024A30
	public void CloseDialoguesAndPopups()
	{
		this.ClosePopups();
		this.GUIWiresUI.Close();
		this.GUIRubbleMaker.Close();
		this.GUIResearch.Close();
		this.GUIReforgePopup.ClosePopup();
		this.GUICraftGuidePopup.ClosePopup();
		GUIEmotesWindow guiemotesWindow = this.GUIEmotesWindow;
		long num = 0L;
		guiemotesWindow.SetDisplayingEmotes(num != 0L);
		if (this.GUIPVPIcons == null)
		{
		}
		Main.CancelClothesWindow(false);
		Main.CancelHairWindow();
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x000268A0 File Offset: 0x00024AA0
	public void CloseNonPageDialogues()
	{
		if (!true)
		{
		}
		Main.CancelClothesWindow(false);
		Main.CancelHairWindow();
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x000268C0 File Offset: 0x00024AC0
	public GUIInstance()
	{
		int num = 1;
		this.UseLargeMinimap = num != 0;
		if (true)
		{
			return;
		}
		if (!true)
		{
		}
		int num2 = 1;
		this.AllowSecondRow = num2 != 0;
		this.AllowDraw = num2 != 0;
		this.ToolMode = (WiresUI.Settings.MultiToolMode)num2;
		this.mouseHSL = num2;
		this.controllerHSL = num2;
		base..ctor();
	}

	// Token: 0x040007D5 RID: 2005
	public static GUIInstance Active;

	// Token: 0x040007D6 RID: 2006
	public XNAUnityRunner.ForcedInputMode LastPrimaryInputMode;

	// Token: 0x040007D7 RID: 2007
	public InterfaceProfile_Layout _active;

	// Token: 0x040007D8 RID: 2008
	public bool UseLargeMinimap;

	// Token: 0x040007D9 RID: 2009
	public GUIControllerNavigationController GUIControllerNavigationController;

	// Token: 0x040007DA RID: 2010
	public GUIControllerPageRedirect GUIControllerPageRedirect;

	// Token: 0x040007DB RID: 2011
	public GUIVirtualInputController GUIVirtualInputController;

	// Token: 0x040007DC RID: 2012
	public GUIAccessoryInfo GUIAccessoryInfo;

	// Token: 0x040007DD RID: 2013
	public GUIMenuNameEdit GUIMenuNameEdit;

	// Token: 0x040007DE RID: 2014
	public GUIReforgePopup GUIReforgePopup;

	// Token: 0x040007DF RID: 2015
	public GUIAmmo GUIAmmo;

	// Token: 0x040007E0 RID: 2016
	public GUIBossBar GUIBossBar;

	// Token: 0x040007E1 RID: 2017
	public GUIBuffs GUIBuffs;

	// Token: 0x040007E2 RID: 2018
	public GUIButtonBar GUIButtonBar;

	// Token: 0x040007E3 RID: 2019
	public GUIChest GUIChest;

	// Token: 0x040007E4 RID: 2020
	public GUIChestQuickStack GUIChestQuickStack;

	// Token: 0x040007E5 RID: 2021
	public GUIChestSplitStack GUIChestSplitStack;

	// Token: 0x040007E6 RID: 2022
	public GUIClothesWindow GUIClothesWindow;

	// Token: 0x040007E7 RID: 2023
	public GUICoins GUICoins;

	// Token: 0x040007E8 RID: 2024
	public GUIControlsBanner GUIControlsBanner;

	// Token: 0x040007E9 RID: 2025
	public GUIControlsStatusIndicators GUIControlsStatusIndicators;

	// Token: 0x040007EA RID: 2026
	public GUICraftGuide GUICraftGuide;

	// Token: 0x040007EB RID: 2027
	public GUICraftGuidePopup GUICraftGuidePopup;

	// Token: 0x040007EC RID: 2028
	public GUICrafting GUICrafting;

	// Token: 0x040007ED RID: 2029
	public GUIDisplayDoll GUIDisplayDoll;

	// Token: 0x040007EE RID: 2030
	public GUIEmotesWindow GUIEmotesWindow;

	// Token: 0x040007EF RID: 2031
	public GUIEquipment GUIEquipment;

	// Token: 0x040007F0 RID: 2032
	public GUIEquipmentUtility GUIEquipmentUtility;

	// Token: 0x040007F1 RID: 2033
	public GUIEvents GUIEvents;

	// Token: 0x040007F2 RID: 2034
	public GUIHairWindow GUIHairWindow;

	// Token: 0x040007F3 RID: 2035
	public GUIHatRack GUIHatRack;

	// Token: 0x040007F4 RID: 2036
	public GUIResearchPage GUIResearchPage;

	// Token: 0x040007F5 RID: 2037
	public GUIHearts GUIHearts;

	// Token: 0x040007F6 RID: 2038
	public GUIHotbar GUIHotbar;

	// Token: 0x040007F7 RID: 2039
	public GUIHousingMenu GUIHousingMenu;

	// Token: 0x040007F8 RID: 2040
	public GUIInventory GUIInventory;

	// Token: 0x040007F9 RID: 2041
	public GUIWiresUI GUIWiresUI;

	// Token: 0x040007FA RID: 2042
	public GUIRubbleMaker GUIRubbleMaker;

	// Token: 0x040007FB RID: 2043
	public GUIInventorySplitStack GUIInventorySplitStack;

	// Token: 0x040007FC RID: 2044
	public GUIInventoryTransactions GUIInventoryTransactions;

	// Token: 0x040007FD RID: 2045
	public GUIItemDuplication GUIItemDuplication;

	// Token: 0x040007FE RID: 2046
	public GUIMagnify GUIMagnify;

	// Token: 0x040007FF RID: 2047
	public GUIMana GUIMana;

	// Token: 0x04000800 RID: 2048
	public GUIMap GUIMap;

	// Token: 0x04000801 RID: 2049
	public GUIMouseItem GUIMouseItem;

	// Token: 0x04000802 RID: 2050
	public GUIMultiplayerChat GUIMultiplayerChat;

	// Token: 0x04000803 RID: 2051
	public GUIMultiplayerChat GUIMultiplayerChatPage;

	// Token: 0x04000804 RID: 2052
	public GUINetplayStatusText GUINetplayStatusText;

	// Token: 0x04000805 RID: 2053
	public GUINPCDialogue GUINPCDialogue;

	// Token: 0x04000806 RID: 2054
	public GUIPageIcons GUIPageIcons;

	// Token: 0x04000807 RID: 2055
	public GUIProfileSwitch GUIProfileSwitch;

	// Token: 0x04000808 RID: 2056
	public GUIPVPIcons GUIPVPIcons;

	// Token: 0x04000809 RID: 2057
	public GUIReforge GUIReforge;

	// Token: 0x0400080A RID: 2058
	public GUIScrollControl GUIScrollControl;

	// Token: 0x0400080B RID: 2059
	public GUIJourneyModeSettings GUIJourneyModeSettings;

	// Token: 0x0400080C RID: 2060
	public GUISettings GUISettings;

	// Token: 0x0400080D RID: 2061
	public GUISettingsPauseMenu GUISettingsPauseMenu;

	// Token: 0x0400080E RID: 2062
	public GUIShop GUIShop;

	// Token: 0x0400080F RID: 2063
	public GUITrashCan GUITrashCan;

	// Token: 0x04000810 RID: 2064
	public GUIWorldOperationProgress GUIWorldOperationProgress;

	// Token: 0x04000811 RID: 2065
	public GUIZoom GUIZoom;

	// Token: 0x04000812 RID: 2066
	public GUIAchievementsMenu GUIAchievementsMenu;

	// Token: 0x04000813 RID: 2067
	public GUICredits GUICredits;

	// Token: 0x04000814 RID: 2068
	public GUIDeleteDedicatedServer GUIDeleteDedicatedServer;

	// Token: 0x04000815 RID: 2069
	public GUIDeletePlayer GUIDeletePlayer;

	// Token: 0x04000816 RID: 2070
	public GUIDeleteWorld GUIDeleteWorld;

	// Token: 0x04000817 RID: 2071
	public GUIErrorScreen GUIErrorScreen;

	// Token: 0x04000818 RID: 2072
	public GUIFileSyncInProgress GUIFileSyncInProgress;

	// Token: 0x04000819 RID: 2073
	public GUIInterfaceEdit GUIInterfaceEdit;

	// Token: 0x0400081A RID: 2074
	public GUILogo GUILogo;

	// Token: 0x0400081B RID: 2075
	public GUILowDiskSpacePopup GUILowDiskSpacePopup;

	// Token: 0x0400081C RID: 2076
	public GUILowMemoryPopup GUILowMemoryPopup;

	// Token: 0x0400081D RID: 2077
	public GUILowMemorySetttings GUILowMemorySetttings;

	// Token: 0x0400081E RID: 2078
	public GUIMainMenu GUIMainMenu;

	// Token: 0x0400081F RID: 2079
	public GUIMultiplayerHost GUIMultiplayerHost;

	// Token: 0x04000820 RID: 2080
	public GUIMultiplayerJoin GUIMultiplayerJoin;

	// Token: 0x04000821 RID: 2081
	public GUIMultiplayerLobby GUIMultiplayerLobby;

	// Token: 0x04000822 RID: 2082
	public GUIMultiplayerMenu GUIMultiplayerMenu;

	// Token: 0x04000823 RID: 2083
	public GUIMultiplayerServerIP GUIMultiplayerServerIP;

	// Token: 0x04000824 RID: 2084
	public GUIMultiplayerServerPassword GUIMultiplayerServerPassword;

	// Token: 0x04000825 RID: 2085
	public GUIMultiplayerServerPort GUIMultiplayerServerPort;

	// Token: 0x04000826 RID: 2086
	public GUIMultiplayerServerRequestedPassword GUIMultiplayerServerRequestedPassword;

	// Token: 0x04000827 RID: 2087
	public GUIMultiplayerWaitingHost GUIMultiplayerWaitingHost;

	// Token: 0x04000828 RID: 2088
	public GUINetPlayStatusMenu GUINetPlayStatusMenu;

	// Token: 0x04000829 RID: 2089
	public GUIPlayerAndGameModeMismatch GUIPlayerAndGameModeMismatch;

	// Token: 0x0400082A RID: 2090
	public GUIPlayerCreateMenu GUIPlayerCreateMenu;

	// Token: 0x0400082B RID: 2091
	public GUIPlayerNameMenu GUIPlayerNameMenu;

	// Token: 0x0400082C RID: 2092
	public GUIPlayerSelectMenu GUIPlayerSelectMenu;

	// Token: 0x0400082D RID: 2093
	public GUIQuitConfirm GUIQuitConfirm;

	// Token: 0x0400082E RID: 2094
	public GUIResetSettings GUIResetSettings;

	// Token: 0x0400082F RID: 2095
	public GUISafeRegionEdit GUISafeRegionEdit;

	// Token: 0x04000830 RID: 2096
	public GUISettingsOverlay GUISettingsOverlay;

	// Token: 0x04000831 RID: 2097
	public GUIStatusMenu GUIStatusMenu;

	// Token: 0x04000832 RID: 2098
	public GUIVirtualInputControllerEdit GUIVirtualInputControllerEdit;

	// Token: 0x04000833 RID: 2099
	public GUIPageGroupEdit GUIPageGroupEdit;

	// Token: 0x04000834 RID: 2100
	public GUIWorldCreateMenu GUIWorldCreateMenu;

	// Token: 0x04000835 RID: 2101
	public GUIWorldGenerateMenu GUIWorldGenerateMenu;

	// Token: 0x04000836 RID: 2102
	public GUIWorldLoadBackup GUIWorldLoadBackup;

	// Token: 0x04000837 RID: 2103
	public GUIWorldNameMenu GUIWorldNameMenu;

	// Token: 0x04000838 RID: 2104
	public GUIWorldNoBackup GUIWorldNoBackup;

	// Token: 0x04000839 RID: 2105
	public GUIWorldSelectMenu GUIWorldSelectMenu;

	// Token: 0x0400083A RID: 2106
	public GUIPageOptions GUIPageOptions;

	// Token: 0x0400083B RID: 2107
	public GUITalkerList GUITalkerList;

	// Token: 0x0400083C RID: 2108
	public GUIControllerDisconnected GUIControllerDisconnected;

	// Token: 0x0400083D RID: 2109
	public GUIAccessoryInfoToggles GUIAccessoryInfoToggles;

	// Token: 0x0400083E RID: 2110
	public GUIEquipmentLoadout GUIEquipmentLoadout;

	// Token: 0x0400083F RID: 2111
	public GUIControllerMappings GUIControllerMappings;

	// Token: 0x04000840 RID: 2112
	public VirtualControllerInputState VirtualControllerInputState;

	// Token: 0x04000841 RID: 2113
	public GUIResearch GUIResearch;

	// Token: 0x04000842 RID: 2114
	public GUIKeyboardMappings GUIKeyboardMappings;

	// Token: 0x04000843 RID: 2115
	public GUIBestiary GUIBestiary;

	// Token: 0x04000844 RID: 2116
	public GUIBuilderAccToggles GUIBuilderAccToggles;

	// Token: 0x04000845 RID: 2117
	public GUIPS4MultiplayerChecks GUIPS4MultiplayerChecks;

	// Token: 0x04000846 RID: 2118
	public GUIReturnToTouch GUIReturnToTouch;

	// Token: 0x04000847 RID: 2119
	public Rectangle BottomCentre_Root;

	// Token: 0x04000848 RID: 2120
	public Rectangle BottomCentre_ChatUI;

	// Token: 0x04000849 RID: 2121
	public Rectangle BottomCentre_BossBar;

	// Token: 0x0400084A RID: 2122
	public Rectangle BottomCentre_EventBar;

	// Token: 0x0400084B RID: 2123
	public Rectangle BottomCentre_ProgressIndicator;

	// Token: 0x0400084C RID: 2124
	public Rectangle BottomCentre_Notification;

	// Token: 0x0400084D RID: 2125
	public Rectangle Right_Root;

	// Token: 0x0400084E RID: 2126
	public Rectangle Right_MainUI;

	// Token: 0x0400084F RID: 2127
	public Rectangle Right_TextNotifications;

	// Token: 0x04000850 RID: 2128
	public Rectangle Right_Event;

	// Token: 0x04000851 RID: 2129
	public Rectangle Right_BossBar;

	// Token: 0x04000852 RID: 2130
	public Rectangle Right_StatusIndicator;

	// Token: 0x04000853 RID: 2131
	public Rectangle Right_InfoAccessories;

	// Token: 0x04000854 RID: 2132
	public Rectangle Right_InfoAccessories2;

	// Token: 0x04000855 RID: 2133
	public Rectangle Right_AchievementNotifiations;

	// Token: 0x04000856 RID: 2134
	public Rectangle _gridItemRegion;

	// Token: 0x04000857 RID: 2135
	public Rectangle PageGroupRegion;

	// Token: 0x04000858 RID: 2136
	public Rectangle PageContentRegion;

	// Token: 0x04000859 RID: 2137
	public Rectangle _leftPageRegion;

	// Token: 0x0400085A RID: 2138
	public Rectangle _rightPageRegion;

	// Token: 0x0400085B RID: 2139
	public Rectangle _selectedItemRegion;

	// Token: 0x0400085C RID: 2140
	public Rectangle _buttonRegion;

	// Token: 0x0400085D RID: 2141
	public Rectangle _mainMenuPageRegion;

	// Token: 0x0400085E RID: 2142
	public Vector2 LeftInterface;

	// Token: 0x0400085F RID: 2143
	public Vector2 RightInterface;

	// Token: 0x04000860 RID: 2144
	public bool AllowSecondRow;

	// Token: 0x04000861 RID: 2145
	public bool UseCollpasedCoinsAmmo;

	// Token: 0x04000862 RID: 2146
	public int AllowRowHeight;

	// Token: 0x04000863 RID: 2147
	public bool AllowDraw;

	// Token: 0x04000864 RID: 2148
	public int currentFrame;

	// Token: 0x04000865 RID: 2149
	public int BottomCentreHUDUpdateFrame;

	// Token: 0x04000866 RID: 2150
	public WiresUI.Settings.MultiToolMode ToolMode;

	// Token: 0x04000867 RID: 2151
	public int _lastActuatorEnabled;

	// Token: 0x04000868 RID: 2152
	public List<int> optionRedirection;

	// Token: 0x04000869 RID: 2153
	public Vector3 mouseHSL;

	// Token: 0x0400086A RID: 2154
	public Vector3 mouseBorderHSL;

	// Token: 0x0400086B RID: 2155
	public Vector3 controllerHSL;

	// Token: 0x0400086C RID: 2156
	public Vector3 controllerBorderHSL;
}
