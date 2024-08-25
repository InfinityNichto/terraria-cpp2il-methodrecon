using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000AE2 RID: 2786
	public class PlainTagHandler : ITagHandler
	{
		// Token: 0x060051E8 RID: 20968 RVA: 0x000021DB File Offset: 0x000003DB
		TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x00281D6C File Offset: 0x0027FF6C
		public PlainTagHandler()
		{
		}

		// Token: 0x02000AE3 RID: 2787
		public class PlainSnippet : TextSnippet
		{
			// Token: 0x060051EA RID: 20970 RVA: 0x00281D80 File Offset: 0x0027FF80
			public PlainSnippet(string text = "")
				: base(text)
			{
			}

			// Token: 0x060051EB RID: 20971 RVA: 0x00281D94 File Offset: 0x0027FF94
			public PlainSnippet(string text, Color color, float scale = 1f)
				: base(text, color, scale)
			{
			}

			// Token: 0x060051EC RID: 20972 RVA: 0x00281DAC File Offset: 0x0027FFAC
			public override Color GetVisibleColor()
			{
				Color color = this.Color;
				Color color2;
				return color2;
			}
		}
	}
}
