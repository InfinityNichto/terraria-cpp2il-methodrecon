using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000462 RID: 1122
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	public sealed class AsyncMethodBuilderAttribute : Attribute
	{
		// Token: 0x060021F1 RID: 8689 RVA: 0x0004CBB4 File Offset: 0x0004ADB4
		public AsyncMethodBuilderAttribute(Type builderType)
		{
			this.<BuilderType>k__BackingField = builderType;
		}

		// Token: 0x040012A2 RID: 4770
		[CompilerGenerated]
		private readonly Type <BuilderType>k__BackingField;
	}
}
