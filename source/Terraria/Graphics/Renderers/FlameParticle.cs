using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000758 RID: 1880
	public class FlameParticle : ABasicParticle
	{
		// Token: 0x06003DE3 RID: 15843 RVA: 0x0023A7A4 File Offset: 0x002389A4
		public override void FetchFromPool()
		{
			base.FetchFromPool();
			this.FadeOutNormalizedTime = (float)16256;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x000021DB File Offset: 0x000003DB
		public override void SetBasicInfo(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x0023A7C4 File Offset: 0x002389C4
		public void SetTypeInfo(float timeToLive, int indexOfPlayerWhoSpawnedIt, int packedShaderIndex)
		{
			this._indexOfPlayerWhoSpawnedThis = indexOfPlayerWhoSpawnedIt;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x0023A7D8 File Offset: 0x002389D8
		public override void Update(ParticleRendererSettings settings)
		{
			base.Update(settings);
			float timeTolive = this._timeTolive;
			float timeSinceSpawn = this._timeSinceSpawn;
			this._timeSinceSpawn = timeSinceSpawn;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = true;
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x0023A808 File Offset: 0x00238A08
		public override void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			int num = 1;
			float timeTolive = this._timeTolive;
			float timeSinceSpawn = this._timeSinceSpawn;
			float fadeOutNormalizedTime = this.FadeOutNormalizedTime;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			int num3 = 1;
			Vector2 anchorPosition = settings.AnchorPosition;
			float x = this.LocalPosition.X;
			float y = this.LocalPosition.Y;
			if (num2 == 0)
			{
			}
			float x2 = this.LocalPosition.X;
			float y2 = this.LocalPosition.Y;
			int num4 = 3;
			int num5 = Utils.RandomInt((ulong)4720931368828141568L, num3, num4);
			int num6 = 3;
			int num7 = Utils.RandomInt((ulong)num5, num3, num6);
			Asset<Texture2D> texture = this._texture;
			float x3 = this.Scale.X;
			float y3 = this.Scale.Y;
			if (texture == null)
			{
			}
			Rectangle frame = this._frame;
			int width = this._frame.Width;
			float y4 = this._origin.Y;
			float rotation = this.Rotation;
			float x4 = this._origin.X;
			float x5 = this.Scale.X;
			float y5 = this.Scale.Y;
			int packedShaderIndex = this._packedShaderIndex;
			if (packedShaderIndex == 0)
			{
			}
			if (packedShaderIndex == 0)
			{
			}
			EffectTechnique <CurrentTechnique>k__BackingField = Main.pixelShader.<CurrentTechnique>k__BackingField;
			long num8 = 0L;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[(int)num8];
			if (<CurrentTechnique>k__BackingField == null)
			{
			}
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x0023A96C File Offset: 0x00238B6C
		public FlameParticle()
		{
		}

		// Token: 0x04007C9D RID: 31901
		public float FadeOutNormalizedTime = (float)16256;

		// Token: 0x04007C9E RID: 31902
		private float _timeTolive;

		// Token: 0x04007C9F RID: 31903
		private float _timeSinceSpawn;

		// Token: 0x04007CA0 RID: 31904
		private int _indexOfPlayerWhoSpawnedThis;

		// Token: 0x04007CA1 RID: 31905
		private int _packedShaderIndex;
	}
}
