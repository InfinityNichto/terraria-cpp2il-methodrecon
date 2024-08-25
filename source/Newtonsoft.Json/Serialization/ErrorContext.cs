using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000095 RID: 149
	[Preserve]
	public class ErrorContext
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x0000D77C File Offset: 0x0000B97C
		internal ErrorContext(object originalObject, object member, string path, Exception error)
		{
			this.Error = error;
			this.OriginalObject = originalObject;
			this.Member = member;
			this.Path = path;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
		internal bool Traced
		{
			[CompilerGenerated]
			get
			{
				return this.<Traced>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		public Exception Error
		{
			[CompilerGenerated]
			get
			{
				return this.<Error>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Error>k__BackingField = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x0000D80C File Offset: 0x0000BA0C
		public object OriginalObject
		{
			[CompilerGenerated]
			get
			{
				return this.<OriginalObject>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<OriginalObject>k__BackingField = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0000D820 File Offset: 0x0000BA20
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x0000D834 File Offset: 0x0000BA34
		public object Member
		{
			[CompilerGenerated]
			get
			{
				return this.<Member>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Member>k__BackingField = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0000D848 File Offset: 0x0000BA48
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0000D85C File Offset: 0x0000BA5C
		public string Path
		{
			[CompilerGenerated]
			get
			{
				return this.<Path>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Path>k__BackingField = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000D870 File Offset: 0x0000BA70
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x0000D884 File Offset: 0x0000BA84
		public bool Handled
		{
			[CompilerGenerated]
			get
			{
				return this.<Handled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0400024B RID: 587
		[CompilerGenerated]
		private bool <Traced>k__BackingField;

		// Token: 0x0400024C RID: 588
		[CompilerGenerated]
		private Exception <Error>k__BackingField;

		// Token: 0x0400024D RID: 589
		[CompilerGenerated]
		private object <OriginalObject>k__BackingField;

		// Token: 0x0400024E RID: 590
		[CompilerGenerated]
		private object <Member>k__BackingField;

		// Token: 0x0400024F RID: 591
		[CompilerGenerated]
		private string <Path>k__BackingField;

		// Token: 0x04000250 RID: 592
		[CompilerGenerated]
		private bool <Handled>k__BackingField;
	}
}
