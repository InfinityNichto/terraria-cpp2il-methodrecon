using System;
using Cpp2IlInjected;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200006F RID: 111
	[Serializable]
	public struct SpriteState : IEquatable<SpriteState>
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00002207 File Offset: 0x00000407
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x0000E8AC File Offset: 0x0000CAAC
		public Sprite highlightedSprite
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.m_HighlightedSprite = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x0000E8D4 File Offset: 0x0000CAD4
		public Sprite pressedSprite
		{
			get
			{
				return this.m_PressedSprite;
			}
			set
			{
				this.m_PressedSprite = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0000E8E8 File Offset: 0x0000CAE8
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x0000E8FC File Offset: 0x0000CAFC
		public Sprite selectedSprite
		{
			get
			{
				return this.m_SelectedSprite;
			}
			set
			{
				this.m_SelectedSprite = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0000E910 File Offset: 0x0000CB10
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x0000E924 File Offset: 0x0000CB24
		public Sprite disabledSprite
		{
			get
			{
				return this.m_DisabledSprite;
			}
			set
			{
				this.m_DisabledSprite = value;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000E938 File Offset: 0x0000CB38
		public bool Equals(SpriteState other)
		{
			if (!true)
			{
			}
			Sprite pressedSprite = this.m_PressedSprite;
			Sprite pressedSprite2 = other.m_PressedSprite;
			if (!true)
			{
			}
			bool flag = pressedSprite == pressedSprite2;
			Sprite selectedSprite = this.m_SelectedSprite;
			Sprite selectedSprite2 = other.m_SelectedSprite;
			if (!true)
			{
			}
			bool flag2 = selectedSprite == selectedSprite2;
			Sprite disabledSprite = this.m_DisabledSprite;
			Sprite disabledSprite2 = other.m_DisabledSprite;
			if (!true)
			{
			}
			return disabledSprite == disabledSprite2;
		}

		// Token: 0x04000234 RID: 564
		[SerializeField]
		private Sprite m_HighlightedSprite;

		// Token: 0x04000235 RID: 565
		[SerializeField]
		private Sprite m_PressedSprite;

		// Token: 0x04000236 RID: 566
		[SerializeField]
		[FormerlySerializedAs("m_HighlightedSprite")]
		private Sprite m_SelectedSprite;

		// Token: 0x04000237 RID: 567
		[SerializeField]
		private Sprite m_DisabledSprite;
	}
}
