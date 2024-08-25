using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000153 RID: 339
	[RequiredByNativeCode]
	public struct PlayableOutput : IEquatable<PlayableOutput>
	{
		// Token: 0x06000650 RID: 1616 RVA: 0x0000B500 File Offset: 0x00009700
		[VisibleToOtherModules]
		internal PlayableOutput(PlayableOutputHandle handle)
		{
			this.m_Handle = handle;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0000B514 File Offset: 0x00009714
		public PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000B528 File Offset: 0x00009728
		public bool Equals(PlayableOutput other)
		{
			PlayableOutputHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000B540 File Offset: 0x00009740
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutput()
		{
			if (!true)
			{
			}
			PlayableOutputHandle @null = PlayableOutputHandle.Null;
		}

		// Token: 0x04000631 RID: 1585
		private PlayableOutputHandle m_Handle;

		// Token: 0x04000632 RID: 1586
		private static readonly PlayableOutput m_NullPlayableOutput;
	}
}
