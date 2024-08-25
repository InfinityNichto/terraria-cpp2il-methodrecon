using System;
using System.Collections.Generic;
using System.IO;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000A33 RID: 2611
	public interface ICreativePower
	{
		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06004C9C RID: 19612
		// (set) Token: 0x06004C9D RID: 19613
		ushort PowerId { get; set; }

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06004C9E RID: 19614
		// (set) Token: 0x06004C9F RID: 19615
		string ServerConfigName { get; set; }

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06004CA0 RID: 19616
		// (set) Token: 0x06004CA1 RID: 19617
		PowerPermissionLevel CurrentPermissionLevel { get; set; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06004CA2 RID: 19618
		// (set) Token: 0x06004CA3 RID: 19619
		PowerPermissionLevel DefaultPermissionLevel { get; set; }

		// Token: 0x06004CA4 RID: 19620
		void DeserializeNetMessage(BinaryReader reader, int userId);

		// Token: 0x06004CA5 RID: 19621
		void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements);

		// Token: 0x06004CA6 RID: 19622
		bool GetIsUnlocked();
	}
}
