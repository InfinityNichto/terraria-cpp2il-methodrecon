using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000A80 RID: 2688
	public class FancyClassicPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
	{
		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06004F6E RID: 20334 RVA: 0x0027A3C8 File Offset: 0x002785C8
		// (set) Token: 0x06004F6F RID: 20335 RVA: 0x0027A3DC File Offset: 0x002785DC
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

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06004F70 RID: 20336 RVA: 0x0027A3F0 File Offset: 0x002785F0
		// (set) Token: 0x06004F71 RID: 20337 RVA: 0x0027A404 File Offset: 0x00278604
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

		// Token: 0x06004F72 RID: 20338 RVA: 0x0027A418 File Offset: 0x00278618
		public FancyClassicPlayerResourcesDisplaySet(string nameKey, string configKey, string resourceFolderName, AssetRequestMode mode)
		{
			int num = 1;
			base..ctor();
			this.NameKey = nameKey;
			this.ConfigKey = configKey;
			bool flag = configKey == "NewWithText";
			this._drawText = num != 0;
			string text = "Images\\UI\\PlayerResourceSets\\" + resourceFolderName;
			string text2 = text + "\\Heart_Left";
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x0027A558 File Offset: 0x00278758
		public void Draw()
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			this.PrepareFields(localPlayer);
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x0027A578 File Offset: 0x00278778
		private void DrawLifeBar(SpriteBatch spriteBatch)
		{
			int screenWidth = Main.screenWidth;
			bool drawText = this._drawText;
			if (drawText)
			{
				if (!drawText)
				{
				}
			}
			if (this._heartCountRow1 == 0)
			{
			}
			if (!true)
			{
			}
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
			int heartCountRow = this._heartCountRow2;
			if (!true)
			{
			}
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
			int heartCountRow2 = this._heartCountRow1;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			int heartCountRow3 = this._heartCountRow2;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x0027A5FC File Offset: 0x002787FC
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
			if ((" " == null || " " != null) && (text == null || text != null) && "/" != null && (text2 == null || text2 != null))
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

		// Token: 0x06004F76 RID: 20342 RVA: 0x0027A678 File Offset: 0x00278878
		private void DrawManaBar(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			if (this._starCount == 0)
			{
			}
			if (!true)
			{
			}
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
			int starCount = this._starCount;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x0027A6BC File Offset: 0x002788BC
		private static void DrawManaText(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x0027A6F0 File Offset: 0x002788F0
		private void HeartPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> sprite, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			offset.X = (float)1;
			Asset<Texture2D> heartLeft = this._heartLeft;
			sourceRect.hasValue = 16256 != 0;
			Asset<Texture2D> heartSingleFancy = this._heartSingleFancy;
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x0027A750 File Offset: 0x00278950
		private void HeartFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> sprite, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Asset<Texture2D> heartLeft = this._heartLeft;
			int playerLifeFruitCount = this._playerLifeFruitCount;
			float currentPlayerLife = this._currentPlayerLife;
			float lifePerHeart = this._lifePerHeart;
			int lastHeartFillingIndex = this._lastHeartFillingIndex;
			float cursorScale = Main.cursorScale;
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x0027A794 File Offset: 0x00278994
		private void StarPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> sprite, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			offset.X = (float)1;
			Asset<Texture2D> starTop = this._starTop;
			sourceRect.hasValue = 16256 != 0;
			Asset<Texture2D> starSingle = this._starSingle;
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0027A7E4 File Offset: 0x002789E4
		private void StarFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> sprite, [Out] Vector2 offset, [Out] float drawScale, [Out] Rectangle? sourceRect)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Asset<Texture2D> starFill = this._starFill;
			float manaPerStar = this._manaPerStar;
			float currentPlayerMana = this._currentPlayerMana;
			if (starFill == null)
			{
			}
			int lastStarFillingIndex = this._lastStarFillingIndex;
			float cursorScale = Main.cursorScale;
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x0027A824 File Offset: 0x00278A24
		private void PrepareFields(Player player)
		{
			int num = 1;
			this._manaPerStar = (float)num;
			if (num == 0)
			{
			}
			float lifePerHeart = this._lifePerHeart;
			float lifePerHeart2 = this._lifePerHeart;
			int heartCountRow = this._heartCountRow1;
			this._heartCountRow1 = heartCountRow;
			float manaPerStar = this._manaPerStar;
			this._lastStarFillingIndex = heartCountRow;
			this._currentPlayerMana = lifePerHeart;
			this._lastStarFillingIndex = heartCountRow;
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x0027A878 File Offset: 0x00278A78
		public void TryToHover()
		{
			if (this._hoverLife)
			{
				CommonResourceBarMethods.DrawLifeMouseOver();
			}
			if (this._hoverMana)
			{
				CommonResourceBarMethods.DrawManaMouseOver();
				return;
			}
		}

		// Token: 0x04008852 RID: 34898
		private float _currentPlayerLife;

		// Token: 0x04008853 RID: 34899
		private float _lifePerHeart;

		// Token: 0x04008854 RID: 34900
		private int _playerLifeFruitCount;

		// Token: 0x04008855 RID: 34901
		private int _lastHeartFillingIndex;

		// Token: 0x04008856 RID: 34902
		private int _lastHeartPanelIndex;

		// Token: 0x04008857 RID: 34903
		private int _heartCountRow1;

		// Token: 0x04008858 RID: 34904
		private int _heartCountRow2;

		// Token: 0x04008859 RID: 34905
		private int _starCount;

		// Token: 0x0400885A RID: 34906
		private int _lastStarFillingIndex;

		// Token: 0x0400885B RID: 34907
		private float _manaPerStar;

		// Token: 0x0400885C RID: 34908
		private float _currentPlayerMana;

		// Token: 0x0400885D RID: 34909
		private Asset<Texture2D> _heartLeft;

		// Token: 0x0400885E RID: 34910
		private Asset<Texture2D> _heartMiddle;

		// Token: 0x0400885F RID: 34911
		private Asset<Texture2D> _heartRight;

		// Token: 0x04008860 RID: 34912
		private Asset<Texture2D> _heartRightFancy;

		// Token: 0x04008861 RID: 34913
		private Asset<Texture2D> _heartFill;

		// Token: 0x04008862 RID: 34914
		private Asset<Texture2D> _heartFillHoney;

		// Token: 0x04008863 RID: 34915
		private Asset<Texture2D> _heartSingleFancy;

		// Token: 0x04008864 RID: 34916
		private Asset<Texture2D> _starTop;

		// Token: 0x04008865 RID: 34917
		private Asset<Texture2D> _starMiddle;

		// Token: 0x04008866 RID: 34918
		private Asset<Texture2D> _starBottom;

		// Token: 0x04008867 RID: 34919
		private Asset<Texture2D> _starSingle;

		// Token: 0x04008868 RID: 34920
		private Asset<Texture2D> _starFill;

		// Token: 0x04008869 RID: 34921
		private bool _hoverLife;

		// Token: 0x0400886A RID: 34922
		private bool _hoverMana;

		// Token: 0x0400886B RID: 34923
		private bool _drawText;

		// Token: 0x0400886C RID: 34924
		[CompilerGenerated]
		private string <NameKey>k__BackingField;

		// Token: 0x0400886D RID: 34925
		[CompilerGenerated]
		private string <ConfigKey>k__BackingField;
	}
}
