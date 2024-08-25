using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.ObjectInteractions;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000760 RID: 1888
	internal class ReturnGatePlayerRenderer : IPlayerRenderer
	{
		// Token: 0x06003E12 RID: 15890 RVA: 0x0023BBB4 File Offset: 0x00239DB4
		public void DrawPlayers(Camera camera, IEnumerable<Player> players)
		{
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0023BBF0 File Offset: 0x00239DF0
		public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor)
		{
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x0023BC00 File Offset: 0x00239E00
		public void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets)
		{
			this.DrawReturnGateInWorld(camera, drawPlayer);
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x0023BC18 File Offset: 0x00239E18
		private void DrawReturnGateInMap(Camera camera, Player player)
		{
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x000021DB File Offset: 0x000003DB
		public void OverReturnGateInWorld(Player player)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0023BC28 File Offset: 0x00239E28
		private void DrawReturnGateInWorld(Camera camera, Player player)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			PotionOfReturnGateInteractionChecker interactionChecker = this._interactionChecker;
			if (num == 0)
			{
			}
			bool smartInteractPotionOfReturn = Main.SmartInteractPotionOfReturn;
			Vector2? potionOfReturnOriginalUsePosition = player.PotionOfReturnOriginalUsePosition;
			int num2 = 2;
			if (potionOfReturnOriginalUsePosition != null)
			{
				if (!true)
				{
				}
				SamplerState sampler = camera.Sampler;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				int num3 = 1;
				int whoAmI = player.whoAmI;
				if (num3 == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				Point point;
				Vector2 vector = point.ToVector2();
				List<DrawData> voidLensData = this._voidLensData;
				int size = voidLensData._size;
				object syncRoot = voidLensData._syncRoot;
				voidLensData._syncRoot = syncRoot;
				List<DrawData> voidLensData2 = this._voidLensData;
				List<DrawData> voidLensData3 = this._voidLensData;
				List<DrawData> voidLensData4 = this._voidLensData;
				return;
			}
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x0023BD04 File Offset: 0x00239F04
		public ReturnGatePlayerRenderer()
		{
		}

		// Token: 0x04007CCD RID: 31949
		private List<DrawData> _voidLensData;

		// Token: 0x04007CCE RID: 31950
		private PotionOfReturnGateInteractionChecker _interactionChecker;
	}
}
