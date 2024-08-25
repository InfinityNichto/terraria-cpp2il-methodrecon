using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003E7 RID: 999
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class OptionalFieldAttribute : Attribute
	{
		// Token: 0x06001F8C RID: 8076 RVA: 0x0004553C File Offset: 0x0004373C
		public OptionalFieldAttribute()
		{
		}

		// Token: 0x17000434 RID: 1076
		// (set) Token: 0x06001F8D RID: 8077 RVA: 0x00045558 File Offset: 0x00043758
		public int VersionAdded
		{
			set
			{
				this.versionAdded = value;
			}
		}

		// Token: 0x04000FC8 RID: 4040
		private int versionAdded = 1;
	}
}
