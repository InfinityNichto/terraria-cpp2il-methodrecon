using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000146 RID: 326
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
	public struct TextureMixerPlayable : IEquatable<TextureMixerPlayable>
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x0000B254 File Offset: 0x00009454
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000B268 File Offset: 0x00009468
		public bool Equals(TextureMixerPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x04000612 RID: 1554
		private PlayableHandle m_Handle;
	}
}
