using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003B3 RID: 947
	public struct HalfSingle : IPackedVector<ushort>, IPackedVector, IEquatable<HalfSingle>
	{
		// Token: 0x0600198B RID: 6539 RVA: 0x0006B4AC File Offset: 0x000696AC
		public HalfSingle(float single)
		{
			ushort num;
			this.packedValue = num;
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x0006B4C0 File Offset: 0x000696C0
		[CLSCompliant(false)]
		public ushort PackedValue
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

		// Token: 0x0600198E RID: 6542 RVA: 0x000021DB File Offset: 0x000003DB
		public float ToSingle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0006B4D4 File Offset: 0x000696D4
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ushort num;
			this.packedValue = num;
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0006B4E8 File Offset: 0x000696E8
		Vector4 IPackedVector.ToVector4()
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0006B4F8 File Offset: 0x000696F8
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				Type type;
				bool flag = obj.GetType() == type;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(HalfSingle other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0006B51C File Offset: 0x0006971C
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0006B52C File Offset: 0x0006972C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(HalfSingle lhs, HalfSingle rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(HalfSingle lhs, HalfSingle rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400279E RID: 10142
		private ushort packedValue;
	}
}
