using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000A81 RID: 2689
	public class HorizontalBarsPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
	{
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06004F7E RID: 20350 RVA: 0x0027A8A0 File Offset: 0x00278AA0
		// (set) Token: 0x06004F7F RID: 20351 RVA: 0x0027A8B4 File Offset: 0x00278AB4
		public string NameKey
		{
			[CompilerGenerated]
			get
			{
				return this.<NameKey>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<NameKey>k__BackingField = value;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x0027A8C8 File Offset: 0x00278AC8
		// (set) Token: 0x06004F81 RID: 20353 RVA: 0x0027A8DC File Offset: 0x00278ADC
		public string ConfigKey
		{
			[CompilerGenerated]
			get
			{
				return this.<ConfigKey>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ConfigKey>k__BackingField = value;
			}
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x0027A8F0 File Offset: 0x00278AF0
		public HorizontalBarsPlayerResourcesDisplaySet(string nameKey, string configKey, string resourceFolderName, AssetRequestMode mode)
		{
			this.NameKey = nameKey;
			this.ConfigKey = configKey;
			bool flag = configKey == "HorizontalBarsWithFullText";
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x0027A9E8 File Offset: 0x00278BE8
		public void Draw()
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			this.PrepareFields(localPlayer);
			int screenWidth = Main.screenWidth;
			byte drawTextStyle = this._drawTextStyle;
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x0027AAB0 File Offset: 0x00278CB0
		private static void DrawManaText(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			string text2;
			string text3;
			string text = text2 + "/" + text3;
			int screenWidth = Main.screenWidth;
			string text5;
			string text4 = text5 + " " + text;
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x0027AAF8 File Offset: 0x00278CF8
		private static void DrawLifeBarText(SpriteBatch spriteBatch, Vector2 topLeftAnchor)
		{
			int num = 17154;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			string text;
			string text2;
			if ((" " == null || " " != null) && (text == null || text != null) && ("/" == null || "/" != null) && (text2 == null || text2 != null))
			{
				string text4;
				string text5;
				string text3 = text4 + "/" + text5;
				string text7;
				string text8;
				string text6 = text7 + "/" + text8;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x0027AB7C File Offset: 0x00278D7C
		private void PrepareFields(Player player)
		{
			this._hpSegmentsCount = 32640;
			this._mpSegmentsCount = 32640;
			this._maxSegmentCount = 20;
			this._hpFruitCount = 32640;
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x0027ABB4 File Offset: 0x00278DB4
		private void LifePanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> sprite, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			offset.X = (float)1;
			Asset<Texture2D> panelLeft = this._panelLeft;
			sourceRect.hasValue = 16256 != 0;
			Asset<Texture2D> panelRightHP = this._panelRightHP;
			offset.X = panelRightHP;
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x0027ABFC File Offset: 0x00278DFC
		private void ManaPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> sprite, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			offset.X = (float)1;
			Asset<Texture2D> panelLeft = this._panelLeft;
			sourceRect.hasValue = 16256 != 0;
			Asset<Texture2D> panelRightMP = this._panelRightMP;
			offset.X = panelRightMP;
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x0027AC44 File Offset: 0x00278E44
		private void LifeFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> sprite, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			Asset<Texture2D> hpFill = this._hpFill;
			int hpSegmentsCount = this._hpSegmentsCount;
			int hpFruitCount = this._hpFruitCount;
			Asset<Texture2D> hpFillHoney = this._hpFillHoney;
			float hpPercent = this._hpPercent;
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x0027AC78 File Offset: 0x00278E78
		private static void FillBarByValues(int elementIndex, Asset<Texture2D> sprite, int segmentsCount, float fillPercent, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = 1;
			float lerpValue = Utils.GetLerpValue(fillPercent, drawScale, fillPercent, num != 0);
			int num2 = 16256;
			int num3 = 1;
			int num4 = 1;
			long num5 = 0L;
			long num6 = 0L;
			long num7 = 0L;
			long num8 = 0L;
			sourceRect.hasValue = num2 != 0;
			Rectangle rectangle = Utils.Frame(sprite, num3, num4, (int)num5, (int)num6, (int)num7, (int)num8);
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x0027ACCC File Offset: 0x00278ECC
		private void ManaFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> sprite, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			Asset<Texture2D> mpFill = this._mpFill;
			int mpSegmentsCount = this._mpSegmentsCount;
			float mpPercent = this._mpPercent;
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x0027ACF0 File Offset: 0x00278EF0
		public void TryToHover()
		{
			if (this._hpHovered)
			{
				CommonResourceBarMethods.DrawLifeMouseOver();
			}
			if (this._mpHovered)
			{
				CommonResourceBarMethods.DrawManaMouseOver();
				return;
			}
		}

		// Token: 0x0400886E RID: 34926
		private int _maxSegmentCount;

		// Token: 0x0400886F RID: 34927
		private int _hpSegmentsCount;

		// Token: 0x04008870 RID: 34928
		private int _mpSegmentsCount;

		// Token: 0x04008871 RID: 34929
		private int _hpFruitCount;

		// Token: 0x04008872 RID: 34930
		private float _hpPercent;

		// Token: 0x04008873 RID: 34931
		private float _mpPercent;

		// Token: 0x04008874 RID: 34932
		private byte _drawTextStyle;

		// Token: 0x04008875 RID: 34933
		private bool _hpHovered;

		// Token: 0x04008876 RID: 34934
		private bool _mpHovered;

		// Token: 0x04008877 RID: 34935
		private Asset<Texture2D> _hpFill;

		// Token: 0x04008878 RID: 34936
		private Asset<Texture2D> _hpFillHoney;

		// Token: 0x04008879 RID: 34937
		private Asset<Texture2D> _mpFill;

		// Token: 0x0400887A RID: 34938
		private Asset<Texture2D> _panelLeft;

		// Token: 0x0400887B RID: 34939
		private Asset<Texture2D> _panelMiddleHP;

		// Token: 0x0400887C RID: 34940
		private Asset<Texture2D> _panelRightHP;

		// Token: 0x0400887D RID: 34941
		private Asset<Texture2D> _panelMiddleMP;

		// Token: 0x0400887E RID: 34942
		private Asset<Texture2D> _panelRightMP;

		// Token: 0x0400887F RID: 34943
		[CompilerGenerated]
		private string <NameKey>k__BackingField;

		// Token: 0x04008880 RID: 34944
		[CompilerGenerated]
		private string <ConfigKey>k__BackingField;
	}
}
