using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	internal sealed class GUIScrollGroup : GUILayoutGroup
	{
		// Token: 0x060000EF RID: 239 RVA: 0x000046E0 File Offset: 0x000028E0
		[RequiredByNativeCode]
		public GUIScrollGroup()
		{
			if (257 == 0)
			{
			}
			base..ctor();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004708 File Offset: 0x00002908
		public override void CalcWidth()
		{
			bool flag = this.allowHorizontalScroll;
			float minWidth = this.minWidth;
			float maxWidth = this.maxWidth;
			if (flag)
			{
			}
			base.CalcWidth();
			float minWidth2 = this.minWidth;
			bool flag2 = this.allowHorizontalScroll;
			this.calcMinWidth = minWidth2;
			if (flag2)
			{
				this.maxWidth = maxWidth;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004754 File Offset: 0x00002954
		public override void SetHorizontal(float x, float width)
		{
			if (this.needsVerticalScrollbar)
			{
				GUIStyle guistyle = this.verticalScrollbar;
				throw new MissingMethodException();
			}
			if (this.allowHorizontalScroll)
			{
				float num = this.calcMinWidth;
				float num2 = this.calcMaxWidth;
				int num3 = 1;
				this.needsHorizontalScrollbar = num3 != 0;
				this.minWidth = num;
				this.maxWidth = num2;
				base.SetHorizontal(x, width);
				float num4 = this.calcMinWidth;
				this.clientWidth = num4;
				return;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000047F0 File Offset: 0x000029F0
		public override void CalcHeight()
		{
			bool flag = this.allowVerticalScroll;
			float minHeight = this.minHeight;
			float maxHeight = this.maxHeight;
			if (flag)
			{
			}
			base.CalcHeight();
			float minHeight2 = this.minHeight;
			bool flag2 = this.needsHorizontalScrollbar;
			this.calcMinHeight = minHeight2;
			if (flag2)
			{
				GUIStyle guistyle = this.horizontalScrollbar;
				throw new MissingMethodException();
			}
			if (this.allowVerticalScroll)
			{
				this.maxHeight = maxHeight;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004874 File Offset: 0x00002A74
		public override void SetVertical(float y, float height)
		{
			if (this.needsHorizontalScrollbar)
			{
				GUIStyle guistyle = this.horizontalScrollbar;
				throw new MissingMethodException();
			}
			if (!this.allowVerticalScroll)
			{
				float num;
				base.SetVertical(y, num);
				return;
			}
			float num2 = this.calcMinHeight;
			if (!this.needsHorizontalScrollbar && !this.needsVerticalScrollbar)
			{
				GUIStyle guistyle2 = this.verticalScrollbar;
				throw new MissingMethodException();
			}
			float num3 = this.calcMaxHeight;
			float minHeight = this.minHeight;
			Rect rect = this.rect;
			float num4;
			this.minHeight = num4;
			this.maxHeight = num3;
			base.SetVertical(y, height);
			this.minHeight = minHeight;
			this.rect = rect;
			float num5 = this.calcMinHeight;
			this.clientHeight = num5;
		}

		// Token: 0x040000BC RID: 188
		public float calcMinWidth;

		// Token: 0x040000BD RID: 189
		public float calcMaxWidth;

		// Token: 0x040000BE RID: 190
		public float calcMinHeight;

		// Token: 0x040000BF RID: 191
		public float calcMaxHeight;

		// Token: 0x040000C0 RID: 192
		public float clientWidth;

		// Token: 0x040000C1 RID: 193
		public float clientHeight;

		// Token: 0x040000C2 RID: 194
		public bool allowHorizontalScroll = 257 != 0;

		// Token: 0x040000C3 RID: 195
		public bool allowVerticalScroll;

		// Token: 0x040000C4 RID: 196
		public bool needsHorizontalScrollbar;

		// Token: 0x040000C5 RID: 197
		public bool needsVerticalScrollbar;

		// Token: 0x040000C6 RID: 198
		public GUIStyle horizontalScrollbar;

		// Token: 0x040000C7 RID: 199
		public GUIStyle verticalScrollbar;
	}
}
