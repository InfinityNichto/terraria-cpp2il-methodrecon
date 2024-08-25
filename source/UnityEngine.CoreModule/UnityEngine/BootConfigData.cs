using System;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000096 RID: 150
	[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
	internal class BootConfigData
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x000021B3 File Offset: 0x000003B3
		[RequiredByNativeCode]
		private static BootConfigData WrapBootConfigData(IntPtr nativeHandle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00005DD8 File Offset: 0x00003FD8
		private BootConfigData(IntPtr nativeHandle)
		{
			this.m_Ptr = nativeHandle;
		}

		// Token: 0x04000345 RID: 837
		private IntPtr m_Ptr;
	}
}
