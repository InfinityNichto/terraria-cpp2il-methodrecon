using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B9 RID: 185
	[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
	internal sealed class UnhandledExceptionHandler
	{
		// Token: 0x06000343 RID: 835 RVA: 0x00006BD8 File Offset: 0x00004DD8
		[RequiredByNativeCode]
		private static void RegisterUECatcher()
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
		}

		// Token: 0x020000BA RID: 186
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000344 RID: 836 RVA: 0x00006BF0 File Offset: 0x00004DF0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000345 RID: 837 RVA: 0x00006C00 File Offset: 0x00004E00
			public <>c()
			{
			}

			// Token: 0x06000346 RID: 838 RVA: 0x00006C14 File Offset: 0x00004E14
			internal void <RegisterUECatcher>b__0_0(object sender, UnhandledExceptionEventArgs e)
			{
				int num = 1;
				object exception = e._exception;
				if (num != 0 && exception == null)
				{
					return;
				}
			}

			// Token: 0x04000370 RID: 880
			public static readonly UnhandledExceptionHandler.<>c <>9;

			// Token: 0x04000371 RID: 881
			public static UnhandledExceptionEventHandler <>9__0_0;
		}
	}
}
