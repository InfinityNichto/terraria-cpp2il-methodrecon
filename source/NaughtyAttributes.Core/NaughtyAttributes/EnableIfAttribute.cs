using System;
using System.Runtime.CompilerServices;

namespace NaughtyAttributes
{
	// Token: 0x0200000C RID: 12
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class EnableIfAttribute : DrawerAttribute
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000022DC File Offset: 0x000004DC
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000022F0 File Offset: 0x000004F0
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002304 File Offset: 0x00000504
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002318 File Offset: 0x00000518
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000232C File Offset: 0x0000052C
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

		// Token: 0x06000020 RID: 32 RVA: 0x0000233C File Offset: 0x0000053C
		public EnableIfAttribute(string condition)
		{
			if (condition == null || condition != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000235C File Offset: 0x0000055C
		public EnableIfAttribute(ConditionOperator conditionOperator, params string[] conditions)
		{
			this.ConditionOperator = conditionOperator;
			this.Conditions = conditions;
		}

		// Token: 0x0400000A RID: 10
		[CompilerGenerated]
		private string[] <Conditions>k__BackingField;

		// Token: 0x0400000B RID: 11
		[CompilerGenerated]
		private ConditionOperator <ConditionOperator>k__BackingField;

		// Token: 0x0400000C RID: 12
		[CompilerGenerated]
		private bool <Reversed>k__BackingField;
	}
}
