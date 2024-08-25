using System;
using System.ComponentModel;

namespace System
{
	// Token: 0x0200009F RID: 159
	[AttributeUsage(AttributeTargets.All)]
	internal class SRDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
	{
		// Token: 0x060002CD RID: 717 RVA: 0x0000AC48 File Offset: 0x00008E48
		public SRDescriptionAttribute(string description)
		{
			if (!true)
			{
			}
			base..ctor(description);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000AC60 File Offset: 0x00008E60
		public override string Description
		{
			get
			{
				if (this.isReplaced)
				{
					return this.<DescriptionValue>k__BackingField;
				}
				string <DescriptionValue>k__BackingField = this.<DescriptionValue>k__BackingField;
				this.isReplaced = true;
				string text = Locale.GetText(<DescriptionValue>k__BackingField);
				this.<DescriptionValue>k__BackingField = text;
				return text;
			}
		}

		// Token: 0x04000276 RID: 630
		private bool isReplaced;
	}
}
