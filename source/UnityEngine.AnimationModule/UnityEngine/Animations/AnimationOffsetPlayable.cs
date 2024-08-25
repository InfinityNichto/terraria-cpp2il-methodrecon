using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000015 RID: 21
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
	internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable>
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002420 File Offset: 0x00000620
		internal AnimationOffsetPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002430 File Offset: 0x00000630
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002444 File Offset: 0x00000644
		public bool Equals(AnimationOffsetPlayable other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002454 File Offset: 0x00000654
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationOffsetPlayable()
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
		}

		// Token: 0x0400003F RID: 63
		private PlayableHandle m_Handle;

		// Token: 0x04000040 RID: 64
		private static readonly AnimationOffsetPlayable m_NullPlayable;
	}
}
