using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007B RID: 123
	[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
	public sealed class ReflectionProbe : Behaviour
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00004CD8 File Offset: 0x00002ED8
		[RequiredByNativeCode]
		private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00004CE8 File Offset: 0x00002EE8
		[RequiredByNativeCode]
		private static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
		{
		}

		// Token: 0x040002EC RID: 748
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;

		// Token: 0x040002ED RID: 749
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Texture> defaultReflectionTexture;

		// Token: 0x0200007C RID: 124
		public enum ReflectionProbeEvent
		{
			// Token: 0x040002EF RID: 751
			ReflectionProbeAdded,
			// Token: 0x040002F0 RID: 752
			ReflectionProbeRemoved
		}
	}
}
