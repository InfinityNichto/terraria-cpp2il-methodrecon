using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003B2 RID: 946
	public struct Byte4 : IPackedVector<uint>, IPackedVector, IEquatable<Byte4>
	{
		// Token: 0x0600197E RID: 6526 RVA: 0x0006B40C File Offset: 0x0006960C
		public Byte4(Vector4 vector)
		{
			uint num;
			this.packedValue = num;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0006B420 File Offset: 0x00069620
		public Byte4(float x, float y, float z, float w)
		{
			uint num;
			this.packedValue = num;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Byte4 a, Byte4 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Byte4 a, Byte4 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x0006B434 File Offset: 0x00069634
		[CLSCompliant(false)]
		public uint PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0006B444 File Offset: 0x00069644
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Byte4 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0006B458 File Offset: 0x00069658
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0006B468 File Offset: 0x00069668
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0006B478 File Offset: 0x00069678
		private static uint Pack(Vector4 vector)
		{
			if (17279 == 0)
			{
				return;
			}
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0006B498 File Offset: 0x00069698
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			uint num;
			this.packedValue = num;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector4 ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400279D RID: 10141
		private uint packedValue;
	}
}
