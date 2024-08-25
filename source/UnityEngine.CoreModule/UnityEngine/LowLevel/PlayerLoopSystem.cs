using System;
using Cpp2IlInjected;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	// Token: 0x02000173 RID: 371
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	public struct PlayerLoopSystem
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x000021B3 File Offset: 0x000003B3
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000670 RID: 1648
		public Type type;

		// Token: 0x04000671 RID: 1649
		public PlayerLoopSystem[] subSystemList;

		// Token: 0x04000672 RID: 1650
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		// Token: 0x04000673 RID: 1651
		public IntPtr updateFunction;

		// Token: 0x04000674 RID: 1652
		public IntPtr loopConditionFunction;

		// Token: 0x02000174 RID: 372
		public sealed class UpdateFunction : MulticastDelegate
		{
			// Token: 0x060006E4 RID: 1764 RVA: 0x0000C504 File Offset: 0x0000A704
			public UpdateFunction(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x0000C558 File Offset: 0x0000A758
			public void Invoke()
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
