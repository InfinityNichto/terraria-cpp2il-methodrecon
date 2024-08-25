using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.DataStructures
{
	// Token: 0x02000625 RID: 1573
	public interface IEntryFilter<T>
	{
		// Token: 0x060035F1 RID: 13809
		bool FitsFilter(T entry);

		// Token: 0x060035F2 RID: 13810
		string GetDisplayNameKey();

		// Token: 0x060035F3 RID: 13811
		UIElement GetImage();

		// Token: 0x060035F4 RID: 13812
		void GetDisplay([Out] Texture2D texture, [Out] Rectangle frame);
	}
}
