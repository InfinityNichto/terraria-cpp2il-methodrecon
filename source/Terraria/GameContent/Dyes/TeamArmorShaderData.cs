using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x0200081D RID: 2077
	public class TeamArmorShaderData : ArmorShaderData
	{
		// Token: 0x060042AB RID: 17067 RVA: 0x0024BFA8 File Offset: 0x0024A1A8
		public TeamArmorShaderData(Ref<Effect> shader, string passName)
			: base(shader, passName)
		{
			ArmorShaderData armorShaderData;
			if (armorShaderData == null || armorShaderData != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x0024BFD0 File Offset: 0x0024A1D0
		public override void Apply(Entity entity, DrawData? drawData)
		{
			if (entity != null)
			{
			}
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000021DB File Offset: 0x000003DB
		public override ArmorShaderData GetSecondaryShader(Entity entity)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040080F0 RID: 33008
		private static bool isInitialized;

		// Token: 0x040080F1 RID: 33009
		private static ArmorShaderData[] dustShaderData;
	}
}
