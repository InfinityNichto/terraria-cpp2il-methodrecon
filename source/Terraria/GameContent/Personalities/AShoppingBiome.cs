using System;
using System.Runtime.CompilerServices;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000831 RID: 2097
	public abstract class AShoppingBiome
	{
		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x0024CE34 File Offset: 0x0024B034
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x0024CE48 File Offset: 0x0024B048
		public string NameKey
		{
			[CompilerGenerated]
			get
			{
				return this.<NameKey>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<NameKey>k__BackingField = value;
			}
		}

		// Token: 0x060042F2 RID: 17138
		public abstract bool IsInBiome(Player player);

		// Token: 0x060042F3 RID: 17139 RVA: 0x0024CE5C File Offset: 0x0024B05C
		protected AShoppingBiome()
		{
		}

		// Token: 0x04008134 RID: 33076
		[CompilerGenerated]
		private string <NameKey>k__BackingField;
	}
}
