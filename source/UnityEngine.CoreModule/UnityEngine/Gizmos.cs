using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000D9 RID: 217
	[StaticAccessor("GizmoBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
	public sealed class Gizmos
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x000083B4 File Offset: 0x000065B4
		[NativeThrows]
		public static void DrawLine(Vector3 from, Vector3 to)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000083C8 File Offset: 0x000065C8
		[NativeThrows]
		public static void DrawSphere(Vector3 center, float radius)
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000E2 RID: 226
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000083DC File Offset: 0x000065DC
		public static Color color
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000083F0 File Offset: 0x000065F0
		private static void DrawLine_Injected(Vector3 from, Vector3 to)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00008404 File Offset: 0x00006604
		private static void DrawSphere_Injected(Vector3 center, float radius)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00008418 File Offset: 0x00006618
		private static void set_color_Injected(Color value)
		{
			throw new MissingMethodException();
		}
	}
}
