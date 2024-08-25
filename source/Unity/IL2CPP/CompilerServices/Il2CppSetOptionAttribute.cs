using System;
using System.Runtime.CompilerServices;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x02000B64 RID: 2916
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public class Il2CppSetOptionAttribute : Attribute
	{
		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x00286D40 File Offset: 0x00284F40
		// (set) Token: 0x060054B5 RID: 21685 RVA: 0x00286D54 File Offset: 0x00284F54
		public Option Option
		{
			[CompilerGenerated]
			get
			{
				return this.<Option>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Option>k__BackingField = value;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x00286D68 File Offset: 0x00284F68
		// (set) Token: 0x060054B7 RID: 21687 RVA: 0x00286D7C File Offset: 0x00284F7C
		public object Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x00286D90 File Offset: 0x00284F90
		public Il2CppSetOptionAttribute(Option option, object value)
		{
			this.Option = option;
			this.Value = value;
		}

		// Token: 0x04008DAB RID: 36267
		[CompilerGenerated]
		private Option <Option>k__BackingField;

		// Token: 0x04008DAC RID: 36268
		[CompilerGenerated]
		private object <Value>k__BackingField;
	}
}
