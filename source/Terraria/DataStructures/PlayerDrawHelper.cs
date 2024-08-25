using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x0200063D RID: 1597
	public class PlayerDrawHelper
	{
		// Token: 0x0600365C RID: 13916 RVA: 0x000021DB File Offset: 0x000003DB
		public static int PackShader(int localShaderIndex, PlayerDrawHelper.ShaderConfiguration shaderType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00212B48 File Offset: 0x00210D48
		public static void UnpackShader(int packedShaderIndex, [Out] int localShaderIndex, [Out] PlayerDrawHelper.ShaderConfiguration shaderType)
		{
			int num = 19923;
			shaderType.value__ = num;
			localShaderIndex.m_value = num;
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00212B6C File Offset: 0x00210D6C
		public static bool SetShaderForData(Player player, int cHead, DrawData cdd, EffectPass effectPass)
		{
			if (!true)
			{
			}
			return false;
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00212BF0 File Offset: 0x00210DF0
		public static bool SetShaderForData(Player player, int cHead, DrawData cdd)
		{
			if (!true)
			{
			}
			return false;
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x00212C54 File Offset: 0x00210E54
		public PlayerDrawHelper()
		{
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00212C68 File Offset: 0x00210E68
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDrawHelper()
		{
		}

		// Token: 0x0400770F RID: 30479
		public static Color DISPLAY_DOLL_DEFAULT_SKIN_COLOR;

		// Token: 0x0200063E RID: 1598
		public enum ShaderConfiguration
		{
			// Token: 0x04007711 RID: 30481
			ArmorShader,
			// Token: 0x04007712 RID: 30482
			HairShader,
			// Token: 0x04007713 RID: 30483
			TileShader,
			// Token: 0x04007714 RID: 30484
			TilePaintID,
			// Token: 0x04007715 RID: 30485
			Misc
		}
	}
}
