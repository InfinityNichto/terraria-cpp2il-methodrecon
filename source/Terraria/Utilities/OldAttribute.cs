using System;

namespace Terraria.Utilities
{
	// Token: 0x02000506 RID: 1286
	public sealed class OldAttribute : Attribute
	{
		// Token: 0x06003118 RID: 12568 RVA: 0x001F78A0 File Offset: 0x001F5AA0
		public OldAttribute()
		{
			this.message = "";
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x001F78C0 File Offset: 0x001F5AC0
		public OldAttribute(string message)
		{
			this.message = message;
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x001F78DC File Offset: 0x001F5ADC
		public string Message
		{
			get
			{
				return this.message;
			}
		}

		// Token: 0x04003AEF RID: 15087
		private string message;
	}
}
