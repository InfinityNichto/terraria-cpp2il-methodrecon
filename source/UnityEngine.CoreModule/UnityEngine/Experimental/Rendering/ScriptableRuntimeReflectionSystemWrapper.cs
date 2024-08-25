using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000141 RID: 321
	[RequiredByNativeCode]
	internal class ScriptableRuntimeReflectionSystemWrapper
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0000B144 File Offset: 0x00009344
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x0000B158 File Offset: 0x00009358
		internal IScriptableRuntimeReflectionSystem implementation
		{
			[CompilerGenerated]
			get
			{
				return this.<implementation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<implementation>k__BackingField = value;
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000B16C File Offset: 0x0000936C
		[RequiredByNativeCode]
		private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes([Out] bool result)
		{
			if (this.<implementation>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000B18C File Offset: 0x0000938C
		public ScriptableRuntimeReflectionSystemWrapper()
		{
		}

		// Token: 0x0400060E RID: 1550
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IScriptableRuntimeReflectionSystem <implementation>k__BackingField;
	}
}
