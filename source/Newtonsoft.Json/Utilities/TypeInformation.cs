using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000058 RID: 88
	[Preserve]
	internal class TypeInformation
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00009430 File Offset: 0x00007630
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00009444 File Offset: 0x00007644
		public Type Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00009458 File Offset: 0x00007658
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0000946C File Offset: 0x0000766C
		public PrimitiveTypeCode TypeCode
		{
			[CompilerGenerated]
			get
			{
				return this.<TypeCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TypeCode>k__BackingField = value;
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00009480 File Offset: 0x00007680
		public TypeInformation()
		{
		}

		// Token: 0x040001C6 RID: 454
		[CompilerGenerated]
		private Type <Type>k__BackingField;

		// Token: 0x040001C7 RID: 455
		[CompilerGenerated]
		private PrimitiveTypeCode <TypeCode>k__BackingField;
	}
}
