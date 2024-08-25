using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003BE RID: 958
	public struct Rg32 : IPackedVector<uint>, IPackedVector, IEquatable<Rg32>
	{
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x0006BA98 File Offset: 0x00069C98
		[CLSCompliant(false)]
		public uint PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.packedValue = value;
			}
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0006BAAC File Offset: 0x00069CAC
		public Rg32(float x, float y)
		{
			uint num = Rg32.Pack(x, y);
			this.packedValue = num;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0006BAC8 File Offset: 0x00069CC8
		public Rg32(Vector2 vector)
		{
			uint num;
			this.packedValue = num;
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector2 ToVector2()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0006BADC File Offset: 0x00069CDC
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			uint num;
			this.packedValue = num;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0006BAF0 File Offset: 0x00069CF0
		Vector4 IPackedVector.ToVector4()
		{
			Vector2 vector = this.ToVector2();
			Vector4 vector2;
			return vector2;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x0006BB08 File Offset: 0x00069D08
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Rg32 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0006BB1C File Offset: 0x00069D1C
		public override string ToString()
		{
			return this.ToVector2().ToString();
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0006BB34 File Offset: 0x00069D34
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Rg32 lhs, Rg32 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Rg32 lhs, Rg32 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0006BB44 File Offset: 0x00069D44
		private static uint Pack(float x, float y)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x040027A8 RID: 10152
		private uint packedValue;
	}
}
