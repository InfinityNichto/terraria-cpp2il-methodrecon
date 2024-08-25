using System;
using UnityEngine;

// Token: 0x0200004F RID: 79
public class SoundChannel
{
	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x00004D14 File Offset: 0x00002F14
	// (set) Token: 0x060001A6 RID: 422 RVA: 0x00004D28 File Offset: 0x00002F28
	public SoundInstance CurrentSound
	{
		get
		{
			return this._currentSound;
		}
		set
		{
			if (this._currentSound != null)
			{
			}
			this._currentSound = value;
		}
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00004D44 File Offset: 0x00002F44
	public SoundChannel()
	{
	}

	// Token: 0x0400011C RID: 284
	public AudioSource AudioSource;

	// Token: 0x0400011D RID: 285
	private SoundInstance _currentSound;
}
