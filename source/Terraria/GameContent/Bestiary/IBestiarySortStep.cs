using System;
using System.Collections.Generic;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200092C RID: 2348
	public interface IBestiarySortStep : IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600472E RID: 18222
		bool HiddenFromSortOptions { get; }
	}
}
