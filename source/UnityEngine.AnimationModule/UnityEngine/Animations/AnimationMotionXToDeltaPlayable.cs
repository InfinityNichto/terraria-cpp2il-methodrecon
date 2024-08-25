using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200001B RID: 27
	[RequiredByNativeCode]
	[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
	internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable>
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000025A4 File Offset: 0x000007A4
		private AnimationMotionXToDeltaPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000025B4 File Offset: 0x000007B4
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000025C8 File Offset: 0x000007C8
		public bool Equals(AnimationMotionXToDeltaPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000025E0 File Offset: 0x000007E0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationMotionXToDeltaPlayable()
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
		}

		// Token: 0x04000049 RID: 73
		private PlayableHandle m_Handle;

		// Token: 0x0400004A RID: 74
		private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable;
	}
}
