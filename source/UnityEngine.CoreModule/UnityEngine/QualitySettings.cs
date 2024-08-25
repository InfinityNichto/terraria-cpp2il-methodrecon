using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000056 RID: 86
	[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Graphics/QualitySettings.h")]
	public sealed class QualitySettings : Object
	{
		// Token: 0x17000044 RID: 68
		// (set) Token: 0x0600017E RID: 382 RVA: 0x000042CC File Offset: 0x000024CC
		public static int vSyncCount
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000042E0 File Offset: 0x000024E0
		public static ColorSpace activeColorSpace
		{
			[NativeName("GetColorSpace")]
			[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
			get
			{
				throw new MissingMethodException();
			}
		}
	}
}
