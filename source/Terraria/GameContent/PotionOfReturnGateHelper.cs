using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x0200080C RID: 2060
	public struct PotionOfReturnGateHelper
	{
		// Token: 0x060041E1 RID: 16865 RVA: 0x00248E58 File Offset: 0x00247058
		public PotionOfReturnGateHelper(PotionOfReturnGateHelper.GateType gateType, Vector2 worldPosition, float opacity)
		{
			int num = 1;
			this._gateType = gateType;
			if (num == 0)
			{
				Vector2 position = this._position;
			}
			int num2 = 16928;
			this._frameNumber = num2;
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00248E88 File Offset: 0x00247088
		public void Update()
		{
			Vector2 position = this._position;
			if (!true)
			{
			}
			this.SpawnReturnPortalDust();
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x00248EA8 File Offset: 0x002470A8
		public void SpawnReturnPortalDust()
		{
			PotionOfReturnGateHelper.GateType gateType = this._gateType;
			if (!true)
			{
			}
			Vector2 vector;
			if (gateType != PotionOfReturnGateHelper.GateType.EntryPoint)
			{
				int num;
				if (num == 0)
				{
					if (!true)
					{
					}
					if (!true)
					{
					}
					Vector2 position = this._position;
					Dust dust;
					dust.noGravity = true;
					dust.noLightEmittence = true;
					dust.fadeIn = (float)16128;
					PotionOfReturnGateHelper.GateType gateType2 = this._gateType;
					float x = dust.position.X;
					float y = dust.position.Y;
					return;
				}
			}
			else if (vector == null)
			{
				PotionOfReturnGateHelper.GateType gateType2;
				if (gateType2 == PotionOfReturnGateHelper.GateType.EntryPoint)
				{
				}
				if (!true)
				{
				}
				int num2;
				if (num2 != 0)
				{
					Vector2 position2 = this._position;
					Dust dust2;
					dust2.noGravity = true;
					dust2.noLight = true;
					Vector2 position3 = this._position;
					return;
				}
				Vector2 position4 = this._position;
				Dust dust3;
				dust3.noGravity = true;
				dust3.noLightEmittence = true;
				Vector2 position5 = this._position;
				dust3.fadeIn = (float)16128;
				PotionOfReturnGateHelper.GateType gateType3 = this._gateType;
				float x2 = dust3.position.X;
				float y2 = dust3.position.Y;
				float x3 = dust3.velocity.X;
				float y3 = dust3.velocity.Y;
			}
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x000021DB File Offset: 0x000003DB
		public void DrawToDrawData(List<DrawData> drawDataList, int selectionMode)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040080A7 RID: 32935
		private readonly Vector2 _position;

		// Token: 0x040080A8 RID: 32936
		private readonly float _opacity;

		// Token: 0x040080A9 RID: 32937
		private readonly int _frameNumber;

		// Token: 0x040080AA RID: 32938
		private readonly PotionOfReturnGateHelper.GateType _gateType;

		// Token: 0x0200080D RID: 2061
		public enum GateType
		{
			// Token: 0x040080AC RID: 32940
			EntryPoint,
			// Token: 0x040080AD RID: 32941
			ExitPoint
		}
	}
}
