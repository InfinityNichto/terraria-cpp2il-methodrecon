using System;
using Terraria.GameContent.UI.Elements;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000A34 RID: 2612
	public interface IPowerSubcategoryElement
	{
		// Token: 0x06004CA7 RID: 19623
		GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex);
	}
}
