using System;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AAA RID: 2730
	public class UISliderBase : UIElement
	{
		// Token: 0x06005075 RID: 20597 RVA: 0x0027D540 File Offset: 0x0027B740
		internal int GetUsageLevel()
		{
			return 1;
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x0027D550 File Offset: 0x0027B750
		public static void EscapeElements()
		{
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x0027D560 File Offset: 0x0027B760
		public UISliderBase()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x04008937 RID: 35127
		internal const int UsageLevel_NotSelected = 0;

		// Token: 0x04008938 RID: 35128
		internal const int UsageLevel_SelectedAndLocked = 1;

		// Token: 0x04008939 RID: 35129
		internal const int UsageLevel_OtherElementIsLocked = 2;

		// Token: 0x0400893A RID: 35130
		internal static UIElement CurrentLockedSlider;

		// Token: 0x0400893B RID: 35131
		internal static UIElement CurrentAimedSlider;
	}
}
