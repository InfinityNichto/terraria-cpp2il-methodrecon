using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000014 RID: 20
	[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable>
	{
		// Token: 0x06000025 RID: 37 RVA: 0x000023A4 File Offset: 0x000005A4
		internal AnimatorControllerPlayable(PlayableHandle handle)
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
			this.m_Handle = @null;
			this.SetHandle(handle);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000023CC File Offset: 0x000005CC
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000023E0 File Offset: 0x000005E0
		public void SetHandle(PlayableHandle handle)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000023F0 File Offset: 0x000005F0
		public bool Equals(AnimatorControllerPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002408 File Offset: 0x00000608
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorControllerPlayable()
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
		}

		// Token: 0x0400003D RID: 61
		private PlayableHandle m_Handle;

		// Token: 0x0400003E RID: 62
		private static readonly AnimatorControllerPlayable m_NullPlayable;
	}
}
