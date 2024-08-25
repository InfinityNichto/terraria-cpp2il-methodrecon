using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorTransitionInfo
	{
		// Token: 0x04000033 RID: 51
		[NativeName("fullPathHash")]
		private int m_FullPath;

		// Token: 0x04000034 RID: 52
		[NativeName("userNameHash")]
		private int m_UserName;

		// Token: 0x04000035 RID: 53
		[NativeName("nameHash")]
		private int m_Name;

		// Token: 0x04000036 RID: 54
		[NativeName("hasFixedDuration")]
		private bool m_HasFixedDuration;

		// Token: 0x04000037 RID: 55
		[NativeName("duration")]
		private float m_Duration;

		// Token: 0x04000038 RID: 56
		[NativeName("normalizedTime")]
		private float m_NormalizedTime;

		// Token: 0x04000039 RID: 57
		[NativeName("anyState")]
		private bool m_AnyState;

		// Token: 0x0400003A RID: 58
		[NativeName("transitionType")]
		private int m_TransitionType;
	}
}
