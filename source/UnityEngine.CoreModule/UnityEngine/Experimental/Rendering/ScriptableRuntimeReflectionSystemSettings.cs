using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200013F RID: 319
	[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
	[RequiredByNativeCode]
	public static class ScriptableRuntimeReflectionSystemSettings
	{
		// Token: 0x1700014B RID: 331
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x0000B0F8 File Offset: 0x000092F8
		private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
		{
			[RequiredByNativeCode]
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0000B10C File Offset: 0x0000930C
		private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
		{
			[RequiredByNativeCode]
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000B120 File Offset: 0x00009320
		[StaticAccessor("ScriptableRuntimeReflectionSystem", StaticAccessorType.DoubleColon)]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void ScriptingDirtyReflectionSystemInstance()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000B134 File Offset: 0x00009334
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRuntimeReflectionSystemSettings()
		{
		}

		// Token: 0x0400060D RID: 1549
		private static ScriptableRuntimeReflectionSystemWrapper s_Instance;
	}
}
