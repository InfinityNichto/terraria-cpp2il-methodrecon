using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000632 RID: 1586
	public class RecipeItemCreationContext : ItemCreationContext
	{
		// Token: 0x06003628 RID: 13864 RVA: 0x002123DC File Offset: 0x002105DC
		public RecipeItemCreationContext(Recipe recipe)
		{
			this.Recipe = recipe;
		}

		// Token: 0x040076E9 RID: 30441
		public readonly Recipe Recipe;
	}
}
