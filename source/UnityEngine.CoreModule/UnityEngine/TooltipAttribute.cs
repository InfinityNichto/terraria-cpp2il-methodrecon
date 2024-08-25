using System;

namespace UnityEngine
{
	// Token: 0x0200008B RID: 139
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public class TooltipAttribute : PropertyAttribute
	{
		// Token: 0x0600027F RID: 639 RVA: 0x00005A60 File Offset: 0x00003C60
		public TooltipAttribute(string tooltip)
		{
			this.tooltip = tooltip;
		}

		// Token: 0x04000322 RID: 802
		public readonly string tooltip;
	}
}
