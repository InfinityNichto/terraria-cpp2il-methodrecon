using System;

namespace System.Runtime.Serialization
{
	// Token: 0x02000004 RID: 4
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class EnumMemberAttribute : Attribute
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020E4 File Offset: 0x000002E4
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x04000006 RID: 6
		private string value;
	}
}
