using System;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000142 RID: 322
	[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
	internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public bool TickRealtimeProbes()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000B1B4 File Offset: 0x000093B4
		public void Dispose()
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000B1C4 File Offset: 0x000093C4
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000B1D4 File Offset: 0x000093D4
		[StaticAccessor("GetReflectionProbes()", Type = 0)]
		private static bool BuiltinUpdate()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000021B3 File Offset: 0x000003B3
		[RequiredByNativeCode]
		private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000B1E8 File Offset: 0x000093E8
		public BuiltinRuntimeReflectionSystem()
		{
		}
	}
}
