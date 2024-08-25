using System;

namespace ReLogic.Text
{
	// Token: 0x02000B15 RID: 2837
	public interface IFontMetrics
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x0600531D RID: 21277
		int LineSpacing { get; }

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x0600531E RID: 21278
		float CharacterSpacing { get; }

		// Token: 0x0600531F RID: 21279
		GlyphMetrics GetCharacterMetrics(char character);
	}
}
