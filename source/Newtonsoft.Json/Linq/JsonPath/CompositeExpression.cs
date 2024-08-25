using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000F0 RID: 240
	[Preserve]
	internal class CompositeExpression : QueryExpression
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x000182E4 File Offset: 0x000164E4
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x000182F8 File Offset: 0x000164F8
		public List<QueryExpression> Expressions
		{
			[CompilerGenerated]
			get
			{
				return this.<Expressions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Expressions>k__BackingField = value;
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0001830C File Offset: 0x0001650C
		public CompositeExpression()
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00018320 File Offset: 0x00016520
		public override bool IsMatch(JToken t)
		{
			QueryOperator <Operator>k__BackingField = this.<Operator>k__BackingField;
			List<QueryExpression> list = this.<Expressions>k__BackingField;
			List<QueryExpression> list2 = this.<Expressions>k__BackingField;
			return true;
		}

		// Token: 0x040003DC RID: 988
		[CompilerGenerated]
		private List<QueryExpression> <Expressions>k__BackingField;
	}
}
