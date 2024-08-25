using System;
using UnityEngine.Audio;

// Token: 0x02000051 RID: 81
public class SoundGroup
{
	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060001AD RID: 429 RVA: 0x00004DD4 File Offset: 0x00002FD4
	public AudioMixerGroup MixerGroup
	{
		get
		{
			AudioMixerGroup group = this._group;
			AudioMixer masterMixer = SoundManager.MasterMixer;
			string mixerGroupPath = this.MixerGroupPath;
			AudioMixerGroup[] array = masterMixer.FindMatchingGroups(mixerGroupPath);
			return this._group;
		}
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00004E04 File Offset: 0x00003004
	public SoundGroup()
	{
	}

	// Token: 0x04000124 RID: 292
	public string Id;

	// Token: 0x04000125 RID: 293
	public string MixerGroupPath;

	// Token: 0x04000126 RID: 294
	private AudioMixerGroup _group;
}
