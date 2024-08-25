using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[NativeHeader("Runtime/Camera/Camera.h")]
	internal class CameraRaycastHelper
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002138 File Offset: 0x00000338
		[FreeFunction("CameraScripting::RaycastTry")]
		internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000214C File Offset: 0x0000034C
		[FreeFunction("CameraScripting::RaycastTry2D")]
		internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002160 File Offset: 0x00000360
		private static GameObject RaycastTry_Injected(Camera cam, Ray ray, float distance, int layerMask)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002174 File Offset: 0x00000374
		private static GameObject RaycastTry2D_Injected(Camera cam, Ray ray, float distance, int layerMask)
		{
			throw new MissingMethodException();
		}
	}
}
