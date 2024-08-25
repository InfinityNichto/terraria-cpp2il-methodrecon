using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000824 RID: 2084
	public class SepiaScreenShaderData : ScreenShaderData
	{
		// Token: 0x060042BD RID: 17085 RVA: 0x0024C308 File Offset: 0x0024A508
		public SepiaScreenShaderData(string passName)
			: base(passName)
		{
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x0024C31C File Offset: 0x0024A51C
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			float num2;
			double num = Main.starGameMath((double)num2);
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x0024C388 File Offset: 0x0024A588
		private static void GetDaylightPowers([Out] float nightlightPower, [Out] float daylightPower, [Out] float moonPower, [Out] float dawnPower)
		{
			if (!true)
			{
			}
			Vector2 dayTimeAsDirectionIn24HClock = Utils.GetDayTimeAsDirectionIn24HClock();
			Vector2 dayTimeAsDirectionIn24HClock2 = Utils.GetDayTimeAsDirectionIn24HClock(nightlightPower);
			Vector2 dayTimeAsDirectionIn24HClock3 = Utils.GetDayTimeAsDirectionIn24HClock(nightlightPower);
			if (!true)
			{
			}
			float num2;
			float num = Utils.Remap(num2, daylightPower, nightlightPower, daylightPower, nightlightPower, true);
			float num3 = Utils.Remap(num2, nightlightPower, nightlightPower, daylightPower, nightlightPower, true);
			float num5;
			float num4 = Utils.Remap(num5, nightlightPower, nightlightPower, daylightPower, nightlightPower, true);
			float num6 = Utils.Remap(nightlightPower, 0f, nightlightPower, daylightPower, nightlightPower, true);
		}
	}
}
