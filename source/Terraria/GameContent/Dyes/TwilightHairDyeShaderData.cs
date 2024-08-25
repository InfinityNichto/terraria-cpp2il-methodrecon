using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x0200081F RID: 2079
	public class TwilightHairDyeShaderData : HairShaderData
	{
		// Token: 0x060042B0 RID: 17072 RVA: 0x0024C018 File Offset: 0x0024A218
		public TwilightHairDyeShaderData(Ref<Effect> shader, string passName)
			: base(shader, passName)
		{
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x0024C030 File Offset: 0x0024A230
		public override void Apply(Player player, [Optional] DrawData? drawData)
		{
			Vector2 screenPosition = Main.screenPosition;
		}
	}
}
