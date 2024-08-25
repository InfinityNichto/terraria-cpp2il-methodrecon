using System;

namespace Mono.Security.Interface
{
	// Token: 0x02000044 RID: 68
	public class Alert
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00008A44 File Offset: 0x00006C44
		public AlertLevel Level
		{
			get
			{
				return this.level;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00008A58 File Offset: 0x00006C58
		public AlertDescription Description
		{
			get
			{
				return this.description;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008A6C File Offset: 0x00006C6C
		public Alert(AlertDescription description)
		{
			this.description = description;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00008A90 File Offset: 0x00006C90
		private void inferAlertLevel()
		{
			if (this.description == AlertDescription.CloseNotify)
			{
				return;
			}
			this.level = AlertLevel.Fatal;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00008AB0 File Offset: 0x00006CB0
		public override string ToString()
		{
			AlertLevel alertLevel = this.level;
			AlertDescription alertDescription = this.description;
			string text;
			return text;
		}

		// Token: 0x04000114 RID: 276
		private AlertLevel level;

		// Token: 0x04000115 RID: 277
		private AlertDescription description;
	}
}
