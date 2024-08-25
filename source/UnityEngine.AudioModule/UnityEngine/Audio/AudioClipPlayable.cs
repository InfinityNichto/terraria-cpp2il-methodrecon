using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x0200000F RID: 15
	[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
	[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
	public struct AudioClipPlayable : IEquatable<AudioClipPlayable>
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002440 File Offset: 0x00000640
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002454 File Offset: 0x00000654
		public bool Equals(AudioClipPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0400000A RID: 10
		private PlayableHandle m_Handle;
	}
}
