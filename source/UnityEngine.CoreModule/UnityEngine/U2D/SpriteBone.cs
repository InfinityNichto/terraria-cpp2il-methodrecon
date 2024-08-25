using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	// Token: 0x020000EC RID: 236
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
	[Serializable]
	public struct SpriteBone
	{
		// Token: 0x04000400 RID: 1024
		[NativeName("name")]
		[SerializeField]
		private string m_Name;

		// Token: 0x04000401 RID: 1025
		[SerializeField]
		[NativeName("guid")]
		private string m_Guid;

		// Token: 0x04000402 RID: 1026
		[NativeName("position")]
		[SerializeField]
		private Vector3 m_Position;

		// Token: 0x04000403 RID: 1027
		[SerializeField]
		[NativeName("rotation")]
		private Quaternion m_Rotation;

		// Token: 0x04000404 RID: 1028
		[NativeName("length")]
		[SerializeField]
		private float m_Length;

		// Token: 0x04000405 RID: 1029
		[NativeName("parentId")]
		[SerializeField]
		private int m_ParentId;

		// Token: 0x04000406 RID: 1030
		[SerializeField]
		[NativeName("color")]
		private Color32 m_Color;
	}
}
