using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000018 RID: 24
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
	[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable>
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000252C File Offset: 0x0000072C
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002540 File Offset: 0x00000740
		public bool Equals(AnimationClipPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x04000045 RID: 69
		private PlayableHandle m_Handle;
	}
}
