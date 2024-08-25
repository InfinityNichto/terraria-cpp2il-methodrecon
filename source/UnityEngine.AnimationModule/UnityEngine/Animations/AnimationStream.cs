using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	// Token: 0x0200001D RID: 29
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	public struct AnimationStream
	{
		// Token: 0x0400004D RID: 77
		private uint m_AnimatorBindingsVersion;

		// Token: 0x0400004E RID: 78
		private IntPtr constant;

		// Token: 0x0400004F RID: 79
		private IntPtr input;

		// Token: 0x04000050 RID: 80
		private IntPtr output;

		// Token: 0x04000051 RID: 81
		private IntPtr workspace;

		// Token: 0x04000052 RID: 82
		private IntPtr inputStreamAccessor;

		// Token: 0x04000053 RID: 83
		private IntPtr animationHandleBinder;
	}
}
