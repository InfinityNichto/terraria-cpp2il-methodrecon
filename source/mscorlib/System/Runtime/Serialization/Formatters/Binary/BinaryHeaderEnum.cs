using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F3 RID: 1011
	internal enum BinaryHeaderEnum
	{
		// Token: 0x04000FF1 RID: 4081
		SerializedStreamHeader,
		// Token: 0x04000FF2 RID: 4082
		Object,
		// Token: 0x04000FF3 RID: 4083
		ObjectWithMap,
		// Token: 0x04000FF4 RID: 4084
		ObjectWithMapAssemId,
		// Token: 0x04000FF5 RID: 4085
		ObjectWithMapTyped,
		// Token: 0x04000FF6 RID: 4086
		ObjectWithMapTypedAssemId,
		// Token: 0x04000FF7 RID: 4087
		ObjectString,
		// Token: 0x04000FF8 RID: 4088
		Array,
		// Token: 0x04000FF9 RID: 4089
		MemberPrimitiveTyped,
		// Token: 0x04000FFA RID: 4090
		MemberReference,
		// Token: 0x04000FFB RID: 4091
		ObjectNull,
		// Token: 0x04000FFC RID: 4092
		MessageEnd,
		// Token: 0x04000FFD RID: 4093
		Assembly,
		// Token: 0x04000FFE RID: 4094
		ObjectNullMultiple256,
		// Token: 0x04000FFF RID: 4095
		ObjectNullMultiple,
		// Token: 0x04001000 RID: 4096
		ArraySinglePrimitive,
		// Token: 0x04001001 RID: 4097
		ArraySingleObject,
		// Token: 0x04001002 RID: 4098
		ArraySingleString,
		// Token: 0x04001003 RID: 4099
		CrossAppDomainMap,
		// Token: 0x04001004 RID: 4100
		CrossAppDomainString,
		// Token: 0x04001005 RID: 4101
		CrossAppDomainAssembly,
		// Token: 0x04001006 RID: 4102
		MethodCall,
		// Token: 0x04001007 RID: 4103
		MethodReturn
	}
}
