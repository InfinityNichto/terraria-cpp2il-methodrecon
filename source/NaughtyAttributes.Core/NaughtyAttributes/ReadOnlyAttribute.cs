using System;

namespace NaughtyAttributes
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ReadOnlyAttribute : DrawerAttribute
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000024B8 File Offset: 0x000006B8
		public ReadOnlyAttribute()
		{
		}
	}
}
