using System;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008DA RID: 2266
	public class ShapeRoot : GenShape
	{
		// Token: 0x060045AF RID: 17839 RVA: 0x0025534C File Offset: 0x0025354C
		public ShapeRoot(double angle, double distance = 10.0, double startingSize = 4.0, double endingSize = 1.0)
		{
			this._endingSize = endingSize;
			this._angle = angle;
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00255370 File Offset: 0x00253570
		private bool DoRoot(Point origin, GenAction action, double angle, double distance, double startingSize)
		{
			double endingSize = this._endingSize;
			double num = Utils.Lerp(startingSize, endingSize, startingSize);
			float num2 = GenBase._random.NextFloat();
			float num3 = GenBase._random.NextFloat();
			double angle2 = this._angle;
			double angle3 = this._angle;
			double num4 = Utils.Lerp(angle3, angle3, angle2);
			if (!this._quitOnFail)
			{
				return;
			}
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x002553E4 File Offset: 0x002535E4
		public override bool Perform(Point origin, GenAction action)
		{
			double distance = this._distance;
			double angle = this._angle;
			bool flag;
			return flag;
		}

		// Token: 0x04008213 RID: 33299
		private double _angle;

		// Token: 0x04008214 RID: 33300
		private double _startingSize;

		// Token: 0x04008215 RID: 33301
		private double _endingSize;

		// Token: 0x04008216 RID: 33302
		private double _distance;
	}
}
