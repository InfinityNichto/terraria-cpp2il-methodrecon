using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000A5B RID: 2651
	public class CustomCurrencySingleCoin : CustomCurrencySystem
	{
		// Token: 0x06004E64 RID: 20068 RVA: 0x002768CC File Offset: 0x00274ACC
		public CustomCurrencySingleCoin(int coinItemID, long currencyCap)
		{
			base.Include(coinItemID, 1);
			this._currencyCap = currencyCap;
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x000021DB File Offset: 0x000003DB
		public override bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x00276910 File Offset: 0x00274B10
		public override void DrawSavingsMoney(SpriteBatch sb, string text, float shopx, float shopy, long totalCoins, bool horizontal = false)
		{
			Dictionary<int, int> valuePerUnit = this._valuePerUnit;
			if (!true)
			{
			}
			if (16948 == 0)
			{
			}
			float currencyDrawScale = this.CurrencyDrawScale;
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x0027694C File Offset: 0x00274B4C
		public override void GetPriceText(string[] lines, int currentLine, long price)
		{
			int num = 1;
			Color currencyTextColor = this.CurrencyTextColor;
			if (num == 0)
			{
			}
			int num2 = 17279;
			currentLine.m_value = num2;
			string text = Language.GetTextValue(this.CurrencyTextKey).ToLower();
			string text2;
			if ((text == null || text != null) && (text2 == null || text2 != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040086F6 RID: 34550
		public float CurrencyDrawScale = (float)52429;

		// Token: 0x040086F7 RID: 34551
		public string CurrencyTextKey = "Currency.DefenderMedals";

		// Token: 0x040086F8 RID: 34552
		public Color CurrencyTextColor = "Currency.DefenderMedals";
	}
}
