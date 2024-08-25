using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	public class TextEditor
	{
		// Token: 0x06000096 RID: 150 RVA: 0x000033D4 File Offset: 0x000015D4
		[RequiredByNativeCode]
		public TextEditor()
		{
			if (!true)
			{
			}
			GUIStyle none = GUIStyle.none;
			this.style = none;
			base..ctor();
		}

		// Token: 0x04000070 RID: 112
		public TouchScreenKeyboard keyboardOnScreen;

		// Token: 0x04000071 RID: 113
		public int controlID;

		// Token: 0x04000072 RID: 114
		public GUIStyle style;

		// Token: 0x04000073 RID: 115
		public bool multiline;

		// Token: 0x04000074 RID: 116
		public bool hasHorizontalCursorPos;

		// Token: 0x04000075 RID: 117
		public bool isPasswordField;

		// Token: 0x04000076 RID: 118
		public Vector2 scrollOffset;

		// Token: 0x04000077 RID: 119
		private GUIContent m_Content;

		// Token: 0x04000078 RID: 120
		private int m_CursorIndex;

		// Token: 0x04000079 RID: 121
		private int m_SelectIndex;

		// Token: 0x0400007A RID: 122
		private bool m_RevealCursor;

		// Token: 0x0400007B RID: 123
		private bool m_MouseDragSelectsWholeWords;

		// Token: 0x0400007C RID: 124
		private int m_DblClickInitPos;

		// Token: 0x0400007D RID: 125
		private TextEditor.DblClickSnapping m_DblClickSnap;

		// Token: 0x0400007E RID: 126
		private bool m_bJustSelected;

		// Token: 0x0400007F RID: 127
		private int m_iAltCursorPos;

		// Token: 0x02000013 RID: 19
		public enum DblClickSnapping : byte
		{
			// Token: 0x04000081 RID: 129
			WORDS,
			// Token: 0x04000082 RID: 130
			PARAGRAPHS
		}
	}
}
