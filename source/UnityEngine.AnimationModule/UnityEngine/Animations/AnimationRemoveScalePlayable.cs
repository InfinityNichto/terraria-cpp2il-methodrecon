using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000013 RID: 19
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable>
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002358 File Offset: 0x00000558
		internal AnimationRemoveScalePlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002368 File Offset: 0x00000568
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000237C File Offset: 0x0000057C
		public bool Equals(AnimationRemoveScalePlayable other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000238C File Offset: 0x0000058C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationRemoveScalePlayable()
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
		}

		// Token: 0x0400003B RID: 59
		private PlayableHandle m_Handle;

		// Token: 0x0400003C RID: 60
		private static readonly AnimationRemoveScalePlayable m_NullPlayable;
	}
}
