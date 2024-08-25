using System;

namespace NaughtyAttributes
{
	// Token: 0x02000004 RID: 4
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class HideIfAttribute : ShowIfAttribute
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		public HideIfAttribute(string condition)
			: base(condition)
		{
			this.<Reversed>k__BackingField = true;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		public HideIfAttribute(ConditionOperator conditionOperator, params string[] conditions)
		{
			this.<ConditionOperator>k__BackingField = conditionOperator;
			this.<Conditions>k__BackingField = conditions;
			this.<Reversed>k__BackingField = true;
		}
	}
}
