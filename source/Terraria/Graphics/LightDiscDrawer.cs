using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x0200073D RID: 1853
	public struct LightDiscDrawer
	{
		// Token: 0x06003D2A RID: 15658 RVA: 0x00238890 File Offset: 0x00236A90
		public void Draw(Projectile proj)
		{
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

		// Token: 0x06003D2B RID: 15659 RVA: 0x002388EC File Offset: 0x00236AEC
		private void StripColors(float progressOnStrip, [Out] Color col)
		{
			if (!true)
			{
			}
			Color color2;
			Color color = color2 * progressOnStrip;
			col.A = color;
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x000021DB File Offset: 0x000003DB
		private float StripWidth(float progressOnStrip)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x0023890C File Offset: 0x00236B0C
		// Note: this type is marked as 'beforefieldinit'.
		static LightDiscDrawer()
		{
		}

		// Token: 0x04007C1B RID: 31771
		private static VertexStrip _vertexStrip;
	}
}
