using System;

namespace UnityEngine
{
	// Token: 0x0200008E RID: 142
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x06000283 RID: 643 RVA: 0x00005ACC File Offset: 0x00003CCC
		public RangeAttribute(float min, float max)
		{
		}

		// Token: 0x04000325 RID: 805
		public readonly float min;

		// Token: 0x04000326 RID: 806
		public readonly float max;
	}
}
