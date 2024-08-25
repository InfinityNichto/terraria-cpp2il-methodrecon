using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000151 RID: 337
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
	public struct PlayableGraph
	{
		// Token: 0x0400062F RID: 1583
		internal IntPtr m_Handle;

		// Token: 0x04000630 RID: 1584
		internal uint m_Version;
	}
}
