using System;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000958 RID: 2392
	public interface IPreferenceProviderElement : IBestiaryInfoElement
	{
		// Token: 0x060047E2 RID: 18402
		IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider();

		// Token: 0x060047E3 RID: 18403
		bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider);
	}
}
