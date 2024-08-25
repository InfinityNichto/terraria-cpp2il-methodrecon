using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003BA RID: 954
	public struct NormalizedByte2 : IPackedVector<ushort>, IPackedVector, IEquatable<NormalizedByte2>
	{
		// Token: 0x060019BA RID: 6586 RVA: 0x0006B760 File Offset: 0x00069960
		public NormalizedByte2(Vector2 vector)
		{
			ushort num;
			this._packed = num;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0006B774 File Offset: 0x00069974
		public NormalizedByte2(float x, float y)
		{
			ushort num = NormalizedByte2.Pack(x, y);
			this._packed = num;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(NormalizedByte2 a, NormalizedByte2 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(NormalizedByte2 a, NormalizedByte2 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0006B790 File Offset: 0x00069990
		[CLSCompliant(false)]
		public ushort PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this._packed = value;
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0006B7A4 File Offset: 0x000699A4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(NormalizedByte2 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0006B7B8 File Offset: 0x000699B8
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0006B7C8 File Offset: 0x000699C8
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0006B7D8 File Offset: 0x000699D8
		private static ushort Pack(float x, float y)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0006B7EC File Offset: 0x000699EC
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ushort num;
			this._packed = num;
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000021DB File Offset: 0x000003DB
		Vector4 IPackedVector.ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector2 ToVector2()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040027A4 RID: 10148
		private ushort _packed;
	}
}
