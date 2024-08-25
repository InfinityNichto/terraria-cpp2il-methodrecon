using System;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x0200080A RID: 2058
	public class ContentRejectionFromSize : IRejectionReason
	{
		// Token: 0x060041DA RID: 16858 RVA: 0x00248C64 File Offset: 0x00246E64
		public ContentRejectionFromSize(int neededWidth, int neededHeight, int actualWidth, int actualHeight)
		{
			this._neededWidth = neededWidth;
			this._actualWidth = neededHeight;
			this._actualWidth = actualWidth;
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x00248C8C File Offset: 0x00246E8C
		public string GetReason()
		{
			int neededWidth = this._neededWidth;
			int actualWidth = this._actualWidth;
			int actualWidth2 = this._actualWidth;
			string text;
			return text;
		}

		// Token: 0x040080A0 RID: 32928
		private int _neededWidth;

		// Token: 0x040080A1 RID: 32929
		private int _neededHeight;

		// Token: 0x040080A2 RID: 32930
		private int _actualWidth;

		// Token: 0x040080A3 RID: 32931
		private int _actualHeight;
	}
}
