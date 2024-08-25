using System;

namespace UnityEngine
{
	// Token: 0x0200008C RID: 140
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00005A7C File Offset: 0x00003C7C
		public SpaceAttribute()
		{
			this.height = (float)16640;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00005A9C File Offset: 0x00003C9C
		public SpaceAttribute(float height)
		{
		}

		// Token: 0x04000323 RID: 803
		public readonly float height;
	}
}
