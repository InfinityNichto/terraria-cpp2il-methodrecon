using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000009 RID: 9
	[NativeHeader("Runtime/Jobs/JobSystem.h")]
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	public static class JobsUtility
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000020F4 File Offset: 0x000002F4
		[RequiredByNativeCode]
		private static void InvokePanicFunction()
		{
		}

		// Token: 0x0400000C RID: 12
		internal static JobsUtility.PanicFunction_ PanicFunction;

		// Token: 0x0200000A RID: 10
		internal sealed class PanicFunction_ : MulticastDelegate
		{
			// Token: 0x0600000A RID: 10 RVA: 0x00002104 File Offset: 0x00000304
			public PanicFunction_(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600000B RID: 11 RVA: 0x00002158 File Offset: 0x00000358
			public void Invoke()
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
