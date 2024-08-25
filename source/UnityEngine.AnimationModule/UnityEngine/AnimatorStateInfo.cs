using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorStateInfo
	{
		// Token: 0x0400002A RID: 42
		private int m_Name;

		// Token: 0x0400002B RID: 43
		private int m_Path;

		// Token: 0x0400002C RID: 44
		private int m_FullPath;

		// Token: 0x0400002D RID: 45
		private float m_NormalizedTime;

		// Token: 0x0400002E RID: 46
		private float m_Length;

		// Token: 0x0400002F RID: 47
		private float m_Speed;

		// Token: 0x04000030 RID: 48
		private float m_SpeedMultiplier;

		// Token: 0x04000031 RID: 49
		private int m_Tag;

		// Token: 0x04000032 RID: 50
		private int m_Loop;
	}
}
