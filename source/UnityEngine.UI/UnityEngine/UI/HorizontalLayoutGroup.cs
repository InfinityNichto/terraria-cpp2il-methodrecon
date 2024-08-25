using System;

namespace UnityEngine.UI
{
	// Token: 0x02000044 RID: 68
	[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x06000291 RID: 657 RVA: 0x00009C8C File Offset: 0x00007E8C
		protected HorizontalLayoutGroup()
		{
			long num = 16843009L;
			this.m_ChildForceExpandWidth = num != 0L;
			base..ctor();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00009CAC File Offset: 0x00007EAC
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			long num = 0L;
			long num2 = 0L;
			base.CalcAlongAxis((int)num, num2 != 0L);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00009CCC File Offset: 0x00007ECC
		public override void CalculateLayoutInputVertical()
		{
			long num = 0L;
			base.CalcAlongAxis(1, num != 0L);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00009CE4 File Offset: 0x00007EE4
		public override void SetLayoutHorizontal()
		{
			long num = 0L;
			long num2 = 0L;
			base.SetChildrenAlongAxis((int)num, num2 != 0L);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00009D00 File Offset: 0x00007F00
		public override void SetLayoutVertical()
		{
			long num = 0L;
			base.SetChildrenAlongAxis(1, num != 0L);
		}
	}
}
