using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x0200045F RID: 1119
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface, Inherited = false)]
	public sealed class ReliabilityContractAttribute : Attribute
	{
		// Token: 0x060021ED RID: 8685 RVA: 0x0004CB5C File Offset: 0x0004AD5C
		public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
		{
			this.<ConsistencyGuarantee>k__BackingField = consistencyGuarantee;
		}

		// Token: 0x040012A0 RID: 4768
		[CompilerGenerated]
		private readonly Consistency <ConsistencyGuarantee>k__BackingField;

		// Token: 0x040012A1 RID: 4769
		[CompilerGenerated]
		private readonly Cer <Cer>k__BackingField;
	}
}
