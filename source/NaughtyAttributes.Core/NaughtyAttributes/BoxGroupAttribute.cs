using System;
using System.Runtime.InteropServices;

namespace NaughtyAttributes
{
	// Token: 0x02000019 RID: 25
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class BoxGroupAttribute : GroupAttribute
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000260C File Offset: 0x0000080C
		public BoxGroupAttribute(string name = "", int groupOrder = -1, [Optional] string parentGroup, [Optional] string subGroupCondition)
		{
			this.<Name>k__BackingField = name;
			this.<GroupOrder>k__BackingField = groupOrder;
			this.<ParentGroup>k__BackingField = parentGroup;
			this.<DisplayChildGroupCondition>k__BackingField = subGroupCondition;
		}
	}
}
