using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A91 RID: 2705
	public class GroupOptionButton<T> : UIElement, IGroupOptionButton
	{
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06004FDE RID: 20446 RVA: 0x000021DB File Offset: 0x000003DB
		public T OptionValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x0027B9D4 File Offset: 0x00279BD4
		public bool IsSelected
		{
			get
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x000021DB File Offset: 0x000003DB
		public GroupOptionButton(T option, LocalizedText title, LocalizedText description, Color textColor, string iconTexturePath, float textSize = 1f, float titleAlignmentX = 0.5f, float titleWidthReduction = 10f)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x0027B9E4 File Offset: 0x00279BE4
		public void SetText(LocalizedText text, float textSize, Color color)
		{
			int num = 1;
			if (num == 0)
			{
			}
			StyleDimension styleDimension = StyleDimension.FromPixels(textSize);
			num.m_value = color;
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x0027BA0C File Offset: 0x00279C0C
		public void SetCurrentOption(T option)
		{
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x0027BA1C File Offset: 0x00279C1C
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num == 0)
			{
				return;
			}
			if (num != 0)
			{
				return;
			}
			if (num != 0)
			{
			}
			int num2 = 32640;
			int num3;
			if (10 != 0)
			{
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				num3 = 10;
			}
			int num4;
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				num4 = 10;
			}
			if (num4 != 0)
			{
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
			}
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x0027BA6C File Offset: 0x00279C6C
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			base.LeftMouseDown(evt);
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x0027BA80 File Offset: 0x00279C80
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x0027BA94 File Offset: 0x00279C94
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x0027BAA8 File Offset: 0x00279CA8
		public void SetColor(Color color, float opacity)
		{
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x0027BAB8 File Offset: 0x00279CB8
		public void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked)
		{
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x0027BAC8 File Offset: 0x00279CC8
		public void SetBorderColor(Color color)
		{
		}

		// Token: 0x040088B7 RID: 34999
		private T _currentOption;

		// Token: 0x040088B8 RID: 35000
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x040088B9 RID: 35001
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x040088BA RID: 35002
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x040088BB RID: 35003
		private readonly Asset<Texture2D> _iconTexture;

		// Token: 0x040088BC RID: 35004
		private readonly T _myOption;

		// Token: 0x040088BD RID: 35005
		private Color _color;

		// Token: 0x040088BE RID: 35006
		private Color _borderColor;

		// Token: 0x040088BF RID: 35007
		public float FadeFromBlack;

		// Token: 0x040088C0 RID: 35008
		private float _whiteLerp;

		// Token: 0x040088C1 RID: 35009
		private float _opacity;

		// Token: 0x040088C2 RID: 35010
		private bool _hovered;

		// Token: 0x040088C3 RID: 35011
		private bool _soundedHover;

		// Token: 0x040088C4 RID: 35012
		public bool ShowHighlightWhenSelected;

		// Token: 0x040088C5 RID: 35013
		private bool _UseOverrideColors;

		// Token: 0x040088C6 RID: 35014
		private Color _overrideUnpickedColor;

		// Token: 0x040088C7 RID: 35015
		private Color _overridePickedColor;

		// Token: 0x040088C8 RID: 35016
		private float _overrideOpacityPicked;

		// Token: 0x040088C9 RID: 35017
		private float _overrideOpacityUnpicked;

		// Token: 0x040088CA RID: 35018
		public readonly LocalizedText Description;

		// Token: 0x040088CB RID: 35019
		private UIText _title;
	}
}
