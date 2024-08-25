using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000155 RID: 341
	public interface IPlayableBehaviour
	{
		// Token: 0x06000660 RID: 1632
		[RequiredByNativeCode]
		void OnGraphStart(Playable playable);

		// Token: 0x06000661 RID: 1633
		[RequiredByNativeCode]
		void OnGraphStop(Playable playable);

		// Token: 0x06000662 RID: 1634
		[RequiredByNativeCode]
		void OnPlayableCreate(Playable playable);

		// Token: 0x06000663 RID: 1635
		[RequiredByNativeCode]
		void OnPlayableDestroy(Playable playable);

		// Token: 0x06000664 RID: 1636
		[RequiredByNativeCode]
		void OnBehaviourPlay(Playable playable, FrameData info);

		// Token: 0x06000665 RID: 1637
		[RequiredByNativeCode]
		void OnBehaviourPause(Playable playable, FrameData info);

		// Token: 0x06000666 RID: 1638
		[RequiredByNativeCode]
		void PrepareFrame(Playable playable, FrameData info);

		// Token: 0x06000667 RID: 1639
		[RequiredByNativeCode]
		void ProcessFrame(Playable playable, FrameData info, object playerData);
	}
}
