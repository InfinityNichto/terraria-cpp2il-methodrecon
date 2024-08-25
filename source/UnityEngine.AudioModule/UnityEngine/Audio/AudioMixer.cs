using System;
using UnityEngine.Bindings;

namespace UnityEngine.Audio
{
	// Token: 0x0200000D RID: 13
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
	[ExcludeFromPreset]
	[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
	[ExcludeFromObjectFactory]
	public class AudioMixer : Object
	{
		// Token: 0x06000026 RID: 38 RVA: 0x0000242C File Offset: 0x0000062C
		[NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = true, HasExplicitThis = true)]
		public AudioMixerGroup[] FindMatchingGroups(string subPath)
		{
			throw new MissingMethodException();
		}
	}
}
