using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000440 RID: 1088
	[ComVisible(true)]
	[Serializable]
	public enum UnmanagedType
	{
		// Token: 0x04001237 RID: 4663
		Bool = 2,
		// Token: 0x04001238 RID: 4664
		I1,
		// Token: 0x04001239 RID: 4665
		U1,
		// Token: 0x0400123A RID: 4666
		I2,
		// Token: 0x0400123B RID: 4667
		U2,
		// Token: 0x0400123C RID: 4668
		I4,
		// Token: 0x0400123D RID: 4669
		U4,
		// Token: 0x0400123E RID: 4670
		I8,
		// Token: 0x0400123F RID: 4671
		U8,
		// Token: 0x04001240 RID: 4672
		R4,
		// Token: 0x04001241 RID: 4673
		R8,
		// Token: 0x04001242 RID: 4674
		Currency = 15,
		// Token: 0x04001243 RID: 4675
		BStr = 19,
		// Token: 0x04001244 RID: 4676
		LPStr,
		// Token: 0x04001245 RID: 4677
		LPWStr,
		// Token: 0x04001246 RID: 4678
		LPTStr,
		// Token: 0x04001247 RID: 4679
		ByValTStr,
		// Token: 0x04001248 RID: 4680
		IUnknown = 25,
		// Token: 0x04001249 RID: 4681
		IDispatch,
		// Token: 0x0400124A RID: 4682
		Struct,
		// Token: 0x0400124B RID: 4683
		Interface,
		// Token: 0x0400124C RID: 4684
		SafeArray,
		// Token: 0x0400124D RID: 4685
		ByValArray,
		// Token: 0x0400124E RID: 4686
		SysInt,
		// Token: 0x0400124F RID: 4687
		SysUInt,
		// Token: 0x04001250 RID: 4688
		VBByRefStr = 34,
		// Token: 0x04001251 RID: 4689
		AnsiBStr,
		// Token: 0x04001252 RID: 4690
		TBStr,
		// Token: 0x04001253 RID: 4691
		VariantBool,
		// Token: 0x04001254 RID: 4692
		FunctionPtr,
		// Token: 0x04001255 RID: 4693
		AsAny = 40,
		// Token: 0x04001256 RID: 4694
		LPArray = 42,
		// Token: 0x04001257 RID: 4695
		LPStruct,
		// Token: 0x04001258 RID: 4696
		CustomMarshaler,
		// Token: 0x04001259 RID: 4697
		Error,
		// Token: 0x0400125A RID: 4698
		[ComVisible(false)]
		IInspectable,
		// Token: 0x0400125B RID: 4699
		[ComVisible(false)]
		HString,
		// Token: 0x0400125C RID: 4700
		[ComVisible(false)]
		LPUTF8Str
	}
}
