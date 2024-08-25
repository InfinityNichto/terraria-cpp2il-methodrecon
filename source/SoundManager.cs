using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000053 RID: 83
[ResourceLocation("Managers/SoundManager")]
public class SoundManager : Singleton<SoundManager>
{
	// Token: 0x060001BB RID: 443 RVA: 0x000052C4 File Offset: 0x000034C4
	public override void Init()
	{
		this.SetupChannels(100);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x000052DC File Offset: 0x000034DC
	public override void Shutdown()
	{
		long num = 0L;
		this.SetupChannels((int)num);
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060001BD RID: 445 RVA: 0x000052F4 File Offset: 0x000034F4
	public static AudioMixer MasterMixer
	{
		get
		{
			if (Resources.Load("Audio/MasterMixer") != null)
			{
				return;
			}
		}
	}

	// Token: 0x060001BE RID: 446 RVA: 0x000021DB File Offset: 0x000003DB
	public void SetupChannels(int numChannels)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00005310 File Offset: 0x00003510
	public SoundChannel GetChannel(SoundDefinition soundDefinition)
	{
		if (!true)
		{
		}
		DateTime utcNow = DateTime.UtcNow;
		List<SoundChannel> channels = this._channels;
		if (true)
		{
			if (channels == null)
			{
			}
			List<SoundChannel> channels2 = this._channels;
			while (!true)
			{
			}
			if (channels == null)
			{
			}
			List<SoundChannel> channels3 = this._channels;
			int priority = soundDefinition.Priority;
			int size = channels._size;
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00005390 File Offset: 0x00003590
	public void StopAllSoundsOnChannels(string channelId)
	{
		if (!true)
		{
		}
		DateTime utcNow = DateTime.UtcNow;
		List<SoundChannel> channels = this._channels;
		while (!true)
		{
		}
		if (channels == null)
		{
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x000053D0 File Offset: 0x000035D0
	public bool IsPlaying(SoundDefinition soundDefinition)
	{
		if (!true)
		{
		}
		DateTime utcNow = DateTime.UtcNow;
		List<SoundChannel> channels = this._channels;
		while (!true)
		{
		}
		if (channels == null)
		{
		}
		bool flag;
		return flag;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0000540C File Offset: 0x0000360C
	public SoundManager()
	{
	}

	// Token: 0x04000130 RID: 304
	public AnimationCurve VolumeFalloff;

	// Token: 0x04000131 RID: 305
	private GameObject _soundRoot;

	// Token: 0x04000132 RID: 306
	private List<SoundChannel> _channels;

	// Token: 0x04000133 RID: 307
	private static AudioMixer _mixer;
}
