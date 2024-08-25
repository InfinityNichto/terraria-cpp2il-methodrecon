using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000498 RID: 1176
	[AttributeUsage(AttributeTargets.Assembly)]
	[Serializable]
	public sealed class DefaultDependencyAttribute : Attribute
	{
		// Token: 0x06002286 RID: 8838 RVA: 0x0004DA44 File Offset: 0x0004BC44
		public DefaultDependencyAttribute(LoadHint loadHintArgument)
		{
			this.loadHint = loadHintArgument;
		}

		// Token: 0x040012E3 RID: 4835
		private LoadHint loadHint;
	}
}
