using System;

namespace Terraria.Initializers
{
	// Token: 0x0200058E RID: 1422
	public static class PlayerDataInitializer
	{
		// Token: 0x060034B3 RID: 13491 RVA: 0x0020A610 File Offset: 0x00208810
		public static void Load()
		{
			if (!true)
			{
			}
			PlayerDataInitializer.LoadStarterMale();
			PlayerDataInitializer.LoadStarterFemale();
			PlayerDataInitializer.LoadStickerMale();
			PlayerDataInitializer.LoadStickerFemale();
			PlayerDataInitializer.LoadGangsterMale();
			PlayerDataInitializer.LoadGangsterFemale();
			PlayerDataInitializer.LoadCoatMale();
			PlayerDataInitializer.LoadDressFemale();
			PlayerDataInitializer.LoadDressMale();
			PlayerDataInitializer.LoadCoatFemale();
			PlayerDataInitializer.LoadDisplayDollMale();
			PlayerDataInitializer.LoadDisplayDollFemale();
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x0020A65C File Offset: 0x0020885C
		private static void LoadVariant(int ID, int[] pieceIDs)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x0020A674 File Offset: 0x00208874
		private static void CopyVariant(int to, int from)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x0020A68C File Offset: 0x0020888C
		private static void LoadStarterMale()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x0020A6A0 File Offset: 0x002088A0
		private static void LoadStickerMale()
		{
			long num = 0L;
			PlayerDataInitializer.CopyVariant(1, (int)num);
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x0020A6B8 File Offset: 0x002088B8
		private static void LoadGangsterMale()
		{
			long num = 0L;
			PlayerDataInitializer.CopyVariant(2, (int)num);
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x0020A6D0 File Offset: 0x002088D0
		private static void LoadCoatMale()
		{
			long num = 0L;
			PlayerDataInitializer.CopyVariant(3, (int)num);
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x0020A6E8 File Offset: 0x002088E8
		private static void LoadDressMale()
		{
			long num = 0L;
			PlayerDataInitializer.CopyVariant(8, (int)num);
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x0020A700 File Offset: 0x00208900
		private static void LoadStarterFemale()
		{
			long num = 0L;
			PlayerDataInitializer.CopyVariant(4, (int)num);
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x0020A718 File Offset: 0x00208918
		private static void LoadStickerFemale()
		{
			PlayerDataInitializer.CopyVariant(5, 4);
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x0020A72C File Offset: 0x0020892C
		private static void LoadGangsterFemale()
		{
			PlayerDataInitializer.CopyVariant(6, 4);
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x0020A740 File Offset: 0x00208940
		private static void LoadCoatFemale()
		{
			PlayerDataInitializer.CopyVariant(7, 4);
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x0020A754 File Offset: 0x00208954
		private static void LoadDressFemale()
		{
			PlayerDataInitializer.CopyVariant(9, 4);
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x0020A76C File Offset: 0x0020896C
		private static void LoadDisplayDollMale()
		{
			int num = 1;
			int num2 = 10;
			long num3 = 0L;
			PlayerDataInitializer.CopyVariant(num2, (int)num3);
			if (num == 0)
			{
			}
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x0020A790 File Offset: 0x00208990
		private static void LoadDisplayDollFemale()
		{
			int num = 1;
			int num2 = 11;
			int num3 = 10;
			PlayerDataInitializer.CopyVariant(num2, num3);
			if (num == 0)
			{
			}
		}
	}
}
