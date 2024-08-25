using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003C2 RID: 962
	public struct Short4 : IPackedVector<ulong>, IPackedVector, IEquatable<Short4>
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x0006BDA8 File Offset: 0x00069FA8
		public Short4(Vector4 vector)
		{
			ulong num;
			this.packedValue = num;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0006BDBC File Offset: 0x00069FBC
		public Short4(float x, float y, float z, float w)
		{
			ulong num;
			this.packedValue = num;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Short4 a, Short4 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Short4 a, Short4 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0006BDD0 File Offset: 0x00069FD0
		[CLSCompliant(false)]
		public ulong PackedValue
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

		// Token: 0x06001A2C RID: 6700 RVA: 0x0006BDE4 File Offset: 0x00069FE4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Short4 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0006BDF8 File Offset: 0x00069FF8
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0006BE08 File Offset: 0x0006A008
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0006BE18 File Offset: 0x0006A018
		private static ulong Pack(Vector4 vector)
		{
			if (50944 == 0)
			{
				return;
			}
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0006BE38 File Offset: 0x0006A038
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ulong num;
			this.packedValue = num;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector4 ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040027AC RID: 10156
		private ulong packedValue;
	}
}
