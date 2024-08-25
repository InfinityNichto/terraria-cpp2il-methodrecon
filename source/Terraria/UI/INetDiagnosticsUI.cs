using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000715 RID: 1813
	public interface INetDiagnosticsUI
	{
		// Token: 0x06003C02 RID: 15362
		void Reset();

		// Token: 0x06003C03 RID: 15363
		void Draw(SpriteBatch spriteBatch);

		// Token: 0x06003C04 RID: 15364
		void CountReadMessage(int messageId, int messageLength);

		// Token: 0x06003C05 RID: 15365
		void CountSentMessage(int messageId, int messageLength);

		// Token: 0x06003C06 RID: 15366
		void CountReadModuleMessage(int moduleMessageId, int messageLength);

		// Token: 0x06003C07 RID: 15367
		void CountSentModuleMessage(int moduleMessageId, int messageLength);
	}
}
