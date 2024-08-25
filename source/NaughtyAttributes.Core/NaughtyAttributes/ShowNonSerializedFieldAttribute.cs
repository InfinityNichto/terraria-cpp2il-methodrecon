using System;

namespace NaughtyAttributes
{
	// Token: 0x02000016 RID: 22
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ShowNonSerializedFieldAttribute : DrawerAttribute
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002574 File Offset: 0x00000774
		public ShowNonSerializedFieldAttribute()
		{
		}
	}
}
