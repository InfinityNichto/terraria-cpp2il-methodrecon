using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x02000745 RID: 1861
	public class ArmorShaderData : ShaderData
	{
		// Token: 0x06003D4B RID: 15691 RVA: 0x00238DA4 File Offset: 0x00236FA4
		public ArmorShaderData(Ref<Effect> shader, string passName)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this._uSecondaryColor.Z = (float)1;
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._uTargetPosition = 1;
			base..ctor();
			this._shader = shader;
			this._passName = passName;
			!0 value = shader.Value;
			Ref<Effect> shader2 = this._shader;
			EffectParameter effectParameter;
			this._uColorParam = effectParameter;
			!0 value2 = shader2.Value;
			Ref<Effect> shader3 = this._shader;
			EffectParameter effectParameter2;
			this._uSaturationParam = effectParameter2;
			!0 value3 = shader3.Value;
			Ref<Effect> shader4 = this._shader;
			EffectParameter effectParameter3;
			this._uSecondaryColorParam = effectParameter3;
			!0 value4 = shader4.Value;
			Ref<Effect> shader5 = this._shader;
			EffectParameter effectParameter4;
			this._uTimeParam = effectParameter4;
			!0 value5 = shader5.Value;
			Ref<Effect> shader6 = this._shader;
			EffectParameter effectParameter5;
			this._uOpacityParam = effectParameter5;
			!0 value6 = shader6.Value;
			Ref<Effect> shader7 = this._shader;
			EffectParameter effectParameter6;
			this._uTargetPositionParam = effectParameter6;
			!0 value7 = shader7.Value;
			Ref<Effect> shader8 = this._shader;
			EffectParameter effectParameter7;
			this._uSourceRectParam = effectParameter7;
			!0 value8 = shader8.Value;
			Ref<Effect> shader9 = this._shader;
			EffectParameter effectParameter8;
			this._uLegacyArmorSourceRectParam = effectParameter8;
			!0 value9 = shader9.Value;
			Ref<Effect> shader10 = this._shader;
			EffectParameter effectParameter9;
			this._uWorldPositionParam = effectParameter9;
			!0 value10 = shader10.Value;
			Ref<Effect> shader11 = this._shader;
			EffectParameter effectParameter10;
			this._uImageSize0Param = effectParameter10;
			!0 value11 = shader11.Value;
			Ref<Effect> shader12 = this._shader;
			EffectParameter effectParameter11;
			this._uLegacyArmorSheetSizeParam = effectParameter11;
			!0 value12 = shader12.Value;
			Ref<Effect> shader13 = this._shader;
			EffectParameter effectParameter12;
			this._uRotationParam = effectParameter12;
			!0 value13 = shader13.Value;
			Ref<Effect> shader14 = this._shader;
			EffectParameter effectParameter13;
			this._uDirectionParam = effectParameter13;
			!0 value14 = shader14.Value;
			EffectParameter effectParameter14;
			this._uImageSize1Param = effectParameter14;
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x000021DB File Offset: 0x000003DB
		public EffectPass GetDustEffect()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00238F38 File Offset: 0x00237138
		public void ApplyDust()
		{
			this.applyingDust = true;
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x000021DB File Offset: 0x000003DB
		public override void Apply(Entity entity, [Optional] DrawData? drawData)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x00238F4C File Offset: 0x0023714C
		public ArmorShaderData UseColor(float r, float g, float b)
		{
			return this;
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00238F5C File Offset: 0x0023715C
		public ArmorShaderData UseColor(Color color)
		{
			return this;
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00238F6C File Offset: 0x0023716C
		public ArmorShaderData UseColor(Vector3 color)
		{
			return this;
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00238F7C File Offset: 0x0023717C
		public ArmorShaderData UseImage(string path)
		{
			if (!true)
			{
			}
			return this;
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00238F90 File Offset: 0x00237190
		public ArmorShaderData UseOpacity(float alpha)
		{
			return this;
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00238FA0 File Offset: 0x002371A0
		public ArmorShaderData UseTargetPosition(Vector2 position)
		{
			return this;
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00238FB0 File Offset: 0x002371B0
		public ArmorShaderData UseSecondaryColor(float r, float g, float b)
		{
			return this;
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00238FC0 File Offset: 0x002371C0
		public ArmorShaderData UseSecondaryColor(Color color)
		{
			return this;
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00238FD0 File Offset: 0x002371D0
		public ArmorShaderData UseSecondaryColor(Vector3 color)
		{
			return this;
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00238FE0 File Offset: 0x002371E0
		public ArmorShaderData UseSaturation(float saturation)
		{
			return this;
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00238FF0 File Offset: 0x002371F0
		public virtual ArmorShaderData GetSecondaryShader(Entity entity)
		{
			return this;
		}

		// Token: 0x04007C29 RID: 31785
		private Vector3 _uColor;

		// Token: 0x04007C2A RID: 31786
		private Vector3 _uSecondaryColor;

		// Token: 0x04007C2B RID: 31787
		private float _uSaturation;

		// Token: 0x04007C2C RID: 31788
		private float _uOpacity;

		// Token: 0x04007C2D RID: 31789
		private Asset<Texture2D> _uImage;

		// Token: 0x04007C2E RID: 31790
		private Vector2 _uTargetPosition;

		// Token: 0x04007C2F RID: 31791
		private int dustFrame;

		// Token: 0x04007C30 RID: 31792
		private EffectPass dustEffect;

		// Token: 0x04007C31 RID: 31793
		private EffectParameter _uColorParam;

		// Token: 0x04007C32 RID: 31794
		private EffectParameter _uSaturationParam;

		// Token: 0x04007C33 RID: 31795
		private EffectParameter _uSecondaryColorParam;

		// Token: 0x04007C34 RID: 31796
		private EffectParameter _uTimeParam;

		// Token: 0x04007C35 RID: 31797
		private EffectParameter _uOpacityParam;

		// Token: 0x04007C36 RID: 31798
		private EffectParameter _uTargetPositionParam;

		// Token: 0x04007C37 RID: 31799
		private EffectParameter _uSourceRectParam;

		// Token: 0x04007C38 RID: 31800
		private EffectParameter _uLegacyArmorSourceRectParam;

		// Token: 0x04007C39 RID: 31801
		private EffectParameter _uWorldPositionParam;

		// Token: 0x04007C3A RID: 31802
		private EffectParameter _uImageSize0Param;

		// Token: 0x04007C3B RID: 31803
		private EffectParameter _uLegacyArmorSheetSizeParam;

		// Token: 0x04007C3C RID: 31804
		private EffectParameter _uRotationParam;

		// Token: 0x04007C3D RID: 31805
		private EffectParameter _uImageSize1Param;

		// Token: 0x04007C3E RID: 31806
		private EffectParameter _uDirectionParam;

		// Token: 0x04007C3F RID: 31807
		private bool applyingDust;
	}
}
