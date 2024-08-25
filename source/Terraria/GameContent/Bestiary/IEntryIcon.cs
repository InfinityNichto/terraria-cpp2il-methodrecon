using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000941 RID: 2369
	public interface IEntryIcon
	{
		// Token: 0x06004796 RID: 18326
		void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings);

		// Token: 0x06004797 RID: 18327
		void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings);

		// Token: 0x06004798 RID: 18328
		bool GetUnlockState(BestiaryUICollectionInfo providedInfo);

		// Token: 0x06004799 RID: 18329
		string GetHoverText(BestiaryUICollectionInfo providedInfo);

		// Token: 0x0600479A RID: 18330
		IEntryIcon CreateClone();
	}
}
