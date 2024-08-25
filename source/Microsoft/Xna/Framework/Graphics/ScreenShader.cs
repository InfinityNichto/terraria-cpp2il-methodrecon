using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200036C RID: 876
	public class ScreenShader : Effect
	{
		// Token: 0x060016D8 RID: 5848 RVA: 0x00063D4C File Offset: 0x00061F4C
		public ScreenShader(GraphicsDevice device)
			: base(device)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00063D68 File Offset: 0x00061F68
		public static ScreenShader Effect
		{
			get
			{
				if (!true)
				{
				}
				if (true || !true)
				{
				}
				if ("Technique1" == null)
				{
				}
				return "Technique1";
			}
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x000021DB File Offset: 0x000003DB
		private static void LoadPass(List<EffectPass> passes, string pass)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00063D8C File Offset: 0x00061F8C
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
			if (!true)
			{
			}
			Color color = this._uColor.Color;
			Color color2 = this._uSecondaryColor.Color;
			float @float = this._uOpacity.Float;
			material.SetFloat(43139072, @float);
			float float2 = this._uTime.Float;
			material.SetFloat(43139072, float2);
			float float3 = this._uIntensity.Float;
			material.SetFloat(43139072, float3);
			float float4 = this._uProgress.Float;
			material.SetFloat(43139072, float4);
			Vector4 vector = this._uScreenResolution.Vector;
			Vector4 vector2 = this._uScreenPosition.Vector;
			Vector4 vector3 = this._uTargetPosition.Vector;
			Vector4 vector4 = this._uDirection.Vector;
			Vector4 vector5 = this._uImageSize1.Vector;
			Vector4 vector6 = this._uImageSize2.Vector;
			Vector4 vector7 = this._uImageSize3.Vector;
			bool flag = pass.Name == "FilterWaterDistortion";
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00063E88 File Offset: 0x00062088
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenShader()
		{
			int num = Shader.PropertyToID("_Color");
			int num2 = Shader.PropertyToID("_Opacity");
			int num3 = Shader.PropertyToID("_SecondaryColor");
			int num4 = Shader.PropertyToID("_ShaderTime");
			int num5 = Shader.PropertyToID("_ScreenResolution");
			int num6 = Shader.PropertyToID("_ScreenPosition");
			int num7 = Shader.PropertyToID("_TargetPosition");
			int num8 = Shader.PropertyToID("_Intensity");
			int num9 = Shader.PropertyToID("_Progress");
			int num10 = Shader.PropertyToID("_Direction");
			int num11 = Shader.PropertyToID("_ImageSize1");
			int num12 = Shader.PropertyToID("_ImageSize2");
			int num13 = Shader.PropertyToID("_ImageSize3");
			int num14 = Shader.PropertyToID("_Zoom");
		}

		// Token: 0x0400254D RID: 9549
		private EffectParameter _uColor;

		// Token: 0x0400254E RID: 9550
		private EffectParameter _uOpacity;

		// Token: 0x0400254F RID: 9551
		private EffectParameter _uSecondaryColor;

		// Token: 0x04002550 RID: 9552
		private EffectParameter _uTime;

		// Token: 0x04002551 RID: 9553
		private EffectParameter _uScreenResolution;

		// Token: 0x04002552 RID: 9554
		private EffectParameter _uScreenPosition;

		// Token: 0x04002553 RID: 9555
		private EffectParameter _uTargetPosition;

		// Token: 0x04002554 RID: 9556
		private EffectParameter _uIntensity;

		// Token: 0x04002555 RID: 9557
		private EffectParameter _uImageOffset;

		// Token: 0x04002556 RID: 9558
		private EffectParameter _uProgress;

		// Token: 0x04002557 RID: 9559
		private EffectParameter _uDirection;

		// Token: 0x04002558 RID: 9560
		private EffectParameter _uZoom;

		// Token: 0x04002559 RID: 9561
		private EffectParameter _uImageSize1;

		// Token: 0x0400255A RID: 9562
		private EffectParameter _uImageSize2;

		// Token: 0x0400255B RID: 9563
		private EffectParameter _uImageSize3;

		// Token: 0x0400255C RID: 9564
		private static ScreenShader _effect;

		// Token: 0x0400255D RID: 9565
		private static int _colorId;

		// Token: 0x0400255E RID: 9566
		private static int _opacityId;

		// Token: 0x0400255F RID: 9567
		private static int _secondaryColorId;

		// Token: 0x04002560 RID: 9568
		private static int _timeId;

		// Token: 0x04002561 RID: 9569
		private static int _screenResolutionId;

		// Token: 0x04002562 RID: 9570
		private static int _screenPositionId;

		// Token: 0x04002563 RID: 9571
		private static int _targetPositionId;

		// Token: 0x04002564 RID: 9572
		private static int _intensityId;

		// Token: 0x04002565 RID: 9573
		private static int _progressId;

		// Token: 0x04002566 RID: 9574
		private static int _directionId;

		// Token: 0x04002567 RID: 9575
		private static int _ImageSize1;

		// Token: 0x04002568 RID: 9576
		private static int _ImageSize2;

		// Token: 0x04002569 RID: 9577
		private static int _ImageSize3;

		// Token: 0x0400256A RID: 9578
		private static int _Zoom;
	}
}
