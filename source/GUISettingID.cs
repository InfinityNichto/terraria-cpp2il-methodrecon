using System;

// Token: 0x02000294 RID: 660
public enum GUISettingID
{
	// Token: 0x04001B80 RID: 7040
	Sound = 1,
	// Token: 0x04001B81 RID: 7041
	Ambient,
	// Token: 0x04001B82 RID: 7042
	Music,
	// Token: 0x04001B83 RID: 7043
	AutoSave,
	// Token: 0x04001B84 RID: 7044
	HighlightNewItems,
	// Token: 0x04001B85 RID: 7045
	PickupText,
	// Token: 0x04001B86 RID: 7046
	PlacementPreview,
	// Token: 0x04001B87 RID: 7047
	GoreVisuals,
	// Token: 0x04001B88 RID: 7048
	MapEnabled,
	// Token: 0x04001B89 RID: 7049
	EventProgressBar,
	// Token: 0x04001B8A RID: 7050
	LockOn,
	// Token: 0x04001B8B RID: 7051
	Magnify,
	// Token: 0x04001B8C RID: 7052
	TooltipTime,
	// Token: 0x04001B8D RID: 7053
	TooltipFadeTime,
	// Token: 0x04001B8E RID: 7054
	TooltipBackings,
	// Token: 0x04001B8F RID: 7055
	FrameSkip,
	// Token: 0x04001B90 RID: 7056
	BatterySavingMode,
	// Token: 0x04001B91 RID: 7057
	ScreenEffects,
	// Token: 0x04001B92 RID: 7058
	ShowFPS,
	// Token: 0x04001B93 RID: 7059
	Language,
	// Token: 0x04001B94 RID: 7060
	WikiButton,
	// Token: 0x04001B95 RID: 7061
	ForumButton,
	// Token: 0x04001B96 RID: 7062
	DiscordButton,
	// Token: 0x04001B97 RID: 7063
	SupportButton,
	// Token: 0x04001B98 RID: 7064
	YoutubeButton,
	// Token: 0x04001B99 RID: 7065
	TwitterButton,
	// Token: 0x04001B9A RID: 7066
	PrivacyButton,
	// Token: 0x04001B9B RID: 7067
	FacebookButton,
	// Token: 0x04001B9C RID: 7068
	EditInterface,
	// Token: 0x04001B9D RID: 7069
	BackgroundEnabled,
	// Token: 0x04001B9E RID: 7070
	AutoPause,
	// Token: 0x04001B9F RID: 7071
	Parallex,
	// Token: 0x04001BA0 RID: 7072
	LeftStickAiming,
	// Token: 0x04001BA1 RID: 7073
	ResetCursorModes,
	// Token: 0x04001BA2 RID: 7074
	BugReportButton,
	// Token: 0x04001BA3 RID: 7075
	Credits,
	// Token: 0x04001BA4 RID: 7076
	RedditButton,
	// Token: 0x04001BA5 RID: 7077
	LockTutorials,
	// Token: 0x04001BA6 RID: 7078
	LeftStickJump,
	// Token: 0x04001BA7 RID: 7079
	AutoSwing,
	// Token: 0x04001BA8 RID: 7080
	UITexturesHigh,
	// Token: 0x04001BA9 RID: 7081
	CharacterTexturesHigh,
	// Token: 0x04001BAA RID: 7082
	ProjectileTexturesHigh,
	// Token: 0x04001BAB RID: 7083
	BackgroundTexturesHigh,
	// Token: 0x04001BAC RID: 7084
	GoreTexturesHigh,
	// Token: 0x04001BAD RID: 7085
	GlowTexturesHigh,
	// Token: 0x04001BAE RID: 7086
	EnvironmentTexturesHigh,
	// Token: 0x04001BAF RID: 7087
	Controls,
	// Token: 0x04001BB0 RID: 7088
	EditControllerMappings,
	// Token: 0x04001BB1 RID: 7089
	ChatOrder,
	// Token: 0x04001BB2 RID: 7090
	PasswordVisibility,
	// Token: 0x04001BB3 RID: 7091
	PinchZoom,
	// Token: 0x04001BB4 RID: 7092
	PinchZoomMap,
	// Token: 0x04001BB5 RID: 7093
	TouchAimSensitivity,
	// Token: 0x04001BB6 RID: 7094
	ControllerAimSensitivity,
	// Token: 0x04001BB7 RID: 7095
	TouchSmartCursorMode,
	// Token: 0x04001BB8 RID: 7096
	TouchAimAndUseMode,
	// Token: 0x04001BB9 RID: 7097
	ControllerSmartCursorMode,
	// Token: 0x04001BBA RID: 7098
	ControllerAimAndUseMode,
	// Token: 0x04001BBB RID: 7099
	ControllerSwapShoulderButtons,
	// Token: 0x04001BBC RID: 7100
	ControllerInterfaceMovementDelay,
	// Token: 0x04001BBD RID: 7101
	SmartInteractionRange,
	// Token: 0x04001BBE RID: 7102
	EditVirtualControls,
	// Token: 0x04001BBF RID: 7103
	ActiveVCProfile,
	// Token: 0x04001BC0 RID: 7104
	ControllerShowControlsBanner,
	// Token: 0x04001BC1 RID: 7105
	KeyboardMouse,
	// Token: 0x04001BC2 RID: 7106
	EditKeyboardMappings,
	// Token: 0x04001BC3 RID: 7107
	EditControllerProfile,
	// Token: 0x04001BC4 RID: 7108
	ControllerDevice,
	// Token: 0x04001BC5 RID: 7109
	ControllerDeviceFace,
	// Token: 0x04001BC6 RID: 7110
	TimeFrozen,
	// Token: 0x04001BC7 RID: 7111
	TimeDawn,
	// Token: 0x04001BC8 RID: 7112
	TimeNoon,
	// Token: 0x04001BC9 RID: 7113
	TimeDusk,
	// Token: 0x04001BCA RID: 7114
	TimeMidnight,
	// Token: 0x04001BCB RID: 7115
	TimeSpeed,
	// Token: 0x04001BCC RID: 7116
	WindDirection,
	// Token: 0x04001BCD RID: 7117
	WindChange,
	// Token: 0x04001BCE RID: 7118
	RainIntensity,
	// Token: 0x04001BCF RID: 7119
	RainChange,
	// Token: 0x04001BD0 RID: 7120
	GodMode,
	// Token: 0x04001BD1 RID: 7121
	BuildRange,
	// Token: 0x04001BD2 RID: 7122
	SpawnRate,
	// Token: 0x04001BD3 RID: 7123
	InfectionSpread,
	// Token: 0x04001BD4 RID: 7124
	WorldDifficulty,
	// Token: 0x04001BD5 RID: 7125
	ExperimentalBatching,
	// Token: 0x04001BD6 RID: 7126
	HorizontalInventory,
	// Token: 0x04001BD7 RID: 7127
	LightingMode,
	// Token: 0x04001BD8 RID: 7128
	GraphicsQuality,
	// Token: 0x04001BD9 RID: 7129
	PlayerBarStyle,
	// Token: 0x04001BDA RID: 7130
	MiniMapBorderStyle,
	// Token: 0x04001BDB RID: 7131
	MiniMapSize,
	// Token: 0x04001BDC RID: 7132
	EscapeKeyMode,
	// Token: 0x04001BDD RID: 7133
	EditTextureSettings,
	// Token: 0x04001BDE RID: 7134
	ViewSocial,
	// Token: 0x04001BDF RID: 7135
	ViewMoreInfo,
	// Token: 0x04001BE0 RID: 7136
	SmartCursorMode,
	// Token: 0x04001BE1 RID: 7137
	SmartCursorPriority,
	// Token: 0x04001BE2 RID: 7138
	SmartCursorBlockPlacement,
	// Token: 0x04001BE3 RID: 7139
	PlacementGrid,
	// Token: 0x04001BE4 RID: 7140
	MinersWobble,
	// Token: 0x04001BE5 RID: 7141
	WindyEnvironment,
	// Token: 0x04001BE6 RID: 7142
	KeyboardMouseSmartCursorMode,
	// Token: 0x04001BE7 RID: 7143
	WaterQuality,
	// Token: 0x04001BE8 RID: 7144
	TransferSaves,
	// Token: 0x04001BE9 RID: 7145
	InventoryPageMode,
	// Token: 0x04001BEA RID: 7146
	AutoSaveFrequency,
	// Token: 0x04001BEB RID: 7147
	InterfaceProfile,
	// Token: 0x04001BEC RID: 7148
	ControllerInterfaceMovementRepeatDelay,
	// Token: 0x04001BED RID: 7149
	ControllerCraftToInventory,
	// Token: 0x04001BEE RID: 7150
	SplitscreenPrimarySplit,
	// Token: 0x04001BEF RID: 7151
	EditSafeRegion,
	// Token: 0x04001BF0 RID: 7152
	BuildGridSnap,
	// Token: 0x04001BF1 RID: 7153
	InterfaceAdvanced,
	// Token: 0x04001BF2 RID: 7154
	VideoAdvanced,
	// Token: 0x04001BF3 RID: 7155
	GameplayControlsAdvanced,
	// Token: 0x04001BF4 RID: 7156
	TouchAdvanced,
	// Token: 0x04001BF5 RID: 7157
	ControllerAdvanced,
	// Token: 0x04001BF6 RID: 7158
	KeyboardMouseAdvanced,
	// Token: 0x04001BF7 RID: 7159
	PageOrientation,
	// Token: 0x04001BF8 RID: 7160
	ShiftQuickTrash,
	// Token: 0x04001BF9 RID: 7161
	EnableDoubleClick,
	// Token: 0x04001BFA RID: 7162
	EnableDoubleTap,
	// Token: 0x04001BFB RID: 7163
	TouchPadPinchZoom,
	// Token: 0x04001BFC RID: 7164
	TouchPadPinchZoomMap,
	// Token: 0x04001BFD RID: 7165
	MouseCursor,
	// Token: 0x04001BFE RID: 7166
	MouseCursorH,
	// Token: 0x04001BFF RID: 7167
	MouseCursorS,
	// Token: 0x04001C00 RID: 7168
	MouseCursorL,
	// Token: 0x04001C01 RID: 7169
	MouseCursorBorderH,
	// Token: 0x04001C02 RID: 7170
	MouseCursorBorderS,
	// Token: 0x04001C03 RID: 7171
	MouseCursorBorderL,
	// Token: 0x04001C04 RID: 7172
	MouseCursorBorderO,
	// Token: 0x04001C05 RID: 7173
	ControllerCursor,
	// Token: 0x04001C06 RID: 7174
	ControllerCursorH,
	// Token: 0x04001C07 RID: 7175
	ControllerCursorS,
	// Token: 0x04001C08 RID: 7176
	ControllerCursorL,
	// Token: 0x04001C09 RID: 7177
	ControllerCursorBorderH,
	// Token: 0x04001C0A RID: 7178
	ControllerCursorBorderS,
	// Token: 0x04001C0B RID: 7179
	ControllerCursorBorderL,
	// Token: 0x04001C0C RID: 7180
	ControllerCursorBorderO,
	// Token: 0x04001C0D RID: 7181
	TouchCursor,
	// Token: 0x04001C0E RID: 7182
	TouchCursorH,
	// Token: 0x04001C0F RID: 7183
	TouchCursorS,
	// Token: 0x04001C10 RID: 7184
	TouchCursorL,
	// Token: 0x04001C11 RID: 7185
	TouchCursorBorderH,
	// Token: 0x04001C12 RID: 7186
	TouchCursorBorderS,
	// Token: 0x04001C13 RID: 7187
	TouchCursorBorderL,
	// Token: 0x04001C14 RID: 7188
	TouchCursorBorderO,
	// Token: 0x04001C15 RID: 7189
	PageCollapseMode,
	// Token: 0x04001C16 RID: 7190
	AutoSelectModeTouch,
	// Token: 0x04001C17 RID: 7191
	PrimaryInput,
	// Token: 0x04001C18 RID: 7192
	InventoryCameraMovement,
	// Token: 0x04001C19 RID: 7193
	AutoSelectModeController,
	// Token: 0x04001C1A RID: 7194
	AutoSelectModeKeyboard,
	// Token: 0x04001C1B RID: 7195
	ScrollSensitivity,
	// Token: 0x04001C1C RID: 7196
	ResetAll,
	// Token: 0x04001C1D RID: 7197
	None
}
