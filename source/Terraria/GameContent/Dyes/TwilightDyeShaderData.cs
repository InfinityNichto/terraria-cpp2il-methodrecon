using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x0200081E RID: 2078
	public class TwilightDyeShaderData : ArmorShaderData
	{
		// Token: 0x060042AE RID: 17070 RVA: 0x0024BFE4 File Offset: 0x0024A1E4
		public TwilightDyeShaderData(Ref<Effect> shader, string passName)
			: base(shader, passName)
		{
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x0024BFFC File Offset: 0x0024A1FC
		public override void Apply(Entity entity, DrawData? drawData)
		{
			if (entity != null)
			{
			}
		}
	}
}
