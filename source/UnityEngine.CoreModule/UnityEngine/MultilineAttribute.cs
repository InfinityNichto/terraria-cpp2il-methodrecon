using System;

namespace UnityEngine
{
	// Token: 0x0200008F RID: 143
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class MultilineAttribute : PropertyAttribute
	{
		// Token: 0x06000284 RID: 644 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public MultilineAttribute()
		{
			this.lines = 3;
		}

		// Token: 0x04000327 RID: 807
		public readonly int lines;
	}
}
