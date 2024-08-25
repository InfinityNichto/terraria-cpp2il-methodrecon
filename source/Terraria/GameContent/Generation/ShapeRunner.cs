using System;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008DB RID: 2267
	public class ShapeRunner : GenShape
	{
		// Token: 0x060045B2 RID: 17842 RVA: 0x00255400 File Offset: 0x00253600
		public ShapeRunner(double strength, int steps, Vector2D velocity)
		{
			this._startStrength = strength;
			this._steps = steps;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00255424 File Offset: 0x00253624
		public override bool Perform(Point origin, GenAction action)
		{
			int num = 1;
			int steps = this._steps;
			double startStrength = this._startStrength;
			double x = this._startVelocity.X;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			UnifiedRandom random = GenBase._random;
			long num3 = 0L;
			double x2 = this._startVelocity.X;
			double startStrength2 = this._startStrength;
			int num4 = Math.Max(1, (int)num3);
			int num5 = Math.Max(1, (int)num3);
			if (!true)
			{
			}
			int num6 = Math.Min(int.MinValue, (int)num3);
			int num7 = 1;
			if (num7 == 0)
			{
			}
			int num8 = Math.Min(int.MinValue, (int)num3);
			if (num7 == 0)
			{
			}
			UnifiedRandom random2 = GenBase._random;
			int num9 = 11;
			int num10 = random2.Next((int)num3, num9);
			if (num7 == 0)
			{
			}
			long num11 = 16457L;
			if (num11 == 0L)
			{
			}
			if (num11 == 0L)
			{
			}
			Vector2D vector2D = Utils.RandomVector2D(GenBase._random, startStrength2, startStrength);
			if (num6 != 0)
			{
			}
			Vector2D vector2D2 = Utils.RandomVector2D(GenBase._random, x2, startStrength);
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x04008217 RID: 33303
		private double _startStrength;

		// Token: 0x04008218 RID: 33304
		private int _steps;

		// Token: 0x04008219 RID: 33305
		private Vector2D _startVelocity;
	}
}
