using System;

namespace System
{
	// Token: 0x0200013C RID: 316
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoTODOAttribute : Attribute
	{
		// Token: 0x06000CAA RID: 3242 RVA: 0x0001B890 File Offset: 0x00019A90
		public MonoTODOAttribute()
		{
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0001B8A4 File Offset: 0x00019AA4
		public MonoTODOAttribute(string comment)
		{
			this.comment = comment;
		}

		// Token: 0x040004E1 RID: 1249
		private string comment;
	}
}
