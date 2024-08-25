using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NaughtyAttributes
{
	// Token: 0x0200001A RID: 26
	public abstract class GroupAttribute : NaughtyAttribute
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002650 File Offset: 0x00000850
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002664 File Offset: 0x00000864
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002678 File Offset: 0x00000878
		public int GroupOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupOrder>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<GroupOrder>k__BackingField = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000268C File Offset: 0x0000088C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000026A0 File Offset: 0x000008A0
		public string ParentGroup
		{
			[CompilerGenerated]
			get
			{
				return this.<ParentGroup>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ParentGroup>k__BackingField = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000026C8 File Offset: 0x000008C8
		public string DisplayChildGroupCondition
		{
			[CompilerGenerated]
			get
			{
				return this.<DisplayChildGroupCondition>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<DisplayChildGroupCondition>k__BackingField = value;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000026DC File Offset: 0x000008DC
		public GroupAttribute(string name, int groupOrder = -1, [Optional] string parentGroup, [Optional] string displayChildGroupCondition)
		{
			this.Name = name;
			this.GroupOrder = groupOrder;
			this.ParentGroup = parentGroup;
			this.DisplayChildGroupCondition = displayChildGroupCondition;
		}

		// Token: 0x04000021 RID: 33
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000022 RID: 34
		[CompilerGenerated]
		private int <GroupOrder>k__BackingField;

		// Token: 0x04000023 RID: 35
		[CompilerGenerated]
		private string <ParentGroup>k__BackingField;

		// Token: 0x04000024 RID: 36
		[CompilerGenerated]
		private string <DisplayChildGroupCondition>k__BackingField;
	}
}
