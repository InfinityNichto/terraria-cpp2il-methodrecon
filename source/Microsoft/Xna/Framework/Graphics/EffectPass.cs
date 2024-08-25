using System;
using Cpp2IlInjected;
using Terraria.Graphics.Shaders;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000365 RID: 869
	public class EffectPass
	{
		// Token: 0x060016B1 RID: 5809 RVA: 0x000021DB File Offset: 0x000003DB
		private static int GetNextBatchIndex()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0006334C File Offset: 0x0006154C
		public EffectPass(Effect effect, int passindex, string name, Material material)
		{
			this.PassIndex = passindex;
			this.Name = name;
			this._effect = effect;
			this._material = material;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0006337C File Offset: 0x0006157C
		public EffectPass(Effect effect, EffectPass existing)
		{
			int passIndex = existing.PassIndex;
			string name = existing.Name;
			Material material = existing._material;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000633A0 File Offset: 0x000615A0
		public EffectPass(EffectPass existing, ShaderData armourData)
		{
			int passIndex = existing.PassIndex;
			Material material = existing._material;
			this._armour = armourData;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000633C4 File Offset: 0x000615C4
		public void ApplyValuesToMaterial(Material material)
		{
			if (this._armour != null)
			{
			}
			Effect effect = this._effect;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000633E0 File Offset: 0x000615E0
		public void SetRegion(Vector4 sourceRect, Texture2D texture)
		{
			float[] data = this._effect.<Parameters>k__BackingField["uSourceRect"].Data;
			float[] data2 = this._effect.<Parameters>k__BackingField["uImageSize0"].Data;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00063424 File Offset: 0x00061624
		public void Apply()
		{
		}

		// Token: 0x040024DD RID: 9437
		public static EffectPass BoundEffect;

		// Token: 0x040024DE RID: 9438
		public readonly int PassIndex;

		// Token: 0x040024DF RID: 9439
		public readonly string Name;

		// Token: 0x040024E0 RID: 9440
		private readonly Effect _effect;

		// Token: 0x040024E1 RID: 9441
		public readonly Material _material;

		// Token: 0x040024E2 RID: 9442
		public readonly int BatchIndex;

		// Token: 0x040024E3 RID: 9443
		public readonly ShaderData _armour;

		// Token: 0x040024E4 RID: 9444
		private static int NextBatchIndex;
	}
}
