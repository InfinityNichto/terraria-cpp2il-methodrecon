using System;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000925 RID: 2341
	public interface IBestiaryEntryFilter : IEntryFilter<BestiaryEntry>
	{
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600470E RID: 18190
		bool? ForcedDisplay { get; }
	}
}
