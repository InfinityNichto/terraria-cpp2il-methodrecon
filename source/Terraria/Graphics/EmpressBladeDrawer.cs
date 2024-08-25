using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x0200073B RID: 1851
	public struct EmpressBladeDrawer
	{
		// Token: 0x06003D22 RID: 15650 RVA: 0x00238738 File Offset: 0x00236938
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
			Vector2[] oldPos2 = proj.oldPos;
			EffectTechnique <CurrentTechnique>k__BackingField = Main.pixelShader.<CurrentTechnique>k__BackingField;
			long num = 0L;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[(int)num];
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x002387A8 File Offset: 0x002369A8
		private void StripColors(float progressOnStrip, [Out] Color col)
		{
			Color colorStart = this.ColorStart;
			if (!true)
			{
			}
			Color color;
			col.A = color;
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x000021DB File Offset: 0x000003DB
		private float StripWidth(float progressOnStrip)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x002387C8 File Offset: 0x002369C8
		// Note: this type is marked as 'beforefieldinit'.
		static EmpressBladeDrawer()
		{
		}

		// Token: 0x04007C15 RID: 31765
		public const int TotalIllusions = 1;

		// Token: 0x04007C16 RID: 31766
		public const int FramesPerImportantTrail = 60;

		// Token: 0x04007C17 RID: 31767
		private static VertexStrip _vertexStrip;

		// Token: 0x04007C18 RID: 31768
		public Color ColorStart;

		// Token: 0x04007C19 RID: 31769
		public Color ColorEnd;
	}
}
