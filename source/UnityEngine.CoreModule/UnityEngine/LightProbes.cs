using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200005B RID: 91
	[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
	[StructLayout(0)]
	public sealed class LightProbes : Object
	{
		// Token: 0x06000189 RID: 393 RVA: 0x0000438C File Offset: 0x0000258C
		[RequiredByNativeCode]
		private static void Internal_CallTetrahedralizationCompletedFunction()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000439C File Offset: 0x0000259C
		[RequiredByNativeCode]
		private static void Internal_CallNeedsRetetrahedralizationFunction()
		{
		}

		// Token: 0x0400022C RID: 556
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action tetrahedralizationCompleted;

		// Token: 0x0400022D RID: 557
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action needsRetetrahedralization;
	}
}
