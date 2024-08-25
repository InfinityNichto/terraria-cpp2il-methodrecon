using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000040 RID: 64
	[AddComponentMenu("Layout/Grid Layout Group", 152)]
	public class GridLayoutGroup : LayoutGroup
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00009810 File Offset: 0x00007A10
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00009824 File Offset: 0x00007A24
		public GridLayoutGroup.Corner startCorner
		{
			get
			{
				return this.m_StartCorner;
			}
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00009834 File Offset: 0x00007A34
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00009848 File Offset: 0x00007A48
		public GridLayoutGroup.Axis startAxis
		{
			get
			{
				return this.m_StartAxis;
			}
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00009858 File Offset: 0x00007A58
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00009880 File Offset: 0x00007A80
		public Vector2 cellSize
		{
			get
			{
				float x = this.m_CellSize.x;
				float y = this.m_CellSize.y;
				Vector2 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00009890 File Offset: 0x00007A90
		// (set) Token: 0x06000286 RID: 646 RVA: 0x000098B8 File Offset: 0x00007AB8
		public Vector2 spacing
		{
			get
			{
				float x = this.m_Spacing.x;
				float y = this.m_Spacing.y;
				Vector2 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000287 RID: 647 RVA: 0x000098C8 File Offset: 0x00007AC8
		// (set) Token: 0x06000288 RID: 648 RVA: 0x000098DC File Offset: 0x00007ADC
		public GridLayoutGroup.Constraint constraint
		{
			get
			{
				return this.m_Constraint;
			}
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000289 RID: 649 RVA: 0x000098EC File Offset: 0x00007AEC
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00009900 File Offset: 0x00007B00
		public int constraintCount
		{
			get
			{
				return this.m_ConstraintCount;
			}
			set
			{
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00009910 File Offset: 0x00007B10
		protected GridLayoutGroup()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000992C File Offset: 0x00007B2C
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			GridLayoutGroup.Constraint constraint = this.m_Constraint;
			int constraintCount = this.m_ConstraintCount;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000099CC File Offset: 0x00007BCC
		public override void CalculateLayoutInputVertical()
		{
			GridLayoutGroup.Constraint constraint = this.m_Constraint;
			List<RectTransform> rectChildren = this.m_RectChildren;
			int constraintCount = this.m_ConstraintCount;
			int size = rectChildren._size;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00009A9C File Offset: 0x00007C9C
		public override void SetLayoutHorizontal()
		{
			long num = 0L;
			this.SetCellsAlongAxis((int)num);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00009AB4 File Offset: 0x00007CB4
		public override void SetLayoutVertical()
		{
			this.SetCellsAlongAxis(1);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00009AC8 File Offset: 0x00007CC8
		private void SetCellsAlongAxis(int axis)
		{
			int size = this.m_RectChildren._size;
			if (axis != 0)
			{
				Vector2 size2 = base.rectTransform.rect.size;
				Vector2 size3 = base.rectTransform.rect.size;
				GridLayoutGroup.Constraint constraint = this.m_Constraint;
				return;
			}
			float x = this.m_CellSize.x;
			float y = this.m_CellSize.y;
			List<RectTransform> rectChildren = this.m_RectChildren;
		}

		// Token: 0x04000153 RID: 339
		[SerializeField]
		protected GridLayoutGroup.Corner m_StartCorner;

		// Token: 0x04000154 RID: 340
		[SerializeField]
		protected GridLayoutGroup.Axis m_StartAxis;

		// Token: 0x04000155 RID: 341
		[SerializeField]
		protected Vector2 m_CellSize;

		// Token: 0x04000156 RID: 342
		[SerializeField]
		protected Vector2 m_Spacing;

		// Token: 0x04000157 RID: 343
		[SerializeField]
		protected GridLayoutGroup.Constraint m_Constraint;

		// Token: 0x04000158 RID: 344
		[SerializeField]
		protected int m_ConstraintCount = 2;

		// Token: 0x02000041 RID: 65
		public enum Corner
		{
			// Token: 0x0400015A RID: 346
			UpperLeft,
			// Token: 0x0400015B RID: 347
			UpperRight,
			// Token: 0x0400015C RID: 348
			LowerLeft,
			// Token: 0x0400015D RID: 349
			LowerRight
		}

		// Token: 0x02000042 RID: 66
		public enum Axis
		{
			// Token: 0x0400015F RID: 351
			Horizontal,
			// Token: 0x04000160 RID: 352
			Vertical
		}

		// Token: 0x02000043 RID: 67
		public enum Constraint
		{
			// Token: 0x04000162 RID: 354
			Flexible,
			// Token: 0x04000163 RID: 355
			FixedColumnCount,
			// Token: 0x04000164 RID: 356
			FixedRowCount
		}
	}
}
