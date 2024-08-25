using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000017 RID: 23
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable>
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000024C0 File Offset: 0x000006C0
		internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000024D4 File Offset: 0x000006D4
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000024E8 File Offset: 0x000006E8
		public bool Equals(AnimationLayerMixerPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002500 File Offset: 0x00000700
		[NativeThrows]
		private static void SetSingleLayerOptimizationInternal(PlayableHandle handle, bool value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002514 File Offset: 0x00000714
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationLayerMixerPlayable()
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
		}

		// Token: 0x04000043 RID: 67
		private PlayableHandle m_Handle;

		// Token: 0x04000044 RID: 68
		private static readonly AnimationLayerMixerPlayable m_NullPlayable;
	}
}
