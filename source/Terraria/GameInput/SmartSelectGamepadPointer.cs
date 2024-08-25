using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.GameInput
{
	// Token: 0x020006CE RID: 1742
	public class SmartSelectGamepadPointer
	{
		// Token: 0x060039F9 RID: 14841 RVA: 0x0022F7E0 File Offset: 0x0022D9E0
		public bool ShouldBeUsed()
		{
			if (!true)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
			if (!true)
			{
			}
			bool controlTorch = Main.LocalPlayer.controlTorch;
			if (controlTorch)
			{
				if (!controlTorch)
				{
				}
				return Main.SmartCursorIsUsed;
			}
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x0022F81C File Offset: 0x0022DA1C
		public void SmartSelectLookup_GetTargetTile(Player player, [Out] int tX, [Out] int tY)
		{
			if (!true)
			{
			}
			int worldMouseX = Main.worldMouseX;
			Vector2 screenPosition = Main.screenPosition;
			tX.m_value = 15744;
			int worldMouseY = Main.worldMouseY;
			Vector2 screenPosition2 = Main.screenPosition;
			tY.m_value = 15744;
			float gravDir = player.gravDir;
			if (15744 == 0)
			{
			}
			Vector2 screenPosition3 = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			int mouseY = Main.mouseY;
			tY.m_value = 15744;
			Vector2 pointerPosition = this.GetPointerPosition();
			if (15744 == 0)
			{
			}
			if (32768 == 0)
			{
			}
			Vector2 screenPosition4 = Main.screenPosition;
			tX.m_value = 15744;
			Vector2 screenPosition5 = Main.screenPosition;
			tY.m_value = 15744;
			float gravDir2 = player.gravDir;
			if (15744 == 0)
			{
			}
			Vector2 screenPosition6 = Main.screenPosition;
			int screenHeight2 = Main.screenHeight;
			tY.m_value = 15744;
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x0022F910 File Offset: 0x0022DB10
		public void UpdateSize(Vector2 size)
		{
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x0022F920 File Offset: 0x0022DB20
		public void UpdateCenter(Vector2 center)
		{
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x0022F930 File Offset: 0x0022DB30
		public Vector2 GetPointerPosition()
		{
			if (!true)
			{
			}
			int worldMouseX = Main.worldMouseX;
			int worldMouseY = Main.worldMouseY;
			float x = this._center.X;
			float y = this._center.Y;
			if (!true)
			{
			}
			float x2 = this._size.X;
			float y2 = this._size.Y;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			float x3 = this._distUniform.X;
			float y3 = this._distUniform.Y;
			float x4 = this._center.X;
			float y4 = this._center.Y;
			return 1;
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x0022F9DC File Offset: 0x0022DBDC
		public SmartSelectGamepadPointer()
		{
		}

		// Token: 0x04007A2F RID: 31279
		private Vector2 _size;

		// Token: 0x04007A30 RID: 31280
		private Vector2 _center;

		// Token: 0x04007A31 RID: 31281
		private Vector2 _distUniform = 17056;
	}
}
