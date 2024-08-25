using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
	[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
	[NativeHeader("Physics2DScriptingClasses.h")]
	[NativeHeader("Physics2DScriptingClasses.h")]
	public class Physics2D
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// Note: this type is marked as 'beforefieldinit'.
		static Physics2D()
		{
		}

		// Token: 0x04000001 RID: 1
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D;
	}
}
