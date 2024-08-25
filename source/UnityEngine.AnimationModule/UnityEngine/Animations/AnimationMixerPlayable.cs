using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200001C RID: 28
	[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
	[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable>
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000025F8 File Offset: 0x000007F8
		internal AnimationMixerPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002608 File Offset: 0x00000808
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000261C File Offset: 0x0000081C
		public bool Equals(AnimationMixerPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002634 File Offset: 0x00000834
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationMixerPlayable()
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
		}

		// Token: 0x0400004B RID: 75
		private PlayableHandle m_Handle;

		// Token: 0x0400004C RID: 76
		private static readonly AnimationMixerPlayable m_NullPlayable;
	}
}
