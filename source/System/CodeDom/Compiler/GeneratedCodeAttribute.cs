using System;

namespace System.CodeDom.Compiler
{
	// Token: 0x020000C6 RID: 198
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	public sealed class GeneratedCodeAttribute : Attribute
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00013470 File Offset: 0x00011670
		public GeneratedCodeAttribute(string tool, string version)
		{
			this.tool = tool;
			this.version = version;
		}

		// Token: 0x0400038B RID: 907
		private readonly string tool;

		// Token: 0x0400038C RID: 908
		private readonly string version;
	}
}
