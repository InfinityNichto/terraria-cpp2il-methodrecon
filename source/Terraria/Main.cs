using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using ReLogic.Graphics;
using ReLogic.Utilities;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.GameContent.Golf;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Liquid;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.CameraModifiers;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Net;
using Terraria.ObjectData;
using Terraria.Social;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.WorldBuilding;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.Profiling;

namespace Terraria
{
	// Token: 0x020003F2 RID: 1010
	public class Main : Game
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x000A9B94 File Offset: 0x000A7D94
		public static bool flushLighting
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x000A9BA4 File Offset: 0x000A7DA4
		public static MinimapFrame ActiveMinimapFrame
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x000A9BB4 File Offset: 0x000A7DB4
		public static IPlayerResourcesDisplaySet ActivePlayerResourcesSet
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x000A9BC4 File Offset: 0x000A7DC4
		public static int mapDelay
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x000A9BD4 File Offset: 0x000A7DD4
		public static bool SettingsUnlock_WorldEvil
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x000A9BE4 File Offset: 0x000A7DE4
		public static bool SettingsEnabled_MinersWobble
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x000A9BF4 File Offset: 0x000A7DF4
		public static bool SettingBlockGamepadsEntirely
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x000A9C04 File Offset: 0x000A7E04
		public static bool SettingDontScaleMainMenuUp
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x000A9C14 File Offset: 0x000A7E14
		public static bool SettingsEnabled_OpaqueBoxBehindTooltips
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x000A9C24 File Offset: 0x000A7E24
		public static int tooltipTime
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x000A9C34 File Offset: 0x000A7E34
		public static int inventoryTooltipTime
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x000A9C44 File Offset: 0x000A7E44
		public static bool SettingMusicReplayDelayEnabled
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x000A9C54 File Offset: 0x000A7E54
		public static bool HidePassword
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x000A9C64 File Offset: 0x000A7E64
		public static bool ReversedUpDownArmorSetBonuses
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x000A9C74 File Offset: 0x000A7E74
		public static bool MouseShowBuildingGrid
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x000A9C84 File Offset: 0x000A7E84
		public static float MouseBuildingGridAlpha
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x000A9C94 File Offset: 0x000A7E94
		public static Terraria.Graphics.Camera Camera
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x000A9CA4 File Offset: 0x000A7EA4
		public static string _savePath
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x000A9CB4 File Offset: 0x000A7EB4
		public static string _oldSavePath
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x000A9CC4 File Offset: 0x000A7EC4
		public static FavoritesFile LocalFavoriteData
		{
			get
			{
				FavoritesFile favoritesFile;
				return favoritesFile;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x000A9CD4 File Offset: 0x000A7ED4
		public static FileMetadata MapFileMetadata
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x000A9CE4 File Offset: 0x000A7EE4
		public static BigProgressBarSystem BigBossProgressBar
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x000A9CF4 File Offset: 0x000A7EF4
		private float hellBlackBoxBottom
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x000A9D04 File Offset: 0x000A7F04
		private int[] backTexture
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x000A9D14 File Offset: 0x000A7F14
		private int[] oldBackTexture
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x000A9D24 File Offset: 0x000A7F24
		private Microsoft.Xna.Framework.Graphics.Texture2D[] backTextureValues
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x000A9D34 File Offset: 0x000A7F34
		private Microsoft.Xna.Framework.Graphics.Texture2D[] oldBackTextureValues
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x000A9D44 File Offset: 0x000A7F44
		public static WorldSections sectionManager
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x000A9D54 File Offset: 0x000A7F54
		public static int WaveQuality
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x000A9D64 File Offset: 0x000A7F64
		public static bool UseStormEffects
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x000A9D74 File Offset: 0x000A7F74
		public static bool UseHeatDistortion
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x000A9D84 File Offset: 0x000A7F84
		public static Microsoft.Xna.Framework.Vector2 CurrentPan
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x000A9D94 File Offset: 0x000A7F94
		public static float sunCircle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x000A9DA4 File Offset: 0x000A7FA4
		public static int BlackFadeIn
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x000A9DB4 File Offset: 0x000A7FB4
		public static int undergroundBackground
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x000A9DC4 File Offset: 0x000A7FC4
		public static int oldUndergroundBackground
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x000A9DD4 File Offset: 0x000A7FD4
		public static bool renderNow
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x000A9DE4 File Offset: 0x000A7FE4
		public static int mouseX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x000A9DF4 File Offset: 0x000A7FF4
		public static int mouseY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x000A9E04 File Offset: 0x000A8004
		public static int worldMouseX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x000A9E14 File Offset: 0x000A8014
		public static int worldMouseY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x000A9E24 File Offset: 0x000A8024
		public static int lastMouseX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x000A9E34 File Offset: 0x000A8034
		public static int lastMouseY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x000A9E44 File Offset: 0x000A8044
		public static bool mouseLeft
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x000A9E54 File Offset: 0x000A8054
		public static bool mouseRight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x000A9E64 File Offset: 0x000A8064
		public static bool worldMouseLeft
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x000A9E74 File Offset: 0x000A8074
		public static bool worldMouseLeftRelease
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x000A9E84 File Offset: 0x000A8084
		public static bool worldMouseRight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x000A9E94 File Offset: 0x000A8094
		public static bool worldMouseRightRelease
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x000A9EA4 File Offset: 0x000A80A4
		public static bool isMouseLeftConsumedByUI
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x000A9EB4 File Offset: 0x000A80B4
		public static bool DisableIntenseVisualEffects
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x000A9EC4 File Offset: 0x000A80C4
		public static bool hairWindow
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x000A9ED4 File Offset: 0x000A80D4
		public static bool clothesWindow
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x000A9EE4 File Offset: 0x000A80E4
		public static bool ingameOptionsWindow
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x000A9EF4 File Offset: 0x000A80F4
		public static bool inFancyUI
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x000A9F04 File Offset: 0x000A8104
		public static byte gFade
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x000A9F14 File Offset: 0x000A8114
		public static float gFader
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x000A9F24 File Offset: 0x000A8124
		public static byte gFadeDir
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x000A9F34 File Offset: 0x000A8134
		public static bool render
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x000A9F44 File Offset: 0x000A8144
		public static int qaStyle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x000A9F54 File Offset: 0x000A8154
		public static bool BackgroundEnabled
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x000A9F64 File Offset: 0x000A8164
		public static int instantBGTransitionCounter
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x000A9F74 File Offset: 0x000A8174
		public static int bgDelay
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x000A9F84 File Offset: 0x000A8184
		public static int bgStyle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x000A9F94 File Offset: 0x000A8194
		public static float[] bgAlphaFrontLayer
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x000A9FA4 File Offset: 0x000A81A4
		public static float[] bgAlphaFarBackLayer
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x000A9FB4 File Offset: 0x000A81B4
		public static int[] bgFrame
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x000A9FC4 File Offset: 0x000A81C4
		public static int[] bgFrameCounter
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x000A9FD4 File Offset: 0x000A81D4
		public static bool refreshMap
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x000A9FE4 File Offset: 0x000A81E4
		public static int loadMapLastX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x000A9FF4 File Offset: 0x000A81F4
		public static bool loadMapLock
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x000AA004 File Offset: 0x000A8204
		public static bool loadMap
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x000AA014 File Offset: 0x000A8214
		public static bool loadMapSections
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x000AA024 File Offset: 0x000A8224
		public static bool mapReady
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x000AA034 File Offset: 0x000A8234
		public static bool updateMap
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x000AA044 File Offset: 0x000A8244
		public static int mapMinX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x000AA054 File Offset: 0x000A8254
		public static int mapMaxX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x000AA064 File Offset: 0x000A8264
		public static int mapMinY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x000AA074 File Offset: 0x000A8274
		public static int mapMaxY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x000AA084 File Offset: 0x000A8284
		public static int mapTimeMax
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x000AA094 File Offset: 0x000A8294
		public static int mapTime
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x000AA0A4 File Offset: 0x000A82A4
		public static bool clearMap
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x000AA0B4 File Offset: 0x000A82B4
		public static bool mapInit
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x000AA0C4 File Offset: 0x000A82C4
		public static bool mapEnabled
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x000AA0D4 File Offset: 0x000A82D4
		public static int mapStyle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x000AA0E4 File Offset: 0x000A82E4
		public static float grabMapX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x000AA0F4 File Offset: 0x000A82F4
		public static float grabMapY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x000AA104 File Offset: 0x000A8304
		public static float grabMapInitialX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x000AA114 File Offset: 0x000A8314
		public static float grabMapInitialY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x000AA124 File Offset: 0x000A8324
		public static bool grabMapInProgress
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x000AA134 File Offset: 0x000A8334
		public static int miniMapX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x000AA144 File Offset: 0x000A8344
		public static int miniMapY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x000AA154 File Offset: 0x000A8354
		public static int miniMapWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x000AA164 File Offset: 0x000A8364
		public static int miniMapHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x000AA174 File Offset: 0x000A8374
		public static float mapMinimapScale
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x000AA184 File Offset: 0x000A8384
		public static float mapMinimapAlpha
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x000AA194 File Offset: 0x000A8394
		public static float mapOverlayScale
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x000AA1A4 File Offset: 0x000A83A4
		public static float mapOverlayAlpha
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C7F RID: 7295 RVA: 0x000AA1B4 File Offset: 0x000A83B4
		public static bool mapFullscreen
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x000AA1C4 File Offset: 0x000A83C4
		public static bool resetMapFull
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x000AA1D4 File Offset: 0x000A83D4
		public static int resetMapFullCharacter
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x000AA1E4 File Offset: 0x000A83E4
		public static float mapFullscreenScale
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x000AA1F4 File Offset: 0x000A83F4
		public static Microsoft.Xna.Framework.Vector2 mapFullscreenPos
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x000AA204 File Offset: 0x000A8404
		public static int renderCount
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x000AA214 File Offset: 0x000A8414
		public static Stopwatch saveTime
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x000AA224 File Offset: 0x000A8424
		public static float gfxQuality
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C8F RID: 7311 RVA: 0x000AA234 File Offset: 0x000A8434
		public static float gfxRate
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x000AA244 File Offset: 0x000A8444
		public static int teamCooldown
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x000AA254 File Offset: 0x000A8454
		public static bool showFrameRate
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x000AA264 File Offset: 0x000A8464
		public static bool drewLava
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x000AA274 File Offset: 0x000A8474
		public static int numActiveLiquidAlpha
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x000AA284 File Offset: 0x000A8484
		public static int[] activeLiquidAlpha
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x000AA294 File Offset: 0x000A8494
		public static float[] liquidAlpha
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x000AA2A4 File Offset: 0x000A84A4
		public static int waterStyle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x000AA2B4 File Offset: 0x000A84B4
		public static bool TOWMusicUnlocked
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x000AA2C4 File Offset: 0x000A84C4
		public static float caveParallax
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x000AA2D4 File Offset: 0x000A84D4
		public static bool showItemText
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x000AA2E4 File Offset: 0x000A84E4
		public static bool autoSave
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x000AA2F4 File Offset: 0x000A84F4
		public static int background
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x000AA304 File Offset: 0x000A8504
		public static int caveBackground
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x000AA314 File Offset: 0x000A8514
		public static float ugBackTransition
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x000AA324 File Offset: 0x000A8524
		public static Main.AutoPauseMode autoPause
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x000AA334 File Offset: 0x000A8534
		public static bool placementPreview
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x000AA344 File Offset: 0x000A8544
		public static SceneMetrics SceneMetrics
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x000AA354 File Offset: 0x000A8554
		public static bool SettingsEnabled_TilesSwayInWind
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x000AA364 File Offset: 0x000A8564
		public static float GraveyardVisualIntensity
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x000AA374 File Offset: 0x000A8574
		public static float musicVolume
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x000AA384 File Offset: 0x000A8584
		public static float ambientVolume
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x000AA394 File Offset: 0x000A8594
		public static float soundVolume
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x000AA3A4 File Offset: 0x000A85A4
		public static WorldMap Map
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x000AA3B4 File Offset: 0x000A85B4
		public static Rain[] rain
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x000AA3C4 File Offset: 0x000A85C4
		public static PopupText[] popupText
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x000AA3D4 File Offset: 0x000A85D4
		public static float startScreenYOffset
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x000AA3E4 File Offset: 0x000A85E4
		public static float targetScreenYOffset
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x000AA3F4 File Offset: 0x000A85F4
		public static float screenYOffset
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x000AA404 File Offset: 0x000A8604
		public static float cameraOffset
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x000AA414 File Offset: 0x000A8614
		public static Microsoft.Xna.Framework.Vector2 screenPosition
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x000AA424 File Offset: 0x000A8624
		public static Microsoft.Xna.Framework.Vector2 screenLastPosition
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x000AA434 File Offset: 0x000A8634
		public static int screenWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x000AA444 File Offset: 0x000A8644
		public static int screenHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x000AA454 File Offset: 0x000A8654
		public static bool mouseLeftRelease
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x000AA464 File Offset: 0x000A8664
		public static bool mouseRightRelease
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x000AA474 File Offset: 0x000A8674
		public static bool playerInventory
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x000AA484 File Offset: 0x000A8684
		public static int stackSplit
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x000AA494 File Offset: 0x000A8694
		public static bool preventStackSplitReset
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x000AA4A4 File Offset: 0x000A86A4
		public static int stackCounter
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x000AA4B4 File Offset: 0x000A86B4
		public static int stackDelay
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x000AA4C4 File Offset: 0x000A86C4
		public static int superFastStack
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x000AA4D4 File Offset: 0x000A86D4
		public static int timesTriedToFastStack
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x000AA4E4 File Offset: 0x000A86E4
		public static Item mouseItem
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x000AA4F4 File Offset: 0x000A86F4
		public static float mouseItemTime
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x000AA504 File Offset: 0x000A8704
		public static Item[] mouseItemSource
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x000AA514 File Offset: 0x000A8714
		public static int mouseItemSourceIndex
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x000AA524 File Offset: 0x000A8724
		public static int mouseItemSourceContext
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x000AA534 File Offset: 0x000A8734
		public static Item guideItem
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x000AA544 File Offset: 0x000A8744
		public static Item reforgeItem
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x000AA554 File Offset: 0x000A8754
		public static float inventoryScale
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x000AA564 File Offset: 0x000A8764
		public static Point rulerLineDisplayValues
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x000AA574 File Offset: 0x000A8774
		public static int[] availableRecipe
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x000AA584 File Offset: 0x000A8784
		public static int lastRecipeUpdateId
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x000AA594 File Offset: 0x000A8794
		public static int numAvailableRecipes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x000AA5A4 File Offset: 0x000A87A4
		public static int focusRecipe
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x000AA5B4 File Offset: 0x000A87B4
		public static int myPlayer
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x000AA5C4 File Offset: 0x000A87C4
		public static int spawnTileX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x000AA5D4 File Offset: 0x000A87D4
		public static int spawnTileY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x000AA5E4 File Offset: 0x000A87E4
		public static bool npcChatRelease
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x000AA5F4 File Offset: 0x000A87F4
		public static bool editSign
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x000AA604 File Offset: 0x000A8804
		public static bool editChest
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x000AA614 File Offset: 0x000A8814
		public static bool blockInput
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x000AA624 File Offset: 0x000A8824
		public static string blockKey
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x000AA634 File Offset: 0x000A8834
		public static string defaultChestName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x000AA644 File Offset: 0x000A8844
		public static string npcChatText
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x000AA654 File Offset: 0x000A8854
		public static bool npcChatFocus1
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x000AA664 File Offset: 0x000A8864
		public static bool npcChatFocus2
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x000AA674 File Offset: 0x000A8874
		public static bool npcChatFocus3
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x000AA684 File Offset: 0x000A8884
		public static bool npcChatFocus4
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x000AA694 File Offset: 0x000A8894
		public static int oldNPCShop
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x000AA6A4 File Offset: 0x000A88A4
		public static int npcShop
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x000AA6B4 File Offset: 0x000A88B4
		public static int npcChatCornerItem
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x000AA6C4 File Offset: 0x000A88C4
		public Chest[] shop
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x000AA6D4 File Offset: 0x000A88D4
		public static ItemShopSellbackHelper shopSellbackHelper
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x000AA6E4 File Offset: 0x000A88E4
		public static bool anglerQuestFinished
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x000AA6F4 File Offset: 0x000A88F4
		public static GolfState LocalGolfState
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x000AA704 File Offset: 0x000A8904
		public static DroneCameraTracker DroneCameraTracker
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x000AA714 File Offset: 0x000A8914
		public static bool InGuideCraftMenu
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x000AA724 File Offset: 0x000A8924
		public static bool InReforgeMenu
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x000AA734 File Offset: 0x000A8934
		public static bool gameMenu
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x000AA744 File Offset: 0x000A8944
		public static List<PlayerFileData> PlayerList
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x000AA754 File Offset: 0x000A8954
		public static PlayerFileData ActivePlayerFileData
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x000AA764 File Offset: 0x000A8964
		public static Player PendingPlayer
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x000AA774 File Offset: 0x000A8974
		public static string WorldPath
		{
			get
			{
				if (!true)
				{
				}
				return Path.Combine(Main.SavePath, "Worlds");
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x000AA794 File Offset: 0x000A8994
		public static string PlayerPath
		{
			get
			{
				if (!true)
				{
				}
				return Path.Combine(Main.SavePath, "Players");
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x000AA7B4 File Offset: 0x000A89B4
		public static string OldPlayerPath
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001D38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Main::get_OldPlayerPath()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0F, call:string(string::Concat, callgetter:string(Main::get_OldSavePath), ldstr:string("/Players")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x000AA7D0 File Offset: 0x000A89D0
		public static string OldWorldPath
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001D39)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Main::get_OldWorldPath()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0F, call:string(string::Concat, callgetter:string(Main::get_OldSavePath), ldstr:string("/Worlds")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x000AA7EC File Offset: 0x000A89EC
		private static Preferences _configuration
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x000AA7FC File Offset: 0x000A89FC
		public static Preferences Configuration
		{
			get
			{
				if (!true)
				{
				}
				if (Main._configuration == null)
				{
					if (!true)
					{
					}
					string text2;
					string text = Main.SavePath + text2 + "config.json";
				}
				return Main._configuration;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x000AA830 File Offset: 0x000A8A30
		private static Preferences _inputProfiles
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x000AA840 File Offset: 0x000A8A40
		public static Preferences InputProfiles
		{
			get
			{
				if (!true)
				{
				}
				if (Main._inputProfiles == null)
				{
					if (!true)
					{
					}
					string text2;
					string text = Main.SavePath + text2 + "input profiles.json";
				}
				return Main._inputProfiles;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x000AA874 File Offset: 0x000A8A74
		public static bool invasionProgressNearInvasion
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x000AA884 File Offset: 0x000A8A84
		public static int invasionProgressMode
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x000AA894 File Offset: 0x000A8A94
		public static bool cSmartCursorModeIsToggleAndNotHold
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x000AA8A4 File Offset: 0x000A8AA4
		public static bool SmartCursorShowing
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x000AA8B4 File Offset: 0x000A8AB4
		public static int SmartCursorX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x000AA8C4 File Offset: 0x000A8AC4
		public static int SmartCursorY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x000AA8D4 File Offset: 0x000A8AD4
		public static bool SmartInteractShowingGenuine
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x000AA8E4 File Offset: 0x000A8AE4
		public static bool SmartInteractShowingFake
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x000AA8F4 File Offset: 0x000A8AF4
		public static int SmartInteractX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x000AA904 File Offset: 0x000A8B04
		public static int SmartInteractY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x000AA914 File Offset: 0x000A8B14
		public static int SmartInteractNPC
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x000AA924 File Offset: 0x000A8B24
		public static int SmartInteractProj
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x000AA934 File Offset: 0x000A8B34
		public static bool SmartInteractPotionOfReturn
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x000AA944 File Offset: 0x000A8B44
		public static Dictionary<int, bool> SmartInteractTileCoords
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x000AA954 File Offset: 0x000A8B54
		public static Dictionary<int, bool> SmartInteractTileCoordsSelected
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x000AA964 File Offset: 0x000A8B64
		public static int TileInteractionLX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x000AA974 File Offset: 0x000A8B74
		public static int TileInteractionLY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x000AA984 File Offset: 0x000A8B84
		public static int TileInteractionHX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x000AA994 File Offset: 0x000A8B94
		public static int TileInteractionHY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x000AA9A4 File Offset: 0x000A8BA4
		public static int cursorOverride
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
		public static int signHover
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x000AA9C4 File Offset: 0x000A8BC4
		public static int lastSignHover
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x000AA9D4 File Offset: 0x000A8BD4
		public static Microsoft.Xna.Framework.Graphics.Color mouseColor
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x000AA9E4 File Offset: 0x000A8BE4
		public static Microsoft.Xna.Framework.Graphics.Color ControllerColor
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x000AA9F4 File Offset: 0x000A8BF4
		public static Microsoft.Xna.Framework.Graphics.Color ControllerBorderColor
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x000AAA04 File Offset: 0x000A8C04
		public static Microsoft.Xna.Framework.Graphics.Color MouseBorderColor
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x000AAA14 File Offset: 0x000A8C14
		public static Microsoft.Xna.Framework.Graphics.Color cursorColor
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x000AAA24 File Offset: 0x000A8C24
		public static int cursorColorDirection
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x000AAA34 File Offset: 0x000A8C34
		public static float cursorAlpha
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x000AAA44 File Offset: 0x000A8C44
		public static float cursorScale
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x000AAA54 File Offset: 0x000A8C54
		public static bool signBubble
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x000AAA64 File Offset: 0x000A8C64
		public static int signX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x000AAA74 File Offset: 0x000A8C74
		public static int signY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x000AAA84 File Offset: 0x000A8C84
		public static bool SettingsSavePending
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x000AAA94 File Offset: 0x000A8C94
		public static int menuMode
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x000AAAA4 File Offset: 0x000A8CA4
		public static bool Quitting
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x000AAAB4 File Offset: 0x000A8CB4
		public static int overloadedMousePositionX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x000AAAC4 File Offset: 0x000A8CC4
		public static int overloadedMousePositionY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x000AAAD4 File Offset: 0x000A8CD4
		public static bool HoveringOverAnNPC
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x000AAAE4 File Offset: 0x000A8CE4
		private static int rare
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x000AAAF4 File Offset: 0x000A8CF4
		public static int hairStart
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x000AAB04 File Offset: 0x000A8D04
		public static int oldHairStyle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x000AAB14 File Offset: 0x000A8D14
		public static Microsoft.Xna.Framework.Graphics.Color oldHairColor
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x000AAB24 File Offset: 0x000A8D24
		public static int selClothes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x000AAB34 File Offset: 0x000A8D34
		public static Microsoft.Xna.Framework.Graphics.Color[] oldClothesColor
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x000AAB44 File Offset: 0x000A8D44
		public static int oldClothesStyle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x000AAB54 File Offset: 0x000A8D54
		public static int interactedDresserTopLeftX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x000AAB64 File Offset: 0x000A8D64
		public static int interactedDresserTopLeftY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x000AAB74 File Offset: 0x000A8D74
		public static Player dresserInterfaceDummy
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x000AAB84 File Offset: 0x000A8D84
		private static bool _MouseOversCanClear
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x000AAB94 File Offset: 0x000A8D94
		private static Microsoft.Xna.Framework.Vector2 _itemIconCacheScreenPosition
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x000AABA4 File Offset: 0x000A8DA4
		private static int _itemIconCacheSelectedItemID
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x000AABB4 File Offset: 0x000A8DB4
		private static int _itemIconCacheTime
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x000AABC4 File Offset: 0x000A8DC4
		public static Microsoft.Xna.Framework.Graphics.Color selColor
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x000AABD4 File Offset: 0x000A8DD4
		public static int bgScroll
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x000AABE4 File Offset: 0x000A8DE4
		public static float hBar
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x000AABF4 File Offset: 0x000A8DF4
		public static float sBar
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x000AAC04 File Offset: 0x000A8E04
		public static float lBar
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x000AAC14 File Offset: 0x000A8E14
		public static float aBar
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x000AAC24 File Offset: 0x000A8E24
		public static float GamepadCursorAlpha
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x000AAC34 File Offset: 0x000A8E34
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x000AAC44 File Offset: 0x000A8E44
		public static bool CanUpdateGameplay
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (06001DB8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_CanUpdateGameplay()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			[CompilerGenerated]
			private set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x000AAC54 File Offset: 0x000A8E54
		public static void ToggleGameplayUpdates(bool state)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x000AAC68 File Offset: 0x000A8E68
		public static Microsoft.Xna.Framework.Vector2 ViewPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DBB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::get_ViewPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_0_08, callgetter:Vector2(Main::get_screenPosition))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x000AAC80 File Offset: 0x000A8E80
		public static Microsoft.Xna.Framework.Vector2 ViewSize
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DBC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::get_ViewSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_08, callgetter:int32(Main::get_screenWidth))
	stloc:int32(var_1_0E, callgetter:int32(Main::get_screenHeight))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000AACA0 File Offset: 0x000A8EA0
		public static Matrix CurrentWantedZoomMatrix
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x000AACB4 File Offset: 0x000A8EB4
		public static void SetRecommendedZoomContext(Matrix matrix)
		{
			float m = matrix.M31;
			float m2 = matrix.M32;
			float m3 = matrix.M11;
			float m4 = matrix.M12;
			if (!true)
			{
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x000AACE0 File Offset: 0x000A8EE0
		public static Matrix UIScaleMatrix
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x000AACF4 File Offset: 0x000A8EF4
		public static float UIScaleWanted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DC0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Main::get_UIScaleWanted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x000AAD04 File Offset: 0x000A8F04
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x000AAD14 File Offset: 0x000A8F14
		public static float UIScale
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DC1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Main::get_UIScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x000AAD2C File Offset: 0x000A8F2C
		public float UIScaleMax
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Main::get_UIScaleMax()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:float32(var_3_14, call:float32(Math::Max, ldloc:float32(var_1), ldloc:float32(var_1)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x000AAD50 File Offset: 0x000A8F50
		public static bool RenderTargetsRequired
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x000AAD64 File Offset: 0x000A8F64
		public static bool IsItRaining
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DC5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_IsItRaining()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x000AAD74 File Offset: 0x000A8F74
		public static bool ThickMouse
		{
			get
			{
				if (!true)
				{
				}
				Microsoft.Xna.Framework.Graphics.Color mouseBorderColor = Main.MouseBorderColor;
				bool flag;
				return flag;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000AAD8C File Offset: 0x000A8F8C
		public static bool GamepadDisableCursorItemIcon
		{
			get
			{
				if (!true)
				{
				}
				bool usingGamepad = PlayerInput.UsingGamepad;
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000AADA8 File Offset: 0x000A8FA8
		public static string SavePath
		{
			get
			{
				if (!true)
				{
				}
				if (Main._savePath == null)
				{
					string savePath = Main._savePath;
					long num = 0L;
					bool flag = savePath.EndsWith("/");
					string savePath2 = Main._savePath;
					int stringLength = Main._savePath._stringLength;
					long num2 = 0L;
					Main._savePath = savePath2.Substring((int)num2, (int)num);
					if (stringLength == 0)
					{
					}
					Main._savePath = FileUtilities.CleanSwitchPath(Main._savePath);
					string savePath3 = Main._savePath;
					int num3 = 92;
					int num4 = 47;
					Main._savePath = savePath3.Replace((char)num3, (char)num4);
					Main._savePath = Main._savePath.Replace("//", "/");
					FileManager.SynchroniseFiles();
				}
				return Main._savePath;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000AAE54 File Offset: 0x000A9054
		public static string OldSavePath
		{
			get
			{
				if (!true)
				{
				}
				if (Main._oldSavePath == null)
				{
					if (!true)
					{
					}
					Main._oldSavePath = Main.SavePath + "/OldSaves";
				}
				if (!true)
				{
				}
				return Main._oldSavePath;
			}
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x000AAE8C File Offset: 0x000A908C
		public static void FindAnnouncementBoxStatus()
		{
			if (!true)
			{
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x000AAE9C File Offset: 0x000A909C
		public static GameModeData GameModeInfo
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DCB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.GameModeData Terraria.Main::get_GameModeInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000AAEAC File Offset: 0x000A90AC
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x000AAEC0 File Offset: 0x000A90C0
		public static int GameMode
		{
			get
			{
				if (!true)
				{
				}
				if (true)
				{
					return;
				}
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000AAED0 File Offset: 0x000A90D0
		public static bool specialSeedWorld
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool masterMode
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool expertMode
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x000AAEE4 File Offset: 0x000A90E4
		public static bool CanPlayCreditsRoll()
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (!true)
			{
			}
			bool hasCreditsSceneMusicBox = Main.LocalPlayer.hasCreditsSceneMusicBox;
			if (!hasCreditsSceneMusicBox)
			{
				if (!hasCreditsSceneMusicBox)
				{
				}
				bool gameMenu2 = Main.gameMenu;
				if (!hasCreditsSceneMusicBox)
				{
				}
				int menuMode = Main.menuMode;
			}
			return true;
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementManager Achievements
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000AAF28 File Offset: 0x000A9128
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x000AAF38 File Offset: 0x000A9138
		public WaterfallManager waterfallManager
		{
			get
			{
				WaterfallManager waterfallManager;
				return waterfallManager;
			}
			set
			{
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x000AAF48 File Offset: 0x000A9148
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x000AAF58 File Offset: 0x000A9158
		public static ulong UnpausedUpdateSeed
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (06001DD5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt64 Terraria.Main::get_UnpausedUpdateSeed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			[CompilerGenerated]
			private set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x000AAF68 File Offset: 0x000A9168
		public static Effect screenShader
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DD7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Effect Terraria.Main::get_screenShader()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x000AAF78 File Offset: 0x000A9178
		public static Effect pixelShader
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DD8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Effect Terraria.Main::get_pixelShader()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x000AAF88 File Offset: 0x000A9188
		public static Effect vertexPixelShader
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DD9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Effect Terraria.Main::get_vertexPixelShader()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x000AAF98 File Offset: 0x000A9198
		public static Effect tileShader
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DDA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Effect Terraria.Main::get_tileShader()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000AAFA8 File Offset: 0x000A91A8
		public static void SetCameraLerp(float lerp, int time)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x000AAFB8 File Offset: 0x000A91B8
		public static void SetCameraGamepadLerp(float lerp)
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x000AAFCC File Offset: 0x000A91CC
		[Obsolete("Transform is deprecated. Please use GameViewMatrix & GUIViewMatrix")]
		public static Matrix Transform
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x000AAFE0 File Offset: 0x000A91E0
		public static Microsoft.Xna.Framework.Vector2 MouseScreen
		{
			get
			{
				if (!true)
				{
				}
				int mouseX = Main.mouseX;
				int mouseY = Main.mouseY;
				return 1;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x000AB000 File Offset: 0x000A9200
		public static Microsoft.Xna.Framework.Vector2 MouseWorld
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DDF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::get_MouseWorld()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:int32(var_5_1B, callgetter:int32(Main::get_myPlayer))
	stloc:Vector2(var_6_22, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_7_29, callgetter:int32(Main::get_screenHeight))
	stloc:int32(var_8_30, callgetter:int32(Main::get_mouseY))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x000AB040 File Offset: 0x000A9240
		public static Microsoft.Xna.Framework.Vector2 MouseWorld2
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DE0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::get_MouseWorld2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int32(var_1_0D, callgetter:int32(Main::get_worldMouseX))
	stloc:int32(var_2_13, callgetter:int32(Main::get_worldMouseY))
	stloc:int32(var_5_1B, callgetter:int32(Main::get_myPlayer))
	stloc:Vector2(var_6_22, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_7_29, callgetter:int32(Main::get_screenHeight))
	stloc:int32(var_8_30, callgetter:int32(Main::get_mouseY))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000AB080 File Offset: 0x000A9280
		public static Microsoft.Xna.Framework.Vector2 ReverseGravitySupport(Microsoft.Xna.Framework.Vector2 pos, float height = 0f)
		{
			/*
An exception occurred when decompiling this method (06001DE1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::ReverseGravitySupport(Microsoft.Xna.Framework.Vector2,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:int32(var_2_13, callgetter:int32(Main::get_screenHeight))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000AB0A0 File Offset: 0x000A92A0
		public static Point ReverseGravitySupport(Point pos, int height = 0)
		{
			/*
An exception occurred when decompiling this method (06001DE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.Main::ReverseGravitySupport(Microsoft.Xna.Framework.Point,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:int32(var_2_13, callgetter:int32(Main::get_screenHeight))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000AB0C0 File Offset: 0x000A92C0
		public static Rectangle ReverseGravitySupport(Rectangle box)
		{
			/*
An exception occurred when decompiling this method (06001DE3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Main::ReverseGravitySupport(Microsoft.Xna.Framework.Rectangle)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:int32(var_2_13, callgetter:int32(Main::get_screenHeight))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000AB0E0 File Offset: 0x000A92E0
		public static INetDiagnosticsUI ActiveNetDiagnosticsUI
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DE4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.INetDiagnosticsUI Terraria.Main::get_ActiveNetDiagnosticsUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x000AB0F0 File Offset: 0x000A92F0
		public int mouseNPCIndex
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x000AB100 File Offset: 0x000A9300
		public int mouseNPCType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000AB110 File Offset: 0x000A9310
		public void SetMouseNPC(int index, int type)
		{
			this.mouseNPCIndex = index;
			this.mouseNPCType = type;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000AB12C File Offset: 0x000A932C
		public void SetMouseNPC_ToHousingQuery()
		{
			long num = 0L;
			this.mouseNPCType = (int)num;
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06001DEB RID: 7659 RVA: 0x000AB144 File Offset: 0x000A9344
		// (remove) Token: 0x06001DEC RID: 7660 RVA: 0x000AB160 File Offset: 0x000A9360
		public static event Action OnEnginePreload
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06001DED RID: 7661 RVA: 0x000AB17C File Offset: 0x000A937C
		// (remove) Token: 0x06001DEE RID: 7662 RVA: 0x000AB1A0 File Offset: 0x000A93A0
		public static event Action<Microsoft.Xna.Framework.Vector2> OnResolutionChanged
		{
			[CompilerGenerated]
			add
			{
				int num = 1;
				if (num == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 1;
				if (num == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06001DEF RID: 7663 RVA: 0x000AB1C4 File Offset: 0x000A93C4
		// (remove) Token: 0x06001DF0 RID: 7664 RVA: 0x000AB1E0 File Offset: 0x000A93E0
		public static event Action OnEngineLoad
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x000AB1FC File Offset: 0x000A93FC
		public static uint GameUpdateCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DF1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Terraria.Main::get_GameUpdateCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06001DF2 RID: 7666 RVA: 0x000AB20C File Offset: 0x000A940C
		// (remove) Token: 0x06001DF3 RID: 7667 RVA: 0x000AB228 File Offset: 0x000A9428
		public static event Action OnTickForThirdPartySoftwareOnly
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06001DF4 RID: 7668 RVA: 0x000AB244 File Offset: 0x000A9444
		// (remove) Token: 0x06001DF5 RID: 7669 RVA: 0x000AB260 File Offset: 0x000A9460
		public static event Action OnTickForInternalCodeOnly
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06001DF6 RID: 7670 RVA: 0x000AB27C File Offset: 0x000A947C
		// (remove) Token: 0x06001DF7 RID: 7671 RVA: 0x000AB2A0 File Offset: 0x000A94A0
		public static event Action<GameTime> OnPreDraw
		{
			[CompilerGenerated]
			add
			{
				int num = 1;
				if (num == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 1;
				if (num == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06001DF8 RID: 7672 RVA: 0x000AB2C4 File Offset: 0x000A94C4
		// (remove) Token: 0x06001DF9 RID: 7673 RVA: 0x000AB2E8 File Offset: 0x000A94E8
		public static event Action<GameTime> OnPostDraw
		{
			[CompilerGenerated]
			add
			{
				int num = 1;
				if (num == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 1;
				if (num == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06001DFA RID: 7674 RVA: 0x000AB30C File Offset: 0x000A950C
		// (remove) Token: 0x06001DFB RID: 7675 RVA: 0x000AB330 File Offset: 0x000A9530
		public static event Action<Microsoft.Xna.Framework.Vector2, float> OnPostFullscreenMapDraw
		{
			[CompilerGenerated]
			add
			{
				int num = 1;
				if (num == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 1;
				if (num == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06001DFC RID: 7676 RVA: 0x000AB354 File Offset: 0x000A9554
		// (remove) Token: 0x06001DFD RID: 7677 RVA: 0x000AB370 File Offset: 0x000A9570
		public static event Action OnRenderTargetsReleased
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06001DFE RID: 7678 RVA: 0x000AB38C File Offset: 0x000A958C
		// (remove) Token: 0x06001DFF RID: 7679 RVA: 0x000AB3A8 File Offset: 0x000A95A8
		public static event ResolutionChangeEvent OnRenderTargetsInitialized
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x000AB3C4 File Offset: 0x000A95C4
		private int firstTileX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x000AB3D4 File Offset: 0x000A95D4
		private int lastTileX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x000AB3E4 File Offset: 0x000A95E4
		private int firstTileY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x000AB3F4 File Offset: 0x000A95F4
		private int lastTileY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06001E08 RID: 7688
		private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

		// Token: 0x06001E09 RID: 7689
		private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

		// Token: 0x06001E0A RID: 7690
		private static extern int GetMenuItemCount(IntPtr hWnd);

		// Token: 0x06001E0B RID: 7691
		public static extern IntPtr LoadLibrary(string dllToLoad);

		// Token: 0x06001E0C RID: 7692 RVA: 0x000AB404 File Offset: 0x000A9604
		public static void FlushBatches()
		{
			if (!true)
			{
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x000AB414 File Offset: 0x000A9614
		public static SamplerState DefaultSamplerState
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E0D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.SamplerState Terraria.Main::get_DefaultSamplerState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x000AB424 File Offset: 0x000A9624
		public static int UnderworldLayer
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E0E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Main::get_UnderworldLayer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x000AB434 File Offset: 0x000A9634
		public static MoonPhase GetMoonPhase()
		{
			/*
An exception occurred when decompiling this method (06001E0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Enums.MoonPhase Terraria.Main::GetMoonPhase()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x000AB444 File Offset: 0x000A9644
		public static float WindForVisuals
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E10)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Main::get_WindForVisuals()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x000AB454 File Offset: 0x000A9654
		public static Microsoft.Xna.Framework.Vector2 DrawPlayerItemPos(float gravdir, int itemtype)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x000AB498 File Offset: 0x000A9698
		public static void SetupTileMerge()
		{
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x000AB4C8 File Offset: 0x000A96C8
		public static void RegisterItemAnimation(int index, DrawAnimation animation)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x000AB4F0 File Offset: 0x000A96F0
		public static void InitializeItemAnimations()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x000AB600 File Offset: 0x000A9800
		public static Player LocalPlayer
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E15)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Player Terraria.Main::get_LocalPlayer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_08, callgetter:int32(Main::get_myPlayer))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x000AB618 File Offset: 0x000A9818
		public static CreativeUnlocksTracker LocalPlayerCreativeTracker
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E16)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Creative.CreativeUnlocksTracker Terraria.Main::get_LocalPlayerCreativeTracker()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_08, callgetter:int32(Main::get_myPlayer))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x000AB630 File Offset: 0x000A9830
		public static void SetGraphicsProfile(GraphicsProfile profile, bool forceSet)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000AB640 File Offset: 0x000A9840
		private static void SetGraphicsProfileInternal()
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000AB650 File Offset: 0x000A9850
		private static void TrySupporting8K()
		{
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000AB660 File Offset: 0x000A9860
		public static void AnglerQuestSwap()
		{
			if (!true)
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000AB6A0 File Offset: 0x000A98A0
		public static string playerPathName
		{
			get
			{
				if (!true)
				{
				}
				return Main.ActivePlayerFileData._path;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x000AB6BC File Offset: 0x000A98BC
		public static string worldPathName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Main::get_worldPathName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x000AB6CC File Offset: 0x000A98CC
		public int currentNPCShowingChatBubble
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000AB6DC File Offset: 0x000A98DC
		public static bool NetClientOnly
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E1F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_NetClientOnly()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000AB6EC File Offset: 0x000A98EC
		public static bool NetClient
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E20)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_NetClient()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000AB6FC File Offset: 0x000A98FC
		public static bool LogicHost
		{
			get
			{
				if (!true)
				{
				}
				return Main.NetClientOnly;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x000AB714 File Offset: 0x000A9914
		public static bool NetHostOnly
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E22)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_NetHostOnly()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x000AB724 File Offset: 0x000A9924
		public static bool LogicClient
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E23)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_LogicClient()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x000AB734 File Offset: 0x000A9934
		public static bool NetHost
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E24)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_NetHost()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x000AB744 File Offset: 0x000A9944
		public static bool NetClientHost
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_NetClientHost()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x000AB754 File Offset: 0x000A9954
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x000AB764 File Offset: 0x000A9964
		public static bool SmartCursorIsUsed
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000AB774 File Offset: 0x000A9974
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x000AB784 File Offset: 0x000A9984
		public static bool SmartCursorWanted
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000AB794 File Offset: 0x000A9994
		public static bool HasSmartInteractTarget
		{
			get
			{
				if (!true)
				{
				}
				int smartInteractNPC = Main.SmartInteractNPC;
				return true;
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x000AB7C8 File Offset: 0x000A99C8
		public void UpdateParticleSystems()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x000AB7D8 File Offset: 0x000A99D8
		public static void TrySetPreparationState(Main.WorldPreparationState state)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x000AB7E8 File Offset: 0x000A99E8
		public static void UpdateWorldPreparationState()
		{
			if (!true)
			{
			}
			bool logicHost = Main.LogicHost;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000AB834 File Offset: 0x000A9A34
		public static bool InSmartCursorHighlightArea(int x, int y, [Out] bool actuallySelected)
		{
			if (!true)
			{
			}
			Dictionary<int, bool> smartInteractTileCoordsSelected = Main.SmartInteractTileCoordsSelected;
			y.m_value = 1;
			if (true)
			{
			}
			if (!true)
			{
			}
			int tileInteractionLX = Main.TileInteractionLX;
			int tileInteractionLY = Main.TileInteractionLY;
			int tileInteractionHX = Main.TileInteractionHX;
			int tileInteractionHY = Main.TileInteractionHY;
			return Collision.InTileBounds(42168472, x, tileInteractionLX, tileInteractionLY, tileInteractionHX, tileInteractionHY);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000021DB File Offset: 0x000003DB
		public static byte[] Decompress(byte[] inputData, int outputSize)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000AB884 File Offset: 0x000A9A84
		public static void LoadWorlds()
		{
			int num = 1;
			OldSaveSynchronise.CopyOldSaves();
			if (num == 0)
			{
			}
			FileUtilities.CreateDirectory(Main.WorldPath);
			FileUtilities.CreateDirectory(Main.OldWorldPath);
			string[] files = FileUtilities.GetFiles(Main.WorldPath, "*.wld");
			long num2 = 0L;
			if (WorldFile.GetAllMetadata(files, num2 != 0L) != null)
			{
				int stringLength = files._stringLength;
				return;
			}
			int stringLength2 = files._stringLength;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000ABA70 File Offset: 0x000A9C70
		private static int WorldListSortMethod(WorldFileData data1, WorldFileData data2)
		{
			int num;
			if (data1 != null && data1.Name != null)
			{
				return num;
			}
			return num;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000021DB File Offset: 0x000003DB
		public static void LoadPlayers()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x000ABA8C File Offset: 0x000A9C8C
		private static int PlayerListSortMethod(PlayerFileData data1, PlayerFileData data2)
		{
			string name = data1.Name;
			int num;
			return num;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x000ABAA4 File Offset: 0x000A9CA4
		public void OpenRecent()
		{
			int num = 1;
			if (num == 0)
			{
			}
			string savePath = Main.SavePath;
			if (num == 0)
			{
			}
			string text2;
			string text = savePath + text2 + "dedServers.dat";
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = FileUtilities.Exists(text, num2 != 0L);
			if (num == 0)
			{
			}
			string savePath2 = Main.SavePath;
			if (num == 0)
			{
			}
			string text4;
			string text3 = savePath2 + text4 + "dedServers.dat";
			if (num == 0)
			{
			}
			long num3 = 0L;
			byte[] array = FileUtilities.ReadAllBytes(text3, num3 != 0L);
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000ABBC4 File Offset: 0x000A9DC4
		public static void SaveRecent()
		{
			if (!true)
			{
			}
			FileUtilities.CreateDirectory(Main.SavePath);
			string text2;
			string text = Main.SavePath + text2 + "dedServers.dat";
			string text4;
			string text3 = Main.SavePath + text4 + "dedServers.dat";
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x000ABC8C File Offset: 0x000A9E8C
		public static bool SaveSettings()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Main.SettingsSavePending = false;
			if (num == 0)
			{
			}
			DateTime now = DateTime.Now;
			Preferences configuration = Main.Configuration;
			bool mapEnabled = Main.mapEnabled;
			Preferences configuration2 = Main.Configuration;
			Preferences configuration3 = Main.Configuration;
			int invasionProgressMode = Main.invasionProgressMode;
			Preferences configuration4 = Main.Configuration;
			bool autoSave = Main.autoSave;
			Preferences configuration5 = Main.Configuration;
			Preferences configuration6 = Main.Configuration;
			Main.AutoPauseMode autoPause = Main.autoPause;
			Preferences configuration7 = Main.Configuration;
			Preferences configuration8 = Main.Configuration;
			Preferences configuration9 = Main.Configuration;
			Preferences configuration10 = Main.Configuration;
			Preferences configuration11 = Main.Configuration;
			Preferences configuration12 = Main.Configuration;
			Preferences configuration13 = Main.Configuration;
			Preferences configuration14 = Main.Configuration;
			Preferences configuration15 = Main.Configuration;
			Preferences configuration16 = Main.Configuration;
			if (!true)
			{
			}
			Preferences configuration17 = Main.Configuration;
			Preferences configuration18 = Main.Configuration;
			if ("CameraMovementMode" != null)
			{
			}
			Preferences configuration19 = Main.Configuration;
			bool placementPreview = Main.placementPreview;
			Preferences configuration20 = Main.Configuration;
			bool disabled = ChildSafety.Disabled;
			Preferences configuration21 = Main.Configuration;
			Preferences configuration22 = Main.Configuration;
			Preferences configuration23 = Main.Configuration;
			Preferences configuration24 = Main.Configuration;
			bool disableIntenseVisualEffects = Main.DisableIntenseVisualEffects;
			string text;
			Main.Configuration.Put("PlayerResourcesSet", text);
			string text2;
			Main.Configuration.Put("MinimapFrame", text2);
			Preferences configuration25 = Main.Configuration;
			bool useLargeMinimap = Map_Layout.UseLargeMinimap;
			Preferences configuration26 = Main.Configuration;
			int tooltipTime = Main.tooltipTime;
			Preferences configuration27 = Main.Configuration;
			int inventoryTooltipTime = Main.inventoryTooltipTime;
			Preferences configuration28 = Main.Configuration;
			bool settingsEnabled_OpaqueBoxBehindTooltips = Main.SettingsEnabled_OpaqueBoxBehindTooltips;
			Preferences configuration29 = Main.Configuration;
			VirtualControlsProfile_Layout virtualControlsProfile_Layout;
			string id = virtualControlsProfile_Layout.Id;
			configuration29.Put("TouchControlsProfile", id);
			Preferences configuration30 = Main.Configuration;
			float soundVolume = Main.soundVolume;
			Preferences configuration31 = Main.Configuration;
			float ambientVolume = Main.ambientVolume;
			Preferences configuration32 = Main.Configuration;
			float musicVolume = Main.musicVolume;
			Preferences configuration33 = Main.Configuration;
			bool towmusicUnlocked = Main.TOWMusicUnlocked;
			Preferences configuration34 = Main.Configuration;
			Preferences configuration35 = Main.Configuration;
			Preferences configuration36 = Main.Configuration;
			Preferences configuration37 = Main.Configuration;
			Preferences configuration38 = Main.Configuration;
			int qaStyle = Main.qaStyle;
			Preferences configuration39 = Main.Configuration;
			bool backgroundEnabled = Main.BackgroundEnabled;
			Preferences configuration40 = Main.Configuration;
			Preferences configuration41 = Main.Configuration;
			LightMode mode = Lighting.Mode;
			Preferences configuration42 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color mouseColor = Main.mouseColor;
			Preferences configuration43 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color mouseColor2 = Main.mouseColor;
			Preferences configuration44 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color mouseColor3 = Main.mouseColor;
			Preferences configuration45 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color mouseBorderColor = Main.MouseBorderColor;
			Preferences configuration46 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color mouseBorderColor2 = Main.MouseBorderColor;
			Preferences configuration47 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color mouseBorderColor3 = Main.MouseBorderColor;
			Preferences configuration48 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color mouseBorderColor4 = Main.MouseBorderColor;
			Preferences configuration49 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color controllerColor = Main.ControllerColor;
			Preferences configuration50 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color controllerColor2 = Main.ControllerColor;
			Preferences configuration51 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color controllerColor3 = Main.ControllerColor;
			Preferences configuration52 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color controllerBorderColor = Main.ControllerBorderColor;
			Preferences configuration53 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color controllerBorderColor2 = Main.ControllerBorderColor;
			Preferences configuration54 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color controllerBorderColor3 = Main.ControllerBorderColor;
			Preferences configuration55 = Main.Configuration;
			Microsoft.Xna.Framework.Graphics.Color controllerBorderColor4 = Main.ControllerBorderColor;
			Preferences configuration56 = Main.Configuration;
			float caveParallax = Main.caveParallax;
			Preferences configuration57 = Main.Configuration;
			bool showItemText = Main.showItemText;
			Preferences configuration58 = Main.Configuration;
			Preferences configuration59 = Main.Configuration;
			Preferences configuration60 = Main.Configuration;
			bool smartBlocksEnabled = Player.SmartCursorSettings.SmartBlocksEnabled;
			Preferences configuration61 = Main.Configuration;
			bool smartAxeAfterPickaxe = Player.SmartCursorSettings.SmartAxeAfterPickaxe;
			Preferences configuration62 = Main.Configuration;
			bool disableLeftShiftTrashCan = ItemSlot.Options.DisableLeftShiftTrashCan;
			Preferences configuration63 = Main.Configuration;
			bool highlightNewItems = ItemSlot.Options.HighlightNewItems;
			Preferences configuration64 = Main.Configuration;
			bool hidePassword = Main.HidePassword;
			Preferences configuration65 = Main.Configuration;
			bool thickMouse = Main.ThickMouse;
			Preferences configuration66 = Main.Configuration;
			bool reversedUpDownArmorSetBonuses = Main.ReversedUpDownArmorSetBonuses;
			Preferences configuration67 = Main.Configuration;
			LockOnHelper.LockOnMode useMode = LockOnHelper.UseMode;
			Preferences configuration68 = Main.Configuration;
			int num2 = 1;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			int width = Screen.width;
			int width2 = Screen.width;
			int height = Screen.height;
			int height2 = Screen.height;
			Preferences configuration69 = Main.Configuration;
			Preferences configuration70 = Main.Configuration;
			Preferences configuration71 = Main.Configuration;
			Preferences configuration72 = Main.Configuration;
			Preferences configuration73 = Main.Configuration;
			Preferences configuration74 = Main.Configuration;
			Preferences configuration75 = Main.Configuration;
			Preferences configuration76 = Main.Configuration;
			int waveQuality = Main.WaveQuality;
			Preferences configuration77 = Main.Configuration;
			if (!true)
			{
			}
			Preferences configuration78 = Main.Configuration;
			if (!true)
			{
			}
			Preferences configuration79 = Main.Configuration;
			if (!true)
			{
			}
			Preferences configuration80 = Main.Configuration;
			if (!true)
			{
			}
			Preferences configuration81 = Main.Configuration;
			if (!true)
			{
			}
			Preferences configuration82 = Main.Configuration;
			if (!true)
			{
			}
			Preferences configuration83 = Main.Configuration;
			if (!true)
			{
			}
			Preferences configuration84 = Main.Configuration;
			bool enabled = ScreenPostProcessor.Enabled;
			Preferences configuration85 = Main.Configuration;
			bool showFrameRate = Main.showFrameRate;
			Preferences configuration86 = Main.Configuration;
			ItemGrid_Layout.ReorderStyle reorder = MultiplayerChat_Layout.Instance.TextGrid.Reorder;
			Preferences configuration87 = Main.Configuration;
			Preferences configuration88 = Main.Configuration;
			Preferences configuration89 = Main.Configuration;
			Preferences configuration90 = Main.Configuration;
			Preferences configuration91 = Main.Configuration;
			Preferences configuration92 = Main.Configuration;
			Preferences configuration93 = Main.Configuration;
			Preferences configuration94 = Main.Configuration;
			bool settingsEnabled_MinersWobble = Main.SettingsEnabled_MinersWobble;
			Preferences configuration95 = Main.Configuration;
			bool mouseShowBuildingGrid = Main.MouseShowBuildingGrid;
			Preferences configuration96 = Main.Configuration;
			bool settingsEnabled_TilesSwayInWind = Main.SettingsEnabled_TilesSwayInWind;
			Preferences configuration97 = Main.Configuration;
			bool cSmartCursorModeIsToggleAndNotHold = Main.cSmartCursorModeIsToggleAndNotHold;
			Preferences configuration98 = Main.Configuration;
			Preferences configuration99 = Main.Configuration;
			int num3 = 45683;
			if ("AutoSaveFrequency" == null)
			{
			}
			InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
			if (num3 == 0)
			{
			}
			Preferences configuration100 = Main.Configuration;
			Preferences configuration101 = Main.Configuration;
			Preferences configuration102 = Main.Configuration;
			Preferences configuration103 = Main.Configuration;
			Preferences configuration104 = Main.Configuration;
			Preferences configuration105 = Main.Configuration;
			int num4 = 1;
			return configuration105.Save(num4 != 0);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x000AC1CC File Offset: 0x000AA3CC
		protected void CheckBunny()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x000AC1DC File Offset: 0x000AA3DC
		public void ResetSettings()
		{
			if (!true)
			{
			}
			string text2;
			string text = Main.SavePath + text2 + "config.json";
			long num = 0L;
			bool flag = FileUtilities.Exists(text, num != 0L);
			string text4;
			string text3 = Main.SavePath + text4 + "config.json";
			long num2 = 0L;
			FileUtilities.Delete(text3, num2 != 0L);
			TextureAtlasDB.UnloadAssets();
			bool flag2 = Main.SaveSettings();
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x000AC238 File Offset: 0x000AA438
		private static void TryPickingDefaultUIScale(float displayHeight)
		{
			if (!true)
			{
			}
			Preferences configuration = Main.Configuration;
			bool flag = Main.Configuration.Save(true);
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x000AC278 File Offset: 0x000AA478
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x000AC25C File Offset: 0x000AA45C
		public static bool Setting_Target60FPS
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E3B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_Setting_Target60FPS()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x000AC288 File Offset: 0x000AA488
		public void LoadSettings(bool allowLoad = true)
		{
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000ACA10 File Offset: 0x000AAC10
		protected void OpenLegacySettings()
		{
			int num = 1;
			if (num == 0)
			{
			}
			string savePath = Main.SavePath;
			if (num == 0)
			{
			}
			string text2;
			string text = savePath + text2 + "config.dat";
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = FileUtilities.Exists(text, num2 != 0L);
			if (num == 0)
			{
			}
			string savePath2 = Main.SavePath;
			if (num == 0)
			{
			}
			string text4;
			string text3 = savePath2 + text4 + "config.dat";
			if (num == 0)
			{
			}
			long num3 = 0L;
			byte[] array = FileUtilities.ReadAllBytes(text3, num3 != 0L);
			long num4 = 0L;
			Main.mouseColor = Main.mouseColor;
			Main.SetDisplayMode(0, 0, num4 != 0L);
			if (!false)
			{
			}
			Main.autoSave = false;
			if (!false)
			{
			}
			Main.autoPause = Main.AutoPauseMode.Disabled;
			if (!false)
			{
			}
			Main.showItemText = false;
			if (!false)
			{
			}
			Main.qaStyle = 1073741824;
			if (1073741824 == 0)
			{
			}
			Main.BackgroundEnabled = false;
			if (!false)
			{
			}
			if (!false)
			{
			}
			if (!false)
			{
			}
			Main.mapEnabled = false;
			if (!false)
			{
			}
			Main.cSmartCursorModeIsToggleAndNotHold = false;
			if (!false)
			{
			}
			Main.invasionProgressMode = 0;
			if (!false)
			{
			}
			Main.placementPreview = false;
			if (!false)
			{
			}
			Main.placementPreview = false;
			if (!false)
			{
			}
			Main.SetFullScreen(false);
			long num5 = 0L;
			if (false)
			{
				return;
			}
			if (num5 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000ACB8C File Offset: 0x000AAD8C
		public static void UpdateTrialMode()
		{
			if (!true)
			{
			}
			if (!true || !true)
			{
			}
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x000ACBA4 File Offset: 0x000AADA4
		public static bool IsTrialMode()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ErasePlayer(int i)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x000ACBB8 File Offset: 0x000AADB8
		public static void EraseWorld(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			long num2 = 0L;
			string text;
			FileUtilities.Delete(text, num2 != 0L);
			if (".bak" == null)
			{
			}
			Main.LoadWorlds();
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x000ACBF0 File Offset: 0x000AADF0
		public static string GetPlayerPathFromName(string playerName, bool cloudSave)
		{
			if (!true)
			{
			}
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			string text2;
			string text = text2.Replace("*", "_").Replace("?", "_").Replace("/", "_")
				.Replace("\\", "_")
				.Replace(">", "_")
				.Replace("<", "_")
				.Replace(":", "_")
				.Replace("|", "_");
			int stringLength = text._stringLength;
			long num = 0L;
			char c = text[(int)num];
			string text4;
			string text3 = "" + text4;
			if (text._stringLength != 0)
			{
			}
			string playerPath = Main.PlayerPath;
			string text6;
			string text5 = playerPath + text6 + text3 + ".plr";
			string text7 = text3 + "_";
			string text9;
			string text8 = playerPath + text9 + text7 + ".plr";
			string text10;
			string text11;
			if ((playerPath == null || playerPath != null) && (text10 == null || text10 != null) && (text7 == null || text7 != null) && (text11 == null || text11 != null) && (".plr" == null || ".plr" != null))
			{
				long num2 = 0L;
				string text12;
				bool flag = FileUtilities.Exists(text12, num2 != 0L);
				string text14;
				string text13 = text7 + text14;
				string text15;
				return playerPath + text15 + text13 + ".plr";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x000ACD48 File Offset: 0x000AAF48
		public static string GetWorldNameFromPath(string filename)
		{
			/*
An exception occurred when decompiling this method (06001E43)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Main::GetWorldNameFromPath(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(1)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x000ACD5C File Offset: 0x000AAF5C
		public static string GetPlayerNameFromPath(string filename)
		{
			do
			{
				if (!true)
				{
				}
			}
			while (Main.ActivePlayerFileData == null);
			if (!true)
			{
			}
			return Main.ActivePlayerFileData.Name;
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x000ACD80 File Offset: 0x000AAF80
		public static string GetWorldPathFromName(string worldName, bool cloudSave)
		{
			if (!true)
			{
			}
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			string text;
			return ("" + text).Replace(".", "_").Replace("*", "_").Replace("?", "_")
				.Replace("/", "_")
				.Replace("\\", "_")
				.Replace(">", "_")
				.Replace("<", "_")
				.Replace(":", "_")
				.Replace("|", "_");
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x000ACECC File Offset: 0x000AB0CC
		public void setServerWorldRollbacks(string rollBacksToKeep)
		{
			if (!true)
			{
			}
			int num = Convert.ToInt32(rollBacksToKeep);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x000ACEE4 File Offset: 0x000AB0E4
		public void autoCreate(string worldSize)
		{
			int num = 1;
			bool flag = worldSize == "0";
			if (num == 0)
			{
			}
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x000ACF40 File Offset: 0x000AB140
		public void NewMOTD(string newMOTD)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000ACF50 File Offset: 0x000AB150
		public static string ConvertToSafeArgument(string arg)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000ACF64 File Offset: 0x000AB164
		public static string ConvertFromSafeArgument(string arg)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000ACF78 File Offset: 0x000AB178
		public void LoadDedConfig(string configPath)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = FileUtilities.Exists(configPath, num != 0L);
			string text;
			bool flag2 = text.ToLower() == "world=";
			string text2;
			bool flag3 = text2.ToLower() == "port=";
			if ("port=" == null)
			{
			}
			string text3;
			int num2 = Convert.ToInt32(text3);
			if ("port=" == null)
			{
			}
			string text4;
			bool flag4 = text4.ToLower() == "worldrollbackstokeep=";
			if ("worldrollbackstokeep=" == null)
			{
			}
			string text5;
			int num3 = Convert.ToInt32(text5);
			if ("worldrollbackstokeep=" == null)
			{
			}
			string text6;
			bool flag5 = text6.ToLower() == "maxplayers=";
			if ("maxplayers=" == null)
			{
			}
			string text7;
			int num4 = Convert.ToInt32(text7);
			string text8;
			bool flag6 = text8.ToLower() == "priority=";
			string text9;
			int num5 = Convert.ToInt32(text9);
			string text10;
			bool flag7 = text10.ToLower() == "password=";
			if ("password=" == null)
			{
			}
			string text12;
			string text11 = Main.ConvertFromSafeArgument(text12);
			if ("password=" == null)
			{
			}
			string text13;
			bool flag8 = text13.ToLower() == "motd=";
			if ("motd=" == null)
			{
			}
			string text14;
			bool flag9 = text14.ToLower() == "lang=";
			string text15;
			int num6 = Convert.ToInt32(text15);
			string text16;
			bool flag10 = text16.ToLower() == "language=";
			string text17;
			bool flag11 = text17.ToLower() == "seed=";
			if ("seed=" == null)
			{
			}
			string text18;
			bool flag12 = text18.ToLower() == "banlist=";
			string text19;
			bool flag13 = text19.ToLower() == "secure=";
			string text20;
			bool flag14 = text20 == "1";
			if ("secure=" == null)
			{
			}
			string text21;
			bool flag15 = text21.ToLower() == "upnp=";
			string text22;
			bool flag16 = text22 != "1";
			if ("upnp=" == null)
			{
			}
			string text23;
			bool flag17 = text23.ToLower() == "slowliquids=";
			string text24;
			bool flag18 = text24 == "1";
			if ("upnp=" == null)
			{
			}
			string text25;
			bool flag19 = text25.ToLower() == "npcstream=";
			if ("npcstream=" == null)
			{
			}
			string text26;
			int num7 = Convert.ToInt32(text26);
			if ("npcstream=" == null)
			{
			}
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000AD3D4 File Offset: 0x000AB5D4
		public void SetNetPlayers(int mPlayers)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000AD3E4 File Offset: 0x000AB5E4
		public void SetWorld(string world, bool cloud)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000AD3F4 File Offset: 0x000AB5F4
		public void SetWorldName(string world)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000AD404 File Offset: 0x000AB604
		public void EnableAutoShutdown()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000AD414 File Offset: 0x000AB614
		public void AutoPass()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000AD424 File Offset: 0x000AB624
		public void AutoJoin(string IP)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag = Netplay.SetRemoteIP(IP);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000AD440 File Offset: 0x000AB640
		public void AutoHost()
		{
			if (!true)
			{
			}
			Main.ClearPendingPlayerSelectCallbacks();
			Main.menuMode = 1;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000AD45C File Offset: 0x000AB65C
		public void loadLib(string path)
		{
			if (!true)
			{
			}
			IntPtr intPtr = Main.LoadLibrary(path);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000AD474 File Offset: 0x000AB674
		public void NeverSleep()
		{
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000AD484 File Offset: 0x000AB684
		public void YouCanSleepNow()
		{
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000AD494 File Offset: 0x000AB694
		public static void RunServerCallBack(object threadContext)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (256 == 0)
			{
			}
			Profiler.EndThreadProfiling();
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000AD4E4 File Offset: 0x000AB6E4
		public static void RunDedServ(string worldName, string password)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			long num = 0L;
			if (WorldFile.GetAllMetadata(worldName, num != 0L) == null)
			{
				long num2 = 0L;
				WorldFileData worldFileData = WorldFileData.FromInvalidWorld(worldName, num2 != 0L);
				if (!true)
				{
				}
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000AD518 File Offset: 0x000AB718
		public void DedServ()
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			ManagedThread managedThread = WorldGen.serverLoadWorld();
			Debug.Log(Language.GetTextValue("CLI.Server", num2));
			Debug.Log("");
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x000AD6B0 File Offset: 0x000AB8B0
		private static void WriteFancyWorldLoadErrorToConsole()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000AD6C4 File Offset: 0x000AB8C4
		public static void startDedInput()
		{
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000AD6D4 File Offset: 0x000AB8D4
		public static void startDedInputCallBack()
		{
			Console.Write(": ");
			string text = Main.ReadLineInput().ToLower();
			string textValue = Language.GetTextValue("CLI.Help_Command");
			bool flag = text == textValue;
			Console.WriteLine(Language.GetTextValue("CLI.AvailableCommands"));
			Console.WriteLine("");
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000ADF44 File Offset: 0x000AC144
		private static string ReadLineInput()
		{
			if (!true)
			{
			}
			string text = Console.ReadLine();
			while (text == null)
			{
			}
			return text;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000ADF60 File Offset: 0x000AC160
		public static bool IsFastForwardingTime()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000ADF74 File Offset: 0x000AC174
		public static void Sundialing()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000ADF8C File Offset: 0x000AC18C
		public static void Moondialing()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000ADFA4 File Offset: 0x000AC1A4
		public static void UpdateTimeRate()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = Main.IsFastForwardingTime();
			if (num == 0)
			{
			}
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000AE000 File Offset: 0x000AC200
		public Main()
		{
			if (!true)
			{
			}
			int num = 16256;
			int num2 = 210;
			this.chestLootScale = (float)num;
			this.chestStackScale = (float)num;
			this.chestDepositScale = (float)num;
			this.chestRenameScale = (float)num;
			this.chestCancelScale = (float)num;
			this.invBottom = num2;
			this.logoScaleSpeed = (float)num;
			int num3 = 1;
			this._needToSetupDrawInterfaceLayers = num3 != 0;
			base..ctor();
			int hashCode = Guid.NewGuid().GetHashCode();
			if (!true)
			{
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000AE08C File Offset: 0x000AC28C
		protected void SetTitle()
		{
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000AE09C File Offset: 0x000AC29C
		private static void SetTileValue()
		{
			if (!true)
			{
			}
			int num = 500;
			int num2 = 500;
			num.m_value = num2;
			int num3 = 600;
			int num4 = 610;
			num3.m_value = num4;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x000AE130 File Offset: 0x000AC330
		private static void ResetGameCounter()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x000AE140 File Offset: 0x000AC340
		protected override void Initialize()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (("" == null || "" != null) && ("" == null || "" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x000AE1C8 File Offset: 0x000AC3C8
		private void Initialize_AlmostEverything()
		{
			int num = 1;
			TilePaintSystemV2 tilePaintSystem = this.TilePaintSystem;
			TilePaintSystemV2 tilePaintSystem2 = this.TilePaintSystem;
			CreativePowerManager.Initialize();
			this.Initialize_Entities();
			if (num == 0)
			{
			}
			Main.FindAnnouncementBoxStatus();
			if (num == 0)
			{
			}
			CustomCurrencyManager.Initialize();
			WingStatsInitializer.Load();
			TileObjectData.Initialize();
			Animation.Initialize();
			if (num == 0)
			{
			}
			Chest.Initialize();
			if (num == 0)
			{
			}
			Wiring.Initialize();
			Framing.Initialize();
			if (num == 0)
			{
			}
			ItemRarity.Initialize();
			if (num == 0)
			{
			}
			TileEntity.InitializeAll();
			if (num == 0)
			{
			}
			Projectile.InitializeStaticThings();
			if (num == 0)
			{
			}
			TorchID.Initialize();
			ContentManager content = this.content;
			if (num == 0)
			{
			}
			GUIPageIcons.LoadContent(content);
			Main.InitializeItemAnimations();
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000AE424 File Offset: 0x000AC624
		private void Initialize_Entities()
		{
			if (!true)
			{
			}
			float[] array = this.menuItemScale;
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x000AE484 File Offset: 0x000AC684
		private static void Initialize_Items()
		{
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000AE4B4 File Offset: 0x000AC6B4
		private static void Initialize_TileAndNPCData2()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 60;
			if (num == 0)
			{
			}
			if (num2 != 0)
			{
				Main.AnimateTiles_CritterCages();
				return;
			}
			int num3 = 1;
			long num4 = 16843009L;
			int num5 = 257;
			long num6 = 16843009L;
			825.m_value = (int)num4;
			int num7 = 500;
			num7.m_value = (int)num4;
			num7.m_value = (int)num6;
			num7.m_value = (int)num4;
			num7.m_value = (int)num4;
			if (num5 == 0)
			{
			}
			if (num5 != 0)
			{
				if (num5 == 0)
				{
				}
				num5.m_value = num3;
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000AE5B8 File Offset: 0x000AC7B8
		private static void AddEchoFurnitureTile(int tileId)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000AE5CC File Offset: 0x000AC7CC
		private static void Initialize_TileAndNPCData1()
		{
			int num = 1;
			int num2 = 65535;
			if (num == 0)
			{
			}
			num.m_value = num2;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000AEA30 File Offset: 0x000ACC30
		private void ClientInitialize()
		{
			if (!true)
			{
			}
			string text = Guid.NewGuid().ToString();
			GameWindow window = base.Window;
			int screenWidth = Main.screenWidth;
			Main.screenWidth = 42190744;
			int screenHeight = Main.screenHeight;
			Main.screenHeight = 42190744;
			PlayerInput.CacheOriginalScreenDimensions();
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			GraphicsDevice graphicsDevice = base.GraphicsDevice;
			GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
			GraphicsDevice graphicsDevice3 = base.GraphicsDevice;
			Main.menuMode = 1212;
			Main.CacheSupportedDisplaySizes();
			Main.LoadPlayers();
			Main.menuMode = 1;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x000AEAC0 File Offset: 0x000ACCC0
		private static void CacheSupportedDisplaySizes()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			IEnumerator<DisplayMode> enumerator = GraphicsAdapter.DefaultAdapter._supportedDisplayModes.GetEnumerator();
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x000AEB20 File Offset: 0x000ACD20
		public static void LoadTestLog(string logname)
		{
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000AEB30 File Offset: 0x000ACD30
		private void OnceFailedLoadingAnAsset(string assetPath, Exception e)
		{
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000AEB40 File Offset: 0x000ACD40
		public static void ProcessAsyncLoad()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x000AEB54 File Offset: 0x000ACD54
		protected override void LoadContent()
		{
			SoundEngine.Initialize();
			if (base.Services.Get<IAssetRepository>() == null)
			{
				AssetInitializer.CreateAssetServices(base.Services);
			}
			IAssetRepository assetRepository = base.Services.Get<IAssetRepository>();
			GraphicsDevice graphicsDevice = base.GraphicsDevice;
			Effect effect = this.content.Load<Effect>("PixelShader");
			graphicsDevice._viewport = effect;
			Effect effect2;
			graphicsDevice._viewport = effect2;
			Effect effect3;
			graphicsDevice._viewport = effect3;
			Effect effect4;
			graphicsDevice._viewport = effect4;
			GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
			GraphicsDevice graphicsDevice3 = base.GraphicsDevice;
			GraphicsDevice graphicsDevice4 = base.GraphicsDevice;
			GraphicsDevice graphicsDevice5 = base.GraphicsDevice;
			GraphicsDevice graphicsDevice6 = base.GraphicsDevice;
			GraphicsDevice graphicsDevice7 = base.GraphicsDevice;
			AssetInitializer.LoadSplashAssets(true);
			IEnumerator enumerator = this.LoadContent_Deferred();
			this._gameContentLoadProcess = enumerator;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x000AEC0C File Offset: 0x000ACE0C
		private void LoadContent_TryEnteringHiDef()
		{
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x000AEC1C File Offset: 0x000ACE1C
		protected IEnumerator LoadContent_Deferred()
		{
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000AEC2C File Offset: 0x000ACE2C
		private void TickLoadProcess()
		{
			IEnumerator gameContentLoadProcess = this._gameContentLoadProcess;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x000AEC44 File Offset: 0x000ACE44
		private static void PostContentLoadInitialize()
		{
			if (!true)
			{
			}
			LiquidRenderer.LoadContent();
			DyeInitializer.Load();
			ScreenEffectInitializer.Load();
			if (!true)
			{
			}
			Mount.Initialize();
			Minecart.Initialize();
			Main.CacheSupportedDisplaySizes();
			ContentSamples.RebuildItemCreativeSortingIDsAfterRecipesAreSetUp();
			ContentSamples.CommonlyUsedContentSamples.PrepareAfterEverythingElseLoaded();
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x000AEC94 File Offset: 0x000ACE94
		private IEnumerator LoadMusic_InSteps()
		{
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x000AECA4 File Offset: 0x000ACEA4
		protected override void UnloadContent()
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x000AECB4 File Offset: 0x000ACEB4
		public static void CheckForMoonEventsStartingTemporarySeasons()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x000AECDC File Offset: 0x000ACEDC
		public static void CheckForMoonEventsScoreDisplay()
		{
			if (!true)
			{
			}
			if ("Misc.FrostMoonScore" == null)
			{
			}
			if ("Misc.FrostMoonScore" == null)
			{
			}
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x000AED00 File Offset: 0x000ACF00
		public static void stopMoonEvent()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool logicHost = Main.LogicHost;
			bool logicHost2 = Main.LogicHost;
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000AED20 File Offset: 0x000ACF20
		public static void startPumpkinMoon()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			long num2 = 1L;
			if (305 == 0)
			{
			}
			if (num2 == 0L)
			{
			}
			if (num2 != 0L || num2 == 0L)
			{
			}
			if (num2 == 0L)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x000AED70 File Offset: 0x000ACF70
		public static void startSnowMoon()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			long num2 = 1L;
			if (338 == 0)
			{
			}
			if (num2 == 0L)
			{
			}
			if (num2 != 0L || num2 == 0L)
			{
			}
			if (num2 == 0L)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000AEDC4 File Offset: 0x000ACFC4
		public void UpdateAudio()
		{
			bool musicLoaded = this._musicLoaded;
			if (!musicLoaded)
			{
				return;
			}
			SoundEngine.Update();
			float musicVolume = Main.musicVolume;
			if (this._active)
			{
				return;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x000AF8A0 File Offset: 0x000ADAA0
		public static bool IsItAHappyWindyDay
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E7E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_IsItAHappyWindyDay()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x000AF8B0 File Offset: 0x000ADAB0
		public static bool IsItStorming
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E7F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_IsItStorming()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x000AF8C0 File Offset: 0x000ADAC0
		public static bool WindyEnoughForKiteDrops
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E80)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_WindyEnoughForKiteDrops()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000AF8D0 File Offset: 0x000ADAD0
		private void UpdateAudio_DecideOnTOWMusic()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				int screenWidth = Main.screenWidth;
				float musicVolume = Main.musicVolume;
				return;
			}
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			int screenWidth2 = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000AFDEC File Offset: 0x000ADFEC
		private void UpdateAudio_DecideOnNewMusic()
		{
			if (!true)
			{
			}
			float townNPCs = Main.LocalPlayer.townNPCs;
			int <ShadowCandleCount>k__BackingField = Main.SceneMetrics.<ShadowCandleCount>k__BackingField;
			if (<ShadowCandleCount>k__BackingField == 0)
			{
			}
			Item[] inventory = Main.LocalPlayer.inventory;
			Player localPlayer = Main.LocalPlayer;
			if (<ShadowCandleCount>k__BackingField == 0)
			{
			}
			if (<ShadowCandleCount>k__BackingField == 0)
			{
			}
			this.lastMusicPlayed = <ShadowCandleCount>k__BackingField;
			int num = this.lastMusicPlayed;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				int screenWidth = Main.screenWidth;
				float musicVolume = Main.musicVolume;
				return;
			}
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			int screenWidth2 = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000B0628 File Offset: 0x000AE828
		private void UpdateWindyDayState()
		{
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000B0648 File Offset: 0x000AE848
		public static void snowing()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 scaledSize = Main.Camera.ScaledSize;
				Microsoft.Xna.Framework.Vector2 scaledPosition = Main.Camera.ScaledPosition;
				if (num == 0)
				{
					if (num == 0)
					{
					}
					if (Main.SceneMetrics.<SnowTileCount>k__BackingField == 0)
					{
					}
					int myPlayer = Main.myPlayer;
					if (Main.myPlayer == 0)
					{
					}
					SceneMetrics sceneMetrics = Main.SceneMetrics;
					int <SnowTileCount>k__BackingField = sceneMetrics.<SnowTileCount>k__BackingField;
					int <HoneyBlockCount>k__BackingField = sceneMetrics.<HoneyBlockCount>k__BackingField;
					Microsoft.Xna.Framework.Vector2 scaledSize2 = Main.Camera.ScaledSize;
					int num2 = 32768;
					bool flag = NPC.IsADeerclopsNearScreen();
					float gfxQuality = Main.gfxQuality;
					int myPlayer2 = Main.myPlayer;
					int myPlayer3 = Main.myPlayer;
					int num3 = 32768;
					if (32640 == 0)
					{
					}
					int num4;
					if (num4 == 0)
					{
						if (num3 == 0)
						{
						}
						return;
					}
					if (num3 == 0)
					{
					}
					int num5;
					if (num5 != 0)
					{
						return;
					}
					if (num4 == 0)
					{
					}
					if (num4 == 0)
					{
					}
					if (num3 == 0)
					{
					}
					long num6 = 0L;
					int num7;
					int num8;
					bool flag2 = WorldGen.InWorld(num7, num8, (int)num6);
					Tile tile;
					bool flag3 = tile.nactive();
					Tile tile2;
					ushort wall = tile2.wall;
					if (num2 == 0)
					{
					}
					float num10;
					int num9 = Math.Sign(num10);
					if (num3 == 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000B07A8 File Offset: 0x000AE9A8
		public static void checkXMas()
		{
			if (!true)
			{
			}
			int day = DateTime.Now.Day;
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x000B07C8 File Offset: 0x000AE9C8
		public static void checkHalloween()
		{
			if (!true)
			{
			}
			int day = DateTime.Now.Day;
			int num;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x000B07F8 File Offset: 0x000AE9F8
		public void updateCloudLayer()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000B08B4 File Offset: 0x000AEAB4
		public static void TeleportEffect(Rectangle effectRect, int Style, int extraInfo = 0, float dustCountMult = 1f, TeleportationSide side = TeleportationSide.Entry, [Optional] Microsoft.Xna.Framework.Vector2 otherPosition)
		{
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000B0C5C File Offset: 0x000AEE5C
		public static void Ambience()
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = Main.LocalPlayer.Center;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x000B0D00 File Offset: 0x000AEF00
		public static void AnimateTiles_CritterCages()
		{
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x000B213C File Offset: 0x000B033C
		private static void UpdateOwlCageFrames()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x000B2154 File Offset: 0x000B0354
		private static void UpdateDragonflyJarFrames()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x000B2174 File Offset: 0x000B0374
		private static void UpdateOwlCageFrame(int[] frames, int[] frameCounters, int style)
		{
			int num = 1;
			int num2 = 26215;
			if (num2 != 0)
			{
				frameCounters.m_value = num;
				return;
			}
			if (num == 0)
			{
			}
			int num3;
			while (num3 == 0)
			{
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000B21AC File Offset: 0x000B03AC
		private static void UpdateDragonflyJarFrame(int[,] frames, int[,] frameCounters, int style, int variation)
		{
			int num;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000B21E0 File Offset: 0x000B03E0
		public static void DoUpdate_AnimateItemIcons()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x000B21F8 File Offset: 0x000B03F8
		public static void QueueMainThreadAction(Action action)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000B2208 File Offset: 0x000B0408
		private static void ConsumeAllMainThreadActions()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x000B221C File Offset: 0x000B041C
		protected override void Update(GameTime gameTime)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0 || num == 0)
				{
				}
			}
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000B227C File Offset: 0x000B047C
		public void UpdateViewZoomKeys()
		{
			if (!true)
			{
			}
			bool inFancyUI = Main.inFancyUI;
			if (!true)
			{
			}
			bool viewZoomIn = PlayerInput.Triggers.Current.ViewZoomIn;
			if (!true)
			{
			}
			bool viewZoomOut = PlayerInput.Triggers.Current.ViewZoomOut;
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000B22C0 File Offset: 0x000B04C0
		public static void NotifyOfEvent(GameNotificationType type)
		{
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x000B22D0 File Offset: 0x000B04D0
		protected void DoUpdate(GameTime gameTime)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			this.UpdateAudio();
			if (gameTime.totalGameTime == null)
			{
			}
			LocalUser.UnloadState();
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x000B28D4 File Offset: 0x000B0AD4
		internal static void UpdateCreativeGameModeOverride()
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (!true)
			{
			}
			if (true)
			{
				float <StrengthMultiplierToGiveNPCs>k__BackingField = CreativePowerManager.Instance.GetPower<CreativePowers.DifficultySliderPower>().<StrengthMultiplierToGiveNPCs>k__BackingField;
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000B2904 File Offset: 0x000B0B04
		private static void TryPlayingCreditsRoll()
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (!true)
			{
			}
			bool flag = Main.CanPlayCreditsRoll();
			if (!true)
			{
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x000B2928 File Offset: 0x000B0B28
		private static bool CanPauseGame()
		{
			/*
An exception occurred when decompiling this method (06001E98)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::CanPauseGame()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:AutoPauseMode(var_3_2B, callgetter:AutoPauseMode(Main::get_autoPause))
	stloc:bool(var_4_31, callgetter:bool(Main::get_playerInventory))
	stloc:int32(var_5_3D, ldfld:int32(Player::sign, callgetter:Player(Main::get_LocalPlayer)))
	brtrue(IL_0000, ldc.i4:bool(0))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x000B2978 File Offset: 0x000B0B78
		private static void DoUpdate_WhilePaused()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				bool editSign = Main.editSign;
				if (num == 0)
				{
				}
				bool editChest = Main.editChest;
				if (num == 0)
				{
				}
				bool blockInput = Main.blockInput;
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				int myPlayer2 = Main.myPlayer;
				int myPlayer3 = Main.myPlayer;
				int myPlayer4 = Main.myPlayer;
				int myPlayer5 = Main.myPlayer;
				return;
			}
			bool playerInventory = Main.playerInventory;
			int myPlayer6 = Main.myPlayer;
			Recipe.GetThroughDelayedFindRecipes();
			Main.focusRecipe = Main.focusRecipe;
			int focusRecipe = Main.focusRecipe;
			int numAvailableRecipes = Main.numAvailableRecipes;
			Main.focusRecipe = Main.numAvailableRecipes;
			int focusRecipe2 = Main.focusRecipe;
			Main.focusRecipe = 0;
			int myPlayer7 = Main.myPlayer;
			int myPlayer8 = Main.myPlayer;
			int myPlayer9 = Main.myPlayer;
			int myPlayer10 = Main.myPlayer;
			int myPlayer11 = Main.myPlayer;
			int myPlayer12 = Main.myPlayer;
			int myPlayer13 = Main.myPlayer;
			int myPlayer14 = Main.myPlayer;
			int myPlayer15 = Main.myPlayer;
			int myPlayer16 = Main.myPlayer;
			int myPlayer17 = Main.myPlayer;
			int myPlayer18 = Main.myPlayer;
			int myPlayer19 = Main.myPlayer;
			int myPlayer20 = Main.myPlayer;
			int myPlayer21 = Main.myPlayer;
			int myPlayer22 = Main.myPlayer;
			int myPlayer23 = Main.myPlayer;
			int myPlayer24 = Main.myPlayer;
			int myPlayer25 = Main.myPlayer;
			int myPlayer26 = Main.myPlayer;
			int myPlayer27 = Main.myPlayer;
			bool editSign2 = Main.editSign;
			int num2;
			if (num2 != 0)
			{
				int myPlayer28 = Main.myPlayer;
				if (num2 == 0)
				{
				}
				Main.InputTextSign();
				return;
			}
			bool editChest2 = Main.editChest;
			Main.InputTextChest();
			int myPlayer29 = Main.myPlayer;
			Main.editChest = false;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x000B2B38 File Offset: 0x000B0D38
		private static void UpdateUIStates(GameTime gameTime)
		{
			if (!true)
			{
			}
			Main.BigBossProgressBar.Update();
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x000B2B54 File Offset: 0x000B0D54
		private void DoDebugFunctions()
		{
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x000B2B64 File Offset: 0x000B0D64
		private void PreUpdateAllProjectiles()
		{
			if (!true)
			{
			}
			this.SpelunkerProjectileHelper.OnPreUpdateAllProjectiles();
			this.ChumBucketProjectileHelper.OnPreUpdateAllProjectiles();
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x000B2B8C File Offset: 0x000B0D8C
		private void PostUpdateAllProjectiles()
		{
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x000B2B9C File Offset: 0x000B0D9C
		private static void TrySyncingMyPlayer()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000B2E8C File Offset: 0x000B108C
		private static void TrySyncingItemArray(bool syncedAnyInventoryContents, Item[] my, Item[] other, int slotOffset)
		{
			long entityId = my.entityId;
			int num = 1;
			syncedAnyInventoryContents.m_value = num != 0;
			if (entityId == 0L)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000B2EB8 File Offset: 0x000B10B8
		public bool ShouldUpdateEntities()
		{
			/*
An exception occurred when decompiling this method (06001EA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::ShouldUpdateEntities()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000B2EC8 File Offset: 0x000B10C8
		private void DoUpdateInWorld(Stopwatch sw)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000B32B4 File Offset: 0x000B14B4
		private static void CheckBossIndexes()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x000B32CC File Offset: 0x000B14CC
		public static bool IsNPCActiveAndOneOfTypes(int npcIndex, short npcType)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x000B32E0 File Offset: 0x000B14E0
		private static void UpdateOldNPCShop()
		{
			if (!true)
			{
			}
			int npcShop = Main.npcShop;
			int oldNPCShop = Main.oldNPCShop;
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000B3314 File Offset: 0x000B1514
		private static void DoUpdate_AnimateCursorColors()
		{
			if (!true)
			{
			}
			Main.CursorColor();
			if (!true)
			{
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000B332C File Offset: 0x000B152C
		private static void DoUpdate_AnimateTileGlows()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000B3348 File Offset: 0x000B1548
		private static void DoUpdate_Enter_ToggleChat()
		{
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x000B3358 File Offset: 0x000B1558
		public static void OpenPlayerChat()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000B3370 File Offset: 0x000B1570
		public static void ClosePlayerChat()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x000B338C File Offset: 0x000B158C
		private static void DoUpdate_HandleChat()
		{
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x000B339C File Offset: 0x000B159C
		private void DoUpdate_HandleInput()
		{
			int num = 1;
			if (num == 0)
			{
			}
			PlayerInput.UpdateInput();
			PlayerInput.SetZoom_Unscaled();
			PlayerInput.CacheMousePositionForZoom();
			PlayerInput.SetZoom_MouseInWorld();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			KeyboardState state = Keyboard.GetState();
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x000B33DC File Offset: 0x000B15DC
		private static void DoUpdate_AltEnter_ToggleFullscreen()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Main.ToggleFullScreen();
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000B3410 File Offset: 0x000B1610
		private static void DoUpdate_F11_ToggleUI()
		{
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x000B3420 File Offset: 0x000B1620
		private static void DoUpdate_F7_ToggleGraphicsDiagnostics()
		{
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x000B3430 File Offset: 0x000B1630
		private static void DoUpdate_F8_ToggleNetDiagnostics()
		{
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x000B3440 File Offset: 0x000B1640
		private static void DoUpdate_F9_ToggleLighting()
		{
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x000B3450 File Offset: 0x000B1650
		private static void DoUpdate_F10_ToggleFPS()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				bool editSign = Main.editSign;
				if (num == 0)
				{
				}
				bool editChest = Main.editChest;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x000B34A4 File Offset: 0x000B16A4
		private static void AnimateTiles()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x000B3650 File Offset: 0x000B1850
		private static void AnimateTiles_WeatherVane()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 32640;
			if (num == 0)
			{
				return;
			}
			if (num != 0)
			{
				if (!true)
				{
				}
				if (num2 == 0)
				{
				}
				return;
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000B368C File Offset: 0x000B188C
		private static void DoUpdate_AnimateWalls()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x000B36AC File Offset: 0x000B18AC
		private void DoUpdate_AnimateWaterfalls()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (16512 == 0)
			{
			}
			if (!true)
			{
			}
			if (16256 == 0)
			{
			}
			WaterfallManager waterfallManager;
			waterfallManager.UpdateFrame();
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000B36DC File Offset: 0x000B18DC
		private static void DoUpdate_AnimateVisualPlayerAura()
		{
			if (!true)
			{
			}
			byte gFadeDir = Main.gFadeDir;
			Main.gFader = Main.gFader;
			float gFader = Main.gFader;
			byte gFade = Main.gFade;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x000B3728 File Offset: 0x000B1928
		private void DoUpdate_AnimateDiscoRGB()
		{
			int discoStyle = this.DiscoStyle;
			if (discoStyle == 0)
			{
				if (discoStyle == 0)
				{
				}
				int discoStyle2 = this.DiscoStyle;
				return;
			}
			int num;
			if (num == 0)
			{
			}
			int discoStyle3 = this.DiscoStyle;
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000B37F8 File Offset: 0x000B19F8
		private static void DoUpdate_AnimateBackgrounds()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000B380C File Offset: 0x000B1A0C
		private static void DoUpdate_AnimateBackgrounds_UpdateForest(int bgIndex, int[] bgSet)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int[] bgFrameCounter = Main.bgFrameCounter;
			int[] bgFrameCounter2 = Main.bgFrameCounter;
			if (num == 0)
			{
			}
			int[] bgFrameCounter3 = Main.bgFrameCounter;
			int[] bgFrame = Main.bgFrame;
			int[] bgFrame2 = Main.bgFrame;
			if (num == 0)
			{
			}
			int[] bgFrame3 = Main.bgFrame;
			if (num == 0)
			{
			}
			int[] bgFrame4 = Main.bgFrame;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int[] bgFrame5 = Main.bgFrame;
				return;
			}
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x000B3918 File Offset: 0x000B1B18
		private static void DoUpdate_AutoSave()
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			bool is_running = Main.saveTime.is_running;
			if (!is_running)
			{
				if (!is_running)
				{
				}
				Main.saveTime.Start();
			}
			if (!is_running)
			{
			}
			long elapsedMilliseconds = Main.saveTime.ElapsedMilliseconds;
			Main.saveTime.Reset();
			WorldGen.saveToonWhilePlaying();
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x000B3A10 File Offset: 0x000B1C10
		private static void UpdateSettingUnlocks()
		{
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
			if (!true)
			{
			}
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000B3A48 File Offset: 0x000B1C48
		public static void InputTextSign()
		{
			bool flag = IngameFancyUI.CanShowVirtualKeyboard(1);
			int keyboardContext = UIVirtualKeyboard.KeyboardContext;
			string npcChatText = Main.npcChatText;
			string text;
			Main.npcChatText = text;
			if (true)
			{
				if (npcChatText != null)
				{
					Main.SubmitSignText();
					return;
				}
			}
			else
			{
				while (npcChatText != null)
				{
				}
			}
			Main.InputTextSignCancel();
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000B3A88 File Offset: 0x000B1C88
		public static void InputTextChest()
		{
			bool flag = IngameFancyUI.CanShowVirtualKeyboard(2);
			int keyboardContext = UIVirtualKeyboard.KeyboardContext;
			string npcChatText = Main.npcChatText;
			!0 ! = PageControllerLayoutDefinition.Instance;
			string npcChatText2 = Main.npcChatText;
			string text;
			Main.npcChatText = text;
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000B3AD8 File Offset: 0x000B1CD8
		public static void InputTextSignCancel()
		{
			if (!true)
			{
			}
			Main.editSign = false;
			string text;
			Main.blockKey = text;
			UIVirtualKeyboard.CacheCanceledInput(1);
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x000B3B10 File Offset: 0x000B1D10
		private static void UpdateMenu()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					int num2;
					string text = num2.ToString();
					int num3 = 2;
					if ("" == null)
					{
					}
					int num4;
					if (num4 == 0)
					{
						int num5;
						string text2 = num5.ToString();
						string text3 = "" + text2;
					}
					if (num3 != 0)
					{
						return;
					}
				}
			}
			InGameNotificationsTracker.Clear();
			Main.playerInventory = false;
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x000B3C64 File Offset: 0x000B1E64
		public static void clrInput()
		{
			if (!true)
			{
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x000B3C74 File Offset: 0x000B1E74
		public static bool HasKeyboard
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001EC1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_HasKeyboard()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x000B3C84 File Offset: 0x000B1E84
		public static bool KeyboardIsActive
		{
			get
			{
				if (!true)
				{
				}
				if (true)
				{
					return;
				}
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000B3C98 File Offset: 0x000B1E98
		public static void OpenKeyboard(string initial, int maxCharacters = -1, bool password = false, bool multiline = false, bool filterText = true)
		{
			if (!true)
			{
			}
			bool hidePassword = Main.HidePassword;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x000B3CB4 File Offset: 0x000B1EB4
		public static void CloseKeyboard()
		{
			if (!true)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06001EC5 RID: 7877
		public static extern short GetKeyState(int keyCode);

		// Token: 0x06001EC6 RID: 7878 RVA: 0x000B3CC8 File Offset: 0x000B1EC8
		public static string GetInputText(string oldString, Rectangle region, int maxCharacters = -1, bool password = false, bool retainText = false, bool multiline = false, bool filterText = true)
		{
			int num = 1;
			string text;
			if (num != 0)
			{
				if (num == 0)
				{
					return text;
				}
				Microsoft.Xna.Framework.Vector2 uicursorPosition = Mouse.GetUICursorPosition();
				DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
				global::Cursor cursor;
				if (cursor != null)
				{
				}
				DrPlatform.DrPlatformType currentPlatform2 = DrPlatform.CurrentPlatform;
			}
			int num2;
			while (num2 != 0)
			{
			}
			return text;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000B3D60 File Offset: 0x000B1F60
		public void MouseTextHackZoom(string text, [Optional] string buffTooltip)
		{
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x000B3D70 File Offset: 0x000B1F70
		public void MouseTextHackZoom(string text, int itemRarity, byte diff = 0, [Optional] string buffTooltip)
		{
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000B3D80 File Offset: 0x000B1F80
		public void MouseTextNoOverride(string cursorText, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0)
		{
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x000B3D90 File Offset: 0x000B1F90
		public void MouseText(string cursorText, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0)
		{
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x000B3DA0 File Offset: 0x000B1FA0
		public void MouseText(string cursorText, string buffTooltip, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0, bool noOverride = false)
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x000B3DB0 File Offset: 0x000B1FB0
		private void MouseTextInner(Main.MouseTextCache info, bool worldMouse)
		{
			if (info.cursorText == null)
			{
				return;
			}
			byte diff = info.diff;
			int rare = info.rare;
			int x = info.X;
			int y = info.Y;
			int hackedScreenWidth = info.hackedScreenWidth;
			string buffTooltip = info.buffTooltip;
			if (diff != 0)
			{
				int worldMouseX = Main.worldMouseX;
				return;
			}
			int mouseX = Main.mouseX;
			if (diff != 0)
			{
				int worldMouseY = Main.worldMouseY;
				return;
			}
			int mouseY = Main.mouseY;
			int num = 10;
			bool thickMouse = Main.ThickMouse;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x000B3F34 File Offset: 0x000B2134
		private void MouseText_DrawItemTooltip(Main.MouseTextCache info, int rare, byte diff, int X, int Y)
		{
			if (!true)
			{
			}
			bool settingsEnabled_OpaqueBoxBehindTooltips = Main.SettingsEnabled_OpaqueBoxBehindTooltips;
			if (true)
			{
				return;
			}
			int mouseY = Main.mouseY;
			int screenWidth = Main.screenWidth;
			int overloadedMousePositionX = Main.overloadedMousePositionX;
			int overloadedMousePositionX2 = Main.overloadedMousePositionX;
			int overloadedMousePositionY = Main.overloadedMousePositionY;
			Main.overloadedMousePositionX = overloadedMousePositionY;
			Main.overloadedMousePositionY = overloadedMousePositionY;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x000B457C File Offset: 0x000B277C
		public static void MouseText_DrawItemTooltip_GetLinesInfo(Item item, int yoyoLogo, int researchLine, int materialsLine, float oldKB, int numLines, string[] toolTipLine, bool[] preFixLine, bool[] badPreFixLine, int setBonusLine)
		{
			string hoverName = item.HoverName;
			if (hoverName == null || hoverName != null)
			{
				bool favorited = item.favorited;
				if (favorited)
				{
					numLines.m_value = (favorited ? 1 : 0);
					if (!favorited)
					{
					}
					if ((hoverName != null && hoverName == null) || (hoverName != null && hoverName == null))
					{
						goto IL_0B7C;
					}
					int num = Main.LocalPlayer.chest;
					string textValue = Language.GetTextValue("UI.ItemCannotBePlacedInsideItself");
					if (textValue != null && textValue == null)
					{
						goto IL_0B7C;
					}
				}
				bool social = item.social;
				if (social)
				{
					if (!social)
					{
					}
					if (preFixLine == null || preFixLine != null)
					{
						if (preFixLine != null)
						{
							if (preFixLine != null)
							{
								return;
							}
						}
						else
						{
							if (item.expert)
							{
								string textValue2 = Language.GetTextValue("GameUI.Expert");
								if (textValue2 != null && textValue2 == null)
								{
									goto IL_0B7C;
								}
							}
							int rare = item.rare;
							string textValue3 = Language.GetTextValue("GameUI.Master");
							if (textValue3 == null || textValue3 != null)
							{
								if (item.tooltipContext == 0)
								{
								}
								byte difficulty = Main.LocalPlayer.difficulty;
								if (difficulty == 0)
								{
								}
								int type = item.type;
								if (difficulty == 0)
								{
								}
								ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
								int type2 = item.type;
								int sacrificeCount = itemSacrifices.GetSacrificeCount(type2);
								string text;
								if (text == null || text != null)
								{
									bool flag = string.IsNullOrWhiteSpace(item.BestiaryNotes);
									long num2 = 0L;
									if (text == null || text != null)
									{
										int tooltipContext = item.tooltipContext;
										if (" " == null)
										{
											return;
										}
										if (" " != null)
										{
											return;
										}
									}
								}
							}
						}
					}
				}
				else
				{
					int damage = item.damage;
					if (!item.notAmmo || item.useStyle != 0)
					{
						int type3 = item.type;
						if (type3 == 0)
						{
						}
						int myPlayer = Main.myPlayer;
						int damage2 = item.damage;
						if (type3 == 0)
						{
						}
						bool melee = item.melee;
						if (melee)
						{
							if (!melee)
							{
							}
							float meleeDamage = Main.LocalPlayer.meleeDamage;
							return;
						}
						bool ranged = item.ranged;
						if (ranged)
						{
							if (!ranged)
							{
							}
							Player localPlayer = Main.LocalPlayer;
							float rangedDamage = localPlayer.rangedDamage;
							int useAmmo = item.useAmmo;
							if (localPlayer == null)
							{
							}
							int useAmmo2 = item.useAmmo;
							long num2;
							if (num2 == 0L)
							{
							}
							if (localPlayer.oldVelocity.Y == null)
							{
							}
							float bowEffectiveDamage = Main.LocalPlayer.bowEffectiveDamage;
							bool archery = Main.LocalPlayer.archery;
							int useAmmo3 = item.useAmmo;
							if (!archery)
							{
							}
							int useAmmo4 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							if (!archery)
							{
							}
							float gunEffectiveDamage = Main.LocalPlayer.gunEffectiveDamage;
							int useAmmo5 = item.useAmmo;
							if (!archery)
							{
							}
							int useAmmo6 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo7 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo8 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo9 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo10 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo11 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo12 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo13 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo14 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							int useAmmo15 = item.useAmmo;
							if (num2 == 0L)
							{
							}
							float specialistEffectiveDamage = Main.LocalPlayer.specialistEffectiveDamage;
							int type4 = item.type;
							return;
						}
						bool magic = item.magic;
						if (magic)
						{
							if (!magic)
							{
							}
							float magicDamage = Main.LocalPlayer.magicDamage;
							return;
						}
						bool summon = item.summon;
						if (summon)
						{
							if (!summon)
							{
							}
							float minionDamage = Main.LocalPlayer.minionDamage;
							return;
						}
						string text2;
						if (text2 == null || text2 != null)
						{
							return;
						}
					}
					else
					{
						int fishingPole = item.fishingPole;
						string text3;
						if (text3 == null || text3 != null)
						{
							int num3;
							numLines.m_value = num3;
							string textValue4 = Language.GetTextValue("GameUI.BaitRequired");
							if (textValue4 == null || textValue4 != null)
							{
								int bait = item.bait;
								string text4;
								if (text4 == null || text4 != null)
								{
									int headSlot = item.headSlot;
									int bodySlot = item.bodySlot;
									int legSlot = item.legSlot;
									bool accessory = item.accessory;
									if (!accessory)
									{
										if (!accessory)
										{
										}
										int mountType = item.mountType;
									}
									int type5 = item.type;
									if (type5 == 0)
									{
									}
									int npcShop = Main.npcShop;
									if (type5 == 0)
									{
									}
									return;
								}
							}
						}
					}
				}
			}
			IL_0B7C:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000B510C File Offset: 0x000B330C
		private void MouseText_DrawBuffTooltip(string cursorText, string buffString, int X, int Y)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool settingsEnabled_OpaqueBoxBehindTooltips = Main.SettingsEnabled_OpaqueBoxBehindTooltips;
			if (17279 == 0)
			{
			}
			if (17279 == 0)
			{
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x000B5218 File Offset: 0x000B3418
		protected void DrawFPS()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool showFrameRate = Main.showFrameRate;
			if (num == 0)
			{
			}
			long num2 = 0L;
			StringBuilder stringBuilder;
			stringBuilder.AppendInt((int)num2);
			int num3 = 40;
			StringBuilder stringBuilder2 = stringBuilder.Append((char)num3);
			float gfxQuality = Main.gfxQuality;
			bool gameMenu = Main.gameMenu;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x000B527C File Offset: 0x000B347C
		public static void shine(Microsoft.Xna.Framework.Graphics.Color newColor, int type)
		{
			byte r = newColor.R;
			byte g = newColor.G;
			byte b = newColor.B;
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000B5328 File Offset: 0x000B3528
		public static void shine([Out] Microsoft.Xna.Framework.Vector3 newColor, int type, int frameX)
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x000B5388 File Offset: 0x000B3588
		private void DrawTileEntities(bool solidLayer, bool overRenderTargets, bool intoRenderTargets)
		{
			this.TilesRenderer.PostDrawTiles(solidLayer, overRenderTargets, intoRenderTargets);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000B53A4 File Offset: 0x000B35A4
		public void ClearCachedTileDraws()
		{
			TileDrawing tilesRenderer = this.TilesRenderer;
			long num = 0L;
			tilesRenderer.ClearCachedTileDraws(num != 0L);
			this.TilesRenderer.ClearCachedTileDraws(true);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000B53D0 File Offset: 0x000B35D0
		public void ResetAllContentBasedRenderTargets()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000B53E8 File Offset: 0x000B35E8
		public static bool IsTileSpelunkable(Tile t)
		{
			ushort num;
			short num2;
			short num3;
			return Main.IsTileSpelunkable(num, num2, num3);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000B5400 File Offset: 0x000B3600
		public static bool IsTileSpelunkable(ushort typeCache, short tileFrameX, short tileFrameY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000B5418 File Offset: 0x000B3618
		public static bool IsTileBiomeSightable(ushort type, short tileFrameX, short tileFrameY, Microsoft.Xna.Framework.Graphics.Color sightColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					goto IL_0027;
				}
			}
			tileFrameY.m_value = (short)num;
			IL_0027:
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
				}
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000B5484 File Offset: 0x000B3684
		protected void DrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			this.TilesRenderer.Draw(solidLayer, forRenderTargets, intoRenderTargets, waterStyleOverride);
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000B54A4 File Offset: 0x000B36A4
		protected void DrawGoreBehind()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num == 0)
				{
				}
				long num2 = 0L;
				int num3 = 63488;
				Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(1073741824, (int)num2);
				if (num3 == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
				return;
			}
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000B5528 File Offset: 0x000B3728
		protected void DrawGore()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
				return;
			}
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000B5598 File Offset: 0x000B3798
		public void DrawHealthBar(float X, float Y, int Health, int MaxHealth, float alpha, float scale = 1f, bool noFlip = false, bool inUISpace = false)
		{
			if (!true)
			{
			}
			int num = 32768;
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000B55F4 File Offset: 0x000B37F4
		public static float NPCAddHeight(NPC theNPC)
		{
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000B5604 File Offset: 0x000B3804
		protected void DrawProjectiles()
		{
			int num = 1;
			if (num == 0)
			{
			}
			PlayerInput.SetZoom_MouseInWorld();
			if (num == 0)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			int num2 = 1;
			long num3 = 0L;
			if (num2 == 0)
			{
			}
			this.DrawProj((int)num3);
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000B5660 File Offset: 0x000B3860
		public static int GetProjectileDesiredShader(Projectile proj)
		{
			/*
An exception occurred when decompiling this method (06001EDF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Main::GetProjectileDesiredShader(Terraria.Projectile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_3:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000021DB File Offset: 0x000003DB
		private void RefreshPlayerDrawOrder()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000021DB File Offset: 0x000003DB
		protected void DrawPlayers_BehindNPCs()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000021DB File Offset: 0x000003DB
		protected void DrawPlayers_AfterProjectiles()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000B5690 File Offset: 0x000B3890
		protected void DrawElderEye(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 worldPosition, float opacity, float scale, int frameNumber, Microsoft.Xna.Framework.Graphics.Color passedColor)
		{
			if (!true)
			{
			}
			if (17032 == 0)
			{
			}
			if (17032 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (17032 == 0)
			{
			}
			if (17032 == 0)
			{
			}
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x000B56C4 File Offset: 0x000B38C4
		protected void DrawNPCs(bool behindTiles = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			int num2 = 32640;
			int num3 = 790;
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition4 = Main.screenPosition;
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			if (num == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			bool isMechQueenUp = NPC.IsMechQueenUp;
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				long num4 = 0L;
				int num5 = 32768;
				Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(1073741824, (int)num4);
				if (num5 == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 screenPosition5 = Main.screenPosition;
				Microsoft.Xna.Framework.Vector2 screenPosition6 = Main.screenPosition;
			}
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x000B5904 File Offset: 0x000B3B04
		protected void DrawNPCCheckAlt(NPC n)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int type = n.type;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000B5928 File Offset: 0x000B3B28
		protected void DrawNPC(int iNPCIndex, bool behindTiles, LightMap lightMap, Rectangle lightRegion)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000B5940 File Offset: 0x000B3B40
		public void DrawNPCDirect_QueenSlimeWings(NPC rCurrentNPC, SpriteBatch mySpriteBatch, Microsoft.Xna.Framework.Vector2 screenPos, Microsoft.Xna.Framework.Vector2 drawCenter, Microsoft.Xna.Framework.Graphics.Color originColor)
		{
			if (!true)
			{
			}
			float[] localAI = rCurrentNPC.localAI;
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float rotation = rCurrentNPC.rotation;
			Microsoft.Xna.Framework.Vector2 bottom = rCurrentNPC.Bottom;
			float y = rCurrentNPC.velocity.Y;
			float rotation2 = rCurrentNPC.rotation;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000021DB File Offset: 0x000003DB
		public void DrawNPCDirect(SpriteBatch mySpriteBatch, NPC rCurrentNPC, bool behindTiles, Microsoft.Xna.Framework.Vector2 screenPos)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000B5994 File Offset: 0x000B3B94
		private static void DrawNPCDirect_Deerclops(SpriteBatch mySpriteBatch, NPC rCurrentNPC, Microsoft.Xna.Framework.Vector2 screenPos, int typeCache, Microsoft.Xna.Framework.Graphics.Color npcColor, Microsoft.Xna.Framework.Vector2 halfSize, SpriteEffects npcSpriteEffect)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 bottom = rCurrentNPC.Bottom;
			float x = screenPos.X;
			float y = screenPos.Y;
			if (num == 0)
			{
			}
			int y2 = rCurrentNPC.frame.Y;
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			int spriteDirection = rCurrentNPC.spriteDirection;
			float[] localAI = rCurrentNPC.localAI;
			if (16912 == 0)
			{
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000B5AE0 File Offset: 0x000B3CE0
		private static void DrawNPCDirect_DeerclopsLeg(SpriteBatch mySpriteBatch, NPC rCurrentNPC, Microsoft.Xna.Framework.Vector2 screenPos, int typeCache, Microsoft.Xna.Framework.Graphics.Color npcColor, Microsoft.Xna.Framework.Vector2 halfSize, SpriteEffects npcSpriteEffect)
		{
			int num = 1;
			if (num == 0)
			{
			}
			float x = rCurrentNPC.position.X;
			int width = rCurrentNPC.width;
			if (num == 0)
			{
			}
			float scale = rCurrentNPC.scale;
			float y = rCurrentNPC.position.Y;
			float y2 = screenPos.Y;
			int height = rCurrentNPC.height;
			float scale2 = rCurrentNPC.scale;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000021DB File Offset: 0x000003DB
		public void DrawNPCDirect(SpriteBatch mySpriteBatch, NPC rCurrentNPC, bool behindTiles, Microsoft.Xna.Framework.Vector2 screenPos, LightMap lightMap, Rectangle lightRegion)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000B5B74 File Offset: 0x000B3D74
		private static void DrawNPCDirect_Faeling(SpriteBatch mySpriteBatch, NPC rCurrentNPC, Microsoft.Xna.Framework.Vector2 screenPos, int typeCache, Microsoft.Xna.Framework.Graphics.Color npcColor, Microsoft.Xna.Framework.Vector2 halfSize, SpriteEffects npcSpriteEffect)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = rCurrentNPC.Center;
			float x = screenPos.X;
			float y = screenPos.Y;
			int whoAmI = rCurrentNPC.whoAmI;
			float rotation = rCurrentNPC.rotation;
			int y2 = rCurrentNPC.frame.Y;
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float scale = rCurrentNPC.scale;
			Microsoft.Xna.Framework.Vector2[] oldPos = rCurrentNPC.oldPos;
			Microsoft.Xna.Framework.Vector2[] oldPos2 = rCurrentNPC.oldPos;
			float x2 = rCurrentNPC.position.X;
			float y3 = rCurrentNPC.position.Y;
			Microsoft.Xna.Framework.Vector2[] oldPos3 = rCurrentNPC.oldPos;
			float x3 = rCurrentNPC.position.X;
			float y4 = rCurrentNPC.position.Y;
			int whoAmI2 = rCurrentNPC.whoAmI;
			Microsoft.Xna.Framework.Graphics.Color color2;
			float num;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num;
			int y5 = rCurrentNPC.frame.Y;
			Microsoft.Xna.Framework.Graphics.Color color4;
			float num2;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num2;
			Microsoft.Xna.Framework.Graphics.Color color6;
			Microsoft.Xna.Framework.Graphics.Color color5 = color6 * num2;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000B5CC8 File Offset: 0x000B3EC8
		private static void DrawNPCDirect_HallowBoss(SpriteBatch mySpriteBatch, NPC rCurrentNPC, Microsoft.Xna.Framework.Vector2 screenPos, int typeCache, Microsoft.Xna.Framework.Graphics.Color npcColor, Microsoft.Xna.Framework.Vector2 halfSize, SpriteEffects npcSpriteEffect)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = rCurrentNPC.Center;
			float x = screenPos.X;
			float y = screenPos.Y;
			bool flag = rCurrentNPC.AI_120_HallowBoss_IsInPhase2();
			float[] ai = rCurrentNPC.ai;
			float[] localAI = rCurrentNPC.localAI;
			if (32640 == 0)
			{
			}
			int num = 11;
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			Rectangle rectangle2;
			Microsoft.Xna.Framework.Vector2 vector2 = rectangle2.Size();
			float[] ai2 = rCurrentNPC.ai;
			if (num == 0)
			{
			}
			float[] ai3 = rCurrentNPC.ai;
			float[] ai4 = rCurrentNPC.ai;
			float[] ai5 = rCurrentNPC.ai;
			float[] ai6 = rCurrentNPC.ai;
			float[] ai7 = rCurrentNPC.ai;
			if (16948 == 0)
			{
			}
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000B613C File Offset: 0x000B433C
		private static void DrawNPCDirect_GetHallowBossArmFrame(NPC rCurrentNPC, [Out] int armFrame_Count, [Out] int armFrameToUseLeft, [Out] int armFrameToUseRight)
		{
			int num = 7;
			armFrame_Count.m_value = num;
			float[] ai = rCurrentNPC.ai;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000B61D4 File Offset: 0x000B43D4
		private static void DrawNPC_SlimeItem(NPC rCurrentNPC, int typeCache, Microsoft.Xna.Framework.Graphics.Color npcColor, float addedRotation)
		{
			float[] ai = rCurrentNPC.ai;
			int num = 32640;
			float scale = rCurrentNPC.scale;
			if (num == 0)
			{
			}
			float[] ai2 = rCurrentNPC.ai;
			float scale2 = rCurrentNPC.scale;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000B6288 File Offset: 0x000B4488
		public static void GetItemDrawFrame(int item, [Out] Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, [Out] Rectangle itemFrame)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000021DB File Offset: 0x000003DB
		protected void DrawNPCExtras(NPC n, bool beforeDraw, float addHeight, float addY, Microsoft.Xna.Framework.Graphics.Color npcColor, Microsoft.Xna.Framework.Vector2 halfSize, SpriteEffects npcSpriteEffect, Microsoft.Xna.Framework.Vector2 screenPosition)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000B62B0 File Offset: 0x000B44B0
		private void DrawProj_LightsBane(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			if (num == 0)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			EffectTechnique <CurrentTechnique>k__BackingField = Main.pixelShader.<CurrentTechnique>k__BackingField;
			int num2 = 60;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[num2];
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (<CurrentTechnique>k__BackingField == null)
			{
			}
			int type = proj.type;
			if (<CurrentTechnique>k__BackingField == null)
			{
			}
			int frame = proj.frame;
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float scale = proj.scale;
			int frame2 = proj.frame;
			int frame3 = proj.frame;
			Microsoft.Xna.Framework.Graphics.Color color2;
			float num3;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num3;
			float rotation = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num3;
			float rotation2 = proj.rotation;
			float rotation3 = proj.rotation;
			float rotation4 = proj.rotation;
			float rotation5 = proj.rotation;
			float rotation6 = proj.rotation;
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000B63BC File Offset: 0x000B45BC
		private void DrawProj_NightsEdge(Projectile proj)
		{
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float scale = proj.scale;
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			Point point;
			float num = Lighting.GetColor(point).ToVector3().Length();
			Microsoft.Xna.Framework.Graphics.Color color2;
			float num2;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num2;
			float rotation = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color4;
			float num3;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num2 * num3 * num2 * num2;
			float rotation2 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color5 = color * num3 * num3 * num3;
			float rotation3 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color7;
			Microsoft.Xna.Framework.Graphics.Color color6 = color7 * num3 * num;
			float rotation4 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color9;
			Microsoft.Xna.Framework.Graphics.Color color8 = color9 * num3 * num3;
			float rotation5 = proj.rotation;
			float rotation6 = proj.rotation;
			float num4;
			Microsoft.Xna.Framework.Vector2 vector2 = num4.ToRotationVector2();
			float opacity = proj.Opacity;
			Microsoft.Xna.Framework.Graphics.Color color11;
			Microsoft.Xna.Framework.Graphics.Color color10 = color11 * opacity;
			if (!true)
			{
			}
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x000B6538 File Offset: 0x000B4738
		private void DrawProj_Excalibur(Projectile proj)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float scale = proj.scale;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			Point point;
			float num2 = Lighting.GetColor(point).ToVector3().Length();
			Microsoft.Xna.Framework.Graphics.Color color2;
			float num3;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num3;
			float rotation = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color4;
			float num4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num4 * num3 * num4 * num4;
			float rotation2 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color5 = color * num3 * num3 * num3;
			float rotation3 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color7;
			Microsoft.Xna.Framework.Graphics.Color color6 = color7 * num3 * num3;
			float rotation4 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color9;
			Microsoft.Xna.Framework.Graphics.Color color8 = color9 * num4;
			float rotation5 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color11;
			Microsoft.Xna.Framework.Graphics.Color color10 = color11 * num4;
			float rotation6 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color13;
			Microsoft.Xna.Framework.Graphics.Color color12 = color13 * num4;
			float rotation7 = proj.rotation;
			float rotation8 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector2 = num4.ToRotationVector2();
			float opacity = proj.Opacity;
			int num5 = 1;
			float num7;
			float num8;
			float num6 = Utils.Remap(num4, num7, num4, num7, num8, num5 != 0);
			if (!true)
			{
			}
			float rotation9 = proj.rotation;
			int num9 = 1;
			float num10 = Utils.Remap(num6, num4, num8, num6, num8, num9 != 0);
			float num11;
			Microsoft.Xna.Framework.Vector2 vector3 = num11.ToRotationVector2();
			float opacity2 = proj.Opacity;
			Microsoft.Xna.Framework.Graphics.Color color15;
			Microsoft.Xna.Framework.Graphics.Color color14 = color15 * num6;
			int num12 = 1;
			float num13 = Utils.Remap(num6, num4, num11, num4, num11, num12 != 0);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x000B6788 File Offset: 0x000B4988
		private void DrawProj_TheHorsemansBlade(Projectile proj)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float scale = proj.scale;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			Point point;
			float num2 = Lighting.GetColor(point).ToVector3().Length();
			Microsoft.Xna.Framework.Graphics.Color color2;
			float num3;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num3;
			float rotation = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color4;
			float num4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num4 * num3 * num4 * num4;
			float rotation2 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color5 = color * num3 * num3 * num3;
			float rotation3 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color7;
			Microsoft.Xna.Framework.Graphics.Color color6 = color7 * num3 * num3;
			float rotation4 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color9;
			Microsoft.Xna.Framework.Graphics.Color color8 = color9 * num4;
			float rotation5 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color11;
			Microsoft.Xna.Framework.Graphics.Color color10 = color11 * num4;
			float rotation6 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color13;
			Microsoft.Xna.Framework.Graphics.Color color12 = color13 * num4;
			float rotation7 = proj.rotation;
			float rotation8 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector2 = num4.ToRotationVector2();
			float opacity = proj.Opacity;
			int num5 = 1;
			float num7;
			float num8;
			float num6 = Utils.Remap(num4, num7, num4, num7, num8, num5 != 0);
			if (!true)
			{
			}
			float rotation9 = proj.rotation;
			int num9 = 1;
			float num10 = Utils.Remap(num6, num4, num8, num6, num8, num9 != 0);
			float num11;
			Microsoft.Xna.Framework.Vector2 vector3 = num11.ToRotationVector2();
			float opacity2 = proj.Opacity;
			Microsoft.Xna.Framework.Graphics.Color color15;
			Microsoft.Xna.Framework.Graphics.Color color14 = color15 * num6;
			int num12 = 1;
			float num13 = Utils.Remap(num6, num4, num11, num4, num11, num12 != 0);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000B69D0 File Offset: 0x000B4BD0
		private void DrawProj_TrueExcalibur(Projectile proj)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float scale = proj.scale;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			Point point;
			float num2 = Lighting.GetColor(point).ToVector3().Length();
			Microsoft.Xna.Framework.Graphics.Color color2;
			float num3;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num3;
			float rotation = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color4;
			float num4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num4 * num3 * num3 * num3;
			float rotation2 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color6;
			Microsoft.Xna.Framework.Graphics.Color color5 = color6 * num3 * num3;
			float rotation3 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color7 = color3 * num3 * num3 * num3;
			float rotation4 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color9;
			Microsoft.Xna.Framework.Graphics.Color color8 = color9 * 0f;
			float rotation5 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color11;
			float num5;
			Microsoft.Xna.Framework.Graphics.Color color10 = color11 * num5;
			float rotation6 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color13;
			float num6;
			Microsoft.Xna.Framework.Graphics.Color color12 = color13 * num6;
			float rotation7 = proj.rotation;
			float rotation8 = proj.rotation;
			int num7 = 1;
			float num9;
			float num10;
			float num11;
			float num8 = Utils.Remap(num9, num10, num11, num11, num10, num7 != 0);
			float num12;
			Microsoft.Xna.Framework.Vector2 vector2 = num12.ToRotationVector2();
			float opacity = proj.Opacity;
			int num13 = 1;
			float num14 = Utils.Remap(num12, num10, num12, num10, num10, num13 != 0);
			if (true)
			{
				return;
			}
			float rotation9 = proj.rotation;
			int num15 = 1;
			float num16 = Utils.Remap(num14, num12, num10, num14, num10, num15 != 0);
			float num17;
			Microsoft.Xna.Framework.Vector2 vector3 = num17.ToRotationVector2();
			float opacity2 = proj.Opacity;
			Microsoft.Xna.Framework.Graphics.Color color15;
			Microsoft.Xna.Framework.Graphics.Color color14 = color15 * num14;
			int num18 = 1;
			float num19 = Utils.Remap(num14, num12, num17, num12, num17, num18 != 0);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000B6C68 File Offset: 0x000B4E68
		private void DrawProj_TrueNightsEdge(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			if (num == 0)
			{
			}
			Point point;
			float num2 = Lighting.GetColor(point).ToVector3().Length();
			float num4;
			float num3 = MathHelper.Min(num4, num4);
			int num5 = 1;
			if (num5 == 0)
			{
			}
			int value = num5.m_value;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Graphics.Color color2;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num4;
			Microsoft.Xna.Framework.Graphics.Color color4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num3;
			Microsoft.Xna.Framework.Graphics.Color color5 = color4 * num3;
			float num7;
			float num6 = MathHelper.Lerp(num3, num4, num7);
			float num9;
			float num8 = MathHelper.Lerp(num3, num4, num9);
			float num10 = MathHelper.Lerp(num3, num3, num9);
			float num11 = MathHelper.Lerp(num3, num3, num9);
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			float num12;
			Microsoft.Xna.Framework.Vector2 vector2 = num12.ToRotationVector2();
			int num13 = 17056;
			int num14 = 1;
			float num16;
			float num15 = Utils.Remap(num16, num3, num12, num3, num9, num14 != 0);
			float num17 = MathHelper.Lerp(num9, num3, num15);
			float num18 = MathHelper.Min(num17, num17);
			if (num13 == 0)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color color7;
			float num19;
			Microsoft.Xna.Framework.Graphics.Color color6 = color7 * num19 * num18;
			Microsoft.Xna.Framework.Graphics.Color color8 = color6 * num18;
			if (!true)
			{
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000B6E8C File Offset: 0x000B508C
		private void DrawProj_TerraBlade2(Projectile proj)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float scale = proj.scale;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			Point point;
			float num2 = Lighting.GetColor(point).ToVector3().Length();
			Microsoft.Xna.Framework.Graphics.Color color2;
			float num3;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num3;
			float rotation = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color4;
			float num4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num4 * num3 * num4 * num4;
			float rotation2 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color5 = color * num3 * num3 * num3;
			float rotation3 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color7;
			Microsoft.Xna.Framework.Graphics.Color color6 = color7 * num3 * num3;
			float rotation4 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color9;
			Microsoft.Xna.Framework.Graphics.Color color8 = color9 * num4;
			float rotation5 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color11;
			Microsoft.Xna.Framework.Graphics.Color color10 = color11 * num4;
			float rotation6 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color13;
			Microsoft.Xna.Framework.Graphics.Color color12 = color13 * num4;
			float rotation7 = proj.rotation;
			float rotation8 = proj.rotation;
			int num5 = 1;
			float num7;
			float num8;
			float num6 = Utils.Remap(num3, num7, num8, num8, num8, num5 != 0);
			Microsoft.Xna.Framework.Vector2 vector2 = num7.ToRotationVector2();
			float opacity = proj.Opacity;
			int num9 = 1;
			float num10 = Utils.Remap(num3, num7, num7, num7, num8, num9 != 0);
			if (!true)
			{
			}
			float rotation9 = proj.rotation;
			int num11 = 1;
			float num12 = Utils.Remap(num10, num10, num7, num10, num8, num11 != 0);
			float num13;
			Microsoft.Xna.Framework.Vector2 vector3 = num13.ToRotationVector2();
			float opacity2 = proj.Opacity;
			Microsoft.Xna.Framework.Graphics.Color color15;
			Microsoft.Xna.Framework.Graphics.Color color14 = color15 * opacity2;
			int num14 = 1;
			float num15 = Utils.Remap(num10, num10, num13, num10, num13, num14 != 0);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000B70E8 File Offset: 0x000B52E8
		private void DrawProj_TerraBlade2Shot(Projectile proj)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float scale = proj.scale;
			if (num == 0)
			{
			}
			float opacity = proj.Opacity;
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			Point point;
			float num2 = Lighting.GetColor(point).ToVector3().Length();
			Microsoft.Xna.Framework.Graphics.Color color2;
			float num3;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * num3;
			float rotation = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num3;
			float rotation2 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color6;
			Microsoft.Xna.Framework.Graphics.Color color5 = color6 * num2 * num2 * num2;
			Microsoft.Xna.Framework.Graphics.Color color7 = color5 * num2;
			float rotation3 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color8 = color5 * num2;
			float rotation4 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color9 = color3 * num2 * num2 * num2;
			float rotation5 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color11;
			Microsoft.Xna.Framework.Graphics.Color color10 = color11 * num3 * num2;
			float rotation6 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color13;
			Microsoft.Xna.Framework.Graphics.Color color12 = color13 * num3 * num2;
			float rotation7 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color15;
			Microsoft.Xna.Framework.Graphics.Color color14 = color15 * num2;
			float rotation8 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color17;
			Microsoft.Xna.Framework.Graphics.Color color16 = color17 * num2;
			float rotation9 = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color19;
			float num4;
			Microsoft.Xna.Framework.Graphics.Color color18 = color19 * num4;
			float rotation10 = proj.rotation;
			float rotation11 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector2 = num2.ToRotationVector2();
			float opacity2 = proj.Opacity;
			Microsoft.Xna.Framework.Graphics.Color color20 = color12 * num2;
			int num5 = 1;
			float num6 = Utils.Remap(num2, 0f, num2, 0f, num2, num5 != 0);
			float rotation12 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector3 = opacity2.ToRotationVector2();
			int num7 = 1;
			float num8 = Utils.Remap(opacity2, num2, num6, num6, num6, num7 != 0);
			float opacity3 = proj.Opacity;
			int num9 = 1;
			float num10 = Utils.Remap(num6, num2, num6, num6, num6, num9 != 0);
			if (!true)
			{
			}
			float opacity4 = proj.Opacity;
			int num11 = 1;
			float num12 = Utils.Remap(num2, num2, num2, num2, num2, num11 != 0);
			if (!true)
			{
			}
			float rotation13 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector4 = num2.ToRotationVector2();
			float opacity5 = proj.Opacity;
			Microsoft.Xna.Framework.Graphics.Color color22;
			Microsoft.Xna.Framework.Graphics.Color color21 = color22 * opacity5;
			int num13 = 1;
			float num14 = Utils.Remap(opacity5, num12, num2, num12, num2, num13 != 0);
			float opacity6 = proj.Opacity;
			Microsoft.Xna.Framework.Graphics.Color color24;
			Microsoft.Xna.Framework.Graphics.Color color23 = color24 * num14;
			int num15 = 1;
			float num16 = Utils.Remap(num14, num2, num12, num14, num12, num15 != 0);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000B748C File Offset: 0x000B568C
		public void DrawProj(int i)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 scaledPosition = Main.Camera.ScaledPosition;
			Microsoft.Xna.Framework.Vector2 scaledPosition2 = Main.Camera.ScaledPosition;
			Microsoft.Xna.Framework.Vector2 scaledSize = Main.Camera.ScaledSize;
			Microsoft.Xna.Framework.Vector2 scaledSize2 = Main.Camera.ScaledSize;
			Rectangle rectangle;
			bool flag = rectangle.Intersects(rectangle);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000B74D4 File Offset: 0x000B56D4
		private void DrawContinuousTrail(Projectile proj)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000B7534 File Offset: 0x000B5734
		private static void DrawTrail(Projectile proj, Microsoft.Xna.Framework.Vector2 rotatableOffsetFromCenter, Microsoft.Xna.Framework.Graphics.Color baseColor)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 size = proj.Size;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2[] oldPos = proj.oldPos;
			float[] oldRot = proj.oldRot;
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 vector;
			float num3 = vector.Length();
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000B75B4 File Offset: 0x000B57B4
		public void DrawProjDirect(Projectile proj, int i = -1)
		{
			int num = 1;
			this.PrepareDrawnProjectileDrawing(proj);
			int type = proj.type;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000BC790 File Offset: 0x000BA990
		private static void DrawProj_Flamethrower(Projectile proj)
		{
			if (!true)
			{
			}
			if (17008 == 0)
			{
			}
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000BC9B4 File Offset: 0x000BABB4
		private static void DrawProj_Spear(Projectile proj, Microsoft.Xna.Framework.Graphics.Color projectileColor, SpriteEffects dir)
		{
			int num = 1;
			float x = proj.velocity.X;
			float y = proj.velocity.Y;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (proj.getRect() == null)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			int direction = proj.direction;
			if (3 == 0)
			{
			}
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000BCB88 File Offset: 0x000BAD88
		private static void DrawPrettyStarSparkle(float opacity, SpriteEffects dir, Microsoft.Xna.Framework.Vector2 drawpos, Microsoft.Xna.Framework.Graphics.Color drawColor, Microsoft.Xna.Framework.Graphics.Color shineColor, float flareCounter, float fadeInStart, float fadeInEnd, float fadeOutStart, float fadeOutEnd, float rotation, Microsoft.Xna.Framework.Vector2 scale, Microsoft.Xna.Framework.Vector2 fatness)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color color2;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * opacity;
			float lerpValue = Utils.GetLerpValue(opacity, flareCounter, fadeInEnd, true);
			float lerpValue2 = Utils.GetLerpValue(lerpValue, flareCounter, fadeInEnd, true);
			Microsoft.Xna.Framework.Graphics.Color color3 = drawColor * lerpValue * lerpValue;
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000BCBDC File Offset: 0x000BADDC
		private static void DrawProj_FlailChains(Projectile proj, Microsoft.Xna.Framework.Vector2 mountedCenter)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x000BCCBC File Offset: 0x000BAEBC
		private static void DrawProj_FlailChains_Old(Projectile proj, Microsoft.Xna.Framework.Vector2 mountedCenter)
		{
			int num = 1;
			int width = proj.width;
			int height = proj.height;
			float x = proj.position.X;
			float y = proj.position.Y;
			long num2 = 0L;
			if (num == 0)
			{
			}
			int alpha = proj.alpha;
			if (alpha == 0)
			{
				int width2 = proj.width;
				float x2 = proj.position.X;
				if (alpha != 0)
				{
					return;
				}
				if (width2 == 0)
				{
				}
				if (alpha == 0)
				{
				}
			}
			if (proj.type == 0)
			{
			}
			if (proj.type == 0)
			{
			}
			int num3 = 63488;
			int num4 = 32768;
			Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(1073741824, (int)num2);
			int type = proj.type;
			if (num4 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (43691 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000BCE3C File Offset: 0x000BB03C
		private static Microsoft.Xna.Framework.Graphics.Color TryApplyingPlayerStringColor(int playerStringColor, Microsoft.Xna.Framework.Graphics.Color stringColor)
		{
			Microsoft.Xna.Framework.Graphics.Color color = WorldGen.paintColor(playerStringColor);
			return 75;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x000BCE5C File Offset: 0x000BB05C
		private static void DrawProj_FishingLine(Projectile proj, float polePosX, float polePosY, Microsoft.Xna.Framework.Vector2 mountedCenter)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x000BD06C File Offset: 0x000BB26C
		private void DrawProj_StardustGuardianPunching(Projectile proj)
		{
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				Microsoft.Xna.Framework.Graphics.Color color2;
				float num;
				Microsoft.Xna.Framework.Graphics.Color color = color2 * num;
				float num2;
				Microsoft.Xna.Framework.Vector2 vector = num2.ToRotationVector2();
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				Microsoft.Xna.Framework.Graphics.Color color4;
				Microsoft.Xna.Framework.Graphics.Color color3 = color4 * num;
			}
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x000BD0D8 File Offset: 0x000BB2D8
		private void DrawProj_PiercingStarlight(Projectile proj)
		{
			if (!true)
			{
			}
			int num = 32640;
			int type = proj.type;
			int num2 = 32768;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			float rotation = proj.rotation;
			if (num == 0)
			{
			}
			float num3;
			Microsoft.Xna.Framework.Vector2 vector = num3.ToRotationVector2();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			if (num2 == 0)
			{
			}
			Point point;
			Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(point);
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			float num5;
			float num6;
			float num7;
			float num4 = MathHelper.Lerp(num5, num6, num7);
			float rotation2 = proj.rotation;
			float num8;
			Microsoft.Xna.Framework.Vector2 vector2 = num8.ToRotationVector2();
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			float rotation3 = proj.rotation;
			if (16968 == 0)
			{
			}
			int num9 = 1;
			float num10;
			float lerpValue = Utils.GetLerpValue(num10, num8, num10, num9 != 0);
			int num11 = 1;
			float lerpValue2 = Utils.GetLerpValue(lerpValue, num8, num10, num11 != 0);
			int num12 = 1;
			float lerpValue3 = Utils.GetLerpValue(lerpValue2, num8, num10, num12 != 0);
			int num13 = 1;
			float lerpValue4 = Utils.GetLerpValue(lerpValue3, num8, num10, num13 != 0);
			float num14 = MathHelper.Lerp(num6, num8, num10);
			float num15;
			Microsoft.Xna.Framework.Vector2 vector3 = num15.ToRotationVector2();
			float num17;
			float num16 = MathHelper.Lerp(num15, num17, num10);
			Microsoft.Xna.Framework.Vector2 vector4 = num10.ToRotationVector2();
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x000BD254 File Offset: 0x000BB454
		private void DrawProj_FairyQueenLance(Projectile proj)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color color = proj.AI_171_GetColor();
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			if (17008 == 0)
			{
			}
			int num2 = 1;
			float num3;
			float num4;
			float lerpValue = Utils.GetLerpValue(num3, num4, num3, num2 != 0);
			float rotation = proj.rotation;
			Microsoft.Xna.Framework.Graphics.Color color3;
			Microsoft.Xna.Framework.Graphics.Color color2 = color3 * lerpValue;
			float rotation2 = proj.rotation;
			Rectangle rectangle2;
			Microsoft.Xna.Framework.Vector2 vector2 = rectangle2.Size();
			int num5 = 1;
			float num6;
			float lerpValue2 = Utils.GetLerpValue(num6, num4, num6, num5 != 0);
			Microsoft.Xna.Framework.Graphics.Color color4 = color3 * lerpValue2;
			int num7 = 1;
			float num8;
			float lerpValue3 = Utils.GetLerpValue(num8, num4, num8, num7 != 0);
			float num9 = MathHelper.Lerp(lerpValue3, num4, lerpValue3);
			long num10 = 0L;
			float num11;
			float lerpValue4 = Utils.GetLerpValue(num4, num4, num11, num10 != 0L);
			int num12 = 1;
			float num13;
			float lerpValue5 = Utils.GetLerpValue(num13, num4, num13, num12 != 0);
			float rotation3 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector3 = num13.ToRotationVector2();
			if (49904 == 0)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color color5 = color * num13 * num13;
			float rotation4 = proj.rotation;
			float rotation5 = proj.rotation;
			float rotation6 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector4 = num13.ToRotationVector2();
			Microsoft.Xna.Framework.Graphics.Color color6 = color * num13;
			float rotation7 = proj.rotation;
			float rotation8 = proj.rotation;
			float rotation9 = proj.rotation;
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x000BD3F0 File Offset: 0x000BB5F0
		private void DrawProj_FairyQueenRangedItemShot(Projectile proj)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float opacity = proj.Opacity;
			float opacity2 = proj.Opacity;
			float rotation = proj.rotation;
			float num2;
			Microsoft.Xna.Framework.Vector2 vector2 = num2.ToRotationVector2();
			Microsoft.Xna.Framework.Graphics.Color color2;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * opacity2;
			Microsoft.Xna.Framework.Graphics.Color color4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * opacity2;
			float rotation2 = proj.rotation;
			float rotation3 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector3 = num2.ToRotationVector2();
			Microsoft.Xna.Framework.Graphics.Color color5 = color2 * opacity2;
			float rotation4 = proj.rotation;
			float rotation5 = proj.rotation;
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x000BD4B4 File Offset: 0x000BB6B4
		private void DrawProj_EmpressBlade(Projectile proj, float hueOverride)
		{
			int num = 1;
			if (num == 0)
			{
			}
			this.PrepareDrawnProjectileDrawing(proj);
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float opacity = proj.Opacity;
			float scale = proj.scale;
			float rotation = proj.rotation;
			float opacity2 = proj.Opacity;
			int num2 = 1;
			float num3;
			float lerpValue = Utils.GetLerpValue(num3, hueOverride, num3, num2 != 0);
			int num4 = 1;
			float num5;
			float lerpValue2 = Utils.GetLerpValue(num5, hueOverride, num5, num4 != 0);
			int num6 = 16948;
			int num7 = 1;
			float num8;
			float lerpValue3 = Utils.GetLerpValue(num8, hueOverride, num8, num7 != 0);
			Microsoft.Xna.Framework.Vector2 vector2 = lerpValue3.ToRotationVector2();
			if (49904 == 0)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color color2;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * lerpValue3;
			Microsoft.Xna.Framework.Graphics.Color color4;
			Microsoft.Xna.Framework.Graphics.Color color3 = color4 * lerpValue3;
			if (num6 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 vector3 = lerpValue3.ToRotationVector2();
			if (num6 == 0)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color color5 = color2 * lerpValue2 * lerpValue2;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x000BD5B8 File Offset: 0x000BB7B8
		private void DrawProj_CoolWhipMinion(Projectile proj)
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			float opacity = proj.Opacity;
			float opacity2 = proj.Opacity;
			long num2 = 0L;
			float x = proj.velocity.X;
			float y = proj.velocity.Y;
			Microsoft.Xna.Framework.Graphics.Color color2;
			Microsoft.Xna.Framework.Graphics.Color color = color2 * opacity2 * opacity2;
			float rotation = proj.rotation;
			float rotation2 = proj.rotation;
			Microsoft.Xna.Framework.Vector2 vector2 = ((float)num2).ToRotationVector2();
			float rotation3 = proj.rotation;
			float rotation4 = proj.rotation;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x000BD668 File Offset: 0x000BB868
		private void DrawMurderAurora(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int timeLeft = proj.timeLeft;
			int timeLeft2 = proj.timeLeft;
			int timeLeft3 = proj.timeLeft;
			int timeLeft4 = proj.timeLeft;
			if (17302 == 0)
			{
			}
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x000BD6F8 File Offset: 0x000BB8F8
		private void DrawWhip(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int type = proj.type;
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x000BD744 File Offset: 0x000BB944
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_BoneWhip(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F0D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_BoneWhip(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stloc:Color(var_12_33, call:Color(Lighting::GetColor, ldloc:Point(var_11)))
	stloc:Vector2(var_13_3A, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_18_48, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x000BD79C File Offset: 0x000BB99C
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_CoolWhip(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F0E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_CoolWhip(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0043:
	stloc:int32(var_21_4C, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x000BD7F8 File Offset: 0x000BB9F8
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_FireWhip(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_FireWhip(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0043:
	stloc:int32(var_21_4C, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x000BD854 File Offset: 0x000BBA54
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_RainbowWhip(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F10)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_RainbowWhip(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007A:
	stloc:int32(var_37_83, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x000BD8E8 File Offset: 0x000BBAE8
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_ThornWhip(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F11)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_ThornWhip(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stloc:Color(var_12_33, call:Color(Lighting::GetColor, ldloc:Point(var_11)))
	stloc:Vector2(var_13_3A, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_18_48, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x000BD940 File Offset: 0x000BBB40
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_WhipSword(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F12)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_WhipSword(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0043:
	stloc:int32(var_20_4C, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000BD99C File Offset: 0x000BBB9C
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_WhipMace(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F13)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_WhipMace(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0050:
	stloc:int32(var_28_59, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x000BDA04 File Offset: 0x000BBC04
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_WhipScythe(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F14)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_WhipScythe(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0050:
	stloc:int32(var_28_59, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000BDA6C File Offset: 0x000BBC6C
		public static Microsoft.Xna.Framework.Vector2 DrawWhip_WhipBland(Projectile proj, List<Microsoft.Xna.Framework.Vector2> controlPoints)
		{
			/*
An exception occurred when decompiling this method (06001F15)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawWhip_WhipBland(Terraria.Projectile,System.Collections.Generic.List`1<Microsoft.Xna.Framework.Vector2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004A:
	stloc:Vector2(var_23_4F, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_28_5D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Vector2>[exp:List`1](controlPoints)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000BDAD8 File Offset: 0x000BBCD8
		private void DrawTwinsPet(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int spriteDirection = proj.spriteDirection;
			int frame = proj.frame;
			if (spriteDirection == 0)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			Point point;
			Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(point);
			bool isAPreviewDummy = proj.isAPreviewDummy;
			if (spriteDirection == 0)
			{
			}
			float scale = proj.scale;
			float rotation = proj.rotation;
			int frame2 = proj.frame;
			float scale2 = proj.scale;
			float rotation2 = proj.rotation;
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x000BDB74 File Offset: 0x000BBD74
		private void DrawMultisegmentPet(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			int type = proj.type;
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x000BDC84 File Offset: 0x000BBE84
		private void DrawKite(Projectile proj)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000BDF0C File Offset: 0x000BC10C
		public static Microsoft.Xna.Framework.Vector2 GetPlayerArmPosition(Projectile proj)
		{
			int num;
			do
			{
				if (!true)
				{
				}
				int direction = proj.direction;
				int width = proj.width;
				if (direction == 0)
				{
				}
				num = 1;
				if (num == 0)
				{
				}
			}
			while (num == 0);
			if (proj.direction == 0)
			{
				return;
			}
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x000BDF5C File Offset: 0x000BC15C
		private void DrawProjWithStarryTrail(Projectile proj, Microsoft.Xna.Framework.Graphics.Color projectileColor, SpriteEffects dir)
		{
			int alpha = proj.alpha;
			if (proj.velocity == null)
			{
			}
			int type = proj.type;
			Microsoft.Xna.Framework.Vector2[] oldPos = proj.oldPos;
			float x = proj.position.X;
			float y = proj.position.Y;
			Microsoft.Xna.Framework.Vector2 vector;
			float num = vector.Length();
			if (oldPos == null)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000BE19C File Offset: 0x000BC39C
		private static int TryInteractingWithVoidLens(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				bool gameMenu = Main.gameMenu;
				if (num == 0)
				{
				}
				bool smartCursorIsUsed = Main.SmartCursorIsUsed;
				if (num == 0)
				{
				}
				bool usingGamepad = PlayerInput.UsingGamepad;
				if (num == 0)
				{
				}
				Player localPlayer = Main.LocalPlayer;
				Microsoft.Xna.Framework.Vector2 center = localPlayer.Center;
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 center2 = localPlayer.Center;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
				Rectangle rectangle;
				if (rectangle == null)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				int smartInteractProj = Main.SmartInteractProj;
				bool lastMouseInterface = localPlayer.lastMouseInterface;
				if (num2 == 0)
				{
				}
				int num3 = 1;
				int num4 = 2;
				localPlayer.cursorItemIconEnabled = num3 != 0;
				int num5 = 4131;
				localPlayer.noThrow = num4;
				localPlayer.cursorItemIconID = num5;
				if (num5 == 0)
				{
				}
				bool usingGamepad2 = PlayerInput.UsingGamepad;
				localPlayer.GamepadEnableGrappleCooldown();
				if (num5 == 0)
				{
				}
				bool mouseRight = Main.mouseRight;
				if (num5 == 0)
				{
				}
				bool mouseRightRelease = Main.mouseRightRelease;
				if (Player.BlockInteractionWithProjectiles == 0)
				{
					Main.mouseRightRelease = false;
					int num6 = localPlayer.chest;
					int num7 = 257;
					localPlayer.tileInteractionHappened = num7 != 0;
					localPlayer.chest = num6;
					if (num6 == 0)
					{
					}
					int disableVoidBag = localPlayer.disableVoidBag;
					localPlayer.chest = disableVoidBag;
					if (disableVoidBag == 0)
					{
					}
					int num8 = 1;
					long num9 = 0L;
					Point point;
					localPlayer.chestX = point;
					localPlayer.SetTalkNPC(num8, num9 != 0L);
					if (disableVoidBag == 0)
					{
					}
					Main.SetNPCShopIndex(0);
					Main.playerInventory = true;
					if (disableVoidBag == 0)
					{
					}
					Recipe.FindRecipes(false);
				}
				bool smartCursorIsUsed2 = Main.SmartCursorIsUsed;
				bool usingGamepad3 = PlayerInput.UsingGamepad;
				return;
			}
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x000BE328 File Offset: 0x000BC528
		private static int TryInteractingWithMoneyTrough(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				bool gameMenu = Main.gameMenu;
				if (num == 0)
				{
				}
				bool smartCursorIsUsed = Main.SmartCursorIsUsed;
				if (num == 0)
				{
				}
				bool usingGamepad = PlayerInput.UsingGamepad;
				if (num == 0)
				{
				}
				Player localPlayer = Main.LocalPlayer;
				Microsoft.Xna.Framework.Vector2 center = localPlayer.Center;
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 center2 = localPlayer.Center;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
				if (num == 0)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				int smartInteractProj = Main.SmartInteractProj;
				bool lastMouseInterface = localPlayer.lastMouseInterface;
				if (num2 == 0)
				{
				}
				int num3 = 1;
				int num4 = 2;
				localPlayer.cursorItemIconEnabled = num3 != 0;
				int num5 = 3213;
				localPlayer.noThrow = num4;
				localPlayer.cursorItemIconID = num5;
				localPlayer.cursorItemIconID = num5;
				if (num5 == 0)
				{
				}
				bool usingGamepad2 = PlayerInput.UsingGamepad;
				localPlayer.GamepadEnableGrappleCooldown();
				if (num5 == 0)
				{
				}
				bool mouseRight = Main.mouseRight;
				if (num5 == 0)
				{
				}
				bool mouseRightRelease = Main.mouseRightRelease;
				if (Player.BlockInteractionWithProjectiles == 0)
				{
					Main.mouseRightRelease = false;
					int num6 = localPlayer.chest;
					int num7 = 257;
					localPlayer.tileInteractionHappened = num7 != 0;
					localPlayer.chest = num6;
					if (num6 == 0)
					{
					}
					localPlayer.chest = num6;
					if (num6 == 0)
					{
					}
					int num8 = 1;
					long num9 = 0L;
					Point point;
					localPlayer.chestX = point;
					localPlayer.SetTalkNPC(num8, num9 != 0L);
					if (num6 == 0)
					{
					}
					Main.SetNPCShopIndex(0);
					int num10 = 1;
					Main.playerInventory = num10 != 0;
					int num11 = 1;
					Main.PlayInteractiveProjectileOpenCloseSound(num10, num11 != 0);
					Recipe.FindRecipes(false);
				}
				bool smartCursorIsUsed2 = Main.SmartCursorIsUsed;
				bool usingGamepad3 = PlayerInput.UsingGamepad;
				return;
			}
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x000BE4C0 File Offset: 0x000BC6C0
		public static void PlayInteractiveProjectileOpenCloseSound(int projType, bool open)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x000BE4D8 File Offset: 0x000BC6D8
		public static void PrintTimedMessage(string message, params object[] arguments)
		{
			if (!true)
			{
			}
			string text = string.Format(message, arguments);
			if (32768 == 0)
			{
			}
			string text2;
			Console.WriteLine(text2);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x000BE500 File Offset: 0x000BC700
		private static void TryInteractingWithMoneyTrough2(Projectile proj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				bool gameMenu = Main.gameMenu;
			}
			float x = proj.position.X;
			float y = proj.position.Y;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			int mouseX = Main.mouseX;
			if (num == 0)
			{
			}
			int mouseX2 = Main.mouseX;
			int width = proj.width;
			if (num == 0)
			{
			}
			int mouseY = Main.mouseY;
			if (num == 0)
			{
			}
			int mouseY2 = Main.mouseY;
			int height = proj.height;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			Microsoft.Xna.Framework.Vector2 center = proj.Center;
			Microsoft.Xna.Framework.Vector2 center2 = proj.Center;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x000BE67C File Offset: 0x000BC87C
		public void PrepareDrawnProjectileDrawing(Projectile proj)
		{
			if (!true)
			{
			}
			int projectileDesiredShader = Main.GetProjectileDesiredShader(proj);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x000BE694 File Offset: 0x000BC894
		public void PrepareDrawnEntityDrawing(Entity entity, int intendedShader)
		{
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if (intendedShader != 0)
			{
				if (!true)
				{
				}
				SamplerState defaultSamplerState = Main.DefaultSamplerState;
				Matrix transform = Main.Transform;
				return;
			}
			if (!true)
			{
			}
			SamplerState defaultSamplerState2 = Main.DefaultSamplerState;
			Matrix transform2 = Main.Transform;
			if (!true)
			{
			}
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x000BE6D0 File Offset: 0x000BC8D0
		public static void EntitySpriteDraw(Microsoft.Xna.Framework.Graphics.Texture2D texture, Microsoft.Xna.Framework.Vector2 position, Rectangle sourceRectangle, Microsoft.Xna.Framework.Graphics.Color color, float rotation, Microsoft.Xna.Framework.Vector2 origin, float scale, SpriteEffects effects, float worthless = 0f)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x000BE6E0 File Offset: 0x000BC8E0
		public static void EntitySpriteDraw(Microsoft.Xna.Framework.Graphics.Texture2D texture, Microsoft.Xna.Framework.Vector2 position, Rectangle sourceRectangle, Microsoft.Xna.Framework.Graphics.Color color, float rotation, Microsoft.Xna.Framework.Vector2 origin, Microsoft.Xna.Framework.Vector2 scale, SpriteEffects effects, float worthless = 0f)
		{
			uint num;
			if (num != 0U)
			{
				if (!true)
				{
				}
				if (32768 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000BE6FC File Offset: 0x000BC8FC
		public static void EntitySpriteDraw(DrawData data)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000BE710 File Offset: 0x000BC910
		public static Microsoft.Xna.Framework.Graphics.Color buffColor(Microsoft.Xna.Framework.Graphics.Color newColor, float R, float G, float B, float A)
		{
			Microsoft.Xna.Framework.Graphics.Color color;
			return color;
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000021DB File Offset: 0x000003DB
		protected void CacheNPCDraws()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000021DB File Offset: 0x000003DB
		protected void CacheProjDraws()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000BE720 File Offset: 0x000BC920
		protected void DrawCachedNPCs(List<int> npcCache, bool behindTiles)
		{
			if (!true)
			{
			}
			int size = npcCache._size;
			int size2 = npcCache._size;
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000BE748 File Offset: 0x000BC948
		protected void DrawCachedProjs(List<int> projCache, bool startSpriteBatch = true)
		{
			if (!true)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			int size = projCache._size;
			int size2 = projCache._size;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000BE77C File Offset: 0x000BC97C
		protected void DrawSuperSpecialProjectiles(List<int> projCache, bool startSpriteBatch = true)
		{
			if (!true)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			int size = projCache._size;
			int num = 32768;
			if (2 == 0)
			{
			}
			Terraria.Graphics.Camera camera = Main.Camera;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000BE7F8 File Offset: 0x000BC9F8
		protected void SortDrawCacheWorms()
		{
			List<int> drawCacheProjsOverPlayers = this.DrawCacheProjsOverPlayers;
			this.SortBabyBirdProjectiles(drawCacheProjsOverPlayers);
			List<int> drawCacheProjsBehindProjectiles = this.DrawCacheProjsBehindProjectiles;
			this.SortStardustDragonProjectiles(drawCacheProjsBehindProjectiles);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000BE824 File Offset: 0x000BCA24
		private void SortBabyBirdProjectiles(List<int> list)
		{
			int size = list._size;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000021DB File Offset: 0x000003DB
		private void SortStardustDragonProjectiles(List<int> list)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000BE83C File Offset: 0x000BCA3C
		protected void DrawWoF()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0 && num == 0)
			{
				if (num == 0)
				{
				}
				Main.DrawWOFTongueToPlayer(int.MinValue);
			}
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x000BE880 File Offset: 0x000BCA80
		private static void DrawWOFBody()
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			long num = -2147483647L;
			if (num == 0L)
			{
			}
			if (num != 0L)
			{
				return;
			}
			if (num == 0L)
			{
				if (num != 0L)
				{
					return;
				}
				if (num == 0L)
				{
				}
			}
			if (43691 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition4 = Main.screenPosition;
			long num2 = 0L;
			Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(1073741824, (int)num2);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x000BE8EC File Offset: 0x000BCAEC
		private static void DrawWOFRopeToTheHungry(int i)
		{
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x000BE934 File Offset: 0x000BCB34
		private static void DrawWOFTongueToPlayer(int i)
		{
			if (!true)
			{
			}
			long num = 0L;
			Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(1073741824, (int)num);
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x000BE968 File Offset: 0x000BCB68
		public static Microsoft.Xna.Framework.Graphics.Color quickAlpha(Microsoft.Xna.Framework.Graphics.Color oldColor, float Alpha)
		{
			Microsoft.Xna.Framework.Graphics.Color color;
			return color;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000BE978 File Offset: 0x000BCB78
		private void DrawItem_GetBasics(Item item, int slot, [Out] Microsoft.Xna.Framework.Graphics.Texture2D texture, [Out] Rectangle frame, [Out] Rectangle glowmaskFrame)
		{
			int num = 1;
			int type = item.type;
			if (num == 0)
			{
			}
			int type2 = item.type;
			if (num == 0 && num == 0)
			{
				int type3 = item.type;
			}
			int type4;
			if (num == 0)
			{
				type4 = item.type;
			}
			if (num == 0)
			{
			}
			if (type4 == 0)
			{
			}
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x000BEA54 File Offset: 0x000BCC54
		private void DrawItem_AnimateSlot(int slot, int gameFramesPerSpriteFrame, int spriteFramesAmount)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x000BEA64 File Offset: 0x000BCC64
		protected void DrawItem(Item item, int whoami)
		{
			if (!item.active)
			{
				return;
			}
			bool isAir = item.IsAir;
			bool instanced = item.instanced;
			if (instanced)
			{
				int playerIndexTheItemIsReservedFor = item.playerIndexTheItemIsReservedFor;
				if (!instanced)
				{
				}
				int myPlayer = Main.myPlayer;
			}
			if (!instanced)
			{
			}
			if (!instanced)
			{
			}
			int width = item.width;
			bool wet = item.wet;
			float x = item.position.X;
			float y = item.position.Y;
			if (width == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			float x2 = item.velocity.X;
			bool shimmered = item.shimmered;
			int num = 16256;
			Microsoft.Xna.Framework.Vector2 center = item.Center;
			if (num == 0)
			{
			}
			if (!shimmered)
			{
			}
			Point point;
			Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(point);
			bool shimmered2 = item.shimmered;
			float shimmerTime = item.shimmerTime;
			int num2;
			long num3;
			if (shimmered2)
			{
				num2 = 17279;
				num3 = 16843009L;
				return;
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
				bool isACoin = item.IsACoin;
				int type = item.type;
				return;
			}
			if (num2 == 0)
			{
			}
			if (num3 != 0L)
			{
				int timeSinceItemSpawned = item.timeSinceItemSpawned;
				if (num2 == 0)
				{
				}
				int num4 = 17264;
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				return;
			}
			int num5 = 4143;
			int timeSinceItemSpawned2 = item.timeSinceItemSpawned;
			int num6 = 17264;
			if (num6 == 0)
			{
			}
			if (num5 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			if (num6 == 0)
			{
			}
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x000BEE48 File Offset: 0x000BD048
		public void DrawItems()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x000BEE5C File Offset: 0x000BD05C
		protected void DrawRain()
		{
			int num;
			if (this._active)
			{
				num = 1;
				return;
			}
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			long num2 = 0L;
			if (num == 0)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value = num3.m_value;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			Rain[] rain = Main.rain;
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(1073741824, (int)num2);
				if (1073741824 == 0)
				{
				}
				if (1073741824 == 0)
				{
				}
				if (1073741824 == 0)
				{
				}
				if (1073741824 == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			}
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x000BEEF4 File Offset: 0x000BD0F4
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		protected void DrawDust()
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			int screenWidth3 = Main.screenWidth;
			int screenHeight3 = Main.screenHeight;
			Matrix transform = Main.Transform;
			if (!true)
			{
			}
			if (!true)
			{
			}
			LightMap lightMap;
			int <Height>k__BackingField = lightMap.<Height>k__BackingField;
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector3[] colors = lightMap._colors;
			int num2 = 17279;
			if (colors != null && num2 != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x000BF0C8 File Offset: 0x000BD2C8
		public static void HelpText()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			if (num == 0)
			{
			}
			int myPlayer3 = Main.myPlayer;
			if (num == 0)
			{
			}
			int myPlayer4 = Main.myPlayer;
			string text;
			bool flag = text != "Copper Pickaxe";
			if ("Copper Pickaxe" == null)
			{
			}
			int myPlayer5 = Main.myPlayer;
			if ("Copper Pickaxe" == null)
			{
			}
			int myPlayer6 = Main.myPlayer;
			string text2;
			bool flag2 = text2 != "Copper Axe";
			if ("Copper Axe" == null)
			{
			}
			int myPlayer7 = Main.myPlayer;
			int myPlayer8 = Main.myPlayer;
			if ("Copper Axe" == null)
			{
			}
			int myPlayer9 = Main.myPlayer;
			if ("Copper Axe" == null)
			{
			}
			int myPlayer10 = Main.myPlayer;
			if ("Copper Axe" == null)
			{
			}
			int myPlayer11 = Main.myPlayer;
			if ("Copper Axe" == null)
			{
			}
			int myPlayer12 = Main.myPlayer;
			if ("Copper Axe" == null)
			{
			}
			int myPlayer13 = Main.myPlayer;
			if ("Copper Axe" == null)
			{
			}
			int myPlayer14 = Main.myPlayer;
			if ("Copper Axe" == null)
			{
			}
			int myPlayer15 = Main.myPlayer;
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int myPlayer16 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer17 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer18 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer19 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer20 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer21 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer22 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer23 = Main.myPlayer;
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int myPlayer24 = Main.myPlayer;
			int myPlayer25 = Main.myPlayer;
			int myPlayer26 = Main.myPlayer;
			if (num3 == 0)
			{
			}
			int myPlayer27 = Main.myPlayer;
			if (num3 == 0)
			{
			}
			int myPlayer28 = Main.myPlayer;
			if (num3 == 0)
			{
			}
			int myPlayer29 = Main.myPlayer;
			if (num3 == 0)
			{
			}
			int myPlayer30 = Main.myPlayer;
			if (num3 == 0)
			{
			}
			int myPlayer31 = Main.myPlayer;
			int num4 = 1;
			if (num4 == 0)
			{
			}
			int myPlayer32 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer33 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer34 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer35 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer36 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer37 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer38 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer39 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer40 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer41 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer42 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer43 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer44 = Main.myPlayer;
			if (num4 == 0)
			{
			}
			int myPlayer45 = Main.myPlayer;
			int num5 = 1;
			if (num5 != 0)
			{
				return;
			}
			int myPlayer46 = Main.myPlayer;
			int myPlayer47 = Main.myPlayer;
			int myPlayer48 = Main.myPlayer;
			int myPlayer49 = Main.myPlayer;
			if (num5 == 0)
			{
			}
			int myPlayer50 = Main.myPlayer;
			if (num5 == 0)
			{
			}
			int myPlayer51 = Main.myPlayer;
			if (num5 == 0)
			{
			}
			int myPlayer52 = Main.myPlayer;
			if (num5 == 0)
			{
			}
			int myPlayer53 = Main.myPlayer;
			if (num5 == 0)
			{
			}
			int myPlayer54 = Main.myPlayer;
			int num6 = 4714;
			if (!true)
			{
			}
			if (num6 != 0)
			{
				if (num6 == 0)
				{
				}
				if (num6 == 0 || num6 == 0)
				{
				}
				if (num6 == 0)
				{
				}
				if (num6 != 0)
				{
					return;
				}
				if (num6 == 0)
				{
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					while (num6 != 0)
					{
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 != 0)
					{
						return;
					}
					if (num6 == 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x000BF8EC File Offset: 0x000BDAEC
		private void OpenShop(int shopIndex)
		{
			if (!true)
			{
			}
			Main.playerInventory = true;
			Main.stackSplit = 9999;
			Main.npcChatText = "";
			Main.SetNPCShopIndex(shopIndex);
			int npcShop = Main.npcShop;
			int npcShop2 = Main.npcShop;
			Chest[] array;
			array.SetupShop(npcShop2);
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x000BF934 File Offset: 0x000BDB34
		public static void SetNPCShopIndex(int index)
		{
			if (!true)
			{
			}
			Main.npcShop = index;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x000BF94C File Offset: 0x000BDB4C
		public static void CloseNPCChatOrSign()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			Main.editSign = false;
			int myPlayer2 = Main.myPlayer;
			Main.npcChatCornerItem = 0;
			Main.npcChatText = "";
			int myPlayer3 = Main.myPlayer;
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x000BF988 File Offset: 0x000BDB88
		public static void SubmitSignText()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			string npcChatText = Main.npcChatText;
			Sign.TextSign(int.MinValue, npcChatText);
			Main.editSign = false;
			bool netClient = Main.NetClient;
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x000BF9C8 File Offset: 0x000BDBC8
		private int NPCBannerSorter(int npcIndex1, int npcIndex2)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x000021DB File Offset: 0x000003DB
		protected void DrawNPCHousesInWorld()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x000BF9DC File Offset: 0x000BDBDC
		protected void DrawPlayerChat()
		{
			if (!true)
			{
			}
			if (true)
			{
			}
			bool allowDraw = RightSideHUDAnchorUpdator.AllowDraw;
			TimeLogger.DetailedDrawTime(10);
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x000BFA00 File Offset: 0x000BDC00
		public static bool ShouldPVPDraw
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F41)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_ShouldPVPDraw()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x000BFA10 File Offset: 0x000BDC10
		public static void LockCraftingForThisCraftClickDuration()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x000BFA20 File Offset: 0x000BDC20
		public void DrawMouseOver()
		{
			int num = 1;
			if (num == 0)
			{
			}
			PlayerInput.SetZoom_Unscaled();
			PlayerInput.SetZoom_MouseInWorld();
			if (num == 0)
			{
			}
			int worldMouseX = Main.worldMouseX;
			int worldMouseY = Main.worldMouseY;
			int myPlayer = Main.myPlayer;
			int screenHeight = Main.screenHeight;
			int mouseY = Main.mouseY;
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x000BFCF0 File Offset: 0x000BDEF0
		private void HoverOverNPCs(Rectangle mouseRectangle)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x000BFE94 File Offset: 0x000BE094
		private static bool TryFreeingElderSlime(int npcIndex)
		{
			/*
An exception occurred when decompiling this method (06001F45)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::TryFreeingElderSlime(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	call:void(Recipe::FindRecipes, ldc.i4:bool(0))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x000BFEBC File Offset: 0x000BE0BC
		private static void DrawNPCChatBubble(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x000BFF00 File Offset: 0x000BE100
		public void GUIBarsDraw()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x000BFF1C File Offset: 0x000BE11C
		protected void GUIBarsDrawInner()
		{
			Main.DrawInterface_Resources_ClearBuffs();
			Main.DrawInterface_Resources_Breath();
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x000BFF34 File Offset: 0x000BE134
		public static void DrawInterface_Resources_ClearBuffs()
		{
			if (!true)
			{
			}
			if ("" == null)
			{
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000BFF4C File Offset: 0x000BE14C
		public void DrawInterface_Resources_Buffs()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num2 = 50;
			int myPlayer2 = Main.myPlayer;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x000BFFA8 File Offset: 0x000BE1A8
		public static string GetBuffTooltip(Player player, int buffType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool expertMode = Main.expertMode;
			string text;
			string text2;
			return text + text2 + "%";
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x000BFFF4 File Offset: 0x000BE1F4
		public static bool TryGetBuffTime(int buffSlotOnPlayer, [Out] int buffTimeValue)
		{
			/*
An exception occurred when decompiling this method (06001F4C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::TryGetBuffTime(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0034:
	stloc:int32(var_6_39, callgetter:int32(Main::get_myPlayer))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](buffSlotOnPlayer), ldloc:int64[exp:int32](var_5_2E))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x000C0044 File Offset: 0x000BE244
		public static int DrawBuffIcon(int drawBuffText, int buffSlotOnPlayer, int x, int y)
		{
			/*
An exception occurred when decompiling this method (06001F4D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Main::DrawBuffIcon(System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_008E:
	stloc:bool(var_26_93, callgetter:bool(Main::get_mouseLeft))
	stloc:bool(var_27_9A, callgetter:bool(Main::get_mouseLeftRelease))
	stloc:bool(var_28_A1, callgetter:bool(Main::get_playerInventory))
	stloc:bool(var_29_A8, callgetter:bool(Main::get_playerInventory))
	stloc:int32(var_30_AF, callgetter:int32(Main::get_myPlayer))
	call:void(Main::TryRemovingBuff, ldloc:bool[exp:int32](var_19), ldc.i4:int32(43143168))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x000C0110 File Offset: 0x000BE310
		public static void TryRemovingBuff(int i, int b)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x000C015C File Offset: 0x000BE35C
		public static void TryRemovingBuff_CheckBuffHideMisc(int slot, int buffID)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x000C0198 File Offset: 0x000BE398
		private static void DrawInterface_Resources_Breath()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				int myPlayer3 = Main.myPlayer;
				int myPlayer4 = Main.myPlayer;
				return;
			}
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x000C0304 File Offset: 0x000BE504
		private static void DrawInterface_Resources_GolfPower()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000C0330 File Offset: 0x000BE530
		private static void DrawInterface_GolfBallIndicator()
		{
			if (!true)
			{
			}
			bool flag = Item.IsAGolfingItem(Main.LocalPlayer.HeldItem);
			Projectile lastHitBall = Main.LocalGolfState.GetLastHitBall();
			if (lastHitBall != null)
			{
				bool flag2 = GolfHelper.IsGolfBallResting(lastHitBall);
				Microsoft.Xna.Framework.Vector2 top = lastHitBall.Top;
				Player localPlayer = Main.LocalPlayer;
				float x = localPlayer.position.X;
				float y = localPlayer.position.Y;
				float x2 = lastHitBall.position.X;
				float y2 = lastHitBall.position.Y;
				if (localPlayer == null)
				{
				}
				Microsoft.Xna.Framework.Vector2 vector;
				float num = vector.Length();
				Microsoft.Xna.Framework.Vector2 unscaledSize = Main.Camera.UnscaledSize;
				if (49942 == 0)
				{
				}
				float num2;
				Microsoft.Xna.Framework.Vector2 vector2 = num2.ToRotationVector2();
				Rectangle rectangle;
				Microsoft.Xna.Framework.Vector2 vector3 = rectangle.Size();
				float num3;
				Microsoft.Xna.Framework.Vector2 vector4 = num3.ToRotationVector2();
				float num4 = MathHelper.Lerp(num3, num3, num3);
				float num5 = MathHelper.Lerp(num4, num4, num3);
				return;
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x000C0484 File Offset: 0x000BE684
		protected void GUIHotbarDrawInner()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool playerInventory = Main.playerInventory;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				int myPlayer3 = Main.myPlayer;
				string text;
				if (text != null)
				{
					int myPlayer4 = Main.myPlayer;
					int myPlayer5 = Main.myPlayer;
					string text2;
					bool flag = text2 != "";
					int myPlayer6 = Main.myPlayer;
					int myPlayer7 = Main.myPlayer;
				}
				int myPlayer8 = Main.myPlayer;
				return;
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x000C061C File Offset: 0x000BE81C
		public static void OpenHairWindow()
		{
			if (!true)
			{
			}
			Main.playerInventory = false;
			Main.npcChatText = "";
			Main.oldHairStyle = Main.myPlayer;
			int myPlayer = Main.myPlayer;
			Main.hairWindow = true;
			Main.playerInventory = true;
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x000C0660 File Offset: 0x000BE860
		public static void CancelHairWindow()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool hairWindow = Main.hairWindow;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int oldHairStyle = Main.oldHairStyle;
			int myPlayer2 = Main.myPlayer;
			Microsoft.Xna.Framework.Graphics.Color oldHairColor = Main.oldHairColor;
			Main.hairWindow = false;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
			int myPlayer5 = Main.myPlayer;
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x000C06B8 File Offset: 0x000BE8B8
		public static void BuyHairWindow()
		{
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			Main.hairWindow = false;
			int myPlayer3 = Main.myPlayer;
			Main.npcChatCornerItem = 0;
			int myPlayer4 = Main.myPlayer;
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x000C06F8 File Offset: 0x000BE8F8
		public static int UnlockedMaxHair()
		{
			return 43143168;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000C070C File Offset: 0x000BE90C
		public static void OpenClothesWindow()
		{
			if (!true)
			{
			}
			bool clothesWindow = Main.clothesWindow;
			Main.CancelClothesWindow(false);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000C07B4 File Offset: 0x000BE9B4
		public static void CancelClothesWindow(bool quiet = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool clothesWindow = Main.clothesWindow;
			if (num == 0)
			{
			}
			Main.clothesWindow = false;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			Microsoft.Xna.Framework.Graphics.Color[] oldClothesColor = Main.oldClothesColor;
			int myPlayer2 = Main.myPlayer;
			Microsoft.Xna.Framework.Graphics.Color[] oldClothesColor2 = Main.oldClothesColor;
			int myPlayer3 = Main.myPlayer;
			Microsoft.Xna.Framework.Graphics.Color[] oldClothesColor3 = Main.oldClothesColor;
			int myPlayer4 = Main.myPlayer;
			Microsoft.Xna.Framework.Graphics.Color[] oldClothesColor4 = Main.oldClothesColor;
			int myPlayer5 = Main.myPlayer;
			Microsoft.Xna.Framework.Graphics.Color[] oldClothesColor5 = Main.oldClothesColor;
			int myPlayer6 = Main.myPlayer;
			Microsoft.Xna.Framework.Graphics.Color[] oldClothesColor6 = Main.oldClothesColor;
			Player dresserInterfaceDummy = Main.dresserInterfaceDummy;
			int oldClothesStyle = Main.oldClothesStyle;
			dresserInterfaceDummy.skinVariant = oldClothesStyle;
			Player dresserInterfaceDummy2 = Main.dresserInterfaceDummy;
			int myPlayer7 = Main.myPlayer;
			long num2 = 0L;
			dresserInterfaceDummy2.Male = num2 != 0L;
			int myPlayer8 = Main.myPlayer;
			int skinVariant = Main.dresserInterfaceDummy.skinVariant;
			dresserInterfaceDummy2.skinVariant = skinVariant;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000C087C File Offset: 0x000BEA7C
		public static void SaveClothesWindow()
		{
			if (!true)
			{
			}
			Main.clothesWindow = false;
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x000C0898 File Offset: 0x000BEA98
		private void SetupDrawInterfaceLayers()
		{
			if (this._needToSetupDrawInterfaceLayers)
			{
				return;
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x000C08BC File Offset: 0x000BEABC
		protected void DrawInterface(GameTime gameTime)
		{
			if (!true)
			{
			}
			int type = Main.mouseItem.type;
			if (type == 0)
			{
			}
			if (type == 0)
			{
			}
			bool needToSetupDrawInterfaceLayers = this._needToSetupDrawInterfaceLayers;
			if (needToSetupDrawInterfaceLayers)
			{
				this.SetupDrawInterfaceLayers();
			}
			if (!needToSetupDrawInterfaceLayers)
			{
			}
			PlayerInput.SetZoom_UI();
			List<GameInterfaceLayer> gameInterfaceLayers = this._gameInterfaceLayers;
			if (!needToSetupDrawInterfaceLayers)
			{
			}
			PlayerInput.SetZoom_World();
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000C0920 File Offset: 0x000BEB20
		private static void DrawWallOfCopperShortswords()
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 vector = Main.ScreenSize.ToVector2();
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000C0940 File Offset: 0x000BEB40
		private static void DrawWallOfBoulders()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 vector = Main.ScreenSize.ToVector2();
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x000C0960 File Offset: 0x000BEB60
		private static void DrawInterface_41_InterfaceLogic4()
		{
			if (!true)
			{
			}
			bool mouseRight = Main.mouseRight;
			Main.npcChatRelease = true;
			if (!true)
			{
			}
			Main._MouseOversCanClear = true;
			long num = 0L;
			Main.DrawPendingMouseText(num != 0L);
			Main.cursorOverride = (int)num;
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000C0994 File Offset: 0x000BEB94
		private static void DrawPendingMouseText(bool worldMouse = false)
		{
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000C09A4 File Offset: 0x000BEBA4
		private void DrawInterface_40_InteractItemIcon()
		{
			if (!true)
			{
			}
			bool playerInventory = Main.playerInventory;
			bool hoveringOverAnNPC = Main.HoveringOverAnNPC;
			bool mouseInterface = Main.LocalPlayer.mouseInterface;
			if (mouseInterface)
			{
				return;
			}
			if (!mouseInterface)
			{
			}
			if (Main.mouseItem.type == 0)
			{
			}
			if (Main.mouseItem.stack == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000C0B54 File Offset: 0x000BED54
		private bool TryGetAmmo(Item sourceItem, [Out] Item ammoItem, [Out] Microsoft.Xna.Framework.Graphics.Color ammoColor, [Out] float ammoScale, [Out] Microsoft.Xna.Framework.Vector2 ammoOffset)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 52429;
			ammoColor.A = (byte)num;
			ammoOffset.X = (float)num2;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			int type = sourceItem.type;
			if (sourceItem.GetFlexibleTileWand() != null)
			{
				if (type == 0)
				{
				}
				Player localPlayer = Main.LocalPlayer;
				if (num2 == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				return;
			}
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000C0BA8 File Offset: 0x000BEDA8
		private void DrawInterface_39_MouseOver()
		{
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x000C0BB8 File Offset: 0x000BEDB8
		private void DrawInterface_38_MouseCarriedObject()
		{
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x000C0DE8 File Offset: 0x000BEFE8
		private static void DrawInterface_37_DebugStuff()
		{
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x000C0DF8 File Offset: 0x000BEFF8
		public void DrawWorldCursor(bool magnify = false)
		{
			if (84 == 0)
			{
			}
			int cursorOverride = Main.cursorOverride;
			Microsoft.Xna.Framework.Graphics.Color cursorColor = Main.cursorColor;
			Microsoft.Xna.Framework.Graphics.Color cursorColor2 = Main.cursorColor;
			Microsoft.Xna.Framework.Graphics.Color cursorColor3 = Main.cursorColor;
			Microsoft.Xna.Framework.Graphics.Color cursorColor4 = Main.cursorColor;
			Microsoft.Xna.Framework.Graphics.Color cursorColor5 = Main.cursorColor;
			int cursorOverride2 = Main.cursorOverride;
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x000C1138 File Offset: 0x000BF338
		public static void DrawInterface_FinalUI()
		{
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000C1148 File Offset: 0x000BF348
		public static void DrawInterface_36_Cursor()
		{
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			global::Cursor cursor;
			int num;
			if (cursor == null)
			{
				global::Cursor cursor2;
				float x = cursor2.Position.x;
				float y = cursor2.Position.y;
				num = 32640;
				Main.mouseX = int.MinValue;
				Main.mouseY = int.MinValue;
			}
			if (num == 0)
			{
			}
			Main.FlushBatches();
			if (!true)
			{
			}
			int cursorOverride = Main.cursorOverride;
			Microsoft.Xna.Framework.Graphics.Color cursorColor = Main.cursorColor;
			Microsoft.Xna.Framework.Graphics.Color cursorColor2 = Main.cursorColor;
			Microsoft.Xna.Framework.Graphics.Color cursorColor3 = Main.cursorColor;
			Microsoft.Xna.Framework.Graphics.Color cursorColor4 = Main.cursorColor;
			Microsoft.Xna.Framework.Graphics.Color cursorColor5 = Main.cursorColor;
			int cursorOverride2 = Main.cursorOverride;
			if (-2147483648 == 0)
			{
			}
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000C12AC File Offset: 0x000BF4AC
		private static void DrawInterface_35_YouDied()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
				int myPlayer2 = Main.myPlayer;
				int myPlayer3 = Main.myPlayer;
				int myPlayer4 = Main.myPlayer;
				int screenWidth2 = Main.screenWidth;
				int screenHeight2 = Main.screenHeight;
				int myPlayer5 = Main.myPlayer;
				return;
			}
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000C1344 File Offset: 0x000BF544
		private void DrawInterface_34_PlayerChat()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000C1360 File Offset: 0x000BF560
		private void DrawInterface_33_MouseText()
		{
			if (!true)
			{
			}
			int stack = Main.mouseItem.stack;
			if (stack == 0)
			{
			}
			Item mouseItem = Main.mouseItem;
			if (stack == 0)
			{
			}
			if (stack != 0)
			{
				int type = Main.mouseItem.type;
				if (type == 0)
				{
					if (type == 0)
					{
					}
					int myPlayer = Main.myPlayer;
					bool settingsEnabled_OpaqueBoxBehindTooltips = Main.SettingsEnabled_OpaqueBoxBehindTooltips;
					int rare = Main.rare;
					int mouseX = Main.mouseX;
					int mouseY = Main.mouseY;
					return;
				}
			}
			bool rulerLine = Main.LocalPlayer.rulerLine;
			if (rulerLine)
			{
				if (!rulerLine)
				{
				}
				int[] builderAccStatus = Main.LocalPlayer.builderAccStatus;
				if (builderAccStatus == null)
				{
					if (builderAccStatus == null)
					{
					}
					Player localPlayer = Main.LocalPlayer;
					if (builderAccStatus == null)
					{
					}
					Point rulerLineDisplayValues = Main.rulerLineDisplayValues;
					int num;
					if (num == 0)
					{
					}
					Point rulerLineDisplayValues2 = Main.rulerLineDisplayValues;
					string text2;
					string text3;
					string text = text2 + "x" + text3;
					int worldMouseX = Main.worldMouseX;
					int worldMouseY = Main.worldMouseY;
				}
			}
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000C1428 File Offset: 0x000BF628
		private void DrawInterface_InstrumentMouseText()
		{
			int signHover = Main.signHover;
			Player localPlayer = Main.LocalPlayer;
			int cursorItemIconID = localPlayer.cursorItemIconID;
			int selectedItem = localPlayer.selectedItem;
			if ((localPlayer.rulerLine && localPlayer.builderAccStatus == null) || localPlayer.mouseInterface)
			{
				int num = 3;
				this.instrumentMouseFixHack = (byte)num;
				return;
			}
			byte b = this.instrumentMouseFixHack;
			if (b != 0)
			{
				return;
			}
			if (b == 0)
			{
			}
			Item[] inventory = Main.LocalPlayer.inventory;
			Player localPlayer2 = Main.LocalPlayer;
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000C14EC File Offset: 0x000BF6EC
		private static void DrawInterface_32_GamepadRadialHotbars()
		{
			int type = Main.mouseItem.type;
			if (type == 0)
			{
				if (type == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				bool settingsEnabled_OpaqueBoxBehindTooltips = Main.SettingsEnabled_OpaqueBoxBehindTooltips;
				int rare = Main.rare;
				int mouseX = Main.mouseX;
				int mouseY = Main.mouseY;
				return;
			}
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x000C152C File Offset: 0x000BF72C
		private void DrawInterface_31_BuilderAccToggles()
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000C153C File Offset: 0x000BF73C
		public static void DrawInterface_29_SettingsButton()
		{
			bool flag;
			if (flag)
			{
				int type = Main.mouseItem.type;
				if (type == 0)
				{
					if (type == 0)
					{
					}
					int myPlayer = Main.myPlayer;
					bool settingsEnabled_OpaqueBoxBehindTooltips = Main.SettingsEnabled_OpaqueBoxBehindTooltips;
					int rare = Main.rare;
					int mouseX = Main.mouseX;
					int mouseY = Main.mouseY;
					return;
				}
			}
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x000C1580 File Offset: 0x000BF780
		private void DrawInterface_28_InfoAccs()
		{
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x000C1590 File Offset: 0x000BF790
		private void HackForGamepadInputHell()
		{
			bool showGamepadHints = PlayerInput.SettingsForUI.ShowGamepadHints;
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x000C15A8 File Offset: 0x000BF7A8
		private void DrawInterface_27_Inventory()
		{
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x000C15B8 File Offset: 0x000BF7B8
		private static void DrawInterface_26_InterfaceLogic3()
		{
			if (!true)
			{
			}
			bool playerInventory = Main.playerInventory;
			int myPlayer = Main.myPlayer;
			Main.playerInventory = false;
			bool playerInventory2 = Main.playerInventory;
			int myPlayer2 = Main.myPlayer;
			Main.InGuideCraftMenu = false;
			Main.InReforgeMenu = false;
			Recipe.FindRecipes(false);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x000C15F8 File Offset: 0x000BF7F8
		private void DrawInterface_25_ResourceBars()
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000C160C File Offset: 0x000BF80C
		private static void DrawInterface_24_InterfaceLogic2()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (17264 == 0)
			{
			}
			if (num == 0)
			{
			}
			if (17204 == 0)
			{
			}
			if (num == 0)
			{
			}
			Main.rare = 0;
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x000C1638 File Offset: 0x000BF838
		private void DrawInterface_23_NPCSignsDialog()
		{
			this.GUIChatDraw();
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x000C164C File Offset: 0x000BF84C
		private void DrawInterface_22_DresserWindow()
		{
			if (!true)
			{
			}
			bool clothesWindow = Main.clothesWindow;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x000C1664 File Offset: 0x000BF864
		private void DrawInterface_21_HairWindow()
		{
			if (!true)
			{
			}
			bool hairWindow = Main.hairWindow;
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x000C167C File Offset: 0x000BF87C
		private static void DrawInterface_20_MultiplayerPlayerNames()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x000C1690 File Offset: 0x000BF890
		private static void DrawInterface_19_SignTileBubble()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool signBubble = Main.signBubble;
			if (num == 0)
			{
			}
			int signX = Main.signX;
			int signY = Main.signY;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int signX2 = Main.signX;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x000C1700 File Offset: 0x000BF900
		private static void DrawInterface_18_DiagnoseVideo()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
			if (!false)
			{
				if (num == 0)
				{
				}
				return;
			}
			if ("" == null)
			{
			}
			if ("Background Tiles:" == null)
			{
			}
			float drawTotal = TimeLogger.GetDrawTotal();
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x000C182C File Offset: 0x000BFA2C
		private static void DrawInterface_17_DiagnoseNet()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				INetDiagnosticsUI activeNetDiagnosticsUI = Main.ActiveNetDiagnosticsUI;
				return;
			}
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000C184C File Offset: 0x000BFA4C
		private void DrawInterface_16_MapOrMinimap()
		{
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x000C185C File Offset: 0x000BFA5C
		public int RecommendedEquipmentAreaPushUp
		{
			get
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool pushEquipmentAreaUp = PlayerInput.SettingsForUI.PushEquipmentAreaUp;
				return true.ToInt();
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x000C1888 File Offset: 0x000BFA88
		private static void DrawInterface_15_InvasionProgressBars()
		{
			Main.DrawInvasionProgress();
			BigProgressBarSystem bigBossProgressBar = Main.BigBossProgressBar;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x000C18A4 File Offset: 0x000BFAA4
		private void DrawInterface_14_EntityHealthBars()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				bool usingGamepad = PlayerInput.UsingGamepad;
				Player localPlayer = Main.LocalPlayer;
				Microsoft.Xna.Framework.Vector2 center = localPlayer.Center;
				Microsoft.Xna.Framework.Vector2 center2 = localPlayer.Center;
				return;
			}
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x000C1AEC File Offset: 0x000BFCEC
		private void DrawInterface_Healthbar_Worm(NPC head, int tailID, float scale)
		{
			int whoAmI = head.whoAmI;
			if (head == null)
			{
			}
			bool active = head.active;
			if (!active || !active)
			{
			}
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x000C1B78 File Offset: 0x000BFD78
		private static void DrawInterface_13_AchievementCompletePopups()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x000C1B88 File Offset: 0x000BFD88
		private static bool DrawInterface_12_IngameFancyUI()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool inFancyUI = Main.inFancyUI;
			return true;
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x000C1BA4 File Offset: 0x000BFDA4
		private bool DrawInterface_11_IngameOptionsMenu()
		{
			return true;
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x000C1BB4 File Offset: 0x000BFDB4
		private static bool DrawInterface_8_CheckF11UIHideToggle()
		{
			if (!true)
			{
			}
			Main._MouseOversCanClear = true;
			Main.DrawPendingMouseText(false);
			return true;
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x000C1BD4 File Offset: 0x000BFDD4
		private static bool DrawInterface_10_CheckCaptureManager()
		{
			return true;
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x000C1BE4 File Offset: 0x000BFDE4
		private static void DrawInterface_9_WireSelection()
		{
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				Main.DrawInterface_Resources_GolfPower();
				Main.DrawInterface_GolfBallIndicator();
			}
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x000C1C04 File Offset: 0x000BFE04
		private static void DrawInterface_0_InterfaceLogic1()
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
			if (num == 0)
			{
			}
			Main.mouseLeftRelease = false;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000C1C30 File Offset: 0x000BFE30
		private void DrawInterface_7_TownNPCHouseBanners()
		{
			bool playerInventory = Main.playerInventory;
			this.DrawNPCHousesInWorld();
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x000C1C58 File Offset: 0x000BFE58
		private bool DrawVirtualControls()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000C1C6C File Offset: 0x000BFE6C
		private void DrawInterface_WorldMouse()
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000C1C7C File Offset: 0x000BFE7C
		private void DrawInterface_WorldMouseOver()
		{
			global::Cursor cursor;
			if (cursor != null)
			{
			}
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000C1CC0 File Offset: 0x000BFEC0
		public static void DrawTileGridOption(bool magnify = false)
		{
			Item item;
			bool isAir = item.IsAir;
			int type = item.type;
			int createTile = item.createTile;
			int createWall = item.createWall;
			int hammer = item.hammer;
			int axe = item.axe;
			int pick = item.pick;
			bool mouseShowBuildingGrid = Main.MouseShowBuildingGrid;
			int myPlayer = Main.myPlayer;
			bool cursorIsBusy = PlayerInput.CursorIsBusy;
			float mouseBuildingGridAlpha = Main.MouseBuildingGridAlpha;
			float num;
			Main.MouseBuildingGridAlpha = num;
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x000C1DCC File Offset: 0x000BFFCC
		private static void DrawInterface_6_TileGridOption()
		{
			global::Cursor cursor;
			if (cursor != null)
			{
				Main.DrawTileGridOption(false);
				return;
			}
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x000C1DE4 File Offset: 0x000BFFE4
		private static void DrawInterface_5_GamepadLockOn()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000C1DF4 File Offset: 0x000BFFF4
		private static void DrawInterface_4_Ruler()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				if (num == 0)
				{
					if (num == 0)
					{
					}
					int myPlayer3 = Main.myPlayer;
					return;
				}
			}
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000C1F44 File Offset: 0x000C0144
		private static void DrawInterface_3_LaserRuler()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				if (num == 0)
				{
					if (num == 0)
					{
					}
					int myPlayer3 = Main.myPlayer;
					int myPlayer4 = Main.myPlayer;
					int myPlayer5 = Main.myPlayer;
					Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
					if (49736 == 0)
					{
					}
					Point point;
					Microsoft.Xna.Framework.Vector2 vector = point.ToVector2();
					Microsoft.Xna.Framework.Vector2 mouseWorld = Main.MouseWorld2;
					Microsoft.Xna.Framework.Graphics.Color color2;
					float num2;
					Microsoft.Xna.Framework.Graphics.Color color = color2 * num2 * num2 * num2;
					if (!true)
					{
					}
					if (16 == 0)
					{
					}
					int num3 = 18;
					if (num3 == 0)
					{
					}
					if (num3 == 0)
					{
					}
					Microsoft.Xna.Framework.Vector2 vector3;
					Microsoft.Xna.Framework.Vector2 vector2 = Main.ReverseGravitySupport(vector3, num2);
					Microsoft.Xna.Framework.Vector2 vector5;
					Microsoft.Xna.Framework.Vector2 vector4 = Main.ReverseGravitySupport(vector5, num2);
					return;
				}
			}
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x000C209C File Offset: 0x000C029C
		private static void DrawInterface_2_SmartCursorTargets()
		{
			if (!true)
			{
			}
			Main.DrawSmartCursor();
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000C20B4 File Offset: 0x000C02B4
		private static void DrawInterface_1_1_DrawEmoteBubblesInWorld()
		{
			if (!true)
			{
			}
			int num;
			Main.DrawNPCChatBubble(num);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000C20CC File Offset: 0x000C02CC
		private static void DrawInterface_1_2_DrawEntityMarkersInWorld()
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			if (!localPlayer.dead)
			{
				bool summon = localPlayer.HeldItem.summon;
				if (summon)
				{
					if (!summon)
					{
					}
					if (!true)
					{
					}
					int num = 1;
					if (num == 0)
					{
					}
					int minionAttackTargetNPC = localPlayer.MinionAttackTargetNPC;
					int value = num.m_value;
					if (num == 0)
					{
					}
					Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
					Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
					int myPlayer = Main.myPlayer;
					int screenHeight = Main.screenHeight;
					int num2 = 32640;
					if (num2 == 0)
					{
					}
					Rectangle rectangle;
					Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
					if (num2 == 0)
					{
					}
				}
			}
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000C215C File Offset: 0x000C035C
		private static void MouseOversTryToClear()
		{
			if (!true)
			{
			}
			bool mouseOversCanClear = Main._MouseOversCanClear;
			if (!true)
			{
			}
			Main._MouseOversCanClear = false;
			Main.MouseOversClear();
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000C2184 File Offset: 0x000C0384
		private static void MouseOversClear()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
			int myPlayer5 = Main.myPlayer;
			int signHover = Main.signHover;
			Main.lastSignHover = signHover;
			Main.signHover = signHover;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000C21C8 File Offset: 0x000C03C8
		public static void ItemIconCacheUpdate(int selectedItemID)
		{
			if (!true)
			{
			}
			Main._itemIconCacheScreenPosition = Main.MouseScreen;
			Main._itemIconCacheSelectedItemID = selectedItemID;
			Main._itemIconCacheTime = 10;
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000C21F0 File Offset: 0x000C03F0
		public static void ItemIconCacheVerification()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int itemIconCacheTime = Main._itemIconCacheTime;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 itemIconCacheScreenPosition = Main._itemIconCacheScreenPosition;
			Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Main._itemIconCacheTime = Main._itemIconCacheTime;
			if (num == 0)
			{
			}
			Main._itemIconCacheTime = 0;
			if (num == 0)
			{
			}
			int itemIconCacheSelectedItemID = Main._itemIconCacheSelectedItemID;
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000C2254 File Offset: 0x000C0454
		public static void DrawWallOfFish()
		{
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000C22A4 File Offset: 0x000C04A4
		public static void DrawWallOfStars()
		{
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			if (!true)
			{
			}
			IEntitySource noneSource = Projectile.GetNoneSource();
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x000C2314 File Offset: 0x000C0514
		private static void DrawSmartCursor()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool smartCursorShowing = Main.SmartCursorShowing;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int smartCursorX = Main.SmartCursorX;
				int smartCursorY = Main.SmartCursorY;
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				int screenHeight = Main.screenHeight;
				int smartCursorX2 = Main.SmartCursorX;
				int smartCursorY2 = Main.SmartCursorY;
				Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(smartCursorX2, smartCursorY2);
				int num2 = 1;
				if (num2 == 0)
				{
				}
				int value = num2.m_value;
				if (!true)
				{
				}
				int num3 = 1;
				if (num3 == 0)
				{
				}
				int value2 = num3.m_value;
				if (!true)
				{
				}
				int num4 = 1;
				if (num4 == 0)
				{
				}
				int value3 = num4.m_value;
				if (!true)
				{
				}
				int num5 = 1;
				if (num5 == 0)
				{
				}
				int value4 = num5.m_value;
				if (!true)
				{
				}
				int num6 = 1;
				if (num6 == 0)
				{
				}
				int value5 = num6.m_value;
				if (!true)
				{
				}
				int num7 = 1;
				if (num7 == 0)
				{
				}
				int value6 = num7.m_value;
				if (!true)
				{
				}
				int num8 = 1;
				if (num8 == 0)
				{
				}
				int value7 = num8.m_value;
				if (!true)
				{
				}
				int num9 = 1;
				if (num9 == 0)
				{
				}
				int value8 = num9.m_value;
			}
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x000C2468 File Offset: 0x000C0668
		private static void DrawSmartInteract()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool smartInteractShowingGenuine = Main.SmartInteractShowingGenuine;
			if (num == 0)
			{
			}
			int smartInteractNPC = Main.SmartInteractNPC;
			if (num == 0)
			{
			}
			int smartInteractProj = Main.SmartInteractProj;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int smartInteractX = Main.SmartInteractX;
				int smartInteractY = Main.SmartInteractY;
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				int myPlayer2 = Main.myPlayer;
				int screenHeight = Main.screenHeight;
				int smartInteractX2 = Main.SmartInteractX;
				int smartInteractY2 = Main.SmartInteractY;
				Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(smartInteractX2, smartInteractY2);
				int num2 = 1;
				if (num2 == 0)
				{
				}
				int value = num2.m_value;
				if (!true)
				{
				}
				int num3 = 1;
				if (num3 == 0)
				{
				}
				int value2 = num3.m_value;
				if (!true)
				{
				}
				int num4 = 1;
				if (num4 == 0)
				{
				}
				int value3 = num4.m_value;
				if (!true)
				{
				}
				int num5 = 1;
				if (num5 == 0)
				{
				}
				int value4 = num5.m_value;
				if (!true)
				{
				}
				int num6 = 1;
				if (num6 == 0)
				{
				}
				int value5 = num6.m_value;
				if (!true)
				{
				}
				int num7 = 1;
				if (num7 == 0)
				{
				}
				int value6 = num7.m_value;
				if (!true)
				{
				}
				int num8 = 1;
				if (num8 == 0)
				{
				}
				int value7 = num8.m_value;
				if (!true)
				{
				}
				int num9 = 1;
				if (num9 == 0)
				{
				}
				int value8 = num9.m_value;
			}
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x000C25B8 File Offset: 0x000C07B8
		private void DrawInterface_30_Hotbar()
		{
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000C25D0 File Offset: 0x000C07D0
		public void GUIChatDraw()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag = Main.npcChatText != "";
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			bool editChest = Main.editChest;
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x000C2638 File Offset: 0x000C0838
		public static bool ShouldDrawInfoIconsHorizontally
		{
			get
			{
				if (!true)
				{
				}
				if (true)
				{
				}
				if (!true)
				{
				}
				int mapStyle = Main.mapStyle;
				if (!true)
				{
				}
				bool mapEnabled = Main.mapEnabled;
				if (!true)
				{
				}
				int screenHeight = Main.screenHeight;
				if (!true)
				{
				}
				int mapStyle2 = Main.mapStyle;
				if (!true)
				{
				}
				int screenWidth = Main.screenWidth;
				return PlayerInput.UsingGamepad;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x000C2684 File Offset: 0x000C0884
		public static bool CanShowInfoAccs
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001FA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_CanShowInfoAccs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002B:
	stloc:int32(var_3_30, callgetter:int32(Main::get_myPlayer))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x000C26C4 File Offset: 0x000C08C4
		public static void DrawItemIcon(SpriteBatch spriteBatch, Item theItem, Microsoft.Xna.Framework.Vector2 screenPositionForItemCenter, Microsoft.Xna.Framework.Graphics.Color itemLightColor, float sizeLimit)
		{
			int type = theItem.type;
			if (!true)
			{
			}
			float scale = theItem.scale;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color color = theItem.color;
			if (!true)
			{
			}
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000C26FC File Offset: 0x000C08FC
		public static void CheckInvasionProgressDisplay()
		{
			if (!true)
			{
			}
			int invasionProgressMode = Main.invasionProgressMode;
			int myPlayer = Main.myPlayer;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000C27FC File Offset: 0x000C09FC
		public static void SyncAnInvasion(int toWho)
		{
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x000C2850 File Offset: 0x000C0A50
		public static void ReportInvasionProgress(int progress, int progressMax, int icon, int progressWave)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x000C2870 File Offset: 0x000C0A70
		public static void DrawInvasionProgress()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int invasionProgressMode = Main.invasionProgressMode;
			if (num == 0)
			{
			}
			bool invasionProgressNearInvasion = Main.invasionProgressNearInvasion;
			if (num == 0)
			{
			}
			int num2 = 160;
			if (num2 != 0 || num2 == 0)
			{
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x000C2914 File Offset: 0x000C0B14
		protected void QuitGame()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = Main.SaveSettings();
			if (num == 0)
			{
				SocialAPI.Shutdown();
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x000C293C File Offset: 0x000C0B3C
		public static Microsoft.Xna.Framework.Graphics.Color randColor()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000C2968 File Offset: 0x000C0B68
		public static Microsoft.Xna.Framework.Graphics.Color hslToRgb(Microsoft.Xna.Framework.Vector3 hslVector)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000C297C File Offset: 0x000C0B7C
		public static Microsoft.Xna.Framework.Graphics.Color hslToRgb(float Hue, float Saturation, float Luminosity, byte a = 255)
		{
			/*
An exception occurred when decompiling this method (06001FA9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Main::hslToRgb(System.Single,System.Single,System.Single,System.Byte)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float64(var_0_13, call:float64(Main::hue2rgb, ldloc:float32[exp:float64](Luminosity), ldc.r8:float64(0.3333333333333333), ldloc:float32[exp:float64](Saturation)))
	stloc:float64(var_1_24, call:float64(Main::hue2rgb, ldloc:float32[exp:float64](Hue), ldc.r8:float64(0.3333333333333333), ldloc:float32[exp:float64](Saturation)))
	stloc:float64(var_2_3D, call:float64(Main::hue2rgb, ldc.r8:float64(-0.3333333333333333), ldc.r8:float64(0.3333333333333333), ldloc:float32[exp:float64](Saturation)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000C29C8 File Offset: 0x000C0BC8
		public static void hslToRgb(Microsoft.Xna.Framework.Graphics.Color color, float Hue, float Saturation, float Luminosity, byte a = 255)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x000021DB File Offset: 0x000003DB
		public static double hue2rgb(double c, double t1, double t2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x000C2A28 File Offset: 0x000C0C28
		public static Microsoft.Xna.Framework.Vector3 rgbToHsl(Microsoft.Xna.Framework.Graphics.Color newColor)
		{
			return 17279;
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x000C2A4C File Offset: 0x000C0C4C
		public static bool HasHWCursor
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001FAD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::get_HasHWCursor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DrPlatformType(var_3_09, callgetter:DrPlatformType(DrPlatform::get_CurrentPlatform))
	stloc:bool(var_5_17, ldfld:bool(iOS_Mouse::UseSWCursor, callgetter:iOS_Mouse(IOS::get_Mouse)))
	stloc:DrPlatformType(var_7_21, callgetter:DrPlatformType(DrPlatform::get_CurrentPlatform))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x000C2A7C File Offset: 0x000C0C7C
		public static void DrawCursor(Microsoft.Xna.Framework.Vector2 bonus, bool smart = false)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			Main.ClearSmartInteract();
			Main.TileInteractionHY = int.MinValue;
			Main.TileInteractionLY = int.MinValue;
			Main.TileInteractionHX = int.MinValue;
			Main.TileInteractionLX = int.MinValue;
			if (-2147483648 == 0)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color cursorColor = Main.cursorColor;
			bool gameMenu2 = Main.gameMenu;
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000C2C70 File Offset: 0x000C0E70
		public static void ClearSmartInteract()
		{
			if (!true)
			{
			}
			Main.SmartInteractShowingGenuine = false;
			long num = 0L;
			Main.SmartInteractShowingFake = num != 0L;
			Main.SmartInteractNPC = (int)num;
			Main.SmartInteractProj = (int)num;
			Dictionary<int, bool> smartInteractTileCoords = Main.SmartInteractTileCoords;
			Dictionary<int, bool> smartInteractTileCoordsSelected = Main.SmartInteractTileCoordsSelected;
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x000C2CA8 File Offset: 0x000C0EA8
		public static Microsoft.Xna.Framework.Vector2 DrawThickCursor(bool smart = false)
		{
			/*
An exception occurred when decompiling this method (06001FB0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Main::DrawThickCursor(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00AE:
	stloc:Vector2(var_27_B5, call:Vector2(Utils::Size, ldloc:Rectangle(var_26)))
	stloc:float32(var_30_BF, callgetter:float32(Main::get_GamepadCursorAlpha))
	stloc:int32(var_36_CD, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_37_D4, callgetter:int32(Main::get_mouseY))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x000C2D90 File Offset: 0x000C0F90
		private void OnCharacterNamed(string text)
		{
			if (!true)
			{
			}
			Player pendingPlayer = Main.PendingPlayer;
			string text2 = text.Trim();
			pendingPlayer.name = text2;
			PlayerFileData playerFileData = PlayerFileData.CreateAndSave(Main.PendingPlayer);
			Main.LoadPlayers();
			Main.menuMode = 1;
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x000C2DCC File Offset: 0x000C0FCC
		private void OnSeedSelected(string text)
		{
			int stringLength = text.Trim()._stringLength;
			if (!true)
			{
			}
			if (stringLength != 0)
			{
				return;
			}
			if (!true)
			{
			}
			Main.menuMode = 10;
			if (!true)
			{
			}
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000C2DFC File Offset: 0x000C0FFC
		private void OnWorldNamed(string text)
		{
			if (!true)
			{
			}
			Main.menuMode = 10;
			string text2 = text.Trim();
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x000C2E38 File Offset: 0x000C1038
		public static Point ScreenSize
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001FB4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.Main::get_ScreenSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_08, callgetter:int32(Main::get_screenWidth))
	stloc:int32(var_1_0E, callgetter:int32(Main::get_screenHeight))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x000C2E54 File Offset: 0x000C1054
		public static void GoToWorldSelect()
		{
			if (!true)
			{
			}
			Main.menuMode = 888;
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x000C2E70 File Offset: 0x000C1070
		public static void StartClientGameplay()
		{
			if (!true)
			{
			}
			Main.menuMode = 10;
			if (!true)
			{
			}
			Netplay.StartTcpClient(false);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x000C2E90 File Offset: 0x000C1090
		public static void ReleaseHostAndPlayProcess()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x000C2EA0 File Offset: 0x000C10A0
		private string SanitizePathArgument(string argumentName, string argumentPath)
		{
			if (!true)
			{
			}
			string text = Regex.Replace(Regex.Replace(argumentPath, "(\\\\*)\"", "$1$1\\\""), "(\\\\+)$", "$1$1");
			string text2 = "\"" + text + "\"";
			return " -" + argumentName + " " + text2;
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x000C2EF4 File Offset: 0x000C10F4
		protected void DrawMenu(GameTime gameTime)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int menuMode = Main.menuMode;
			int menuMode2 = Main.menuMode;
			Main.StopSlimeRain(true);
			Main.AnimateTiles_CritterCages();
			Main.render = false;
			Main.SceneMetrics.Reset();
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000C30E8 File Offset: 0x000C12E8
		private static void DrawVersionNumber(Microsoft.Xna.Framework.Graphics.Color menuColor, float upBump)
		{
			if (!true)
			{
			}
			if (2 == 0)
			{
			}
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x000C3104 File Offset: 0x000C1304
		public static void ClearVisualPostProcessEffects()
		{
			!0 !;
			if (! == null || "Solar" == null)
			{
			}
			!0 !2;
			if (!2 != null)
			{
			}
			!0 !3;
			if (!3 != null)
			{
			}
			if ("BloodMoon" == null)
			{
			}
			if ("Graveyard" == null)
			{
			}
			if ("Sepia" == null)
			{
			}
			if ("BloodMoon" == null)
			{
			}
			BirthdayParty.WorldClear();
			LanternNight.WorldClear();
			Sandstorm.WorldClear();
			CreditsRollEvent.Reset();
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x000C3164 File Offset: 0x000C1364
		private static void PostDrawMenu(Point screenSizeCache, Point screenSizeCacheAfterScaling)
		{
			if (!true)
			{
			}
			bool flag = Main.ScreenSize == screenSizeCacheAfterScaling;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x000C3190 File Offset: 0x000C1390
		private void PreDrawMenu([Out] Point screenSizeCache, [Out] Point screenSizeCacheAfterScaling)
		{
			if (!true)
			{
			}
			int screenHeight = Main.screenHeight;
			bool settingDontScaleMainMenuUp = Main.SettingDontScaleMainMenuUp;
			Point screenSize = Main.ScreenSize;
			screenSizeCache.X = screenSize;
			PlayerInput.SetZoom_UI();
			Point screenSize2 = Main.ScreenSize;
			screenSizeCacheAfterScaling.X = screenSize2;
			bool needsMenuUIRecalculation = this._needsMenuUIRecalculation;
			if (!needsMenuUIRecalculation || !needsMenuUIRecalculation)
			{
			}
			if (!needsMenuUIRecalculation)
			{
			}
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x000C31E4 File Offset: 0x000C13E4
		private static bool IsBorderlessDisplayAvailable()
		{
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000C31F4 File Offset: 0x000C13F4
		private static void CycleClothingStyle(Player plr)
		{
			if (!true)
			{
			}
			Main.CycleClothingStyle_Inner(plr);
			if (!true)
			{
			}
			int skinVariant = plr.skinVariant;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x000021DB File Offset: 0x000003DB
		private static bool IsValidPlayerStyle(Player plr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000C3214 File Offset: 0x000C1414
		private static void CycleClothingStyle_Inner(Player plr)
		{
			bool male = plr.Male;
			int skinVariant = plr.skinVariant;
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x000C3240 File Offset: 0x000C1440
		public static void ResetKeyBindings()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000C3250 File Offset: 0x000C1450
		public static void CursorColor()
		{
			if (!true)
			{
			}
			float cursorAlpha = Main.cursorAlpha;
			int cursorColorDirection = Main.cursorColorDirection;
			Main.cursorAlpha = cursorAlpha;
			Main.cursorAlpha = Main.cursorAlpha;
			Main.cursorColorDirection = int.MinValue;
			Main.cursorAlpha = Main.cursorAlpha;
			Main.cursorColorDirection = 1;
			float cursorAlpha2 = Main.cursorAlpha;
			Microsoft.Xna.Framework.Graphics.Color mouseColor = Main.mouseColor;
			float cursorAlpha3 = Main.cursorAlpha;
			Microsoft.Xna.Framework.Graphics.Color mouseColor2 = Main.mouseColor;
			float cursorAlpha4 = Main.cursorAlpha;
			Microsoft.Xna.Framework.Graphics.Color mouseColor3 = Main.mouseColor;
			float cursorAlpha5 = Main.cursorAlpha;
			Main.cursorColor = mouseColor3;
			Main.cursorScale = Main.cursorAlpha;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x000C32D8 File Offset: 0x000C14D8
		private void UnloadSplashScreenTextures()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000C32E8 File Offset: 0x000C14E8
		protected void DrawSplash(GameTime gameTime)
		{
			GraphicsDevice graphicsDevice = base.GraphicsDevice;
			base.Draw(gameTime);
			this.TickLoadProcess();
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000C3438 File Offset: 0x000C1638
		private void DrawSplash_LoadingFlower(Microsoft.Xna.Framework.Graphics.Color splashColor)
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			if (16968 == 0)
			{
			}
			float splashFrameCount = this._splashFrameCount;
			int num = 32640;
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x000C3498 File Offset: 0x000C1698
		private void DrawSplash_LoadingStar(Microsoft.Xna.Framework.Graphics.Color splashColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			float splashFrameCount = this._splashFrameCount;
			int num2 = 32640;
			int num3 = 32768;
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			long num4 = 0L;
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			if (num4 == 0L)
			{
			}
			if (num4 == 0L)
			{
			}
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x000C34F0 File Offset: 0x000C16F0
		protected void DrawUnderworldBackground(bool flat)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			if (screenHeight == 0)
			{
			}
			if (screenHeight == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			if (screenHeight == 0)
			{
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000C3538 File Offset: 0x000C1738
		private static void DrawUnderworldBackgroudLayer(bool flat, Microsoft.Xna.Framework.Vector2 screenOffset, float pushUp, int layerTextureIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x000C367C File Offset: 0x000C187C
		private void ProcessBatchFinished(int index)
		{
			TileDrawing tileDrawing = this._threadManager.DrawThreads.tileDrawing;
			double treeWindCounter = tileDrawing._treeWindCounter;
			double treeWindCounter2 = tileDrawing._treeWindCounter;
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000C36A8 File Offset: 0x000C18A8
		private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001FCB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ThreadedRenderManager/BatchProcessCallback Terraria.Main::get_ProcessBatchFinishedCallback()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:BatchProcessCallback[exp:bool](Main::_processBatchFinishedCallback, ldloc:Main(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x000C36BC File Offset: 0x000C18BC
		private void WaitBackgroundDrawThreads(int numberOfThreads)
		{
			if (!true)
			{
			}
			ThreadedRenderManager threadManager = this._threadManager;
			ThreadedRenderManager.BatchProcessCallback processBatchFinishedCallback = this.ProcessBatchFinishedCallback;
			threadManager.WaitAndProcess(processBatchFinishedCallback, numberOfThreads);
			Matrix transform = Main.Transform;
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x000C36E8 File Offset: 0x000C18E8
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void DrawCurrentBackground(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			SpriteBatch backgroundSpriteBatch = this._currentBackgroundDrawInfo.Value.backgroundSpriteBatch;
			Main.BackgroundDrawInfo value = this._currentBackgroundDrawInfo.Value;
			Main.BackgroundDrawInfo value2 = this._currentBackgroundDrawInfo.Value;
			Microsoft.Xna.Framework.Graphics.Texture2D[] array;
			object <Tag>k__BackingField = array.<Tag>k__BackingField;
			Microsoft.Xna.Framework.Graphics.Texture2D[] array2;
			object <Tag>k__BackingField2 = array2.<Tag>k__BackingField;
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num2 = 255;
			value2.bgColors = num2;
			value2.bgColors.TopRightColor = num2;
			value2.bgColors.BottomLeftColor = num2;
			value2.bgColors.BottomRightColor = num2;
			bool notRetro = Lighting.NotRetro;
			float ugBackTransition = Main.ugBackTransition;
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x000C38F0 File Offset: 0x000C1AF0
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void DrawMagmaLayer(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			for (;;)
			{
				SpriteBatch backgroundSpriteBatch = this._currentBackgroundDrawInfo.Value.backgroundSpriteBatch;
				Main.BackgroundDrawInfo value = this._currentBackgroundDrawInfo.Value;
				Main.BackgroundDrawInfo value2 = this._currentBackgroundDrawInfo.Value;
				float gfxQuality = Main.gfxQuality;
				float gfxQuality2 = Main.gfxQuality;
				float gfxQuality3 = Main.gfxQuality;
				float gfxQuality4 = Main.gfxQuality;
				if (!true)
				{
				}
				Microsoft.Xna.Framework.Graphics.Texture2D[] array;
				int height = array.Height;
				float ugBackTransition = Main.ugBackTransition;
				if (height == 0)
				{
				}
				bool notRetro = Lighting.NotRetro;
				bool flag = Main.ShouldShowInvisibleWalls();
				LightMap lightMap;
				Microsoft.Xna.Framework.Vector3[] colors = lightMap._colors;
				if (colors != null)
				{
					break;
				}
				if (colors == null)
				{
				}
				int <Height>k__BackingField = lightMap.<Height>k__BackingField;
				if (!true)
				{
				}
				if (<Height>k__BackingField == 0)
				{
				}
				if (!true)
				{
					goto Block_1;
				}
			}
			return;
			Block_1:
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (17279 == 0)
			{
			}
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x000C3AD0 File Offset: 0x000C1CD0
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void DrawRockLayer(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			SpriteBatch backgroundSpriteBatch = this._currentBackgroundDrawInfo.Value.backgroundSpriteBatch;
			Main.BackgroundDrawInfo value = this._currentBackgroundDrawInfo.Value;
			Main.BackgroundDrawInfo value2 = this._currentBackgroundDrawInfo.Value;
			float gfxQuality = Main.gfxQuality;
			float gfxQuality2 = Main.gfxQuality;
			float gfxQuality3 = Main.gfxQuality;
			float gfxQuality4 = Main.gfxQuality;
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Graphics.Texture2D[] array;
			int sortingKey = array._sortingKey;
			Microsoft.Xna.Framework.Graphics.Texture2D[] array2;
			int sortingKey2 = array2._sortingKey;
			int num = 255;
			value2.bgColors = num;
			value2.bgColors.TopRightColor = num;
			value2.bgColors.BottomLeftColor = num;
			value2.bgColors.BottomRightColor = num;
			float ugBackTransition = Main.ugBackTransition;
			if (num == 0)
			{
			}
			bool notRetro = Lighting.NotRetro;
			if (num == 0)
			{
			}
			bool flag = Main.ShouldShowInvisibleWalls();
			LightMap lightMap;
			Microsoft.Xna.Framework.Vector3[] colors = lightMap._colors;
			if (colors != null)
			{
				return;
			}
			if (colors == null)
			{
			}
			int <Height>k__BackingField = lightMap.<Height>k__BackingField;
			if (!true)
			{
			}
			if (<Height>k__BackingField == 0)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x000021DB File Offset: 0x000003DB
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		protected void DrawBackground()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x000C3C8C File Offset: 0x000C1E8C
		public static Point GetScreenOverdrawOffset()
		{
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x000C3C9C File Offset: 0x000C1E9C
		private static bool ShouldDrawBackgroundTileAt(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06001FD2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::ShouldDrawBackgroundTileAt(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002C:
	stloc:bool(var_4_37, call:bool(Main::WallLightAt, ldc.i4:int32(-2147483648), ldloc:int32(i)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x000C3CE8 File Offset: 0x000C1EE8
		public static bool WallLightAt(int i, int j)
		{
			if (!true)
			{
			}
			return Main.WallLightAt(Main.ShouldShowInvisibleWalls() ? 1 : 0, i, j != 0);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x000C3D04 File Offset: 0x000C1F04
		public static bool WallLightAt(int i, int j, bool showInvisibleWalls)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			bool flag;
			return flag;
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x000C3D1C File Offset: 0x000C1F1C
		protected void OldDrawBackground()
		{
			float gfxQuality = Main.gfxQuality;
			float gfxQuality2 = Main.gfxQuality;
			float gfxQuality3 = Main.gfxQuality;
			float gfxQuality4 = Main.gfxQuality;
			if (!true)
			{
			}
			int <BloodTileCount>k__BackingField = Main.SceneMetrics.<BloodTileCount>k__BackingField;
			if (Main.SceneMetrics.<EvilTileCount>k__BackingField == 0)
			{
			}
			int <BloodTileCount>k__BackingField2 = Main.SceneMetrics.<BloodTileCount>k__BackingField;
			if (Main.SceneMetrics.<HolyTileCount>k__BackingField == 0)
			{
			}
			int <BloodTileCount>k__BackingField3 = Main.SceneMetrics.<BloodTileCount>k__BackingField;
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000C4950 File Offset: 0x000C2B50
		protected void RenderBackground()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				GraphicsDevice graphicsDevice = base.GraphicsDevice;
				RenderTarget2D renderTarget2D = this.backWaterTarget;
				graphicsDevice.SetRenderTarget(renderTarget2D);
				GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
				int num2 = 1;
				this.DrawWaters(num2 != 0);
				GraphicsDevice graphicsDevice3 = base.GraphicsDevice;
				GraphicsDevice graphicsDevice4 = base.GraphicsDevice;
				RenderTarget2D renderTarget2D2 = this.backgroundTarget;
				graphicsDevice4.SetRenderTarget(renderTarget2D2);
				GraphicsDevice graphicsDevice5 = base.GraphicsDevice;
				this.DrawBackground();
				return;
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x000C49E8 File Offset: 0x000C2BE8
		public static string ValueToCoins(long value)
		{
			return "Currency.Platinum";
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x000C4AA8 File Offset: 0x000C2CA8
		private static void UpdateMinimapAnchors()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x000C4AC4 File Offset: 0x000C2CC4
		private static void DrawMapFullscreenBackground(Microsoft.Xna.Framework.Vector2 screenPosition, int screenWidth, int screenHeight)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
			Tile tile;
			ushort wall = tile.wall;
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x000C4C38 File Offset: 0x000C2E38
		public static bool DrawPlayerDeathMarker(float X, float Y, float scale, float left, float top, float headScale, int i)
		{
			/*
An exception occurred when decompiling this method (06001FDA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::DrawPlayerDeathMarker(System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:int32(var_8_1C, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_9_23, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_10_2A, callgetter:int32(Main::get_mouseY))
	stloc:int32(var_12_34, callgetter:int32(Main::get_mouseY))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000C4C7C File Offset: 0x000C2E7C
		public void DrawMiscMapIcons(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 mapTopLeft, Microsoft.Xna.Framework.Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, string mouseTextString)
		{
			this.DrawMapIcons_PotionOfReturnHomePosition(spriteBatch, mapTopLeft, mapX2Y2AndOff, mapRect, mapScale, drawScale, mouseTextString);
			this.DrawMapIcons_PotionOfReturnAppearAfterUsePosition(spriteBatch, mapTopLeft, mapX2Y2AndOff, mapRect, mapScale, drawScale, mouseTextString);
			this.DrawMapIcons_LastGolfballHit(spriteBatch, mapTopLeft, mapX2Y2AndOff, mapRect, mapScale, drawScale, mouseTextString);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000C4CBC File Offset: 0x000C2EBC
		private void DrawMapIcons_PotionOfReturnAppearAfterUsePosition(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 mapTopLeft, Microsoft.Xna.Framework.Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, string mouseTextString)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			if (num == 0)
			{
			}
			int height = Main.LocalPlayer.height;
			int num2 = 1;
			if (height == 0)
			{
			}
			if (height == 0)
			{
			}
			if (height == 0)
			{
			}
			if (mapTopLeft == null)
			{
			}
			if (mapTopLeft == null)
			{
			}
			if (num2 == 0)
			{
			}
			if (mapTopLeft == null)
			{
			}
			Rectangle rectangle;
			Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
			if (mapTopLeft == null)
			{
			}
			Microsoft.Xna.Framework.Vector2 vector2 = rectangle.Size();
			Rectangle rectangle2;
			if (rectangle2 == null)
			{
			}
			Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
			string textValue = Language.GetTextValue("GameUI.PotionOfReturnExitPortal");
			mapX2Y2AndOff.X = textValue;
			if ("GameUI.PotionOfReturnExitPortal" == null)
			{
			}
			Microsoft.Xna.Framework.Vector2 mouseScreen2 = Main.MouseScreen;
			if ("GameUI.PotionOfReturnExitPortal" == null)
			{
			}
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000C4D6C File Offset: 0x000C2F6C
		private void DrawMapIcons_PotionOfReturnHomePosition(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 mapTopLeft, Microsoft.Xna.Framework.Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, string mouseTextString)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2? potionOfReturnHomePosition = Main.LocalPlayer.PotionOfReturnHomePosition;
			if (potionOfReturnHomePosition != null)
			{
				if (potionOfReturnHomePosition == null)
				{
				}
				int height = Main.LocalPlayer.height;
				int num = 1;
				if (height == 0)
				{
				}
				if (height == 0)
				{
				}
				if (height == 0)
				{
				}
				if (mapTopLeft == null)
				{
				}
				if (mapTopLeft == null)
				{
				}
				if (num == 0)
				{
				}
				if (mapTopLeft == null)
				{
				}
				Rectangle rectangle;
				Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
				if (mapTopLeft == null)
				{
				}
				Microsoft.Xna.Framework.Vector2 vector2 = rectangle.Size();
				Rectangle rectangle2;
				if (rectangle2 == null)
				{
				}
				Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
				string textValue = Language.GetTextValue("GameUI.PotionOfReturnHomePortal");
				mapX2Y2AndOff.X = textValue;
				if ("GameUI.PotionOfReturnHomePortal" == null)
				{
				}
				Microsoft.Xna.Framework.Vector2 mouseScreen2 = Main.MouseScreen;
				if ("GameUI.PotionOfReturnHomePortal" == null)
				{
				}
			}
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000C4E24 File Offset: 0x000C3024
		private void DrawMapIcons_LastGolfballHit(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 mapTopLeft, Microsoft.Xna.Framework.Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, string mouseTextString)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Projectile lastHitBall = Main.LocalGolfState.GetLastHitBall();
			if (lastHitBall != null)
			{
				Microsoft.Xna.Framework.Vector2 center = lastHitBall.Center;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (mapTopLeft == null)
				{
				}
				if (mapTopLeft == null)
				{
				}
				if (mapTopLeft == null)
				{
				}
				Rectangle rectangle;
				Microsoft.Xna.Framework.Vector2 vector = rectangle.Size();
				Microsoft.Xna.Framework.Vector2 vector2 = rectangle.Size();
				int type = lastHitBall.type;
				Rectangle rectangle2;
				Microsoft.Xna.Framework.Vector2 vector3 = rectangle2.Size();
				Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
				string name = lastHitBall.Name;
				mapX2Y2AndOff.X = name;
				Microsoft.Xna.Framework.Vector2 mouseScreen2 = Main.MouseScreen;
			}
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000C4EC4 File Offset: 0x000C30C4
		public static void TriggerPing(Microsoft.Xna.Framework.Vector2 position)
		{
			if (!true)
			{
			}
			bool netClient = Main.NetClient;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000C4EE0 File Offset: 0x000C30E0
		public static void DrawNPCHeadFriendly(Entity theNPC, byte alpha, float headScale, SpriteEffects dir, int npcID, float x, float y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000C4EF4 File Offset: 0x000C30F4
		public static void DrawNPCHeadBoss(Entity theNPC, byte alpha, float headScale, float rotation, SpriteEffects effects, int npcID, float x, float y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x000C4F08 File Offset: 0x000C3108
		private static void DrawWithOutlines(Entity entity, Microsoft.Xna.Framework.Graphics.Texture2D tex, Microsoft.Xna.Framework.Vector2 position, Rectangle rect, Microsoft.Xna.Framework.Graphics.Color color, float rotation, Microsoft.Xna.Framework.Vector2 origin, float scale, SpriteEffects effects)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x000C4F94 File Offset: 0x000C3194
		public static Microsoft.Xna.Framework.Graphics.Color GetPlayerHeadBordersColor(Player plr)
		{
			/*
An exception occurred when decompiling this method (06001FE3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Main::GetPlayerHeadBordersColor(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0052:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_6))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x000C4FF8 File Offset: 0x000C31F8
		public static string DrawMap_FindChestName(LocalizedText[] chestNames, Tile chestTile, int x, int y, int fullTileWidth = 36)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			short num2;
			if (num2 != 0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x000C5018 File Offset: 0x000C3218
		public void DrawSimpleSurfaceBackground(Microsoft.Xna.Framework.Vector2 areaPosition, int areaWidth, int areaHeight)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000C5060 File Offset: 0x000C3260
		public void DrawCapture(Rectangle area, CaptureSettings settings)
		{
			if (!true)
			{
			}
			float[] bgAlphaFrontLayer = Main.bgAlphaFrontLayer;
			float[] bgAlphaFarBackLayer = Main.bgAlphaFarBackLayer;
			float[] liquidAlpha = Main.liquidAlpha;
			int <HolyTileCount>k__BackingField = Main.SceneMetrics.<HolyTileCount>k__BackingField;
			SceneMetrics sceneMetrics = Main.SceneMetrics;
			if (<HolyTileCount>k__BackingField == 0)
			{
			}
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000C54D4 File Offset: 0x000C36D4
		protected void RenderTiles()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				this.RenderBlack();
				GraphicsDevice graphicsDevice = base.GraphicsDevice;
				RenderTarget2D renderTarget2D = this.tileTarget;
				graphicsDevice.SetRenderTarget(renderTarget2D);
				GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
				TileDrawing tilesRenderer = this.TilesRenderer;
				int num2 = 1;
				int num3 = 1;
				long num4 = 0L;
				long num5 = 0L;
				tilesRenderer.PreDrawTiles(num2 != 0, num4 != 0L, num3 != 0);
				TileDrawing tilesRenderer2 = this.TilesRenderer;
				int num6 = 1;
				int num7 = 1;
				long num8 = 0L;
				tilesRenderer2.Draw(num6 != 0, num8 != 0L, num7 != 0, (int)num5);
				TimeLogger.DetailedDrawReset();
				TileDrawing tilesRenderer3 = this.TilesRenderer;
				int num9 = 1;
				int num10 = 1;
				long num11 = 0L;
				tilesRenderer3.PostDrawTiles(num9 != 0, num11 != 0L, num10 != 0);
				TimeLogger.DetailedDrawTime(28);
				GraphicsDevice graphicsDevice3 = base.GraphicsDevice;
			}
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x000C5594 File Offset: 0x000C3794
		protected void RenderTiles2()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				GraphicsDevice graphicsDevice = base.GraphicsDevice;
				RenderTarget2D renderTarget2D = this.tile2Target;
				graphicsDevice.SetRenderTarget(renderTarget2D);
				GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
				TileDrawing tilesRenderer = this.TilesRenderer;
				int num2 = 1;
				long num3 = 0L;
				long num4 = 0L;
				long num5 = 0L;
				tilesRenderer.PreDrawTiles(num3 != 0L, num4 != 0L, num2 != 0);
				TileDrawing tilesRenderer2 = this.TilesRenderer;
				int num6 = 1;
				long num7 = 0L;
				long num8 = 0L;
				tilesRenderer2.Draw(num7 != 0L, num8 != 0L, num6 != 0, (int)num5);
				TimeLogger.DetailedDrawReset();
				TileDrawing tilesRenderer3 = this.TilesRenderer;
				int num9 = 1;
				long num10 = 0L;
				long num11 = 0L;
				tilesRenderer3.PostDrawTiles(num10 != 0L, num11 != 0L, num9 != 0);
				TimeLogger.DetailedDrawTime(29);
				GraphicsDevice graphicsDevice3 = base.GraphicsDevice;
			}
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x000C564C File Offset: 0x000C384C
		protected void RenderWater()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				GraphicsDevice graphicsDevice = base.GraphicsDevice;
				GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
				int num2 = 1;
				long num3 = 0L;
				this.DrawWaters(num3 != 0L);
				TimeLogger.DetailedDrawReset();
				if (num2 == 0)
				{
				}
				TimeLogger.DetailedDrawTime(31);
				GraphicsDevice graphicsDevice3 = base.GraphicsDevice;
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x000C56A0 File Offset: 0x000C38A0
		public static int CalculateWaterStyle(bool ignoreFountains = false)
		{
			if (!true)
			{
			}
			int <ActiveFountainColor>k__BackingField = Main.SceneMetrics.<ActiveFountainColor>k__BackingField;
			if (<ActiveFountainColor>k__BackingField == 0 || <ActiveFountainColor>k__BackingField == 0)
			{
			}
			return Main.bgStyle;
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool IsLiquidStyleWater(int liquidStyle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x000C5774 File Offset: 0x000C3974
		private void DrawWaters(bool isBackground = false)
		{
			if (!true)
			{
			}
			Main.drewLava = false;
			bool flushWater = this.FlushWater;
			if (flushWater)
			{
				if (!flushWater)
				{
				}
				Main.waterStyle = Main.CalculateWaterStyle(false);
				Main.numActiveLiquidAlpha = 0;
				int waterStyle = Main.waterStyle;
				int waterStyle2 = Main.waterStyle;
				float[] liquidAlpha = Main.liquidAlpha;
				float[] liquidAlpha2 = Main.liquidAlpha;
				return;
			}
			float[] liquidAlpha3 = Main.liquidAlpha;
			int waterStyle3 = Main.waterStyle;
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x000C58DC File Offset: 0x000C3ADC
		protected void DrawLiquid(bool bg = false, int Style = 0, float Alpha = 1f, bool drawSinglePassLiquids = true)
		{
			if (!true)
			{
			}
			bool notRetro = Lighting.NotRetro;
			if (!true)
			{
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000C594C File Offset: 0x000C3B4C
		public static void DrawTileInWater(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 drawOffset, int x, int y, byte liquid, short frameX, short frameY)
		{
			if (!true)
			{
			}
			int num = 8;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000C596C File Offset: 0x000C3B6C
		public void oldDrawWater(bool bg = false, int Style = 0, float Alpha = 1f)
		{
			if (!true)
			{
			}
			long num = 0L;
			if (!true)
			{
			}
			float gfxQuality = Main.gfxQuality;
			float gfxQuality2 = Main.gfxQuality;
			float gfxQuality3 = Main.gfxQuality;
			float gfxQuality4 = Main.gfxQuality;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int num2 = 32640;
			int num3 = 32768;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition4 = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			int num4 = 5;
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				return;
			}
			int num5 = 5;
			if (num4 == 0)
			{
			}
			if (num5 != 0)
			{
				return;
			}
			if (num4 == 0)
			{
			}
			if (num3 == 0 || num3 == 0)
			{
			}
			uint packedValue = Lighting.GetColor(num4, (int)num).PackedValue;
			long num6 = -16777215L;
			if (num6 == 0L)
			{
			}
			bool drewLava = Main.drewLava;
			if (num6 == 0L)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition5 = Main.screenPosition;
			int screenWidth2 = Main.screenWidth;
			if (num3 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition6 = Main.screenPosition;
			int screenHeight2 = Main.screenHeight;
			int screenWidth3 = Main.screenWidth;
			int screenHeight3 = Main.screenHeight;
			int screenWidth4 = Main.screenWidth;
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000C5CE8 File Offset: 0x000C3EE8
		protected bool FullTile(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (num == 0)
			{
			}
			Tile tile2;
			if (tile2.blockType() != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			Tile tile3;
			bool isLoaded2 = tile3.IsLoaded;
			if (num == 0)
			{
			}
			Tile tile4;
			if (tile4.blockType() == 0)
			{
				if (num == 0)
				{
				}
				Tile tile5;
				bool isLoaded3 = tile5.IsLoaded;
				return;
			}
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000C5D38 File Offset: 0x000C3F38
		protected void DrawBlack(bool force = false)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000C5E94 File Offset: 0x000C4094
		public static bool ShouldShowInvisibleWalls()
		{
			/*
An exception occurred when decompiling this method (06001FF2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::ShouldShowInvisibleWalls()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:bool(var_1_20, ldfld:bool(Player::CanSeeInvisibleBlocks, callgetter:Player(Main::get_LocalPlayer)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x000C5EC4 File Offset: 0x000C40C4
		protected void RenderBlack()
		{
			if (!true)
			{
			}
			if (!true)
			{
				GraphicsDevice graphicsDevice = base.GraphicsDevice;
				RenderTarget2D renderTarget2D = this.blackTarget;
				graphicsDevice.SetRenderTarget(renderTarget2D);
				GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
				GraphicsDevice graphicsDevice3 = base.GraphicsDevice;
				TimeLogger.DetailedDrawReset();
				Main.FlushBatches();
				TimeLogger.DetailedDrawTime(30);
				GraphicsDevice graphicsDevice4 = base.GraphicsDevice;
			}
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000C5F1C File Offset: 0x000C411C
		protected void DrawWalls()
		{
			this.WallsRenderer.DrawWalls();
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000C5F34 File Offset: 0x000C4134
		protected void RenderWalls()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				GraphicsDevice graphicsDevice = base.GraphicsDevice;
				RenderTarget2D renderTarget2D = this.wallTarget;
				graphicsDevice.SetRenderTarget(renderTarget2D);
				GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
				GraphicsDevice graphicsDevice3 = base.GraphicsDevice;
				WallDrawing wallsRenderer = this.WallsRenderer;
				wallsRenderer.DrawWalls();
				return;
			}
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000C5FA8 File Offset: 0x000C41A8
		protected void ReleaseTargets()
		{
			RenderTarget2D renderTarget2D = this.backWaterTarget;
			if (renderTarget2D != null)
			{
				renderTarget2D.Dispose();
			}
			RenderTarget2D renderTarget2D2 = this.blackTarget;
			if (renderTarget2D2 != null)
			{
				renderTarget2D2.Dispose();
			}
			RenderTarget2D renderTarget2D3 = this.tileTarget;
			if (renderTarget2D3 != null)
			{
				renderTarget2D3.Dispose();
			}
			RenderTarget2D renderTarget2D4 = this.tile2Target;
			if (renderTarget2D4 != null)
			{
				renderTarget2D4.Dispose();
			}
			RenderTarget2D renderTarget2D5 = this.wallTarget;
			if (renderTarget2D5 != null)
			{
				renderTarget2D5.Dispose();
			}
			RenderTarget2D renderTarget2D6 = this.backgroundTarget;
			if (renderTarget2D6 != null)
			{
				renderTarget2D6.Dispose();
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000C602C File Offset: 0x000C422C
		protected void InitTargets()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			GraphicsDevice graphicsDevice = base.GraphicsDevice;
			GraphicsDevice graphicsDevice2 = base.GraphicsDevice;
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000C6050 File Offset: 0x000C4250
		protected void EnsureRenderTargetContent()
		{
			if (!true)
			{
			}
			LightMode mode = Lighting.Mode;
			if (!true)
			{
			}
			LightMode mode2 = Lighting.Mode;
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000C6080 File Offset: 0x000C4280
		protected void InitTargets(int width, int height)
		{
			if (!true)
			{
			}
			LightMode mode = Lighting.Mode;
			if (!true)
			{
			}
			LightMode mode2 = Lighting.Mode;
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000C60B0 File Offset: 0x000C42B0
		protected void DrawWires()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool hideWires = WiresUI.Settings.HideWires;
			bool hideWires2 = WiresUI.Settings.HideWires;
			int myPlayer = Main.myPlayer;
			if (hideWires2)
			{
				if (!hideWires2)
				{
				}
				int myPlayer2 = Main.myPlayer;
				return;
			}
			int num = 1;
			if (num == 0)
			{
			}
			float gfxQuality = Main.gfxQuality;
			float gfxQuality2 = Main.gfxQuality;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int num2 = 15744;
			int num3 = 32640;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition4 = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
				return;
			}
			if (num2 == 0)
			{
			}
			if (num3 != 0)
			{
				return;
			}
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			float num4 = Lighting.Brightness(1073741824, 1073741824);
			if (num2 != 0)
			{
			}
			Microsoft.Xna.Framework.Graphics.Color color = Lighting.GetColor(1073741824, 1073741824);
			if (num2 != 0)
			{
				return;
			}
			if (1073741824 != 0)
			{
				return;
			}
			int num5;
			if (num5 != 0)
			{
				return;
			}
			Microsoft.Xna.Framework.Vector2 screenPosition5 = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition6 = Main.screenPosition;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000C6518 File Offset: 0x000C4718
		public static int ConvertPaintIdToTileShaderIndex(int paintIndexOnTile, bool isUsedForPaintingGrass, bool useWallShaderHacks)
		{
			return 43;
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000C6530 File Offset: 0x000C4730
		public static void ResetWindCounter(bool resetExtreme = false)
		{
			int num = FastRandom.CreateWithRandomSeed().Next(900, 2701);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000C6554 File Offset: 0x000C4754
		public static void NewLightning()
		{
			if (!true)
			{
			}
			bool disableIntenseVisualEffects = Main.DisableIntenseVisualEffects;
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				return;
			}
			int num2;
			if (num2 != 0)
			{
				return;
			}
			int num3;
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000C657C File Offset: 0x000C477C
		public void UpdateWeather(GameTime gameTime, int currentDayRateIteration)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicClient = Main.LogicClient;
			if (currentDayRateIteration != 0)
			{
				return;
			}
			bool active = this._active;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			long num2 = 32752L;
			if (active)
			{
			}
			int num3;
			if (num2 != 0L)
			{
				num3 = 16256;
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				int num4;
				int num5;
				int num6;
				int num7;
				Lighting.LightTiles(num4, num5, num6, num7);
				int num8;
				int num9;
				int num10;
				int num11;
				Lighting.LightTiles(num8, num9, num10, num11);
				return;
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			int num12;
			int num13;
			int num14;
			int num15;
			Lighting.LightTiles(num12, num13, num14, num15);
			int num16;
			int num17;
			int num18;
			int num19;
			Lighting.LightTiles(num16, num17, num18, num19);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000C6864 File Offset: 0x000C4A64
		public void LoadBackground(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x000C6884 File Offset: 0x000C4A84
		public void LoadItem(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x000C689C File Offset: 0x000C4A9C
		public void LoadNPC(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000C68B4 File Offset: 0x000C4AB4
		public void LoadProjectile(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000C68CC File Offset: 0x000C4ACC
		public void LoadGore(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x000C68E4 File Offset: 0x000C4AE4
		public void LoadWall(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x000C68FC File Offset: 0x000C4AFC
		public void LoadTiles(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000C6914 File Offset: 0x000C4B14
		public void LoadItemFlames(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x000C6930 File Offset: 0x000C4B30
		public void LoadWings(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x000C6948 File Offset: 0x000C4B48
		public void LoadHair(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000C6960 File Offset: 0x000C4B60
		public void LoadArmorHead(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x000C6978 File Offset: 0x000C4B78
		public void LoadArmorBody(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000C6994 File Offset: 0x000C4B94
		public void LoadArmorLegs(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000C69AC File Offset: 0x000C4BAC
		public void LoadAccHandsOn(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x000C69CC File Offset: 0x000C4BCC
		public void LoadAccHandsOff(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000C69EC File Offset: 0x000C4BEC
		public void LoadAccBack(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000C6A04 File Offset: 0x000C4C04
		public void LoadAccFront(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x000C6A1C File Offset: 0x000C4C1C
		public void LoadAccShoes(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x000C6A34 File Offset: 0x000C4C34
		public void LoadAccWaist(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000C6A4C File Offset: 0x000C4C4C
		public void LoadAccShield(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000C6A64 File Offset: 0x000C4C64
		public void LoadAccNeck(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x000C6A7C File Offset: 0x000C4C7C
		public void LoadAccFace(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x000C6A94 File Offset: 0x000C4C94
		public void LoadAccBalloon(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x000C6AAC File Offset: 0x000C4CAC
		public void LoadAccBeard(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000C6AC4 File Offset: 0x000C4CC4
		public void LoadFlameRing()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000C6ADC File Offset: 0x000C4CDC
		protected void DrawSurfaceBG()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				bool gameMenu = Main.gameMenu;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}
			else if (num == 0)
			{
			}
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000C6F84 File Offset: 0x000C5184
		private static float DrawSurfaceBG_GetFogPower()
		{
			if (!true)
			{
			}
			float graveyardVisualIntensity = Main.GraveyardVisualIntensity;
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000C6FA0 File Offset: 0x000C51A0
		private void DrawSurfaceBG_DrawBackMountainsLayer(int bgTextureIndex)
		{
			int num = this.bgTopY;
			int num2 = this.bgLoops;
			this.bgTopY = num;
			if (num == 0)
			{
			}
			int num3 = this.bgStartX;
			int num4 = this.bgTopY;
			Rectangle? backgroundRect = this.GetBackgroundRect(bgTextureIndex);
			int num5 = this.bgLoops;
			int num6 = this.bgTopY;
			this.bgTopY = num6;
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x000C6FF8 File Offset: 0x000C51F8
		private int DrawSurfaceBG_GetLayerYOffset(int bgTextureIndex)
		{
			return 130;
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000C7014 File Offset: 0x000C5214
		private float GetForestToForestBackgroundLerperValue()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000C7028 File Offset: 0x000C5228
		private void DrawSurfaceBG_BackMountainsStep1(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack)
		{
			if (!true)
			{
			}
			float num = this.scAdj;
			long num2 = 32752L;
			long num3 = 858993459L;
			this.bgTopY = (int)num2;
			this.bgParallax = (double)num3;
			if (num2 != 0L)
			{
				return;
			}
			double num4 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num5 = this.bgParallax;
			double num6 = Math.IEEERemainder(num4, 1300.0);
			long num7 = 32752L;
			this.bgStartX = (int)num7;
			int num8 = 1024;
			int screenWidth = Main.screenWidth;
			bool gameMenu = Main.gameMenu;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			float[] bgAlphaFarBackLayer = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer2 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			long num9 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num9);
			float[] bgAlphaFarBackLayer3 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer4 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			long num10 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num10);
			float[] bgAlphaFarBackLayer5 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer6 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			long num11 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num11);
			float[] bgAlphaFarBackLayer7 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer8 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			long num12 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num12);
			float[] bgAlphaFarBackLayer9 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer10 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			int num13 = 23;
			this.DrawSurfaceBG_DrawBackMountainsLayer(num13);
			float[] bgAlphaFarBackLayer11 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer12 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			int num14 = 24;
			this.DrawSurfaceBG_DrawBackMountainsLayer(num14);
			float[] bgAlphaFarBackLayer13 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer14 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			long num15 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num15);
			float[] bgAlphaFarBackLayer15 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer16 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			int num16 = 24;
			this.DrawSurfaceBG_DrawBackMountainsLayer(num16);
			float[] bgAlphaFarBackLayer17 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer18 = Main.bgAlphaFarBackLayer;
			if (num8 == 0)
			{
			}
			int num17 = 246;
			this.DrawSurfaceBG_DrawBackMountainsLayer(num17);
			if (num7 == 0L)
			{
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000C71CC File Offset: 0x000C53CC
		private void DrawSurfaceBG_BackMountainsStep2(int pushBGTopHack)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			int num = this.bgStartX;
			this.bgStartX = num;
			if (num == 0)
			{
			}
			this.UpdateOceanWaterLineForAmbience();
			if (num == 0)
			{
			}
			double num2 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			float[] bgAlphaFarBackLayer = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer2 = Main.bgAlphaFarBackLayer;
			long num3 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num3);
			float[] bgAlphaFarBackLayer3 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer4 = Main.bgAlphaFarBackLayer;
			int num4 = 22;
			this.DrawSurfaceBG_DrawBackMountainsLayer(num4);
			float[] bgAlphaFarBackLayer5 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer6 = Main.bgAlphaFarBackLayer;
			int num5 = 25;
			this.DrawSurfaceBG_DrawBackMountainsLayer(num5);
			float[] bgAlphaFarBackLayer7 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer8 = Main.bgAlphaFarBackLayer;
			long num6 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num6);
			float[] bgAlphaFarBackLayer9 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer10 = Main.bgAlphaFarBackLayer;
			long num7 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num7);
			float[] bgAlphaFarBackLayer11 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer12 = Main.bgAlphaFarBackLayer;
			int num8 = 42;
			this.DrawSurfaceBG_DrawBackMountainsLayer(num8);
			float[] bgAlphaFarBackLayer13 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer14 = Main.bgAlphaFarBackLayer;
			int num9 = 247;
			this.DrawSurfaceBG_DrawBackMountainsLayer(num9);
			float[] bgAlphaFarBackLayer15 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer16 = Main.bgAlphaFarBackLayer;
			long num10 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num10);
			float[] bgAlphaFarBackLayer17 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer18 = Main.bgAlphaFarBackLayer;
			long num11 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num11);
			float[] bgAlphaFarBackLayer19 = Main.bgAlphaFarBackLayer;
			float[] bgAlphaFarBackLayer20 = Main.bgAlphaFarBackLayer;
			long num12 = 0L;
			this.DrawSurfaceBG_DrawBackMountainsLayer((int)num12);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000C730C File Offset: 0x000C550C
		private void UpdateOceanWaterLineForAmbience()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000C733C File Offset: 0x000C553C
		private void DrawSurfaceBG_Mushroom(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
			int num = 28;
			if (270 == 0)
			{
			}
			int num2 = 32640;
			long num3 = -1717986919L;
			this.bgParallax = (double)num3;
			this.SetBackgroundOffsets(num, backgroundTopMagicNumber, pushBGTopHack);
			double num4 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num5 = this.bgParallax;
			if (num2 == 0)
			{
			}
			double num6 = Math.IEEERemainder(num4, (double)bgGlobalScaleMultiplier);
			float num7 = this.scAdj;
			int num8 = 32768;
			this.SetBackgroundOffsets(num, backgroundTopMagicNumber, pushBGTopHack);
			bool gameMenu = Main.gameMenu;
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			if (this.bgLoops == 0)
			{
			}
			if (num8 == 0)
			{
			}
			int num9 = this.bgTopY;
			long num10 = 0L;
			int num11 = this.bgStartX;
			Rectangle? backgroundRect = this.GetBackgroundRect((int)num10);
			if (this.bgLoops == 0)
			{
			}
			int num12 = 28;
			if (17279 == 0)
			{
			}
			long num13 = 60293L;
			this.bgParallax = (double)num13;
			this.SetBackgroundOffsets(num12, backgroundTopMagicNumber, pushBGTopHack);
			double num14 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			double num15 = this.bgParallax;
			double num16 = Math.IEEERemainder(num14, (double)bgGlobalScaleMultiplier);
			long num17 = 32752L;
			float num18 = this.scAdj;
			int num19 = 32768;
			this.SetBackgroundOffsets(num12, backgroundTopMagicNumber, pushBGTopHack);
			bool gameMenu2 = Main.gameMenu;
			int num20 = this.bgStartX;
			this.bgTopY = (int)num17;
			this.bgStartX = num20;
			if (num20 == 0)
			{
			}
			if (num20 != 0)
			{
				if (num20 == 0)
				{
				}
				int screenWidth2 = Main.screenWidth;
				Microsoft.Xna.Framework.Vector2 screenPosition4 = Main.screenPosition;
				if (this.bgLoops == 0)
				{
				}
				if (num19 == 0)
				{
				}
				int num21 = this.bgTopY;
				long num22 = 0L;
				int num23 = this.bgStartX;
				Rectangle? backgroundRect2 = this.GetBackgroundRect((int)num22);
				if (this.bgLoops == 0)
				{
				}
				int num24 = 28;
				if (270 == 0)
				{
				}
				long num25 = 36700L;
				this.bgParallax = (double)num25;
				this.SetBackgroundOffsets(num24, backgroundTopMagicNumber, pushBGTopHack);
				double num26 = this.bgParallax;
				Microsoft.Xna.Framework.Vector2 screenPosition5 = Main.screenPosition;
				double num27 = this.bgParallax;
				double num28 = Math.IEEERemainder(num26, (double)bgGlobalScaleMultiplier);
				long num29 = 32752L;
				float num30 = this.scAdj;
				int num31 = 32768;
				this.SetBackgroundOffsets(num24, backgroundTopMagicNumber, pushBGTopHack);
				bool gameMenu3 = Main.gameMenu;
				int num32 = this.bgStartX;
				this.bgTopY = (int)num29;
				this.bgStartX = num32;
				if (num32 == 0)
				{
				}
				if (num32 != 0)
				{
					if (num32 == 0)
					{
					}
					int screenWidth3 = Main.screenWidth;
					Microsoft.Xna.Framework.Vector2 screenPosition6 = Main.screenPosition;
					if (this.bgLoops == 0)
					{
					}
					if (num31 == 0)
					{
					}
					int num33 = this.bgTopY;
					long num34 = 0L;
					int num35 = this.bgStartX;
					Rectangle? backgroundRect3 = this.GetBackgroundRect((int)num34);
					int num36 = this.bgLoops;
					return;
				}
			}
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x000C75D4 File Offset: 0x000C57D4
		private void DrawSurfaceBG_Crimson(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 16288;
			float num3 = this.scAdj;
			int num4 = 32640;
			long num5 = -1717986919L;
			this.bgParallax = (double)num5;
			this.bgTopY = num;
			this.SetBackgroundOffsets(pushBGTopHack, backgroundTopMagicNumber, pushBGTopHack);
			this.LoadBackground(pushBGTopHack);
			if (num2 == 0)
			{
			}
			double num6 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num7 = this.bgParallax;
			double num8 = Math.IEEERemainder(num6, (double)0f);
			int num9 = this.bgTopY;
			this.bgTopY = num9;
			int num10 = this.bgTopY;
			this.bgTopY = num10;
			if (num10 == 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			this.bgTopY = num10;
			if (num10 == 0)
			{
			}
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			if (this.bgLoops == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num11 = this.bgTopY;
			int num12 = this.bgStartX;
			int num13 = this.bgLoops;
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x000C78AC File Offset: 0x000C5AAC
		private void DrawSurfaceBG_Snow(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 16288;
			float num3 = this.scAdj;
			int num4 = 32768;
			long num5 = -1717986919L;
			this.bgParallax = (double)num5;
			this.bgTopY = num;
			this.SetBackgroundOffsets(pushBGTopHack, backgroundTopMagicNumber, pushBGTopHack);
			this.LoadBackground(pushBGTopHack);
			if (num2 == 0)
			{
			}
			double num6 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num7 = this.bgParallax;
			double num8 = Math.IEEERemainder(num6, (double)0f);
			bool gameMenu = Main.gameMenu;
			this.bgTopY = num4;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x000C7B58 File Offset: 0x000C5D58
		private void SetBackgroundOffsets(int backgroundID, double backgroundTopMagicNumber, int pushBGTopHack)
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x000C7C5C File Offset: 0x000C5E5C
		private void DrawSurfaceBG_Hallow(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 16288;
			float num3 = this.scAdj;
			long num4 = -1717986919L;
			this.bgParallax = (double)num4;
			this.bgTopY = num;
			this.SetBackgroundOffsets(pushBGTopHack, backgroundTopMagicNumber, pushBGTopHack);
			this.LoadBackground(pushBGTopHack);
			if (num2 == 0)
			{
			}
			double num5 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num6 = this.bgParallax;
			double num7 = Math.IEEERemainder(num5, (double)0f);
			bool gameMenu = Main.gameMenu;
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			if (this.bgLoops == 0)
			{
			}
			int num8 = this.bgTopY;
			long num9 = 0L;
			int num10 = this.bgStartX;
			Rectangle? backgroundRect = this.GetBackgroundRect((int)num9);
			int num11 = this.bgLoops;
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000C7EDC File Offset: 0x000C60DC
		private void DrawSurfaceBG_GoodEvilDesert(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack)
		{
			if (!true)
			{
			}
			long num = 18350L;
			int num2 = 32640;
			this.bgParallax = (double)num;
			if (num2 != 0)
			{
				return;
			}
			double num3 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num4 = this.bgParallax;
			double num5 = Math.IEEERemainder(num3, (double)bgGlobalScaleMultiplier);
			float num6 = this.scAdj;
			int num7 = 32768;
			bool gameMenu = Main.gameMenu;
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			if (this.bgLoops == 0)
			{
			}
			if (num7 == 0)
			{
			}
			int num8 = this.bgStartX;
			int num9 = this.bgTopY;
			if (this.bgLoops == 0)
			{
			}
			int num10 = 32640;
			long num11 = 36700L;
			this.bgParallax = (double)num11;
			if (num10 != 0)
			{
				return;
			}
			double num12 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			double num13 = this.bgParallax;
			double num14 = Math.IEEERemainder(num12, (double)bgGlobalScaleMultiplier);
			long num15 = 32752L;
			float num16 = this.scAdj;
			int num17 = 32768;
			bool gameMenu2 = Main.gameMenu;
			int num18 = this.bgStartX;
			this.bgTopY = (int)num15;
			this.bgStartX = num18;
			if (num18 == 0)
			{
			}
			int screenWidth2 = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition4 = Main.screenPosition;
			if (this.bgLoops == 0)
			{
			}
			if (num17 == 0)
			{
			}
			int num19 = this.bgStartX;
			int num20 = this.bgTopY;
			int num21 = this.bgLoops;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x000C803C File Offset: 0x000C623C
		private void DrawSurfaceBG_Jungle(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = -1717986919L;
			int num3 = 32640;
			this.bgParallax = (double)num2;
			this.SetBackgroundOffsets(pushBGTopHack, backgroundTopMagicNumber, pushBGTopHack);
			if (num == 0)
			{
			}
			double num4 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num5 = this.bgParallax;
			if (num3 == 0)
			{
			}
			double num6 = Math.IEEERemainder(num4, (double)bgGlobalScaleMultiplier);
			float num7 = this.scAdj;
			int num8 = 32768;
			this.SetBackgroundOffsets(pushBGTopHack, backgroundTopMagicNumber, pushBGTopHack);
			bool gameMenu = Main.gameMenu;
			int num9 = this.bgTopY;
			this.bgTopY = num9;
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			if (this.bgLoops == 0)
			{
			}
			if (num8 == 0)
			{
			}
			int num10 = this.bgTopY;
			long num11 = 0L;
			int num12 = this.bgStartX;
			Rectangle? backgroundRect = this.GetBackgroundRect((int)num11);
			int num13 = this.bgLoops;
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x000C82E4 File Offset: 0x000C64E4
		private void DrawSurfaceBG_Desert(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 16288;
			float num3 = this.scAdj;
			long num4 = 18350L;
			int num5 = 32768;
			this.bgParallax = (double)num4;
			this.bgTopY = num;
			this.SetBackgroundOffsets(pushBGTopHack, backgroundTopMagicNumber, pushBGTopHack);
			this.LoadBackground(pushBGTopHack);
			if (num2 == 0)
			{
			}
			double num6 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num7 = this.bgParallax;
			double num8 = Math.IEEERemainder(num6, (double)0f);
			long num9 = 32752L;
			this.bgStartX = (int)num9;
			bool gameMenu = Main.gameMenu;
			this.bgTopY = (int)num9;
			if (num9 == 0L)
			{
			}
			int screenWidth = Main.screenWidth;
			int num10 = 32768;
			this.bgLoops = num10;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			if (this.bgLoops == 0)
			{
			}
			if (num5 == 0)
			{
			}
			int num11 = this.bgStartX;
			int num12 = this.bgTopY;
			int num13 = this.bgLoops;
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x000C8580 File Offset: 0x000C6780
		private void DrawSurfaceBG_DrawChangeOverlay(int backgroundAreaId)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x000C85A8 File Offset: 0x000C67A8
		private void DrawSurfaceBG_Corrupt(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
			int num = 1;
			if (num == 0)
			{
			}
			float num2 = this.scAdj;
			int num3 = 32768;
			long num4 = -1717986919L;
			this.bgParallax = (double)num4;
			this.bgTopY = num;
			this.SetBackgroundOffsets(pushBGTopHack, backgroundTopMagicNumber, pushBGTopHack);
			this.LoadBackground(pushBGTopHack);
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				if (num3 != 0)
				{
					if (num3 == 0)
					{
					}
					int num5 = 32640;
					int num6 = 32768;
					if (num5 == 0)
					{
					}
					double num7 = this.bgParallax;
					Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
					double num8 = this.bgParallax;
					double num9 = Math.IEEERemainder(num7, (double)0f);
					this.bgStartX = int.MinValue;
					bool gameMenu = Main.gameMenu;
					this.bgTopY = int.MinValue;
					int num10 = this.bgTopY;
					this.bgTopY = num10;
					if (num10 == 0)
					{
					}
					int screenWidth = Main.screenWidth;
					this.bgLoops = int.MinValue;
					Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
					if (this.bgLoops == 0)
					{
					}
					if (num6 == 0)
					{
					}
					int num11 = this.bgTopY;
					int num12 = this.bgStartX;
					long num13 = 0L;
					int num14 = this.bgLoops;
					if (num14 == 0)
					{
					}
					int num15 = 44564;
					float num16 = this.scAdj;
					long num17 = 60293L;
					int num18 = 32768;
					this.bgParallax = (double)num17;
					this.bgTopY = num14;
					this.SetBackgroundOffsets((int)num13, backgroundTopMagicNumber, pushBGTopHack);
					this.LoadBackground((int)num13);
					if (num15 == 0)
					{
					}
					double num19 = this.bgParallax;
					Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
					double num20 = this.bgParallax;
					double num21 = Math.IEEERemainder(num19, (double)0f);
					int num22 = 32768;
					this.bgStartX = int.MinValue;
					bool gameMenu2 = Main.gameMenu;
					int num23 = this.bgStartX;
					this.bgTopY = num22;
					this.bgStartX = num23;
					int num24 = this.bgTopY;
					this.bgTopY = num24;
					if (num24 == 0)
					{
					}
					if (num22 == 0)
					{
						if (num22 == 0)
						{
						}
					}
					if (num24 == 0)
					{
					}
					int screenWidth2 = Main.screenWidth;
					this.bgLoops = int.MinValue;
					Microsoft.Xna.Framework.Vector2 screenPosition4 = Main.screenPosition;
					int num27;
					if (num18 != 0)
					{
						if (this.bgLoops == 0)
						{
						}
						int num25 = this.bgStartX;
						int num26 = this.bgTopY;
						num27 = this.bgLoops;
					}
					if (num27 == 0)
					{
					}
					int num28 = 34079;
					float num29 = this.scAdj;
					int num30 = 32640;
					long num31 = 36700L;
					this.bgParallax = (double)num31;
					this.bgTopY = num27;
					this.SetBackgroundOffsets(num18, backgroundTopMagicNumber, pushBGTopHack);
					this.LoadBackground(num18);
					int num32;
					if (num28 == 0)
					{
						if (num28 == 0)
						{
						}
						num32 = 150;
					}
					if (num32 == 0)
					{
					}
					if (num32 == 0)
					{
					}
					double num33 = this.bgParallax;
					Microsoft.Xna.Framework.Vector2 screenPosition5 = Main.screenPosition;
					double num34 = this.bgParallax;
					double num35 = Math.IEEERemainder(num33, (double)0f);
					int num36 = 32768;
					this.bgStartX = int.MinValue;
					bool gameMenu3 = Main.gameMenu;
					int num37 = this.bgStartX;
					this.bgTopY = num36;
					this.bgStartX = num37;
					int num38 = this.bgTopY;
					this.bgTopY = num38;
					if (num38 == 0)
					{
					}
					int screenWidth3 = Main.screenWidth;
					this.bgLoops = int.MinValue;
					Microsoft.Xna.Framework.Vector2 screenPosition6 = Main.screenPosition;
					if (this.bgLoops == 0)
					{
					}
					if (num30 == 0)
					{
					}
					int num39 = this.bgTopY;
					int num40 = this.bgStartX;
					int num41 = this.bgLoops;
					return;
				}
			}
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x000C88F0 File Offset: 0x000C6AF0
		private Rectangle? GetBackgroundRect(int backgroundTextureIndex)
		{
			/*
An exception occurred when decompiling this method (0600202A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<Microsoft.Xna.Framework.Rectangle> Terraria.Main::GetBackgroundRect(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_8_0C, ldc.i4:int32(2))
	stloc:int64(var_10_0F, ldc.i4:int64(0))
	call:void(Rectangle::Inflate, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](var_9), ldloc:int64[exp:int32](var_10_0F), ldloc:int32(var_8_0C))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000C8918 File Offset: 0x000C6B18
		private uint GetBackgroundCounter()
		{
			/*
An exception occurred when decompiling this method (0600202B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Terraria.Main::GetBackgroundCounter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_0_08, callgetter:bool(Main::get_gameMenu))
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x000C8930 File Offset: 0x000C6B30
		private void DrawSurfaceBG_Forest(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
			if (!true)
			{
			}
			int num = 16288;
			float num2 = this.scAdj;
			this.bgTopY = num;
			long num3 = 8192L;
			this.bgParallax = (double)num3;
			if (num3 != 0L)
			{
				return;
			}
			long num4 = 16336L;
			this.bgParallax = (double)num4;
			if (num4 == 0L)
			{
			}
			long num5 = 16384L;
			this.bgParallax = (double)num5;
			if (num5 != 0L)
			{
				return;
			}
			long num6 = 16336L;
			this.bgParallax = (double)num6;
			if (num6 == 0L)
			{
			}
			if (num6 == 0L)
			{
			}
			if (num6 == 0L)
			{
			}
			double num7 = this.bgParallax;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			double num8 = this.bgParallax;
			double num9 = Math.IEEERemainder(backgroundTopMagicNumber, 1500.0);
			long num10 = 16537L;
			float num11 = this.scAdj;
			this.bgTopY = (int)num10;
			long num12 = 16537L;
			float num13 = this.scAdj;
			this.bgTopY = (int)num12;
			long num14 = 16537L;
			float num15 = this.scAdj;
			long num16 = 32752L;
			this.bgTopY = (int)num16;
			if (num16 == 0L)
			{
			}
			bool gameMenu = Main.gameMenu;
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int num17 = this.bgLoops;
			if (num14 == 0L)
			{
			}
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x000C8C38 File Offset: 0x000C6E38
		private void DrawBackgroundBlackFill()
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			int screenHeight2 = Main.screenHeight;
			int screenHeight3 = Main.screenHeight;
			if (50484 == 0)
			{
			}
			int screenWidth = Main.screenWidth;
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x000C8C88 File Offset: 0x000C6E88
		public void DrawTileCracks(int crackType, HitTile hitter)
		{
			if (!true)
			{
			}
			long num = 0L;
			if (!true)
			{
			}
			bool flag = Main.ShouldShowInvisibleWalls();
			int[] hitTileObjectData = hitter.HitTileObjectData;
			long num2 = 0L;
			bool flag2 = WorldGen.InWorld(0, (int)num, (int)num2);
			if (hitTileObjectData == null)
			{
			}
			if (hitTileObjectData == null)
			{
			}
			Tile tile;
			bool flag3 = tile.active();
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x000C8DC4 File Offset: 0x000C6FC4
		private static void CheckMonoliths()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
			int myPlayer5 = Main.myPlayer;
			int myPlayer6 = Main.myPlayer;
			int myPlayer7 = Main.myPlayer;
			int myPlayer8 = Main.myPlayer;
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x000C8E30 File Offset: 0x000C7030
		public static bool IsGraphicsDeviceAvailable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x000C8E40 File Offset: 0x000C7040
		private void GraphicsDeviceLost(object sender, EventArgs evt)
		{
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000C8E50 File Offset: 0x000C7050
		protected override void Draw(GameTime gameTime)
		{
			bool isDrawingOrUpdating = this._isDrawingOrUpdating;
			if (!isDrawingOrUpdating)
			{
				if (!isDrawingOrUpdating)
				{
				}
				int num = 1;
				this._isDrawingOrUpdating = num != 0;
				this.DoDraw(gameTime);
				if (num == 0)
				{
				}
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x000C8E84 File Offset: 0x000C7084
		private void DoDraw(GameTime gameTime)
		{
			this.DrawSplash(gameTime);
			TimeLogger.EndDrawFrame();
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x000C9B28 File Offset: 0x000C7D28
		private static void DrawItemTextPopups(float scaleTarget)
		{
			PopupText[] popupText = Main.popupText;
			PopupText[] popupText2 = Main.popupText;
			PopupText[] popupText3 = Main.popupText;
			PopupText[] popupText4 = Main.popupText;
			string text2;
			string text = text2 + " (" + text2 + ")";
			if (")" == null)
			{
			}
			if (")" == null)
			{
			}
			PopupText[] popupText5 = Main.popupText;
			int num = 17279;
			PopupText[] popupText6 = Main.popupText;
			PopupText[] popupText7 = Main.popupText;
			PopupText[] popupText8 = Main.popupText;
			PopupText[] popupText9 = Main.popupText;
			PopupText[] popupText10 = Main.popupText;
			PopupText[] popupText11 = Main.popupText;
			PopupText[] popupText12 = Main.popupText;
			PopupText[] popupText13 = Main.popupText;
			if (num == 0)
			{
			}
			PopupText[] popupText14 = Main.popupText;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x000C9C94 File Offset: 0x000C7E94
		private static void DoDraw_UpdateCameraPosition()
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (num == 0)
			{
			}
			bool logicClient = Main.LogicClient;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
			Rect rect;
			float height = rect.height;
			if (42190744 == 0)
			{
			}
			bool playerInventory = Main.playerInventory;
			if (42190744 == 0)
			{
			}
			bool ingameOptionsWindow = Main.ingameOptionsWindow;
			if (42190744 == 0)
			{
			}
			bool hairWindow = Main.hairWindow;
			if (42190744 == 0)
			{
			}
			bool clothesWindow = Main.clothesWindow;
			if (42190744 == 0)
			{
			}
			bool flag = Main.npcChatText != "";
			if (42190744 == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			float targetScreenYOffset = Main.targetScreenYOffset;
			float screenYOffset = Main.screenYOffset;
			Main.startScreenYOffset = screenYOffset;
			Main.targetScreenYOffset = screenYOffset;
			float targetScreenYOffset2 = Main.targetScreenYOffset;
			float startScreenYOffset = Main.startScreenYOffset;
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x000CA4C8 File Offset: 0x000C86C8
		public static bool IsItDay()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000CA4DC File Offset: 0x000C86DC
		public static double starGameMath(double value = 1.0)
		{
			/*
An exception occurred when decompiling this method (06002037)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.Main::starGameMath(System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x000CA4F4 File Offset: 0x000C86F4
		private void DrawSunAndMoon(Main.SceneArea sceneArea, Microsoft.Xna.Framework.Graphics.Color moonColor, Microsoft.Xna.Framework.Graphics.Color sunColor, float tempMushroomInfluence)
		{
			if (!true)
			{
			}
			int num = sceneArea.bgTopY;
			float totalWidth = sceneArea.totalWidth;
			long num2;
			if (this != null)
			{
				num2 = 32752L;
				return;
			}
			if (num2 == 0L)
			{
			}
			double num4;
			double num3 = Math.Pow(num4, 250.0);
			if (32752 == 0)
			{
			}
			int num5 = 4829;
			int num6;
			if (num5 == 0)
			{
				if (num6 == 0)
				{
				}
				return;
			}
			if (num5 == 0)
			{
			}
			if (num5 == 0)
			{
			}
			num6 = 1;
			int num7;
			if (num7 != 0)
			{
				return;
			}
			long num8 = 0L;
			int num9;
			if (num9 == 0)
			{
			}
			Star.SpawnStars((int)num8);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x000CA734 File Offset: 0x000C8934
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private void DrawStarsInBackground(Main.SceneArea sceneArea, bool artificial)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			float graveyardVisualIntensity = Main.GraveyardVisualIntensity;
			if (num == 0)
			{
			}
			float graveyardVisualIntensity2 = Main.GraveyardVisualIntensity;
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x000CA7C8 File Offset: 0x000C89C8
		private void DrawStarsInForeground(Main.SceneArea sceneArea)
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x000CA7D8 File Offset: 0x000C89D8
		private void DrawStar(Main.SceneArea sceneArea, float starOpacity, Microsoft.Xna.Framework.Graphics.Color bgColorForStars, int i, Star theStar, bool artificial, bool foreground = false)
		{
			if (theStar != null)
			{
				bool hidden = theStar.hidden;
				if (!hidden)
				{
					if (!hidden)
					{
					}
					int num = 155;
					float twinkle = theStar.twinkle;
					float fadeIn = theStar.fadeIn;
					int num2 = 32640;
					if (32768 == 0)
					{
					}
					Microsoft.Xna.Framework.Graphics.Color color = bgColorForStars * starOpacity;
					if (num == 0)
					{
						float twinkle2 = theStar.twinkle;
						return;
					}
					if (num == 0)
					{
					}
					if (num2 == 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x000CAAAC File Offset: 0x000C8CAC
		private static void ApplyColorOfTheSkiesToTiles()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000CAAC4 File Offset: 0x000C8CC4
		private static void UpdateAtmosphereTransparencyToSkyColor()
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			int num = 17026;
			if (num == 0)
			{
			}
			if (screenHeight == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 16256;
			if (screenHeight == 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000CAB10 File Offset: 0x000C8D10
		private void Debug_PrettifyMap()
		{
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x000CAB20 File Offset: 0x000C8D20
		private static void DrawNetplayStatusText()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (!true)
			{
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000CAB3C File Offset: 0x000C8D3C
		private void DrawPlayerChatBubbles()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int myPlayer = Main.myPlayer;
				int num2 = 1;
				if (num2 == 0)
				{
				}
				int value = num2.m_value;
				if (!true)
				{
				}
			}
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000CAB74 File Offset: 0x000C8D74
		private void DrawRainInMenu()
		{
			int num = 1;
			bool active = this._active;
			if (num == 0)
			{
			}
			Rain[] rain = Main.rain;
			Rain[] rain2 = Main.rain;
			if (rain2 == null)
			{
			}
			int alpha = rain2.alpha;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (rain2 == null)
			{
			}
			float scale = rain2.scale;
			int alpha2 = rain2.alpha;
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (active)
			{
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x000CABF0 File Offset: 0x000C8DF0
		private void DoDraw_WallsTilesNPCs()
		{
			int num = 1;
			this.CacheNPCDraws();
			this.CacheProjDraws();
			List<int> drawCacheNPCsMoonMoon = this.DrawCacheNPCsMoonMoon;
			int num2 = 1;
			this.DrawCachedNPCs(drawCacheNPCsMoonMoon, num2 != 0);
			this.DoDraw_WallsAndBlacks();
			this.DrawWoF();
			this.DrawBackGore();
			if (num == 0)
			{
			}
			List<int> drawCacheNPCsBehindNonSolidTiles = this.DrawCacheNPCsBehindNonSolidTiles;
			int num3 = 1;
			this.DrawCachedNPCs(drawCacheNPCsBehindNonSolidTiles, num3 != 0);
			this.DoDraw_Tiles_NonSolid();
			this.DoDraw_Waterfalls();
			int myPlayer = Main.myPlayer;
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			SamplerState defaultSamplerState2 = Main.DefaultSamplerState;
			Matrix transform2 = Main.Transform;
			Main.FlushBatches();
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000CACC8 File Offset: 0x000C8EC8
		private void DoDraw_Waterfalls()
		{
			TimeLogger.DetailedDrawTime(16);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000CACDC File Offset: 0x000C8EDC
		private void DoDraw_Tiles_Solid()
		{
			int num = 1;
			TileDrawing tilesRenderer = this.TilesRenderer;
			if (num == 0)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			SamplerState defaultSamplerState2 = Main.DefaultSamplerState;
			Matrix transform2 = Main.Transform;
			TileDrawing tilesRenderer2 = this.TilesRenderer;
			GeometryBufferInstance.EndBuffer();
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000CAD94 File Offset: 0x000C8F94
		private void DoDraw_Tiles_NonSolid()
		{
			if (!true)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			int num = 1;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				long num2 = 0L;
				TileDrawing tilesRenderer = this.TilesRenderer;
				if (num == 0)
				{
				}
				long num3 = 0L;
				long num4 = 0L;
				long num5 = 0L;
				tilesRenderer.PreDrawTiles(num3 != 0L, num2 != 0L, num4 != 0L);
				TileDrawing tilesRenderer2 = this.TilesRenderer;
				long num6 = 0L;
				long num7 = 0L;
				tilesRenderer2.Draw(num6 != 0L, num2 != 0L, num7 != 0L, (int)num5);
				GeometryBufferInstance.EndBuffer();
				TimeLogger.DetailedDrawReset();
				return;
			}
			TileDrawing tilesRenderer3 = this.TilesRenderer;
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000CAE78 File Offset: 0x000C9078
		private void DoDraw_DrawNPCsOverTiles()
		{
			int num = 1;
			List<int> drawCacheProjsBehindNPCs = this.DrawCacheProjsBehindNPCs;
			int num2 = 1;
			this.DrawCachedProjs(drawCacheProjsBehindNPCs, num2 != 0);
			if (num == 0)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			SamplerState defaultSamplerState2 = Main.DefaultSamplerState;
			Matrix transform2 = Main.Transform;
			long num3 = 0L;
			this.DrawNPCs(num3 != 0L);
			List<int> drawCacheNPCProjectiles = this.DrawCacheNPCProjectiles;
			long num4 = 0L;
			this.DrawCachedNPCs(drawCacheNPCProjectiles, num4 != 0L);
			TimeLogger.DetailedDrawTime(19);
			Main.FlushBatches();
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000CAEEC File Offset: 0x000C90EC
		private void DoDraw_DrawNPCsBehindTiles()
		{
			int num = 1;
			List<int> drawCacheProjsBehindNPCsAndTiles = this.DrawCacheProjsBehindNPCsAndTiles;
			int num2 = 1;
			this.DrawCachedProjs(drawCacheProjsBehindNPCsAndTiles, num2 != 0);
			if (num == 0)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			SamplerState defaultSamplerState2 = Main.DefaultSamplerState;
			Matrix transform2 = Main.Transform;
			int num3 = 1;
			this.DrawNPCs(num3 != 0);
			TimeLogger.DetailedDrawTime(18);
			Main.FlushBatches();
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000CAF48 File Offset: 0x000C9148
		private void DrawBackGore()
		{
			if (!true)
			{
			}
			this.DrawGoreBehind();
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000CAF68 File Offset: 0x000C9168
		private void DoDraw_WallsAndBlacks()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag = GeometryBufferInstance.BeginBuffer(GeometryBufferInstance.BatchBuffer.Walls, 2);
			if (!true)
			{
			}
			Main.FlushBatches();
			this.WallsRenderer.DrawWalls();
			GeometryBufferInstance.EndBuffer();
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000CAFD4 File Offset: 0x000C91D4
		private static void SetBackColor(Main.InfoToSetBackColor info, [Out] Microsoft.Xna.Framework.Graphics.Color sunColor, [Out] Microsoft.Xna.Framework.Graphics.Color moonColor)
		{
			if (!true)
			{
			}
			int num = 17046;
			sunColor.R = (byte)num;
			sunColor.G = (byte)num;
			sunColor.B = (byte)num;
			int num2 = 16988;
			int num3 = 16908;
			sunColor.R = (byte)num3;
			sunColor.B = (byte)num3;
			sunColor.G = (byte)num2;
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000CB348 File Offset: 0x000C9548
		public static void GetAreaToLight([Out] int firstTileX, [Out] int lastTileX, [Out] int firstTileY, [Out] int lastTileY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 scaledPosition = Main.Camera.ScaledPosition;
			Microsoft.Xna.Framework.Vector2 scaledSize = Main.Camera.ScaledSize;
			if (num == 0)
			{
			}
			bool usingNewLighting = Lighting.UsingNewLighting;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			Microsoft.Xna.Framework.Vector2 unscaledSize = Main.Camera.UnscaledSize;
			if (num == 0)
			{
			}
			int num2 = 15744;
			int num3 = 32640;
			firstTileX.m_value = num3;
			firstTileY.m_value = num2;
			lastTileY.m_value = num2;
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000CB3C0 File Offset: 0x000C95C0
		private void DoLightTiles()
		{
			if (!true)
			{
			}
			bool flushLighting = Main.flushLighting;
			Main.flushLighting = false;
			if (-2147483648 == 0)
			{
			}
			GeometryBufferInstance.InvalidateBuffers();
			Main.renderCount = 0;
			int num;
			int num2;
			int num3;
			int num4;
			Lighting.LightTiles(num, num2, num3, num4);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x000CB40C File Offset: 0x000C960C
		private static void ClampScreenPositionToWorld()
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			Microsoft.Xna.Framework.Vector2 vector;
			Main.screenPosition = vector;
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x000CB448 File Offset: 0x000C9648
		private void DrawBG()
		{
			if (!true)
			{
			}
			int num = Math.Min(Main.screenHeight, 0);
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			float num2 = this.scAdj;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x000CB5C4 File Offset: 0x000C97C4
		private void UpdateBGVisibility_FrontLayer(int? targetBiomeOverride, float? transitionAmountOverride)
		{
			if (!true)
			{
			}
			int bgStyle = Main.bgStyle;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x000CB61C File Offset: 0x000C981C
		private void UpdateBGVisibility_BackLayer(int? targetBiomeOverride, float? transitionAmountOverride)
		{
			if (!true)
			{
			}
			int bgStyle = Main.bgStyle;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x000CB640 File Offset: 0x000C9840
		public static int GetPreferredBGStyleForPlayer()
		{
			if (!true)
			{
			}
			int bgStyle = Main.bgStyle;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int num = 32768;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth2 = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			if (63488 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			return 6;
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x000CB754 File Offset: 0x000C9954
		private void DrawBG_ModifyBGFarBackLayerAlpha(int desiredBG, [Optional] int? desiredBG2, [Optional] float? transitionAmountOverride)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000CB780 File Offset: 0x000C9980
		public void DrawInfernoRings()
		{
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x000CB7B4 File Offset: 0x000C99B4
		private static void UpdateInvasion()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			NPC.SetEventFlagCleared(true, (int)num2);
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			AchievementsHelper.NotifyProgressionEvent(10);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x000CB854 File Offset: 0x000C9A54
		private static void InvasionWarning()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int spawnTileX = Main.spawnTileX;
				return;
			}
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x000CB89C File Offset: 0x000C9A9C
		public static bool CanStartInvasion(int type = 1, bool ignoreDelay = false)
		{
			/*
An exception occurred when decompiling this method (06002056)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main::CanStartInvasion(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x000CB8C8 File Offset: 0x000C9AC8
		public static void StartInvasion(int type = 1)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0 || num == 0)
				{
				}
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000CB918 File Offset: 0x000C9B18
		public static void FakeLoadInvasionStart()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000CB930 File Offset: 0x000C9B30
		private static void UpdateClient()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				if (num2 == 0)
				{
				}
			}
			int num3 = 900;
			int myPlayer3 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer4 = Main.myPlayer;
			int myPlayer5 = Main.myPlayer;
			bool netHost = Main.NetHost;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num3 != 0 || num3 == 0)
			{
			}
			if (7201 == 0)
			{
			}
			Main.CheckPlayerItemOwnership();
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000CB9B8 File Offset: 0x000C9BB8
		private static void CheckPlayerItemOwnership()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000CB9D8 File Offset: 0x000C9BD8
		private static void CheckAssignItemOwnership()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x000CB9EC File Offset: 0x000C9BEC
		private static void UpdateServer()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (46021 == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000CBA3C File Offset: 0x000C9C3C
		public static void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000CBA50 File Offset: 0x000C9C50
		public static void NewTextMultiline(string text, bool force = false, [Optional] Microsoft.Xna.Framework.Graphics.Color c, int WidthLimit = -1)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000CBA64 File Offset: 0x000C9C64
		public static void StopRain()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000CBA74 File Offset: 0x000C9C74
		public static void StartRain()
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
			}
			int num3;
			if (num3 == 0)
			{
			}
			int num4;
			if (num4 == 0)
			{
			}
			int num5;
			if (num5 == 0)
			{
			}
			int num6;
			if (num6 == 0)
			{
			}
			Main.ChangeRain();
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000CBB08 File Offset: 0x000C9D08
		private static void ChangeRain()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num;
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000CBB2C File Offset: 0x000C9D2C
		public static void StartSlimeRain(bool announce = true)
		{
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000CBB4C File Offset: 0x000C9D4C
		public static void StopSlimeRain(bool announce = true)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000CBB64 File Offset: 0x000C9D64
		private static void UpdateTime()
		{
			bool lanternsUp = LanternNight.LanternsUp;
			int num = 30;
			if (num == 0 || num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			bool gameMenu = Main.gameMenu;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000CBF10 File Offset: 0x000CA110
		public static bool AnyPlayerReadyToFightKingSlime()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000CBF34 File Offset: 0x000CA134
		public static void SkipToTime(int timeToSet, bool setIsDayTime)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag = Main.ShouldNormalEventsBeAbleToStart();
			Main.UpdateTime_StartNight(true);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000CBF70 File Offset: 0x000CA170
		public static bool ShouldNormalEventsBeAbleToStart()
		{
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				bool flag = NPC.AnyNPCs(398);
				if (!true)
				{
				}
			}
			return true;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000CBFA0 File Offset: 0x000CA1A0
		public static void UpdateTime_StartNight(bool stopEvents)
		{
			if (!true)
			{
			}
			int num = 4600;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Main.UpdateTimeRate();
			}
			NPC.ResetBadgerHatTime();
			Star.NightSetup();
			NPC.setFireFlyChance();
			BirthdayParty.CheckNight();
			LanternNight.CheckNight();
			int num2;
			if (num2 == 0)
			{
				bool logicHost = Main.LogicHost;
			}
			bool lanternsUp = LanternNight.LanternsUp;
			int num3 = 1;
			stopEvents.m_value = num3 != 0;
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				bool logicHost2 = Main.LogicHost;
				AchievementsHelper.NotifyProgressionEvent(3);
			}
			if (num3 == 0)
			{
			}
			AchievementsHelper.NotifyProgressionEvent(0);
			if (num3 == 0)
			{
			}
			bool flag = Main.IsFastForwardingTime();
			bool logicHost3 = Main.LogicHost;
			bool logicHost4 = Main.LogicHost;
			int num4;
			if (num4 == 0)
			{
				bool logicHost5 = Main.LogicHost;
				return;
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000CC180 File Offset: 0x000CA380
		public static void UpdateTime_StartDay(bool stopEvents)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WorldGen.ResetTreeShakes();
			if (num == 0)
			{
			}
			Main.UpdateTimeRate();
			Main.AnglerQuestSwap();
			BirthdayParty.CheckMorning();
			LanternNight.CheckMorning();
			bool logicHost = Main.LogicHost;
			AchievementsHelper.NotifyProgressionEvent(5);
			Main.CheckForMoonEventsScoreDisplay();
			Main.CheckForMoonEventsStartingTemporarySeasons();
			Main.checkXMas();
			Main.checkHalloween();
			Main.stopMoonEvent();
			int num2 = 1;
			if (num2 == 0)
			{
			}
			bool logicHost2 = Main.LogicHost;
			bool netHost = Main.NetHost;
			bool logicHost3 = Main.LogicHost;
			AchievementsHelper.NotifyProgressionEvent(1);
			int num3;
			if (num3 != 0)
			{
				int num4;
				if (num4 != 0)
				{
					return;
				}
				Main.StartInvasion(1);
				int num5;
				if (num5 != 0)
				{
					return;
				}
				if (num5 == 0)
				{
				}
				int num6;
				if (num6 != 0)
				{
					int num7;
					while (num7 != 0)
					{
					}
				}
				Main.StartInvasion(3);
				return;
			}
			else
			{
				int num5 = 1;
				AchievementsHelper.NotifyProgressionEvent(2);
				if (num5 != 0)
				{
					if (num5 != 0)
					{
						if (num2 != 0)
						{
							if (num5 == 0)
							{
							}
							return;
						}
					}
					else if (num5 == 0)
					{
					}
					if (num5 == 0)
					{
					}
					if (num5 == 0)
					{
					}
					return;
				}
				bool netHost2 = Main.NetHost;
				return;
			}
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000CC2A4 File Offset: 0x000CA4A4
		private static void HandleMeteorFall()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num2;
				if (num != 0)
				{
					num2 = 1;
					num.m_value = num2;
					return;
				}
				if (num2 != 0)
				{
					return;
				}
			}
			WorldGen.dropMeteor();
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000CC2DC File Offset: 0x000CA4DC
		private static void UpdateSlimeRainWarning()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000CC314 File Offset: 0x000CA514
		public static BestiaryUnlockProgressReport GetBestiaryProgressReport()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000CC328 File Offset: 0x000CA528
		private static void UpdateTime_SpawnTownNPCs()
		{
			if (!true)
			{
			}
			int worldUpdateRate = WorldGen.GetWorldUpdateRate();
			bool logicHost = Main.LogicHost;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000CC5F8 File Offset: 0x000CA7F8
		public static int DamageVar(float dmg, float luck = 0f)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000021DB File Offset: 0x000003DB
		public static double CalculateDamageNPCsTake(int Damage, int Defense)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000021DB File Offset: 0x000003DB
		public static double CalculateDamagePlayersTakeInPVP(int Damage, int Defense)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000CC610 File Offset: 0x000CA810
		public static double CalculateDamagePlayersTake(int Damage, int Defense)
		{
			/*
An exception occurred when decompiling this method (06002071)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.Main::CalculateDamagePlayersTake(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:bool(var_2_13, callgetter:bool(Main::get_expertMode))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000CC630 File Offset: 0x000CA830
		public void OnTileChangeEvent(int x, int y, int count, TileChangeType eventType)
		{
			if (!true)
			{
			}
			WorldGen.PlayLiquidChangeSound(eventType, x, y, count);
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x000CC64C File Offset: 0x000CA84C
		public static void ClearPendingPlayerSelectCallbacks()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000CC65C File Offset: 0x000CA85C
		public static void SelectPlayer(PlayerFileData data)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Lighting.ResetLighting();
			if (num != 0)
			{
				return;
			}
			Main.menuMode = 446;
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			Main.clrInput();
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000CC6B8 File Offset: 0x000CA8B8
		public static void ToggleFullScreen()
		{
			if (!true)
			{
			}
			bool flag;
			Main.SetFullScreen(flag);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000CC6D0 File Offset: 0x000CA8D0
		public static void SetFullScreen(bool fullscreen)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000CC6E0 File Offset: 0x000CA8E0
		public static void SetResolution(int width, int height)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000CC6F0 File Offset: 0x000CA8F0
		public static void SetDisplayMode(int width, int height, bool fullscreen)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			GraphicsDevice graphicsDevice;
			Viewport viewport = graphicsDevice.Viewport;
			GraphicsDevice graphicsDevice2;
			Viewport viewport2 = graphicsDevice2.Viewport;
			GraphicsDevice graphicsDevice3;
			Viewport viewport3 = graphicsDevice3.Viewport;
			GraphicsDevice graphicsDevice4;
			Viewport viewport4 = graphicsDevice4.Viewport;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			Main.mapTime = 0;
			Main.renderNow = true;
			Main.screenWidth = width;
			Main.screenHeight = height;
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			PlayerInput.CacheOriginalScreenDimensions();
			Main.FixUIScale();
			if (height != 0)
			{
				int screenWidth3 = Main.screenWidth;
				int screenHeight3 = Main.screenHeight;
			}
			int screenWidth4 = Main.screenWidth;
			int screenHeight4 = Main.screenHeight;
			PlayerInput.CacheOriginalScreenDimensions();
			Lighting.Initialize(true);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000CC798 File Offset: 0x000CA998
		public static void FixUIScale()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000CC7AC File Offset: 0x000CA9AC
		public void FullscreenStartup()
		{
			if (!true)
			{
			}
			Preferences configuration = Main.Configuration;
			Preferences configuration2 = Main.Configuration;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000CC7C8 File Offset: 0x000CA9C8
		public void UpdateDisplaySettings()
		{
			if (!true)
			{
			}
			Main.SetResolution(int.MinValue, 42190744);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000CC7E8 File Offset: 0x000CA9E8
		public static void SwitchNetMode(int mode)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000CC7F8 File Offset: 0x000CA9F8
		public static void WeGameRequireExitGame()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000CC808 File Offset: 0x000CAA08
		// Note: this type is marked as 'beforefieldinit'.
		static Main()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int hashCode = Guid.NewGuid().GetHashCode();
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000CCC98 File Offset: 0x000CAE98
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_9()
		{
			this.DrawInterface_7_TownNPCHouseBanners();
			return true;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000CCCAC File Offset: 0x000CAEAC
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_11()
		{
			this.DrawInterface_WorldMouse();
			return true;
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000CCCC0 File Offset: 0x000CAEC0
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_12()
		{
			this.DrawInterface_WorldMouseOver();
			return true;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000CCCD4 File Offset: 0x000CAED4
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_15()
		{
			this.DrawInterface_14_EntityHealthBars();
			return true;
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x000CCCE8 File Offset: 0x000CAEE8
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_17()
		{
			this.DrawInterface_16_MapOrMinimap();
			return true;
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x000CCCFC File Offset: 0x000CAEFC
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_21()
		{
			this.DrawInterface_25_ResourceBars();
			return true;
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x000CCD10 File Offset: 0x000CAF10
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_23()
		{
			this.DrawInterface_28_InfoAccs();
			return true;
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x000CCD24 File Offset: 0x000CAF24
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_24()
		{
			this.DrawInterface_27_Inventory();
			return true;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000CCD38 File Offset: 0x000CAF38
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_25()
		{
			this.DrawInterface_30_Hotbar();
			return true;
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000CCD4C File Offset: 0x000CAF4C
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_26()
		{
			this.GUIChatDraw();
			return true;
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000CCD60 File Offset: 0x000CAF60
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_27()
		{
			this.DrawInterface_21_HairWindow();
			return true;
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000CCD74 File Offset: 0x000CAF74
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_28()
		{
			this.DrawInterface_22_DresserWindow();
			return true;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000CCD88 File Offset: 0x000CAF88
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_29()
		{
			return true;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000CCD98 File Offset: 0x000CAF98
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_30()
		{
			this.DrawInterface_33_MouseText();
			return true;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000CCDAC File Offset: 0x000CAFAC
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_31()
		{
			this.DrawInterface_34_PlayerChat();
			return true;
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x000CCDC0 File Offset: 0x000CAFC0
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_38()
		{
			this.DrawInterface_38_MouseCarriedObject();
			return true;
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000CCDD4 File Offset: 0x000CAFD4
		[CompilerGenerated]
		private bool <SetupDrawInterfaceLayers>b__2162_39()
		{
			return true;
		}

		// Token: 0x040028E9 RID: 10473
		public static bool SettingsEnabled_AutoReuseAllItems;

		// Token: 0x040028EA RID: 10474
		public static int CurrentDrawnEntityShader;

		// Token: 0x040028EB RID: 10475
		public static Entity CurrentDrawnEntity;

		// Token: 0x040028EC RID: 10476
		public static bool LightingEveryFrame;

		// Token: 0x040028ED RID: 10477
		public static bool AllowUnfocusedInputOnGamepad;

		// Token: 0x040028EE RID: 10478
		public static bool CrouchingEnabled;

		// Token: 0x040028EF RID: 10479
		public static Main instance;

		// Token: 0x040028F0 RID: 10480
		public static bool AnnouncementBoxDisabled;

		// Token: 0x040028F1 RID: 10481
		public static int AnnouncementBoxRange;

		// Token: 0x040028F2 RID: 10482
		private static GameModeData _currentGameModeInfo;

		// Token: 0x040028F3 RID: 10483
		public static bool drunkWorld;

		// Token: 0x040028F4 RID: 10484
		public static bool getGoodWorld;

		// Token: 0x040028F5 RID: 10485
		public static Microsoft.Xna.Framework.Vector2 destroyerHB;

		// Token: 0x040028F6 RID: 10486
		public static FileMetadata WorldFileMetadata;

		// Token: 0x040028F7 RID: 10487
		public static PingMapLayer Pings;

		// Token: 0x040028F8 RID: 10488
		public static CreativeUI CreativeMenu;

		// Token: 0x040028F9 RID: 10489
		public static MapIconOverlay MapIcons;

		// Token: 0x040028FA RID: 10490
		private static Microsoft.Xna.Framework.Vector2 _lastPingMousePosition;

		// Token: 0x040028FB RID: 10491
		private static double _lastPingMouseDownTime;

		// Token: 0x040028FC RID: 10492
		private static Main.OnPlayerSelected _pendingCharacterSelect;

		// Token: 0x040028FD RID: 10493
		public static bool drawBackGore;

		// Token: 0x040028FE RID: 10494
		public static ulong LobbyId;

		// Token: 0x040028FF RID: 10495
		public static bool ServerSideCharacter;

		// Token: 0x04002900 RID: 10496
		public static string clientUUID;

		// Token: 0x04002901 RID: 10497
		private static int toolTipDistance;

		// Token: 0x04002902 RID: 10498
		public static float GlobalTimeWrappedHourly;

		// Token: 0x04002903 RID: 10499
		public static bool GlobalTimerPaused;

		// Token: 0x04002904 RID: 10500
		public static GameTime gameTimeCache;

		// Token: 0x04002905 RID: 10501
		public static ulong TileFrameSeed;

		// Token: 0x04002906 RID: 10502
		private static ulong _drawCycleCounter;

		// Token: 0x04002907 RID: 10503
		public static int npcStreamSpeed;

		// Token: 0x04002908 RID: 10504
		public static bool superFast;

		// Token: 0x04002909 RID: 10505
		private static float cameraLerp;

		// Token: 0x0400290A RID: 10506
		private static int cameraLerpTimer;

		// Token: 0x0400290B RID: 10507
		private static int cameraLerpTimeToggle;

		// Token: 0x0400290C RID: 10508
		private static bool cameraGamePadLerp;

		// Token: 0x0400290D RID: 10509
		public static bool[] townNPCCanSpawn;

		// Token: 0x0400290E RID: 10510
		public static int musicBox2;

		// Token: 0x0400290F RID: 10511
		public static int musicBoxNotModifiedByVolume;

		// Token: 0x04002910 RID: 10512
		public static byte HealthBarDrawSettings;

		// Token: 0x04002911 RID: 10513
		public static float wFrCounter;

		// Token: 0x04002912 RID: 10514
		public static float wFrame;

		// Token: 0x04002913 RID: 10515
		public static float upTimer;

		// Token: 0x04002914 RID: 10516
		public static float upTimerMax;

		// Token: 0x04002915 RID: 10517
		public static float upTimerMaxDelay;

		// Token: 0x04002916 RID: 10518
		public static bool drawDiag;

		// Token: 0x04002917 RID: 10519
		public static bool drawRelease;

		// Token: 0x04002918 RID: 10520
		public static bool drawBetterDebug;

		// Token: 0x04002919 RID: 10521
		public static bool betterDebugRelease;

		// Token: 0x0400291A RID: 10522
		public static bool drawToScreen;

		// Token: 0x0400291B RID: 10523
		public static bool targetSet;

		// Token: 0x0400291C RID: 10524
		private static ConcurrentQueue<Action> _mainThreadActions;

		// Token: 0x0400291D RID: 10525
		public static float essScale;

		// Token: 0x0400291E RID: 10526
		public static int essDir;

		// Token: 0x0400291F RID: 10527
		public static float[] cloudBGX;

		// Token: 0x04002920 RID: 10528
		public static float cloudBGAlpha;

		// Token: 0x04002921 RID: 10529
		public static float cloudBGActive;

		// Token: 0x04002922 RID: 10530
		public static int[] cloudBG;

		// Token: 0x04002923 RID: 10531
		public static int[] treeMntBGSet1;

		// Token: 0x04002924 RID: 10532
		public static int[] treeMntBGSet2;

		// Token: 0x04002925 RID: 10533
		public static int[] treeMntBGSet3;

		// Token: 0x04002926 RID: 10534
		public static int[] treeMntBGSet4;

		// Token: 0x04002927 RID: 10535
		public static int[] treeBGSet1;

		// Token: 0x04002928 RID: 10536
		public static int[] treeBGSet2;

		// Token: 0x04002929 RID: 10537
		public static int[] treeBGSet3;

		// Token: 0x0400292A RID: 10538
		public static int[] treeBGSet4;

		// Token: 0x0400292B RID: 10539
		public static int[] corruptBG;

		// Token: 0x0400292C RID: 10540
		public static int[] jungleBG;

		// Token: 0x0400292D RID: 10541
		public static int[] snowMntBG;

		// Token: 0x0400292E RID: 10542
		public static int[] snowBG;

		// Token: 0x0400292F RID: 10543
		public static int[] hallowBG;

		// Token: 0x04002930 RID: 10544
		public static int[] crimsonBG;

		// Token: 0x04002931 RID: 10545
		public static int[] desertBG;

		// Token: 0x04002932 RID: 10546
		public static int[] mushroomBG;

		// Token: 0x04002933 RID: 10547
		public static int oceanBG;

		// Token: 0x04002934 RID: 10548
		public static int[] underworldBG;

		// Token: 0x04002935 RID: 10549
		public static int[] treeX;

		// Token: 0x04002936 RID: 10550
		public static int[] treeStyle;

		// Token: 0x04002937 RID: 10551
		public static int[] caveBackX;

		// Token: 0x04002938 RID: 10552
		public static int[] caveBackStyle;

		// Token: 0x04002939 RID: 10553
		public static int iceBackStyle;

		// Token: 0x0400293A RID: 10554
		public static int hellBackStyle;

		// Token: 0x0400293B RID: 10555
		public static int jungleBackStyle;

		// Token: 0x0400293C RID: 10556
		public static string debugWords;

		// Token: 0x0400293D RID: 10557
		public static bool gamePad;

		// Token: 0x0400293E RID: 10558
		public static bool xMas;

		// Token: 0x0400293F RID: 10559
		public static bool halloween;

		// Token: 0x04002940 RID: 10560
		public static bool forceXMasForToday;

		// Token: 0x04002941 RID: 10561
		public static bool forceHalloweenForToday;

		// Token: 0x04002942 RID: 10562
		public static int snowDust;

		// Token: 0x04002943 RID: 10563
		public static bool changeTheTitle;

		// Token: 0x04002944 RID: 10564
		public static int keyCount;

		// Token: 0x04002945 RID: 10565
		public static string[] keyString;

		// Token: 0x04002946 RID: 10566
		public static int[] keyInt;

		// Token: 0x04002947 RID: 10567
		public static double UpdateTimeAccumulator;

		// Token: 0x04002948 RID: 10568
		public static bool drawSkip;

		// Token: 0x04002949 RID: 10569
		public static int fpsCount;

		// Token: 0x0400294A RID: 10570
		public static Stopwatch fpsTimer;

		// Token: 0x0400294B RID: 10571
		public static int dayRate;

		// Token: 0x0400294C RID: 10572
		public static int desiredWorldTilesUpdateRate;

		// Token: 0x0400294D RID: 10573
		public static int maxScreenW;

		// Token: 0x0400294E RID: 10574
		public static int maxScreenH;

		// Token: 0x0400294F RID: 10575
		public static int minScreenW;

		// Token: 0x04002950 RID: 10576
		public static int minScreenH;

		// Token: 0x04002951 RID: 10577
		public static float iS;

		// Token: 0x04002952 RID: 10578
		public static int buffScanAreaWidth;

		// Token: 0x04002953 RID: 10579
		public static int buffScanAreaHeight;

		// Token: 0x04002954 RID: 10580
		public static float musicPitch;

		// Token: 0x04002955 RID: 10581
		public static int maxMP;

		// Token: 0x04002956 RID: 10582
		public static string[] recentWorld;

		// Token: 0x04002957 RID: 10583
		public static string[] recentIP;

		// Token: 0x04002958 RID: 10584
		public static int[] recentPort;

		// Token: 0x04002959 RID: 10585
		public static bool[] recentHardMode;

		// Token: 0x0400295A RID: 10586
		public static short[] recentGameMode;

		// Token: 0x0400295B RID: 10587
		public static bool[] recentCrimson;

		// Token: 0x0400295C RID: 10588
		public static int[] recentSizeX;

		// Token: 0x0400295D RID: 10589
		public static bool[] recentFavorite;

		// Token: 0x0400295E RID: 10590
		public static bool shortRender;

		// Token: 0x0400295F RID: 10591
		public static int ladyBugRainBoost;

		// Token: 0x04002960 RID: 10592
		public const int BG_STYLES_COUNT = 14;

		// Token: 0x04002961 RID: 10593
		public static int EquipPage;

		// Token: 0x04002962 RID: 10594
		public static int EquipPageSelected;

		// Token: 0x04002963 RID: 10595
		public static int wofNPCIndex;

		// Token: 0x04002964 RID: 10596
		public static int wofDrawAreaTop;

		// Token: 0x04002965 RID: 10597
		public static int wofDrawAreaBottom;

		// Token: 0x04002966 RID: 10598
		public static int wofDrawFrameIndex;

		// Token: 0x04002967 RID: 10599
		public static int offScreenRange;

		// Token: 0x04002968 RID: 10600
		public static int maxMapUpdates;

		// Token: 0x04002969 RID: 10601
		public static int textureMaxWidth;

		// Token: 0x0400296A RID: 10602
		public static int textureMaxHeight;

		// Token: 0x0400296B RID: 10603
		public static int mapTargetX;

		// Token: 0x0400296C RID: 10604
		public static int mapTargetY;

		// Token: 0x0400296D RID: 10605
		public static bool[,] initMap;

		// Token: 0x0400296E RID: 10606
		public static float mapMinimapDefaultScale;

		// Token: 0x0400296F RID: 10607
		private static uint _gameUpdateCount;

		// Token: 0x04002970 RID: 10608
		public static bool SkipAssemblyLoad;

		// Token: 0x04002971 RID: 10609
		public static KeyboardState keyState;

		// Token: 0x04002972 RID: 10610
		public static KeyboardState oldKeyState;

		// Token: 0x04002973 RID: 10611
		public static bool craftingHide;

		// Token: 0x04002974 RID: 10612
		public static bool armorHide;

		// Token: 0x04002975 RID: 10613
		public static float shimmerAlpha;

		// Token: 0x04002976 RID: 10614
		public static float shimmerDarken;

		// Token: 0x04002977 RID: 10615
		public static float shimmerBrightenDelay;

		// Token: 0x04002978 RID: 10616
		public static float craftingAlpha;

		// Token: 0x04002979 RID: 10617
		public static float armorAlpha;

		// Token: 0x0400297A RID: 10618
		public static float[] buffAlpha;

		// Token: 0x0400297B RID: 10619
		public static bool hardMode;

		// Token: 0x0400297C RID: 10620
		public static Microsoft.Xna.Framework.Vector2 sceneWaterPos;

		// Token: 0x0400297D RID: 10621
		public static Microsoft.Xna.Framework.Vector2 sceneTilePos;

		// Token: 0x0400297E RID: 10622
		public static Microsoft.Xna.Framework.Vector2 sceneTile2Pos;

		// Token: 0x0400297F RID: 10623
		public static Microsoft.Xna.Framework.Vector2 sceneWallPos;

		// Token: 0x04002980 RID: 10624
		public static Microsoft.Xna.Framework.Vector2 sceneBackgroundPos;

		// Token: 0x04002981 RID: 10625
		public static bool maxQ;

		// Token: 0x04002982 RID: 10626
		public static int DiscoR;

		// Token: 0x04002983 RID: 10627
		public static int DiscoB;

		// Token: 0x04002984 RID: 10628
		public static int DiscoG;

		// Token: 0x04002985 RID: 10629
		public static int teamCooldownLen;

		// Token: 0x04002986 RID: 10630
		public static bool gamePaused;

		// Token: 0x04002987 RID: 10631
		public static bool gameInactive;

		// Token: 0x04002988 RID: 10632
		public static int updatesCountedForFPS;

		// Token: 0x04002989 RID: 10633
		public static int drawsCountedForFPS;

		// Token: 0x0400298A RID: 10634
		public static int uCount;

		// Token: 0x0400298B RID: 10635
		public static int updateRate;

		// Token: 0x0400298C RID: 10636
		public static int frameRate;

		// Token: 0x0400298D RID: 10637
		public static bool RGBRelease;

		// Token: 0x0400298E RID: 10638
		public static bool qRelease;

		// Token: 0x0400298F RID: 10639
		public static bool netRelease;

		// Token: 0x04002990 RID: 10640
		public static bool frameRelease;

		// Token: 0x04002991 RID: 10641
		public static int magmaBGFrame;

		// Token: 0x04002992 RID: 10642
		public static int magmaBGFrameCounter;

		// Token: 0x04002993 RID: 10643
		public static int saveTimer;

		// Token: 0x04002994 RID: 10644
		public static bool autoJoin;

		// Token: 0x04002995 RID: 10645
		public static bool serverStarting;

		// Token: 0x04002996 RID: 10646
		public static float leftWorld;

		// Token: 0x04002997 RID: 10647
		public static float rightWorld;

		// Token: 0x04002998 RID: 10648
		public static float topWorld;

		// Token: 0x04002999 RID: 10649
		public static float bottomWorld;

		// Token: 0x0400299A RID: 10650
		public static int maxTilesX;

		// Token: 0x0400299B RID: 10651
		public static int maxTilesY;

		// Token: 0x0400299C RID: 10652
		public static int maxSectionsX;

		// Token: 0x0400299D RID: 10653
		public static int maxSectionsY;

		// Token: 0x0400299E RID: 10654
		public static int maxDustToDraw;

		// Token: 0x0400299F RID: 10655
		public static int maxNetPlayers;

		// Token: 0x040029A0 RID: 10656
		public static int activePlayerCount;

		// Token: 0x040029A1 RID: 10657
		public static int maxActivePlayers;

		// Token: 0x040029A2 RID: 10658
		public static int maxRain;

		// Token: 0x040029A3 RID: 10659
		public static int slimeWarningTime;

		// Token: 0x040029A4 RID: 10660
		public static int slimeWarningDelay;

		// Token: 0x040029A5 RID: 10661
		public static float slimeRainNPCSlots;

		// Token: 0x040029A6 RID: 10662
		public static bool[] slimeRainNPC;

		// Token: 0x040029A7 RID: 10663
		public static double slimeRainTime;

		// Token: 0x040029A8 RID: 10664
		public static bool slimeRain;

		// Token: 0x040029A9 RID: 10665
		public static int slimeRainKillCount;

		// Token: 0x040029AA RID: 10666
		public static float cameraX;

		// Token: 0x040029AB RID: 10667
		public static int WorldRollingBackupsCountToKeep;

		// Token: 0x040029AC RID: 10668
		public static bool swapMusic;

		// Token: 0x040029AD RID: 10669
		public static int dungeonX;

		// Token: 0x040029AE RID: 10670
		public static int dungeonY;

		// Token: 0x040029AF RID: 10671
		public static Liquid[] liquid;

		// Token: 0x040029B0 RID: 10672
		public static LiquidBuffer[] liquidBuffer;

		// Token: 0x040029B1 RID: 10673
		public static bool dedServ;

		// Token: 0x040029B2 RID: 10674
		public static int spamCount;

		// Token: 0x040029B3 RID: 10675
		public static int newMusic;

		// Token: 0x040029B4 RID: 10676
		public static int curMusic;

		// Token: 0x040029B5 RID: 10677
		public static int dayMusic;

		// Token: 0x040029B6 RID: 10678
		public static int ugMusic;

		// Token: 0x040029B7 RID: 10679
		public static bool bannerMouseOver;

		// Token: 0x040029B8 RID: 10680
		public static string buffString;

		// Token: 0x040029B9 RID: 10681
		public static string libPath;

		// Token: 0x040029BA RID: 10682
		public static int lo;

		// Token: 0x040029BB RID: 10683
		public static int LogoA;

		// Token: 0x040029BC RID: 10684
		public static int LogoB;

		// Token: 0x040029BD RID: 10685
		public static bool LogoT;

		// Token: 0x040029BE RID: 10686
		public static string statusText;

		// Token: 0x040029BF RID: 10687
		public static string worldName;

		// Token: 0x040029C0 RID: 10688
		public static int worldID;

		// Token: 0x040029C1 RID: 10689
		public static Microsoft.Xna.Framework.Graphics.Color tileColor;

		// Token: 0x040029C2 RID: 10690
		public static double worldSurface;

		// Token: 0x040029C3 RID: 10691
		public static double rockLayer;

		// Token: 0x040029C4 RID: 10692
		public static bool dayTime;

		// Token: 0x040029C5 RID: 10693
		public static double time;

		// Token: 0x040029C6 RID: 10694
		public static double timeForVisualEffects;

		// Token: 0x040029C7 RID: 10695
		public static int moonPhase;

		// Token: 0x040029C8 RID: 10696
		public static short sunModY;

		// Token: 0x040029C9 RID: 10697
		public static short moonModY;

		// Token: 0x040029CA RID: 10698
		public static bool alreadyGrabbingSunOrMoon;

		// Token: 0x040029CB RID: 10699
		public static bool bloodMoon;

		// Token: 0x040029CC RID: 10700
		public static bool pumpkinMoon;

		// Token: 0x040029CD RID: 10701
		public static bool snowMoon;

		// Token: 0x040029CE RID: 10702
		public static float cloudAlpha;

		// Token: 0x040029CF RID: 10703
		public static float maxRaining;

		// Token: 0x040029D0 RID: 10704
		public static float oldMaxRaining;

		// Token: 0x040029D1 RID: 10705
		public static int rainTime;

		// Token: 0x040029D2 RID: 10706
		public static bool raining;

		// Token: 0x040029D3 RID: 10707
		public static bool eclipse;

		// Token: 0x040029D4 RID: 10708
		public static float eclipseLight;

		// Token: 0x040029D5 RID: 10709
		public static int checkForSpawns;

		// Token: 0x040029D6 RID: 10710
		public static int helpText;

		// Token: 0x040029D7 RID: 10711
		public static int BartenderHelpTextIndex;

		// Token: 0x040029D8 RID: 10712
		public static float demonTorch;

		// Token: 0x040029D9 RID: 10713
		public static int demonTorchDir;

		// Token: 0x040029DA RID: 10714
		public static float martianLight;

		// Token: 0x040029DB RID: 10715
		public static int martianLightDir;

		// Token: 0x040029DC RID: 10716
		public static float masterColor;

		// Token: 0x040029DD RID: 10717
		public static int masterColorDir;

		// Token: 0x040029DE RID: 10718
		public static int numStars;

		// Token: 0x040029DF RID: 10719
		public static int weatherCounter;

		// Token: 0x040029E0 RID: 10720
		public static int numClouds;

		// Token: 0x040029E1 RID: 10721
		public static int numCloudsTemp;

		// Token: 0x040029E2 RID: 10722
		public static float windSpeedCurrent;

		// Token: 0x040029E3 RID: 10723
		public static float windSpeedTarget;

		// Token: 0x040029E4 RID: 10724
		public static int windCounter;

		// Token: 0x040029E5 RID: 10725
		public static int extremeWindCounter;

		// Token: 0x040029E6 RID: 10726
		public static bool windPhysics;

		// Token: 0x040029E7 RID: 10727
		public static float windPhysicsStrength;

		// Token: 0x040029E8 RID: 10728
		public static Cloud[] cloud;

		// Token: 0x040029E9 RID: 10729
		public static bool resetClouds;

		// Token: 0x040029EA RID: 10730
		public static float SmoothedMushroomLightInfluence;

		// Token: 0x040029EB RID: 10731
		public static int fadeCounter;

		// Token: 0x040029EC RID: 10732
		public static float invAlpha;

		// Token: 0x040029ED RID: 10733
		public static float invDir;

		// Token: 0x040029EE RID: 10734
		public static bool allChestStackHover;

		// Token: 0x040029EF RID: 10735
		public static bool inventorySortMouseOver;

		// Token: 0x040029F0 RID: 10736
		public static int moonType;

		// Token: 0x040029F1 RID: 10737
		public static bool UseExperimentalFeatures;

		// Token: 0x040029F2 RID: 10738
		public static string DefaultSeed;

		// Token: 0x040029F3 RID: 10739
		public static float[] musicFade;

		// Token: 0x040029F4 RID: 10740
		public static HairstyleUnlocksHelper Hairstyles;

		// Token: 0x040029F5 RID: 10741
		public static bool tilesLoaded;

		// Token: 0x040029F6 RID: 10742
		public static TileData tile;

		// Token: 0x040029F7 RID: 10743
		public static Dust[] dust;

		// Token: 0x040029F8 RID: 10744
		public static Star[] star;

		// Token: 0x040029F9 RID: 10745
		public static Item[] item;

		// Token: 0x040029FA RID: 10746
		public static int[] timeItemSlotCannotBeReusedFor;

		// Token: 0x040029FB RID: 10747
		public static NPC[] npc;

		// Token: 0x040029FC RID: 10748
		public static Gore[] gore;

		// Token: 0x040029FD RID: 10749
		public static List<int> BoneJavlinProjectiles;

		// Token: 0x040029FE RID: 10750
		public static List<int> TentacleSpikeProjectiles;

		// Token: 0x040029FF RID: 10751
		public static List<int> DaybreakProjectiles;

		// Token: 0x04002A00 RID: 10752
		public static List<int> StardustCellMinionShotProjectiles;

		// Token: 0x04002A01 RID: 10753
		public static Projectile[] projectile;

		// Token: 0x04002A02 RID: 10754
		public static int[,] projectileIdentity;

		// Token: 0x04002A03 RID: 10755
		public static CombatText[] combatText;

		// Token: 0x04002A04 RID: 10756
		public static Chest[] chest;

		// Token: 0x04002A05 RID: 10757
		public static Sign[] sign;

		// Token: 0x04002A06 RID: 10758
		public static int[] itemFrame;

		// Token: 0x04002A07 RID: 10759
		public static int[] itemFrameCounter;

		// Token: 0x04002A08 RID: 10760
		public static bool screenMaximized;

		// Token: 0x04002A09 RID: 10761
		public static bool screenBorderless;

		// Token: 0x04002A0A RID: 10762
		public static int screenBorderlessPendingResizes;

		// Token: 0x04002A0B RID: 10763
		public static int teamNamePlateDistance;

		// Token: 0x04002A0C RID: 10764
		public static int multiplayerNPCSmoothingRange;

		// Token: 0x04002A0D RID: 10765
		public static bool Setting_UseReducedMaxLiquids;

		// Token: 0x04002A0E RID: 10766
		public static int PlayerOverheadChatMessageDisplayTime;

		// Token: 0x04002A0F RID: 10767
		public static object CurrentInputTextTakerOverride;

		// Token: 0x04002A10 RID: 10768
		public static bool drawingPlayerChat;

		// Token: 0x04002A11 RID: 10769
		public static bool chatRelease;

		// Token: 0x04002A12 RID: 10770
		public static string chatText;

		// Token: 0x04002A13 RID: 10771
		public static bool inputTextEnter;

		// Token: 0x04002A14 RID: 10772
		public static bool inputTextEscape;

		// Token: 0x04002A15 RID: 10773
		public static float[] hotbarScale;

		// Token: 0x04002A16 RID: 10774
		public static byte mouseTextColor;

		// Token: 0x04002A17 RID: 10775
		public static int mouseTextColorChange;

		// Token: 0x04002A18 RID: 10776
		public static bool hasFocus;

		// Token: 0x04002A19 RID: 10777
		public static bool recFastScroll;

		// Token: 0x04002A1A RID: 10778
		public static bool recBigList;

		// Token: 0x04002A1B RID: 10779
		public static int recStart;

		// Token: 0x04002A1C RID: 10780
		public static Recipe[] recipe;

		// Token: 0x04002A1D RID: 10781
		public static float[] availableRecipeY;

		// Token: 0x04002A1E RID: 10782
		public static Player[] player;

		// Token: 0x04002A1F RID: 10783
		public static Player[] playerVisualClone;

		// Token: 0x04002A20 RID: 10784
		public static bool[] countsAsHostForGameplay;

		// Token: 0x04002A21 RID: 10785
		public static int[] travelShop;

		// Token: 0x04002A22 RID: 10786
		public static List<string> anglerWhoFinishedToday;

		// Token: 0x04002A23 RID: 10787
		public static int anglerQuest;

		// Token: 0x04002A24 RID: 10788
		public static AmbienceServer AmbienceServer;

		// Token: 0x04002A25 RID: 10789
		public static ItemDropDatabase ItemDropsDB;

		// Token: 0x04002A26 RID: 10790
		public static BestiaryDatabase BestiaryDB;

		// Token: 0x04002A27 RID: 10791
		public static ItemDropResolver ItemDropSolver;

		// Token: 0x04002A28 RID: 10792
		public static BestiaryUnlocksTracker BestiaryTracker;

		// Token: 0x04002A29 RID: 10793
		public static TeleportPylonsSystem PylonSystem;

		// Token: 0x04002A2A RID: 10794
		public static ShopHelper ShopHelper;

		// Token: 0x04002A2B RID: 10795
		public static bool Support4K;

		// Token: 0x04002A2C RID: 10796
		public static float MinimumZoomComparerX;

		// Token: 0x04002A2D RID: 10797
		public static float MinimumZoomComparerY;

		// Token: 0x04002A2E RID: 10798
		public static int LogicCheckScreenWidth;

		// Token: 0x04002A2F RID: 10799
		public static int LogicCheckScreenHeight;

		// Token: 0x04002A30 RID: 10800
		private static Main.WorldPreparationState _worldPreparationState;

		// Token: 0x04002A31 RID: 10801
		public static float temporaryGUIScaleSlider;

		// Token: 0x04002A32 RID: 10802
		public static bool temporaryGUIScaleSliderUpdate;

		// Token: 0x04002A33 RID: 10803
		public static Item HoverItem;

		// Token: 0x04002A34 RID: 10804
		private static int backSpaceCount;

		// Token: 0x04002A35 RID: 10805
		private static float backSpaceRate;

		// Token: 0x04002A36 RID: 10806
		public static string motd;

		// Token: 0x04002A37 RID: 10807
		public static bool toggleFullscreen;

		// Token: 0x04002A38 RID: 10808
		public static int numDisplayModes;

		// Token: 0x04002A39 RID: 10809
		public static bool menuBGChangedDay;

		// Token: 0x04002A3A RID: 10810
		public static bool menuBGChangedNight;

		// Token: 0x04002A3B RID: 10811
		public static bool lockMenuBGChange;

		// Token: 0x04002A3C RID: 10812
		public static List<WorldFileData> WorldList;

		// Token: 0x04002A3D RID: 10813
		public static WorldFileData ActiveWorldFileData;

		// Token: 0x04002A3E RID: 10814
		public static string CloudWorldPath;

		// Token: 0x04002A3F RID: 10815
		private static string _playerPath;

		// Token: 0x04002A40 RID: 10816
		public static string CloudPlayerPath;

		// Token: 0x04002A41 RID: 10817
		private static string _oldPlayerPath;

		// Token: 0x04002A42 RID: 10818
		private static string _oldWorldPath;

		// Token: 0x04002A43 RID: 10819
		public static KeyboardState inputText;

		// Token: 0x04002A44 RID: 10820
		public static KeyboardState oldInputText;

		// Token: 0x04002A45 RID: 10821
		public static int PendingResolutionWidth;

		// Token: 0x04002A46 RID: 10822
		public static int PendingResolutionHeight;

		// Token: 0x04002A47 RID: 10823
		public static bool PendingBorderlessState;

		// Token: 0x04002A48 RID: 10824
		public static int invasionType;

		// Token: 0x04002A49 RID: 10825
		public static double invasionX;

		// Token: 0x04002A4A RID: 10826
		public static int invasionSize;

		// Token: 0x04002A4B RID: 10827
		public static int invasionDelay;

		// Token: 0x04002A4C RID: 10828
		public static int invasionWarn;

		// Token: 0x04002A4D RID: 10829
		public static int invasionSizeStart;

		// Token: 0x04002A4E RID: 10830
		public static int invasionProgressIcon;

		// Token: 0x04002A4F RID: 10831
		public static int invasionProgress;

		// Token: 0x04002A50 RID: 10832
		public static int invasionProgressMax;

		// Token: 0x04002A51 RID: 10833
		public static int invasionProgressWave;

		// Token: 0x04002A52 RID: 10834
		public static int invasionWaveMax;

		// Token: 0x04002A53 RID: 10835
		public static int invasionProgressDisplayLeft;

		// Token: 0x04002A54 RID: 10836
		public static float invasionProgressAlpha;

		// Token: 0x04002A55 RID: 10837
		public static bool HasInteractibleObjectThatIsNotATile;

		// Token: 0x04002A56 RID: 10838
		public static bool mouseExit;

		// Token: 0x04002A57 RID: 10839
		public static float exitScale;

		// Token: 0x04002A58 RID: 10840
		public static bool mouseReforge;

		// Token: 0x04002A59 RID: 10841
		public static float reforgeScale;

		// Token: 0x04002A5A RID: 10842
		public static Player clientPlayer;

		// Token: 0x04002A5B RID: 10843
		public static string getIP;

		// Token: 0x04002A5C RID: 10844
		public static string getPort;

		// Token: 0x04002A5D RID: 10845
		public static bool menuMultiplayer;

		// Token: 0x04002A5E RID: 10846
		public static bool menuServer;

		// Token: 0x04002A5F RID: 10847
		public static int netMode;

		// Token: 0x04002A60 RID: 10848
		private static int _targetNetMode;

		// Token: 0x04002A61 RID: 10849
		private static bool _hasPendingNetmodeChange;

		// Token: 0x04002A62 RID: 10850
		public static int netPlayCounter;

		// Token: 0x04002A63 RID: 10851
		public static int lastNPCUpdate;

		// Token: 0x04002A64 RID: 10852
		public static int lastItemUpdate;

		// Token: 0x04002A65 RID: 10853
		public static int maxNPCUpdates;

		// Token: 0x04002A66 RID: 10854
		public static int maxItemUpdates;

		// Token: 0x04002A67 RID: 10855
		public static ColorSlidersSet mouseColorSlider;

		// Token: 0x04002A68 RID: 10856
		public static ColorSlidersSet mouseBorderColorSlider;

		// Token: 0x04002A69 RID: 10857
		public static bool hideUI;

		// Token: 0x04002A6A RID: 10858
		public static bool releaseUI;

		// Token: 0x04002A6B RID: 10859
		public static int FrameSkipMode;

		// Token: 0x04002A6C RID: 10860
		public static bool terrariasFixedTiming;

		// Token: 0x04002A6D RID: 10861
		private int splashCounter;

		// Token: 0x04002A6E RID: 10862
		public static ParticleRenderer ParticleSystem_World_OverPlayers;

		// Token: 0x04002A6F RID: 10863
		public static ParticleRenderer ParticleSystem_World_BehindPlayers;

		// Token: 0x04002A70 RID: 10864
		public static AnchoredEntitiesCollection sittingManager;

		// Token: 0x04002A71 RID: 10865
		public static AnchoredEntitiesCollection sleepingManager;

		// Token: 0x04002A72 RID: 10866
		private static bool shouldSetDefaultUIScale;

		// Token: 0x04002A73 RID: 10867
		private static float newDefaultUIScale;

		// Token: 0x04002A74 RID: 10868
		private static bool _target60FPS;

		// Token: 0x04002A75 RID: 10869
		private static bool startFullscreen;

		// Token: 0x04002A76 RID: 10870
		public static bool CaptureModeDisabled;

		// Token: 0x04002A77 RID: 10871
		public static bool unityMouseOver;

		// Token: 0x04002A78 RID: 10872
		public static bool LocalModeServer;

		// Token: 0x04002A79 RID: 10873
		public static IPlayerRenderer PlayerRenderer;

		// Token: 0x04002A7A RID: 10874
		public static IPlayerRenderer PotionOfReturnRenderer;

		// Token: 0x04002A7B RID: 10875
		public static MapHeadRenderer MapPlayerRenderer;

		// Token: 0x04002A7C RID: 10876
		public static NPCHeadRenderer TownNPCHeadRenderer;

		// Token: 0x04002A7D RID: 10877
		public static NPCHeadRenderer BossNPCHeadRenderer;

		// Token: 0x04002A7E RID: 10878
		private static bool? _overrideForExpertMode;

		// Token: 0x04002A7F RID: 10879
		private static bool? _overrideForMasterMode;

		// Token: 0x04002A80 RID: 10880
		public static int musicError;

		// Token: 0x04002A81 RID: 10881
		public static string oldStatusText;

		// Token: 0x04002A82 RID: 10882
		public static bool localPlayerConnected;

		// Token: 0x04002A83 RID: 10883
		public static bool autoShutdown;

		// Token: 0x04002A84 RID: 10884
		public static bool forceServerShutdown;

		// Token: 0x04002A85 RID: 10885
		public static bool serverBootupInProgress;

		// Token: 0x04002A86 RID: 10886
		public static int sundialCooldown;

		// Token: 0x04002A87 RID: 10887
		public static bool fastForwardTimeToDawn;

		// Token: 0x04002A88 RID: 10888
		public static bool _shouldUseWindyDayMusic;

		// Token: 0x04002A89 RID: 10889
		public static bool _shouldUseStormMusic;

		// Token: 0x04002A8A RID: 10890
		public static bool playOldTile;

		// Token: 0x04002A8B RID: 10891
		public static float ambientWaterfallX;

		// Token: 0x04002A8C RID: 10892
		public static float ambientWaterfallY;

		// Token: 0x04002A8D RID: 10893
		public static float ambientWaterfallStrength;

		// Token: 0x04002A8E RID: 10894
		public static float ambientLavafallX;

		// Token: 0x04002A8F RID: 10895
		public static float ambientLavafallY;

		// Token: 0x04002A90 RID: 10896
		public static float ambientLavafallStrength;

		// Token: 0x04002A91 RID: 10897
		public static float ambientLavaX;

		// Token: 0x04002A92 RID: 10898
		public static float ambientLavaY;

		// Token: 0x04002A93 RID: 10899
		public static float ambientLavaStrength;

		// Token: 0x04002A94 RID: 10900
		public static int ambientCounter;

		// Token: 0x04002A95 RID: 10901
		private static bool _isWaterfallMusicPlaying;

		// Token: 0x04002A96 RID: 10902
		private static bool _isLavafallMusicPlaying;

		// Token: 0x04002A97 RID: 10903
		public static IChatMonitor chatMonitor;

		// Token: 0x04002A98 RID: 10904
		public static int ProjectileUpdateLoopIndex;

		// Token: 0x04002A99 RID: 10905
		public static GameTipsDisplay gameTips;

		// Token: 0x04002A9A RID: 10906
		public static int weatherVaneBobframe;

		// Token: 0x04002A9B RID: 10907
		private static DrKeyboard_Base _keyboard;

		// Token: 0x04002A9C RID: 10908
		private static int _openedFrame;

		// Token: 0x04002A9D RID: 10909
		private static int _maxCharaceters;

		// Token: 0x04002A9E RID: 10910
		public static int selectedPlayer;

		// Token: 0x04002A9F RID: 10911
		public static int selectedWorld;

		// Token: 0x04002AA0 RID: 10912
		public static string newWorldName;

		// Token: 0x04002AA1 RID: 10913
		private static int[] specX;

		// Token: 0x04002AA2 RID: 10914
		private static int[] specY;

		// Token: 0x04002AA3 RID: 10915
		private static List<string> _requiredObjecsForCraftingText;

		// Token: 0x04002AA4 RID: 10916
		private static bool hidePVPIcons;

		// Token: 0x04002AA5 RID: 10917
		public static string hoverItemName;

		// Token: 0x04002AA6 RID: 10918
		public static Microsoft.Xna.Framework.Graphics.Color inventoryBack;

		// Token: 0x04002AA7 RID: 10919
		public static bool mouseText;

		// Token: 0x04002AA8 RID: 10920
		public static int mH;

		// Token: 0x04002AA9 RID: 10921
		private static int lastMouseDrawItem;

		// Token: 0x04002AAA RID: 10922
		private static int lastMouseDrawXOffset;

		// Token: 0x04002AAB RID: 10923
		public static int focusColor;

		// Token: 0x04002AAC RID: 10924
		public static int colorDelay;

		// Token: 0x04002AAD RID: 10925
		public static int setKey;

		// Token: 0x04002AAE RID: 10926
		public static bool autoPass;

		// Token: 0x04002AAF RID: 10927
		public static int menuFocus;

		// Token: 0x04002AB0 RID: 10928
		public static bool blockMouse;

		// Token: 0x04002AB1 RID: 10929
		public static float MenuXMovement;

		// Token: 0x04002AB2 RID: 10930
		public static float MapScale;

		// Token: 0x04002AB3 RID: 10931
		public static bool cancelWormHole;

		// Token: 0x04002AB4 RID: 10932
		public static float lightning;

		// Token: 0x04002AB5 RID: 10933
		private static float lightningDecay;

		// Token: 0x04002AB6 RID: 10934
		private static float lightningSpeed;

		// Token: 0x04002AB7 RID: 10935
		private static int thunderDelay;

		// Token: 0x04002AB8 RID: 10936
		public static int thunderDistance;

		// Token: 0x04002AB9 RID: 10937
		private static float backgroundLayerTransitionSpeed;

		// Token: 0x04002ABA RID: 10938
		public static float atmo;

		// Token: 0x04002ABB RID: 10939
		private static float bgScale;

		// Token: 0x04002ABC RID: 10940
		private static int bgWidthScaled;

		// Token: 0x04002ABD RID: 10941
		public static Microsoft.Xna.Framework.Graphics.Color ColorOfTheSkies;

		// Token: 0x04002ABE RID: 10942
		private static Microsoft.Xna.Framework.Graphics.Color ColorOfSurfaceBackgroundsBase;

		// Token: 0x04002ABF RID: 10943
		private static Microsoft.Xna.Framework.Graphics.Color ColorOfSurfaceBackgroundsModified;

		// Token: 0x04002AC0 RID: 10944
		private static string _oldNetplayStatusText;

		// Token: 0x04002AC1 RID: 10945
		private static TextSnippet[] _netplayStatusTextSnippets;

		// Token: 0x04002AC2 RID: 10946
		private static bool _canShowMeteorFall;

		// Token: 0x04002AC3 RID: 10947
		private const string versionStringBecauseTheyreTheSame = "v1.4.4.9";

		// Token: 0x04002AC4 RID: 10948
		public const int curRelease = 279;

		// Token: 0x04002AC5 RID: 10949
		public static StringBuilder UIStringBuilder;

		// Token: 0x04002AC6 RID: 10950
		public const string assemblyVersionNumber = "1.4.4.9";

		// Token: 0x04002AC7 RID: 10951
		public const string copyrightText = "Copyright © 2022 Re-Logic";

		// Token: 0x04002AC8 RID: 10952
		public const ulong WorldGeneratorVersion = 1198295875585UL;

		// Token: 0x04002AC9 RID: 10953
		public static Dictionary<string, MinimapFrame> MinimapFrames;

		// Token: 0x04002ACA RID: 10954
		public static Dictionary<string, IPlayerResourcesDisplaySet> PlayerResourcesSets;

		// Token: 0x04002ACB RID: 10955
		public const string TerrariaSaveFolderPath = "Terraria";

		// Token: 0x04002ACC RID: 10956
		public static IAssetRepository Assets;

		// Token: 0x04002ACD RID: 10957
		private bool _musicLoaded;

		// Token: 0x04002ACE RID: 10958
		private bool _artLoaded;

		// Token: 0x04002ACF RID: 10959
		private bool _begunMainAsyncLoad;

		// Token: 0x04002AD0 RID: 10960
		[CompilerGenerated]
		private static bool <CanUpdateGameplay>k__BackingField;

		// Token: 0x04002AD1 RID: 10961
		private static bool GameAskedToQuit;

		// Token: 0x04002AD2 RID: 10962
		public static float ForcedMinimumZoom;

		// Token: 0x04002AD3 RID: 10963
		public static SpriteViewMatrix GameViewMatrix;

		// Token: 0x04002AD4 RID: 10964
		public static SpriteViewMatrix BackgroundViewMatrix;

		// Token: 0x04002AD5 RID: 10965
		private static Matrix _currentWantedZoomMatrix;

		// Token: 0x04002AD6 RID: 10966
		private static Matrix _uiScaleMatrix;

		// Token: 0x04002AD7 RID: 10967
		private static float _uiScaleWanted;

		// Token: 0x04002AD8 RID: 10968
		private static float _uiScaleUsed;

		// Token: 0x04002AD9 RID: 10969
		public static float GameZoomTarget;

		// Token: 0x04002ADA RID: 10970
		public static bool InvisibleCursorForGamepad;

		// Token: 0x04002ADB RID: 10971
		public static bool GamepadDisableCursorItemIconInner;

		// Token: 0x04002ADC RID: 10972
		public static bool GamepadDisableInstructionsDisplay;

		// Token: 0x04002ADD RID: 10973
		private static GameNotificationType _flashNotificationType;

		// Token: 0x04002ADE RID: 10974
		public static string versionNumber;

		// Token: 0x04002ADF RID: 10975
		public static string versionNumber2;

		// Token: 0x04002AE0 RID: 10976
		public static string AutogenSeedName;

		// Token: 0x04002AE1 RID: 10977
		public static Dictionary<int, GameModeData> RegisteredGameModes;

		// Token: 0x04002AE2 RID: 10978
		public static bool tenthAnniversaryWorld;

		// Token: 0x04002AE3 RID: 10979
		public static bool dontStarveWorld;

		// Token: 0x04002AE4 RID: 10980
		public static bool notTheBeesWorld;

		// Token: 0x04002AE5 RID: 10981
		public static bool remixWorld;

		// Token: 0x04002AE6 RID: 10982
		public static bool noTrapsWorld;

		// Token: 0x04002AE7 RID: 10983
		public static bool zenithWorld;

		// Token: 0x04002AE8 RID: 10984
		public static FavoritesFile CloudFavoritesData;

		// Token: 0x04002AE9 RID: 10985
		public static UserInterface MenuUI;

		// Token: 0x04002AEA RID: 10986
		public static UserInterface InGameUI;

		// Token: 0x04002AEB RID: 10987
		public static bool ContentLoaded;

		// Token: 0x04002AEC RID: 10988
		[CompilerGenerated]
		private static ulong <UnpausedUpdateSeed>k__BackingField;

		// Token: 0x04002AED RID: 10989
		public static ContentManager ShaderContentManager;

		// Token: 0x04002AEE RID: 10990
		public static Ref<Effect> ScreenShaderRef;

		// Token: 0x04002AEF RID: 10991
		public static Ref<Effect> PixelShaderRef;

		// Token: 0x04002AF0 RID: 10992
		public static Ref<Effect> TileShaderRef;

		// Token: 0x04002AF1 RID: 10993
		public static Ref<Effect> VertexPixelShaderRef;

		// Token: 0x04002AF2 RID: 10994
		public static List<IEnumerator> DelayedProcesses;

		// Token: 0x04002AF3 RID: 10995
		public static bool dedServFPS;

		// Token: 0x04002AF4 RID: 10996
		public static int dedServCount1;

		// Token: 0x04002AF5 RID: 10997
		public static int dedServCount2;

		// Token: 0x04002AF6 RID: 10998
		public static readonly int offLimitBorderTiles;

		// Token: 0x04002AF7 RID: 10999
		public const int maxMusic = 92;

		// Token: 0x04002AF8 RID: 11000
		public const int MaxBannerTypes = 290;

		// Token: 0x04002AF9 RID: 11001
		public static readonly int maxBackgrounds;

		// Token: 0x04002AFA RID: 11002
		public const int MaxShopIDs = 100;

		// Token: 0x04002AFB RID: 11003
		public static Microsoft.Xna.Framework.Vector2[] OffsetsNPCOffhand;

		// Token: 0x04002AFC RID: 11004
		public static Microsoft.Xna.Framework.Vector2[] OffsetsPlayerOffhand;

		// Token: 0x04002AFD RID: 11005
		public static Microsoft.Xna.Framework.Vector2[] OffsetsPlayerOnhand;

		// Token: 0x04002AFE RID: 11006
		public static Microsoft.Xna.Framework.Vector2[] OffsetsPlayerHeadgear;

		// Token: 0x04002AFF RID: 11007
		public static bool noWindowBorder;

		// Token: 0x04002B00 RID: 11008
		public static RasterizerState Rasterizer;

		// Token: 0x04002B01 RID: 11009
		private string _cachedTitle;

		// Token: 0x04002B02 RID: 11010
		public static bool skipMenu;

		// Token: 0x04002B03 RID: 11011
		public static bool verboseNetplay;

		// Token: 0x04002B04 RID: 11012
		public static bool stopTimeOuts;

		// Token: 0x04002B05 RID: 11013
		public static bool showSpam;

		// Token: 0x04002B06 RID: 11014
		public static bool showItemOwner;

		// Token: 0x04002B07 RID: 11015
		public static bool runningCollectorsEdition;

		// Token: 0x04002B08 RID: 11016
		public static bool shouldDrawNetDiagnosticsUI;

		// Token: 0x04002B09 RID: 11017
		private static INetDiagnosticsUI _activeNetDiagnosticsUI;

		// Token: 0x04002B0A RID: 11018
		public static IMultiplayerClosePlayersOverlay ActiveClosePlayersTeamOverlay;

		// Token: 0x04002B0B RID: 11019
		public bool gammaTest;

		// Token: 0x04002B0C RID: 11020
		private const bool USE_ASYNC_LOAD = true;

		// Token: 0x04002B0D RID: 11021
		public static bool _isAsyncLoadComplete;

		// Token: 0x04002B0E RID: 11022
		public static bool showSplash;

		// Token: 0x04002B0F RID: 11023
		public static bool ignoreErrors;

		// Token: 0x04002B10 RID: 11024
		public static string defaultIP;

		// Token: 0x04002B11 RID: 11025
		public static int defaultPort;

		// Token: 0x04002B12 RID: 11026
		public static bool[] projHostile;

		// Token: 0x04002B13 RID: 11027
		public static bool[] projHook;

		// Token: 0x04002B14 RID: 11028
		public static bool[] pvpBuff;

		// Token: 0x04002B15 RID: 11029
		public static bool[] persistentBuff;

		// Token: 0x04002B16 RID: 11030
		public static bool[] vanityPet;

		// Token: 0x04002B17 RID: 11031
		public static bool[] lightPet;

		// Token: 0x04002B18 RID: 11032
		public static bool[] meleeBuff;

		// Token: 0x04002B19 RID: 11033
		public static bool[] debuff;

		// Token: 0x04002B1A RID: 11034
		public static bool[] buffNoSave;

		// Token: 0x04002B1B RID: 11035
		public static bool[] buffNoTimeDisplay;

		// Token: 0x04002B1C RID: 11036
		public static bool[] buffDoubleApply;

		// Token: 0x04002B1D RID: 11037
		private RenderTarget2D backWaterTarget;

		// Token: 0x04002B1E RID: 11038
		public static RenderTarget2D waterTarget;

		// Token: 0x04002B1F RID: 11039
		private RenderTarget2D tileTarget;

		// Token: 0x04002B20 RID: 11040
		private RenderTarget2D blackTarget;

		// Token: 0x04002B21 RID: 11041
		private RenderTarget2D tile2Target;

		// Token: 0x04002B22 RID: 11042
		private RenderTarget2D wallTarget;

		// Token: 0x04002B23 RID: 11043
		private RenderTarget2D backgroundTarget;

		// Token: 0x04002B24 RID: 11044
		public static RenderTarget2D screenTarget;

		// Token: 0x04002B25 RID: 11045
		public static RenderTarget2D screenTargetSwap;

		// Token: 0x04002B26 RID: 11046
		private RenderTarget2D[,] mapTarget;

		// Token: 0x04002B27 RID: 11047
		private RenderTarget2D mapSectionTexture;

		// Token: 0x04002B28 RID: 11048
		public static bool[,] mapWasContentLost;

		// Token: 0x04002B29 RID: 11049
		public const int numInfoIcons = 13;

		// Token: 0x04002B2A RID: 11050
		public static Microsoft.Xna.Framework.Graphics.Color OurFavoriteColor;

		// Token: 0x04002B2B RID: 11051
		[CompilerGenerated]
		private static Action OnEnginePreload;

		// Token: 0x04002B2C RID: 11052
		private static bool IsEnginePreloaded;

		// Token: 0x04002B2D RID: 11053
		[CompilerGenerated]
		private static Action<Microsoft.Xna.Framework.Vector2> OnResolutionChanged;

		// Token: 0x04002B2E RID: 11054
		[CompilerGenerated]
		private static Action OnEngineLoad;

		// Token: 0x04002B2F RID: 11055
		private static bool IsEngineLoaded;

		// Token: 0x04002B30 RID: 11056
		[CompilerGenerated]
		private static Action OnTickForThirdPartySoftwareOnly;

		// Token: 0x04002B31 RID: 11057
		[CompilerGenerated]
		private static Action OnTickForInternalCodeOnly;

		// Token: 0x04002B32 RID: 11058
		[CompilerGenerated]
		private static Action<GameTime> OnPreDraw;

		// Token: 0x04002B33 RID: 11059
		[CompilerGenerated]
		private static Action<GameTime> OnPostDraw;

		// Token: 0x04002B34 RID: 11060
		[CompilerGenerated]
		private static Action<Microsoft.Xna.Framework.Vector2, float> OnPostFullscreenMapDraw;

		// Token: 0x04002B35 RID: 11061
		[CompilerGenerated]
		private static Action OnRenderTargetsReleased;

		// Token: 0x04002B36 RID: 11062
		[CompilerGenerated]
		private static ResolutionChangeEvent OnRenderTargetsInitialized;

		// Token: 0x04002B37 RID: 11063
		private double bgParallax;

		// Token: 0x04002B38 RID: 11064
		private int bgStartX;

		// Token: 0x04002B39 RID: 11065
		private int bgLoops;

		// Token: 0x04002B3A RID: 11066
		private int bgStartY;

		// Token: 0x04002B3B RID: 11067
		private int bgLoopsY;

		// Token: 0x04002B3C RID: 11068
		private int bgTopY;

		// Token: 0x04002B3D RID: 11069
		private const int MF_BYPOSITION = 1024;

		// Token: 0x04002B3E RID: 11070
		public static GraphicsDeviceManager graphics;

		// Token: 0x04002B3F RID: 11071
		public static SpriteBatch spriteBatch;

		// Token: 0x04002B40 RID: 11072
		public static SpriteBatch spriteBatch2;

		// Token: 0x04002B41 RID: 11073
		public static TileBatch tileBatch;

		// Token: 0x04002B42 RID: 11074
		public static BasicDebugDrawer DebugDrawer;

		// Token: 0x04002B43 RID: 11075
		public static SamplerState SamplerStateForCursor;

		// Token: 0x04002B44 RID: 11076
		public static GenerationProgress AutogenProgress;

		// Token: 0x04002B45 RID: 11077
		private static Process tServer;

		// Token: 0x04002B46 RID: 11078
		public static Microsoft.Xna.Framework.Graphics.Color mcColor;

		// Token: 0x04002B47 RID: 11079
		public static Microsoft.Xna.Framework.Graphics.Color hcColor;

		// Token: 0x04002B48 RID: 11080
		public static Microsoft.Xna.Framework.Graphics.Color creativeModeColor;

		// Token: 0x04002B49 RID: 11081
		public static Microsoft.Xna.Framework.Graphics.Color legendaryModeColor;

		// Token: 0x04002B4A RID: 11082
		public static Microsoft.Xna.Framework.Graphics.Color highVersionColor;

		// Token: 0x04002B4B RID: 11083
		public static Microsoft.Xna.Framework.Graphics.Color errorColor;

		// Token: 0x04002B4C RID: 11084
		public static bool afterPartyOfDoom;

		// Token: 0x04002B4D RID: 11085
		public float chestLootScale;

		// Token: 0x04002B4E RID: 11086
		public bool chestLootHover;

		// Token: 0x04002B4F RID: 11087
		public float chestStackScale;

		// Token: 0x04002B50 RID: 11088
		public bool chestStackHover;

		// Token: 0x04002B51 RID: 11089
		public float chestDepositScale;

		// Token: 0x04002B52 RID: 11090
		public bool chestDepositHover;

		// Token: 0x04002B53 RID: 11091
		public float chestRenameScale;

		// Token: 0x04002B54 RID: 11092
		public bool chestRenameHover;

		// Token: 0x04002B55 RID: 11093
		public float chestCancelScale;

		// Token: 0x04002B56 RID: 11094
		public bool chestCancelHover;

		// Token: 0x04002B57 RID: 11095
		public int DiscoStyle;

		// Token: 0x04002B58 RID: 11096
		public const int sectionWidth = 200;

		// Token: 0x04002B59 RID: 11097
		public const int sectionHeight = 150;

		// Token: 0x04002B5A RID: 11098
		public const int maxDust = 6000;

		// Token: 0x04002B5B RID: 11099
		public const int maxCombatText = 100;

		// Token: 0x04002B5C RID: 11100
		public const int maxItemText = 20;

		// Token: 0x04002B5D RID: 11101
		public const int maxPlayers = 255;

		// Token: 0x04002B5E RID: 11102
		public const int maxChests = 8000;

		// Token: 0x04002B5F RID: 11103
		public const int maxItems = 400;

		// Token: 0x04002B60 RID: 11104
		public const int maxProjectiles = 1000;

		// Token: 0x04002B61 RID: 11105
		public const int maxNPCs = 200;

		// Token: 0x04002B62 RID: 11106
		private const double slimeRainMaxTime = 54000.0;

		// Token: 0x04002B63 RID: 11107
		private const double slimeRainMinTime = 32400.0;

		// Token: 0x04002B64 RID: 11108
		private const double slimeRainMaxDelay = 604800.0;

		// Token: 0x04002B65 RID: 11109
		private const double slimeRainMinDelay = 302400.0;

		// Token: 0x04002B66 RID: 11110
		private const double LeinforsBalanceRequestForSlimeRainChance = 1.0416666666666667;

		// Token: 0x04002B67 RID: 11111
		private const double slimeRainChance = 450000.00000000006;

		// Token: 0x04002B68 RID: 11112
		public const int maxGore = 600;

		// Token: 0x04002B69 RID: 11113
		public const int InventoryItemSlotsStart = 0;

		// Token: 0x04002B6A RID: 11114
		public const int InventoryItemSlotsCount = 50;

		// Token: 0x04002B6B RID: 11115
		public const int InventoryCoinSlotsStart = 50;

		// Token: 0x04002B6C RID: 11116
		public const int InventoryCoinSlotsCount = 4;

		// Token: 0x04002B6D RID: 11117
		public const int InventoryAmmoSlotsStart = 54;

		// Token: 0x04002B6E RID: 11118
		public const int InventoryAmmoSlotsCount = 4;

		// Token: 0x04002B6F RID: 11119
		public const int InventorySlotsTotal = 58;

		// Token: 0x04002B70 RID: 11120
		public int invBottom;

		// Token: 0x04002B71 RID: 11121
		public const int maxLiquidTypes = 15;

		// Token: 0x04002B72 RID: 11122
		public static bool useBackupFiles;

		// Token: 0x04002B73 RID: 11123
		public static bool validateSaves;

		// Token: 0x04002B74 RID: 11124
		public static Microsoft.Xna.Framework.Graphics.Color[] teamColor;

		// Token: 0x04002B75 RID: 11125
		public const double dayLength = 54000.0;

		// Token: 0x04002B76 RID: 11126
		public const double nightLength = 32400.0;

		// Token: 0x04002B77 RID: 11127
		public static bool autoGen;

		// Token: 0x04002B78 RID: 11128
		public static int[] projFrames;

		// Token: 0x04002B79 RID: 11129
		public static bool[] projPet;

		// Token: 0x04002B7A RID: 11130
		public const int maxStars = 400;

		// Token: 0x04002B7B RID: 11131
		public const int maxStarTypes = 4;

		// Token: 0x04002B7C RID: 11132
		public const int maxClouds = 200;

		// Token: 0x04002B7D RID: 11133
		[ThreadStatic]
		public static UnifiedRandom rand;

		// Token: 0x04002B7E RID: 11134
		public const int maxMoons = 9;

		// Token: 0x04002B7F RID: 11135
		public const int numTileColors = 32;

		// Token: 0x04002B80 RID: 11136
		public const int numTreeStyles = 32;

		// Token: 0x04002B81 RID: 11137
		public const int numberOfHairstyles = 165;

		// Token: 0x04002B82 RID: 11138
		public const int maxHairStyles = 165;

		// Token: 0x04002B83 RID: 11139
		public const int maxCharSelectHair = 51;

		// Token: 0x04002B84 RID: 11140
		public const int maxHairOfStylistDefault = 123;

		// Token: 0x04002B85 RID: 11141
		public static IAudioSystem audioSystem;

		// Token: 0x04002B86 RID: 11142
		public static bool[] musicNoCrossFade;

		// Token: 0x04002B87 RID: 11143
		public static ServerMode MenuServerMode;

		// Token: 0x04002B88 RID: 11144
		public static bool[] tileLighted;

		// Token: 0x04002B89 RID: 11145
		public static bool[] tileMergeDirt;

		// Token: 0x04002B8A RID: 11146
		public static bool[] tileCut;

		// Token: 0x04002B8B RID: 11147
		public static bool[] tileAlch;

		// Token: 0x04002B8C RID: 11148
		public static int[] tileShine;

		// Token: 0x04002B8D RID: 11149
		public static bool[] tileShine2;

		// Token: 0x04002B8E RID: 11150
		public static bool[] wallHouse;

		// Token: 0x04002B8F RID: 11151
		public static bool[] wallDungeon;

		// Token: 0x04002B90 RID: 11152
		public static bool[] wallLight;

		// Token: 0x04002B91 RID: 11153
		public static bool[] wallLighted;

		// Token: 0x04002B92 RID: 11154
		public static int[] wallBlend;

		// Token: 0x04002B93 RID: 11155
		public static bool[] tileStone;

		// Token: 0x04002B94 RID: 11156
		public static bool[] tileAxe;

		// Token: 0x04002B95 RID: 11157
		public static bool[] tileHammer;

		// Token: 0x04002B96 RID: 11158
		public static bool[] tileWaterDeath;

		// Token: 0x04002B97 RID: 11159
		public static bool[] tileLavaDeath;

		// Token: 0x04002B98 RID: 11160
		public static bool[] tileTable;

		// Token: 0x04002B99 RID: 11161
		public static bool[] tileBlockLight;

		// Token: 0x04002B9A RID: 11162
		public static bool[] tileNoSunLight;

		// Token: 0x04002B9B RID: 11163
		public static bool[] tileDungeon;

		// Token: 0x04002B9C RID: 11164
		public static bool[] tileSpelunker;

		// Token: 0x04002B9D RID: 11165
		public static bool[] tileSolidTop;

		// Token: 0x04002B9E RID: 11166
		public static bool[] tileSolid;

		// Token: 0x04002B9F RID: 11167
		public static bool[] tileBouncy;

		// Token: 0x04002BA0 RID: 11168
		public static short[] tileOreFinderPriority;

		// Token: 0x04002BA1 RID: 11169
		public static byte[] tileLargeFrames;

		// Token: 0x04002BA2 RID: 11170
		public static byte[] wallLargeFrames;

		// Token: 0x04002BA3 RID: 11171
		public static bool[] tileRope;

		// Token: 0x04002BA4 RID: 11172
		public static bool[] tileBrick;

		// Token: 0x04002BA5 RID: 11173
		public static bool[] tileMoss;

		// Token: 0x04002BA6 RID: 11174
		public static bool[] tileNoAttach;

		// Token: 0x04002BA7 RID: 11175
		public static bool[] tileNoFail;

		// Token: 0x04002BA8 RID: 11176
		public static bool[] tileCracked;

		// Token: 0x04002BA9 RID: 11177
		public static bool[] tileObsidianKill;

		// Token: 0x04002BAA RID: 11178
		public static bool[] tileFrameImportant;

		// Token: 0x04002BAB RID: 11179
		public static bool[] tilePile;

		// Token: 0x04002BAC RID: 11180
		public static bool[] tileBlendAll;

		// Token: 0x04002BAD RID: 11181
		public static short[] tileGlowMask;

		// Token: 0x04002BAE RID: 11182
		public static bool[] tileContainer;

		// Token: 0x04002BAF RID: 11183
		public static bool[] tileSign;

		// Token: 0x04002BB0 RID: 11184
		public static bool[][] tileMerge;

		// Token: 0x04002BB1 RID: 11185
		public static int cageFrames;

		// Token: 0x04002BB2 RID: 11186
		public static bool critterCage;

		// Token: 0x04002BB3 RID: 11187
		public static int[] bunnyCageFrame;

		// Token: 0x04002BB4 RID: 11188
		public static int[] bunnyCageFrameCounter;

		// Token: 0x04002BB5 RID: 11189
		public static int[] squirrelCageFrame;

		// Token: 0x04002BB6 RID: 11190
		public static int[] squirrelCageFrameCounter;

		// Token: 0x04002BB7 RID: 11191
		public static int[] squirrelCageFrameOrange;

		// Token: 0x04002BB8 RID: 11192
		public static int[] squirrelCageFrameCounterOrange;

		// Token: 0x04002BB9 RID: 11193
		public static int[] mallardCageFrame;

		// Token: 0x04002BBA RID: 11194
		public static int[] mallardCageFrameCounter;

		// Token: 0x04002BBB RID: 11195
		public static int[] duckCageFrame;

		// Token: 0x04002BBC RID: 11196
		public static int[] duckCageFrameCounter;

		// Token: 0x04002BBD RID: 11197
		public static int[] grebeCageFrame;

		// Token: 0x04002BBE RID: 11198
		public static int[] grebeCageFrameCounter;

		// Token: 0x04002BBF RID: 11199
		public static int[] seagullCageFrame;

		// Token: 0x04002BC0 RID: 11200
		public static int[] seagullCageFrameCounter;

		// Token: 0x04002BC1 RID: 11201
		public static int[] birdCageFrame;

		// Token: 0x04002BC2 RID: 11202
		public static int[] birdCageFrameCounter;

		// Token: 0x04002BC3 RID: 11203
		public static int[] redBirdCageFrame;

		// Token: 0x04002BC4 RID: 11204
		public static int[] redBirdCageFrameCounter;

		// Token: 0x04002BC5 RID: 11205
		public static int[] blueBirdCageFrame;

		// Token: 0x04002BC6 RID: 11206
		public static int[] blueBirdCageFrameCounter;

		// Token: 0x04002BC7 RID: 11207
		public static int[] macawCageFrame;

		// Token: 0x04002BC8 RID: 11208
		public static int[] macawCageFrameCounter;

		// Token: 0x04002BC9 RID: 11209
		public static byte[,] butterflyCageMode;

		// Token: 0x04002BCA RID: 11210
		public static int[,] butterflyCageFrame;

		// Token: 0x04002BCB RID: 11211
		public static int[,] butterflyCageFrameCounter;

		// Token: 0x04002BCC RID: 11212
		public static int[,] dragonflyJarFrameCounter;

		// Token: 0x04002BCD RID: 11213
		public static int[,] dragonflyJarFrame;

		// Token: 0x04002BCE RID: 11214
		public static int[,] scorpionCageFrame;

		// Token: 0x04002BCF RID: 11215
		public static int[,] scorpionCageFrameCounter;

		// Token: 0x04002BD0 RID: 11216
		public static int[] snailCageFrame;

		// Token: 0x04002BD1 RID: 11217
		public static int[] snailCageFrameCounter;

		// Token: 0x04002BD2 RID: 11218
		public static int[] snail2CageFrame;

		// Token: 0x04002BD3 RID: 11219
		public static int[] snail2CageFrameCounter;

		// Token: 0x04002BD4 RID: 11220
		public static byte[] fishBowlFrameMode;

		// Token: 0x04002BD5 RID: 11221
		public static int[] fishBowlFrame;

		// Token: 0x04002BD6 RID: 11222
		public static int[] fishBowlFrameCounter;

		// Token: 0x04002BD7 RID: 11223
		public static int[] lavaFishBowlFrame;

		// Token: 0x04002BD8 RID: 11224
		public static int[] lavaFishBowlFrameCounter;

		// Token: 0x04002BD9 RID: 11225
		public static int[] frogCageFrame;

		// Token: 0x04002BDA RID: 11226
		public static int[] frogCageFrameCounter;

		// Token: 0x04002BDB RID: 11227
		public static int[] mouseCageFrame;

		// Token: 0x04002BDC RID: 11228
		public static int[] mouseCageFrameCounter;

		// Token: 0x04002BDD RID: 11229
		public static int[] turtleCageFrame;

		// Token: 0x04002BDE RID: 11230
		public static int[] turtleCageFrameCounter;

		// Token: 0x04002BDF RID: 11231
		public static int[] fairyJarFrame;

		// Token: 0x04002BE0 RID: 11232
		public static int[] fairyJarFrameCounter;

		// Token: 0x04002BE1 RID: 11233
		public static byte[,] jellyfishCageMode;

		// Token: 0x04002BE2 RID: 11234
		public static int[,] jellyfishCageFrame;

		// Token: 0x04002BE3 RID: 11235
		public static int[,] jellyfishCageFrameCounter;

		// Token: 0x04002BE4 RID: 11236
		public static int[] wormCageFrame;

		// Token: 0x04002BE5 RID: 11237
		public static int[] wormCageFrameCounter;

		// Token: 0x04002BE6 RID: 11238
		public static int[] maggotCageFrame;

		// Token: 0x04002BE7 RID: 11239
		public static int[] maggotCageFrameCounter;

		// Token: 0x04002BE8 RID: 11240
		public static int[] ratCageFrame;

		// Token: 0x04002BE9 RID: 11241
		public static int[] ratCageFrameCounter;

		// Token: 0x04002BEA RID: 11242
		public static int[] ladybugCageFrame;

		// Token: 0x04002BEB RID: 11243
		public static int[] ladybugCageFrameCounter;

		// Token: 0x04002BEC RID: 11244
		public static int[] penguinCageFrame;

		// Token: 0x04002BED RID: 11245
		public static int[] penguinCageFrameCounter;

		// Token: 0x04002BEE RID: 11246
		public static int[] waterStriderCageFrame;

		// Token: 0x04002BEF RID: 11247
		public static int[] waterStriderCageFrameCounter;

		// Token: 0x04002BF0 RID: 11248
		public static int[] seahorseCageFrame;

		// Token: 0x04002BF1 RID: 11249
		public static int[] seahorseCageFrameCounter;

		// Token: 0x04002BF2 RID: 11250
		public static int[,] slugCageFrame;

		// Token: 0x04002BF3 RID: 11251
		public static int[,] slugCageFrameCounter;

		// Token: 0x04002BF4 RID: 11252
		public static int[] owlCageFrame;

		// Token: 0x04002BF5 RID: 11253
		public static int[] owlCageFrameCounter;

		// Token: 0x04002BF6 RID: 11254
		public static int[] grasshopperCageFrame;

		// Token: 0x04002BF7 RID: 11255
		public static int[] grasshopperCageFrameCounter;

		// Token: 0x04002BF8 RID: 11256
		public static bool[] tileSand;

		// Token: 0x04002BF9 RID: 11257
		public static bool[] tileFlame;

		// Token: 0x04002BFA RID: 11258
		public static bool[] npcCatchable;

		// Token: 0x04002BFB RID: 11259
		public static int[] tileFrame;

		// Token: 0x04002BFC RID: 11260
		public static int[] tileFrameCounter;

		// Token: 0x04002BFD RID: 11261
		public static byte[] wallFrame;

		// Token: 0x04002BFE RID: 11262
		public static byte[] wallFrameCounter;

		// Token: 0x04002BFF RID: 11263
		public static int[] backgroundWidth;

		// Token: 0x04002C00 RID: 11264
		public static int[] backgroundHeight;

		// Token: 0x04002C01 RID: 11265
		public static DrawAnimation[] itemAnimations;

		// Token: 0x04002C02 RID: 11266
		private static DrawAnimation _coinOnWorldAnimation;

		// Token: 0x04002C03 RID: 11267
		private static DrawAnimation _monkStaffT3OnWorldAnimation;

		// Token: 0x04002C04 RID: 11268
		public static List<int> itemAnimationsRegistered;

		// Token: 0x04002C05 RID: 11269
		public static int[] anglerQuestItemNetIDs;

		// Token: 0x04002C06 RID: 11270
		private static int _renderTargetMaxSize;

		// Token: 0x04002C07 RID: 11271
		private static GraphicsProfile _selectedGraphicsProfile;

		// Token: 0x04002C08 RID: 11272
		private static GraphicsProfile _currentGraphicsProfile;

		// Token: 0x04002C09 RID: 11273
		public static int[] displayWidth;

		// Token: 0x04002C0A RID: 11274
		public static int[] displayHeight;

		// Token: 0x04002C0B RID: 11275
		private static int maxLoadPlayer;

		// Token: 0x04002C0C RID: 11276
		private static int maxLoadWorld;

		// Token: 0x04002C0D RID: 11277
		public static int[] npcFrameCount;

		// Token: 0x04002C0E RID: 11278
		public const int MaxTimeout = 120;

		// Token: 0x04002C0F RID: 11279
		public static string cUp;

		// Token: 0x04002C10 RID: 11280
		public static string cLeft;

		// Token: 0x04002C11 RID: 11281
		public static string cDown;

		// Token: 0x04002C12 RID: 11282
		public static string cRight;

		// Token: 0x04002C13 RID: 11283
		public static string cJump;

		// Token: 0x04002C14 RID: 11284
		public static string cThrowItem;

		// Token: 0x04002C15 RID: 11285
		public static string cHeal;

		// Token: 0x04002C16 RID: 11286
		public static string cMana;

		// Token: 0x04002C17 RID: 11287
		public static string cBuff;

		// Token: 0x04002C18 RID: 11288
		public static string cHook;

		// Token: 0x04002C19 RID: 11289
		public static string cTorch;

		// Token: 0x04002C1A RID: 11290
		public static string cInv;

		// Token: 0x04002C1B RID: 11291
		public static string cSmart;

		// Token: 0x04002C1C RID: 11292
		public static string cMount;

		// Token: 0x04002C1D RID: 11293
		public static string cFavoriteKey;

		// Token: 0x04002C1E RID: 11294
		public static string cMapZoomIn;

		// Token: 0x04002C1F RID: 11295
		public static string cMapZoomOut;

		// Token: 0x04002C20 RID: 11296
		public static string cMapAlphaUp;

		// Token: 0x04002C21 RID: 11297
		public static string cMapAlphaDown;

		// Token: 0x04002C22 RID: 11298
		public static string cMapFull;

		// Token: 0x04002C23 RID: 11299
		public static string cMapStyle;

		// Token: 0x04002C24 RID: 11300
		public static Keys FavoriteKey;

		// Token: 0x04002C25 RID: 11301
		public List<int> DrawCacheNPCsMoonMoon;

		// Token: 0x04002C26 RID: 11302
		public List<int> DrawCacheNPCsOverPlayers;

		// Token: 0x04002C27 RID: 11303
		public List<int> DrawCacheNPCProjectiles;

		// Token: 0x04002C28 RID: 11304
		public List<int> DrawCacheNPCsBehindNonSolidTiles;

		// Token: 0x04002C29 RID: 11305
		public List<int> DrawCacheProjsBehindNPCsAndTiles;

		// Token: 0x04002C2A RID: 11306
		public List<int> DrawCacheProjsBehindNPCs;

		// Token: 0x04002C2B RID: 11307
		public List<int> DrawCacheProjsBehindProjectiles;

		// Token: 0x04002C2C RID: 11308
		public List<int> DrawCacheProjsOverWiresUI;

		// Token: 0x04002C2D RID: 11309
		public List<int> DrawCacheProjsOverPlayers;

		// Token: 0x04002C2E RID: 11310
		public List<int> DrawCacheFirstFractals;

		// Token: 0x04002C2F RID: 11311
		private static bool TrialMode;

		// Token: 0x04002C30 RID: 11312
		public static string autoGenFileLocation;

		// Token: 0x04002C31 RID: 11313
		public static bool fastForwardTimeToDusk;

		// Token: 0x04002C32 RID: 11314
		public static int moondialCooldown;

		// Token: 0x04002C33 RID: 11315
		private static Stopwatch splashTimer;

		// Token: 0x04002C34 RID: 11316
		public static GeneralIssueReporter IssueReporter;

		// Token: 0x04002C35 RID: 11317
		private static int AnimateCritterPages;

		// Token: 0x04002C36 RID: 11318
		public static bool PreventUpdatingTargets;

		// Token: 0x04002C37 RID: 11319
		private DateTime lastYield;

		// Token: 0x04002C38 RID: 11320
		private IEnumerator _gameContentLoadProcess;

		// Token: 0x04002C39 RID: 11321
		private int _musicReplayDelay;

		// Token: 0x04002C3A RID: 11322
		private int lastMusicPlayed;

		// Token: 0x04002C3B RID: 11323
		private static float _minWind;

		// Token: 0x04002C3C RID: 11324
		private static float _maxWind;

		// Token: 0x04002C3D RID: 11325
		private static float _minRain;

		// Token: 0x04002C3E RID: 11326
		private static float _maxRain;

		// Token: 0x04002C3F RID: 11327
		private Stopwatch _worldUpdateTimeTester;

		// Token: 0x04002C40 RID: 11328
		private int _perfLastFrame;

		// Token: 0x04002C41 RID: 11329
		private Microsoft.Xna.Framework.Vector2 lastCloudScreenPosition;

		// Token: 0x04002C42 RID: 11330
		public SpelunkerProjectileHelper SpelunkerProjectileHelper;

		// Token: 0x04002C43 RID: 11331
		public ChumBucketProjectileHelper ChumBucketProjectileHelper;

		// Token: 0x04002C44 RID: 11332
		private static int AutoSavePlayerTime;

		// Token: 0x04002C45 RID: 11333
		public static int AutoSaveWorldTime;

		// Token: 0x04002C46 RID: 11334
		private static List<char> removeChars;

		// Token: 0x04002C47 RID: 11335
		public float logoRotation;

		// Token: 0x04002C48 RID: 11336
		public float logoRotationDirection;

		// Token: 0x04002C49 RID: 11337
		public float logoRotationSpeed;

		// Token: 0x04002C4A RID: 11338
		public float logoScale;

		// Token: 0x04002C4B RID: 11339
		public float logoScaleDirection;

		// Token: 0x04002C4C RID: 11340
		public float logoScaleSpeed;

		// Token: 0x04002C4D RID: 11341
		private static int maxMenuItems;

		// Token: 0x04002C4E RID: 11342
		private float[] menuItemScale;

		// Token: 0x04002C4F RID: 11343
		private int focusMenu;

		// Token: 0x04002C50 RID: 11344
		private int selectedMenu;

		// Token: 0x04002C51 RID: 11345
		private int selectedMenu2;

		// Token: 0x04002C52 RID: 11346
		public static int menuSkip;

		// Token: 0x04002C53 RID: 11347
		private static bool _needsLanguageSelect;

		// Token: 0x04002C54 RID: 11348
		private static Item tooltipPrefixComparisonItem;

		// Token: 0x04002C55 RID: 11349
		public int textBlinkerCount;

		// Token: 0x04002C56 RID: 11350
		public int textBlinkerState;

		// Token: 0x04002C57 RID: 11351
		public static long TotalMemory;

		// Token: 0x04002C58 RID: 11352
		public static int TotalMemoryUpdate;

		// Token: 0x04002C59 RID: 11353
		public static int TotalMemotyFullClear;

		// Token: 0x04002C5A RID: 11354
		private static Microsoft.Xna.Framework.Vector3 shimmerShine;

		// Token: 0x04002C5B RID: 11355
		public TilePaintSystemV2 TilePaintSystem;

		// Token: 0x04002C5C RID: 11356
		public TileDrawing TilesRenderer;

		// Token: 0x04002C5D RID: 11357
		public WallDrawing WallsRenderer;

		// Token: 0x04002C5E RID: 11358
		private AmbientWindSystem _ambientWindSys;

		// Token: 0x04002C5F RID: 11359
		private List<Player> _playersThatDrawBehindNPCs;

		// Token: 0x04002C60 RID: 11360
		private List<Player> _playersThatDrawAfterProjectiles;

		// Token: 0x04002C61 RID: 11361
		private List<Player> drawPlayersPotion;

		// Token: 0x04002C62 RID: 11362
		private List<DrawData> _voidLensData;

		// Token: 0x04002C63 RID: 11363
		private List<DrawData> _voidLensDataSillouette;

		// Token: 0x04002C64 RID: 11364
		private List<DrawData> _voidLensDataSillouette2;

		// Token: 0x04002C65 RID: 11365
		private FlameLashDrawer flameLashDrawer;

		// Token: 0x04002C66 RID: 11366
		private MagicMissileDrawer magicMissileDrawer;

		// Token: 0x04002C67 RID: 11367
		private FinalFractalHelper finalFractalHelper;

		// Token: 0x04002C68 RID: 11368
		private RainbowRodDrawer rainbowRodDrawer;

		// Token: 0x04002C69 RID: 11369
		private EmpressBladeDrawer empressBladeDrawer;

		// Token: 0x04002C6A RID: 11370
		private static BlendState _multiplyBlendState;

		// Token: 0x04002C6B RID: 11371
		private static StardewValleyAnimation _stardewAnimation;

		// Token: 0x04002C6C RID: 11372
		private static UnifiedRandom _tempSeededRandom;

		// Token: 0x04002C6D RID: 11373
		private List<int> _occupantsListToDrawNPCHouses;

		// Token: 0x04002C6E RID: 11374
		private List<int> _npcsWithBannersToDraw;

		// Token: 0x04002C6F RID: 11375
		private List<int> _npcTypesThatAlreadyDrewAHead;

		// Token: 0x04002C70 RID: 11376
		private int[] _npcIndexWhoHoldsHeadIndex;

		// Token: 0x04002C71 RID: 11377
		private static bool _preventCraftingBecauseClickWasUsedToChangeFocusedRecipe;

		// Token: 0x04002C72 RID: 11378
		private static int _currentRecipeBeingCrafted;

		// Token: 0x04002C73 RID: 11379
		private bool _needToSetupDrawInterfaceLayers;

		// Token: 0x04002C74 RID: 11380
		private List<GameInterfaceLayer> _gameInterfaceLayers;

		// Token: 0x04002C75 RID: 11381
		private static GameTime _drawInterfaceGameTime;

		// Token: 0x04002C76 RID: 11382
		private byte instrumentMouseFixHack;

		// Token: 0x04002C77 RID: 11383
		private static bool _settingsButtonIsPushedToSide;

		// Token: 0x04002C78 RID: 11384
		private static bool _cannotDrawAccessoriesHorizontally;

		// Token: 0x04002C79 RID: 11385
		private int grabColorSlider;

		// Token: 0x04002C7A RID: 11386
		private static bool _blockFancyUIWhileLoading;

		// Token: 0x04002C7B RID: 11387
		private bool[] menuWide;

		// Token: 0x04002C7C RID: 11388
		private bool _needsMenuUIRecalculation;

		// Token: 0x04002C7D RID: 11389
		public RejectionMenuInfo RejectionMenuInfo;

		// Token: 0x04002C7E RID: 11390
		private float _splashFrameCount;

		// Token: 0x04002C7F RID: 11391
		private bool quickSplash;

		// Token: 0x04002C80 RID: 11392
		private Microsoft.Xna.Framework.Graphics.Color[] backgroundColorSlicesStatic;

		// Token: 0x04002C81 RID: 11393
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x04002C82 RID: 11394
		private ThreadedRenderManager _threadManager;

		// Token: 0x04002C83 RID: 11395
		public ThreadLocal<Main.BackgroundDrawInfo> _currentBackgroundDrawInfo;

		// Token: 0x04002C84 RID: 11396
		private static int _minimapTopRightAnchorOffsetTowardsLeft;

		// Token: 0x04002C85 RID: 11397
		private static int _minimapTopRightAnchorOffsetTowardsBottom;

		// Token: 0x04002C86 RID: 11398
		public bool FlushWater;

		// Token: 0x04002C87 RID: 11399
		private static VertexColors _glowPaintColors;

		// Token: 0x04002C88 RID: 11400
		protected List<Tuple<int, int, ushort>> DrawWiresSpecialTiles;

		// Token: 0x04002C89 RID: 11401
		private static string[] MonolithFilterNames;

		// Token: 0x04002C8A RID: 11402
		private static string[] MonolithSkyNames;

		// Token: 0x04002C8B RID: 11403
		private float screenOff;

		// Token: 0x04002C8C RID: 11404
		private float scAdj;

		// Token: 0x04002C8D RID: 11405
		private float cTop;

		// Token: 0x04002C8E RID: 11406
		private bool _isDrawingOrUpdating;

		// Token: 0x04002C8F RID: 11407
		public static List<INeedRenderTargetContent> ContentThatNeedsRenderTargets;

		// Token: 0x04002C90 RID: 11408
		private static Item clearItem;

		// Token: 0x04002C91 RID: 11409
		private static int _lastFrameFPSCount;

		// Token: 0x04002C92 RID: 11410
		private static bool _cameraPanHasBlackTransition;

		// Token: 0x04002C93 RID: 11411
		public CameraModifierStack CameraModifiers;

		// Token: 0x04002C94 RID: 11412
		public static bool starGame;

		// Token: 0x04002C95 RID: 11413
		public static int starsHit;

		// Token: 0x04002C96 RID: 11414
		private float controllerSunGrabPositionX;

		// Token: 0x04002C97 RID: 11415
		private float controllerSunGrabPositionY;

		// Token: 0x020003F3 RID: 1011
		public static class CurrentFrameFlags
		{
			// Token: 0x04002C98 RID: 11416
			public static int ActivePlayersCount;

			// Token: 0x04002C99 RID: 11417
			public static int SleepingPlayersCount;

			// Token: 0x04002C9A RID: 11418
			public static bool AnyActiveBossNPC;

			// Token: 0x04002C9B RID: 11419
			public static bool HadAnActiveInteractibleProjectile;

			// Token: 0x020003F4 RID: 1012
			public static class Hacks
			{
				// Token: 0x04002C9C RID: 11420
				public static Matrix CurrentBackgroundMatrixForCreditsRoll;
			}
		}

		// Token: 0x020003F5 RID: 1013
		public sealed class OnPlayerSelected : MulticastDelegate
		{
			// Token: 0x06002090 RID: 8336 RVA: 0x000CCDF4 File Offset: 0x000CAFF4
			public OnPlayerSelected(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06002091 RID: 8337 RVA: 0x000CCE54 File Offset: 0x000CB054
			public void Invoke(PlayerFileData player)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06002092 RID: 8338 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(PlayerFileData player, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002093 RID: 8339 RVA: 0x000CCE78 File Offset: 0x000CB078
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x020003F6 RID: 1014
		public enum AutoPauseMode
		{
			// Token: 0x04002C9E RID: 11422
			Disabled,
			// Token: 0x04002C9F RID: 11423
			Menus,
			// Token: 0x04002CA0 RID: 11424
			Inventory
		}

		// Token: 0x020003F7 RID: 1015
		public enum WorldPreparationState
		{
			// Token: 0x04002CA2 RID: 11426
			AwaitingData,
			// Token: 0x04002CA3 RID: 11427
			ProcessingData,
			// Token: 0x04002CA4 RID: 11428
			Ready
		}

		// Token: 0x020003F8 RID: 1016
		public struct MouseTextCache
		{
			// Token: 0x04002CA5 RID: 11429
			public bool noOverride;

			// Token: 0x04002CA6 RID: 11430
			public bool isValid;

			// Token: 0x04002CA7 RID: 11431
			public string cursorText;

			// Token: 0x04002CA8 RID: 11432
			public int rare;

			// Token: 0x04002CA9 RID: 11433
			public byte diff;

			// Token: 0x04002CAA RID: 11434
			public int X;

			// Token: 0x04002CAB RID: 11435
			public int Y;

			// Token: 0x04002CAC RID: 11436
			public int hackedScreenWidth;

			// Token: 0x04002CAD RID: 11437
			public int hackedScreenHeight;

			// Token: 0x04002CAE RID: 11438
			public string buffTooltip;
		}

		// Token: 0x020003F9 RID: 1017
		public class BackgroundDrawInfo
		{
			// Token: 0x06002094 RID: 8340 RVA: 0x000CCE88 File Offset: 0x000CB088
			public BackgroundDrawInfo()
			{
			}

			// Token: 0x04002CAF RID: 11439
			public SpriteBatch backgroundSpriteBatch;

			// Token: 0x04002CB0 RID: 11440
			public Microsoft.Xna.Framework.Graphics.Color[] backgroundColorSlicesStatic;

			// Token: 0x04002CB1 RID: 11441
			public VertexColors bgColors;
		}

		// Token: 0x020003FA RID: 1018
		public struct SceneArea
		{
			// Token: 0x04002CB2 RID: 11442
			public Microsoft.Xna.Framework.Vector2 SceneLocalScreenPositionOffset;

			// Token: 0x04002CB3 RID: 11443
			public float totalWidth;

			// Token: 0x04002CB4 RID: 11444
			public float totalHeight;

			// Token: 0x04002CB5 RID: 11445
			public int bgTopY;
		}

		// Token: 0x020003FB RID: 1019
		public struct InfoToSetBackColor
		{
			// Token: 0x04002CB6 RID: 11446
			public bool isInGameMenuOrIsServer;

			// Token: 0x04002CB7 RID: 11447
			public float CorruptionBiomeInfluence;

			// Token: 0x04002CB8 RID: 11448
			public float CrimsonBiomeInfluence;

			// Token: 0x04002CB9 RID: 11449
			public float JungleBiomeInfluence;

			// Token: 0x04002CBA RID: 11450
			public float MushroomBiomeInfluence;

			// Token: 0x04002CBB RID: 11451
			public float GraveyardInfluence;

			// Token: 0x04002CBC RID: 11452
			public bool BloodMoonActive;

			// Token: 0x04002CBD RID: 11453
			public bool LanternNightActive;
		}

		// Token: 0x020003FC RID: 1020
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002095 RID: 8341 RVA: 0x000CCE9C File Offset: 0x000CB09C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002096 RID: 8342 RVA: 0x000CCEAC File Offset: 0x000CB0AC
			public <>c()
			{
			}

			// Token: 0x06002097 RID: 8343 RVA: 0x000CCEC0 File Offset: 0x000CB0C0
			internal bool <LoadWorlds>b__1785_0(string path)
			{
				if (!true)
				{
				}
				bool flag = path.StartsWith(path, StringComparison.CurrentCultureIgnoreCase);
				return path.EndsWith(".wld", StringComparison.CurrentCultureIgnoreCase);
			}

			// Token: 0x06002098 RID: 8344 RVA: 0x000CCEE8 File Offset: 0x000CB0E8
			internal bool <LoadPlayers>b__1787_0(string path)
			{
				if (!true)
				{
				}
				bool flag = path.StartsWith(path, StringComparison.CurrentCultureIgnoreCase);
				return path.EndsWith(".plr", StringComparison.CurrentCultureIgnoreCase);
			}

			// Token: 0x06002099 RID: 8345 RVA: 0x000021DB File Offset: 0x000003DB
			internal Main.BackgroundDrawInfo <.ctor>b__1839_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600209A RID: 8346 RVA: 0x000CCF10 File Offset: 0x000CB110
			internal void <Initialize>b__1845_0()
			{
				if (!true)
				{
				}
			}

			// Token: 0x0600209B RID: 8347 RVA: 0x000CCF28 File Offset: 0x000CB128
			internal void <Initialize>b__1845_1()
			{
				if (!true)
				{
				}
				if (Main.LocalGolfState != null)
				{
					if (!true)
					{
					}
					Main.LocalGolfState.CancelBallTracking();
					return;
				}
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x000CCF54 File Offset: 0x000CB154
			internal void <ClientInitialize>b__1854_0(LanguageManager languageManager)
			{
				if (!true)
				{
				}
				ItemTooltip.InvalidateTooltips();
			}

			// Token: 0x0600209D RID: 8349 RVA: 0x000CCF6C File Offset: 0x000CB16C
			internal bool <SetupDrawInterfaceLayers>b__2162_0()
			{
				if (!true)
				{
				}
				Main.DrawInterface_0_InterfaceLogic1();
				return true;
			}

			// Token: 0x0600209E RID: 8350 RVA: 0x000CCF84 File Offset: 0x000CB184
			internal bool <SetupDrawInterfaceLayers>b__2162_1()
			{
				if (!true)
				{
				}
				Main.DrawInterface_20_MultiplayerPlayerNames();
				return true;
			}

			// Token: 0x0600209F RID: 8351 RVA: 0x000CCF9C File Offset: 0x000CB19C
			internal bool <SetupDrawInterfaceLayers>b__2162_2()
			{
				if (!true)
				{
				}
				Main.DrawInterface_1_1_DrawEmoteBubblesInWorld();
				return true;
			}

			// Token: 0x060020A0 RID: 8352 RVA: 0x000CCFB4 File Offset: 0x000CB1B4
			internal bool <SetupDrawInterfaceLayers>b__2162_3()
			{
				if (!true)
				{
				}
				Main.DrawInterface_1_2_DrawEntityMarkersInWorld();
				return true;
			}

			// Token: 0x060020A1 RID: 8353 RVA: 0x000CCFCC File Offset: 0x000CB1CC
			internal bool <SetupDrawInterfaceLayers>b__2162_4()
			{
				if (!true)
				{
				}
				Main.DrawInterface_2_SmartCursorTargets();
				return true;
			}

			// Token: 0x060020A2 RID: 8354 RVA: 0x000CCFE4 File Offset: 0x000CB1E4
			internal bool <SetupDrawInterfaceLayers>b__2162_5()
			{
				if (!true)
				{
				}
				Main.DrawInterface_3_LaserRuler();
				return true;
			}

			// Token: 0x060020A3 RID: 8355 RVA: 0x000CCFFC File Offset: 0x000CB1FC
			internal bool <SetupDrawInterfaceLayers>b__2162_6()
			{
				if (!true)
				{
				}
				Main.DrawInterface_4_Ruler();
				return true;
			}

			// Token: 0x060020A4 RID: 8356 RVA: 0x000CD014 File Offset: 0x000CB214
			internal bool <SetupDrawInterfaceLayers>b__2162_7()
			{
				if (!true)
				{
				}
				Main.DrawInterface_5_GamepadLockOn();
				return true;
			}

			// Token: 0x060020A5 RID: 8357 RVA: 0x000CD02C File Offset: 0x000CB22C
			internal bool <SetupDrawInterfaceLayers>b__2162_8()
			{
				if (!true)
				{
				}
				Main.DrawInterface_6_TileGridOption();
				return true;
			}

			// Token: 0x060020A6 RID: 8358 RVA: 0x000CD044 File Offset: 0x000CB244
			internal bool <SetupDrawInterfaceLayers>b__2162_10()
			{
				if (!true)
				{
				}
				Main.DrawInterface_19_SignTileBubble();
				return true;
			}

			// Token: 0x060020A7 RID: 8359 RVA: 0x000CD05C File Offset: 0x000CB25C
			internal bool <SetupDrawInterfaceLayers>b__2162_13()
			{
				if (!true)
				{
				}
				Main.DrawInterface_9_WireSelection();
				return true;
			}

			// Token: 0x060020A8 RID: 8360 RVA: 0x000CD074 File Offset: 0x000CB274
			internal bool <SetupDrawInterfaceLayers>b__2162_14()
			{
				if (!true)
				{
				}
				Main.DrawInterface_13_AchievementCompletePopups();
				return true;
			}

			// Token: 0x060020A9 RID: 8361 RVA: 0x000CD08C File Offset: 0x000CB28C
			internal bool <SetupDrawInterfaceLayers>b__2162_16()
			{
				if (!true)
				{
				}
				Main.DrawInterface_15_InvasionProgressBars();
				return true;
			}

			// Token: 0x060020AA RID: 8362 RVA: 0x000CD0A4 File Offset: 0x000CB2A4
			internal bool <SetupDrawInterfaceLayers>b__2162_18()
			{
				if (!true)
				{
				}
				Main.DrawInterface_17_DiagnoseNet();
				return true;
			}

			// Token: 0x060020AB RID: 8363 RVA: 0x000CD0BC File Offset: 0x000CB2BC
			internal bool <SetupDrawInterfaceLayers>b__2162_19()
			{
				if (!true)
				{
				}
				Main.DrawInterface_18_DiagnoseVideo();
				return true;
			}

			// Token: 0x060020AC RID: 8364 RVA: 0x000CD0D4 File Offset: 0x000CB2D4
			internal bool <SetupDrawInterfaceLayers>b__2162_20()
			{
				if (!true)
				{
				}
				Main.DrawInterface_24_InterfaceLogic2();
				return true;
			}

			// Token: 0x060020AD RID: 8365 RVA: 0x000CD0EC File Offset: 0x000CB2EC
			internal bool <SetupDrawInterfaceLayers>b__2162_22()
			{
				if (!true)
				{
				}
				Main.DrawInterface_26_InterfaceLogic3();
				return true;
			}

			// Token: 0x060020AE RID: 8366 RVA: 0x000CD104 File Offset: 0x000CB304
			internal bool <SetupDrawInterfaceLayers>b__2162_32()
			{
				if (!true)
				{
				}
				Main.DrawInterface_35_YouDied();
				return true;
			}

			// Token: 0x060020AF RID: 8367 RVA: 0x000CD11C File Offset: 0x000CB31C
			internal bool <SetupDrawInterfaceLayers>b__2162_33()
			{
				if (!true)
				{
				}
				Main.DrawInterface_29_SettingsButton();
				return true;
			}

			// Token: 0x060020B0 RID: 8368 RVA: 0x000CD134 File Offset: 0x000CB334
			internal bool <SetupDrawInterfaceLayers>b__2162_34()
			{
				if (!true)
				{
				}
				Main.DrawInterface_32_GamepadRadialHotbars();
				return true;
			}

			// Token: 0x060020B1 RID: 8369 RVA: 0x000CD14C File Offset: 0x000CB34C
			internal bool <SetupDrawInterfaceLayers>b__2162_35()
			{
				if (!true)
				{
				}
				Main.DrawInterface_FinalUI();
				return true;
			}

			// Token: 0x060020B2 RID: 8370 RVA: 0x000CD164 File Offset: 0x000CB364
			internal bool <SetupDrawInterfaceLayers>b__2162_36()
			{
				if (!true)
				{
				}
				Main.DrawInterface_36_Cursor();
				return true;
			}

			// Token: 0x060020B3 RID: 8371 RVA: 0x000CD17C File Offset: 0x000CB37C
			internal bool <SetupDrawInterfaceLayers>b__2162_37()
			{
				if (!true)
				{
				}
				Main.DrawInterface_37_DebugStuff();
				return true;
			}

			// Token: 0x060020B4 RID: 8372 RVA: 0x000CD194 File Offset: 0x000CB394
			internal bool <SetupDrawInterfaceLayers>b__2162_40()
			{
				if (!true)
				{
				}
				Main.DrawInterface_41_InterfaceLogic4();
				return true;
			}

			// Token: 0x04002CBE RID: 11454
			public static readonly Main.<>c <>9;

			// Token: 0x04002CBF RID: 11455
			public static Func<string, bool> <>9__1785_0;

			// Token: 0x04002CC0 RID: 11456
			public static Func<string, bool> <>9__1787_0;

			// Token: 0x04002CC1 RID: 11457
			public static Func<Main.BackgroundDrawInfo> <>9__1839_0;

			// Token: 0x04002CC2 RID: 11458
			public static Action <>9__1845_0;

			// Token: 0x04002CC3 RID: 11459
			public static Action <>9__1845_1;

			// Token: 0x04002CC4 RID: 11460
			public static LanguageChangeCallback <>9__1854_0;

			// Token: 0x04002CC5 RID: 11461
			public static GameInterfaceDrawMethod <>9__2162_0;

			// Token: 0x04002CC6 RID: 11462
			public static GameInterfaceDrawMethod <>9__2162_1;

			// Token: 0x04002CC7 RID: 11463
			public static GameInterfaceDrawMethod <>9__2162_2;

			// Token: 0x04002CC8 RID: 11464
			public static GameInterfaceDrawMethod <>9__2162_3;

			// Token: 0x04002CC9 RID: 11465
			public static GameInterfaceDrawMethod <>9__2162_4;

			// Token: 0x04002CCA RID: 11466
			public static GameInterfaceDrawMethod <>9__2162_5;

			// Token: 0x04002CCB RID: 11467
			public static GameInterfaceDrawMethod <>9__2162_6;

			// Token: 0x04002CCC RID: 11468
			public static GameInterfaceDrawMethod <>9__2162_7;

			// Token: 0x04002CCD RID: 11469
			public static GameInterfaceDrawMethod <>9__2162_8;

			// Token: 0x04002CCE RID: 11470
			public static GameInterfaceDrawMethod <>9__2162_10;

			// Token: 0x04002CCF RID: 11471
			public static GameInterfaceDrawMethod <>9__2162_13;

			// Token: 0x04002CD0 RID: 11472
			public static GameInterfaceDrawMethod <>9__2162_14;

			// Token: 0x04002CD1 RID: 11473
			public static GameInterfaceDrawMethod <>9__2162_16;

			// Token: 0x04002CD2 RID: 11474
			public static GameInterfaceDrawMethod <>9__2162_18;

			// Token: 0x04002CD3 RID: 11475
			public static GameInterfaceDrawMethod <>9__2162_19;

			// Token: 0x04002CD4 RID: 11476
			public static GameInterfaceDrawMethod <>9__2162_20;

			// Token: 0x04002CD5 RID: 11477
			public static GameInterfaceDrawMethod <>9__2162_22;

			// Token: 0x04002CD6 RID: 11478
			public static GameInterfaceDrawMethod <>9__2162_32;

			// Token: 0x04002CD7 RID: 11479
			public static GameInterfaceDrawMethod <>9__2162_33;

			// Token: 0x04002CD8 RID: 11480
			public static GameInterfaceDrawMethod <>9__2162_34;

			// Token: 0x04002CD9 RID: 11481
			public static GameInterfaceDrawMethod <>9__2162_35;

			// Token: 0x04002CDA RID: 11482
			public static GameInterfaceDrawMethod <>9__2162_36;

			// Token: 0x04002CDB RID: 11483
			public static GameInterfaceDrawMethod <>9__2162_37;

			// Token: 0x04002CDC RID: 11484
			public static GameInterfaceDrawMethod <>9__2162_40;
		}

		// Token: 0x020003FD RID: 1021
		[CompilerGenerated]
		private sealed class <LoadContent_Deferred>d__1863 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060020B5 RID: 8373 RVA: 0x000CD1AC File Offset: 0x000CB3AC
			[DebuggerHidden]
			public <LoadContent_Deferred>d__1863(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x060020B6 RID: 8374 RVA: 0x000CD1C8 File Offset: 0x000CB3C8
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060020B7 RID: 8375 RVA: 0x000CD1D8 File Offset: 0x000CB3D8
			private bool MoveNext()
			{
				int num = this.<>1__state;
				Main main = this.<>4__this;
				int num2 = 1;
				this.<>1__state = num2;
				this.<>1__state = num;
				if (num == 0)
				{
				}
				DateTime now = DateTime.Now;
				main.lastYield = now;
				IEnumerator enumerator = AssetInitializer.LoadAssetsWhileInInitialBlackScreen_InSteps();
				this.<initialLoadProcedure>5__5 = enumerator;
				this.<>1__state = num;
				if (num == 0)
				{
				}
				DateTime now2 = DateTime.Now;
				main.lastYield = now2;
				this.<>1__state = num;
				if (num == 0)
				{
				}
				DateTime now3 = DateTime.Now;
				main.lastYield = now3;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Lang.InitializeLegacyLocalization();
				int num3 = 4;
				this.<>1__state = num3;
				if (num3 == 0)
				{
				}
				DateTime now4 = DateTime.Now;
				main.lastYield = now4;
				IEnumerator enumerator2 = main.LoadMusic_InSteps();
				this.<musicLoadProcedure>5__3 = enumerator2;
				int num4 = 1;
				if (!this.<doneLoadingMusic>5__2)
				{
					IEnumerator enumerator3 = this.<musicLoadProcedure>5__3;
					bool flag = this.<doneLoadingMusic>5__2;
					if (flag)
					{
						return;
					}
					if (!flag)
					{
					}
					DateTime now5 = DateTime.Now;
					DateTime lastYield = main.lastYield;
					TimeSpan timeSpan = now5 - lastYield;
					double totalMilliseconds = timeSpan.TotalMilliseconds;
					this.<doneLoadingMusic>5__2 = num4 != 0;
					Main.musicVolume = (float)totalMilliseconds;
					Main.soundVolume = (float)totalMilliseconds;
					DateTime now6 = DateTime.Now;
					main.lastYield = now6;
					int num5 = 1;
					if (!this.<doneinitialLoad>5__4)
					{
						IEnumerator enumerator4 = this.<initialLoadProcedure>5__5;
						this.<doneinitialLoad>5__4 = num5 != 0;
						DateTime now7 = DateTime.Now;
						DateTime lastYield2 = main.lastYield;
						double totalMilliseconds2 = (now7 - lastYield2).TotalMilliseconds;
					}
					int num6 = 6;
					this.<>1__state = num6;
					int num7 = 1;
					int num8 = 1;
					main._begunMainAsyncLoad = num7 != 0;
					AssetInitializer.Load(num8 != 0);
					main._artLoaded = num7 != 0;
					if (num6 == 0)
					{
					}
					if (num6 == 0)
					{
					}
				}
				int num9 = 1;
				main._musicLoaded = num9 != 0;
				if (num9 == 0)
				{
				}
				if (num9 == 0)
				{
					return;
				}
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x060020B8 RID: 8376 RVA: 0x000CD3AC File Offset: 0x000CB5AC
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060020B9 RID: 8377 RVA: 0x000021DB File Offset: 0x000003DB
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x060020BA RID: 8378 RVA: 0x000CD3C0 File Offset: 0x000CB5C0
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04002CDD RID: 11485
			private int <>1__state;

			// Token: 0x04002CDE RID: 11486
			private object <>2__current;

			// Token: 0x04002CDF RID: 11487
			public Main <>4__this;

			// Token: 0x04002CE0 RID: 11488
			private bool <doneLoadingMusic>5__2;

			// Token: 0x04002CE1 RID: 11489
			private IEnumerator <musicLoadProcedure>5__3;

			// Token: 0x04002CE2 RID: 11490
			private bool <doneinitialLoad>5__4;

			// Token: 0x04002CE3 RID: 11491
			private IEnumerator <initialLoadProcedure>5__5;
		}

		// Token: 0x020003FE RID: 1022
		[CompilerGenerated]
		private sealed class <LoadMusic_InSteps>d__1866 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060020BB RID: 8379 RVA: 0x000CD3D4 File Offset: 0x000CB5D4
			[DebuggerHidden]
			public <LoadMusic_InSteps>d__1866(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x060020BC RID: 8380 RVA: 0x000CD3F0 File Offset: 0x000CB5F0
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060020BD RID: 8381 RVA: 0x000CD400 File Offset: 0x000CB600
			private bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (060020BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Main/<LoadMusic_InSteps>d__1866::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004B:
	stloc:int64(var_6_51, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
	stloc:int32(var_7_54, ldc.i4:int32(2))
	stfld:int32('<LoadMusic_InSteps>d__1866'::<>1__state, ldloc:'<LoadMusic_InSteps>d__1866'(this), ldloc:int32(var_7_54))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x060020BE RID: 8382 RVA: 0x000CD470 File Offset: 0x000CB670
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060020BF RID: 8383 RVA: 0x000021DB File Offset: 0x000003DB
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x060020C0 RID: 8384 RVA: 0x000CD484 File Offset: 0x000CB684
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04002CE4 RID: 11492
			private int <>1__state;

			// Token: 0x04002CE5 RID: 11493
			private object <>2__current;

			// Token: 0x04002CE6 RID: 11494
			private int <i>5__2;
		}
	}
}
