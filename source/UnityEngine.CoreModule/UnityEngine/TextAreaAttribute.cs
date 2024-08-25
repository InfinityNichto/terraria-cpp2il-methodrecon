using System;

namespace UnityEngine
{
	// Token: 0x02000090 RID: 144
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00005AFC File Offset: 0x00003CFC
		public TextAreaAttribute()
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00005B10 File Offset: 0x00003D10
		public TextAreaAttribute(int minLines, int maxLines)
		{
			this.minLines = minLines;
		}

		// Token: 0x04000328 RID: 808
		public readonly int minLines;

		// Token: 0x04000329 RID: 809
		public readonly int maxLines;
	}
}
