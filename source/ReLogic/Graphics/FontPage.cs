using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	// Token: 0x02000B37 RID: 2871
	internal sealed class FontPage
	{
		// Token: 0x060053BA RID: 21434 RVA: 0x00284E78 File Offset: 0x00283078
		public FontPage(Texture2D texture, List<Rectangle> glyphs, List<Rectangle> padding, List<char> characters, List<Vector3> kerning)
		{
			this.Texture = texture;
			this.Glyphs = glyphs;
			this.Padding = padding;
			this.Characters = characters;
			this.Kerning = kerning;
		}

		// Token: 0x04008CEB RID: 36075
		public readonly Texture2D Texture;

		// Token: 0x04008CEC RID: 36076
		public readonly List<Rectangle> Glyphs;

		// Token: 0x04008CED RID: 36077
		public readonly List<Rectangle> Padding;

		// Token: 0x04008CEE RID: 36078
		public readonly List<char> Characters;

		// Token: 0x04008CEF RID: 36079
		public readonly List<Vector3> Kerning;
	}
}
