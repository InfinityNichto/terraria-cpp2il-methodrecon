using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[NativeType(CodegenOptions.Custom, "MonoSkeletonBone")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	public struct SkeletonBone
	{
		// Token: 0x04000002 RID: 2
		[NativeName("m_Name")]
		public string name;

		// Token: 0x04000003 RID: 3
		[NativeName("m_ParentName")]
		internal string parentName;

		// Token: 0x04000004 RID: 4
		[NativeName("m_Position")]
		public Vector3 position;

		// Token: 0x04000005 RID: 5
		[NativeName("m_Rotation")]
		public Quaternion rotation;

		// Token: 0x04000006 RID: 6
		[NativeName("m_Scale")]
		public Vector3 scale;
	}
}
