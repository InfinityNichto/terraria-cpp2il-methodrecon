using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	[Serializable]
	public sealed class GUISettings
	{
		// Token: 0x06000097 RID: 151 RVA: 0x000033F8 File Offset: 0x000015F8
		public GUISettings()
		{
			this.m_SelectionColor.a = (float)16256;
			base..ctor();
		}

		// Token: 0x04000083 RID: 131
		[SerializeField]
		private bool m_DoubleClickSelectsWord = 257 != 0;

		// Token: 0x04000084 RID: 132
		[SerializeField]
		private bool m_TripleClickSelectsLine;

		// Token: 0x04000085 RID: 133
		[SerializeField]
		private Color m_CursorColor;

		// Token: 0x04000086 RID: 134
		[SerializeField]
		private float m_CursorFlashSpeed;

		// Token: 0x04000087 RID: 135
		[SerializeField]
		private Color m_SelectionColor;
	}
}
