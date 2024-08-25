using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200001A RID: 26
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable>
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002558 File Offset: 0x00000758
		internal AnimationPosePlayable(PlayableHandle handle)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002568 File Offset: 0x00000768
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000257C File Offset: 0x0000077C
		public bool Equals(AnimationPosePlayable other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000258C File Offset: 0x0000078C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPosePlayable()
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
		}

		// Token: 0x04000047 RID: 71
		private PlayableHandle m_Handle;

		// Token: 0x04000048 RID: 72
		private static readonly AnimationPosePlayable m_NullPlayable;
	}
}
