using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200014D RID: 333
	[RequiredByNativeCode]
	[Serializable]
	public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x0000B368 File Offset: 0x00009568
		public PlayableBehaviour()
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000B37C File Offset: 0x0000957C
		public virtual void OnGraphStart(Playable playable)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000B38C File Offset: 0x0000958C
		public virtual void OnGraphStop(Playable playable)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000B39C File Offset: 0x0000959C
		public virtual void OnPlayableCreate(Playable playable)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000B3AC File Offset: 0x000095AC
		public virtual void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000B3BC File Offset: 0x000095BC
		public virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000B3CC File Offset: 0x000095CC
		public virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000B3DC File Offset: 0x000095DC
		public virtual void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000B3EC File Offset: 0x000095EC
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000B3FC File Offset: 0x000095FC
		public virtual object Clone()
		{
			return base.MemberwiseClone();
		}
	}
}
