using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.ID
{
	// Token: 0x02000600 RID: 1536
	public static class TorchID
	{
		// Token: 0x060035A5 RID: 13733 RVA: 0x00211674 File Offset: 0x0020F874
		public static void Initialize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x0021168C File Offset: 0x0020F88C
		public static void TorchColor(int torchID, [Out] float R, [Out] float G, [Out] float B)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x002116A8 File Offset: 0x0020F8A8
		// Note: this type is marked as 'beforefieldinit'.
		static TorchID()
		{
		}

		// Token: 0x04007331 RID: 29489
		public static int[] Dust;

		// Token: 0x04007332 RID: 29490
		private static TorchID.ITorchLightProvider[] _lights;

		// Token: 0x04007333 RID: 29491
		public const short Torch = 0;

		// Token: 0x04007334 RID: 29492
		public const short Blue = 1;

		// Token: 0x04007335 RID: 29493
		public const short Red = 2;

		// Token: 0x04007336 RID: 29494
		public const short Green = 3;

		// Token: 0x04007337 RID: 29495
		public const short Purple = 4;

		// Token: 0x04007338 RID: 29496
		public const short White = 5;

		// Token: 0x04007339 RID: 29497
		public const short Yellow = 6;

		// Token: 0x0400733A RID: 29498
		public const short Demon = 7;

		// Token: 0x0400733B RID: 29499
		public const short Cursed = 8;

		// Token: 0x0400733C RID: 29500
		public const short Ice = 9;

		// Token: 0x0400733D RID: 29501
		public const short Orange = 10;

		// Token: 0x0400733E RID: 29502
		public const short Ichor = 11;

		// Token: 0x0400733F RID: 29503
		public const short UltraBright = 12;

		// Token: 0x04007340 RID: 29504
		public const short Bone = 13;

		// Token: 0x04007341 RID: 29505
		public const short Rainbow = 14;

		// Token: 0x04007342 RID: 29506
		public const short Pink = 15;

		// Token: 0x04007343 RID: 29507
		public const short Desert = 16;

		// Token: 0x04007344 RID: 29508
		public const short Coral = 17;

		// Token: 0x04007345 RID: 29509
		public const short Corrupt = 18;

		// Token: 0x04007346 RID: 29510
		public const short Crimson = 19;

		// Token: 0x04007347 RID: 29511
		public const short Hallowed = 20;

		// Token: 0x04007348 RID: 29512
		public const short Jungle = 21;

		// Token: 0x04007349 RID: 29513
		public const short Mushroom = 22;

		// Token: 0x0400734A RID: 29514
		public const short Shimmer = 23;

		// Token: 0x0400734B RID: 29515
		public static readonly short Count;

		// Token: 0x02000601 RID: 1537
		private interface ITorchLightProvider
		{
			// Token: 0x060035A8 RID: 13736
			void GetRGB([Out] float r, [Out] float g, [Out] float b);
		}

		// Token: 0x02000602 RID: 1538
		private struct ConstantTorchLight : TorchID.ITorchLightProvider
		{
			// Token: 0x060035A9 RID: 13737 RVA: 0x002116B8 File Offset: 0x0020F8B8
			public ConstantTorchLight(float Red, float Green, float Blue)
			{
			}

			// Token: 0x060035AA RID: 13738 RVA: 0x002116C8 File Offset: 0x0020F8C8
			public void GetRGB([Out] float r, [Out] float g, [Out] float b)
			{
				float g2 = this.G;
				float b2 = this.B;
			}

			// Token: 0x0400734C RID: 29516
			public float R;

			// Token: 0x0400734D RID: 29517
			public float G;

			// Token: 0x0400734E RID: 29518
			public float B;
		}

		// Token: 0x02000603 RID: 1539
		private struct DemonTorchLight : TorchID.ITorchLightProvider
		{
			// Token: 0x060035AB RID: 13739 RVA: 0x002116E4 File Offset: 0x0020F8E4
			public void GetRGB([Out] float r, [Out] float g, [Out] float b)
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x02000604 RID: 1540
		private struct ShimmerTorchLight : TorchID.ITorchLightProvider
		{
			// Token: 0x060035AC RID: 13740 RVA: 0x002116F4 File Offset: 0x0020F8F4
			public void GetRGB([Out] float r, [Out] float g, [Out] float b)
			{
				if (!true)
				{
				}
				float num = MathHelper.Clamp(r, g, b);
				float num2 = MathHelper.Clamp(num, g, b);
			}
		}

		// Token: 0x02000605 RID: 1541
		private struct DiscoTorchLight : TorchID.ITorchLightProvider
		{
			// Token: 0x060035AD RID: 13741 RVA: 0x0021171C File Offset: 0x0020F91C
			public void GetRGB([Out] float r, [Out] float g, [Out] float b)
			{
				if (!true)
				{
				}
			}
		}
	}
}
