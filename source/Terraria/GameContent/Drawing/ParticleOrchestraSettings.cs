using System;
using System.IO;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x020009E7 RID: 2535
	public struct ParticleOrchestraSettings
	{
		// Token: 0x06004ACC RID: 19148 RVA: 0x00268208 File Offset: 0x00266408
		public void Serialize(BinaryWriter writer)
		{
			Vector2 positionInWorld = this.PositionInWorld;
			if (!true)
			{
			}
			float x = this.MovementVector.X;
			float y = this.MovementVector.Y;
			int uniqueInfoPiece = this.UniqueInfoPiece;
			byte indexOfPlayerWhoInvokedThis = this.IndexOfPlayerWhoInvokedThis;
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x00268248 File Offset: 0x00266448
		public void DeserializeFrom(BinaryReader reader)
		{
			if (!true)
			{
			}
			Vector2 vector = reader.ReadVector2();
			Vector2 vector2 = reader.ReadVector2();
			this.UniqueInfoPiece = reader;
			this.IndexOfPlayerWhoInvokedThis = reader;
		}

		// Token: 0x0400854D RID: 34125
		public Vector2 PositionInWorld;

		// Token: 0x0400854E RID: 34126
		public Vector2 MovementVector;

		// Token: 0x0400854F RID: 34127
		public int UniqueInfoPiece;

		// Token: 0x04008550 RID: 34128
		public byte IndexOfPlayerWhoInvokedThis;

		// Token: 0x04008551 RID: 34129
		public const int SerializationSize = 21;
	}
}
