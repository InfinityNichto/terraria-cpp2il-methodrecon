using System;
using System.Runtime.CompilerServices;

namespace NaughtyAttributes
{
	// Token: 0x02000009 RID: 9
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class DropdownAttribute : DrawerAttribute
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021FC File Offset: 0x000003FC
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002210 File Offset: 0x00000410
		public string ValuesFieldName
		{
			[CompilerGenerated]
			get
			{
				return this.<ValuesFieldName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ValuesFieldName>k__BackingField = value;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002224 File Offset: 0x00000424
		public DropdownAttribute(string valuesFieldName)
		{
			this.ValuesFieldName = valuesFieldName;
		}

		// Token: 0x04000008 RID: 8
		[CompilerGenerated]
		private string <ValuesFieldName>k__BackingField;
	}
}
