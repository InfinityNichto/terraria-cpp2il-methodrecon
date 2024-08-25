using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x0200073C RID: 1852
	public struct MagicMissileDrawer
	{
		// Token: 0x06003D26 RID: 15654 RVA: 0x002387D8 File Offset: 0x002369D8
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

		// Token: 0x06003D27 RID: 15655 RVA: 0x00238838 File Offset: 0x00236A38
		private void StripColors(float progressOnStrip, [Out] Color col)
		{
			if (!true)
			{
			}
			Color color;
			col.A = color;
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x00238854 File Offset: 0x00236A54
		private float StripWidth(float progressOnStrip)
		{
			if (!true)
			{
			}
			float num;
			float lerpValue = Utils.GetLerpValue(MathHelper.Lerp(num, progressOnStrip, num), progressOnStrip, num, 2.3509887E-38f != null);
			return 2.3509887E-38f;
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x00238880 File Offset: 0x00236A80
		// Note: this type is marked as 'beforefieldinit'.
		static MagicMissileDrawer()
		{
		}

		// Token: 0x04007C1A RID: 31770
		private static VertexStrip _vertexStrip;
	}
}
