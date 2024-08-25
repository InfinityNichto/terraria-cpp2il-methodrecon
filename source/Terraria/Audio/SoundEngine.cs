using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Utilities;

namespace Terraria.Audio
{
	// Token: 0x0200068B RID: 1675
	public static class SoundEngine
	{
		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x00224AA4 File Offset: 0x00222CA4
		public static bool IsAudioSupported
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00224AB4 File Offset: 0x00222CB4
		public static void Initialize()
		{
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00224AC4 File Offset: 0x00222CC4
		public static void Load(IServiceProvider services)
		{
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00224AD4 File Offset: 0x00222CD4
		public static void Update()
		{
			SoundInstanceGarbageCollector.Update();
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00224AEC File Offset: 0x00222CEC
		public static void Reload()
		{
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00224AFC File Offset: 0x00222CFC
		public static void PlaySound(int type, Vector2 position, int style = 1)
		{
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00224B0C File Offset: 0x00222D0C
		public static SoundEffectInstance PlaySound(LegacySoundStyle type, Vector2 position)
		{
			SoundEffectInstance soundEffectInstance;
			return soundEffectInstance;
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00224B1C File Offset: 0x00222D1C
		public static SoundEffectInstance PlaySound(LegacySoundStyle type, int x = -1, int y = -1)
		{
			SoundEffectInstance soundEffectInstance;
			return soundEffectInstance;
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00224B2C File Offset: 0x00222D2C
		public static SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
		{
			if (!true)
			{
			}
			if (true)
			{
			}
			SoundEffectInstance soundEffectInstance;
			return soundEffectInstance;
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00224B44 File Offset: 0x00222D44
		public static ActiveSound GetActiveSound(SlotId id)
		{
			if (!true)
			{
			}
			if (true)
			{
			}
			ActiveSound activeSound;
			return activeSound;
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00224B5C File Offset: 0x00222D5C
		public static SlotId PlayTrackedSound(SoundStyle style, Vector2 position)
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				return 1;
			}
			SlotId slotId;
			return slotId;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00224B78 File Offset: 0x00222D78
		public static SlotId PlayTrackedLoopedSound(SoundStyle style, Vector2 position, [Optional] ActiveSound.LoopedPlayCondition loopingCondition)
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				return 1;
			}
			SlotId slotId;
			return slotId;
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00224B94 File Offset: 0x00222D94
		public static SlotId PlayTrackedSound(SoundStyle style)
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				return 1;
			}
			SlotId slotId;
			return slotId;
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00224BB0 File Offset: 0x00222DB0
		public static void StopTrackedSounds()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x00224BC4 File Offset: 0x00222DC4
		public static SoundEffect GetTrackableSoundByStyleId(int id)
		{
			if (!true)
			{
			}
			if (true)
			{
			}
			SoundEffect soundEffect;
			return soundEffect;
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x00224BDC File Offset: 0x00222DDC
		public static void StopAmbientSounds()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00224BF0 File Offset: 0x00222DF0
		public static ActiveSound FindActiveSound(SoundStyle style)
		{
			if (!true)
			{
			}
			if (true)
			{
			}
			ActiveSound activeSound;
			return activeSound;
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x00224C08 File Offset: 0x00222E08
		private static bool TestAudioSupport()
		{
			return true;
		}

		// Token: 0x04007903 RID: 30979
		public static LegacySoundPlayer LegacySoundPlayer;

		// Token: 0x04007904 RID: 30980
		public static SoundPlayer SoundPlayer;

		// Token: 0x04007905 RID: 30981
		public static bool AreSoundsPaused;

		// Token: 0x04007906 RID: 30982
		[CompilerGenerated]
		private static bool <IsAudioSupported>k__BackingField;
	}
}
