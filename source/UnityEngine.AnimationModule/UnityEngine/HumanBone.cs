using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[NativeType(CodegenOptions.Custom, "MonoHumanBone")]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[RequiredByNativeCode]
	public struct HumanBone
	{
		// Token: 0x0400000C RID: 12
		private string m_BoneName;

		// Token: 0x0400000D RID: 13
		private string m_HumanName;

		// Token: 0x0400000E RID: 14
		[NativeName("m_Limit")]
		public HumanLimit limit;
	}
}
