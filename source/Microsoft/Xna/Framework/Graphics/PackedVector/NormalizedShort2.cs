using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003BC RID: 956
	public struct NormalizedShort2 : IPackedVector<uint>, IPackedVector, IEquatable<NormalizedShort2>
	{
		// Token: 0x060019D5 RID: 6613 RVA: 0x0006B8D0 File Offset: 0x00069AD0
		public NormalizedShort2(Vector2 vector)
		{
			uint num;
			this.short2Packed = num;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0006B8E4 File Offset: 0x00069AE4
		public NormalizedShort2(float x, float y)
		{
			uint num = NormalizedShort2.PackInTwo(x, y);
			this.short2Packed = num;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0006B900 File Offset: 0x00069B00
		public static bool operator !=(NormalizedShort2 a, NormalizedShort2 b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0006B910 File Offset: 0x00069B10
		public static bool operator ==(NormalizedShort2 a, NormalizedShort2 b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x0006B920 File Offset: 0x00069B20
		[CLSCompliant(false)]
		public uint PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.short2Packed = value;
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0006B934 File Offset: 0x00069B34
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0006B948 File Offset: 0x00069B48
		public bool Equals(NormalizedShort2 other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0006B958 File Offset: 0x00069B58
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0006B968 File Offset: 0x00069B68
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector2 ToVector2()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0006B978 File Offset: 0x00069B78
		private static uint PackInTwo(float vectorX, float vectorY)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0006B98C File Offset: 0x00069B8C
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x000021DB File Offset: 0x000003DB
		Vector4 IPackedVector.ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040027A6 RID: 10150
		private uint short2Packed;
	}
}
