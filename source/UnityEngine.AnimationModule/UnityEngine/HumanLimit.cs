using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeType(CodegenOptions.Custom, "MonoHumanLimit")]
	[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
	public struct HumanLimit
	{
		// Token: 0x04000007 RID: 7
		private Vector3 m_Min;

		// Token: 0x04000008 RID: 8
		private Vector3 m_Max;

		// Token: 0x04000009 RID: 9
		private Vector3 m_Center;

		// Token: 0x0400000A RID: 10
		private float m_AxisLength;

		// Token: 0x0400000B RID: 11
		private int m_UseDefaultValues;
	}
}
