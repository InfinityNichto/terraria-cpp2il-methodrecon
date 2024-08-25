using System;

namespace Terraria
{
	// Token: 0x02000458 RID: 1112
	public class Ref<T>
	{
		// Token: 0x060029DB RID: 10715 RVA: 0x001B16E8 File Offset: 0x001AF8E8
		public Ref()
		{
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x001B16FC File Offset: 0x001AF8FC
		public Ref(T value)
		{
			this.Value = value;
		}

		// Token: 0x040036F2 RID: 14066
		public T Value;
	}
}
