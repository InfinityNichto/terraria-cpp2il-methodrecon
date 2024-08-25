using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AD0 RID: 2768
	public class UITextPanel<T> : UIPanel
	{
		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600517D RID: 20861 RVA: 0x000021DB File Offset: 0x000003DB
		public bool IsLarge
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600517F RID: 20863 RVA: 0x002809B8 File Offset: 0x0027EBB8
		public bool DrawPanel
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06005181 RID: 20865 RVA: 0x002809C8 File Offset: 0x0027EBC8
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

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x002809D8 File Offset: 0x0027EBD8
		public Vector2 TextSize
		{
			get
			{
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06005183 RID: 20867 RVA: 0x002809E8 File Offset: 0x0027EBE8
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

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x00280A08 File Offset: 0x0027EC08
		// (set) Token: 0x06005185 RID: 20869 RVA: 0x00280A18 File Offset: 0x0027EC18
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

		// Token: 0x06005186 RID: 20870 RVA: 0x00280A28 File Offset: 0x0027EC28
		public UITextPanel(T text, float textScale = 1f, bool large = false)
		{
			if (16256 == 0)
			{
			}
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x00280A50 File Offset: 0x0027EC50
		public override void Recalculate()
		{
			base.Recalculate();
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00280A64 File Offset: 0x0027EC64
		public void SetText(T text)
		{
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00280A74 File Offset: 0x0027EC74
		public virtual void SetText(T text, float textScale, bool large)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00280A8C File Offset: 0x0027EC8C
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			base.DrawSelf(spriteBatch);
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x00280AA0 File Offset: 0x0027ECA0
		protected void DrawText(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num != 0)
			{
				if (num != 0)
				{
					T text = this._text;
					return;
				}
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x04008A00 RID: 35328
		protected T _text;

		// Token: 0x04008A01 RID: 35329
		protected float _textScale;

		// Token: 0x04008A02 RID: 35330
		protected Vector2 _textSize;

		// Token: 0x04008A03 RID: 35331
		protected bool _isLarge;

		// Token: 0x04008A04 RID: 35332
		protected Color _color;

		// Token: 0x04008A05 RID: 35333
		protected bool _drawPanel;

		// Token: 0x04008A06 RID: 35334
		public float TextHAlign;

		// Token: 0x04008A07 RID: 35335
		public bool HideContents;

		// Token: 0x04008A08 RID: 35336
		private string _asterisks;
	}
}
