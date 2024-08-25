using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NaughtyAttributes
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ValidateInputAttribute : ValidatorAttribute
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002954 File Offset: 0x00000B54
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002968 File Offset: 0x00000B68
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000297C File Offset: 0x00000B7C
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

		// Token: 0x0600006A RID: 106 RVA: 0x00002990 File Offset: 0x00000B90
		public ValidateInputAttribute(string callbackName, [Optional] string message)
		{
			this.CallbackName = callbackName;
			this.Message = message;
		}

		// Token: 0x04000031 RID: 49
		[CompilerGenerated]
		private string <CallbackName>k__BackingField;

		// Token: 0x04000032 RID: 50
		[CompilerGenerated]
		private string <Message>k__BackingField;
	}
}
