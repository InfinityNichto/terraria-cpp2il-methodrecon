using System;
using System.Collections.Generic;
using ReLogic.Content.Sources;

namespace Terraria.Audio
{
	// Token: 0x02000687 RID: 1671
	public interface IAudioSystem : IDisposable
	{
		// Token: 0x060037C2 RID: 14274
		void LoadCue(int cueIndex, string cueName);

		// Token: 0x060037C3 RID: 14275
		void PauseAll();

		// Token: 0x060037C4 RID: 14276
		void ResumeAll();

		// Token: 0x060037C5 RID: 14277
		void UpdateMisc();

		// Token: 0x060037C6 RID: 14278
		void UpdateAudioEngine();

		// Token: 0x060037C7 RID: 14279
		void UpdateAmbientCueState(int i, bool gameIsActive, float trackVolume, float systemVolume);

		// Token: 0x060037C8 RID: 14280
		void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, float trackVolume, float systemVolume);

		// Token: 0x060037C9 RID: 14281
		void UpdateCommonTrack(bool active, int i, float totalVolume, float tempFade);

		// Token: 0x060037CA RID: 14282
		void UpdateCommonTrackTowardStopping(int i, float totalVolume, float tempFade, bool isMainTrackAudible);

		// Token: 0x060037CB RID: 14283
		bool IsTrackPlaying(int trackIndex);

		// Token: 0x060037CC RID: 14284
		void UseSources(List<IContentSource> sources);

		// Token: 0x060037CD RID: 14285
		void LoadFromSources();

		// Token: 0x060037CE RID: 14286
		void Update();
	}
}
