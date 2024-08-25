using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x0200072F RID: 1839
	public interface ITagHandler
	{
		// Token: 0x06003CDF RID: 15583
		TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options);
	}
}
