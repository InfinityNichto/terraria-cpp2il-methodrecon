using System;

namespace UnityEngine.UI
{
	// Token: 0x02000046 RID: 70
	public interface ILayoutElement
	{
		// Token: 0x060002AA RID: 682
		void CalculateLayoutInputHorizontal();

		// Token: 0x060002AB RID: 683
		void CalculateLayoutInputVertical();

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002AC RID: 684
		float minWidth { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002AD RID: 685
		float preferredWidth { get; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002AE RID: 686
		float flexibleWidth { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002AF RID: 687
		float minHeight { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002B0 RID: 688
		float preferredHeight { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002B1 RID: 689
		float flexibleHeight { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002B2 RID: 690
		int layoutPriority { get; }
	}
}
