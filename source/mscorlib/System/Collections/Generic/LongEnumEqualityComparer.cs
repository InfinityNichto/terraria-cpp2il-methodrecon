using System;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x0200065D RID: 1629
	[Serializable]
	internal sealed class LongEnumEqualityComparer<T> : EqualityComparer<T>, ISerializable where T : struct
	{
		// Token: 0x060031AF RID: 12719 RVA: 0x0006B970 File Offset: 0x00069B70
		public override bool Equals(T x, T y)
		{
			return default(bool);
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x0006B988 File Offset: 0x00069B88
		public override int GetHashCode(T obj)
		{
			return 0;
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x0006B9A0 File Offset: 0x00069BA0
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x0006B9B8 File Offset: 0x00069BB8
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x0001B05E File Offset: 0x0001925E
		public LongEnumEqualityComparer()
		{
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x0001B05E File Offset: 0x0001925E
		public LongEnumEqualityComparer(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x0001B05E File Offset: 0x0001925E
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
