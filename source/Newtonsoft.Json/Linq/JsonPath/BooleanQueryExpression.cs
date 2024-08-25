using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000F1 RID: 241
	[Preserve]
	internal class BooleanQueryExpression : QueryExpression
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00018360 File Offset: 0x00016560
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00018374 File Offset: 0x00016574
		public List<PathFilter> Path
		{
			[CompilerGenerated]
			get
			{
				return this.<Path>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Path>k__BackingField = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00018388 File Offset: 0x00016588
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0001839C File Offset: 0x0001659C
		public JValue Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000183B0 File Offset: 0x000165B0
		public override bool IsMatch(JToken t)
		{
			List<PathFilter> list = this.<Path>k__BackingField;
			long num = 0L;
			IEnumerable<JToken> enumerable = JPath.Evaluate(list, t, num != 0L);
			if (enumerable != null)
			{
			}
			QueryOperator <Operator>k__BackingField = this.<Operator>k__BackingField;
			QueryOperator <Operator>k__BackingField2 = this.<Operator>k__BackingField;
			JValue jvalue = this.<Value>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0001848C File Offset: 0x0001668C
		private bool EqualsWithStringCoercion(JValue value, JValue queryValue)
		{
			if (queryValue != null)
			{
				return JValue.ValuesEquals(value, queryValue);
			}
			if (queryValue._value != null)
			{
			}
			object value2 = value._value;
			if (value._value != null)
			{
			}
			StringWriter stringWriter = StringUtils.CreateStringWriter(64);
			if (value._value != null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			long num = 0L;
			int num2 = 12;
			if (num == 0L)
			{
				while (num2 != 0)
				{
				}
				object value3 = value._value;
				if (value3 != null)
				{
					if (value3 == null)
					{
						throw new InvalidCastException();
					}
				}
				bool flag;
				return flag;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00018530 File Offset: 0x00016730
		public BooleanQueryExpression()
		{
		}

		// Token: 0x040003DD RID: 989
		[CompilerGenerated]
		private List<PathFilter> <Path>k__BackingField;

		// Token: 0x040003DE RID: 990
		[CompilerGenerated]
		private JValue <Value>k__BackingField;
	}
}
