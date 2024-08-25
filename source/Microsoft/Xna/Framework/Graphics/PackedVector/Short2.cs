using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003C1 RID: 961
	public struct Short2 : IPackedVector<uint>, IPackedVector, IEquatable<Short2>
	{
		// Token: 0x06001A18 RID: 6680 RVA: 0x0006BD04 File Offset: 0x00069F04
		public Short2(Vector2 vector)
		{
			uint num;
			this._short2Packed = num;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0006BD18 File Offset: 0x00069F18
		public Short2(float x, float y)
		{
			uint num = Short2.PackInTwo(x, y);
			this._short2Packed = num;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Short2 a, Short2 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Short2 a, Short2 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0006BD34 File Offset: 0x00069F34
		[CLSCompliant(false)]
		public uint PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this._short2Packed = value;
			}
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0006BD48 File Offset: 0x00069F48
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Short2 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0006BD5C File Offset: 0x00069F5C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0006BD6C File Offset: 0x00069F6C
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector2 ToVector2()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0006BD7C File Offset: 0x00069F7C
		private static uint PackInTwo(float vectorX, float vectorY)
		{
			if (50944 == 0)
			{
				return;
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0006BD94 File Offset: 0x00069F94
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			uint num;
			this._short2Packed = num;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000021DB File Offset: 0x000003DB
		Vector4 IPackedVector.ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040027AB RID: 10155
		private uint _short2Packed;
	}
}
