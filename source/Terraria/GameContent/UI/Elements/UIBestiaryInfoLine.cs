using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AA6 RID: 2726
	public class UIBestiaryInfoLine<T> : UIElement, IManuallyOrderedUIElement
	{
		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06005054 RID: 20564 RVA: 0x0027CEB4 File Offset: 0x0027B0B4
		public int OrderInUIList
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06005055 RID: 20565 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06005056 RID: 20566 RVA: 0x0027CEC4 File Offset: 0x0027B0C4
		public float TextScale
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06005057 RID: 20567 RVA: 0x0027CED4 File Offset: 0x0027B0D4
		public Vector2 TextSize
		{
			get
			{
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06005058 RID: 20568 RVA: 0x0027CEE4 File Offset: 0x0027B0E4
		public string Text
		{
			get
			{
				if ("" != null)
				{
					return "";
				}
				return "";
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06005059 RID: 20569 RVA: 0x0027CF04 File Offset: 0x0027B104
		// (set) Token: 0x0600505A RID: 20570 RVA: 0x0027CF14 File Offset: 0x0027B114
		public Color TextColor
		{
			get
			{
				Color color;
				return color;
			}
			set
			{
			}
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x0027CF24 File Offset: 0x0027B124
		public UIBestiaryInfoLine(T text, float textScale = 1f)
		{
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x0027CF40 File Offset: 0x0027B140
		public override void Recalculate()
		{
			base.Recalculate();
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x0027CF54 File Offset: 0x0027B154
		public void SetText(T text)
		{
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x0027CF64 File Offset: 0x0027B164
		public virtual void SetText(T text, float textScale)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x0027CF7C File Offset: 0x0027B17C
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x0027CF8C File Offset: 0x0027B18C
		public override int CompareTo(object obj)
		{
			if (obj != null)
			{
			}
			return base.CompareTo(obj);
		}

		// Token: 0x0400891C RID: 35100
		private T _text;

		// Token: 0x0400891D RID: 35101
		private float _textScale;

		// Token: 0x0400891E RID: 35102
		private Vector2 _textSize;

		// Token: 0x0400891F RID: 35103
		private Color _color;

		// Token: 0x04008920 RID: 35104
		[CompilerGenerated]
		private int <OrderInUIList>k__BackingField;
	}
}
