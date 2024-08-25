using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000143 RID: 323
	[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
	public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable>
	{
		// Token: 0x0600062A RID: 1578 RVA: 0x0000B1FC File Offset: 0x000093FC
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000B210 File Offset: 0x00009410
		public bool Equals(MaterialEffectPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0400060F RID: 1551
		private PlayableHandle m_Handle;
	}
}
