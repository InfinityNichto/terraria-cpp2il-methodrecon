using System;
using Cpp2IlInjected;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class FontData : ISerializationCallbackReceiver
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002207 File Offset: 0x00000407
		public static FontData defaultFontData
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003B24 File Offset: 0x00001D24
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00003B38 File Offset: 0x00001D38
		public Font font
		{
			get
			{
				return this.m_Font;
			}
			set
			{
				this.m_Font = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00003B4C File Offset: 0x00001D4C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00003B60 File Offset: 0x00001D60
		public int fontSize
		{
			get
			{
				return this.m_FontSize;
			}
			set
			{
				this.m_FontSize = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003B74 File Offset: 0x00001D74
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00003B88 File Offset: 0x00001D88
		public FontStyle fontStyle
		{
			get
			{
				return this.m_FontStyle;
			}
			set
			{
				this.m_FontStyle = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003B9C File Offset: 0x00001D9C
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public bool bestFit
		{
			get
			{
				return this.m_BestFit;
			}
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003BC0 File Offset: 0x00001DC0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00003BD4 File Offset: 0x00001DD4
		public int minSize
		{
			get
			{
				return this.m_MinSize;
			}
			set
			{
				this.m_MinSize = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00003BFC File Offset: 0x00001DFC
		public int maxSize
		{
			get
			{
				return this.m_MaxSize;
			}
			set
			{
				this.m_MaxSize = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003C10 File Offset: 0x00001E10
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00003C24 File Offset: 0x00001E24
		public TextAnchor alignment
		{
			get
			{
				return this.m_Alignment;
			}
			set
			{
				this.m_Alignment = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003C38 File Offset: 0x00001E38
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00003C4C File Offset: 0x00001E4C
		public bool alignByGeometry
		{
			get
			{
				return this.m_AlignByGeometry;
			}
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003C5C File Offset: 0x00001E5C
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00003C70 File Offset: 0x00001E70
		public bool richText
		{
			get
			{
				return this.m_RichText;
			}
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003C80 File Offset: 0x00001E80
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00003C94 File Offset: 0x00001E94
		public HorizontalWrapMode horizontalOverflow
		{
			get
			{
				return this.m_HorizontalOverflow;
			}
			set
			{
				this.m_HorizontalOverflow = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003CA8 File Offset: 0x00001EA8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00003CBC File Offset: 0x00001EBC
		public VerticalWrapMode verticalOverflow
		{
			get
			{
				return this.m_VerticalOverflow;
			}
			set
			{
				this.m_VerticalOverflow = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002207 File Offset: 0x00000407
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public float lineSpacing
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003CE0 File Offset: 0x00001EE0
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003CF0 File Offset: 0x00001EF0
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			int fontSize = this.m_FontSize;
			int minSize = this.m_MinSize;
			TextAnchor alignment = this.m_Alignment;
			this.m_FontSize = fontSize;
			this.m_MinSize = minSize;
			this.m_Alignment = (TextAnchor)fontSize;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003D28 File Offset: 0x00001F28
		public FontData()
		{
		}

		// Token: 0x0400005B RID: 91
		[SerializeField]
		[FormerlySerializedAs("font")]
		private Font m_Font;

		// Token: 0x0400005C RID: 92
		[SerializeField]
		[FormerlySerializedAs("fontSize")]
		private int m_FontSize;

		// Token: 0x0400005D RID: 93
		[FormerlySerializedAs("fontStyle")]
		[SerializeField]
		private FontStyle m_FontStyle;

		// Token: 0x0400005E RID: 94
		[SerializeField]
		private bool m_BestFit;

		// Token: 0x0400005F RID: 95
		[SerializeField]
		private int m_MinSize;

		// Token: 0x04000060 RID: 96
		[SerializeField]
		private int m_MaxSize;

		// Token: 0x04000061 RID: 97
		[FormerlySerializedAs("alignment")]
		[SerializeField]
		private TextAnchor m_Alignment;

		// Token: 0x04000062 RID: 98
		[SerializeField]
		private bool m_AlignByGeometry;

		// Token: 0x04000063 RID: 99
		[FormerlySerializedAs("richText")]
		[SerializeField]
		private bool m_RichText;

		// Token: 0x04000064 RID: 100
		[SerializeField]
		private HorizontalWrapMode m_HorizontalOverflow;

		// Token: 0x04000065 RID: 101
		[SerializeField]
		private VerticalWrapMode m_VerticalOverflow;

		// Token: 0x04000066 RID: 102
		[SerializeField]
		private float m_LineSpacing;
	}
}
