using System;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.Audio
{
	// Token: 0x0200068D RID: 1677
	public class SoundPlayer
	{
		// Token: 0x0600380B RID: 14347 RVA: 0x00224C5C File Offset: 0x00222E5C
		public SlotId Play(SoundStyle style, Vector2 position)
		{
			if (!true)
			{
			}
			if (style != null && !true)
			{
				Vector2 screenPosition = Main.screenPosition;
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
			}
			SlotVector<ActiveSound> trackedSounds = this._trackedSounds;
			SlotId slotId;
			return slotId;
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00224C9C File Offset: 0x00222E9C
		public SlotId PlayLooped(SoundStyle style, Vector2 position, ActiveSound.LoopedPlayCondition loopingCondition)
		{
			if (!true)
			{
			}
			if (style != null && !true)
			{
				Vector2 screenPosition = Main.screenPosition;
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
			}
			SlotVector<ActiveSound> trackedSounds = this._trackedSounds;
			SlotId slotId;
			return slotId;
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00224CDC File Offset: 0x00222EDC
		public void Reload()
		{
			this.StopAll();
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00224CF0 File Offset: 0x00222EF0
		public SlotId Play(SoundStyle style)
		{
			while (((!true || style == null) && style == null) || true)
			{
			}
			SlotVector<ActiveSound> trackedSounds = this._trackedSounds;
			SlotId slotId;
			return slotId;
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00224D14 File Offset: 0x00222F14
		public ActiveSound GetActiveSound(SlotId id)
		{
			bool flag = this._trackedSounds.Has(id);
			return this._trackedSounds[id];
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00224D3C File Offset: 0x00222F3C
		public void PauseAll()
		{
			SlotVector<ActiveSound> trackedSounds = this._trackedSounds;
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00224D80 File Offset: 0x00222F80
		public void ResumeAll()
		{
			SlotVector<ActiveSound> trackedSounds = this._trackedSounds;
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x00224DC4 File Offset: 0x00222FC4
		public void StopAll()
		{
			SlotVector<ActiveSound> trackedSounds = this._trackedSounds;
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x00224E14 File Offset: 0x00223014
		public void Update()
		{
			SlotVector<ActiveSound> trackedSounds = this._trackedSounds;
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00224E74 File Offset: 0x00223074
		public ActiveSound FindActiveSound(SoundStyle style)
		{
			SlotVector<ActiveSound> trackedSounds = this._trackedSounds;
			long num;
			if (trackedSounds == null)
			{
				num = 0L;
				if (trackedSounds != null)
				{
				}
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00224EBC File Offset: 0x002230BC
		public SoundPlayer()
		{
		}

		// Token: 0x04007908 RID: 30984
		private readonly SlotVector<ActiveSound> _trackedSounds;
	}
}
