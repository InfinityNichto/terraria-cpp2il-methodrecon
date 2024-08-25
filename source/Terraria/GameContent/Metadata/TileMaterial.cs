using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Terraria.GameContent.Metadata
{
	// Token: 0x02000855 RID: 2133
	public class TileMaterial
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x0024DF00 File Offset: 0x0024C100
		// (set) Token: 0x06004355 RID: 17237 RVA: 0x0024DF14 File Offset: 0x0024C114
		[JsonProperty]
		public TileGolfPhysics GolfPhysics
		{
			[CompilerGenerated]
			get
			{
				return this.<GolfPhysics>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<GolfPhysics>k__BackingField = value;
			}
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x0024DF28 File Offset: 0x0024C128
		public TileMaterial()
		{
		}

		// Token: 0x04008165 RID: 33125
		[CompilerGenerated]
		private TileGolfPhysics <GolfPhysics>k__BackingField;
	}
}
