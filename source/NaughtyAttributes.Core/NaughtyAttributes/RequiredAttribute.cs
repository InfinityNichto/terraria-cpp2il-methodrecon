using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NaughtyAttributes
{
	// Token: 0x02000022 RID: 34
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class RequiredAttribute : ValidatorAttribute
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000028FC File Offset: 0x00000AFC
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002910 File Offset: 0x00000B10
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this.<Message>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Message>k__BackingField = value;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002924 File Offset: 0x00000B24
		public RequiredAttribute([Optional] string message)
		{
			this.Message = message;
		}

		// Token: 0x04000030 RID: 48
		[CompilerGenerated]
		private string <Message>k__BackingField;
	}
}
