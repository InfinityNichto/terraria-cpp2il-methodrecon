using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB1 RID: 2737
	public class UIItemSlot : UIElement
	{
		// Token: 0x060050BE RID: 20670 RVA: 0x0027E21C File Offset: 0x0027C41C
		public UIItemSlot(Item[] itemArray, int itemIndex, int itemSlotContext)
		{
			if (!true)
			{
			}
			base..ctor();
			this._itemArray = itemArray;
			this._itemIndex = itemIndex;
			this._itemSlotContext = itemSlotContext;
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x0027E248 File Offset: 0x0027C448
		private void HandleItemSlotLogic()
		{
			if (this.<IsMouseHovering>k__BackingField)
			{
				Player localPlayer = Main.LocalPlayer;
				int num = 1;
				localPlayer.mouseInterface = num != 0;
				Vector2 position = this._itemArray.position;
				int itemSlotContext = this._itemSlotContext;
				if (position == null)
				{
				}
				int itemSlotContext2 = this._itemSlotContext;
				int itemSlotContext3 = this._itemSlotContext;
				int itemSlotContext4 = this._itemSlotContext;
				Item[] itemArray = this._itemArray;
				if (itemSlotContext != 0 && itemSlotContext == 0)
				{
					throw new ArrayTypeMismatchException();
				}
			}
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x0027E2B4 File Offset: 0x0027C4B4
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			Vector2 position = this._itemArray.position;
			float x = this._dimensions.X;
			int num = 16976;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			float inventoryScale = Main.inventoryScale;
			int itemSlotContext = this._itemSlotContext;
			if (num == 0)
			{
			}
		}

		// Token: 0x04008978 RID: 35192
		private Item[] _itemArray;

		// Token: 0x04008979 RID: 35193
		private int _itemIndex;

		// Token: 0x0400897A RID: 35194
		private int _itemSlotContext;
	}
}
