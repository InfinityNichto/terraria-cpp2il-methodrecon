using System;

namespace UnityEngine.UI
{
	// Token: 0x02000052 RID: 82
	[AddComponentMenu("Layout/Vertical Layout Group", 151)]
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x0600032C RID: 812 RVA: 0x0000A990 File Offset: 0x00008B90
		protected VerticalLayoutGroup()
		{
			long num = 16843009L;
			this.m_ChildForceExpandWidth = num != 0L;
			base..ctor();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			long num = 0L;
			base.CalcAlongAxis((int)num, true);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		public override void CalculateLayoutInputVertical()
		{
			base.CalcAlongAxis(1, true);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		public override void SetLayoutHorizontal()
		{
			long num = 0L;
			base.SetChildrenAlongAxis((int)num, true);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000AA00 File Offset: 0x00008C00
		public override void SetLayoutVertical()
		{
			base.SetChildrenAlongAxis(1, true);
		}
	}
}
