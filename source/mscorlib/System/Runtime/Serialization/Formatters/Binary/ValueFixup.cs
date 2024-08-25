using System;
using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000428 RID: 1064
	internal sealed class ValueFixup
	{
		// Token: 0x06002139 RID: 8505 RVA: 0x0004B988 File Offset: 0x00049B88
		internal ValueFixup(Array arrayObj, int[] indexMap)
		{
			this.valueFixupEnum = ValueFixupEnum.Array;
			this.arrayObj = arrayObj;
			this.indexMap = indexMap;
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x0004B9B0 File Offset: 0x00049BB0
		internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo)
		{
			this.objectInfo = objectInfo;
			this.memberName = memberName;
			this.valueFixupEnum = ValueFixupEnum.Member;
			this.memberObject = memberObject;
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0004B9E0 File Offset: 0x00049BE0
		internal void Fixup(ParseRecord record, ParseRecord parent)
		{
			ValueFixupEnum valueFixupEnum = this.valueFixupEnum;
			object prnewObj = record.PRnewObj;
			Array array = this.arrayObj;
			int[] array2 = this.indexMap;
			array.SetValue(prnewObj, array2);
		}

		// Token: 0x040011B6 RID: 4534
		internal ValueFixupEnum valueFixupEnum;

		// Token: 0x040011B7 RID: 4535
		internal Array arrayObj;

		// Token: 0x040011B8 RID: 4536
		internal int[] indexMap;

		// Token: 0x040011B9 RID: 4537
		internal object header;

		// Token: 0x040011BA RID: 4538
		internal object memberObject;

		// Token: 0x040011BB RID: 4539
		internal static MemberInfo valueInfo;

		// Token: 0x040011BC RID: 4540
		internal ReadObjectInfo objectInfo;

		// Token: 0x040011BD RID: 4541
		internal string memberName;
	}
}
