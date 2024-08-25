using System;

namespace System.Reflection
{
	// Token: 0x020004D5 RID: 1237
	[Flags]
	public enum GenericParameterAttributes
	{
		// Token: 0x040013A8 RID: 5032
		None = 0,
		// Token: 0x040013A9 RID: 5033
		VarianceMask = 3,
		// Token: 0x040013AA RID: 5034
		Covariant = 1,
		// Token: 0x040013AB RID: 5035
		Contravariant = 2,
		// Token: 0x040013AC RID: 5036
		SpecialConstraintMask = 28,
		// Token: 0x040013AD RID: 5037
		ReferenceTypeConstraint = 4,
		// Token: 0x040013AE RID: 5038
		NotNullableValueTypeConstraint = 8,
		// Token: 0x040013AF RID: 5039
		DefaultConstructorConstraint = 16
	}
}
