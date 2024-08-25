using System;

namespace NaughtyAttributes
{
	// Token: 0x02000007 RID: 7
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class DisableIfAttribute : EnableIfAttribute
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000021A4 File Offset: 0x000003A4
		public DisableIfAttribute(string condition)
			: base(condition)
		{
			this.<Reversed>k__BackingField = true;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021C0 File Offset: 0x000003C0
		public DisableIfAttribute(ConditionOperator conditionOperator, params string[] conditions)
		{
			this.<ConditionOperator>k__BackingField = conditionOperator;
			this.<Conditions>k__BackingField = conditions;
			this.<Reversed>k__BackingField = true;
		}
	}
}
