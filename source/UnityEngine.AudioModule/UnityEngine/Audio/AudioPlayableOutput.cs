using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x0200000B RID: 11
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
	public struct AudioPlayableOutput
	{
		// Token: 0x04000009 RID: 9
		private PlayableOutputHandle m_Handle;
	}
}
