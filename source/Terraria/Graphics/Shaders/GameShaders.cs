using System;
using System.Collections.Generic;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x02000747 RID: 1863
	public class GameShaders
	{
		// Token: 0x06003D61 RID: 15713 RVA: 0x002390F4 File Offset: 0x002372F4
		public GameShaders()
		{
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00239108 File Offset: 0x00237308
		// Note: this type is marked as 'beforefieldinit'.
		static GameShaders()
		{
		}

		// Token: 0x04007C43 RID: 31811
		public static ArmorShaderDataSet Armor;

		// Token: 0x04007C44 RID: 31812
		public static HairShaderDataSet Hair;

		// Token: 0x04007C45 RID: 31813
		public static Dictionary<string, MiscShaderData> Misc;
	}
}
