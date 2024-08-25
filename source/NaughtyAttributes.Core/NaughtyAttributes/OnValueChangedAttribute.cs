using System;
using System.Runtime.CompilerServices;

namespace NaughtyAttributes
{
	// Token: 0x0200001E RID: 30
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
	public class OnValueChangedAttribute : MetaAttribute
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000280C File Offset: 0x00000A0C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002820 File Offset: 0x00000A20
		public string CallbackName
		{
			[CompilerGenerated]
			get
			{
				return this.<CallbackName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<CallbackName>k__BackingField = value;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002834 File Offset: 0x00000A34
		public OnValueChangedAttribute(string callbackName)
		{
			this.CallbackName = callbackName;
		}

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		private string <CallbackName>k__BackingField;
	}
}
