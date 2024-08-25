using System;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x0200065B RID: 1627
	[Serializable]
	internal sealed class SByteEnumEqualityComparer<T> : EnumEqualityComparer<T>, ISerializable where T : struct
	{
		// Token: 0x060031A9 RID: 12713 RVA: 0x0001B05E File Offset: 0x0001925E
		public SByteEnumEqualityComparer()
		{
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x0001B05E File Offset: 0x0001925E
		public SByteEnumEqualityComparer(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x0006B940 File Offset: 0x00069B40
		public override int GetHashCode(T obj)
		{
			return 0;
		}
	}
}
