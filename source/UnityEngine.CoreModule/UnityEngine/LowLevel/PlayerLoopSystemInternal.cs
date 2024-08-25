using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	// Token: 0x02000172 RID: 370
	[RequiredByNativeCode]
	[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	internal struct PlayerLoopSystemInternal
	{
		// Token: 0x0400066B RID: 1643
		public Type type;

		// Token: 0x0400066C RID: 1644
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		// Token: 0x0400066D RID: 1645
		public IntPtr updateFunction;

		// Token: 0x0400066E RID: 1646
		public IntPtr loopConditionFunction;

		// Token: 0x0400066F RID: 1647
		public int numSubSystems;
	}
}
