using System;
using System.Runtime.CompilerServices;

namespace NaughtyAttributes
{
	// Token: 0x02000005 RID: 5
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ShowIfAttribute : DrawConditionAttribute
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020A8 File Offset: 0x000002A8
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020BC File Offset: 0x000002BC
		public string[] Conditions
		{
			[CompilerGenerated]
			get
			{
				return this.<Conditions>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Conditions>k__BackingField = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020E4 File Offset: 0x000002E4
		public ConditionOperator ConditionOperator
		{
			[CompilerGenerated]
			get
			{
				return this.<ConditionOperator>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ConditionOperator>k__BackingField = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020F8 File Offset: 0x000002F8
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000210C File Offset: 0x0000030C
		public bool Reversed
		{
			[CompilerGenerated]
			get
			{
				return this.<Reversed>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000031C
		public ShowIfAttribute(string condition)
		{
			if (condition == null || condition != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000213C File Offset: 0x0000033C
		public ShowIfAttribute(ConditionOperator conditionOperator, params string[] conditions)
		{
			this.ConditionOperator = conditionOperator;
			this.Conditions = conditions;
		}

		// Token: 0x04000004 RID: 4
		[CompilerGenerated]
		private string[] <Conditions>k__BackingField;

		// Token: 0x04000005 RID: 5
		[CompilerGenerated]
		private ConditionOperator <ConditionOperator>k__BackingField;

		// Token: 0x04000006 RID: 6
		[CompilerGenerated]
		private bool <Reversed>k__BackingField;
	}
}
