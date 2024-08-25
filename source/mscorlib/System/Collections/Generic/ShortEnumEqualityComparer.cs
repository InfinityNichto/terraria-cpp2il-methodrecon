using System;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x0200065C RID: 1628
	[Serializable]
	internal sealed class ShortEnumEqualityComparer<T> : EnumEqualityComparer<T>, ISerializable where T : struct
	{
		// Token: 0x060031AC RID: 12716 RVA: 0x0001B05E File Offset: 0x0001925E
		public ShortEnumEqualityComparer()
		{
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x0001B05E File Offset: 0x0001925E
		public ShortEnumEqualityComparer(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x0006B958 File Offset: 0x00069B58
		public override int GetHashCode(T obj)
		{
			return 0;
		}
	}
}
