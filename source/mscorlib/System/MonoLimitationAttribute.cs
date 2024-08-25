using System;

namespace System
{
	// Token: 0x0200013D RID: 317
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoLimitationAttribute : MonoTODOAttribute
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x0001B8C0 File Offset: 0x00019AC0
		public MonoLimitationAttribute(string comment)
		{
			this.comment = comment;
		}
	}
}
