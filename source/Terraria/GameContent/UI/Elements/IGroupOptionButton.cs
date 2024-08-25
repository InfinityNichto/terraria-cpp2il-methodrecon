using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A90 RID: 2704
	public interface IGroupOptionButton
	{
		// Token: 0x06004FDC RID: 20444
		void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked);

		// Token: 0x06004FDD RID: 20445
		void SetBorderColor(Color color);
	}
}
