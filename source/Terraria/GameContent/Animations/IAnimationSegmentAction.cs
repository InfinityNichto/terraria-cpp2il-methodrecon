using System;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000971 RID: 2417
	public interface IAnimationSegmentAction<T>
	{
		// Token: 0x06004843 RID: 18499
		void BindTo(T obj);

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06004844 RID: 18500
		int ExpectedLengthOfActionInFrames { get; }

		// Token: 0x06004845 RID: 18501
		void ApplyTo(T obj, float localTimeForObj);

		// Token: 0x06004846 RID: 18502
		void SetDelay(float delay);
	}
}
