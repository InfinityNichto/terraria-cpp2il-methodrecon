using System;
using System.Runtime.CompilerServices;

namespace NaughtyAttributes
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ShowAssetPreviewAttribute : DrawerAttribute
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000024F4 File Offset: 0x000006F4
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002508 File Offset: 0x00000708
		public int Width
		{
			[CompilerGenerated]
			get
			{
				return this.<Width>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Width>k__BackingField = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000251C File Offset: 0x0000071C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002530 File Offset: 0x00000730
		public int Height
		{
			[CompilerGenerated]
			get
			{
				return this.<Height>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Height>k__BackingField = value;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002544 File Offset: 0x00000744
		public ShowAssetPreviewAttribute(int width = 64, int height = 64)
		{
			this.Width = width;
		}

		// Token: 0x0400001D RID: 29
		[CompilerGenerated]
		private int <Width>k__BackingField;

		// Token: 0x0400001E RID: 30
		[CompilerGenerated]
		private int <Height>k__BackingField;
	}
}
