using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004CE RID: 1230
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class DefaultMemberAttribute : Attribute
	{
		// Token: 0x0600237E RID: 9086 RVA: 0x000504C0 File Offset: 0x0004E6C0
		public DefaultMemberAttribute(string memberName)
		{
			this.MemberName = memberName;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000504DC File Offset: 0x0004E6DC
		public string MemberName
		{
			[CompilerGenerated]
			get
			{
				return this.<MemberName>k__BackingField;
			}
		}

		// Token: 0x04001387 RID: 4999
		[CompilerGenerated]
		private readonly string <MemberName>k__BackingField;
	}
}
