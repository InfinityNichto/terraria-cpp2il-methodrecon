using System;

namespace UnityEngine.Playables
{
	// Token: 0x02000148 RID: 328
	public struct FrameData
	{
		// Token: 0x04000616 RID: 1558
		internal ulong m_FrameID;

		// Token: 0x04000617 RID: 1559
		internal double m_DeltaTime;

		// Token: 0x04000618 RID: 1560
		internal float m_Weight;

		// Token: 0x04000619 RID: 1561
		internal float m_EffectiveWeight;

		// Token: 0x0400061A RID: 1562
		internal double m_EffectiveParentDelay;

		// Token: 0x0400061B RID: 1563
		internal float m_EffectiveParentSpeed;

		// Token: 0x0400061C RID: 1564
		internal float m_EffectiveSpeed;

		// Token: 0x0400061D RID: 1565
		internal FrameData.Flags m_Flags;

		// Token: 0x0400061E RID: 1566
		internal PlayableOutput m_Output;

		// Token: 0x02000149 RID: 329
		[Flags]
		internal enum Flags
		{
			// Token: 0x04000620 RID: 1568
			Evaluate = 1,
			// Token: 0x04000621 RID: 1569
			SeekOccured = 2,
			// Token: 0x04000622 RID: 1570
			Loop = 4,
			// Token: 0x04000623 RID: 1571
			Hold = 8,
			// Token: 0x04000624 RID: 1572
			EffectivePlayStateDelayed = 16,
			// Token: 0x04000625 RID: 1573
			EffectivePlayStatePlaying = 32
		}
	}
}
