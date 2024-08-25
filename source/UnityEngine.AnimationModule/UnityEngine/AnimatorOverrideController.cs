using System;
using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[DefaultMember("Item")]
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[RequiredByNativeCode]
		[NativeConditional("UNITY_EDITOR")]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
			AnimatorOverrideController.OnOverrideControllerDirtyCallback onOverrideControllerDirty = controller.OnOverrideControllerDirty;
			if (onOverrideControllerDirty != null)
			{
				IntPtr invoke_impl = onOverrideControllerDirty.invoke_impl;
				IntPtr method_code = onOverrideControllerDirty.method_code;
				IntPtr method = onOverrideControllerDirty.method;
				return;
			}
		}

		// Token: 0x04000001 RID: 1
		internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

		// Token: 0x02000003 RID: 3
		internal sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
		{
			// Token: 0x06000002 RID: 2 RVA: 0x00002080 File Offset: 0x00000280
			public OnOverrideControllerDirtyCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000003 RID: 3 RVA: 0x000020D4 File Offset: 0x000002D4
			public void Invoke()
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
