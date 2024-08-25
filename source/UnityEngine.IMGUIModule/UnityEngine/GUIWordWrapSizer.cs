using System;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	internal sealed class GUIWordWrapSizer : GUILayoutEntry
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002388 File Offset: 0x00000588
		public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options)
		{
			if (!true)
			{
			}
			float minHeight = this.minHeight;
			this.m_ForcedMinHeight = minHeight;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000023A8 File Offset: 0x000005A8
		public override void CalcWidth()
		{
			float minWidth = this.minWidth;
			float maxWidth = this.maxWidth;
			GUIStyle style = this.m_Style;
			GUIContent content = this.m_Content;
			Vector2 vector = style.Internal_CalcMinMaxWidth(content);
			float minWidth2 = this.minWidth;
			this.minWidth = maxWidth;
			float maxWidth2 = this.maxWidth;
			this.maxWidth = maxWidth2;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023FC File Offset: 0x000005FC
		public override void CalcHeight()
		{
			float forcedMinHeight = this.m_ForcedMinHeight;
			float forcedMaxHeight = this.m_ForcedMaxHeight;
			GUIStyle style = this.m_Style;
			GUIContent content = this.m_Content;
			throw new MissingMethodException();
		}

		// Token: 0x0400000C RID: 12
		private readonly GUIContent m_Content;

		// Token: 0x0400000D RID: 13
		private readonly float m_ForcedMinHeight;

		// Token: 0x0400000E RID: 14
		private readonly float m_ForcedMaxHeight;
	}
}
