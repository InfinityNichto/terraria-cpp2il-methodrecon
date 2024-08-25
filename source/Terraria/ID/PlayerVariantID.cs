using System;
using System.Runtime.CompilerServices;

namespace Terraria.ID
{
	// Token: 0x020005E5 RID: 1509
	public static class PlayerVariantID
	{
		// Token: 0x06003570 RID: 13680 RVA: 0x0020FC90 File Offset: 0x0020DE90
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerVariantID()
		{
		}

		// Token: 0x040068DE RID: 26846
		public const int MaleStarter = 0;

		// Token: 0x040068DF RID: 26847
		public const int MaleSticker = 1;

		// Token: 0x040068E0 RID: 26848
		public const int MaleGangster = 2;

		// Token: 0x040068E1 RID: 26849
		public const int MaleCoat = 3;

		// Token: 0x040068E2 RID: 26850
		public const int FemaleStarter = 4;

		// Token: 0x040068E3 RID: 26851
		public const int FemaleSticker = 5;

		// Token: 0x040068E4 RID: 26852
		public const int FemaleGangster = 6;

		// Token: 0x040068E5 RID: 26853
		public const int FemaleCoat = 7;

		// Token: 0x040068E6 RID: 26854
		public const int MaleDress = 8;

		// Token: 0x040068E7 RID: 26855
		public const int FemaleDress = 9;

		// Token: 0x040068E8 RID: 26856
		public const int MaleDisplayDoll = 10;

		// Token: 0x040068E9 RID: 26857
		public const int FemaleDisplayDoll = 11;

		// Token: 0x040068EA RID: 26858
		public static readonly int Count;

		// Token: 0x020005E6 RID: 1510
		public class Sets
		{
			// Token: 0x06003571 RID: 13681 RVA: 0x0020FCA0 File Offset: 0x0020DEA0
			public Sets()
			{
			}

			// Token: 0x06003572 RID: 13682 RVA: 0x0020FCB4 File Offset: 0x0020DEB4
			// Note: this type is marked as 'beforefieldinit'.
			static Sets()
			{
				if (!true)
				{
				}
				int[] array;
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.9EBE6A4BE4EFCDDD0B06733A9D5E459B0C5B8C2CE9E178DDDA4B6B0EE206D0AF).FieldHandle);
			}

			// Token: 0x040068EB RID: 26859
			public static SetFactory Factory;

			// Token: 0x040068EC RID: 26860
			public static bool[] Male;

			// Token: 0x040068ED RID: 26861
			public static int[] AltGenderReference;

			// Token: 0x040068EE RID: 26862
			public static int[] VariantOrderMale;

			// Token: 0x040068EF RID: 26863
			public static int[] VariantOrderFemale;
		}
	}
}
