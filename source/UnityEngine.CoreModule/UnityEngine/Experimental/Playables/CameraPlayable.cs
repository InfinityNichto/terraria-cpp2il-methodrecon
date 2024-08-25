using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000144 RID: 324
	[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("CameraPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
	[RequiredByNativeCode]
	public struct CameraPlayable : IEquatable<CameraPlayable>
	{
		// Token: 0x0600062C RID: 1580 RVA: 0x0000B228 File Offset: 0x00009428
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0000B23C File Offset: 0x0000943C
		public bool Equals(CameraPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x04000610 RID: 1552
		private PlayableHandle m_Handle;
	}
}
