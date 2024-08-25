using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x020005C7 RID: 1479
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
	[Serializable]
	public sealed class ConditionalAttribute : Attribute
	{
		// Token: 0x06002D4C RID: 11596 RVA: 0x000644AC File Offset: 0x000626AC
		public ConditionalAttribute(string conditionString)
		{
			this.<ConditionString>k__BackingField = conditionString;
		}

		// Token: 0x0400194E RID: 6478
		[CompilerGenerated]
		private readonly string <ConditionString>k__BackingField;
	}
}
