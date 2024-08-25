using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x0200073F RID: 1855
	public struct RainbowRodDrawer
	{
		// Token: 0x06003D32 RID: 15666 RVA: 0x002389DC File Offset: 0x00236BDC
		public void Draw(Projectile proj)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Vector2[] oldPos = proj.oldPos;
			float[] oldRot = proj.oldRot;
			Vector2 screenPosition = Main.screenPosition;
			Vector2 size = proj.Size;
			EffectTechnique <CurrentTechnique>k__BackingField = Main.pixelShader.<CurrentTechnique>k__BackingField;
			long num = 0L;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[(int)num];
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00238A3C File Offset: 0x00236C3C
		private void StripColors(float progressOnStrip, [Out] Color col)
		{
			if (!true)
			{
			}
			Color color;
			col.A = color;
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00238A58 File Offset: 0x00236C58
		private float StripWidth(float progressOnStrip)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00238A6C File Offset: 0x00236C6C
		// Note: this type is marked as 'beforefieldinit'.
		static RainbowRodDrawer()
		{
		}

		// Token: 0x04007C1E RID: 31774
		private static VertexStrip _vertexStrip;
	}
}
