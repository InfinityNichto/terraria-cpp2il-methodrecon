using System;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000A6 RID: 166
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	[NativeClass("BitField", "struct BitField;")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/BaseClasses/BitField.h")]
	public struct LayerMask
	{
		// Token: 0x06000309 RID: 777 RVA: 0x000021B3 File Offset: 0x000003B3
		public static implicit operator int(LayerMask mask)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000021B3 File Offset: 0x000003B3
		public static implicit operator LayerMask(int intVal)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000363 RID: 867
		[NativeName("m_Bits")]
		private int m_Mask;
	}
}
