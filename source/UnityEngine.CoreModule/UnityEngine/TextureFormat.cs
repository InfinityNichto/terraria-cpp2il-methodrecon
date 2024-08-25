using System;
using System.ComponentModel;

namespace UnityEngine
{
	// Token: 0x0200006A RID: 106
	public enum TextureFormat
	{
		// Token: 0x0400025E RID: 606
		Alpha8 = 1,
		// Token: 0x0400025F RID: 607
		ARGB4444,
		// Token: 0x04000260 RID: 608
		RGB24,
		// Token: 0x04000261 RID: 609
		RGBA32,
		// Token: 0x04000262 RID: 610
		ARGB32,
		// Token: 0x04000263 RID: 611
		RGB565 = 7,
		// Token: 0x04000264 RID: 612
		R16 = 9,
		// Token: 0x04000265 RID: 613
		DXT1,
		// Token: 0x04000266 RID: 614
		DXT5 = 12,
		// Token: 0x04000267 RID: 615
		RGBA4444,
		// Token: 0x04000268 RID: 616
		BGRA32,
		// Token: 0x04000269 RID: 617
		RHalf,
		// Token: 0x0400026A RID: 618
		RGHalf,
		// Token: 0x0400026B RID: 619
		RGBAHalf,
		// Token: 0x0400026C RID: 620
		RFloat,
		// Token: 0x0400026D RID: 621
		RGFloat,
		// Token: 0x0400026E RID: 622
		RGBAFloat,
		// Token: 0x0400026F RID: 623
		YUY2,
		// Token: 0x04000270 RID: 624
		RGB9e5Float,
		// Token: 0x04000271 RID: 625
		BC4 = 26,
		// Token: 0x04000272 RID: 626
		BC5,
		// Token: 0x04000273 RID: 627
		BC6H = 24,
		// Token: 0x04000274 RID: 628
		BC7,
		// Token: 0x04000275 RID: 629
		DXT1Crunched = 28,
		// Token: 0x04000276 RID: 630
		DXT5Crunched,
		// Token: 0x04000277 RID: 631
		PVRTC_RGB2,
		// Token: 0x04000278 RID: 632
		PVRTC_RGBA2,
		// Token: 0x04000279 RID: 633
		PVRTC_RGB4,
		// Token: 0x0400027A RID: 634
		PVRTC_RGBA4,
		// Token: 0x0400027B RID: 635
		ETC_RGB4,
		// Token: 0x0400027C RID: 636
		EAC_R = 41,
		// Token: 0x0400027D RID: 637
		EAC_R_SIGNED,
		// Token: 0x0400027E RID: 638
		EAC_RG,
		// Token: 0x0400027F RID: 639
		EAC_RG_SIGNED,
		// Token: 0x04000280 RID: 640
		ETC2_RGB,
		// Token: 0x04000281 RID: 641
		ETC2_RGBA1,
		// Token: 0x04000282 RID: 642
		ETC2_RGBA8,
		// Token: 0x04000283 RID: 643
		ASTC_4x4,
		// Token: 0x04000284 RID: 644
		ASTC_5x5,
		// Token: 0x04000285 RID: 645
		ASTC_6x6,
		// Token: 0x04000286 RID: 646
		ASTC_8x8,
		// Token: 0x04000287 RID: 647
		ASTC_10x10,
		// Token: 0x04000288 RID: 648
		ASTC_12x12,
		// Token: 0x04000289 RID: 649
		[Obsolete("Nintendo 3DS is no longer supported.")]
		ETC_RGB4_3DS = 60,
		// Token: 0x0400028A RID: 650
		[Obsolete("Nintendo 3DS is no longer supported.")]
		ETC_RGBA8_3DS,
		// Token: 0x0400028B RID: 651
		RG16,
		// Token: 0x0400028C RID: 652
		R8,
		// Token: 0x0400028D RID: 653
		ETC_RGB4Crunched,
		// Token: 0x0400028E RID: 654
		ETC2_RGBA8Crunched,
		// Token: 0x0400028F RID: 655
		ASTC_HDR_4x4,
		// Token: 0x04000290 RID: 656
		ASTC_HDR_5x5,
		// Token: 0x04000291 RID: 657
		ASTC_HDR_6x6,
		// Token: 0x04000292 RID: 658
		ASTC_HDR_8x8,
		// Token: 0x04000293 RID: 659
		ASTC_HDR_10x10,
		// Token: 0x04000294 RID: 660
		ASTC_HDR_12x12,
		// Token: 0x04000295 RID: 661
		RG32,
		// Token: 0x04000296 RID: 662
		RGB48,
		// Token: 0x04000297 RID: 663
		RGBA64,
		// Token: 0x04000298 RID: 664
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
		ASTC_RGB_4x4 = 48,
		// Token: 0x04000299 RID: 665
		[Obsolete("Enum member TextureFormat.ASTC_RGB_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGB_5x5,
		// Token: 0x0400029A RID: 666
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
		ASTC_RGB_6x6,
		// Token: 0x0400029B RID: 667
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
		ASTC_RGB_8x8,
		// Token: 0x0400029C RID: 668
		[Obsolete("Enum member TextureFormat.ASTC_RGB_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGB_10x10,
		// Token: 0x0400029D RID: 669
		[Obsolete("Enum member TextureFormat.ASTC_RGB_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGB_12x12,
		// Token: 0x0400029E RID: 670
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGBA_4x4,
		// Token: 0x0400029F RID: 671
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
		ASTC_RGBA_5x5,
		// Token: 0x040002A0 RID: 672
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGBA_6x6,
		// Token: 0x040002A1 RID: 673
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
		ASTC_RGBA_8x8,
		// Token: 0x040002A2 RID: 674
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGBA_10x10,
		// Token: 0x040002A3 RID: 675
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ASTC_RGBA_12x12
	}
}
