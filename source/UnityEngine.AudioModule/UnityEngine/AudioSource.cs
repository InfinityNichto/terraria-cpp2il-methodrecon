using System;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	[RequireComponent(typeof(Transform))]
	public sealed class AudioSource : AudioBehaviour
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000022E8 File Offset: 0x000004E8
		private static void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000022FC File Offset: 0x000004FC
		private static void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002310 File Offset: 0x00000510
		private void Stop(bool stopOneShots)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002338 File Offset: 0x00000538
		public float volume
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000234C File Offset: 0x0000054C
		public float pitch
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002360 File Offset: 0x00000560
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002374 File Offset: 0x00000574
		[NativeProperty("SecPosition")]
		public float time
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002388 File Offset: 0x00000588
		[NativeProperty("AudioClip")]
		public AudioClip clip
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000239C File Offset: 0x0000059C
		public AudioMixerGroup outputAudioMixerGroup
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000023B0 File Offset: 0x000005B0
		[ExcludeFromDocs]
		public void Play()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000023C4 File Offset: 0x000005C4
		public void Stop()
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000023D8 File Offset: 0x000005D8
		public bool loop
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000023EC File Offset: 0x000005EC
		[NativeProperty("StereoPan")]
		public float panStereo
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002400 File Offset: 0x00000600
		public int priority
		{
			set
			{
				throw new MissingMethodException();
			}
		}
	}
}
