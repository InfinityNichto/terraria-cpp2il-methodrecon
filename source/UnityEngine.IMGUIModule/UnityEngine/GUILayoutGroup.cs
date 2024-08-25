using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000019 RID: 25
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
	internal class GUILayoutGroup : GUILayoutEntry
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00004048 File Offset: 0x00002248
		public override int marginLeft
		{
			get
			{
				return this.m_MarginLeft;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000405C File Offset: 0x0000225C
		public override int marginRight
		{
			get
			{
				return this.m_MarginRight;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004070 File Offset: 0x00002270
		public override int marginTop
		{
			get
			{
				return this.m_MarginTop;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00004084 File Offset: 0x00002284
		public override int marginBottom
		{
			get
			{
				return this.m_MarginBottom;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004098 File Offset: 0x00002298
		public GUILayoutGroup()
		{
			if (!true)
			{
			}
			GUIStyle guistyle = GUIStyle.none;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000040BC File Offset: 0x000022BC
		public override void ApplyOptions(GUILayoutOption[] options)
		{
			if (options != null)
			{
				base.ApplyOptions(options);
				object value = options.value;
				int num = 1;
				this.m_UserSpecifiedWidth = num != 0;
				return;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000040FC File Offset: 0x000022FC
		protected override void ApplyStyleSettings(GUIStyle style)
		{
			base.ApplyStyleSettings(style);
			RectOffset margin = style.margin;
			int left = margin.left;
			this.m_MarginLeft = left;
			int right = margin.right;
			this.m_MarginRight = right;
			int top = margin.top;
			this.m_MarginTop = top;
			int bottom = margin.bottom;
			this.m_MarginBottom = bottom;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004154 File Offset: 0x00002354
		public void ResetCursor()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004164 File Offset: 0x00002364
		public GUILayoutEntry GetNext()
		{
			int cursor = this.m_Cursor;
			throw new MissingMethodException();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000020F5 File Offset: 0x000002F5
		public void Add(GUILayoutEntry e)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000020F5 File Offset: 0x000002F5
		public override void CalcWidth()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000041B8 File Offset: 0x000023B8
		public override void SetHorizontal(float x, float width)
		{
			bool flag = this.resetCoords;
			RectOffset padding = this.m_Style.padding;
			bool flag2 = this.isVertical;
			GUIStyle style = this.m_Style;
			GUIStyle guistyle = GUIStyle.none;
			if (!flag2)
			{
				int left = padding.left;
				int right = padding.right;
				if (this.entries._size != 0)
				{
					int size = this.entries._size;
				}
				List<GUILayoutEntry> list = this.entries;
				float num = this.spacing;
				float childMinWidth = this.m_ChildMinWidth;
				float childMaxWidth = this.m_ChildMaxWidth;
				int size2 = list._size;
				int stretchableCountX = this.m_StretchableCountX;
				float minWidth = this.minWidth;
				float maxWidth = this.maxWidth;
				bool consideredForMargin = this.consideredForMargin;
				int stretchWidth = this.stretchWidth;
				if (consideredForMargin)
				{
				}
				return;
			}
			List<GUILayoutEntry> list2 = this.entries;
			int left2 = padding.left;
			int right2 = padding.right;
			if (this.stretchWidth != 0)
			{
				throw new MissingMethodException();
			}
			float minWidth2 = this.minWidth;
			float maxWidth2 = this.maxWidth;
			throw new MissingMethodException();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004324 File Offset: 0x00002524
		public override void CalcHeight()
		{
			if (this.entries._size == 0)
			{
				int vertical = this.m_Style.padding.vertical;
				return;
			}
			if (this.isVertical)
			{
				return;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000044D4 File Offset: 0x000026D4
		public override void SetVertical(float y, float height)
		{
			if (this.entries._size == 0)
			{
				return;
			}
			RectOffset padding = this.m_Style.padding;
			bool flag = this.resetCoords;
			bool flag2 = this.isVertical;
			GUIStyle style = this.m_Style;
			GUIStyle guistyle = GUIStyle.none;
			if (flag2)
			{
				int top = padding.top;
				int bottom = padding.bottom;
				if (this.entries._size != 0)
				{
					int size = this.entries._size;
				}
				List<GUILayoutEntry> list = this.entries;
				float num = this.spacing;
				float childMinHeight = this.m_ChildMinHeight;
				float childMaxHeight = this.m_ChildMaxHeight;
				int size2 = list._size;
				int stretchableCountY = this.m_StretchableCountY;
				if (stretchableCountY != 0)
				{
				}
				return;
			}
			List<GUILayoutEntry> list2 = this.entries;
			if (this.stretchHeight != 0)
			{
				throw new MissingMethodException();
			}
			float minHeight = this.minHeight;
			float maxHeight = this.maxHeight;
			throw new MissingMethodException();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004620 File Offset: 0x00002820
		public override string ToString()
		{
			if (!true)
			{
			}
			return "" + " ";
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000046C8 File Offset: 0x000028C8
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutGroup()
		{
			if (!true)
			{
			}
			GUIStyle guistyle = GUIStyle.none;
		}

		// Token: 0x040000A7 RID: 167
		public List<GUILayoutEntry> entries;

		// Token: 0x040000A8 RID: 168
		public bool isVertical = true;

		// Token: 0x040000A9 RID: 169
		public bool resetCoords;

		// Token: 0x040000AA RID: 170
		public float spacing;

		// Token: 0x040000AB RID: 171
		public bool sameSize = true;

		// Token: 0x040000AC RID: 172
		public bool isWindow;

		// Token: 0x040000AD RID: 173
		public int windowID;

		// Token: 0x040000AE RID: 174
		private int m_Cursor;

		// Token: 0x040000AF RID: 175
		protected int m_StretchableCountX;

		// Token: 0x040000B0 RID: 176
		protected int m_StretchableCountY;

		// Token: 0x040000B1 RID: 177
		protected bool m_UserSpecifiedWidth;

		// Token: 0x040000B2 RID: 178
		protected bool m_UserSpecifiedHeight;

		// Token: 0x040000B3 RID: 179
		protected float m_ChildMinWidth;

		// Token: 0x040000B4 RID: 180
		protected float m_ChildMaxWidth;

		// Token: 0x040000B5 RID: 181
		protected float m_ChildMinHeight;

		// Token: 0x040000B6 RID: 182
		protected float m_ChildMaxHeight;

		// Token: 0x040000B7 RID: 183
		protected int m_MarginLeft;

		// Token: 0x040000B8 RID: 184
		protected int m_MarginRight;

		// Token: 0x040000B9 RID: 185
		protected int m_MarginTop;

		// Token: 0x040000BA RID: 186
		protected int m_MarginBottom;

		// Token: 0x040000BB RID: 187
		private static readonly GUILayoutEntry none;
	}
}
