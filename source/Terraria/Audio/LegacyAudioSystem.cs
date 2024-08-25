using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content.Sources;
using UnityEngine;

namespace Terraria.Audio
{
	// Token: 0x02000688 RID: 1672
	public class LegacyAudioSystem : IAudioSystem, IDisposable
	{
		// Token: 0x060037CF RID: 14287 RVA: 0x002225A4 File Offset: 0x002207A4
		public void LoadFromSources()
		{
			SoundEffectInstance audioInstance = this.AudioTracks._audioInstance;
			Dictionary<int, string> trackNamesByIndex = this.TrackNamesByIndex;
			if (audioInstance == null)
			{
			}
			Dictionary<int, Cue> defaultTrackByIndex = this.DefaultTrackByIndex;
			Cue[] audioTracks = this.AudioTracks;
			Cue[] audioTracks2 = this.AudioTracks;
			if (defaultTrackByIndex == null)
			{
				string text2;
				string text = "Missing music " + text2;
				Debug.LogError(defaultTrackByIndex);
				Cue[] audioTracks3 = this.AudioTracks;
				return;
			}
			if (defaultTrackByIndex != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0022260C File Offset: 0x0022080C
		public void UseSources(List<IContentSource> sourcesFromLowestToHighest)
		{
			this.FileSources = sourcesFromLowestToHighest;
			this.LoadFromSources();
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00222628 File Offset: 0x00220828
		public void Update()
		{
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00222638 File Offset: 0x00220838
		public LegacyAudioSystem()
		{
			AudioEngine engine = this.Engine;
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x0022264C File Offset: 0x0022084C
		public void LoadCue(int cueIndex, string cueName)
		{
			this.SoundBank.LoadMusicId(cueIndex);
			Cue cue = this.SoundBank.GetCue(cueName);
			Dictionary<int, string> trackNamesByIndex = this.TrackNamesByIndex;
			Dictionary<int, Cue> defaultTrackByIndex = this.DefaultTrackByIndex;
			Cue[] audioTracks = this.AudioTracks;
			if (cue == null || cue != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00222694 File Offset: 0x00220894
		public void UpdateMisc()
		{
			if (!true)
			{
			}
			int musicReplayDelay = this.MusicReplayDelay;
			this.MusicReplayDelay = musicReplayDelay;
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x002226B4 File Offset: 0x002208B4
		public void PauseAll()
		{
			if (!true)
			{
			}
			Cue[] audioTracks = this.AudioTracks;
			SoundEffectInstance audioInstance = audioTracks._audioInstance;
			SoundEffect effect = audioTracks._effect;
			if (effect != null && effect._name == null)
			{
				SoundEffect effect2 = this.AudioTracks._effect;
			}
			Cue[] audioTracks2 = this.AudioTracks;
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x00222704 File Offset: 0x00220904
		public void ResumeAll()
		{
			if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
			{
			}
			Cue[] audioTracks = this.AudioTracks;
			SoundEffect effect = audioTracks._effect;
			if (effect == null || effect._name != null)
			{
			}
			Cue[] audioTracks2 = this.AudioTracks;
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x00222744 File Offset: 0x00220944
		public void UpdateAmbientCueState(int i, bool gameIsActive, float trackVolume, float systemVolume)
		{
			Cue[] audioTracks = this.AudioTracks;
			if (audioTracks != null && audioTracks._effect != null)
			{
				SoundEffect effect = this.AudioTracks._effect;
				return;
			}
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x0022279C File Offset: 0x0022099C
		public void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, float trackVolume, float systemVolume)
		{
			Cue[] audioTracks = this.AudioTracks;
			if (audioTracks != null && audioTracks._effect != null)
			{
				Cue[] audioTracks2 = this.AudioTracks;
				SoundEffect effect = audioTracks._effect;
				return;
			}
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x002227CC File Offset: 0x002209CC
		public bool IsTrackPlaying(int trackIndex)
		{
			Cue[] audioTracks = this.AudioTracks;
			if (audioTracks != null && audioTracks._effect != null)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x002227F0 File Offset: 0x002209F0
		public void UpdateCommonTrack(bool active, int i, float totalVolume, float tempFade)
		{
			Cue[] audioTracks = this.AudioTracks;
			if (audioTracks != null && audioTracks._effect != null)
			{
				SoundEffect effect = this.AudioTracks._effect;
				if (this.MusicReplayDelay == 0)
				{
					Cue[] array;
					if (array == null)
					{
					}
					bool settingMusicReplayDelayEnabled = Main.SettingMusicReplayDelayEnabled;
					if (array == null)
					{
					}
					int num;
					this.MusicReplayDelay = num;
					SoundEffect effect2 = this.AudioTracks._effect;
					SoundEffect effect3 = this.AudioTracks._effect;
					return;
				}
			}
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x00222874 File Offset: 0x00220A74
		public void UpdateCommonTrackTowardStopping(int i, float totalVolume, float tempFade, bool isMainTrackAudible)
		{
			Cue[] audioTracks = this.AudioTracks;
			if (audioTracks != null && audioTracks._effect != null)
			{
				SoundEffect effect = this.AudioTracks._effect;
			}
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x002228CC File Offset: 0x00220ACC
		public void UpdateAudioEngine()
		{
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x002228DC File Offset: 0x00220ADC
		public void Dispose()
		{
		}

		// Token: 0x040078AC RID: 30892
		public Cue[] AudioTracks;

		// Token: 0x040078AD RID: 30893
		public int MusicReplayDelay;

		// Token: 0x040078AE RID: 30894
		public AudioEngine Engine;

		// Token: 0x040078AF RID: 30895
		public SoundBank SoundBank;

		// Token: 0x040078B0 RID: 30896
		public WaveBank WaveBank;

		// Token: 0x040078B1 RID: 30897
		public Dictionary<int, string> TrackNamesByIndex;

		// Token: 0x040078B2 RID: 30898
		public Dictionary<int, Cue> DefaultTrackByIndex;

		// Token: 0x040078B3 RID: 30899
		public List<IContentSource> FileSources;
	}
}
