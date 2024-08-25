using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200036A RID: 874
	public class PixelShader : Effect
	{
		// Token: 0x060016D3 RID: 5843 RVA: 0x000636FC File Offset: 0x000618FC
		public PixelShader(GraphicsDevice device)
		{
			if (!true)
			{
			}
			this.TileOffsetData = 1;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0006371C File Offset: 0x0006191C
		public static PixelShader Effect
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

		// Token: 0x060016D5 RID: 5845 RVA: 0x000021DB File Offset: 0x000003DB
		private static void LoadPass(List<EffectPass> passes, string pass)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00063740 File Offset: 0x00061940
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
			int passIndex = pass.PassIndex;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00063C98 File Offset: 0x00061E98
		// Note: this type is marked as 'beforefieldinit'.
		static PixelShader()
		{
			int num = Shader.PropertyToID("_Color");
			int num2 = Shader.PropertyToID("_SecondaryColor");
			int num3 = Shader.PropertyToID("_Saturation");
			int num4 = Shader.PropertyToID("_ImageSize0");
			int num5 = Shader.PropertyToID("_ImageSize1");
			int num6 = Shader.PropertyToID("_SourceRect");
			int num7 = Shader.PropertyToID("_ShaderTime");
			int num8 = Shader.PropertyToID("_Opacity");
			int num9 = Shader.PropertyToID("_Direction");
			int num10 = Shader.PropertyToID("_Rotation");
			int num11 = Shader.PropertyToID("_LightSource");
			int num12 = Shader.PropertyToID("_TargetPosition");
			int num13 = Shader.PropertyToID("_TextureRect");
			int num14 = Shader.PropertyToID("_ShaderSpecificData");
		}

		// Token: 0x040024EC RID: 9452
		private EffectParameter _uColor;

		// Token: 0x040024ED RID: 9453
		private EffectParameter _uSaturation;

		// Token: 0x040024EE RID: 9454
		private EffectParameter _uSecondaryColor;

		// Token: 0x040024EF RID: 9455
		private EffectParameter _uTime;

		// Token: 0x040024F0 RID: 9456
		private EffectParameter _uOpacity;

		// Token: 0x040024F1 RID: 9457
		private EffectParameter _uLightSource;

		// Token: 0x040024F2 RID: 9458
		private EffectParameter _uSourceRect;

		// Token: 0x040024F3 RID: 9459
		private EffectParameter _uLegacyArmorSourceRect;

		// Token: 0x040024F4 RID: 9460
		private EffectParameter _uLegacyArmorSheetSize;

		// Token: 0x040024F5 RID: 9461
		private EffectParameter _uWorldPosition;

		// Token: 0x040024F6 RID: 9462
		private EffectParameter _uImageSize0;

		// Token: 0x040024F7 RID: 9463
		private EffectParameter _uImageSize1;

		// Token: 0x040024F8 RID: 9464
		private EffectParameter _uImageSize2;

		// Token: 0x040024F9 RID: 9465
		private EffectParameter _uRotation;

		// Token: 0x040024FA RID: 9466
		private EffectParameter _uDirection;

		// Token: 0x040024FB RID: 9467
		private EffectParameter _uTargetPosition;

		// Token: 0x040024FC RID: 9468
		private EffectParameter _uShaderSpecificData;

		// Token: 0x040024FD RID: 9469
		private EffectParameter _uMatrixTransform0;

		// Token: 0x040024FE RID: 9470
		private short[] TileOffsetData;

		// Token: 0x040024FF RID: 9471
		private GraphicsDevice device;

		// Token: 0x04002500 RID: 9472
		private static PixelShader _effect;

		// Token: 0x04002501 RID: 9473
		private static int _colorId;

		// Token: 0x04002502 RID: 9474
		private static int _secondaryColorId;

		// Token: 0x04002503 RID: 9475
		private static int _saturationId;

		// Token: 0x04002504 RID: 9476
		private static int _imageSize0Id;

		// Token: 0x04002505 RID: 9477
		private static int _imageSize1Id;

		// Token: 0x04002506 RID: 9478
		private static int _sourceRectId;

		// Token: 0x04002507 RID: 9479
		private static int _timeId;

		// Token: 0x04002508 RID: 9480
		private static int _opacityId;

		// Token: 0x04002509 RID: 9481
		private static int _directionId;

		// Token: 0x0400250A RID: 9482
		private static int _rotationId;

		// Token: 0x0400250B RID: 9483
		private static int _lightSourceId;

		// Token: 0x0400250C RID: 9484
		private static int _targetPositionId;

		// Token: 0x0400250D RID: 9485
		private static int _textureRectId;

		// Token: 0x0400250E RID: 9486
		private static int _shaderSpecificDataId;

		// Token: 0x0200036B RID: 875
		public enum PassIds
		{
			// Token: 0x04002510 RID: 9488
			Default,
			// Token: 0x04002511 RID: 9489
			ColorOnly,
			// Token: 0x04002512 RID: 9490
			ArmorMartian,
			// Token: 0x04002513 RID: 9491
			ArmorColored,
			// Token: 0x04002514 RID: 9492
			ArmorColoredAndBlack,
			// Token: 0x04002515 RID: 9493
			ArmorColoredAndSilverTrim,
			// Token: 0x04002516 RID: 9494
			ArmorSilverTrim,
			// Token: 0x04002517 RID: 9495
			ArmorBrightnessColored,
			// Token: 0x04002518 RID: 9496
			ArmorColoredGradient,
			// Token: 0x04002519 RID: 9497
			ArmorColoredAndBlackGradient,
			// Token: 0x0400251A RID: 9498
			ArmorBrightnessGradient,
			// Token: 0x0400251B RID: 9499
			ArmorColoredRainbow,
			// Token: 0x0400251C RID: 9500
			ArmorBrightnessRainbow,
			// Token: 0x0400251D RID: 9501
			ArmorLivingRainbow,
			// Token: 0x0400251E RID: 9502
			ArmorInvert,
			// Token: 0x0400251F RID: 9503
			ArmorLivingOcean,
			// Token: 0x04002520 RID: 9504
			ArmorLivingFlame,
			// Token: 0x04002521 RID: 9505
			ArmorWisp,
			// Token: 0x04002522 RID: 9506
			ArmorHighContrastGlow,
			// Token: 0x04002523 RID: 9507
			ArmorPlaid,
			// Token: 0x04002524 RID: 9508
			ArmorDev,
			// Token: 0x04002525 RID: 9509
			ArmorPlaid2,
			// Token: 0x04002526 RID: 9510
			ArmorReflectiveColor,
			// Token: 0x04002527 RID: 9511
			ArmorBasicColor,
			// Token: 0x04002528 RID: 9512
			ArmorHades,
			// Token: 0x04002529 RID: 9513
			ArmorTwilight,
			// Token: 0x0400252A RID: 9514
			ArmorAcid,
			// Token: 0x0400252B RID: 9515
			ArmorMushroom,
			// Token: 0x0400252C RID: 9516
			ArmorPhase,
			// Token: 0x0400252D RID: 9517
			ArmorReflective,
			// Token: 0x0400252E RID: 9518
			ArmorSolar,
			// Token: 0x0400252F RID: 9519
			ArmorNebula,
			// Token: 0x04002530 RID: 9520
			ArmorVortex,
			// Token: 0x04002531 RID: 9521
			ArmorStardust,
			// Token: 0x04002532 RID: 9522
			ArmorVoid,
			// Token: 0x04002533 RID: 9523
			ArmorShiftingSands,
			// Token: 0x04002534 RID: 9524
			ArmorShiftingPearlsands,
			// Token: 0x04002535 RID: 9525
			ArmorFog,
			// Token: 0x04002536 RID: 9526
			ArmorHallowBoss,
			// Token: 0x04002537 RID: 9527
			ArmorMirage,
			// Token: 0x04002538 RID: 9528
			ArmorMidnightRainbow,
			// Token: 0x04002539 RID: 9529
			ArmorColoredAndSilverTrimGradient,
			// Token: 0x0400253A RID: 9530
			ArmorPolarized,
			// Token: 0x0400253B RID: 9531
			ArmorGel,
			// Token: 0x0400253C RID: 9532
			ArmorFlow,
			// Token: 0x0400253D RID: 9533
			ArmorForceField,
			// Token: 0x0400253E RID: 9534
			ArmorLoki,
			// Token: 0x0400253F RID: 9535
			ForceField,
			// Token: 0x04002540 RID: 9536
			WaterProcessor,
			// Token: 0x04002541 RID: 9537
			WaterDistortionObject,
			// Token: 0x04002542 RID: 9538
			HallowBoss,
			// Token: 0x04002543 RID: 9539
			TitaniumStorm,
			// Token: 0x04002544 RID: 9540
			QueenSlime,
			// Token: 0x04002545 RID: 9541
			MagicMissile,
			// Token: 0x04002546 RID: 9542
			FinalFractal,
			// Token: 0x04002547 RID: 9543
			FinalFractalVertex,
			// Token: 0x04002548 RID: 9544
			MaskedFade,
			// Token: 0x04002549 RID: 9545
			RainbowTownSlime,
			// Token: 0x0400254A RID: 9546
			RainbowTownSlimeOutline,
			// Token: 0x0400254B RID: 9547
			Outline,
			// Token: 0x0400254C RID: 9548
			RevSub
		}
	}
}
