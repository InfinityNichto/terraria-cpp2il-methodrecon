using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000EF RID: 239
	[Preserve]
	internal abstract class QueryExpression
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x000182A8 File Offset: 0x000164A8
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x000182BC File Offset: 0x000164BC
		public QueryOperator Operator
		{
			[CompilerGenerated]
			get
			{
				return this.<Operator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Operator>k__BackingField = value;
			}
		}

		// Token: 0x060009D6 RID: 2518
		public abstract bool IsMatch(JToken t);

		// Token: 0x060009D7 RID: 2519 RVA: 0x000182D0 File Offset: 0x000164D0
		protected QueryExpression()
		{
		}

		// Token: 0x040003DB RID: 987
		[CompilerGenerated]
		private QueryOperator <Operator>k__BackingField;
	}
}
