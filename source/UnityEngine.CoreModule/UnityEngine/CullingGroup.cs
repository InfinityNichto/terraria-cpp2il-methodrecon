using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000079 RID: 121
	[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
	[StructLayout(0)]
	public class CullingGroup
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00004C10 File Offset: 0x00002E10
		[RequiredByNativeCode]
		private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			CullingGroup.StateChanged onStateChanged = cullingGroup.m_OnStateChanged;
			if (onStateChanged != null)
			{
				IntPtr invoke_impl = onStateChanged.invoke_impl;
				IntPtr method_code = onStateChanged.method_code;
				IntPtr method = onStateChanged.method;
				CullingGroup.StateChanged onStateChanged2 = cullingGroup.m_OnStateChanged;
				IntPtr invoke_impl2 = onStateChanged2.invoke_impl;
				IntPtr method_code2 = onStateChanged2.method_code;
				IntPtr method2 = onStateChanged2.method;
			}
		}

		// Token: 0x040002EA RID: 746
		internal IntPtr m_Ptr;

		// Token: 0x040002EB RID: 747
		private CullingGroup.StateChanged m_OnStateChanged;

		// Token: 0x0200007A RID: 122
		public sealed class StateChanged : MulticastDelegate
		{
			// Token: 0x060001F3 RID: 499 RVA: 0x00004C60 File Offset: 0x00002E60
			public StateChanged(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00004CB4 File Offset: 0x00002EB4
			public void Invoke(CullingGroupEvent sphere)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
