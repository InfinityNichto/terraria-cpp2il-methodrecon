using System;
using System.Runtime.CompilerServices;

namespace NaughtyAttributes
{
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class LabelAttribute : DrawerAttribute
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002380 File Offset: 0x00000580
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002394 File Offset: 0x00000594
		public string Label
		{
			[CompilerGenerated]
			get
			{
				return this.<Label>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Label>k__BackingField = value;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000023A8 File Offset: 0x000005A8
		public LabelAttribute(string label)
		{
			this.Label = label;
		}

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		private string <Label>k__BackingField;
	}
}
