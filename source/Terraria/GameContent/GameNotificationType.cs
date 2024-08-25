using System;

namespace Terraria.GameContent
{
	// Token: 0x020007C6 RID: 1990
	[Flags]
	public enum GameNotificationType
	{
		// Token: 0x04007E46 RID: 32326
		None = 0,
		// Token: 0x04007E47 RID: 32327
		Damage = 1,
		// Token: 0x04007E48 RID: 32328
		SpawnOrDeath = 2,
		// Token: 0x04007E49 RID: 32329
		WorldGen = 4,
		// Token: 0x04007E4A RID: 32330
		All = 7
	}
}
