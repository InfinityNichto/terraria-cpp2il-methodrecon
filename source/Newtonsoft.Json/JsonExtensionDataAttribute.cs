using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000016 RID: 22
	[Preserve]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class JsonExtensionDataAttribute : Attribute
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002594 File Offset: 0x00000794
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000025A8 File Offset: 0x000007A8
		public bool WriteData
		{
			[CompilerGenerated]
			get
			{
				return this.<WriteData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000025B8 File Offset: 0x000007B8
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000025CC File Offset: 0x000007CC
		public bool ReadData
		{
			[CompilerGenerated]
			get
			{
				return this.<ReadData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000025DC File Offset: 0x000007DC
		public JsonExtensionDataAttribute()
		{
			this.<WriteData>k__BackingField = 257 != 0;
		}

		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		private bool <WriteData>k__BackingField;

		// Token: 0x04000028 RID: 40
		[CompilerGenerated]
		private bool <ReadData>k__BackingField;
	}
}
