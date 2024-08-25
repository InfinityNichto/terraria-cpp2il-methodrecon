using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x02000010 RID: 16
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable>
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000246C File Offset: 0x0000066C
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002480 File Offset: 0x00000680
		public bool Equals(AudioMixerPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0400000B RID: 11
		private PlayableHandle m_Handle;
	}
}
