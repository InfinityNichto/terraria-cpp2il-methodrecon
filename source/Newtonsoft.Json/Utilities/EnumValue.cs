using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000068 RID: 104
	[Preserve]
	internal class EnumValue<T> where T : struct
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000A740 File Offset: 0x00008940
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000A754 File Offset: 0x00008954
		public T Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000A768 File Offset: 0x00008968
		public EnumValue(string name, T value)
		{
			this._name = name;
			this._value = value;
		}

		// Token: 0x040001F1 RID: 497
		private readonly string _name;

		// Token: 0x040001F2 RID: 498
		private readonly T _value;
	}
}
