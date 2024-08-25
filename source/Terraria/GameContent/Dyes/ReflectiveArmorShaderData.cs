using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x0200081C RID: 2076
	public class ReflectiveArmorShaderData : ArmorShaderData
	{
		// Token: 0x060042A9 RID: 17065 RVA: 0x0024BEF4 File Offset: 0x0024A0F4
		public ReflectiveArmorShaderData(Ref<Effect> shader, string passName)
			: base(shader, passName)
		{
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x0024BF0C File Offset: 0x0024A10C
		public override void Apply(Entity entity, DrawData? drawData)
		{
			if (entity != null)
			{
				return;
			}
			EffectParameter effectParameter = base.Shader.<Parameters>k__BackingField["uLightSource"];
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
		}
	}
}
