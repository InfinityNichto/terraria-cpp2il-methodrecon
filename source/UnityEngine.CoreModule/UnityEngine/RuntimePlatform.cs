using System;

namespace UnityEngine
{
	// Token: 0x0200002F RID: 47
	public enum RuntimePlatform
	{
		// Token: 0x04000051 RID: 81
		OSXEditor,
		// Token: 0x04000052 RID: 82
		OSXPlayer,
		// Token: 0x04000053 RID: 83
		WindowsPlayer,
		// Token: 0x04000054 RID: 84
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", true)]
		OSXWebPlayer,
		// Token: 0x04000055 RID: 85
		[Obsolete("Dashboard widget on Mac OS X export is no longer supported in Unity 5.4+.", true)]
		OSXDashboardPlayer,
		// Token: 0x04000056 RID: 86
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", true)]
		WindowsWebPlayer,
		// Token: 0x04000057 RID: 87
		WindowsEditor = 7,
		// Token: 0x04000058 RID: 88
		IPhonePlayer,
		// Token: 0x04000059 RID: 89
		[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
		XBOX360 = 10,
		// Token: 0x0400005A RID: 90
		[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
		PS3 = 9,
		// Token: 0x0400005B RID: 91
		Android = 11,
		// Token: 0x0400005C RID: 92
		[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
		NaCl,
		// Token: 0x0400005D RID: 93
		[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
		FlashPlayer = 15,
		// Token: 0x0400005E RID: 94
		LinuxPlayer = 13,
		// Token: 0x0400005F RID: 95
		LinuxEditor = 16,
		// Token: 0x04000060 RID: 96
		WebGLPlayer,
		// Token: 0x04000061 RID: 97
		[Obsolete("Use WSAPlayerX86 instead")]
		MetroPlayerX86,
		// Token: 0x04000062 RID: 98
		WSAPlayerX86 = 18,
		// Token: 0x04000063 RID: 99
		[Obsolete("Use WSAPlayerX64 instead")]
		MetroPlayerX64,
		// Token: 0x04000064 RID: 100
		WSAPlayerX64 = 19,
		// Token: 0x04000065 RID: 101
		[Obsolete("Use WSAPlayerARM instead")]
		MetroPlayerARM,
		// Token: 0x04000066 RID: 102
		WSAPlayerARM = 20,
		// Token: 0x04000067 RID: 103
		[Obsolete("Windows Phone 8 was removed in 5.3")]
		WP8Player,
		// Token: 0x04000068 RID: 104
		[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
		BlackBerryPlayer,
		// Token: 0x04000069 RID: 105
		[Obsolete("TizenPlayer export is no longer supported in Unity 2017.3+.")]
		TizenPlayer,
		// Token: 0x0400006A RID: 106
		[Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
		PSP2,
		// Token: 0x0400006B RID: 107
		PS4,
		// Token: 0x0400006C RID: 108
		[Obsolete("PSM export is no longer supported in Unity >= 5.3")]
		PSM,
		// Token: 0x0400006D RID: 109
		XboxOne,
		// Token: 0x0400006E RID: 110
		[Obsolete("SamsungTVPlayer export is no longer supported in Unity 2017.3+.")]
		SamsungTVPlayer,
		// Token: 0x0400006F RID: 111
		[Obsolete("Wii U is no longer supported in Unity 2018.1+.")]
		WiiU = 30,
		// Token: 0x04000070 RID: 112
		tvOS,
		// Token: 0x04000071 RID: 113
		Switch,
		// Token: 0x04000072 RID: 114
		Lumin,
		// Token: 0x04000073 RID: 115
		Stadia,
		// Token: 0x04000074 RID: 116
		CloudRendering,
		// Token: 0x04000075 RID: 117
		[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", false)]
		GameCoreScarlett = -1,
		// Token: 0x04000076 RID: 118
		GameCoreXboxSeries = 36,
		// Token: 0x04000077 RID: 119
		GameCoreXboxOne,
		// Token: 0x04000078 RID: 120
		PS5,
		// Token: 0x04000079 RID: 121
		EmbeddedLinuxArm64,
		// Token: 0x0400007A RID: 122
		EmbeddedLinuxArm32,
		// Token: 0x0400007B RID: 123
		EmbeddedLinuxX64,
		// Token: 0x0400007C RID: 124
		EmbeddedLinuxX86,
		// Token: 0x0400007D RID: 125
		LinuxServer,
		// Token: 0x0400007E RID: 126
		WindowsServer,
		// Token: 0x0400007F RID: 127
		OSXServer
	}
}
