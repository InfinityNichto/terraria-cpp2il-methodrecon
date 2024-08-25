using System;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000994 RID: 2452
	public interface IAnimationSegment
	{
		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060048CB RID: 18635
		float DedicatedTimeNeeded { get; }

		// Token: 0x060048CC RID: 18636
		void Draw(GameAnimationSegment info);
	}
}
