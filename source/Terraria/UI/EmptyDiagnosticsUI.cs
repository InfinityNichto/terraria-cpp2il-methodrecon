using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000717 RID: 1815
	public class EmptyDiagnosticsUI : INetDiagnosticsUI
	{
		// Token: 0x06003C13 RID: 15379 RVA: 0x002357BC File Offset: 0x002339BC
		public void Reset()
		{
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x002357CC File Offset: 0x002339CC
		public void CountReadMessage(int messageId, int messageLength)
		{
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x002357DC File Offset: 0x002339DC
		public void CountSentMessage(int messageId, int messageLength)
		{
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x002357EC File Offset: 0x002339EC
		public void CountReadModuleMessage(int moduleMessageId, int messageLength)
		{
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x002357FC File Offset: 0x002339FC
		public void CountSentModuleMessage(int moduleMessageId, int messageLength)
		{
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x0023580C File Offset: 0x00233A0C
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0023581C File Offset: 0x00233A1C
		public EmptyDiagnosticsUI()
		{
		}
	}
}
